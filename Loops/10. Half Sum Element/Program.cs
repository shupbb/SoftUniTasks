using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Half_Sum_Element
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int max = int.MinValue;
            int sum = 0;

            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                sum += num;

                if (num > max)
                {
                    max = num;
                }
            }
            if (max == sum - max)
            {
                Console.WriteLine("Yes{0}Sum = {1}", Environment.NewLine, sum - max);
            }
            else
            {
                Console.WriteLine("No{0}Diff = {1}", Environment.NewLine, Math.Abs((sum - max) - max));
            }
        }
    }
}
