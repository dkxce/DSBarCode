using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            barCodeCtrl1.BarCode = textBox1.Text;
            pictureBox1.Image = barCodeCtrl1.ToBarImage((int)numericUpDown2.Value, (int)numericUpDown1.Value);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1_TextChanged(sender, e);
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            textBox1_TextChanged(sender, e);
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            textBox1_TextChanged(sender, e);
        }
    }
}
