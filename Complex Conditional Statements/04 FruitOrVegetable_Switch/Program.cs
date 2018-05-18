using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_FruitOrVegetable_Switch
{
    class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine().ToLower();

            switch (product)
            {
                case "banana":
                case "apple":
                case "kiwi":
                case "cherry":
                case "lemon":
                case "grapes":
                    Console.WriteLine("fruit");
                    break;
                case "cucumber":
                case "tomato":
                case "pepper":
                case "carrot":
                    Console.WriteLine("vegetable");
                    break;

                default:
                    Console.WriteLine("unknown");
                    break;
                 
            }
        }
    }
}
