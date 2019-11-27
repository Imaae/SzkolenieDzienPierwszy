using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab22___KlasaWlasciwosci
{
    class Program
    {
        static void Main(string[] args)
        {

            Samochod samochod = new Samochod("BMW", 2000, 200);

            samochod.PokazSamochod();

            samochod.MaksymalnaPredkosc = 1000;
            samochod.Nazwa = "BMW SUPER";
            samochod.RokProdukcji = 2002;
            samochod.AktualnaPredkosc = 100;
            samochod.PokazSamochod();

            Console.ReadKey();
        }
    }
}
