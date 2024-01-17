using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tuan2
{
    internal class Rectangle : Shape
    {
        public int width;
        public int height;

        // Constructor mặc định
        public Rectangle(){}

        // Constructor với tham số
        public Rectangle(Point sPoint, Point ePoint, int borderWidth, Color borderColor)
        {
            this.location = sPoint;
            this.width = ePoint.X;
            this.height = ePoint.Y;
            this.borderWidth = borderWidth;
            this.borderColor = borderColor;
        }

        //Phương thức vẽ hình chữ nhật
        public void Draw(Graphics g)
        {
            Pen pen = new Pen(borderColor, borderWidth);
            int x = location.X < width ? location.X : width;
            int y = location.Y < height ? location.Y : height;
            int w = Math.Abs(location.X - width);
            int h = Math.Abs(location.Y - height);

            
            g.DrawRectangle(pen, x, y, w, h);
        }
        //Phuong thuc ve hcn filled 
        //public void DrawFill(Graphics g)
        //{
        //    Pen pen = new Pen(BorderColor, BorderWidth);
        //    SolidBrush fillPen = new SolidBrush(FillColor);
        //    g.DrawRectangle(pen, Location.X, Location.Y, Width, Height);
        //    g.FillRectangle(fillPen, Location.X, Location.Y, Width, Height);
        //    pen.Dispose();
        //}
    }
}
