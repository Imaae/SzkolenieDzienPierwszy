using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab14___TabliceDwuwymiarowe
{
    class Program
    {
        static void Main(string[] args)
        {
            RandomTab();

            Console.ReadKey();
        }

        private static void RandomTab()
        {
            Random random = new Random();
            int min=0, max = 0, minx = 0, miny = 0, maxx = 0, maxy = 0;
            int[,] tablica = new int[10, 10];

            for (int rowNumber = 0; rowNumber < tablica.GetLength(0); rowNumber++)
            {
                for (int columnNumber = 0; columnNumber < tablica.GetLength(0); columnNumber++)
                {
                    tablica[columnNumber, rowNumber] = random.Next(200);
                }
            }
            min = tablica[0, 0];
            max = tablica[0, 0];

            for (int rowNumber = 0; rowNumber < tablica.GetLength(0); rowNumber++)
            {      
                for (int columnNumber = 0; columnNumber < tablica.GetLength(0); columnNumber++)
                {                
                    if (min > tablica[rowNumber, columnNumber])
                    {
                        min = tablica[rowNumber, columnNumber];
                        minx = rowNumber;
                        miny = columnNumber;
                    }
                    if (max < tablica[rowNumber, columnNumber])
                    {
                        max = tablica[rowNumber, columnNumber];
                        maxx = rowNumber;
                        maxy = columnNumber;
                    }                   
                }
             }


            Console.WriteLine($"  ---0-----1-----2-----3-----4-----5-----6-----7-----8-----9---");
            for (int rowNumber = 0; rowNumber < tablica.GetLength(0); rowNumber++)
            {
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.WriteLine("  -------------------------------------------------------------");
                Console.Write($"{rowNumber} | ");

                for (int columnNumber = 0; columnNumber < tablica.GetLength(0); columnNumber++)
                {
                    
                    if(minx == rowNumber && miny==columnNumber)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write($"{tablica[rowNumber, columnNumber].ToString().PadRight(3)}");
                    }
                    else if (maxx == rowNumber && maxy == columnNumber)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write($"{tablica[rowNumber, columnNumber].ToString().PadRight(3)}");
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write($"{tablica[rowNumber, columnNumber].ToString().PadRight(3)}");
                    }
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    Console.Write(" | ");
                }
                Console.WriteLine("");
            }
            Console.WriteLine("  -------------------------------------------------------------");
            //Console.WriteLine($"{random.Next(200)}");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"min: {min} z pozycji: [{minx},{miny}]");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"max: {max} z pozycji: [{maxx},{maxy}]");
        }
    }
}
