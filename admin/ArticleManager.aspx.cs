using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HolyInnocents.admin
{
    public partial class ArticleManager : System.Web.UI.Page
    {

        private string connectionString = ConfigurationManager.ConnectionStrings["AzureConnString"].ConnectionString;//connection string

        protected void Page_Load(object sender, EventArgs e)
        {

            if (!Page.IsPostBack)
            {
                getNews();
            }//close if statement
        }//close Page_Load

        private void getNews()
        {
            SqlConnection c = new SqlConnection(connectionString);
            DataTable x = new DataTable();
            SqlCommand cmd;

            try
            {
                c.Open();

                cmd = c.CreateCommand();



                cmd.CommandText = "SELECT ID, EnglishTitle, Date from News ORDER BY Date DESC";

                SqlDataAdapter a = new SqlDataAdapter(cmd);

                a.Fill(x);


            }//close try statement

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }//close catch statement
            finally
            {
                if (c.State == ConnectionState.Open)
                {
                    c.Close();
                }//close if statement
            }//close finally statement
            string articleLink = "";
            for (int q = 0; q < x.Rows.Count; q++)
            {

                //fileLink = "/Downloads/" + x.Rows[q]["FileName"];
                articleLink = "ManageArticle.aspx?id=" + x.Rows[q]["ID"];

                newsArticles.Text = newsArticles.Text +
                    "<td>" + x.Rows[q]["EnglishTitle"] + "</td>" +
                    "<td>" + x.Rows[q]["Date"] + "</td>" +
                    "<td>" + "<a href=\"" + articleLink + "\"><img src=\"images/icn_edit.png\"</a>" + "</td>" +
                    "<tr>";
            }//close for loop
            
        }//close getNews()



    }//close class
}//close namespace