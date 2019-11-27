using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab21___KlasaKonstruktor_cwiczenie3_
{
    class Wspolrzedne
    {
        public int wartoscX;
        public int wartoscY;


        public Wspolrzedne(int wartoscX, int wartoscY)
        {
            this.wartoscX = wartoscX;
            this.wartoscY = wartoscY;
        }

        public string PokazWspolrzedne()
        {
            string powrot = "["+ wartoscX + "," + wartoscY + "]";
            return powrot;
        }
    }
}
