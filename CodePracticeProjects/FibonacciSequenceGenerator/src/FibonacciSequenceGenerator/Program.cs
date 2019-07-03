using System;
using System.Collections.Generic;

namespace FinonacciSequenceGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose the length (in number of digits) you would like the Fibonacci Sequence to be:");
            var sequenceLength = int.Parse(Console.ReadLine());

            getSequence(sequenceLength);

        }

        static void getSequence(int sequenceLength)
        {
            var result = "\n";
            ulong x = 0;
            ulong y = 1;
            ulong z = 0;
        
            if(sequenceLength < 2)
            {
                Console.WriteLine("\nYou need at least two numbers to create a sequence!");
            }
            
            else if (SequenceList.Count == 0)
            {
                SequenceList.Add(x);
                SequenceList.Add(y);
            }

            while (SequenceList.Count < sequenceLength)
            {

                z = x + y;
                SequenceList.Add(z);
                x = y;
                y = z;

            };

            foreach (var value in SequenceList)
            {
                result += (value + " ");
            }

            Console.WriteLine(result);
        }

        public static List<ulong> SequenceList = new List<ulong>();
    }
}
