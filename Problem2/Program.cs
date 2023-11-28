using System;

namespace Problem2
{
    class Program
    {
        static void Main(string[] args)
        {
            var sum = 0;
            var max = 4000000;
            var current = 0;
            var previous = 1;
            var next = 0;

            do
            {
                if (current % 2 == 0)
                {
                    sum += current;
                }
                next = current + previous;
                previous = current;
                current = next;
            } while (current < max);

            Console.WriteLine(sum);
        }
    }
}