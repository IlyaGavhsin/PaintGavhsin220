using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3
{
    public class Figure
    {
        protected int x;
        protected int y;

        public Figure(int newX, int newY)
        {
            x = newX;
            y = newY;
        }

        public virtual void Draw(Graphics pap, Pen pen) { }

        public override string ToString()
        {
            return base.ToString() + $";X={x};Y={y};";
        }
    }

    public class Line : Figure
    {
        protected int x2;
        protected int y2;

        public Line(int newX, int newY, int newX2, int newY2) : base(newX, newY)
        {
            x2 = newX2;
            y2 = newY2;
        }

        public override void Draw(Graphics pap, Pen pen)
        {
            pap.DrawLine(pen, x, y, x2, y2);
        }

        public override string ToString()
        {
            return base.ToString() + $"X2={x2};Y2={y2};";
        }
    }

    public class Circle : Figure
    {
        protected int r;

        public Circle(int newX, int newY, int newR) : base(newX, newY)
        {
            r = newR;
        }

        public override void Draw(Graphics pap, Pen pen)
        {
            pap.DrawEllipse(pen, x, y, r, r);
        }

        public override string ToString()
        {
            return base.ToString() + $"R={r}";
        }
    }
    public class Rectangle : Figure
    {
        protected int h;
        protected int w;

        public Rectangle(int newX, int newY, int newH, int newW) : base(newX, newY)
        {
            h = newH;
            w = newW;
        }

        public override void Draw(Graphics pap, Pen pen)
        {
            pap.DrawRectangle(pen, x, y, w, h);
        }

        public override string ToString()
        {
            return base.ToString() + $"W={w} H={h}";
        }
    }

    public class Triangle : Figure
    {
        protected int w;

        public Triangle(int newX, int newY, int newW) : base(newX, newY)
        {
            w = newW;
        }

        public override void Draw(Graphics pap, Pen pen)
        {
            pap.DrawLine(pen, x, y, x + w, y + w);
            pap.DrawLine(pen, x, y, x - w, y + w);
            pap.DrawLine(pen, x - w, y + w, x + w, y + w);
        }

        public override string ToString()
        {
            return base.ToString() + $"W={w}";
        }
    }
}
