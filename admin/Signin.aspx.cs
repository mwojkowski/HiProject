using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using HolyInnocents.App_Code;

namespace HolyInnocents.admin
{
    public partial class Signin : System.Web.UI.Page
    {
        clsLogin user = new clsLogin();//create a new login object
        clsMessage message = new clsMessage();//create new message object to alert the user what's up

        protected void Page_Load(object sender, EventArgs e)
        {

        }//close Page_Load

        protected void LoginButton(object sender, EventArgs e)
        {
            user.username = txtLoginUsername.Text.ToString();
            user.password = user.Encrypt(txtLoginPassword.Text.ToString());


            user.validate(user.username, user.password);
            if (user.authorized)
            {
                user.password = "";//make this blank for security reasons....
                Session["user"] = user;//store the user so we can keep the information in the admin panel

                message.type = "success";
                message.message = "You have successfully logged in. Welcome to the administration panel!";
                Session["message"] = message;

                Response.Redirect("../admin/Default.aspx");//user is authorized. Take them to the admin panel
            }//close if statement
            else
            {
                ErrorLabel.Text = "You have specified invalid credentials.";
            }//close else statement
        }//close LoginButton


    }//close class
}//close namespace