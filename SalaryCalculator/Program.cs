using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaryCalculator
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Choose one of the options below:");
            Console.WriteLine("1. Calculate your gross income of your current week\n" +
                "2. Check your PTOs \n" +
                "3. The ending date of your contract");
       
            //double hourlyRate = double.Parse(Console.ReadLine());
            //Console.WriteLine("How many hours did you work this week?");
            //double workHours = double.Parse(Console.ReadLine());


            if(Console.ReadLine()=="1")
            {
                Console.WriteLine("Enter your hourly rate: ");
                SalaryCalculator sc = new SalaryCalculator();
                sc.setTotalHours(Convert.ToDouble(Console.ReadLine()));
                sc.salaryCalculator();

            }


        }
    }
}
