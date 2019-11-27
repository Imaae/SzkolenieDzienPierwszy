using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab21___KlasaKonstruktor_cwiczenie_
{
    class Zwierze
    {
        public string nazwa;
        public int iloscNog;
        public int iloscOczu;

        public Zwierze(string nazwa, int iloscOczu, int iloscNog)
        {
            this.nazwa = nazwa;
            this.iloscNog = iloscNog;
            this.iloscOczu = iloscOczu;           
        }
        public Zwierze(string nazwa, int iloscOczu)
        {
            this.nazwa = nazwa;
            this.iloscOczu = iloscOczu;           
            this.iloscNog = 4;
        }

        public void OpisKonsola()
        {
            Console.WriteLine($"{this.GetType()} - nazwa: {nazwa} iloscNog: {iloscNog} iloscOczu: {iloscOczu}");
        }
       
        public string Opis()
        {
            string powrot;
       
            powrot =$" nazwa: {nazwa} iloscNog: {iloscNog} iloscOczu: {iloscOczu}";
            return powrot;
        }
    }
}
