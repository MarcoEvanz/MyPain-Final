using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tuan2
{
    internal class CirclePattern : Circle
    {
        public Color brColor;
        public CirclePattern(Point sPoint, Point ePoint, int borderWidth, Color borderColor, Color brushColor)
        {
            this.location = sPoint;
            this.rad = ePoint;
            this.borderWidth = borderWidth;
            this.borderColor = borderColor;
            this.brColor = brushColor;
        }

        public void Draw(Graphics g)
        {
            Pen pen = new Pen(borderColor, borderWidth);
            HatchBrush brush = new HatchBrush(HatchStyle.SmallGrid, borderColor, brColor);

            int radius = Math.Min(rad.X, rad.Y) / 2;
            int centerX = location.X - radius;
            int centerY = location.Y - radius;



            g.DrawEllipse(pen, centerX, centerY, 2 * radius, 2 * radius);
            g.FillEllipse(brush, centerX, centerY, 2 * radius, 2 * radius);
        }
    }
}
