using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    class Program
    {
        public static void Main(string[] args)
        {

            
            Console.WriteLine("1. Calculate your gross income of your current week\n" +
                "2. Check your PTOs \n" +
                "3. The ending date of your contract\n");
            Console.WriteLine("Choose one of the options above or enter 'Q' to quit the application");
            String st = Console.ReadLine();

            while (st != "Q")
            {

                if (st == "1")
                {
                    Console.WriteLine("Enter your total work hours: ");
                    Salary sc = new Salary();
                    sc.setTotalHours(Convert.ToDouble(Console.ReadLine()));
                    Console.WriteLine("Enter your hoursly pay rate: ");
                    sc.setHourlyRate(Convert.ToDouble(Console.ReadLine()));
                    sc.salaryCalculator();

                }
                else if (st == "2")
                {
                    PTOs pto = new PTOs();
                    Console.WriteLine("Would you like to use your PTOs? Enter Y or N?");
                    String input = Console.ReadLine();
                    if (input == "Y" || input == "y")
                    {
                        Console.WriteLine("How many hours would you like to use?");
                        pto.usePTO(Convert.ToInt32(Console.ReadLine()));
                        Console.WriteLine("You have " + pto.getCurrentTotalPTOs() + " hours of PTO left");

                    }
                else
                 {
                     Console.WriteLine("You have " + pto.getCurrentTotalPTOs() + " hours of PTO left");
                 }


                }
                else
                {
                    Contract c = new Contract();
                    Console.WriteLine("Your contract will end on " + c.getContractEndDate());
                }

                Console.WriteLine("****************************************************");
                Console.WriteLine("What would you like to do today?");
                Console.WriteLine("1. Calculate your gross income of your current week\n" +
                "2. Check your PTOs \n" +
                "3. The ending date of your contract\n");
                Console.WriteLine("Choose one of the options above or enter 'Q' to quit the application");
                st = Console.ReadLine();

                //Console.Read(); // DREW, ADDED SO THAT CONSOLE DOESN'T IMMEDIATELY DISAPPEAR
            }

            
        }
    }
}
