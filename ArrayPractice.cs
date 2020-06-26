using System;
using System.Collections.Generic;
using System.Text;

namespace practicewithcsharp
{
    class ArrayPractice
    { 
     static void Main(string[] args)
     {
        var names = new List<string> { "<name>", "Ana", "Felipe" };
        foreach (var name in names)
        {
            Console.WriteLine($"Hello {name.ToUpper()}!");
        }
     }
    } 
  
}
