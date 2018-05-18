using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawLines
{
    [Serializable]
    public class Line
    {
        public Point Start { get; set; }
        public Point End { get; set; }
        public float Tickness { get; set; }

        public Line(Point Start, Point End, float Tickness) {
            this.Start = Start;
            this.End = End;
            this.Tickness = Tickness;
        }
        public void Draw(Graphics e) {
            Pen p = new Pen(Color.Black, Tickness);
            e.DrawLine(p, Start, End);
            p.Dispose();
        }
    }
}
