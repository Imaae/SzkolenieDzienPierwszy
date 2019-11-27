using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab21___KlasaKonstruktor_cwiczenie3_
{
    class Program
    {
        static void Main(string[] args)
        {
            Wspolrzedne lewyGornyPunkt = new Wspolrzedne(2, 5);
            int wysokosc = 3;
            int szerokosc = 4;

            Prostkat prostkat = new Prostkat(lewyGornyPunkt, wysokosc, szerokosc);

            prostkat.ObliczObwod();
            prostkat.ObliczPole();
            prostkat.PokarzWierzcholki();


            Console.ReadKey();
        }
    }
}
