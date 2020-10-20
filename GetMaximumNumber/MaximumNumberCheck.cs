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
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                return -1;
            }
        }
    }
}
