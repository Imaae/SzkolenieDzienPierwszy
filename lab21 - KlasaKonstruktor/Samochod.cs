using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab21___KlasaKonstruktor
{
    class Samochod
    {
        public string nazwa;
        public int rokProdukcji;
        public int aktualnaPredkosc;
        public int maksymalnaPredkosc;

        //konstruktor       
        /// <summary>
        /// aaaaaa
        /// </summary>
        /// <param name="nazwa">nazwa zamaoschod</param>
        /// <param name="rokProdukcji">produkcja</param>
        /// <param name="maksymalnaPredkosc">szybkosc</param>
         public Samochod(string nazwa, int rokProdukcji, int maksymalnaPredkosc)
        {
            this.nazwa = nazwa;
            this.rokProdukcji = rokProdukcji;
            this.maksymalnaPredkosc = maksymalnaPredkosc;
            this.aktualnaPredkosc = 0;
        }
        public Samochod(string nazwa, int rokProdukcji):this(nazwa, rokProdukcji,2000)
        {
           
        }
        public Samochod(string nazwa)
        {
            this.nazwa = nazwa;
          
        }

        public Samochod()
        {
                
        }



        public void PokazSamochod()
        {
            string nl = Environment.NewLine;
            Console.WriteLine($"samochod {nl} nazwa: {nazwa}{nl} rok: {rokProdukcji} {nl} aktualna: {aktualnaPredkosc}{nl} max: {maksymalnaPredkosc}");
            Console.WriteLine();
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
