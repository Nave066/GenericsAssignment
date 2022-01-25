using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMaximumNumber
{
    class MaximumNumberCheck
    {
        public static int MaximumIntegerNumber(int firstValue, int secondValue,int thirdValue)
        {
            if (firstValue.CompareTo(secondValue) > 0 && firstValue.CompareTo(thirdValue) > 0)
            {
               // Console.WriteLine("The biggest Value is" +firstValue);
                return firstValue;
            }
            else if (secondValue.CompareTo(firstValue) > 0 && secondValue.CompareTo(thirdValue) > 0)
            {
                //Console.WriteLine("The biggest Value is" + secondValue);
                return secondValue;
            }
            else if (thirdValue.CompareTo(firstValue) > 0 && thirdValue.CompareTo(secondValue) > 0)
            {
                //Console.WriteLine("The biggest Value is" + thirdValue);
                return thirdValue;            
            }
            throw new Exception("All the values are same");
        }
        public static double MaximumDoubleNumber(double firstValue, double secondValue, double thirdValue)
        {
            if (firstValue.CompareTo(secondValue) > 0 && firstValue.CompareTo(thirdValue) > 0)
            {
                //Console.WriteLine("The biggest Value is" + firstValue);
                return firstValue;
            }
            else if (secondValue.CompareTo(firstValue) > 0 && secondValue.CompareTo(thirdValue) > 0)
            {
                //Console.WriteLine("The biggest Value is" + secondValue);
                return secondValue;
            }
            else if (thirdValue.CompareTo(firstValue) > 0 && thirdValue.CompareTo(secondValue) > 0)
            {
                //Console.WriteLine("The biggest Value is" + thirdValue);
                return thirdValue;
            }
            throw new Exception("All the values are same");
        }
        public static string MaximumStringNumber(string firstString, string secondString, string thirdString)
        {
            if (firstString.CompareTo(secondString) > 0 && firstString.CompareTo(thirdString) > 0 || 
                firstString.CompareTo(secondString) >= 0 && firstString.CompareTo(thirdString) > 0 ||
                firstString.CompareTo(secondString) > 0 && firstString.CompareTo(thirdString) >= 0)
            {
               // Console.WriteLine("The biggest Value is" + firstValue);
                return firstString;
            }
            if (secondString.CompareTo(firstString) > 0 && secondString.CompareTo(thirdString) > 0 ||
                secondString.CompareTo(firstString) >= 0 && secondString.CompareTo(thirdString) > 0 ||
                secondString.CompareTo(firstString) > 0 && secondString.CompareTo(thirdString) >= 0)
            {
                //Console.WriteLine("The biggest Value is" + secondValue);
                return secondString;
            }
            if (thirdString.CompareTo(firstString) > 0 && thirdString.CompareTo(secondString) > 0 ||
                thirdString.CompareTo(firstString) >= 0 && thirdString.CompareTo(secondString) > 0 ||
                thirdString.CompareTo(firstString) > 0 && thirdString.CompareTo(secondString) >= 0)
            {
                //Console.WriteLine("The biggest Value is" + secondValue);
                return thirdString;
            }
            throw new Exception("All the values are same");
        }
    }
}
