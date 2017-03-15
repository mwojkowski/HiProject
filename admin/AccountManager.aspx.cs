using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using HolyInnocents.App_Code;

namespace HolyInnocents.admin
{
    public partial class WebForm2 : System.Web.UI.Page
    {

        private string connectionString = ConfigurationManager.ConnectionStrings["AzureConnString"].ConnectionString;//connection string
        clsMessage message;


        protected void Page_Load(object sender, EventArgs e)
        {
            if (!((clsMessage)Session["message"] == null))
            {
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

            if (!Page.IsPostBack)
            {
                populateForm();
                
            }//close if not postback
        }//close Page_Load()


        private void populateForm()
        {
            clsLogin account = new clsLogin();
            account = (clsLogin)Session["User"];
            txtAdminName.Text = account.username;
            
        }//close populateForm()

        protected void updateAccount(object sender, EventArgs e)
        {
            if(checkUpdatePassword.Checked){
                clsLogin account = new clsLogin();
                account = (clsLogin)Session["User"];
                account.password = account.Encrypt(txtPassword.Text.ToString());


                SqlConnection c = new SqlConnection(connectionString);

                c.Open();

                SqlCommand cmd;
                try
                {
                    cmd = c.CreateCommand();
                    cmd.CommandText = "UPDATE Users SET password = @password WHERE username = @username;";
                    cmd.Parameters.AddWithValue("@password", account.password);
                    cmd.Parameters.AddWithValue("@username", account.username);

                    cmd.ExecuteNonQuery();

                }//close try statement
                catch (Exception ex)
                {
                    message.type = "error";
                    message.message = "There was an error in processing your account update.\n " + ex.Message + "\nPlease contact your system administrator.";
                    Session["mesage"] = message;
                    Console.WriteLine(ex.Message);
                }//close catch exception


                finally
                {
                    if (c.State == ConnectionState.Open)
                    {
                        c.Close();
                    }//close if statement
                }//close finally statement

                message.type = "success";
                message.message = "Your account was updated successfully.";
                Session["mesage"] = message;

                Response.Redirect("Default.aspx");

            }//close checked checkbox
            else
            {

                message.type = "error";
                message.message = "There was an error updating your account. \n Please check the Update Password checkbox to update your password.";
                Session["mesage"] = message;
            }



        }//close updateAccount()

    }//close class
}//close namespace