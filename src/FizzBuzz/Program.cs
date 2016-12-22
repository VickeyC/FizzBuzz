using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FizzBuzz
{
    public class Program
    {
        public static void Main(string[] args)
        {
            for (int i = 0; i < 100; i++)
            {
                bool fizz = i % 3 == 0;
                bool buzz = i % 7 == 0;
                if (fizz && buzz)
                    Console.WriteLine("FizzBuzz " + i.ToString());
                else if (fizz)
                    Console.WriteLine("Fizz " + i.ToString());
                else if (buzz)
                    Console.WriteLine("Buzz " + i.ToString());
            }
            Console.ReadLine();
        }
    }
}

