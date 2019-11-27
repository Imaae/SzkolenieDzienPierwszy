using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab21___KlasaKonstruktor_cwiczenie2_
{
    class Wspolrzedne
    {
        public int wartoscX;
        public int wartoscY;

        public Wspolrzedne( int wartoscX)
        {
            this.wartoscX = wartoscX;
            this.wartoscY = (wartoscX * 3)+6;
        }
        public Wspolrzedne(int wartoscX, int wartoscY)
        {
            this.wartoscX = wartoscX;
            this.wartoscY = wartoscY;
        }
    }
}
