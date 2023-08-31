using System;

namespace _07__Arrays
{
    class Program
    {
        public static void GetOdd(int[] Array)
        {
            Console.Write("Odd numbers: ");
            foreach (int num in Array)
            {
                if (num % 2 != 0)
                {
                    Console.Write(num + " ");
                }
            }
            Console.WriteLine();
        }

        public static void GetEven(int[] Array)
        {
            Console.Write("Even numbers: ");
            foreach (int num in Array)
            {
                if (num % 2 == 0)
                {
                    Console.Write(num + " ");
                }
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            GetOdd(array);
            GetEven(array);
        }
    }
}
