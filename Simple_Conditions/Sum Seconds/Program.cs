﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_Seconds
{
    class Program
    {
        static void Main(string[] args)
        {
            int timeA = int.Parse(Console.ReadLine());
            int timeB = int.Parse(Console.ReadLine());
            int timeC = int.Parse(Console.ReadLine());
            int sum = timeA + timeB + timeC;

            int minutes = sum / 60;
            int seconds = sum % 60;
            Console.WriteLine($"{minutes}:{seconds:D2}");
        }
    }
}
