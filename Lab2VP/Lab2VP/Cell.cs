using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2VP
{
    class Cell
    {
        public bool IsAlive { get; set; }
        public bool ShouldLive { get; set; }

        public Cell() {
            IsAlive = false;
            ShouldLive = false;
        }

        public override string ToString()
        {
            if (IsAlive) { return "X"; } else return "_";
        }
    }
}
