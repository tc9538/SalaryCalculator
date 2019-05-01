using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class PTOs
    {
        //Each full-time employee has a 10-day PTO
        public int totalPTOs = 80;
        Hashtable table = new Hashtable();
        public PTOs()
        {
         
        }

        //update PTOs
        public void usePTO(int num)
        {
            if (num > 80)
            {
                Console.WriteLine("You only have 80 hours for PTO");
            }
            else
            {
                totalPTOs = totalPTOs - num;
            }
            
        }

        //Getter of PTO
        public int getCurrentTotalPTOs()
        {
            return totalPTOs;
        }

        //public void storeData()
        //{
        //    Hashtable table = new Hashtable();
        //    table.Add("Truc", 80);
        //    table.Add("Drew", 70);
        //}

        public void getPTOByName(String name)
        {
            if(table.ContainsKey("Truc") == true)
            {
                this.totalPTOs = (int)(table["Truc"]);
            }

            else
            {
                this.totalPTOs = (int)(table["Drew"]);
            }
        }


    }
}
