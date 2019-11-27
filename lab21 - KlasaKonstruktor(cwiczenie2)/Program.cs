using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab21___KlasaKonstruktor_cwiczenie2_
{
    class Program
    {
        static void Main(string[] args)
        {
            //lista
            List<Wspolrzedne> lWspolrzedne = new List<Wspolrzedne>();
            for (int indeks = 0; indeks < 10; indeks++)
            {
                lWspolrzedne.Add( new Wspolrzedne(indeks));
            }

            foreach (var item in lWspolrzedne)
            {
                Console.WriteLine($"punkt[{item.wartoscX}] x={item.wartoscX} y={item.wartoscY}");
            }
            Console.WriteLine(  );
            Wspolrzedne[] wspolrzedne = new Wspolrzedne[10];

            for (int indeks = 0; indeks < wspolrzedne.Length; indeks++)
            {
                wspolrzedne[indeks] = new Wspolrzedne(indeks, (indeks * 3) + 6);
                Console.WriteLine($"punkt[{indeks}] x={wspolrzedne[indeks].wartoscX} y={wspolrzedne[indeks].wartoscY}");
            }

            Console.ReadKey();

        }
    }
}
