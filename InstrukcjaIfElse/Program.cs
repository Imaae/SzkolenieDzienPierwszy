using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstrukcjaIfElse
{
    class Program
    {
        static void Main(string[] args)
        {

            //if (1==2)
            //{
            //    Console.WriteLine($"1==2 => true");
            //}
            //else
            //{
            //    Console.WriteLine($"1==2 => false");
            //}

            int a = 14;
            //int? b = null;
            int b = 5;
            if (a>b)
            {
                Console.WriteLine($"zmienna a={a} wieksza od b={b} ");
            }
            else if(a<b)
            {
                Console.WriteLine($"zmienna b={b} wieksza od a={a} ");
            }
            else
            {
                Console.WriteLine($"zmienna b={b} jest rowna od a={a} ");
            }
            //Console.WriteLine($"iloraz: {zmienna1 / zmienna2}");

            Console.ReadKey();
            //   || - or && - and
            Console.WriteLine();
            if (a>=1 && a<=10)
            {
                Console.WriteLine($"zmienna a={a} w zakresie <1-10>");
            }
            else
            {
                Console.WriteLine($"zmienna a={a} nie jest w zakresie <1-10>");
            }


            Console.Clear();
            Console.WriteLine($"podaj wage [kg]");
            double waga = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"podaj wzrost [m]");
            double wzrost = Convert.ToDouble(Console.ReadLine());

            double bmi = Math.Round((waga / (Math.Pow(wzrost, 2))), 2);
            string komentarz="";
            if (bmi<16)
            {
                komentarz = "wygłodzenie";
            }
            else if (bmi>=16 && bmi<17)
            {
                komentarz = "wychudzenie";
            }
            else if (bmi >= 17 && bmi < 18.5)
            {
                komentarz = "niedowaga";
            }
            else if (bmi >= 18.5 && bmi < 25)
            {
                komentarz = "wartość prawidłowa";
            }
            else if (bmi >= 25 && bmi < 30)
            {
                komentarz = "nadwaga";
            }
            else if (bmi >= 30 && bmi < 35)
            {
                komentarz = "I stopień otyłości";
            }
            else if (bmi >= 35 && bmi < 40)
            {
                komentarz = "II stopień otyłości";
            }
            else if (bmi >= 40)
            {
                komentarz = "otyłość skrajna";
            }
            
            Console.WriteLine($"bmi: {bmi} - {komentarz}");



            Console.ReadKey();
        }
    }
}
