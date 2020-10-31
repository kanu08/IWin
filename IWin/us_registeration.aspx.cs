using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using IWinBLL;
using IWinBO;


namespace IWin
{
    public partial class us_registeration : System.Web.UI.Page
    {
        int Result = 0;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_saveUser_Click(object sender, EventArgs e)
        {
            try
            {
                string en_password = null;
                IWinBO.Buyer bu = new IWinBO.Buyer();
                //IWinBLL.blUtil ps = new IWinBLL.blUtil();
                bu.Name = txtUName.Text;
                bu.Contact = txtUNum.Text;
                bu.Email = txtUEmail.Text;
                en_password = blUtil.PBKDF2password(txtUPassword.Text);
                bu.Password = en_password;
                bu.OP = 1;  //represent an insert operation 
                IWinBLL.Buyer objbu = new IWinBLL.Buyer();
                Result = objbu.insertBuyer(bu);
                if (Result == 2)
                {
                    lblmessage.Text = "<span class='glyphicon glyphicon-ok'></span>" + "User added successfully";
                    lblmessage.Visible = true;
                }
            }
            catch
            {

            }
        }
    }
}