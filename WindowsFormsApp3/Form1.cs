using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// Илья Гавшин 220 Форма

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        private int x = 400;
        private int y = 40;
        private int radius = 1;
        public Form1()
        {
            InitializeComponent();
        }

        private void texRadius_TextChanged(object sender, EventArgs e)
        {
            radius = Int32.Parse(texRadius.Text);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textX_TextChanged(object sender, EventArgs e)
        {
            x = 400 + Int32.Parse(textX.Text);
        }

        private void textY_TextChanged(object sender, EventArgs e)
        {
            y = 40 + Int32.Parse(textY.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Graphics graphics = CreateGraphics();
            graphics.Clear(BackColor);
            graphics.FillEllipse(Brushes.Red, x, y, radius * 2, radius * 2);
            graphics.Dispose();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
