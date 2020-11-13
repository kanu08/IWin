using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace WebApplication3
{
    public partial class emailactivate : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Label3.Text = "Your Email is " + Request.QueryString["emailadd"].ToString() + " , Kindly Check Your Mail Inbox For Activation Code";

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            String mycon = "DESKTOP-S2EPCEP\\SQLEXPRESS; Iwin; Integrated Security=True";
            String myquery = "Select * from EmailDetails where Emailid='" + Request.QueryString["emailid"] + "'";
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
                activationcode = ds.Tables[0].Rows[0]["activationcode"].ToString();
                if (activationcode == TextBox1.Text)
                {
                    changestatus();
                    Label4.Text = "Your Email Has Been Verified Successfully";
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
            String mycon = "DESKTOP-S2EPCEP\\SQLEXPRESS; Initial Catalog=Iwin; Integrated Security=True";
            String updatedata = "Update emaildetails set status='Verified' where emailaddress='" + Request.QueryString["emailadd"] + "'";
            SqlConnection con = new SqlConnection(mycon);
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = updatedata;
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
        }
    }

}


