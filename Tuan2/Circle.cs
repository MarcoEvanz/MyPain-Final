using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tuan2
{
    internal class Circle : Shape
    {
        public Point rad;
        public Circle() { }

        public Circle(Point sPoint, Point ePoint, int borderWidth, Color borderColor)
        {
            this.location = sPoint;
            this.rad = ePoint;
            this.borderWidth = borderWidth;
            this.borderColor = borderColor;
        }

        public void Draw(Graphics g)
        {
            Pen pen = new Pen(borderColor, borderWidth);

            int radius = Math.Min(rad.X, rad.Y) / 2;
            int centerX = location.X - radius;
            int centerY = location.Y - radius;

            g.DrawEllipse(pen, centerX, centerY, 2 * radius, 2 * radius);
        }
    }
}
