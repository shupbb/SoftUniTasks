using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Square_Frame
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int row = 1; row <= n; row++)
            {
                char usedChar = '|';
                if (row == 1 || row == n)
                {
                    usedChar = '+';
                }

                Console.Write("" + usedChar);
                for (int col = 1; col <= n - 2; col++)
                {
                    Console.Write(" -");
                }
                Console.Write($" {usedChar}");
                Console.WriteLine();

            }


        }
    }
}
