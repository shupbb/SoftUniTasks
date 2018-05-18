using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Equal_Pairs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            bool areEqual = true;
            int sum = int.MinValue;
            int maxDifference = int.MinValue;
            int previousSum = 0;

            for (int i = 1; i <= n; i += 1)
            {
                int numberA = int.Parse(Console.ReadLine());
                int numberB = int.Parse(Console.ReadLine());
                int currentSum = numberA + numberB;

                if (i == 1)
                {
                    sum = currentSum;
                    previousSum = currentSum;
                }
                else if (currentSum != previousSum)
                {
                    
                    areEqual = false;
                    int diff = Math.Abs(previousSum - currentSum);

                    if (diff > maxDifference)
                    {
                        maxDifference = diff;
                    }
                }
                previousSum = currentSum;
            }
            if (areEqual)
            {
                Console.WriteLine($"Yes, value = {sum} ");
            }
            else
            {
                Console.WriteLine($"No, maxdiff = {maxDifference}");
            }
        }
    }
}
