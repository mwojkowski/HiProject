using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HolyInnocents
{
    public class Club
    {
        public string name { get; set; }
        public string description { get; set; }


        public Club()
        {
            this.name = "";
            this.description = "";
        }//close underloaded Constructor

        public Club(string name, string description)
        {
            this.name = name;
            this.description = description;
        }//close overloaded Constructor


    }
}