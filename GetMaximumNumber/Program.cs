using System;

namespace GetMaximumNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Get Maximum Number Program");
            Console.WriteLine("Enter integer Numbers");
            int output1 = MaximumNumberCheck.MaximumIntegerNumber(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()));
            Console.WriteLine("Maximum integer Number: " + output1);
            Console.WriteLine("Enter float Numbers");
            float output2 = MaximumNumberCheck.MaximumFloatNumber(float.Parse(Console.ReadLine()), float.Parse(Console.ReadLine()), float.Parse(Console.ReadLine()));
            Console.WriteLine("Maximum float Number: " + output2);
        }
    }
}
