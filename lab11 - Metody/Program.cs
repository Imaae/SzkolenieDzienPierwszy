using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab11___Metody
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Inicjaly: {DajInicjaly("Michal","Kacprowicz")}");

            Console.WriteLine($"dlugosc 'abcd': {ObliczDlugoscWyrazu("abcd")}");
            WypiszLiczby(312,534);
            WypiszLiczby(312, 534,876543);

            WypiszLiczby(312.2, 534.1, 876543.3);
            Console.ReadKey();
        }

        static string DajInicjaly(string imie, string nazwisko)
        {
            return imie[0]+"."+nazwisko[0]+".";
        }

        static int ObliczDlugoscWyrazu(string wyraz)
        {
                        return wyraz.Length;
        }

        static void WypiszLiczby(int liczba1, int liczba2)
        {
            Console.WriteLine($"liczba1 : {liczba1} liczba2: {liczba2}");
        }
        static void WypiszLiczby(int liczba1, int liczba2,int liczba3)
        {
            Console.WriteLine($"liczba1 : {liczba1} liczba2: {liczba2} liczba3: {liczba3}");
        }
        static void WypiszLiczby(double liczba1, double liczba2, double liczba3)
        {
            Console.WriteLine($"liczba1 : {liczba1} liczba2: {liczba2} liczba3: {liczba3}");
        }
                static void WypiszLiczby(double liczba1, int liczba2, int liczba3)
        {
            Console.WriteLine($"liczba1 : {liczba1} liczba2: {liczba2} liczba3: {liczba3}");
        }
    }
}
