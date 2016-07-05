using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HolyInnocents.admin
{
    public partial class WebForm5 : System.Web.UI.Page
    {
        clsLogin user;
        protected void Page_Load(object sender, EventArgs e)
        {
            user = new clsLogin();
            Session["User"] = user;
            Response.Redirect("Signin.aspx");
        }
    }
}