using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawLines
{
    [Serializable]
    public class LineDoc
    {
        public List<Line> lines { get; set; }
        public Point odKade;

        public LineDoc() {
            lines = new List<Line>();
        }
        public void addLine(Line line) {
            lines.Add(line);
        }

        public void Draw(Graphics g) {
            foreach (var l in lines) {
                l.Draw(g);
            }
        }
        
    }
}
