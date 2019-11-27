using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab21___KlasaKonstruktor_cwiczenie3_
{
    class Prostkat
    {
        public Wspolrzedne lewyGronyRog;
        public Wspolrzedne lewyDolnyRog;
        public Wspolrzedne PrawyGronyRog;
        public Wspolrzedne PrawyDolnyRog;
        public int dlugosc;
        public int szerokosc;

        public Prostkat(Wspolrzedne LGR, int wysokosc,int szerokosc)
        {
            this.lewyGronyRog = LGR;
            this.dlugosc = wysokosc;
            this.szerokosc = szerokosc;
            this.lewyDolnyRog= new Wspolrzedne(LGR.wartoscX, LGR.wartoscY - wysokosc) ;
            this.PrawyGronyRog =new Wspolrzedne(LGR.wartoscX + szerokosc, LGR.wartoscY );
            this.PrawyDolnyRog = new Wspolrzedne(LGR.wartoscX +szerokosc , LGR.wartoscY- wysokosc);
        }

        public void PokarzWierzcholki()
        {
            Console.WriteLine($"LGW: {lewyGronyRog.PokazWspolrzedne()} PGR: {PrawyGronyRog.PokazWspolrzedne()}");
            Console.WriteLine($"LDW: {lewyDolnyRog.PokazWspolrzedne()} PDR: {PrawyDolnyRog.PokazWspolrzedne()}");
        }
        public void ObliczObwod()
        {
            Console.WriteLine($"Obwod: {(this.dlugosc * 2 )+(this.szerokosc *2)}");
           
        }
        public void ObliczPole()
        {
            Console.WriteLine($"Pole: {(this.dlugosc * this.szerokosc)}");
           
        }
    }
}
