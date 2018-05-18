using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Topki
{
    [Serializable]
    public class BallDoc
    {
        public List<Ball> topcinja { get; set; }
        public static int velocity = 7;
        public int width { get; set; }
        public int Hits { get; set; }
        public int Misses { get; set; }

        public BallDoc(int width) {
            this.width = width;
            topcinja = new List<Ball>();
            Hits = 0;
            Misses = 0;

        }

        public void AddBall(Ball b) {
            topcinja.Add(b);
        }

        public void Draw(Graphics g) {
            foreach (Ball b in topcinja) {
                b.Draw(g);
            }
        }

        public void Move() {
            for (int i=0; i<topcinja.Count; i++) {
                topcinja[i].Move(new Point(topcinja[i].Center.X + velocity, topcinja[i].Center.Y));
                if (topcinja[i].Center.X+Ball.Radius >= width) {
                    topcinja[i].State = -1;
                    topcinja.RemoveAt(i);
                    Misses++;
                }
            }
        }

        public void checkHit(int x, int y)
        {
            for (int i=0; i<topcinja.Count; i++) {
                if (topcinja[i].isHit(x, y)) {
                    topcinja[i].State++;
                        if (topcinja[i].State == 3) {
                            Hits++;
                            topcinja.RemoveAt(i);
                        }
                    }
            }

        }

    }
}
