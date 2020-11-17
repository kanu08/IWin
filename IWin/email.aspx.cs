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
using System.Configuration;

namespace IWin
{
    public partial class email : System.Web.UI.Page
    {
        static String activationcode;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            activationcode = random.Next(1001, 9999).ToString();
            String query = "insert into tbl_user_tempActCode(Email,ActCode) values('" + TextBox2.Text + "','" + activationcode + "')";
            String mycon = ConfigurationManager.ConnectionStrings["iwinConn"].ConnectionString;
            SqlConnection con = new SqlConnection(mycon);
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = query;
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            sendcode();
            Response.Redirect("us_emailVerify.aspx?emailadd=" + TextBox2.Text);
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
            msg.Body = "Dear " + TextBox1.Text + ", Your Activation Code is  " + activationcode + "\n\n\nThanks & Regards\nIWin";
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