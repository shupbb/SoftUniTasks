using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Check_Conditions
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isHungry = true;
            if (isHungry)
            {
                bool havefood = true;
                if (havefood)
                {
                    Console.WriteLine("Yes, I have food");
                }
                else
                {
                    Console.WriteLine("Please buy food!");
                }
            }
            else
            {
                Console.WriteLine("Life is great");
            }
        }
    }
}
