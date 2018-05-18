using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metric_Converter
{
    class Program
    {
        static void Main(string[] args)
        {
            double num = double.Parse(Console.ReadLine());
            string convertFrom = Console.ReadLine();
            string convertTo = Console.ReadLine();

            if (convertFrom == "m")
            {
                if (convertTo == "mm")
                {
                    Console.WriteLine(num * 1000);
                }
                else if (convertTo == "cm")
                {
                    Console.WriteLine(num * 100);
                }
            }
            else if (convertFrom == "mm")
            {
                if (convertTo == "m")
                {
                    Console.WriteLine(num / 1000);
                }
                else if (convertTo == "cm")
                {
                   Console.WriteLine((num / 1000) * 100);
                }
            }
            else if (convertFrom == "cm")
            {
                if (convertTo == "m")
                {
                    Console.WriteLine(num / 100);
                }
                else if (convertTo =="mm")
                {
                    Console.WriteLine((num / 100) * 1000);
                }
            }
        }
    }
}
