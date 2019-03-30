using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaryCalculator
{
    public class SalaryCalculator
    {
        double totalHours;
        double payRate = 21.5;
        public SalaryCalculator()
        {
        
        }
        
        public void setTotalHours(double hours)
        {
            this.totalHours = hours;
        }

        public void salaryCalculator()
        {
            double result = totalHours * payRate;
            Console.WriteLine("Your gross income for this week is $" + result);
        }
    }
}
