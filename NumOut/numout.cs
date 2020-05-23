using System;

namespace NumOut
{
    class numout
    {
        static void Main(string[] args)
        {
            double value = 987654.321d;

            Console.WriteLine("The number in two decimal points is {0}", value.ToString(".00"));
            Console.WriteLine("The number in integer {0}", value.ToString("N2"));
            Console.WriteLine("The number in Currency value is {0}", value.ToString("C"));

            Console.ReadLine();
        }
    }
}
