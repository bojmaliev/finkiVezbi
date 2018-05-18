using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlidingBalls
{
    public class BallDoc
    {
        public List<Ball> balls { get; set; }
        public int Width { get; set; }
        public static Random random = new Random();
        public int Height { get; set; }
        public Ball movingBall;
        public int movingAngle { get; set; }

        public BallDoc(int Width, int Height) {
            this.Width = Width;
            this.Height = Height;
            balls = new List<Ball>();
        }

        public void AddBall(Ball b) {
            balls.Add(b);
        }
        public void Draw(Graphics g) {
            foreach (Ball b in balls) b.Draw(g);
        }

        public void Move() {
            if (movingBall != null)
            {
                Point p = new Point(movingBall.Centar.X + (int)(10 * Math.Cos(movingAngle)), movingBall.Centar.Y + (int)(10 * Math.Sin(movingAngle)));
                movingBall.Move(p);
                if ((p.X + Ball.Radius < 0 || p.X - Ball.Radius > Width) || (p.Y + Ball.Radius < 0 || p.Y - Ball.Radius > Height)) {
                    movingBall = null;
                }
            }

            if (movingBall != null) {
                for (int i = 0; i < balls.Count; i++)
                {
                    if (balls[i].Color == Color.Green && balls[i].isHit(movingBall.Centar.X, movingBall.Centar.Y))
                    {
                        balls.RemoveAt(i);
                    }
                }
            }

        }

        public void checkRedClick(int x, int y)
        {
            if(movingBall == null)
            foreach (Ball b in balls) {
                if (b.Color == Color.Red && b.isHit(x,y)) {
                    movingBall = b;
                    movingAngle = random.Next(0, 360);
                }
            }
        }
    }
}
