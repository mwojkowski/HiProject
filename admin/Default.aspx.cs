using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace HolyInnocents.admin
{
    public partial class Default : System.Web.UI.Page
    {
        clsLogin user;
        clsMessage message;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!((clsMessage)Session["message"] == null)) { 
                message = (clsMessage)Session["message"];

                if (message.type.Equals("success"))
                {
                    messageLiteral.Text = "<h4 class=\"alert_success\">" + message.message + "</h4>";
                
                }
                if (message.type.Equals("error"))
                {
                    messageLiteral.Text = "<h4 class=\"alert_error\">There was an error processing your request: <br />" + message.message + "</h4>";

                }


                message.type = "";    //clear the message type and
                message.message = "";//message so it doesnt set off on other pages.

            }//close if statement

            

        }//close Page_Load
    }//close class
}//close namespace




/*

<h4 class="alert_success">Welcome to the Holy Innocents Administration panel!</h4>
<h4 class="alert_info">Welcome to the Holy Innocents Administration panel!</h4>
<h4 class="alert_error">Welcome to the Holy Innocents Administration panel!</h4>





*/