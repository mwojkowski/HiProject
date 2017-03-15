using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HolyInnocents.App_Code
{
    public class Calendar
    {
        List<Month> months = new List<Month>();

        public Calendar(){

        }

        public void addMonth(Month x){
            months.Add(x);
        }//close addMonth
            
    }//close class
}