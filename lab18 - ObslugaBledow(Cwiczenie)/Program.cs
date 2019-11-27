using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab18___ObslugaBledow_Cwiczenie_
{
    class Program
    {
        static void Main(string[] args)
        {


            try
            {
                Console.WriteLine("Podaj dzielna");
                decimal a = Convert.ToDecimal(Console.ReadLine());
                Console.WriteLine("Podaj dzielnik");
                decimal b = Convert.ToDecimal(Console.ReadLine());
                Console.WriteLine($"Iloraz {a}/{b}= {Division(a, b)}");
              
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine($"Blad: {Environment.NewLine} {ex.Message}");

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Blad: {Environment.NewLine} {ex.Message}");

            }

















            Console.ReadKey();

        }

        static decimal Division(decimal dzielna, decimal dzielnik)
        {
            decimal iloraz;
            if (dzielnik < 0)
                throw new DivideByZeroException();
            iloraz = dzielna / dzielnik;
            return iloraz;
        }
    }
}
