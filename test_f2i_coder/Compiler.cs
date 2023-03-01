using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
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
                foreach (byte b in binaryData)
                {
                    for (int i = 7; i >= 0; i--)
                    {
                        Boolean bit = (b & (1 << i)) == 0 ? false : true;
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
