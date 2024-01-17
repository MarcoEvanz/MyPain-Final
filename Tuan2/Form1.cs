using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tuan2
{
    public partial class Form1 : Form
    {

        private Graphics _graphic;
        private Point _aPoint;
        private Point _sPoint;
        private bool _moving;
        private LinkedList<Rectangle> _rectangles;
        private LinkedList<Circle> _circles;
        private LinkedList<RectangleColor> _rectanglesColors;
        private LinkedList<RectanglePattern> _rectanglesPatterns;
        private LinkedList<CircleColor> _circlesColors;
        private LinkedList<CirclePattern> _circlesPatterns;
        public Form1()
        {
            InitializeComponent();

            //Khởi tạo panel
            _graphic = mainPanel.CreateGraphics();
            //Tạo nét vẽ
            _aPoint = new Point(-1, -1);
            _sPoint = new Point(-1, -1);
            //Hàm Kiểm Tra Di Chuyển
            _moving = false;
            //Tạo Hàm Vẽ Hình Chữ Nhật
            _rectangles = new LinkedList<Rectangle>();
            //Tạo hàm Vẽ Hình Tròn
            _circles = new LinkedList<Circle>();
            //Ve hinh chu nhat fill
            _rectanglesColors = new LinkedList<RectangleColor>();
            //Ve hinh chu nhat pattern
            _rectanglesPatterns = new LinkedList<RectanglePattern>();
            //ve hinh tron fill color
            _circlesColors = new LinkedList<CircleColor>();
            //Ve hinh tron pattern
            _circlesPatterns = new LinkedList<CirclePattern>();
            //Khien net ve mac dinh la 1
            inpPenWidth.Value = 1;
            //Khiến vẽ hình vuông là mặc định
            rbRectangle.Checked = true;
            rbNoFill.Checked = true;
        }

        private void cdPenColor_HelpRequest(object sender, EventArgs e)
        {

        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            if (cdPenColor.ShowDialog() == DialogResult.OK)
            {
                lblColor.ForeColor = cdPenColor.Color;
            }
        }

        private void mainPanel_MouseDown(object sender, MouseEventArgs e)
        {
            _sPoint = e.Location;
            _moving = true;
        }

        private void mainPanel_MouseUp(object sender, MouseEventArgs e)
        {
            int penWidth = (int)inpPenWidth.Value;
            Color penColor = cdPenColor.Color;
            if (rbRectangle.Checked)
            {
                if (rbNoFill.Checked)
                {
                    Rectangle rect = new Rectangle(_sPoint, e.Location, penWidth, penColor);
                    _rectangles.AddLast(rect);
                }

                if (rbColorFill.Checked)
                {
                    Color brushColor = cdBrushColor.Color;
                    RectangleColor colorrect = new RectangleColor(_sPoint, e.Location, penWidth, penColor, brushColor);
                    _rectanglesColors.AddLast(colorrect);
                }
                if(rbPatternFill.Checked)
                {
                    Color brushColor = cdBrushColor.Color;
                    RectanglePattern pattrec = new RectanglePattern(_sPoint, e.Location, penWidth, penColor, brushColor);
                    _rectanglesPatterns.AddLast(pattrec);
                }
                
            }
            if (rbCircle.Checked)
            {
                if(rbNoFill.Checked)
                {
                    Circle circle = new Circle(_sPoint, e.Location, penWidth, penColor);
                    _circles.AddLast(circle);
                }
                if(rbColorFill.Checked)
                {
                    Color brushColor = cdBrushColor.Color;
                    CircleColor circleColor = new CircleColor(_sPoint, e.Location, penWidth, penColor, brushColor);
                    _circlesColors.AddLast(circleColor);
                }
                if(rbPatternFill.Checked)
                {
                    Color brushColor = cdBrushColor.Color;
                    CirclePattern circlePattern = new CirclePattern(_sPoint, e.Location, penWidth, penColor, brushColor);
                    _circlesPatterns.AddLast(circlePattern);
                }
            }
            
            _moving = false;
        }

        private void mainPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (!_moving || (_sPoint == _aPoint)) { return; }
            RefreshPanel();
            int penWidth = (int)inpPenWidth.Value;
            Color penColor = cdPenColor.Color;
            if (rbRectangle.Checked)
            {
                if (rbNoFill.Checked)
                {
                    Rectangle rect = new Rectangle(_sPoint, e.Location, penWidth, penColor);
                    rect.Draw(_graphic);
                }

                if (rbColorFill.Checked)
                {
                    Color brushColor = cdBrushColor.Color;
                    RectangleColor colorrect = new RectangleColor(_sPoint, e.Location, penWidth, penColor, brushColor);
                    colorrect.Draw(_graphic);
                }
                if (rbPatternFill.Checked)
                {
                    Color brushColor = cdBrushColor.Color;
                    RectanglePattern pattrect = new RectanglePattern(_sPoint, e.Location, penWidth, penColor, brushColor);
                    pattrect.Draw(_graphic);
                }


            }
            if (rbCircle.Checked)
            {
                if (rbNoFill.Checked)
                {
                    Circle circle = new Circle(_sPoint, e.Location, penWidth, penColor);
                    circle.Draw(_graphic);
                }
                if(rbColorFill.Checked)
                {
                    Color brushColor = cdBrushColor.Color;
                    CircleColor circleColor= new CircleColor(_sPoint, e.Location, penWidth, penColor, brushColor);
                    circleColor.Draw(_graphic);
                }
                if (rbPatternFill.Checked)
                {
                    Color brushColor = cdBrushColor.Color;
                    CirclePattern circlePattern = new CirclePattern(_sPoint, e.Location, penWidth, penColor, brushColor);
                    circlePattern.Draw(_graphic);
                }
            }
            
        }

        private void RefreshPanel()
        {
            _graphic.Clear(Color.White);         
            foreach (Rectangle rect in _rectangles)
            {
                rect.Draw(_graphic);
            }
            foreach (Circle circ in _circles)
            {
                circ.Draw(_graphic);
            }
            foreach (RectangleColor rectColor in _rectanglesColors)
            {
                rectColor.Draw(_graphic);
            }
            foreach (RectanglePattern rectColor in _rectanglesPatterns)
            {
                rectColor.Draw(_graphic);
            }
            foreach(CircleColor circleColor in _circlesColors)
            {
                circleColor.Draw(_graphic);
            }
            foreach(CirclePattern circlePattern in _circlesPatterns)
            {
                circlePattern.Draw(_graphic);
            }    
        }

        private void colorFill_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void btFillColor_Click(object sender, EventArgs e)
        {
            if (cdBrushColor.ShowDialog() == DialogResult.OK)
            {
                lbFillColor.ForeColor = cdBrushColor.Color;
            }
        }
    }
}
