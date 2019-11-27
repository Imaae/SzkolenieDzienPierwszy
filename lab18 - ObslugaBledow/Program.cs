using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab18___ObslugaBledow
{
    class Program
    {
        static void Main(string[] args)
        {

            //try
            //{
            //    Console.WriteLine("Wprowadz dlugosc boku kwadratu");
            //    int vDlugosc = Convert.ToInt32(Console.ReadLine());

            //    Console.WriteLine($"Pole kwadratu: {vDlugosc * vDlugosc}");
            //    Console.WriteLine($"Obwod kwadratu: {4 * vDlugosc}");
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine($"Blad: {Environment.NewLine} {ex.Message}");

            //}
            //finally
            //{
            //    Console.WriteLine("Koniec");
            //}

            //try
            //{
            //    int a = 1;
            //    int b = 2;
            //    a = a / b;
            //}
            //catch (ArgumentException ex)
            //{
            //    Console.WriteLine($"Blad argumentu: {Environment.NewLine} {ex.Message}"); 
            //}
            //catch (DivideByZeroException ex)
            //{
            //    Console.WriteLine($"Blad dzielenie przez 0: {Environment.NewLine} {ex.Message}");
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine($"Blad: {Environment.NewLine} {ex.Message}");
            //}
            //// Console.WriteLine($"{nazwa.nazwisko}");
            //finally
            //{
            //    Console.WriteLine($"blok finally ");
            //}


            try
            {
                Console.WriteLine("Wprowadz dlugosc boku kwadratu");
                int vDlugosc = Convert.ToInt32(Console.ReadLine());
                if (vDlugosc < 0)
                    throw new ArgumentException("Liczba ujemna nie dozwolona");
                Console.WriteLine($"Pole kwadratu: {vDlugosc * vDlugosc}");
                Console.WriteLine($"Obwod kwadratu: {4 * vDlugosc}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Blad: {Environment.NewLine} {ex.Message}");
                
            }


















            Console.ReadKey();
        }
    }
}
