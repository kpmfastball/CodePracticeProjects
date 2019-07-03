using System;

namespace PiToTheNth
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var run = true;

            do {
                Console.WriteLine("Enter the number of decimals for Pi you would like to see:");
                
                var input = Console.ReadLine();
                var specificity = int.Parse(input);
                var pi = Math.PI;

                if (specificity < 15)
                {
                    Console.WriteLine(Math.Round(pi, specificity));
                    run = false;
                }
                else
                {
                    Console.WriteLine("Sorry! We all have our limits, and unfortunately C# cannot calculate a value of Pi with more than 14 decimals! Try again.");
                }

            } while (run);
        }
    }
}
