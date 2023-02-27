using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using test_f2i_coder;

namespace f2i_coder
{
    public partial class f2i : Form
    {
        public f2i()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var compileForm = new Compiler();
            compileForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var decompileForm = new Form1();
            decompileForm.Show();
        }
    }
}
