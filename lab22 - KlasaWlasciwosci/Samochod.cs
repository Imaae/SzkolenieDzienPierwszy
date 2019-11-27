using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab22___KlasaWlasciwosci
{
    class Samochod
    {
        private string nazwa;
        private int rokProdukcji;
        private int aktualnaPredkosc;
        private int maksymalnaPredkosc;
        //wlasciwosci
        public string Nazwa { get => nazwa; set => nazwa = value; }
        public int RokProdukcji { get => rokProdukcji; set => rokProdukcji = value; }
        public int AktualnaPredkosc { get => aktualnaPredkosc; set => aktualnaPredkosc = value; }
        public int MaksymalnaPredkosc
        {
            get => maksymalnaPredkosc; set
            {
                if (value>150)
                {
                    maksymalnaPredkosc = 150;
                }
                else
                {
                    maksymalnaPredkosc = value;
                }
            } }

        public Samochod(string nazwa, int rokProdukcji, int maksymalnaPredkosc)
        {
            this.Nazwa = nazwa;
            this.RokProdukcji = rokProdukcji;
            this.MaksymalnaPredkosc = maksymalnaPredkosc;
            this.AktualnaPredkosc = 0;
        }
        public Samochod(string nazwa, int rokProdukcji):this(nazwa, rokProdukcji,2000)
        {
           
        }
        public Samochod(string nazwa)
        {
            this.Nazwa = nazwa;
          
        }

        public Samochod()
        {
                
        }



        public void PokazSamochod()
        {
            string nl = Environment.NewLine;
            Console.WriteLine($"samochod {nl} nazwa: {Nazwa}{nl} rok: {RokProdukcji} {nl} aktualna: {AktualnaPredkosc}{nl} max: {MaksymalnaPredkosc}");
            Console.WriteLine();
        }

        public void Przyspiesz(int wartosc)
        {
            if ((AktualnaPredkosc+ wartosc) <=MaksymalnaPredkosc)
            {
                AktualnaPredkosc +=wartosc;
            }
            else
            {
                AktualnaPredkosc = MaksymalnaPredkosc;
            }
        }
        public void Zwolnij(int wartosc)
        {
            if ((AktualnaPredkosc - wartosc) < 0)
            {
                AktualnaPredkosc =0;
            }
            else
            {
                AktualnaPredkosc -=wartosc;
            }
        }
    }

}
