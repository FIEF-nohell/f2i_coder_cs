using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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

        // ----- COMPILER SECTION -----

        private void c_select_file_Click(object sender, EventArgs e)
        {
            //compiler select file
            try
            {

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
