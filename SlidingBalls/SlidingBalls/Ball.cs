using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlidingBalls
{
    public class Ball
    {
        public Point Centar { get; set; }
        public static int Radius = 30;
        public Color Color { get; set; }


        public Ball(Point position, Color color) {
            Color = color;
            Centar = position;
            
        }

        public void Draw(Graphics g) {
            Brush b = new SolidBrush(Color);
            g.FillEllipse(b, Centar.X-Radius, Centar.Y - Radius, Radius*2, Radius*2);
            b.Dispose();
        }

        public bool isHit(int x, int y) {
                return (Math.Pow(x - Centar.X, 2) + Math.Pow(y - Centar.Y, 2)) < (Radius + Radius) * (Radius+ Radius);
        }

        public void Move(Point c) {
            Centar = c;

        }

    }
}
