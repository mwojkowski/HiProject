using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using HolyInnocents.App_Code;

namespace HolyInnocents.admin
{
    public partial class AdminPanel : System.Web.UI.MasterPage
    {
        clsLogin user;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["User"] != null)
            {
                user = (clsLogin)Session["User"];
                if (user.authorized)
                {
                    userNameLabel.Text = user.username;
                }
                else
                {
                    Response.Redirect("../admin/Signin.aspx");
                }//close else statement
            }//close if statemenmt
            else
            {
                Response.Redirect("../admin/Signin.aspx");
            }//close else statement
        
        }//close Page_Load

    }//close class
}//close namespace