using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20.Smart_Lili
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());
            double washMasterPrice = double.Parse(Console.ReadLine());
            int toyPrice = int.Parse(Console.ReadLine());

            int maxSavedMoney = 0;
            int currentGottenMoney = 0;
            int badBrotherTaken = 0;
            int totalToyPrice = 0;


            for(int currentAge = 1; currentAge < age; currentAge++)
            {
                if (currentAge % 2 == 0)
                {
                    currentGottenMoney = currentGottenMoney + 10;
                    maxSavedMoney = maxSavedMoney + currentGottenMoney;

                    badBrotherTaken = badBrotherTaken + 1;
                }
                else
                {
                    totalToyPrice = totalToyPrice + toyPrice;  
                }
            }

            int maxPrice = maxSavedMoney + totalToyPrice - badBrotherTaken;

            if (washMasterPrice <= maxPrice)
            {
                double difference = maxPrice - washMasterPrice;
                Console.WriteLine($"Yes {difference:F2}");
            }
            else
            {
                double difference = washMasterPrice - maxPrice;
                Console.WriteLine($"No! {difference:F2}");
            }

        }
    }
}
