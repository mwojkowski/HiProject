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
    public partial class WebForm4 : System.Web.UI.Page
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["AzureConnString"].ConnectionString;//connection string

        protected void Page_Load(object sender, EventArgs e)
        {

        }//close Page_Load

        protected void createAdmin(object sender, EventArgs e)
        {
            clsLogin newAdmin = new clsLogin(txtUsername.Text, txtPassword.Text);

            SqlConnection c = new SqlConnection(connectionString);

            SqlCommand cmd;

            try
            {
                c.Open();
                cmd = c.CreateCommand();
                cmd.CommandText = "INSERT INTO Users (Username, Password, AccessLevel, FirstName, LastName," +
                    "Address, City, State, Zip, Phone, Active) Values (@username, @password, @access, @fn, @ln, @address," +
                    "@city, @state, @zip, @phone, @active);";
                cmd.Parameters.AddWithValue("@username", newAdmin.username);
                cmd.Parameters.AddWithValue("@password", newAdmin.password);
                cmd.Parameters.AddWithValue("@access", 1);
                cmd.Parameters.AddWithValue("@fn", "");
                cmd.Parameters.AddWithValue("@ln", "");
                cmd.Parameters.AddWithValue("@address", "");
                cmd.Parameters.AddWithValue("@city", "");
                cmd.Parameters.AddWithValue("@state", "");
                cmd.Parameters.AddWithValue("@zip", "");
                cmd.Parameters.AddWithValue("@phone", "");
                cmd.Parameters.AddWithValue("@active", 1);

                cmd.ExecuteNonQuery();
            }//close try statement
            catch (Exception)
            {
                throw;
            }//close catch statement
            finally
            {
                if (c.State == ConnectionState.Open)
                {
                    c.Close();
                }//close if statement
            }//close finally statement

            Response.Redirect("Default.aspx");
        }//close createAdmin
    }
}