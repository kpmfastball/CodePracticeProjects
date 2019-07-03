using System;
using System.Collections.Generic;

namespace PrimeFactorization
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number to get the Prime Factorization\n");
            
            var input = int.Parse(Console.ReadLine());

            getFirstMultiple(input);

            getOtherMultiple(input, primeFactors[0]);

        }

        static void getFirstMultiple(int input)
        {
                
            for(var x = 2; x <= input; x++)
            {
                if(input % x == 0 && input != x)
                {
                    primeFactors.Add(x);
                    Console.WriteLine(x + " was added to the list because it is the first prime factor.");
                    break;
                }
                else if(input == x)
                {
                    Console.WriteLine($"{input} is a prime number, so the prime factorization is 1 x {input}");
                }
            }

        }

        static void getOtherMultiple(int input, int firstMultiple)
        {
            var otherMultiple = input / firstMultiple;
            System.Console.WriteLine($"The other multiple of {input} is {otherMultiple}.");
        }

        static List<int> primeFactors = new List<int>();
    }
}
