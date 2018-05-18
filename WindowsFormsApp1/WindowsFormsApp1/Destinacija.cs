using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Destinacija
    {
        public string destinacija { get; set; }
        public int cas { get; set; }
        public int min { get; set; }
        public int cena { get; set; }

        public Destinacija(string destinacija, int cas, int min, int cena) {
            this.destinacija = destinacija;
            this.cas = cas;
            this.min = min;
            this.cena = cena;
        }

        public override string ToString()
        {
            return string.Format("{0} {1}:{2} - {3} ден.", destinacija, cas, min, cena);
        }
    }
}
