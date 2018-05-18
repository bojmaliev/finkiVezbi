using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1._3
{
    enum PasswordStrenght : byte {
        easy = 1,
        normal = 2,
        hard = 3

    }
    class Program
    {
        static String generatePasword(PasswordStrenght password) {
            String vraka = "";
            Random r = new Random();
            if ((byte)password == 1)
            {
                for (int i = 0; i < 6; i++) {
                    vraka += (char)('a' + r.Next(0, 26));
                }   
            }
            else if ((byte)password == 2)
            {
                for (int i = 0; i < r.Next(6, 11); i++) {
                    int sto = r.Next(0,1);
                    if (sto == 0)
                    {
                        vraka += (char)('A' + r.Next(0, 26));
                    }
                    else {
                        vraka += r.Next(0,10);
                    }
                    
                }
            }
            else
            {
                for (int i = 0; i < r.Next(10, 20); i++) {
                    int sto = r.Next(0,3);
                    if (sto == 0)
                    {
                        vraka += (char)('a' + r.Next(0, 26));
                    }
                    else if (sto == 1)
                    {
                        vraka += (char)('A' + r.Next(0, 26));
                    }
                    else {
                        char[] spec = new char[] { '~', '@', '#', '$', '%', '^', '&', '*', '(', ')'};
                        vraka += spec[r.Next(0, spec.Length)];
                    }
                }
            }

            return vraka;
        }
        static void Main(string[] args)
        {
            
            
            String[] lozinki3 = new String[3];
            lozinki3[0] = generatePasword(PasswordStrenght.easy);
            lozinki3[1] = generatePasword(PasswordStrenght.normal);
            lozinki3[2] = generatePasword(PasswordStrenght.hard);
            Console.Write("Pogodete gi lozinkite ;) \n");
            String pogoduvaLozinki = Console.ReadLine();
            String[] pLozinki = pogoduvaLozinki.Split(' ');

            Random r = new Random();

            int ednakvi = 0;
            for (int i = 0; i < pLozinki.Length; i++) {
                for (int j = 0; j < lozinki3.Length; j++) {

                    if (pLozinki[i] == lozinki3[j]) {
                        ednakvi++;
                    }

                }
            }

            Console.Write("pogodivte {0} lozinki", ednakvi);

            Console.ReadKey();
        }
    }
}
