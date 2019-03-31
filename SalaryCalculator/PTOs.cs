using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaryCalculator
{
    public class PTOs
    {
        //Each full-time employee has a 10-day PTO
        public int totalPTOs = 80;
        public PTOs()
        {
         
        }

        //update PTOs
        public void usePTO(int num)
        {
            totalPTOs = totalPTOs - num;
        }

        //Getter of PTO
        public int currentTotalPTOs()
        {
            return totalPTOs;
        }

    }
}
