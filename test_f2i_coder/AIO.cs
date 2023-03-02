﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace f2i_coder
{
    public partial class AIO : Form
    {
        public AIO()
        {
            InitializeComponent();
        }

        private void AIO_Load(object sender, EventArgs e)
        {
            c_compile_data.Enabled = false;
            c_save_image.Enabled = false;

            d_decompile_data.Enabled = false;
            d_save_file.Enabled = false;

            c_select_info.Visible = false;
            c_compile_info.Visible = false;
            c_save_info.Visible = false;

            d_select_info.Visible = false;
            d_decompile_info.Visible = false;
            d_save_info.Visible = false;

        }

        // ----- Variables -----
        byte[] c_binaryData = null;
        byte[] c_binaryData_ext = null;
        string c_fileExtension = "";
        Bitmap c_bitmap;

        Bitmap d_bmp = null;
        BitArray d_file_data_global = new BitArray(0);
        BitArray d_ext_data_global = new BitArray(0);

        // ----- COMPILER SECTION -----

        private void compiler_save_image()
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "PNG Image|*.png"; // Set the filter to only allow PNG images
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string saveFilePath = saveFileDialog.FileName;
                using (FileStream stream = new FileStream(saveFilePath, FileMode.Create))
                {
                    c_bitmap.Save(stream, ImageFormat.Png);
                    c_bitmap = null;
                }
            }
        }

        private void compiler_compile()
        {
            int totalBytes = c_binaryData.Length + c_binaryData_ext.Length; // Total number of bytes

            int numPixels = (totalBytes * 8) + 2; // each byte has 8 bits, add 1 for red pixel
            int imageSize = (int)Math.Ceiling(Math.Sqrt(numPixels)); // calculate image size
            c_bitmap = new Bitmap(imageSize, imageSize);

            int pixelIndex = 0;
            for (int i = 0; i < c_binaryData.Length; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    int x = pixelIndex % imageSize;
                    int y = pixelIndex / imageSize;
                    bool bitValue = (c_binaryData[i] & (1 << (7 - j))) != 0; // get bit value
                    Color pixelColor = bitValue ? Color.White : Color.Black; // set pixel color
                    c_bitmap.SetPixel(x, y, pixelColor);
                    pixelIndex++;
                }
            }
            c_bitmap.SetPixel(pixelIndex % imageSize, pixelIndex / imageSize, Color.Red); // Place red pixel

            pixelIndex++;
            for (int i = 0; i < c_binaryData_ext.Length; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    int x = pixelIndex % imageSize;
                    int y = pixelIndex / imageSize;
                    bool bitValue = (c_binaryData_ext[i] & (1 << (7 - j))) != 0; // get bit value
                    Color pixelColor = bitValue ? Color.White : Color.Black; // set pixel color
                    c_bitmap.SetPixel(x, y, pixelColor);
                    pixelIndex++;
                }
            }
            c_bitmap.SetPixel(pixelIndex % imageSize, pixelIndex / imageSize, Color.Red); // Place final red pixel
            pictureBox1.Image = c_bitmap;
        }

        private void compiler_input_file()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                c_fileExtension = Path.GetExtension(filePath); // Get the file extension
                c_binaryData_ext = Encoding.UTF8.GetBytes(c_fileExtension);

                using (FileStream fileStream = new FileStream(filePath, FileMode.Open))
                {

                    using (BinaryReader binaryReader = new BinaryReader(fileStream))
                    {
                        c_binaryData = binaryReader.ReadBytes((int)fileStream.Length);
                    }
                }
            }
        }

        private void c_select_file_Click(object sender, EventArgs e)
        {
            //compiler select file
            try
            {
                pictureBox1.Image = null;
                c_binaryData = null;
                c_compile_info.Visible = false;
                c_save_info.Visible = false;
                c_select_info.Visible = false;
                c_compile_data.Enabled = false;
                c_save_image.Enabled = false;
                compiler_input_file();

                if(c_binaryData != null)
                {
                    c_compile_data.Enabled = true;
                    c_select_info.Visible = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void c_compile_data_Click(object sender, EventArgs e)
        {
            //compiler compile data
            try
            {
                c_save_info.Visible = false;
                compiler_compile();
                c_save_image.Enabled = true;
                c_compile_info.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void c_save_image_Click(object sender, EventArgs e)
        {
            //compiler save image
            try
            {
                compiler_save_image();
                if(c_bitmap == null)
                {
                    c_save_image.Enabled = false;
                    c_compile_data.Enabled = false;
                    c_save_info.Visible = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        // ----- DECOMPILER SECTION -----

        private void decompiler_decompile()
        {
            int pixels = d_bmp.Height * d_bmp.Width;
            int bytes_read = 0;
            int red_bytes_read = 0;
            int separator_counter = 0;
            BitArray file_data = new BitArray(pixels);
            BitArray ext_data = new BitArray(100);

            for (int y = 0; y < d_bmp.Height; y++)
            {
                for (int x = 0; x < d_bmp.Width; x++)
                {
                    Color color = d_bmp.GetPixel(x, y);
                    int r = color.R;
                    if (r == 169)
                    {
                        separator_counter++;
                        if (separator_counter == 2) break;
                    }
                    if (r == 0)
                    {
                        if (separator_counter == 0) file_data.Set(bytes_read, false);
                        else if (separator_counter == 1) ext_data.Set(red_bytes_read, false);
                    }
                    if (r == 255)
                    {
                        if (separator_counter == 0) file_data.Set(bytes_read, true);
                        else if (separator_counter == 1) ext_data.Set(red_bytes_read, true);
                    }
                    bytes_read++;
                    if (separator_counter >= 1) red_bytes_read++;
                }
                if (separator_counter == 2) break;
            }

            d_file_data_global = file_data;

            // Calculate the number of bytes needed to store the bit array
            int numBytes = d_file_data_global.Count / 8;
            if (d_file_data_global.Count % 8 != 0) numBytes++;

            // Create a new byte array to store the converted bits
            byte[] byteArray = new byte[numBytes];

            // Loop through the bit array, setting each byte in the byte array
            int byteIndex = 0;
            int bitIndex = 0;
            for (int i = 0; i < d_file_data_global.Count; i++)
            {
                if (d_file_data_global[i])
                {
                    byteArray[byteIndex] |= (byte)(1 << (7 - bitIndex));
                }

                bitIndex++;
                if (bitIndex == 8)
                {
                    byteIndex++;
                    bitIndex = 0;
                }
            }
        }

        private void decompiler_select_file()
        {
            // open file dialog   
            OpenFileDialog open = new OpenFileDialog();
            // image filters  
            open.Filter = "Allowed types: (*.png)|*.png";
            if (open.ShowDialog() == DialogResult.OK)
            {
                // display image in picture box  
                d_bmp = new Bitmap(open.FileName);
                pictureBox2.Image = d_bmp;
            }
        }

        private void decompiler_save_file()
        {
            Stopwatch stopwatch2 = new Stopwatch();
            stopwatch2.Start();
            // Convert the BitArray to a byte array
            List<byte> byteList = new List<byte>();
            byte currentByte = 0;
            int bitCount = 0;

            foreach (bool bit in d_file_data_global)
            {
                currentByte <<= 1;
                if (bit)
                {
                    currentByte |= 1;
                }
                bitCount++;
                if (bitCount == 8)
                {
                    byteList.Add(currentByte);
                    currentByte = 0;
                    bitCount = 0;
                }
            }

            if (bitCount > 0)
            {
                currentByte <<= (8 - bitCount);
                byteList.Add(currentByte);
            }

            byte[] data = byteList.ToArray();

            // Create a dialog box to select the output location and filename
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Title = "Save File";
            saveFileDialog1.ShowDialog();

            // If the user selects a file location and name, save the file
            if (saveFileDialog1.FileName != "")
            {
                // Write the binary data to the selected file
                using (FileStream fs = new FileStream(saveFileDialog1.FileName, FileMode.Create, FileAccess.Write))
                {
                    fs.Write(data, 0, data.Length);
                    d_file_data_global = null;
                }
            }

        }

        private void d_select_file_Click(object sender, EventArgs e)
        {
            //decompiler select file
            try
            {
                d_bmp = null;
                pictureBox2.Image = null;
                d_decompile_info.Visible = false;
                d_save_info.Visible = false;
                d_select_info.Visible = false;
                d_decompile_data.Enabled = false;
                d_save_file.Enabled = false;
                decompiler_select_file();
                if(d_bmp != null)
                {
                    d_decompile_data.Enabled = true;
                    d_select_info.Visible = true;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void d_decompile_data_Click(object sender, EventArgs e)
        {
            //decompiler decompile data
            try
            {
                d_save_info.Visible = false;
                decompiler_decompile();
                d_save_file.Enabled = true;
                d_decompile_info.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void d_save_file_Click(object sender, EventArgs e)
        {
            //decompiler save file
            try
            {
                decompiler_save_file();
                if(d_file_data_global == null)
                {
                    d_save_file.Enabled = false;
                    d_decompile_data.Enabled = false;
                    d_save_info.Visible = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

    }
}
