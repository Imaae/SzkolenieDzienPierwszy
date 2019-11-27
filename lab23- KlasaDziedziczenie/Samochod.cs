using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab23__KlasaDziedziczenie
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

    }
}
