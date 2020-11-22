using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace IWin
{
    public partial class us_emailVerify : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["check"]==null)
            {
                Label3.Text = "Your Registered Email is " + Session["user"].ToString() + " , Kindly Check Your Mail For Activation Code";   
            }
            else
            {
                 btnVerifyOtp.Enabled = false;
            }
        }

        protected void btnVerifyOtp_Click(object sender, EventArgs e)
        {
            String mycon = ConfigurationManager.ConnectionStrings["iwinConn"].ConnectionString;
            String myquery = "Select * from tbl_user_tempActCode where Email='"+Session["user"].ToString()+"'";
            SqlConnection con = new SqlConnection(mycon);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = myquery;
            cmd.Connection = con;
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataSet ds = new DataSet();
            da.Fill(ds);
            if (ds.Tables[0].Rows.Count > 0)
            {
                String activationcode;
                activationcode = ds.Tables[0].Rows[0]["ActCode"].ToString();
                if (activationcode.Trim() == TextBox1.Text)
                {
                    changestatus();
                    Label4.Text = "Your Email Has Been Verified Successfully";
                    btnVerifyOtp.Enabled = false;
                    Session["check"] = 1;
                }
                else
                {
                    Label4.Text = "You Have Entered Invalid Activation Code, Kindly Check Your Mail Inbox";
                }
            }

            con.Close();
        }
        private void changestatus()
        {
            String mycon = ConfigurationManager.ConnectionStrings["iwinConn"].ConnectionString;
            String updatedata = "Update tbl_user_login set VerifyStatus=1 where Email='"+Session["user"]+"'";
            SqlConnection con = new SqlConnection(mycon);
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = updatedata;
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
        }

        protected void btnToProfile_Click(object sender, EventArgs e)
        {
            Response.Redirect("us_profile.aspx");

        }
    }
}