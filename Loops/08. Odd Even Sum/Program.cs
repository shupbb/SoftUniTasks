using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Odd_Even_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int oddSum = 0;
            int evenSum = 0;

            for (int i = 1; i <= n; i++)
            {
                if (i % 2 == 1)
                {
                    oddSum = oddSum + int.Parse(Console.ReadLine());
                }
                else
                {
                    evenSum = evenSum + int.Parse(Console.ReadLine());
                }
            }

            if (oddSum == evenSum)
            {
                Console.WriteLine("Yes{0}Sum = {1}", Environment.NewLine, oddSum);
            }
            else
            {
                Console.WriteLine("No{0}Diff = {1}", Environment.NewLine, Math.Abs(evenSum - oddSum));
            }
        }
    }
}
