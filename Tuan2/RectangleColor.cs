using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tuan2
{
    internal class RectangleColor : Rectangle
    {
        public Color FillColor;


        // Constructor với tham số
        public RectangleColor(Point sPoint, Point ePoint, int borderWidth, Color borderColor, Color fillColor)
        {
            this.location = sPoint;
            this.width = ePoint.X;
            this.height = ePoint.Y;
            this.borderWidth = borderWidth;
            this.borderColor = borderColor;
            this.FillColor = fillColor;
        }
        //Phuong thuc ve hcn filled 
        public void Draw(Graphics g)
        {
            Pen pen = new Pen(borderColor, borderWidth);
            Brush brush = new SolidBrush(FillColor);
            int x = location.X < width ? location.X : width;
            int y = location.Y < height ? location.Y : height;
            int w = Math.Abs(location.X - width);
            int h = Math.Abs(location.Y - height);

            g.FillRectangle(brush, x, y, w, h);
            g.DrawRectangle(pen, x, y, w, h);
            

        }
    }
}
