using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BallsInHoles
{
    public class Ball
    {
        public Point Centar { get; set; }
        public static int Radius = 25;
        public static Random random = new Random();
        Color color;
        public int Angle { get; set; }

        public Ball(Point p, Color c) {
            Centar = p;
            color = c;

            Angle = random.Next(0,360);
        }

        public void Draw(Graphics g) {
            Brush b = new SolidBrush(color);
            g.FillEllipse(b, Centar.X-Radius, Centar.Y-Radius, Radius*2, Radius*2);
        }

        public void Move(Point p) {
            Centar = p;
        }

    }
}
