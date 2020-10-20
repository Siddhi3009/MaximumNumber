using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace GetMaximumNumber
{
    public class GenericMaximumCheck<T> where T : IComparable
    {
        public T num1;
        public T num2;
        public T num3;

        public GenericMaximumCheck(T num1, T num2, T num3)
        {
            this.num1 = num1;
            this.num2 = num2;
            this.num3 = num3;
        }
        public T MaximumCheck()
        {
            if ((this.num1.CompareTo(this.num2) > 0 && this.num1.CompareTo(this.num3) > 0) || (this.num1.CompareTo(this.num2) >= 0 && this.num1.CompareTo(this.num3) > 0) || (this.num1.CompareTo(this.num2) > 0 && this.num1.CompareTo(this.num3) >= 0))
            {
                return this.num1;
            }
            if ((this.num2.CompareTo(this.num1) > 0 && this.num2.CompareTo(this.num3) > 0) || (this.num2.CompareTo(this.num1) >= 0 && this.num2.CompareTo(this.num3) > 0) || (this.num2.CompareTo(this.num1) > 0 && this.num2.CompareTo(this.num3) >= 0))
            {
                return this.num2;
            }
            if ((this.num3.CompareTo(this.num2) > 0 && this.num3.CompareTo(this.num1) > 0) || (this.num3.CompareTo(this.num2) >= 0 && this.num3.CompareTo(this.num1) > 0) || (this.num3.CompareTo(this.num2) > 0 && this.num3.CompareTo(this.num1) >= 0))
            {
                return this.num3;
            }

            throw new Exception("first value,second value and third value are same");
        }
        public void PrintMaxValue()
        {
            var output = MaximumCheck();
            Console.WriteLine("Maximum value: " + output);
        }
    }
}
