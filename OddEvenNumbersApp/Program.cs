using System;
using System.Collections.Generic;
using System.Linq;

namespace OddEvenNumbersApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            PrintNumber("Numbers", numbers);
            PrintNumber("Even No", numbers.Where(x=>(IsEven(x))));
            PrintNumber("Odd No", numbers.Where(x => (IsOdd(x))));


            Console.ReadKey();
        }
        static void PrintNumber(string title,IEnumerable<int> numbers)
        {
            Console.WriteLine();
            Console.Write($"{title} : [ ");
            foreach (var n in numbers)
            {
                Console.Write($" { n }");

            }
            Console.Write(" ]");
            Console.WriteLine();

        }
        static bool IsEven(int number)
        {
            if (number%2==0) 
                return true;
            else return false;
        }
        static bool IsOdd(int number)
        {
            if (number % 2 != 0)
                return true;
            else return false;
        }
    }
}
