using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Salter
{
    class Salter
    {
        ArrayList karti;
        int id;
        public Salter(int id) {
            this.id = id;
            karti = new ArrayList();
        }

        public void novaNaracka(String destinacija) {
            karti.Add(destinacija);
            Console.WriteLine("Успешно додадена нова нарачка на шалтер бр. "+this.id);
        }

        public int brojKarti() {
            return karti.Count;
        }

        public void print() {
            Console.Write("Продадени карти до градовите: ");
            foreach(String karta in karti)Console.Write(karta+" ");
            Console.WriteLine("Вкупно продадени карти:" + brojKarti());
            Console.WriteLine("Вкупно остварен промет:" + promet());
        }

        public int promet() {
            int vkupno = 0;
            foreach (String karta in karti)
            {
                vkupno += karta.Length * 1000;
            }
            return vkupno;
        }


    }
}
