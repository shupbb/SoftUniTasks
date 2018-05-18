using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatchTickets 
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string category = Console.ReadLine();
            int count = int.Parse(Console.ReadLine());

            double ticketPrice = 0.0;
            if (category == "VIP")
            {
                ticketPrice = 499.99;
            }
            else if (category == "Normal")
            {
                ticketPrice = 249.99;
            }

            if (count >= 1 && count <=4)
            {
                budget = budget - (budget * (75.0 / 100.0));
            }
            else if (count >= 5 && count <= 9)
            {
                budget = budget - (budget * (60.0 / 100.0));
            }
            else if (count >= 10 && count <= 24)
            {
                budget = budget - (budget * (50.0 / 100.0));
            }
            else if (count >= 25 && count <= 49)
            {
                budget = budget - (budget * (40.0 / 100.0));
            }
            else if (count >= 50)
            {
                budget = budget - (budget * (25.0 / 100.0));
            }

            if ((ticketPrice * count) <= budget)
            {
                Console.WriteLine($"Yes! You have {budget - (ticketPrice * count):F2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {(ticketPrice * count) - budget:F2} leva.");
            }
        }
    }
}
