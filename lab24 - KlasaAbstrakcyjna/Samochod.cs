using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab24___KlasaAbstrakcyjna
{
    class Samochod : Pojazd
    {
        public Samochod(string nazwa, int rokProdukcji, int maksymalnaPredkosc)
        {
            this.Nazwa = nazwa;
            this.RokProdukcji = rokProdukcji;
            this.MaksymalnaPredkosc = maksymalnaPredkosc;
            this.AktualnaPredkosc = 0;
        }

        public void PokazSamochod()
        {
            string nl = Environment.NewLine;
            Console.WriteLine($"samochod {nl} nazwa: {Nazwa}{nl} rok: {RokProdukcji} {nl} aktualna: {AktualnaPredkosc}{nl} max: {MaksymalnaPredkosc}");
            Console.WriteLine();
        }
        public override void Przyspiesz(int wartosc)
        {
            if (WlaczonySilnik == false)
            {
                if ((AktualnaPredkosc + wartosc) <= MaksymalnaPredkosc)
                {
                    AktualnaPredkosc += wartosc;
                }
                else
                {
                    AktualnaPredkosc = MaksymalnaPredkosc;
                }
            }
            else
            {
                Console.WriteLine("Najpierw uruchom silnik");
            }

        }
        public override void Zwolnij(int wartosc)
        {
            if (WlaczonySilnik == false)
            {
                if ((AktualnaPredkosc - wartosc) < 0)
                {
                    AktualnaPredkosc = 0;
                }
                else
                {
                    AktualnaPredkosc -= wartosc;
                }
            }
            else
            {
                Console.WriteLine("Najpierw uruchom silnik");
            }
        }
        public override void Uruchom()
        {
            WlaczonySilnik = true;
        }
        public override void Zatrzymaj()
        {
            WlaczonySilnik = false;
        }

        public override void PokazPredkosc()
        {
            base.PokazPredkosc();
            if (AktualnaPredkosc==0)
            {
                Console.WriteLine("Stoisz w miejscu");
            }
            else if (AktualnaPredkosc>90)
            {
                Console.WriteLine("Jedziesz za szybko");
            }
        }

    }
}
