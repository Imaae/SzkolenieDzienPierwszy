using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab20___KlasaMetody_cwiczenie_
{
    class Program
    {
        static void Main(string[] args)
        {
            Zwierze pies = new Zwierze();
            Zwierze pajak = new Zwierze();
            Zwierze mucha = new Zwierze();

            pies.nazwa = "Labrador";
            pies.iloscNog = 4;
            pies.iloscOczu = 2;
            pajak.nazwa = "Tarantula";
            pajak.iloscNog = 8;
            pajak.iloscOczu = 4;
            mucha.nazwa = "TseTse";
            mucha.iloscNog = 6;
            mucha.iloscOczu = 2;

            pies.OpisKonsola();
            pajak.OpisKonsola();
            mucha.OpisKonsola();
            
            Console.WriteLine(pies.Opis());
            Console.WriteLine(pajak.Opis());
            Console.WriteLine(mucha.Opis());
       
            Console.Read();

        }
    }
}
