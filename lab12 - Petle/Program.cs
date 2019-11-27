using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab12___Petle
{
    class Program
    {
        static void Main(string[] args)
        {
            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine($"Iterator: {i}");

            //    //if (i == 5) break;
            //    if (i == 5) continue;
            //    Console.WriteLine($"Iterator: {i}");
            //}

            //    LiczbyNieparzyste();

            //CzyLiczbaPierwsza();

            //List<int> lista = new List<int>()
            //{
            //    1,2,3,5,7
            //};

            //for (int i = 0; i < lista.Count; i++)
            //{
            //    Console.WriteLine($"{i} : {lista[i]}");
            //}


            /////////////////////////////////////////////////////////////////////////////////////////

            //foreach (var item in "Rafał")
            //{
            //    Console.WriteLine($"{item}");
            //}


            //Console.WriteLine($"podaj tekst");
            //string vTekst = Console.ReadLine();
            //int iloscLiter = 0, iloscCyfr = 0, iloscBialychZnakow = 0;
            //foreach (var item in vTekst)
            //{
            //    if (Char.IsWhiteSpace(item)) iloscBialychZnakow++;
            //    if (Char.IsLetter(item)) iloscLiter++;
            //    if (Char.IsNumber(item)) iloscCyfr++;
            //}

            //Console.WriteLine($"Liczba liter: {iloscLiter} , Liczba cyfr: {iloscCyfr}, Liczba białych znaków: {iloscBialychZnakow}");

            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            //int licznik = 0;

            //while (licznik<10)
            //{
            //    Console.WriteLine(licznik);
            //    licznik++;
            //}

            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            int licznik = 0;
            do
            {
                Console.WriteLine(licznik);
                    licznik++;
            } while (licznik < 0);

   




            Console.ReadKey();
        }

        private static void CzyLiczbaPierwsza()
        {
            Console.WriteLine($"podaj liczbe do spr czy jest liczba pierwsza");
            int vLiczbaUzytkownika = Convert.ToInt32(Console.ReadLine());
            int liczbaDzielnikow = 1;
            for (int i = 2; i < vLiczbaUzytkownika - 1; i++)
            {

                if (vLiczbaUzytkownika % i == 0)
                {
                    liczbaDzielnikow++;
                }
            }
            string komunikat;
            if (liczbaDzielnikow == 1)
            {
                komunikat = "Liczba: " + vLiczbaUzytkownika + " jest liczbą pierwszą";
            }
            else
            {
                komunikat = "Liczba: " + vLiczbaUzytkownika + " nie jest liczbą pierwszą(liczba dzielników: " + liczbaDzielnikow + ")";
            }
            Console.WriteLine($"{komunikat}");
        }

        private static void LiczbyNieparzyste()
        {
            Console.WriteLine($"podaj  liczbe ");
            int vLiczbaUzytkownika = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i < vLiczbaUzytkownika; i++)
            {

                if (i % 2 != 0)
                {
                    Console.WriteLine($"Liczba nieparzysta: {i}");
                }
            }
        }
    }
}
