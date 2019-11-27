using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab15___ListaString
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> lista = new List<string> ();

            lista.Add("Adam");
            lista.Add("Witek");
            lista.Add("Paweł");
            lista.Add("Adam");
            lista.Add("Robert");
            lista.Add("Jola");
            lista.Add("Adam");

            Console.WriteLine($"lista ma {lista.Count} elementow");

            foreach (var item in lista)
            {
                Console.WriteLine($"{item}");
            }

           // lista.RemoveAt(3);

            Console.WriteLine($"lista ma {lista.Count} elementow");

            string zmienna = lista[3];

            Console.WriteLine($"1 el{zmienna}");

            lista.Remove(zmienna);

            Console.WriteLine($"lista ma {lista.Count} elementow");

            foreach (var item in lista)
            {
                Console.WriteLine($"{item}");
            }

            Console.ReadKey();
        }
    }
}
