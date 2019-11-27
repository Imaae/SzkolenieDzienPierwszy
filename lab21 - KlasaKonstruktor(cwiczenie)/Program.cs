using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab21___KlasaKonstruktor_cwiczenie_
{
    class Program
    {
        static void Main(string[] args)
        {
            Zwierze pies = new Zwierze("Labrador", 2);
            Zwierze pajak = new Zwierze("Tarantula",4,8);
            Zwierze mucha = new Zwierze("TseTse",6,4);
            pies.OpisKonsola();
            pajak.OpisKonsola();
            mucha.OpisKonsola();
            Console.ReadKey();

        }
    }
}
