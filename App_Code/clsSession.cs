using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HolyInnocents.App_Code
{
    public class clsSession
    {
        public string language { get; set; }
        public clsLogin user { get; set; }

        public clsSession()//blank session declares an english language by default...
                            //also creates a blank guest user, which is only used by admin at this point.
        {
            language = "English";
            clsLogin user = new clsLogin();
        }//close constructor




    }
}