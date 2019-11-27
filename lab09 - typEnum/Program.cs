using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab09___typEnum
{
    class Program
    {

        enum State1
        {
            Off,
            On,
            Unknown
        }
        enum State2
        {
            Off,
            On=10,
            Unknown
        }
        static void Main(string[] args)
        {
            State1 state1 = State1.Unknown;
            Console.WriteLine($"Stan: {state1}, {Convert.ToInt32(state1)}");
            
            Console.WriteLine();
            State2 state2 = State2.On;
            Console.WriteLine($"Stan: {state2}, {Convert.ToInt32(state2)}");
            state2 = State2.Off;
            Console.WriteLine($"Stan: {state2}, {Convert.ToInt32(state2)}");
            state2 = State2.Unknown;
            Console.WriteLine($"Stan: {state2}, {Convert.ToInt32(state2)}");
            state2 = State2.Off;
            Console.WriteLine($"Stan: {state2}, {Convert.ToInt32(state2)}");
            state2++;
            state2++; 
            state2++;
            Console.WriteLine($"Stan: {state2}, {Convert.ToInt32(state2)}");
            Console.ReadKey();

        }
    }
}
