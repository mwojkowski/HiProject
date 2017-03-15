using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HolyInnocents.App_Code
{
    public class Month
    {
        public string name { get; set; }
        int days { get; set; }
        List<int> holidays = new List<int>();

        public Month(string name, int days){
            this.name = name;
            this.days = days;

        }//close constructor
    }
}