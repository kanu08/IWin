using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ViewDetails : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void DataList1_ItemCommand(object source, DataListCommandEventArgs e)
    {


        Response.Redirect("AddtoCart.aspx?id=" + e.CommandArgument.ToString());
    }

    protected void Button1_Click(object sender, EventArgs e)
    {

    }
}