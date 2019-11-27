using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab10___typEnumSwitch_cwiczenie_
{
    class Program
    {
        enum RozmiarKawy
        {
            Mała,
            Normalna,
            Duża
        }
        static void Main(string[] args)
        {
            RozmiarKawy rozmiarKawy = RozmiarKawy.Normalna;

           

            switch (rozmiarKawy)
            {
                case RozmiarKawy.Mała:
                    Console.WriteLine($"Kawa: {rozmiarKawy} - 3 pln");
                    break;
                case RozmiarKawy.Normalna:
                    Console.WriteLine($"Kawa: {rozmiarKawy} - 4,5 pln");
                    break;
                case RozmiarKawy.Duża:
                    Console.WriteLine($"Kawa: {rozmiarKawy} - 5 pln");
                    break;
            }

            // Console.WriteLine($"Stan: {state2}, {Convert.ToInt32(state2)}");
            Console.ReadKey();
        }
    }
}