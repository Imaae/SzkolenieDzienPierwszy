using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab22___KlasaWlasciwosci_cwiczenie_
{
    class Zwierze
    {
        private string nazwa;
        private int iloscNog;
        private int iloscOczu;

        public string Nazwa { get => nazwa; set => nazwa = value; }
        public int IloscNog { get => iloscNog; set => iloscNog = value; }
        public int IloscOczu { get => iloscOczu; set => iloscOczu = value; }

        public Zwierze(string nazwa, int iloscOczu, int iloscNog)
        {
            this.Nazwa = nazwa;
            this.IloscNog = iloscNog;
            this.IloscOczu = iloscOczu;           
        }
        public Zwierze(string nazwa, int iloscOczu)
        {
            this.Nazwa = nazwa;
            this.IloscOczu = iloscOczu;           
            this.IloscNog = 4;
        }

        public void OpisKonsola()
        {
            Console.WriteLine($"nazwa: {Nazwa} iloscNog: {IloscNog} iloscOczu: {IloscOczu}");
        }
       
        public string Opis()
        {
            string powrot;
       
            powrot =$" nazwa: {Nazwa} iloscNog: {IloscNog} iloscOczu: {IloscOczu}";
            return powrot;
        }
    }
}
