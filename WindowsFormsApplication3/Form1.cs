using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ColorContrastTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label1.Parent = pictureBox1;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            SetNewColors();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            SetNewColors();
        }
        
        private void SetNewColors()
        {
            colorDialog1.ShowDialog();
            pictureBox1.BackColor = colorDialog1.Color;

            //https://en.wikipedia.org/wiki/YIQ
            int yiq = ((colorDialog1.Color.R * 299) + (colorDialog1.Color.G * 596) + (colorDialog1.Color.B * 211)) / 1000;

            label1.ForeColor = (yiq >= 128) ? Color.Black : Color.White;
        }
    }
}
