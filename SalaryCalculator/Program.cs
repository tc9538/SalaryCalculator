using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaryCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your hourly rate: ");
            double hourlyRate = double.Parse(Console.ReadLine());
            Console.WriteLine("How many hours did you work this week?");
            double workHours = double.Parse(Console.ReadLine());

            Console.WriteLine("Your gross income for this week is $" + hourlyRate*workHours);

        }
    }
}
