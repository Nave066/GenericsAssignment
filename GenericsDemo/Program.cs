using System;

namespace GenericsDemo
{
    internal class Program
    {
        public static void Main(String[] args)
        {
            int[] intArray = { 1, 2, 3, 4, 5, };
            double[] doubleArray = { 1.1, 2.2, 3.3, 4.4 };
            char[] charArray = { 'H', 'E', 'L', 'L', 'O' };
            Display(intArray);
            Display(charArray);
            Display(doubleArray);
            Console.ReadKey();
        }

        //public static void Display<T>(T[] test)
        //{
        //    for (int i = 0; i < test.Length; i++)
        //    {
        //        Console.Write(test[i] + " ");
        //    }
        //    Console.WriteLine();
        //}
        public static void Display(int[] input)
        {
            foreach (int element in input)
            {
                Console.WriteLine(element);
            }
        }
        public static void Display(char[] input)
        {
            foreach (char element in input)
            {
                Console.WriteLine(element);
            }
        }
        public static void Display(double[] input)
        {
            foreach (double element in input)
            {
                Console.WriteLine(element);
            }
        }
    }
}
