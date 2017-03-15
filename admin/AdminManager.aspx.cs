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
    public partial class WebForm3 : System.Web.UI.Page
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["AzureConnString"].ConnectionString;//connection string
        clsMessage message;       // clsLogin user;

        protected void Page_Load(object sender, EventArgs e)
        {
            
        }//close Page_Load

        /*private bool authenticateAccess()
        {
            SqlConnection c = new SqlConnection(connectionString);

            c.Open();

            SqlCommand cmd;
            DataTable x = new DataTable();

            try
            {
                cmd = c.CreateCommand();
                cmd.CommandText = "SELECT AccessLevel FROM USERS where Username = @username;";
                cmd.Parameters.AddWithValue("@username", user.username);
                SqlDataAdapter a = new SqlDataAdapter();

                a.Fill(x);

            }//close try statement
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }//close catch statement
            finally
            {
                if (c.State == ConnectionState.Open)
                {
                    c.Close();
                }//close if statement
            }//close finally statement

            int accessLevel = Convert.ToInt32(x.Rows[0]["AccessLevel"]);

            if (accessLevel == 0)
            {
                return true;
            }//close if statement
            else
            {
                return false;
            }//close else statement

        }//close authenticateAccess()*///

        protected void adminSelection(object sender, EventArgs e)
        {
            SqlConnection c = new SqlConnection(connectionString);

            DataTable x = new DataTable();

            c.Open();

            SqlCommand cmd;

            try
            {
                cmd = c.CreateCommand();
                cmd.CommandText = "SELECT Active FROM Users WHERE id = @id;";
                cmd.Parameters.AddWithValue("@id", comboAdminList.SelectedValue);

                SqlDataAdapter q = new SqlDataAdapter(cmd);

                q.Fill(x);

            }//close try statement
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }//close catch exception


            finally
            {
                if (c.State == ConnectionState.Open)
                {
                    c.Close();
                }//close if statement
            }//close finally statement

            radioActive.SelectedValue = x.Rows[0]["Active"].ToString();




        }//close adminSelection

        protected void updateButton(object sender, EventArgs e)
        {
            if (UpdatePassword.Checked)
            {
                clsLogin account = new clsLogin();
                account = (clsLogin)Session["User"];
                account.password = account.Encrypt(txtPasswordReset.Text.ToString());


                SqlConnection c = new SqlConnection(connectionString);

                c.Open();

                SqlCommand cmd;
                try
                {
                    cmd = c.CreateCommand();
                    cmd.CommandText = "UPDATE Users SET password = @password WHERE username = @username;";
                    cmd.Parameters.AddWithValue("@password", account.password);
                    cmd.Parameters.AddWithValue("@username", comboAdminList.Text);

                    cmd.ExecuteNonQuery();

                }//close try statement
                catch (Exception ex)
                {
                    //message.type = "error";
                    //message.message = "There was an error in processing your account update.\n " + ex.Message + "\nPlease contact your system administrator.";
                    //Session["mesage"] = message;
                    Console.WriteLine(ex.Message);
                }//close catch exception


                finally
                {
                    if (c.State == ConnectionState.Open)
                    {
                        c.Close();
                    }//close if statement
                }//close finally statement

                //message.type = "success";
                //message.message = "Your account was updated successfully.";
                //Session["mesage"] = message;

                Response.Redirect("Default.aspx");

            }//close checked checkbox
            else
            {

                message.type = "error";
                message.message = "There was an error updating your account. \n Please check the Update Password checkbox to update your password.";
                Session["mesage"] = message;
            }
        }//close updateButton

    }//close class
}//close namespace