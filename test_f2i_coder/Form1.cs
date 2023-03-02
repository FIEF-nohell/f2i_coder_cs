using System.Collections;
using System.Diagnostics;
using System.Text;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.IO;

namespace test_f2i_coder
{
    public partial class Form1 : Form
    {
        Bitmap bmp = null;
        BitArray file_data_global = new BitArray(0);
        BitArray ext_data_global = new BitArray(0);
        public Form1()
        {
            InitializeComponent();
        }

        public void createFile()
        {
            Stopwatch stopwatch2 = new Stopwatch();
            stopwatch2.Start();
            // Convert the BitArray to a byte array
            List<byte> byteList = new List<byte>();
            byte currentByte = 0;
            int bitCount = 0;

            foreach (bool bit in file_data_global)
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

            // Write the binary data to a file
            using (FileStream fs = new FileStream(textBox1.Text, FileMode.Create, FileAccess.Write))
            {
                fs.Write(data, 0, data.Length);
            }

            stopwatch2.Stop();
            TimeSpan elapsed = stopwatch2.Elapsed;

            info_lbl.Text = "Decompiled in " + Math.Round(elapsed.TotalSeconds, 2, MidpointRounding.ToEven).ToString() + " seconds!";
            decode_btn.Enabled = false;
            button1.Enabled = false;
        }

        public void scanImage()
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            int pixels = bmp.Height * bmp.Width;
            int bytes_read = 0;
            int red_bytes_read = 0;
            int separator_counter = 0;
            BitArray file_data = new BitArray(pixels);
            BitArray ext_data = new BitArray(100);

            for (int y = 0; y < bmp.Height; y++)
            {
                for (int x = 0; x < bmp.Width; x++)
                {
                    Color color = bmp.GetPixel(x, y);
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
                    if(separator_counter >= 1) red_bytes_read++;
                }
                if (separator_counter == 2) break;
            }

            stopwatch.Stop();
            TimeSpan elapsed = stopwatch.Elapsed;
            info_lbl.Text = "Reading data took " + Math.Round(elapsed.TotalSeconds, 2, MidpointRounding.ToEven).ToString() + " Seconds";

            file_data_global = file_data;

            // Calculate the number of bytes needed to store the bit array
            int numBytes = file_data_global.Count / 8;
            if (file_data_global.Count % 8 != 0) numBytes++;

            // Create a new byte array to store the converted bits
            byte[] byteArray = new byte[numBytes];

            // Loop through the bit array, setting each byte in the byte array
            int byteIndex = 0;
            int bitIndex = 0;
            for (int i = 0; i < file_data_global.Count; i++)
            {
                if (file_data_global[i])
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
            info_lbl.Text = Encoding.UTF8.GetString(byteArray);
            ext_data_global = ext_data;
            button1.Enabled = true;
        }

        public void LoadBitmap()
        {
            // open file dialog   
            OpenFileDialog open = new OpenFileDialog();
            // image filters  
            open.Filter = "Allowed types: (*.jpg; *.png)|*.jpg; *.png";
            if (open.ShowDialog() == DialogResult.OK)
            {
                Stopwatch stopwatch1 = new Stopwatch();
                stopwatch1.Start();
                // display image in picture box  
                bmp = new Bitmap(open.FileName);
                pictureBox1.Image = bmp;
                stopwatch1.Stop();
                TimeSpan elapsed1 = stopwatch1.Elapsed;
                info_lbl.Text = bmp.Width.ToString() + " x " + bmp.Height.ToString() + " px loaded in " + Math.Round(elapsed1.TotalSeconds, 2,MidpointRounding.ToEven).ToString() + " Seconds";
                decode_btn.Enabled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                button1.Text = "Create file";
                LoadBitmap();
            }
            catch
            {
                MessageBox.Show("Error while loading the image.");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            decode_btn.Enabled = false;
            button1.Enabled = false;
        }

        private void decode_btn_Click(object sender, EventArgs e)
        {
            if (bmp != null)
            {
                try
                {
                    scanImage();
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            else MessageBox.Show("No image to decompile.");
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (bmp != null)
            {
                try
                {
                    createFile();
                }
                catch
                {
                    MessageBox.Show("Error creating file: " + textBox1.Text);
                }
                createFile();
            }
            else MessageBox.Show("No image to decompile."); 
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}