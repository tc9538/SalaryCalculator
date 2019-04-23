using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class Contract
    {
        String st = "12/31/19";
        public Contract()
        {

        }

        public void setContractEndDate(String s)
        {
           st = s;
        }
        public String getContractEndDate()
        {
            return st;
        }
    }
}
