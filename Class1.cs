﻿using System;

namespace practicewithcsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 0;
            int c = 4;
            if ((a + b + c > 10) || (a == b))
            {
                Console.WriteLine("The answer is greater than 10");
                Console.WriteLine("Or the first number is equal to the second");
            }
            else
            {
                Console.WriteLine("The answer is not greater than 10");
                Console.WriteLine("And the first number is not equal to the second");
            }
            //if (a + b > 10)
            //{ 
            //  Console.WriteLine("The answer is greater than 10");
            //}
            //else
            //{

            //Console.WriteLine("the answer is not greater than 10");
            // }


            //class Loop
            //{
            //    static void Main(string[] args)
            //    {
            int counter = 0;
            do
            {
                Console.WriteLine($"Hello World! The counter is {counter}");
                counter++;
            } while (counter < 10);

            //    }
            //}
        }
    }
}
