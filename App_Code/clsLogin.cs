using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
//custom references
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Configuration;
using System.Security.Cryptography;
using System.Text;

using System.Data.SqlClient;


namespace HolyInnocents.App_Code
{
    public class clsLogin
    {
        public string username { get; set; }
        public string password { get; set; }
        public bool authorized { get; set; }
        private string connectionString = ConfigurationManager.ConnectionStrings["AzureConnString"].ConnectionString;
        //hi_siteConnectionString

        //my pass is kA/ZSDGe+b8dKPLrxIHrhA==


        public clsLogin()
        {
            username = "";
            password = "";
            authorized = false;

        }//close underloaded Constructor

        public clsLogin(string username, string password)
        {
            this.username = username;
            this.password = Encrypt(password);
        }//close Overloaded Constructor



        public string Encrypt(string strToEncrypt)
        {
            try
            {
                string key = "Np2ZY36ahh";
                TripleDESCryptoServiceProvider objDESCrypto =
                    new TripleDESCryptoServiceProvider();
                MD5CryptoServiceProvider objHashMD5 = new MD5CryptoServiceProvider();
                byte[] byteHash, byteBuff;
                string strTempKey = key;
                byteHash = objHashMD5.ComputeHash(ASCIIEncoding.ASCII.GetBytes(strTempKey));
                objHashMD5 = null;
                objDESCrypto.Key = byteHash;
                objDESCrypto.Mode = CipherMode.ECB; //CBC, CFB
                byteBuff = ASCIIEncoding.ASCII.GetBytes(strToEncrypt);
                return Convert.ToBase64String(objDESCrypto.CreateEncryptor().
                    TransformFinalBlock(byteBuff, 0, byteBuff.Length));
            }
            catch (Exception)
            {
                throw;
            }
        }//close Encrypt

        public bool isEmpty()
        {
            if (username.Equals(null))
            {
                return true;
            }//close if statement
            else
            {
                return true;
            }//close else statement
        }//close isEmpty

        public void validate(string username, string password)
        {
            //bool verified = false;

            DataTable user = new DataTable();
            clsLogin clsclsLogin = new clsLogin();
            SqlConnection c = new SqlConnection(connectionString);


            c.Open();

            SqlCommand cmd;


            try
            {
                cmd = c.CreateCommand();
                cmd.CommandText = "SELECT Password from users where Username = '" + username + "'";
                
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                adapter.Fill(user);
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

            //populate datatable
            string test = user.Rows[0]["Password"].ToString();
            if (password.Equals(test))
            {
                authorized = true;
                
            }//close if statement
            else
            {
                authorized = false;
            }//close else statement
        }//close checkclsclsLogin


    }//close class
}//close namespace