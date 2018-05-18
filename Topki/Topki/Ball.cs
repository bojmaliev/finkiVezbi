using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Topki
{
    [Serializable]
    public class Ball
    {
        public Point Center { get; set; }
        // 0 zeleno 1 plavo  2 crveno -1 nadvor od ekran 3 - za brisenje 
        public int State { get; set; }
        public static int Radius = 40;

        public Ball(Point center) {
            Random r = new Random();
            Center = center;
            State = r.Next(3);
        }
        public void Draw(Graphics g) {

            if (State == 0)
            {
                Brush b = new SolidBrush(Color.Green);
                g.FillEllipse(b, Center.X-Radius, Center.Y-Radius, 2*Radius, 2*Radius);
            }
            else if (State == 1)
            {
                Brush b = new SolidBrush(Color.Blue);
                g.FillEllipse(b, Center.X - Radius, Center.Y - Radius, 2 * Radius, 2 * Radius);
            }
            else if (State == 2)
            {
                Brush b = new SolidBrush(Color.Red);
                g.FillEllipse(b, Center.X - Radius, Center.Y - Radius, 2 * Radius, 2 * Radius);
            }
        }

        public bool isHit(int x, int y) {

            var diff = (Center.X - x) * (Center.X - x) + (Center.Y - y) * (Center.Y - y);
            return diff <= Radius * Radius;

        }

        public void Move(Point newCentar) {
            Center = newCentar;
        }
         

            


    }
}
