using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class DualAccountLogin : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        SqlConnection con = new SqlConnection();
        con.ConnectionString = "Data Source=DESKTOP-O9MNC2S\\SQLEXPRESS01;Initial Catalog=userlogin;Integrated Security=true";
        con.Open();
        SqlDataAdapter sda = new SqlDataAdapter("select * from userlogin where username='" + txtuser.Text + "' and password = '" + txtpass.Text + "' and usertype = '" + DropDownList1.SelectedItem.Value + "'", con);
        DataTable dt = new DataTable();

        sda.Fill(dt);
        if (dt.Rows.Count > 0)
        {
            Response.Write("<script>('you are logined as " + dt.Rows[0][2] + "')</script>");
            if (Convert.ToString(DropDownList1.SelectedItem.Value) == "1" )
            {
                Server.Transfer("buyer.aspx");
            }
            else 
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