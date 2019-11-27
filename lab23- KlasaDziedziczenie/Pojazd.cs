using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab23__KlasaDziedziczenie
{
    class Pojazd
    {
        //pola z malych
        private string nazwa;
        private int rokProdukcji;
        private int aktualnaPredkosc;
        private int maksymalnaPredkosc;
        //wlasciwosci z duzych
        public string Nazwa { get => nazwa; set => nazwa = value; }
        public int RokProdukcji { get => rokProdukcji; set => rokProdukcji = value; }
        public int AktualnaPredkosc { get => aktualnaPredkosc; set => aktualnaPredkosc = value; }
        public int MaksymalnaPredkosc { get => maksymalnaPredkosc; set => maksymalnaPredkosc = value; }
    }
}
