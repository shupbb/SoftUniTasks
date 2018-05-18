using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Christmas_Tree
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int row = 1; row <= n + 1; row++)
            {
                Console.Write(new string(' ', n - row + 1));
                Console.Write(new string('*', row - 1));
                Console.Write(" | ");
                Console.Write(new string('*', row - 1));
                Console.WriteLine();
            }
        }
    }
}
