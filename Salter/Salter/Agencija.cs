using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Salter
{
    class Agencija
    {
        int brojSalteri;
        int brojKlienti;
        int brojUsluzeni;
        String []gradovi;
        Salter[] salteri;
        public Agencija(int brojSalteri) {
            this.brojSalteri = brojSalteri;
            this.salteri = new Salter[brojSalteri];
            for (int i = 0; i < this.salteri.Length; i++) this.salteri[i] = new Salter(i+1);
            this.printMenu();
            this.brojKlienti = 0;
            this.brojUsluzeni = 0;
            gradovi = new string[]{"Rim", "London", "Tokio", "Sofija", "Istanbul", "Toronto", "Majami", "Zagreb", "Belgrad", "Moskva"};
        }

        public void usluziKlient() {
            this.brojKlienti++;
            Console.Write("Внеси име: ");
            Console.ReadLine();
            Console.Write("Презиме: ");
            Console.ReadLine();
            Console.Write("Години: ");
            Console.ReadLine();
            Console.Write("Опции: ");
            for (int i = 0; i < gradovi.Length; i++) Console.Write(gradovi[i]+", ");
            Console.WriteLine();
            Console.Write("Дестинација: ");
            String destinacija = Convert.ToString(Console.ReadLine());
            if (postoiDestinacija(destinacija))
            {
                Console.Write("Број шалтер: ");
                int s = Convert.ToInt32(Console.ReadLine());
                salteri[s - 1].novaNaracka(destinacija);
                this.brojUsluzeni++;
            }
            else {
                Console.WriteLine("Одбраната дестинација не постои.");
            }
            

        }
        public void printMenu() {
            Console.WriteLine("0. Види го менито");
            Console.WriteLine("1. Услужи го клиентот");
            Console.WriteLine("2. Продадени карти на шалтерот");
            Console.WriteLine("3. Вкупен промет на шалтерот");
            Console.WriteLine("4. Сите продадени карти на агенцијата, организирани по шалтер");
            Console.WriteLine("5. Вкупен промет на агенцијата");
            Console.WriteLine("6. Успешност на агенцијата");
            Console.WriteLine("7. Излез");
        }
        public void prodadeniKartiSalter() {
            Console.WriteLine("Шалтер бр:");
            int salter = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Шалтер бр: " + salter + " има продадено: " + this.salteri[salter - 1].brojKarti() +" карти");
        }
        public void vkupenPrometSalter() {
            Console.WriteLine("Шалтер бр:");
            int salter = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Шалтер бр: " + salter + " има вкупен промет: " + this.salteri[salter - 1].promet() + " ден");


        }
        public void siteKartiPoSalter() {
            for (int i = 0; i < salteri.Length; i++)
            {
                Console.WriteLine("Шалтер број "+(i+1)+" информации");
                salteri[i].print();

            }
        }
        public void vkupenPromet() {
            int vkupenPromet = 0;

            for (int i = 0; i<salteri.Length; i++) {
                vkupenPromet += salteri[i].promet();
            }

            Console.WriteLine("Агенцијата има вкупен промет: " + vkupenPromet + " ден");
        }
        public void uspesnost() {
            Console.WriteLine("Агенцијата има успешност од: "+ (double)brojUsluzeni/(double)brojKlienti);
        }
        private bool postoiDestinacija(String d) {
            bool postoi = false;
            for (int i = 0; i < gradovi.Length; i++) {
                if (gradovi[i].ToString().Equals(d)) postoi = true;
            }
            return postoi;
        }
        
    }
}
