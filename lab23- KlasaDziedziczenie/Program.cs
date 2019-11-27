using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab23__KlasaDziedziczenie
{
    class Program
    {
        static void Main(string[] args)
        {

            Samochod samochod = new Samochod("Polonez", 1987, 150);
            Console.WriteLine($"Nazwa: {samochod.Nazwa} RokProdukcji: {samochod.RokProdukcji} MaksymalnaPredkosc: {samochod.MaksymalnaPredkosc} AktualnaPredkosc: {samochod.AktualnaPredkosc}");
            Console.ReadKey();
        }
    }
}
