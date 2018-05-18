using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BallsInHoles
{
    public class Hole
    {
        public Point Centar { get; set; }
        public static int Radius = 30;
        public int countBalls { get; set; }

        public Hole(Point p) {
            countBalls = 0;
            Centar = p;
        }

        public void Draw(Graphics g) {
            Brush b = new SolidBrush(Color.Black);
            g.FillEllipse(b, Centar.X-Radius, Centar.Y-Radius, Radius*2, Radius*2);


            Brush brush = new SolidBrush(Color.White);
            Font font = new Font("Arial", 16, FontStyle.Regular);
            g.DrawString(countBalls.ToString(), font, brush, Centar.X-10, Centar.Y-10);
            b.Dispose();
            brush.Dispose();
            font.Dispose();
        }

        public bool isNear(Point b, int vrednost) {
            return (Math.Pow(b.X - Centar.X, 2) + Math.Pow(b.Y - Centar.Y, 2)) < vrednost* vrednost;
        }
    }
}
