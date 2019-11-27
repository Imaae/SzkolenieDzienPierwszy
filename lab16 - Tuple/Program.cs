using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab16___Tuple
{
    class Program
    {
        static void Main(string[] args)
        {
            var nazwa = WezOsobe();

            Console.WriteLine($"{nazwa.imie}");
            Console.WriteLine($"{nazwa.nazwisko}");


            Console.ReadKey();
        }

        public static (string imie, string nazwisko) WezOsobe()
            {
            var nazwa = (imie: "Kubuś", nazwisko: "Puchatek");
            return nazwa;
            }
    }
}
