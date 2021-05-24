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
        private Figure fig = null;
        Color mainCol = Color.Black;

        Graphics paper;
        Pen pen;

        int radius;
        int height;
        int weight;
        int stroke;

        int lineX = 0;
        int lineY = 0;
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
            pen = new Pen(mainCol, 5);
            switch (curFig)
            {
                case TypeFigure.Circle:
                    radius = Convert.ToInt32(paramDatas.Rows[0].Cells[1].Value);
                    stroke = Convert.ToInt32(paramDatas.Rows[1].Cells[1].Value);
                    fig = new Circle(e.X, e.Y, radius);
                    pen.Width = stroke;
                    fig.Draw(paper, pen);
                    break;

                case TypeFigure.Rectangle:
                    height = Convert.ToInt32(paramDatas.Rows[0].Cells[1].Value);
                    weight = Convert.ToInt32(paramDatas.Rows[1].Cells[1].Value);
                    stroke = Convert.ToInt32(paramDatas.Rows[2].Cells[1].Value);
                    fig = new Rectangle(e.X, e.Y, height, weight);
                    pen.Width = stroke;
                    fig.Draw(paper, pen);
                    break;

                case TypeFigure.Line:
                    weight = Convert.ToInt32(paramDatas.Rows[0].Cells[1].Value);
                    stroke = Convert.ToInt32(paramDatas.Rows[1].Cells[1].Value);
                    lineX = e.X;
                    lineY = e.Y;

                    pen.Width = stroke;
                    fig = new Line(e.X + weight, e.Y + weight, e.X, e.Y);
                    fig.Draw(paper, pen);
                    break;

                case TypeFigure.Triangle:
                    weight = Convert.ToInt32(paramDatas.Rows[0].Cells[1].Value);
                    stroke = Convert.ToInt32(paramDatas.Rows[1].Cells[1].Value);

                    pen.Width = stroke;

                    fig = new Triangle(e.X, e.Y, weight);
                    fig.Draw(paper, pen) ;
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

        private void label3_Click(object sender, EventArgs e)
        {
            curFig = TypeFigure.Line;
            Line_Mode();
            panelCircle.BackColor = Color.Transparent;
            panelLine.BackColor = Color.WhiteSmoke;
            panelRec.BackColor = Color.Transparent;
            panelTrin.BackColor = Color.Transparent;

        }

        private void label5_Click(object sender, EventArgs e)
        {
            curFig = TypeFigure.Rectangle;
            Rectangle_Mode();

            panelCircle.BackColor = Color.Transparent;
            panelLine.BackColor = Color.Transparent;
            panelRec.BackColor = Color.WhiteSmoke;
            panelTrin.BackColor = Color.Transparent;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            curFig = TypeFigure.Line;
            Line_Mode();
            panelCircle.BackColor = Color.Transparent;
            panelLine.BackColor = Color.WhiteSmoke;
            panelRec.BackColor = Color.Transparent;
            panelTrin.BackColor = Color.Transparent;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            curFig = TypeFigure.Rectangle;
            Rectangle_Mode();
            panelCircle.BackColor = Color.Transparent;
            panelLine.BackColor = Color.Transparent;
            panelRec.BackColor = Color.WhiteSmoke;
            panelTrin.BackColor = Color.Transparent;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            curFig = TypeFigure.Triangle;
            Triangle_Mode();
            panelCircle.BackColor = Color.Transparent;
            panelLine.BackColor = Color.Transparent;
            panelRec.BackColor = Color.Transparent;
            panelTrin.BackColor = Color.WhiteSmoke;
        }

        #region
        private void label4_Click(object sender, EventArgs e)
        {
            curFig = TypeFigure.Triangle;
            Triangle_Mode();
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
            Circle_Mode();
            panelCircle.BackColor = Color.WhiteSmoke;
            panelLine.BackColor = Color.Transparent;
            panelRec.BackColor = Color.Transparent;
            panelTrin.BackColor = Color.Transparent;
        }

        private void imgCircle_Click(object sender, EventArgs e)
        {
            curFig = TypeFigure.Circle;
            Circle_Mode();
            panelCircle.BackColor = Color.WhiteSmoke;
            panelLine.BackColor = Color.Transparent;
            panelRec.BackColor = Color.Transparent;
            panelTrin.BackColor = Color.Transparent;
        }
        private void label1_Click_1(object sender, EventArgs e)
        {
            curFig = TypeFigure.Circle;

            Circle_Mode();
            panelCircle.BackColor = Color.WhiteSmoke;
            panelLine.BackColor = Color.Transparent;
            panelRec.BackColor = Color.Transparent;
            panelTrin.BackColor = Color.Transparent;

        }
        private void Circle_Mode()
        {

            paramDatas.Rows.Clear();
            paramDatas.Rows.Add();
            paramDatas.Rows[0].Cells[0].Value = "Radius";
            paramDatas.Rows[0].Cells[1].Value = 50;
            paramDatas.Rows.Add();
            paramDatas.Rows[1].Cells[0].Value = "Stroke";
            paramDatas.Rows[1].Cells[1].Value = 10;
        }

        private void Triangle_Mode()
        {
            paramDatas.Rows.Clear();
            paramDatas.Rows.Add();
            paramDatas.Rows[0].Cells[0].Value = "Weight";
            paramDatas.Rows[0].Cells[1].Value = 250;
            paramDatas.Rows.Add();
            paramDatas.Rows[1].Cells[0].Value = "Stroke";
            paramDatas.Rows[1].Cells[1].Value = 10;
        }
        private void Rectangle_Mode()
        {
            paramDatas.Rows.Clear();
            paramDatas.Rows.Add();
            paramDatas.Rows[0].Cells[0].Value = "Height";
            paramDatas.Rows[0].Cells[1].Value = 50;

            paramDatas.Rows.Add();
            paramDatas.Rows[1].Cells[0].Value = "Weight";
            paramDatas.Rows[1].Cells[1].Value = 100;

            paramDatas.Rows.Add();
            paramDatas.Rows[2].Cells[0].Value = "Stroke";
            paramDatas.Rows[2].Cells[1].Value = 10;
        }
        private void Line_Mode()
        {
            paramDatas.Rows.Clear();

            paramDatas.Rows.Add();
            paramDatas.Rows[0].Cells[0].Value = "Stroke";
            paramDatas.Rows[0].Cells[1].Value = 10;

            paramDatas.Rows.Add();
            paramDatas.Rows[1].Cells[0].Value = "Weight";
            paramDatas.Rows[1].Cells[1].Value = 100;
        }



        private void panelLine_MouseClick(object sender, MouseEventArgs e)
        {
            curFig = TypeFigure.Line;
            Line_Mode();
            panelCircle.BackColor = Color.Transparent;
            panelLine.BackColor = Color.WhiteSmoke;
            panelRec.BackColor = Color.Transparent;
            panelTrin.BackColor = Color.Transparent;
        }

        private void panelRec_MouseClick(object sender, MouseEventArgs e)
        {
            curFig = TypeFigure.Rectangle;
            Rectangle_Mode();
            panelCircle.BackColor = Color.Transparent;
            panelLine.BackColor = Color.Transparent;
            panelRec.BackColor = Color.WhiteSmoke;
            panelTrin.BackColor = Color.Transparent;
        }

        private void panelTrin_MouseClick(object sender, MouseEventArgs e)
        {
            curFig = TypeFigure.Triangle;
            Triangle_Mode();
            panelCircle.BackColor = Color.Transparent;
            panelLine.BackColor = Color.Transparent;
            panelRec.BackColor = Color.Transparent;
            panelTrin.BackColor = Color.WhiteSmoke;
        }
        private void colorBtn_click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            mainCol = colorDialog1.Color;
        }

    }
    
}
