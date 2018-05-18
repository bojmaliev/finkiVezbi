using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labvp3
{
    public class Player
    {
        public string ime { get; set; }
        public int poeni { get; set; }
        public int vreme { get; set; }

        public Player(string ime) {
            this.ime = ime;
            poeni = 0;
            vreme = 10;
        }
        public override string ToString()
        {
            return string.Format("{0} - {1}", ime, poeni);
        }
    }
}
