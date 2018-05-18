using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1VP
{
    class Program
    {
        static void Main(string[] args)
        {
            int N;
            Console.Write("How many numbers you want: ");
            N = Convert.ToInt32(Console.ReadLine());
            Console.Write("Do you want random generated numbers or you will fill?\n(1) you fill\n(2) random generated\nChoose: ");
            int vlezType = Convert.ToInt32(Console.ReadLine());
            float suma = 0;
            int max = 0;
            int min = Int32.MaxValue;
            Random random = new Random();
            for (int i = 0; i < N; i++) {
                int broj=0;
                if (vlezType == 1)
                {
                    broj = Convert.ToInt32(Console.ReadLine());
                }
                else if (vlezType == 2) {
                    broj = random.Next(1, 1000);
                }
                
                if (broj > max) max = broj;
                if (broj < min) min = broj;
                suma += broj;
            }

            Console.Write("Vneseni {0} broja, najmal e: {1}, najgolem e: {2}, prosek na site e {3} \n", N, min, max, suma/N);
            Console.ReadKey();

        }
    }
}
