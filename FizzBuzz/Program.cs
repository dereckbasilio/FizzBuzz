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
            var fizzBuzz = new FizzBuzzClass().GenerateFizzBuzz(10, 30);

            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine(fizzBuzz[i]);
            }
            Console.ReadLine();
        }
    }

}
