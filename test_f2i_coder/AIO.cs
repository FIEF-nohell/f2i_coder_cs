using System;
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
        bool currentlyUsing = false;
        byte[] c_binaryData = null;
        byte[] c_binaryData_ext = null;
        string c_fileExtension = "";
        Bitmap c_bitmap;


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

        private void d_select_file_Click(object sender, EventArgs e)
        {
            //decompiler select file
            try
            {

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

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

    }
}
