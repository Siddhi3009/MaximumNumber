using System;

namespace GetMaximumNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Get Maximum Number Program");
            Console.WriteLine("Enter Numbers");
            int output = MaximumNumberCheck.MaximumIntegerNumber(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()));
            Console.WriteLine("Maximum Number: " + output);
        }
    }
}
