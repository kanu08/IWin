using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using IWinBLL;

using System.Net;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Specialized;

namespace IWin
{
    public partial class us_login : System.Web.UI.Page
    {
        int Result = 0;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_loginPs_Click(object sender, EventArgs e)
        {
            try
            {
                IWinBO.Buyer bu = new IWinBO.Buyer();
                bu.Email = txtUName.Text;
                bu.Password = txtUPassword.Text;
                bu.OP = 2;  //represent a login operation 
                IWinBLL.Buyer objbu = new IWinBLL.Buyer();
                Result = objbu.loginBuyer(bu);
                if (Result == 1)   // checks if username & password both are correct
                {
                    //var mail = new MailAddress(txtUName.Text.Trim());
                    //Session["user"] = mail.User; // name.surname
                    Session["user"] = txtUName.Text;
                    //Redirectig page  
                    Response.Redirect("UserHome.aspx");

                }
                else if (Result == 2)  //checks if username is present but password doesnt match
                {
                    lblmessage.Text = "<span class='glyphicon glyphicon-remove'></span>" + "Incorrect password";
                    lblmessage.Visible = true;
                }
                else   //if username is not present
                {
                    lblmessage.Text = "<span class='glyphicon glyphicon-remove'></span>" + "Username not present";
                    lblmessage.Visible = true;
                }
            }
            catch
            {

            }
        }

        protected void btn_sendOtp(object sender,EventArgs e)
        {
            Random random = new Random();
            int value = random.Next(1001, 9999);
            string destinationaddr = "91" + txtUNum.Text;
            string message = "Your OTP Number is " + value + " ( Sent By : IWin )";
            //Label3.Text = message;
            String message1 = HttpUtility.UrlEncode(message);
            using (var wb = new WebClient())
            {
                byte[] response = wb.UploadValues("https://api.textlocal.in/send/", new NameValueCollection()
                {
                {"apikey" , "T6jI6TbIpcs-gdqH98jZ8rhzbptLmGw2TtpK9AaQSW"},
                {"numbers" , destinationaddr},
                {"message" , message1},
                {"sender" , "TXTLCL"}
                });
                string result = System.Text.Encoding.UTF8.GetString(response);
                Session["otp"] = value;
            }
        }

        protected void btn_verifyOtp(object sender, EventArgs e)
        {
            if (txtOtp.Text == Session["otp"].ToString())
            {
                string em = IWinBLL.blUtil.getEmail(txtUNum.Text);
                Session["user"] = em;
                //Redirectig page  
                Response.Redirect("UserHome.aspx");
            }
            else
            {
                lblOtpmsg.Text = "OTP is incorrect";
            }
        }
    }
}