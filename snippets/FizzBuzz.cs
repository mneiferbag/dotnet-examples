/*
 * Copyright (c) 2020 Markus Neifer. All rights reserved.
 */
namespace MnCons.Samples.FizzBuzz
{
    internal class FizzBuzz
    {
        private static void Main()
        {

            for (int i = 1; i < 101; i++)
            {
                if ((i % 3 == 0) && (i % 5 == 0))
                    Console.WriteLine($"{i} - FizzBuzz");
                else if (i % 3 == 0)
                    Console.WriteLine($"{i} - Fizz");
                else if (i % 5 == 0)
                    Console.WriteLine($"{i} - Buzz");
                else
                    Console.WriteLine($"{i}");
            }
        }
    }
}
