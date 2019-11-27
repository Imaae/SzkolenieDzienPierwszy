using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab10___typEnumSwitch
{
    class Program
    {
        enum State
        {
            Off,
            On,
            Unknown
        }
        static void Main(string[] args)
        {
            State state = State.On;
            switch (state)
            {
                case State.Off:
                    Console.WriteLine($"OFF");
                    break;
                case State.On:
                    Console.WriteLine($"ON");
                    break;
                case State.Unknown:
                    Console.WriteLine($"nieznnay");
                    break;                    
                default:
                    Console.WriteLine($"brak");
                    break;
            }

           // Console.WriteLine($"Stan: {state2}, {Convert.ToInt32(state2)}");
            Console.ReadKey();
        }
    }
}
