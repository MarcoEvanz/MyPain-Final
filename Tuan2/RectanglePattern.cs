using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tuan2
{
    internal class RectanglePattern : Rectangle
    {
        public Color brColor;
        public RectanglePattern(Point sPoint, Point ePoint, int borderWidth, Color borderColor, Color brushColor)
        {
            this.location = sPoint;
            this.width = ePoint.X;
            this.height = ePoint.Y;
            this.borderWidth = borderWidth;
            this.borderColor = borderColor;
            this.brColor = brushColor;
        }

        
        public void Draw(Graphics g)
        {
            Pen pen = new Pen(borderColor, borderWidth);
            HatchBrush brush = new HatchBrush(HatchStyle.SmallGrid, borderColor, brColor);
            int x = location.X < width ? location.X : width;
            int y = location.Y < height ? location.Y : height;
            int w = Math.Abs(location.X - width);
            int h = Math.Abs(location.Y - height);

            g.DrawRectangle(pen, x, y,w,h);
            g.FillRectangle(brush, x, y, w, h); ;
        }
    }
}
