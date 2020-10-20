using System;

namespace GetMaximumNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            //Generic Class

            Console.WriteLine("Welcome to Get Maximum Number Program");
            int[] intArray = { 56, 7, 89, 98, 3 };
            GenericMaximumCheck<int> genericInt = new GenericMaximumCheck<int>(intArray);
            genericInt.PrintMaxValue();
            float[] floatArray = { 6.5F, 85.65F, 94.65F, 3.98F};
            GenericMaximumCheck<float> genericFloat = new GenericMaximumCheck<float>(floatArray);
            genericFloat.PrintMaxValue();
            string[] stringArray = {"Apple", "Peach", "Banana", "Mango", "papaya" };
            GenericMaximumCheck<string> genericString = new GenericMaximumCheck<string>(stringArray);
            genericString.PrintMaxValue();

            //GenericMethod

            //Console.WriteLine("Enter values to be compared");
            //int output1 = MaximumNumberCheck.MaximumCheck<int>(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()));
            //Console.WriteLine("Maximum value: " + output1);
            //Console.WriteLine("Enter values to be compared");
            //float output2 = MaximumNumberCheck.MaximumCheck<float>(float.Parse(Console.ReadLine()), float.Parse(Console.ReadLine()), float.Parse(Console.ReadLine()));
            //Console.WriteLine("Maximum value: " + output2);
            //Console.WriteLine("Enter values to be compared");
            //string output3 = MaximumNumberCheck.MaximumCheck<string>(Console.ReadLine(), Console.ReadLine(), Console.ReadLine());
            //Console.WriteLine("Maximum value: " + output3);

            //Normal Method

            //Console.WriteLine("Enter integer Numbers");
            //int output1 = MaximumNumberCheck.MaximumIntegerNumber(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()));
            //Console.WriteLine("Maximum integer Number: " + output1);
            //Console.WriteLine("Enter float Numbers");
            //float output2 = MaximumNumberCheck.MaximumFloatNumber(float.Parse(Console.ReadLine()), float.Parse(Console.ReadLine()), float.Parse(Console.ReadLine()));
            //Console.WriteLine("Maximum float Number: " + output2);
            //Console.WriteLine("Enter strings");
            //string output3 = MaximumNumberCheck.MaximumString(Console.ReadLine(), Console.ReadLine(), Console.ReadLine());
            //Console.WriteLine("Maximum string: " + output3);
        }
    }
}
