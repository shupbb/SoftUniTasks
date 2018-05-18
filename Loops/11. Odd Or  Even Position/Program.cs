using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Odd_Or__Even_Position
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double oddSum = 0;
            double evenSum = 0;
            double oddMax = double.MinValue;
            double oddMin = double.MaxValue;
            double evenMax = double.MinValue;
            double evenMin = double.MaxValue;


            for (int i = 1; i <= n; i++)
            {
                double num = double.Parse(Console.ReadLine());

                if (i % 2 == 1)
                {

                    if (num > oddMax)
                    {
                        oddMax = num;
                    }
                       if (num < oddMin)
                    {
                        oddMin = num;
                    }
                    oddSum += num;
                }
                else
                {
                    if (num > evenMax)
                    {
                        evenMax = num;
                    }
                    if (num < evenMin)
                    {
                        evenMin = num;
                    }
                    evenSum += num;
                }

            }
            Console.WriteLine("OddSum = {0}", oddSum);
            if (oddMin == double.MaxValue)
            {
                Console.WriteLine("OddMin = No");
            }
            else
            {
                Console.WriteLine("OddMin = {0}", oddMin);
            }
            if (oddMax == double.MinValue)
            {
                Console.WriteLine("OddMax = No");
            }
            else
            {
                Console.WriteLine("OddMax = {0}", oddMax);
            }

            Console.WriteLine("EvenSum = {0}", evenSum);
            if (evenMin == double.MaxValue)
            {
                Console.WriteLine("EvenMin = No");
            }
            else
            {
                Console.WriteLine("EvenMin = {0}", evenMin);
            }
            if (evenMax == double.MinValue)
            {
                Console.WriteLine("EvenMax = No");
            }
            else
            {
                Console.WriteLine("EvenMax = {0}", evenMax);
            }
        }
    }
}
