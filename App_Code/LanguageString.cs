using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HolyInnocents.App_Code
{
    public class LanguageString
    {
        public string english { get; set; }
        public string spanish { get; set; }
        public string polish { get; set; }

        public LanguageString()
        {
            english = "";
            spanish = "";
            polish = "";
        }
        public LanguageString(string english, string spanish, string polish)
        {
            this.english = english; 
            this.spanish = spanish;
            this.polish = polish;
        }


    }
}