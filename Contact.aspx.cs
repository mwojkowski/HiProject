using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Net;
using System.Net.Mail;

namespace HolyInnocents
{
    public partial class Contact : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }//close Page_load

        protected void SubmitButton(object sender, EventArgs e)
        {
            sendEmail();
        }//close SubmitButton Event handler

        private void submit()
        {
            string name = txtName.Text.ToString();
            string returnemail = txtEmail.Text.ToString();
            string subject = txtSubject.Text.ToString();
            string body = txtMessage.Text.ToString();

            

        }//close submit()

        private void sendEmail()
        {
            string smtpAddress = "smtp.gmail.com";
            int portNumber = 587;
            bool enableSSL = true;

            string emailFrom = "holyinnocentschicago@gmail.com";
            string password = "HiChurch743";
            string emailTo = "holyinnocentschicago@gmail.com";
            string subject = txtSubject.Text;
            string body = "You have received a contact request from " + txtName.Text + ". \n\n Message:\n\n" + txtMessage.Text + "\n\n Return Email: " + txtEmail.Text;

            using (MailMessage mail = new MailMessage())
            {
                mail.From = new MailAddress(emailFrom);
                mail.To.Add(emailTo);
                mail.Subject = subject;
                mail.Body = body;
                mail.IsBodyHtml = false;
                // Can set to false, if you are sending pure text.

                using (SmtpClient smtp = new SmtpClient(smtpAddress, portNumber))
                {
                    //smtp.UseDefaultCredentials = false;
                    smtp.Credentials = new NetworkCredential(emailFrom, password);
                    smtp.EnableSsl = enableSSL;
                    try
                    {
                        smtp.Send(mail);
                    }
                    catch (Exception)
                    {
                        throw;
                    }
                }
            }//close using statement

            messageLiteral.Text = "Your Email was successfully sent.";
            txtEmail.Text = "";
            txtMessage.Text = "";
            txtName.Text = "";
            txtSubject.Text = "";
            
        }//close sendEmail()

    }//close class
}//close namespace