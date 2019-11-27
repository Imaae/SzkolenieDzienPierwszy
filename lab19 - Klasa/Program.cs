using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab19___Klasa
{
    class Program
    {
        static void Main(string[] args)
        {
            Klasa klasa = new Klasa();
            Console.WriteLine($"klasa.zmienna: {klasa.zmienna}");
            klasa.zmienna = 10;
            Console.WriteLine($"klasa.zmienna: {klasa.zmienna}");

            Samochod samochod1 = new Samochod();
            Samochod samochod2 = new Samochod();

            samochod1.nazwa = "BMW";
            samochod1.rokProdukcji = 2000;
            samochod1.maksymalnaPredkosc = 180;
            samochod1.aktualnaPredkosc = 0;

             samochod2 = samochod1;
            Console.WriteLine($"samochod1 - nazwa: {samochod1.nazwa} rok: {samochod1.rokProdukcji} aktualna: {samochod1.aktualnaPredkosc} max: {samochod1.maksymalnaPredkosc}");
            //Console.WriteLine($"{word}");
            Console.WriteLine($"samochod2 - nazwa: {samochod2.nazwa} rok: {samochod2.rokProdukcji} aktualna: {samochod2.aktualnaPredkosc} max: {samochod2.maksymalnaPredkosc}");

            samochod2.nazwa = "SSSS";
            Console.WriteLine($"samochod1 - nazwa: {samochod1.nazwa} rok: {samochod1.rokProdukcji} aktualna: {samochod1.aktualnaPredkosc} max: {samochod1.maksymalnaPredkosc}");

            Console.WriteLine($"samochod2 - nazwa: {samochod2.nazwa} rok: {samochod2.rokProdukcji} aktualna: {samochod2.aktualnaPredkosc} max: {samochod2.maksymalnaPredkosc}");
            //referencja samochod2 do samochod1

            Console.ReadKey();
        }
    }
}
