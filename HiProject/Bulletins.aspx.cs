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
    public partial class Bulletins : System.Web.UI.Page
    {

        private string connectionString = ConfigurationManager.ConnectionStrings["AzureConnString"].ConnectionString;

        protected void Page_Load(object sender, EventArgs e)
        {

        }//close Page_Load

        private void getBulletins()
        {
            SqlConnection c = new SqlConnection(connectionString);
            DataTable x = new DataTable();

            SqlCommand cmd;

            try
            {
                c.Open();
                cmd = c.CreateCommand();
                cmd.CommandText = "SELECT Filename, Date FROM BULLETINS;";

                SqlDataAdapter a = new SqlDataAdapter(cmd);

                a.Fill(x);
                

            }//close try statement
            catch(Exception ex)
            {

            }//close catch exception

            string filename;
            for (int z = 0; z < x.Rows.Count; z++)
            {
                filename = "../files/" + x.Rows[z]["Filename"].ToString();


            }//close for loop


        }//close getBulletins()

    }//close class
}//close namespace