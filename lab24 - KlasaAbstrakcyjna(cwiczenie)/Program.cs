using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab24___KlasaAbstrakcyjna_cwiczenie_
{
    class Program
    {
        static void Main(string[] args)
        {
            CarRobot carRobot = new CarRobot();
            TrainRobot trainRobot = new TrainRobot();

         

             Console.WriteLine($"{carRobot.GiveName()} : {carRobot.Work()}");
            Console.WriteLine($"{trainRobot.GiveName()} : {trainRobot.Work()}");

            Console.ReadKey();
        }
    }
}
