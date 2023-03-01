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

namespace f2i_coder
{
    public partial class Compiler : Form
    {

        byte[] binaryData = null;
        public Compiler()
        {
            InitializeComponent();
        }

        private void Compiler_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            Stopwatch stopwatch1 = new Stopwatch();
            stopwatch1.Start();

            OpenFileDialog openFileDialog = new OpenFileDialog();

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                try
                {
                    using (FileStream fileStream = new FileStream(filePath, FileMode.Open))
                    {
                        using (BinaryReader binaryReader = new BinaryReader(fileStream))
                        {
                            binaryData = binaryReader.ReadBytes((int)fileStream.Length);
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }

            stopwatch1.Stop();
            TimeSpan elapsed1 = stopwatch1.Elapsed;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                int numPixels = binaryData.Length * 8; // each byte has 8 bits
                int imageSize = (int)Math.Ceiling(Math.Sqrt(numPixels)); // calculate image size
                Bitmap bitmap = new Bitmap(imageSize, imageSize);

                for (int i = 0; i < numPixels; i++)
                {
                    int x = i % imageSize;
                    int y = i / imageSize;
                    bool bitValue = (binaryData[i / 8] & (1 << (7 - (i % 8)))) != 0; // get bit value
                    Color pixelColor = bitValue ? Color.White : Color.Black; // set pixel color
                    bitmap.SetPixel(x, y, pixelColor);
                }

                bitmap.Save("output.png", ImageFormat.Png);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
