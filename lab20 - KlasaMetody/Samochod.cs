using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab20___KlasaMetody
{
    class Samochod
    {
        public string nazwa;
        public int rokProdukcji;
        public int aktualnaPredkosc;
        public int maksymalnaPredkosc;

        public void PokazSamochod()
        {
            string nl = Environment.NewLine;
            Console.WriteLine($"samochod {nl} nazwa: {nazwa}{nl} rok: {rokProdukcji} {nl} aktualna: {aktualnaPredkosc}{nl} max: {maksymalnaPredkosc}");

        }

        public void Przyspiesz(int wartosc)
        {
            if ((aktualnaPredkosc+ wartosc) <=maksymalnaPredkosc)
            {
                aktualnaPredkosc +=wartosc;
            }
            else
            {
                aktualnaPredkosc = maksymalnaPredkosc;
            }
        }
        public void Zwolnij(int wartosc)
        {
            if ((aktualnaPredkosc - wartosc) < 0)
            {
                aktualnaPredkosc =0;
            }
            else
            {
                aktualnaPredkosc -=wartosc;
            }
        }
    }

}
