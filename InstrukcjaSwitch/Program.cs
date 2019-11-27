using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstrukcjaSwitch
{
    class Program
    {
        static void Main(string[] args)
        {
            //switch (0)
            //{
            //    case 1:
            //        Console.WriteLine($"1");
            //        break;
            //    case 2:
            //        Console.WriteLine($"2");
            //        break;                
            //    case 4:
            //        Console.WriteLine($"4");
            //        break;
            //    case 5:
            //    case 6:
            //        Console.WriteLine($"5/6");
            //        break;

            //    default:
            //        Console.WriteLine($"nie 1,2,4,5,6");
            //        break;
            //}


           
            string day = DateTime.Now.DayOfWeek.ToString().ToLower();
            string day_pl;
            switch (day)
            {
                case "monday":
                    day_pl = "poniedziałek";
                    break;
                case "tuesday":
                    day_pl = "wtorek";
                    break;
                case "wednesday":
                    day_pl = "środa";
                    break;
                case "thursday":
                    day_pl = "czwartek";
                    break;
                case "friday":
                    day_pl = "piatek";
                    break;
                case "saturnday":
                    day_pl = "sobota";
                    break;
                default:
                    day_pl = "niedziela";
                    break;
            }
            Console.WriteLine($"dzis jest : {day_pl}");

           

            Console.ReadKey();

        }
    }
}
