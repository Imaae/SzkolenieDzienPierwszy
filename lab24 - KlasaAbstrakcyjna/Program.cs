using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab24___KlasaAbstrakcyjna
{
    class Program
    {
        static void Main(string[] args)
        {
            Samochod samochod = new Samochod("Polonez", 1987, 150);

            samochod.PokazPredkosc();
            samochod.Przyspiesz(20);
            samochod.PokazPredkosc();
            samochod.Zwolnij(10);
            samochod.PokazPredkosc();
            
            samochod.PokazSamochod();
            Console.ReadKey();
        }
    }
}
