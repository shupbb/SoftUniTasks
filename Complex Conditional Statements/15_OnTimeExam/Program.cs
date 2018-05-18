using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_OnTimeExam
{
    class Program
    {
        static void Main(string[] args)
        {
            int hourExam = int.Parse(Console.ReadLine());
            int minutesExam = int.Parse(Console.ReadLine());
            int hoursArrival = int.Parse(Console.ReadLine());
            int minutesArrival = int.Parse(Console.ReadLine());

            int examTotalMinutes = (hourExam * 60) + minutesExam;
            int arrivalTotalMinutes = (hoursArrival * 60) + minutesArrival;

            if (arrivalTotalMinutes <= examTotalMinutes && arrivalTotalMinutes >= examTotalMinutes - 30)
            {
                int timeBeforeExamStart = examTotalMinutes - arrivalTotalMinutes;
                Console.WriteLine("On time");
                if (timeBeforeExamStart >= 60)
                {
                    Console.WriteLine($"{timeBeforeExamStart / 60}:{timeBeforeExamStart % 60:D2} hours after the start");

                }
                else
                {
                    Console.WriteLine($"{timeBeforeExamStart} minutes before the start");

                }
            }
            else if (arrivalTotalMinutes < examTotalMinutes - 30)
            {
                int timeBeforeExamStart = examTotalMinutes - arrivalTotalMinutes;
                Console.WriteLine("Early");
                if (timeBeforeExamStart >= 60)
                {
                    Console.WriteLine($"{timeBeforeExamStart / 60}:{timeBeforeExamStart % 60:D2} hours before the start");

                }
                else
                {
                    Console.WriteLine($"{timeBeforeExamStart} minutes before the start");

                }

            }
            else
            {
                Console.WriteLine("Late");

                int timeBeforeExamStart = arrivalTotalMinutes - examTotalMinutes;
                if (timeBeforeExamStart >= 60)
                {
                    Console.WriteLine($"{timeBeforeExamStart / 60}:{timeBeforeExamStart % 60} hours after the start");

                }
                else
                {
                    Console.WriteLine($"{timeBeforeExamStart} minutes after the start");

                }

            }
        }
    }
}
