using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HolyInnocents.App_Code
{
    public class clsLink
    {
        public string english   { get; set; }
        public string spanish   { get; set; }
        public string polish    { get; set; }
        public string link  { get; set; }

        public clsLink()
        {

            english = "";
            spanish = "";
            polish = "";
            link = "";

        }//underloaded 

        public clsLink(string english, string spanish, string polish, string link)
        {
            this.english = english;
            this.spanish = spanish;
            this.polish = polish;
            this.link = link;
        }//overloaded


    }//class
}//namespace