using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace f2i_coder
{
    public partial class Compiler : Form
    {

        byte[] binaryData = null;
        byte[] binaryData_ext = null;
        string fileExtension = "";
        Bitmap bitmap;
        public Compiler()
        {
            InitializeComponent();
        }

        private void Compiler_Load(object sender, EventArgs e)
        {
            save_btn.Enabled = false;
            button1.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            OpenFileDialog openFileDialog = new OpenFileDialog();

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                Stopwatch stopwatch1 = new Stopwatch();
                stopwatch1.Start();
                string filePath = openFileDialog.FileName;
                fileExtension = Path.GetExtension(filePath); // Get the file extension
                binaryData_ext = Encoding.UTF8.GetBytes(fileExtension);
                try
                {
                    using (FileStream fileStream = new FileStream(filePath, FileMode.Open))
                    {
                        
                        using (BinaryReader binaryReader = new BinaryReader(fileStream))
                        {
                            binaryData = binaryReader.ReadBytes((int)fileStream.Length);
                        }
                    }
                    save_btn.Enabled = false;
                    button1.Enabled = true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
                stopwatch1.Stop();
                TimeSpan elapsed1 = stopwatch1.Elapsed;
                info_lbl.Text = "Reading data took " + Math.Round(elapsed1.TotalSeconds, 2, MidpointRounding.ToEven).ToString() + " seconds";

            }

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Stopwatch stopwatch1 = new Stopwatch();
            stopwatch1.Start();
            try
            {
                int totalBytes = binaryData.Length + binaryData_ext.Length; // Total number of bytes

                int numPixels = (totalBytes * 8) + 2; // each byte has 8 bits, add 1 for red pixel
                int imageSize = (int)Math.Ceiling(Math.Sqrt(numPixels)); // calculate image size
                bitmap = new Bitmap(imageSize, imageSize);

                int pixelIndex = 0;
                for (int i = 0; i < binaryData.Length; i++)
                {
                    for (int j = 0; j < 8; j++)
                    {
                        int x = pixelIndex % imageSize;
                        int y = pixelIndex / imageSize;
                        bool bitValue = (binaryData[i] & (1 << (7 - j))) != 0; // get bit value
                        Color pixelColor = bitValue ? Color.White : Color.Black; // set pixel color
                        bitmap.SetPixel(x, y, pixelColor);
                        pixelIndex++;
                    }
                }
                bitmap.SetPixel(pixelIndex % imageSize, pixelIndex / imageSize, Color.Red); // Place red pixel

                pixelIndex++;
                for (int i = 0; i < binaryData_ext.Length; i++)
                {
                    for (int j = 0; j < 8; j++)
                    {
                        int x = pixelIndex % imageSize;
                        int y = pixelIndex / imageSize;
                        bool bitValue = (binaryData_ext[i] & (1 << (7 - j))) != 0; // get bit value
                        Color pixelColor = bitValue ? Color.White : Color.Black; // set pixel color
                        bitmap.SetPixel(x, y, pixelColor);
                        pixelIndex++;
                    }
                }
                bitmap.SetPixel(pixelIndex % imageSize, pixelIndex / imageSize, Color.Red); // Place final red pixel

                pictureBox1.Image = bitmap;
                save_btn.Enabled = true;
                

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            stopwatch1.Stop();
            TimeSpan elapsed1 = stopwatch1.Elapsed;
            info_lbl.Text = "Compiling took " + Math.Round(elapsed1.TotalSeconds, 2, MidpointRounding.ToEven).ToString() + " seconds";

        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "PNG Image|*.png"; // Set the filter to only allow PNG images
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string saveFilePath = saveFileDialog.FileName;
                using (FileStream stream = new FileStream(saveFilePath, FileMode.Create))
                {
                    bitmap.Save(stream, ImageFormat.Png);
                    save_btn.Enabled = false;
                    button1.Enabled = false;
                }
            }
        }
    }
}
