using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class Salary
    {
        double totalHours;
        double payRate;
        double result;
        public Salary()
        {
            
        }
        
        public void setTotalHours(double hours)
        {
            this.totalHours = hours;
        }

        public void setHourlyRate(double rate)
        {
            this.payRate = rate;
        }

        public void salaryCalculator()
        {
            this.result = totalHours * payRate;
            Console.WriteLine("Your gross income for this week is $" + result);
        }

        public double getCalculatedSalary()
        {
            return this.result;
        }
        
    }
}
