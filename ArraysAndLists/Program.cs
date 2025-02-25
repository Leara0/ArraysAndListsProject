using System;
using System.Collections.Generic;

namespace ArraysAndLists
{
    class Program
    {
        static void Main(string[] args)
        {
           var numbers = new int[10];
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = i + 1;
            }

            List<int> evens = new List<int>();

            List<int> odds = new List<int>();

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                    evens.Add(numbers[i]);
                else
                    odds.Add(numbers[i]);
            }

            foreach (var even in evens)
                Console.WriteLine(even);

            for (var i = 0; i < odds.Count; i++)
                Console.WriteLine(odds[i]);
        }

    }
}