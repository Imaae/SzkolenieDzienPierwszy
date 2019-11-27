using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Konsola
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello");

            //string firstName = "Jan";
            //string lastName = "Kowalski";

            //Console.WriteLine("Hello " + firstName + " " + lastName);

            //Console.WriteLine("Hello {0} {1}", firstName, lastName);

            //Console.WriteLine($"Hello {firstName} {lastName}");

            ///////////////////////////////////////////////////////////////////////////////////////////////////

            //Console.WriteLine("Podaj swoje imie");

            //string yourName = Console.ReadLine();

            //Console.WriteLine($"Hello {yourName}");

            ///////////////////////////////////////////////////////////////////////////////////////////////////
            //Console.WriteLine("Podaj swoje imie");

            //string yourName = Console.ReadLine();

            //Console.Clear();
            //Console.WriteLine($"Hello {yourName}");

            ///////////////////////////////////////////////////////////////////////////////////////////////////

            //Console.WriteLine("Podaj swoje imie");

            //string yourName = Console.ReadLine();

            //Console.BackgroundColor=ConsoleColor.Red;
            //Console.ForegroundColor = ConsoleColor.Green;

            //Console.WriteLine($"Hello {yourName}");

            //Console.ResetColor();
            //Console.WriteLine("Hello World!");

            ////////////////////////////////////////////////////////////////////////////////////////////////
            string komunikat = "to moja aplikacja";
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Beep();
            Console.WriteLine(komunikat);

            Console.ReadKey();
        }
    }
}
