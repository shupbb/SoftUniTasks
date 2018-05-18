using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Sunglasses
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                if (i == 1 || i == n)
                {
                    Console.Write(new string('*', n * 2));
                    Console.Write(new string(' ', n));
                    Console.Write(new string('*', n * 2));
                }
                else
                {
                    Console.Write("*");      
                    Console.Write(new string('/', n * 2 - 2));
                    Console.Write("*");

                    if ((n % 2 != 0 && i == (n - 1) / 2 + 1) || (n % 2 == 0 && i == n / 2))
                    {
                        Console.Write(new string ('|', n));
                    }
                    else
                    {
                        Console.Write(new string(' ', n));
                    }

                    Console.Write("*");
                    Console.Write(new string('/', n * 2 - 2));
                    Console.Write("*");

                }
                Console.WriteLine();
            }
        }
    }
}
                