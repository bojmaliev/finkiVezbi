using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BallsInHoles
{
    public class ballsHolesDoc
    {
        public List<Hole> holes{ get; set; }
        public List<Ball> balls { get; set; }
        public int width { get; set; }
        public static Random random = new Random();
        public int height { get; set;  }

        public ballsHolesDoc(int width, int height) {
            this.width = width;
            this.height = height;
            holes = new List<Hole>();
            balls = new List<Ball>();

            for (int i = 0; i < 5; i++) {

                Point p=new Point();
                bool isNear = true;
                while (isNear)
                { 
                    p = new Point(random.Next(Hole.Radius, width - Hole.Radius), random.Next(Hole.Radius, height - Hole.Radius));
                    isNear = false;
                    foreach (Hole hole in holes) {
                        if (hole.isNear(p, Hole.Radius * 2)) isNear = true;
                    }
                }

                Hole h = new Hole(p);
                holes.Add(h);

            }

        }

       

        public void Draw(Graphics g) {
            foreach (Hole h in holes)
                h.Draw(g);

            foreach (Ball b in balls)
                b.Draw(g);
        }
        public void Move() {
            foreach (Ball b in balls) {
                int x = b.Centar.X;
                int y = b.Centar.Y;
                int angle = b.Angle;
                x += (int)(8 * Math.Cos(angle * Math.PI / 180));
                y += (int)(8 * Math.Sin(angle * Math.PI / 180));

                if (x < 0 || x > width)
                {
                    angle = 180 - angle;
                }
                else if (y < 0 || y > height)
                {
                    angle = 360 - angle;
                }
                Point p = new Point(x, y);
                b.Angle = angle;
                b.Move(p);
            }
            foreach (Hole h in holes) {
                for (int i = 0; i < balls.Count; i++) {
                    if(h.isNear(balls[i].Centar, 25)){
                        h.countBalls++;
                        balls.RemoveAt(i);
                    }
                }
            }
        }

        public void addBall(Ball b) {
            balls.Add(b);
        }




    }
}
