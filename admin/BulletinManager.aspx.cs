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
    public partial class BulletinManager : System.Web.UI.Page
    {

        private string connectionString = ConfigurationManager.ConnectionStrings["AzureConnString"].ConnectionString;//connection string
        clsMessage message;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                getBulletins();
            }//close if statement
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

            
        }//close Page_Load

        protected void uploadButton(object sender, EventArgs e)
        {
            Boolean fileOK = false;
            String path = Server.MapPath("~/Downloads/");
            if (FileUpload1.HasFile)
            {
                String fileExtension =
                    System.IO.Path.GetExtension(FileUpload1.FileName).ToLower();
                String[] allowedExtensions = { ".pdf"};
                for (int i = 0; i < allowedExtensions.Length; i++)
                {
                    if (fileExtension == allowedExtensions[i])
                    {
                        fileOK = true;
                    }
                }
            }

            if (fileOK)
            {
                try
                {
                    FileUpload1.PostedFile.SaveAs(path
                        + FileUpload1.FileName);
                    storeData(FileUpload1.FileName);
                    //Label1.Text = "File uploaded!";
                    message.type = "success";
                    message.message = "Your bulletin was successfully uploaded.";
                    Session["mesage"] = message;
                    Response.Redirect("Default.aspx");
                }
                catch (Exception ex)
                {

                    message.type = "error";
                    message.message = "There was an error processing your bulletin upload: \n" + ex.Message + "\n Please contact your system administrator.";
                    Session["mesage"] = message;
                    Response.Redirect("BulletinManager.aspx");
                }//close catch statement
            }//close outer if statement
                    
            else
            {
                message.type = "error";
                message.message = "There was an error in Processing your Bulletin. Please contact your system administrator.";
                Session["mesage"] = message;
                Response.Redirect("BulletinManager.aspx");
            }

        }//close uploadButton

        /* Used to store the file's location, date and author in the database for retrieval by the CMS */
        private void storeData(string x)
        {
            string dateString = DateTextBox.Text;
            DateTime date = Convert.ToDateTime(dateString);

            SqlConnection c = new SqlConnection(connectionString);

            c.Open();

            SqlCommand cmd;
            try
            {
                cmd = c.CreateCommand();
                cmd.CommandText = "INSERT INTO Bulletins(Filename, Date, Author) VALUES(@Filename, @Date, @Author);";
                cmd.Parameters.AddWithValue("@Filename", x);
                cmd.Parameters.AddWithValue("@Date", date);
                cmd.Parameters.AddWithValue("@Author", "");

                cmd.ExecuteNonQuery();
            }//close try statement
            catch (Exception ex)
            {
                message.type = "success";
                message.message = "Your news article was successfully posted.";
            }//close catch statement
            finally
            {
                if (c.State == ConnectionState.Open)
                {
                    c.Close();
                }//close if statement
            }//close finally statement

            Response.Redirect("../admin/Default.aspx");
        }//close storeData

        private void getBulletins()
        {
            SqlConnection c = new SqlConnection(connectionString);
            DataTable x = new DataTable();
            SqlCommand cmd;

            try
            {
                c.Open();

                cmd = c.CreateCommand();

                

                cmd.CommandText = "SELECT id, Filename, Date FROM Bulletins;";

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
            string fileLink = "";
            for (int q = 0; q < x.Rows.Count; q++)
            {

                fileLink = "/Downloads/" + x.Rows[q]["FileName"];

                bulletinTable.Text = bulletinTable.Text + "<tr>" +
                            "<td style=\"text-align:center;\">" + x.Rows[q]["Date"] + "</td>" +
                            "<td style=\"text-align:center;\"><a href=\"" + fileLink + "\">" + x.Rows[q]["Filename"] + "</a></td>" +
                        "</tr>";
            }//close for loop
            


        }//close getBulletins()

    }//Close class
}//close namespace