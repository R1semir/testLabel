using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace testt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            int kalan = Convert.ToInt16(label2.Text);
            kalan--;           
            label2.Text = kalan.ToString();
            if(kalan == 0)
            {
                textBox1.Enabled = false;
            }
        }
    }
}
