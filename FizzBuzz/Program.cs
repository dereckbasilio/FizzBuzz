using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FizzBuzzClassLibrary;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            var fizzBuzz = new FizzBuzzClass();
            fizzBuzz.GenerateFizzBuzz(10,30);
            Console.ReadLine();
        }
    }
}
