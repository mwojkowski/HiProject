using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HolyInnocents.App_Code
{
    public class UserSession
    {
        public int aboutCount { get; set; }
        public string language { get; set; }



        public UserSession(){
            aboutCount = 0;
            language = "English";
        }//close UserSession






    }//close UserSession
}//close namespace