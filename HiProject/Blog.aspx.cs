using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace HolyInnocents
{
    public partial class Blog : Page
    {

        private string connectionString = ConfigurationManager.ConnectionStrings["AzureConnString"].ConnectionString;
        //hi_siteConnectionString
        protected void Page_Load(object sender, EventArgs e)
        {
            populatePosts();


            Console.WriteLine("Test");




        }//close PageLoad

        private void populatePosts()
        {
            DataTable Posts = new DataTable();
            SqlConnection c = new SqlConnection(connectionString);

            c.Open();

            SqlCommand cmd;


            try
            {
                cmd = c.CreateCommand();
                cmd.CommandText = "SELECT TOP 20 (ID), Title, Date, body from Posts order by ID DESC";
                //"SELECT * FROM Posts ORDER BY id DESC LIMIT 2";
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(Posts);



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

            List<Article> activePosts = new List<Article>();
            for (int x = 0; x < Posts.Rows.Count; x++)
            {
                Article temp = new Article(Posts.Rows[x]["Title"].ToString(), "", Convert.ToDateTime(Posts.Rows[x]["Date"]), Posts.Rows[x]["body"].ToString());
                activePosts.Add(temp);
            }//close for loop

            for (int q = 0; q < activePosts.Count; q++)
            {
                Article article = new Article();

                article = activePosts[q];
                BlogPosts.Text = BlogPosts.Text +
                    "<div class=\"blog-post\" id=\"PostOne\">" +
                    "<h2 id=\"Title\">" + activePosts[q].title + "</h2>" +
                    "<span class=\"post-date\" id=\"Date1\"><i class=\"fa fa-calendar\"></i>" + activePosts[q].date.ToString("MM/dd/yyyy") + "</span>" +
                    "<p id=\"Text\">" + activePosts[q].text.Replace(System.Environment.NewLine, "<br />") + "</p>" +
                    "</div><br><hr>";

            }//clcose for loop

            /*
             <div class="blog-post" id="PostOne">
                            <h2 id="Title1">Post Title</h2>
                            <span class="post-date" id="Date1"><i class="fa fa-calendar"></i> June 27, 2015</span>
                            <p id="Text1">Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nullam feugiat dignissim metus, id vestibulum tellus Cras ante commodo ipsum dolor sit amet, consectetur adipiscing elit. Nullam feugiat dignissim ipsum dolor sit amet, consectetur adipiscing elit. Nullam feugiat dignissim metus, id vestibulum tellus Cras ante commodo ipsum dolor sit amet, consectetur adipiscing elit. Nullam feugiat dignissim.</p>
                     </div>  
             
              
             
             */
        }//close populatePosts()


    }//close class
}//close namespace