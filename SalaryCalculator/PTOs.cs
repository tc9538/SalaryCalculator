using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaryCalculator
{
    class PTOs
    {
        int totalPTOs;
        PTOs(int numPTOs)
        {
            totalPTOs = numPTOs;
        }

        //update PTOs
        void usePTO(int num)
        {
            totalPTOs = totalPTOs - num;
        }

        int currentTotalPTOs()
        {
            return totalPTOs;
        }
    }
}
