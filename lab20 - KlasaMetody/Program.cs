using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab20___KlasaMetody
{
    class Program
    {
        static void Main(string[] args)
        {
            Samochod samochod = new Samochod();


            samochod.nazwa = "BMW";
            samochod.rokProdukcji = 2000;
            samochod.maksymalnaPredkosc = 180;
            samochod.aktualnaPredkosc = 0;

            samochod.PokazSamochod();
            samochod.Przyspiesz(200);
            samochod.PokazSamochod();
            samochod.Zwolnij(300);
            samochod.PokazSamochod();


            Console.ReadKey();
        }
    }
}
