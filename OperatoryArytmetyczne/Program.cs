using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatoryArytmetyczne
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("2+2=" + (2+2));
            Console.WriteLine("5-2=" + (5-2));
            Console.WriteLine("5*2=" + (5 * 2));
            Console.WriteLine("5/2=" + (5.0 / 2));
            Console.WriteLine("2^3=" + Math.Pow(2,3));
            Console.WriteLine("2%3=" + (2 % 3));
            //  Console.WriteLine($"numer5: {numer5} - numer6: {numer6}");

            int a = 5;
            a = a + 1;
            Console.WriteLine($"a + 1: { a }");
            int b = 5;
            
            Console.WriteLine($"b++: { b++ }");
            int c = 5;
            
            Console.WriteLine($"++c: { ++c }");

            int d = 6;
            int e = 4;
            d += e;
            Console.WriteLine($"d+=: { d }");

            Console.Clear();
            Console.WriteLine($"podaj wage [kg]");
            double waga = Convert.ToDouble(  Console.ReadLine());
            Console.WriteLine($"podaj wzrost [m]");
            double wzrost = Convert.ToDouble(Console.ReadLine());

            double bmi = Math.Round((waga / (Math.Pow(wzrost, 2))),2);
            Console.WriteLine($"bmi: {bmi.ToString("%")} - {bmi}");

            Console.Clear();
            Console.WriteLine($"podaj dlugosc boku kwadratu");
            double bok = Convert.ToDouble(Console.ReadLine());
        
            Console.WriteLine($"pole kwadratu: {Math.Round(Math.Pow(bok, 2),2)} - bok:{bok}");


            Console.Clear();
            Console.WriteLine($"podaj 1 zmienna");
            decimal zmienna1 = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine($"podaj 2 zmienna");
            decimal zmienna2 = Convert.ToDecimal(Console.ReadLine());
            
            Console.WriteLine($"suma: {zmienna1 + zmienna2} roznica: {zmienna1 - zmienna2} iloczyn: {zmienna1 * zmienna2} iloraz: {zmienna1 / zmienna2}");
            //Console.WriteLine($"roznica: {zmienna1 - zmienna2}");
            //Console.WriteLine($"iloczyn: {zmienna1 * zmienna2}");
            //Console.WriteLine($"iloraz: {zmienna1 / zmienna2}");


            Console.ReadKey();
        }
    }
}
