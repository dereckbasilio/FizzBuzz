using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FizzBuzzClassLibrary
{
    interface IFizzBuzz
    {
        string GenerateFizzBuzz(int value);
    }

    public class FizzBuzzClass//:IFizzBuzz
    {
        public string[] GenerateFizzBuzz(int begin, int end)
        {
            int value = begin;
            string[] fizzbuzz= new string[100];
            for (int i = 0; i < (end - begin) + 1; i++)
            {
                if (value % 15 == 0)
                {
                    fizzbuzz[i] = "FizzBuzz";
                }
                else if (value % 5 == 0)
                {
                    fizzbuzz[i] = "Buzz";
                }
                else if (value % 3 == 0)
                {
                    fizzbuzz[i] = "Fizz";
                }
                else
                {
                    fizzbuzz[i] = value.ToString();
                }
                value++;
            }
            return fizzbuzz;
        }
    }
}
