using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab19___Klasa_cwiczenie_
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

            Console.WriteLine($"pies - nazwa: {pies.nazwa} iloscNog: {pies.iloscNog} iloscOczu: {pies.iloscOczu}");
            Console.WriteLine($"pajak - nazwa: {pajak.nazwa} iloscNog: {pajak.iloscNog} iloscOczu: {pajak.iloscOczu}");
            Console.WriteLine($"mucha - nazwa: {mucha.nazwa} iloscNog: {mucha.iloscNog} iloscOczu: {mucha.iloscOczu}");
            
            Console.ReadKey();
        }
        }
    }
