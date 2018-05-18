using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labvp3
{
    public class Equation
    {
        public int broj1 { get; set; }
        public int broj2 { get; set; }
        public int rezultat { get; set; }
        public string znak { get; set; }

        public Equation() {
            Random random = new Random();
            int op = random.Next(1,5);
            if (op == 1)
            {
                znak = "+";
                broj1 = random.Next(1, 100);
                broj2 = random.Next(1, 100);
                rezultat = broj1 + broj2;
            }
            else if (op == 2)
            {
                znak = "-";
                broj2 = random.Next(1, 100);
                broj1 = random.Next(broj2, 100);
                rezultat = broj1 - broj2;

            }
            else if (op == 3)
            {
                znak = "*";
                broj1 = random.Next(1, 20);
                broj2 = random.Next(1, 20);
                rezultat = broj1 * broj2;

            }
            else if (op == 4) {
                
                znak = "/";
                rezultat = random.Next(1, 100);
                broj2 = random.Next(1, 100);
                broj1 = rezultat * broj2;
            }
        }

    }
}
