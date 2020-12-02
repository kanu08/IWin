using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Mail;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace IWin
{
    public partial class us_profile : System.Web.UI.Page
    {
        int Result;
        static String activationcode;
        protected void Page_Load(object sender, EventArgs e)
        {
            IWinDAL.dbUtil du = new IWinDAL.dbUtil();
            if (!Page.IsPostBack)
            {
                du.Bindddl(ddlPinCode);
            }
            if (btn_editProfile.Text == "Edit") {
            String p;
            DataTable dtFull = new DataTable();
            dtFull= IWinBLL.Buyer.getDetails(Session["user"].ToString());
            Verify.Enabled = false;
                if (Session["user"] != null)
                {
                    bool status = Convert.ToBoolean(dtFull.Rows[0][4]);
                    if (status == false)
                    {
                        Verify.Enabled = true;
                    }
                    txtUName.Text = dtFull.Rows[0][1].ToString();
                    txtUCont.Text = dtFull.Rows[0][3].ToString();
                    p = dtFull.Rows[0][6].ToString();
                    if (p!= null && p!= "")
                    {
                        ddlPinCode.Items.FindByText(p).Selected = true;
                        lblUCity.Text = dtFull.Rows[0][5].ToString();
                    }
                    else
                    {
                        ddlPinCode.SelectedIndex=0;
                        lblUCity.Text = "";

                    }
                    txtUName.Enabled = false;
                    txtUCont.Enabled = false;
                    ddlPinCode.Enabled = false;
                }
            }
        }

        protected void btn_editProfile_Click(object sender, EventArgs e)
        {
            if (txtUName.Enabled == false)
            {
                txtUName.Enabled = true;
                txtUCont.Enabled = true;
                ddlPinCode.Enabled = true;
                btn_editProfile.Text = "Save";
            }
            else
            {
                try
                {
                    IWinBO.Buyer bu = new IWinBO.Buyer();
                    //IWinBLL.blUtil ps = new IWinBLL.blUtil();
                    bu.Name = txtUName.Text;
                    bu.Contact = txtUCont.Text;
                    bu.PinCode = ddlPinCode.SelectedValue;
                    bu.Email = Session["user"].ToString();
                    bu.OP = 6; //represents an update operation
                    IWinBLL.Buyer objbu = new IWinBLL.Buyer();
                    Result = objbu.updateBuyerDtl(bu);
                    if (Result == 6)
                    {
                        Response.Redirect("us_profile.aspx");
                    }
                }
                catch
                {

                }
            }
        }

        protected void Verify_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            activationcode = random.Next(1001, 9999).ToString();
            String query = "insert into tbl_user_tempActCode(Email,ActCode) values('"+Session["user"].ToString()+"','"+activationcode+"')";
            String mycon = ConfigurationManager.ConnectionStrings["iwinConn"].ConnectionString;
            SqlConnection con = new SqlConnection(mycon);
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = query;
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            sendcode();
            Response.Redirect("us_emailVerify.aspx");
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
            msg.Body = "Dear " +txtUName.Text + ", Your Activation Code is  " + activationcode + "\n\n\nThanks & Regards\nIWin";
            string toaddress = Session["user"].ToString();
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
