using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace userlogin {
    public partial class Default2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e) {
            SqlConnection con = new SqlConnection("Data Source = DESKTOP-O9MNC2S\SQLEXPRESS01'; Initial Catalog = userlogin; Integrated Security = True");
            SqlDataAdapter sda = new SqlDataAdapter("select * from userlogin where username'" + txtuser.Text + "' and password = '" + txtpass.Text + " and usertype = '" + DropDownList1.SelectedItem.ToString() + "'", con);
            DataTable dt = new DataTable();

            sda.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                Response.Write("<script>('you are logined as " + dt.Rows[0][2] + "')</script>");
                if (DropDownList1_SelectedIndexChanged == 0)
                {
                    Server.Transfer("buyer.aspx");
                } else if (DropDownList1_SelectedIndexChanged == 1)
                {
                    Server.Transfer("Sellerpage.aspx");
                }
            }
            else
            {
                Response.Write("error in your input");
            }
        }
    }

}