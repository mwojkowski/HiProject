using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace HolyInnocents
{
    public partial class NewArticle : System.Web.UI.Page
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["AzureConnString"].ConnectionString;

        clsMessage message;

        protected void Page_Load(object sender, EventArgs e)
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

        }//close Page_load


        protected void SubmitButton(object sender, EventArgs e)
        {
            string title = txtPostTitle.Text.ToString();
            string body = txtArticleBody.Text.ToString().Replace(System.Environment.NewLine, "<br />");
            SqlConnection c = new SqlConnection(connectionString);


            c.Open();

            SqlCommand cmd;


            try
            {
                cmd = c.CreateCommand();
                cmd.CommandText = "INSERT INTO Posts(Title, body, Date, Author) VALUES(@Title, @body, @Date, @Author);";
                cmd.Parameters.AddWithValue("@Title", title);
                cmd.Parameters.AddWithValue("@body", body);
                cmd.Parameters.AddWithValue("@Author", "none");
                cmd.Parameters.AddWithValue("@Date", DateTime.Now);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                cmd.ExecuteNonQuery();

                message.type = "success";
                message.message = "Your news article was successfully posted.";


            }//close try statement
            catch (Exception ex)
            {
                message.type = "error";
                message.message = "There was an error posting your article: <br />" + ex.Message;
                //throw; don't throw this anymore. useless code with messaging built in
            }//close catch statement
            finally
            {
                if (c.State == ConnectionState.Open)
                {
                    c.Close();
                }//close if statemenmt
            }//close finally



            Response.Redirect("../admin/Default.aspx");
        }//close SubmitButton


    }//close class
}//close namespace