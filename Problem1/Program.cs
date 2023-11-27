using System;

namespace Problem1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declare a variable to store the sum
            int sum = 0;

            // Loop through all the numbers from 1 to 999
            for (int i = 1; i < 1000; i++)
            {
                // Check if the number is divisible by 3 or 5
                if (i % 3 == 0 || i % 5 == 0)
                {
                    // Add the number to the sum
                    sum += i;
                }
            }

            // Write the sum to the console
            Console.WriteLine(sum);
        }
    }
}