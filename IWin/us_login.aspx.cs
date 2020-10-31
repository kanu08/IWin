using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using IWinBLL;

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
                if (Result == 1)
                {
                    var mail = new MailAddress(txtUName.Text.Trim());
                    Session["user"] = mail.User; // name.surname
                    //Redirectig page  
                    Response.Redirect("UserHome.aspx");
                    
                }
                else if (Result == 2)
                {
                    lblmessage.Text = "<span class='glyphicon glyphicon-ok'></span>" + "Incorrect";
                    lblmessage.Visible = true;
                }
            }
            catch
            {

            }
        }
    }
}