using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Data.SqlClient;

namespace HolyInnocents.admin
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["AzureConnString"].ConnectionString;//connection string
        clsMessage message;


        protected void Page_Load(object sender, EventArgs e)
        {
            message = (clsMessage)Session["message"];
            if (message != null)
            {
                if (message.type.Equals("success"))
                {
                    messageLiteral.Text = "<h4 class=\"alert_success\">" + message.message + "</h4>";

                }
                if (message.type.Equals("error"))
                {
                    messageLiteral.Text = "<h4 class=\"alert_error\">There was an error processing your request: <br />" + message.message + "</h4>";

                }
            }

            message.type = "";    //clear the message type and
            message.message = "";//message so it doesnt set off on other pages.


        }//close Page_Load


        protected void CommunitySelection(object sender, EventArgs e)
        {
            updateCommunity();
        }//close CommunitySelection Event Handler

        private void updateCommunity()
        {
            int id = Convert.ToInt32(comboCommunityList.SelectedValue);
            DataTable article = new DataTable();
            SqlConnection c = new SqlConnection(connectionString);


            c.Open();
            SqlCommand cmd;


            try
            {
                cmd = c.CreateCommand();
                cmd.CommandText = "SELECT Name, Description FROM Communities WHERE id=@id";
                cmd.Parameters.AddWithValue("@id", id);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                adapter.Fill(article);


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
                }//close if statemenmt
            }//close finally

            txtCommunityName.Text = article.Rows[0]["Name"].ToString();
            txtCommunityDescription.Text = article.Rows[0]["Description"].ToString();




        }//close updateArticle();

        protected void updateButton(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(comboCommunityList.SelectedValue);
            DataTable article = new DataTable();
            SqlConnection c = new SqlConnection(connectionString);

            
            c.Open();
            SqlCommand cmd;


            try
            {
                cmd = c.CreateCommand();
                cmd.CommandText = "UPDATE Communities SET Name=@Name, Description=@Description WHERE id = @id";
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@Name", txtCommunityName.Text.ToString());
                cmd.Parameters.AddWithValue("@Description", txtCommunityDescription.Text.ToString());

                cmd.ExecuteNonQuery();


                message.type = "success";
                message.message = "Your community information was successfully updated.";

            }//close try statement
            catch (Exception ex)
            {
                message.type = "error";
                message.message = "There was an error updating your the community information: <br />" + ex.Message;
            }//close catch statement
            finally
            {
                if (c.State == ConnectionState.Open)
                {
                    c.Close();
                }//close if statemenmt
            }//close finally


        }//close updateButton()
    }
}