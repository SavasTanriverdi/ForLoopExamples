using System;

namespace ForLoopExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1'den 10'a kadar olan sayıları yazdırma
            Console.WriteLine("Numbers from 1 to 10:");
            for (int i = 1; i <= 10; i++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            // 10'dan 1'e kadar olan sayıları tersten yazdırma
            Console.WriteLine("Numbers from 10 to 1:");
            for (int i = 10; i >= 1; i--)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            // 1 ile 20 arasındaki çift sayıları yazdırma
            Console.WriteLine("Even numbers from 1 to 20:");
            for (int i = 1; i <= 20; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write(i + " ");
                }
            }
            Console.WriteLine();

            // Faktöriyel hesaplama
            Console.Write("Enter a number to calculate its factorial: ");
            int number = int.Parse(Console.ReadLine());
            int factorial = 1;

            for (int i = 1; i <= number; i++)
            {
                factorial *= i;
            }

            Console.WriteLine($"Factorial of {number} is: {factorial}");
        }
    }
}