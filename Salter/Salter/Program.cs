using System;
using System.Text;

namespace Salter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            int cmd;
            Agencija agencija = new Agencija(10);
            while (true) {
                Console.WriteLine("Одбери опција:");
                cmd = Convert.ToInt32(Console.ReadLine());
                if (cmd == 0) {
                    agencija.printMenu();
                } else if (cmd == 1) {
                    agencija.usluziKlient();
                }
                else if (cmd == 2)
                {
                    agencija.prodadeniKartiSalter();

                }
                else if (cmd == 3)
                {
                    agencija.vkupenPrometSalter();
                }
                else if (cmd == 4)
                {
                    agencija.siteKartiPoSalter();
                }
                else if (cmd == 5)
                {
                    agencija.vkupenPromet();
                }
                else if (cmd == 6)
                {
                    agencija.uspesnost();
                }else if (cmd == 7) break;

            }
        }
    }
}
