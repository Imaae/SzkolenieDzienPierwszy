using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab13___Tablice
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] tablica1;
            //tablica1 = new int[] { 1, 3, 6, 8 };
            //Console.WriteLine($"dlugosc tablicy: {tablica1.Length}");
            //Console.WriteLine($"element 2: {tablica1[1]}");
            //tablica1[1] = 2333;
            //Console.WriteLine($"element 2: {tablica1[1]}");

            //foreach (var item in tablica1)
            //{
            //    Console.WriteLine($"item foreach: {item}");
            //}

            ////////////////////////////////////////////////////////////////

            //int[] tablica2 = new int[] { 1, 4, 6, 8 };

            ////////////////////////////////////////////////////////////////

            int[] tablica3 = new int[10];
           // Console.WriteLine($"{tablica3[2]}");

            WypiszTablice(tablica3);

            ///////////////////////////////////////////////////////////////////////////////////////////////////////












            Console.ReadKey();
        }

        private static void WypiszTablice(int[] tablica)
        {
            for (int i = 0; i < tablica.Length; i++)
            {
                Console.WriteLine($"i={i} - {tablica[i]}");
            }
        }
    }
}
