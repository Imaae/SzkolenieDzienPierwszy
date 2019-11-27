using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab25___KlasaStatyczna
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Dodawanie: { Kalkulator.Dodaj(10m, 2.5m)}");
            Console.WriteLine($"Odejmowanie: { Kalkulator.Odejmij(10m, 2.5m)}");
            Console.WriteLine($"Mnożenie: { Kalkulator.Pomnoz(10m, 2.5m)}");
            Console.WriteLine($"Dzielenie: { Kalkulator.Podziel(10m, 2.5m)}");

            Console.ReadKey();
        }
    }
}
