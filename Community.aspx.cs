using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Data.SqlClient;

namespace HolyInnocents
{
    public partial class Community : System.Web.UI.Page
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["AzureConnString"].ConnectionString;

        protected void Page_Load(object sender, EventArgs e)
        {
            populateCommunities();


        }


        protected void populateCommunities()
        {
            DataTable communityTable = new DataTable();
            SqlConnection c = new SqlConnection(connectionString);

            c.Open();

            SqlCommand cmd;


            try
            {
                cmd = c.CreateCommand();
                cmd.CommandText = "SELECT * FROM Communities";
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(communityTable);



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

            List<Club> communities = new List<Club>();
            for (int x = 0; x < communityTable.Rows.Count; x++)
            {
                Club temp = new Club(communityTable.Rows[x]["Name"].ToString(), communityTable.Rows[x]["Description"].ToString());
                communities.Add(temp);
            }//close for loop

            for (int q = 0; q < communities.Count; q++)
            {
                Club temp = communities[q];

                Clubs.Text = Clubs.Text +
                    "<div class=\"post\">" +
                    "<h2 class=\"title-style-2\">" + temp.name + "<span class=\"title-under\"></span></h2>" +
                    "<p>" +
                         temp.description +
                    "</p>" +
                "</div>";

            }//clcose for loop

        }//close populateCommunities

       


    }//close partial class
}//close namespace