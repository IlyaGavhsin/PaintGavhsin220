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
    public enum TypeFigure
    {
        Null,
        Rectangle,
        Circle,
        Line,
        Triangle
    }
    public partial class Form1 : Form
    {
        
        private TypeFigure curFig = TypeFigure.Null;
        Color mainCol;

        Graphics paper;
        Pen pen;
        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_MouseClicks(object sender, MouseEventArgs e)
        {
            if (curFig == TypeFigure.Null) return;
            Draw(e);
        }
        private void Draw(MouseEventArgs e)
        {
            paper = panel1.CreateGraphics();
            pen = new Pen(Color.Black, 5);
            switch (curFig)
            {
                case TypeFigure.Circle:
                    paper.DrawEllipse(pen, e.X, e.Y, 50, 50);
                    break;
                case TypeFigure.Rectangle:
                    paper.DrawRectangle(pen, e.X, e.Y, 100, 100);
                    break;
                case TypeFigure.Line:
                    paper.DrawLine(pen, e.X, e.Y, e.X + 100, e.Y + 100);
                    break;
                case TypeFigure.Triangle:
                    paper.DrawLine(pen, e.X, e.Y, e.X + 51, e.Y + 51);
                    paper.DrawLine(pen, e.X, e.Y, e.X - 51, e.Y + 51);
                    paper.DrawLine(pen, e.X - 51, e.Y + 51, e.X + 51, e.Y + 51);
                    break;

            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {
            paper.Clear(Color.WhiteSmoke);
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            curFig = TypeFigure.Circle;
            panelCircle.BackColor = Color.WhiteSmoke;
            panelLine.BackColor = Color.Transparent;
            panelRec.BackColor = Color.Transparent;
            panelTrin.BackColor = Color.Transparent;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            curFig = TypeFigure.Line;
            panelCircle.BackColor = Color.Transparent;
            panelLine.BackColor = Color.WhiteSmoke;
            panelRec.BackColor = Color.Transparent;
            panelTrin.BackColor = Color.Transparent;

        }

        private void label5_Click(object sender, EventArgs e)
        {
            curFig = TypeFigure.Rectangle;
            panelCircle.BackColor = Color.Transparent;
            panelLine.BackColor = Color.Transparent;
            panelRec.BackColor = Color.WhiteSmoke;
            panelTrin.BackColor = Color.Transparent;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            curFig = TypeFigure.Line;
            panelCircle.BackColor = Color.Transparent;
            panelLine.BackColor = Color.WhiteSmoke;
            panelRec.BackColor = Color.Transparent;
            panelTrin.BackColor = Color.Transparent;
        }

        private void imgCircle_Click(object sender, EventArgs e)
        {
            curFig = TypeFigure.Circle;
            panelCircle.BackColor = Color.WhiteSmoke;
            panelLine.BackColor = Color.Transparent;
            panelRec.BackColor = Color.Transparent;
            panelTrin.BackColor = Color.Transparent;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            curFig = TypeFigure.Rectangle;
            panelCircle.BackColor = Color.Transparent;
            panelLine.BackColor = Color.Transparent;
            panelRec.BackColor = Color.WhiteSmoke;
            panelTrin.BackColor = Color.Transparent;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            curFig = TypeFigure.Triangle;
            panelCircle.BackColor = Color.Transparent;
            panelLine.BackColor = Color.Transparent;
            panelRec.BackColor = Color.Transparent;
            panelTrin.BackColor = Color.WhiteSmoke;
        }

        #region
        private void label4_Click(object sender, EventArgs e)
        {
            curFig = TypeFigure.Triangle;
            panelCircle.BackColor = Color.Transparent;
            panelLine.BackColor = Color.Transparent;
            panelRec.BackColor = Color.Transparent;
            panelTrin.BackColor = Color.WhiteSmoke;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox8_Enter(object sender, EventArgs e)
        {

        }

        private void panelCircle_Paint(object sender, PaintEventArgs e)
        {

        }

#endregion

        private void panelCircle_MouseClick(object sender, MouseEventArgs e)
        {
            curFig = TypeFigure.Circle;
            panelCircle.BackColor = Color.WhiteSmoke;
            panelLine.BackColor = Color.Transparent;
            panelRec.BackColor = Color.Transparent;
            panelTrin.BackColor = Color.Transparent;
        }

        private void panelLine_MouseClick(object sender, MouseEventArgs e)
        {
            curFig = TypeFigure.Line;
            panelCircle.BackColor = Color.Transparent;
            panelLine.BackColor = Color.WhiteSmoke;
            panelRec.BackColor = Color.Transparent;
            panelTrin.BackColor = Color.Transparent;
        }

        private void panelRec_MouseClick(object sender, MouseEventArgs e)
        {
            curFig = TypeFigure.Rectangle;
            panelCircle.BackColor = Color.Transparent;
            panelLine.BackColor = Color.Transparent;
            panelRec.BackColor = Color.WhiteSmoke;
            panelTrin.BackColor = Color.Transparent;
        }

        private void panelTrin_MouseClick(object sender, MouseEventArgs e)
        {
            curFig = TypeFigure.Triangle;
            panelCircle.BackColor = Color.Transparent;
            panelLine.BackColor = Color.Transparent;
            panelRec.BackColor = Color.Transparent;
            panelTrin.BackColor = Color.WhiteSmoke;
        }
        private void colorBtn_click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            colorDialog1.FullOpen = true;

            colorBtn.BackColor = colorDialog1.Color;
        }
    }
    
}
