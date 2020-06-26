using System;
using System.Collections.Generic;
using System.Text;

namespace practicewithcsharp
{
    class loop
    {
        static void Main(string[] args)
        {
            int counter = 0;
            do
            {
                Console.WriteLine($"Hello World! The counter is {counter}");
                counter++;
            } while (counter < 10);

        }
    }
}
