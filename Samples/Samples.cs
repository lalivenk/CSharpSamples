using System;

namespace Samples
{
    class Samples
    {
        /// <summary>
        ///  This can be optimized and this method can be documented, but leaving all that out for the sake of adding the code quicker
        /// </summary>
        /// <param name="n"></param>
        public void FizzBuzz(int n)
        {
            if (n < 0)
            {
                Console.WriteLine("For the sake of simplicity, this FizzBuzz program accepts only positive numbers now, try your luck at a later time the support for negative numbers might be added later :-)");
                return;
            }

            if (n < 3)
            {
                Console.WriteLine("If you want to see Fizz/Buzz/FizzBuzz, you need to pass in a number that is >= 3)");
                return;
            }
            
            Console.WriteLine($"\nFizz Buzz for numbers up to {n}");
            for (int i = 2; i <= n; i++)
            {
                if (i % 15 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadKey();
        }

        public static void Main()
        {
            Samples samples = new Samples();
            
            // To test invalid argument
            //samples.FizzBuzz(-1);

            //For boundary testing
            //samples.FizzBuzz(0);
            //samples.FizzBuzz(3);

            samples.FizzBuzz(40);

            //We can write more tests, but I guess this gives a gist 
        }
    }
}
