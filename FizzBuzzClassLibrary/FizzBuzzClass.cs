using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FizzBuzzClassLibrary
{
    public class FizzBuzzClass
    {
        public void GenerateFizzBuzz(int begin, int end)
        {
            for (int i = begin; i <= end; i++)
            {
                if (i % 15 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
