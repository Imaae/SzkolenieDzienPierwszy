using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab17___ParametryMetod
{
    class Program
    {
        static void Main(string[] args)
        {

            string firstName = "Kubus";
            Console.WriteLine($"{firstName}");
            Upper(firstName);
            Console.WriteLine($"{firstName}");
            //Console.WriteLine($"{nazwa.nazwisko}");

            string lastName = "Puchatek";
            Console.WriteLine($"{lastName}");
            Lower(ref lastName);
            Console.WriteLine($"{lastName}");


            int lenA = 5555;
            GetWodLen(lastName,out lenA);
            Console.WriteLine(lenA);

            GetWodLen(lastName, out int lenB);
            Console.WriteLine(lenB);

            Console.ReadKey();
        }

        static void Upper(string word)
        {
            word = word.ToUpper();
            Console.WriteLine($"{word}");
        }
        static void Lower(ref string word)
        {
            word = word.ToLower();
            Console.WriteLine($"{word}");
        }

        static void GetWodLen ( string word,out int length)
        {
            length = word.Length;
            
        }
    }
}
