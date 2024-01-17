using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tuan2
{
    internal abstract class Shape
    {
        public Point location;
        public int borderWidth;
        public Color borderColor;

        public void Draw() { }
    }
}
