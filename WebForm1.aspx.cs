using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Net.Mail;
using System.Net;

namespace WebApplication3
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        static String activationcode;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            activationcode = random.Next(1001, 9999).ToString();
            String query = "insert into emaildetails(FirstName,Emailid,Status,activationcode) values('" + TextBox1.Text + "','" + TextBox2.Text + "','Unverified','" + activationcode + "')";
            String mycon = "DESKTOP-S2EPCEP\\SQLEXPRESS; Initial Catalog=Iwin; Integrated Security=true";
            SqlConnection con = new SqlConnection(mycon);
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = query;
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            sendcode();
            Response.Redirect("emailactivate.aspx?emailadd=" + TextBox2.Text);
        }

        private void sendcode()
        {
            SmtpClient smtp = new SmtpClient();
            smtp.Host = "smtp.gmail.com";
            smtp.Port = 587;
            smtp.Credentials = new System.Net.NetworkCredential("orderiwin07@gmail.com", "roboCON2017@");
            smtp.EnableSsl = true;
            MailMessage msg = new MailMessage();
            msg.Subject = "Activation Code to Verify Email Address";
            msg.Body = "Dear " + TextBox1.Text + ", Your Activation Code is  " + activationcode + "\n\n\nThanks & Regards\nHariti Study Hub Team";
            string toaddress = TextBox2.Text;
            msg.To.Add(toaddress);
            string fromaddress = "Iwin <orderiwin07@gmail.com>";
            msg.From = new MailAddress(fromaddress);
            try
            {
                smtp.Send(msg);


            }
            catch
            {
                throw;
            }
        }

    }
}

