using System;
using System.Collections.Generic;
using System.Text;

namespace GetMaximumNumber
{
    public class MaximumNumberCheck
    {
        public static int MaximumIntegerNumber(int num1, int num2, int num3)
        {
            try
            {
                if ((num1.CompareTo(num2) > 0 && num1.CompareTo(num3) > 0) || (num1.CompareTo(num2) >= 0 && num1.CompareTo(num3) > 0) || (num1.CompareTo(num2) > 0 && num1.CompareTo(num3) >= 0))
                {
                    return num1;
                }
                if ((num2.CompareTo(num1) > 0 && num2.CompareTo(num3) > 0) || (num2.CompareTo(num1) >= 0 && num2.CompareTo(num3) > 0) || (num2.CompareTo(num1) > 0 && num2.CompareTo(num3) >= 0))
                {
                    return num2;
                }
                if ((num3.CompareTo(num2) > 0 && num3.CompareTo(num1) > 0) || (num3.CompareTo(num2) >= 0 && num3.CompareTo(num1) > 0) || (num3.CompareTo(num2) > 0 && num3.CompareTo(num1) >= 0))
                {
                    return num3;
                }
                else
                    throw new Exception("firstNumber,secondNumber and thirdNumber are same");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return -1;
            }
        }
        public static float MaximumFloatNumber(float num1, float num2, float num3)
        {
            try
            {
                if ((num1.CompareTo(num2) > 0 && num1.CompareTo(num3) > 0) || (num1.CompareTo(num2) >= 0 && num1.CompareTo(num3) > 0) || (num1.CompareTo(num2) > 0 && num1.CompareTo(num3) >= 0))
                {
                    return num1;
                }
                if ((num2.CompareTo(num1) > 0 && num2.CompareTo(num3) > 0) || (num2.CompareTo(num1) >= 0 && num2.CompareTo(num3) > 0) || (num2.CompareTo(num1) > 0 && num2.CompareTo(num3) >= 0))
                {
                    return num2;
                }
                if ((num3.CompareTo(num2) > 0 && num3.CompareTo(num1) > 0) || (num3.CompareTo(num2) >= 0 && num3.CompareTo(num1) > 0) || (num3.CompareTo(num2) > 0 && num3.CompareTo(num1) >= 0))
                {
                    return num3;
                }
                else
                    throw new Exception("firstNumber,secondNumber and thirdNumber are same");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return -1;
            }
        }
        public static string MaximumString(string string1, string string2, string string3)
        {
            try
            {
                if ((string1.CompareTo(string2) > 0 && string1.CompareTo(string3) > 0) || (string1.CompareTo(string2) >= 0 && string1.CompareTo(string3) > 0) || (string1.CompareTo(string2) > 0 && string1.CompareTo(string3) >= 0))
                {
                    return string1;
                }
                if ((string2.CompareTo(string1) > 0 && string2.CompareTo(string3) > 0) || (string2.CompareTo(string1) >= 0 && string2.CompareTo(string3) > 0) || (string2.CompareTo(string1) > 0 && string2.CompareTo(string3) >= 0))
                {
                    return string2;
                }
                if ((string3.CompareTo(string2) > 0 && string3.CompareTo(string1) > 0) || (string3.CompareTo(string2) >= 0 && string3.CompareTo(string1) > 0) || (string3.CompareTo(string2) > 0 && string3.CompareTo(string1) >= 0))
                {
                    return string3;
                }
                else
                    throw new Exception("firstNumber,secondNumber and thirdNumber are same");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return "";
            }
        }
        public static T MaximumCheck<T>(T num1, T num2, T num3) where T : IComparable
        {
            if ((num1.CompareTo(num2) > 0 && num1.CompareTo(num3) > 0) || (num1.CompareTo(num2) >= 0 && num1.CompareTo(num3) > 0) || (num1.CompareTo(num2) > 0 && num1.CompareTo(num3) >= 0))
            {
                return num1;
            }
            if ((num2.CompareTo(num1) > 0 && num2.CompareTo(num3) > 0) || (num2.CompareTo(num1) >= 0 && num2.CompareTo(num3) > 0) || (num2.CompareTo(num1) > 0 && num2.CompareTo(num3) >= 0))
            {
                return num2;
            }
            if ((num3.CompareTo(num2) > 0 && num3.CompareTo(num1) > 0) || (num3.CompareTo(num2) >= 0 && num3.CompareTo(num1) > 0) || (num3.CompareTo(num2) > 0 && num3.CompareTo(num1) >= 0))
            {
                return num3;
            }

            throw new Exception("first value,second value and third value are same");
        }

    }
}
