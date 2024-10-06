using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    internal class Shape
    {
    // IShape.cs
    public interface IShape
    {
        void Draw(Graphics g);
    }

        // RedCircle.cs
        public class RedCircle : IShape
        {
            public void Draw(Graphics g)
            {
                using (Brush brush = new SolidBrush(Color.Red))
                {
                    g.FillEllipse(brush, 10, 40, 100, 100);
                }
            }
        }

        // BlueCircle.cs
        public class BlueCircle : IShape
        {
            public void Draw(Graphics g)
            {
                using (Brush brush = new SolidBrush(Color.Blue))
                {
                    g.FillEllipse(brush, 10, 40, 100, 100);
                }
            }
        }

        // RedSquare.cs
        public class RedSquare : IShape
        {
            public void Draw(Graphics g)
            {
                using (Brush brush = new SolidBrush(Color.Red))
                {
                    g.FillRectangle(brush, 10, 40, 100, 100);
                }
            }
        }

        // BlueSquare.cs
        public class BlueSquare : IShape
        {
            public void Draw(Graphics g)
            {
                using (Brush brush = new SolidBrush(Color.Blue))
                {
                    g.FillRectangle(brush, 10, 40, 100, 100);
                }
            }
        }

        // RedTriangle.cs
        public class RedTriangle : IShape
        {
            public void Draw(Graphics g)
            {
                using (Brush brush = new SolidBrush(Color.Red))
                {
                    Point[] points = { new Point(60, 40), new Point(40, 110), new Point(110, 110) };
                    g.FillPolygon(brush, points);
                }
            }
        }

        // BlueTriangle.cs
        public class BlueTriangle : IShape
        {
            public void Draw(Graphics g)
            {
                using (Brush brush = new SolidBrush(Color.Blue))
                {
                    Point[] points = { new Point(60, 40), new Point(40, 110), new Point(110, 110) };
                    g.FillPolygon(brush, points);
                }
            }
        }
    }
}
