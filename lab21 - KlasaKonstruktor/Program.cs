using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab21___KlasaKonstruktor
{
    class Program
    {
        static void Main(string[] args)
        {
            Samochod samochod = new Samochod("BMW",2000,180);
           

            samochod.PokazSamochod();
            
            Samochod samochod1 = new Samochod();
            
            samochod1.nazwa = "BMW SUPER";
            samochod1.rokProdukcji = 2020;
            samochod1.maksymalnaPredkosc = 280;
            samochod1.aktualnaPredkosc = 0;

            samochod1.PokazSamochod();

            Samochod samochod2 = new Samochod("Maluch");
            samochod2.PokazSamochod();

            Samochod samochod3 = new Samochod("Polonez", 1987);
            samochod3.PokazSamochod();

            Console.ReadKey();
        }
    }
}
