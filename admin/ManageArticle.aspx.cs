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
    public partial class ManageArticle : System.Web.UI.Page
    {

        clsMessage message;
        private string connectionString = ConfigurationManager.ConnectionStrings["AzureConnString"].ConnectionString;//connection string

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
            if (!Page.IsPostBack) { 
                string id = Request.QueryString["id"];
                if (!id.Equals(null))
                {
                    fillForm(id);

                }
                else
                {
                    message.type = "error";
                    message.message = "There was an error with your request. You must query an news post by using a news ID.";
                    Session["message"] = message;

                    Response.Redirect("Default.aspx");
                }//close else
            }//close if statement

            

        }//close Page_Load()

        private void fillForm(string qq)
        {
            int id = Convert.ToInt32(qq);

            DataTable article = new DataTable();
            SqlConnection c = new SqlConnection(connectionString);


            c.Open();
            SqlCommand cmd;


            try
            {
                cmd = c.CreateCommand();
                cmd.CommandText = "SELECT EnglishTitle, SpanishTitle, PolishTitle, EnglishBody, SpanishBody, PolishBody, FROM News WHERE id=@ID";
                cmd.Parameters.AddWithValue("@ID", id);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                adapter.Fill(article);


            }//close try statement
            catch (Exception ex)
            {
                message.type = "error";
                message.message = "There was an error updating your article: <br />" + ex.Message;
            }//close catch statement
            finally
            {
                if (c.State == ConnectionState.Open)
                {
                    c.Close();
                }//close if statemenmt
            }//close finally

            txtEnglishTitle.Text = article.Rows[0]["EnglishTitle"].ToString();
            txtSpanishTitle.Text = article.Rows[0]["SpanishTitle"].ToString();
            txtPolishTitle.Text = article.Rows[0]["PolishTitle"].ToString();

            txtEnglishBody.Text = article.Rows[0]["EnglishBody"].ToString().Replace("<br />", System.Environment.NewLine);
            txtSpanishBody.Text = article.Rows[0]["SpanishBody"].ToString().Replace("<br />", System.Environment.NewLine);
            txtPolishBody.Text = article.Rows[0]["PolishBody"].ToString().Replace("<br />", System.Environment.NewLine);

        }//close fillForm(string qq)

        /*protected void ArticleSelected(object sender, EventArgs e)
        {
            updateArticle();
        }//close Article Selected */
        
        

        /*private void updateArticle()
        {
            int id = Convert.ToInt32(ArticleList.SelectedValue);
            DataTable article = new DataTable();
            SqlConnection c = new SqlConnection(connectionString);


            c.Open();
            SqlCommand cmd;


            try
            {
                cmd = c.CreateCommand();
                cmd.CommandText = "SELECT Title, body FROM Posts WHERE id=@id";
                cmd.Parameters.AddWithValue("@id", id);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                adapter.Fill(article);


            }//close try statement
            catch (Exception ex)
            {
                message.type = "error";
                message.message = "There was an error updating your article: <br />" + ex.Message;
            }//close catch statement
            finally
            {
                if (c.State == ConnectionState.Open)
                {
                    c.Close();
                }//close if statemenmt
            }//close finally

            txtPostTitle.Text = article.Rows[0]["Title"].ToString();
            txtArticleBody.Text = article.Rows[0]["body"].ToString().Replace("<br />", System.Environment.NewLine);

        }//close updateArticle();*/

        protected void updateButton(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Request.QueryString["id"]);
            DataTable article = new DataTable();
            SqlConnection c = new SqlConnection(connectionString);


            c.Open();
            SqlCommand cmd;


            try
            {
                cmd = c.CreateCommand();
                cmd.CommandText = "UPDATE Posts SET EnglishTitle = @EnglishTitle, SpanishTitle = @SpanishTitle, PolishTitle = @PolishTitle, "+
                "EnlgishBody = @EnglishBody, SpanishBody = @SpanishBody, PolishBody = @PolishBody WHERE ID = @id";
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@EnglishTitle", txtEnglishTitle.Text.ToString());
                cmd.Parameters.AddWithValue("@SpanishTitle", txtSpanishTitle.Text.ToString());
                cmd.Parameters.AddWithValue("@PolishTitle", txtPolishTitle.Text.ToString());

                cmd.Parameters.AddWithValue("@EnglishBody", txtEnglishBody.Text.ToString().Replace(System.Environment.NewLine, "<br />"));
                cmd.Parameters.AddWithValue("@SpanishBody", txtSpanishBody.Text.ToString().Replace(System.Environment.NewLine, "<br />"));
                cmd.Parameters.AddWithValue("@PolishBody", txtPolishBody.Text.ToString().Replace(System.Environment.NewLine, "<br />"));

                cmd.ExecuteNonQuery();
                message.type = "success";
                message.message = "Your post update was successful.";
                Session["message"] = message;

            }//close try statement
            catch (Exception ex)
            {
                message.type = "error";
                message.message = "There was an error processing your update. '/" + ex.Message;
                Session["message"] = message;

            }//close catch statement
            finally
            {
                if (c.State == ConnectionState.Open)
                {
                    c.Close();
                }//close if statemenmt
            }//close finally
            Response.Redirect("Default.aspx");
            

        }//close updateButton()

        protected void deleteButton(string qq)
        {
            int id = Convert.ToInt32(qq);
            DataTable article = new DataTable();
            SqlConnection c = new SqlConnection(connectionString);


            c.Open();
            SqlCommand cmd;


            try
            {
                cmd = c.CreateCommand();
                cmd.CommandText = "DELETE FROM Posts WHERE id = @id";
                cmd.Parameters.AddWithValue("@id", id);

                cmd.ExecuteNonQuery();


            }//close try statement
            catch (Exception ex)
            {
                message.type = "error";
                message.message = "There was an error removing your article: <br />" + ex.Message;
            }//close catch statement
            finally
            {
                if (c.State == ConnectionState.Open)
                {
                    c.Close();
                }//close if statemenmt
            }//close finally
        }//close deleteButton
    
    
    }//close Class
}//close namespace