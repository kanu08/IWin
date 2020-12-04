using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace IWin
{
    public partial class us_prodDetails1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void DataList1_ItemCommand(object source, DataListCommandEventArgs e)
        {
            if (e.CommandName == "addtocart")
            {
                string[] commandArgs = e.CommandArgument.ToString().Split(new char[] { ',' });
                string mqu = commandArgs[0];
                string se = commandArgs[1];
                DropDownList dlist = (DropDownList)(e.Item.FindControl("ddlQty"));
                Response.Redirect("AddtoCart.aspx?mqu="+mqu+"&se="+se+"&pid="+Request.QueryString["prod"]+"&qty="+dlist.SelectedItem.ToString());
            }
            if(e.CommandName == "subscribe")
            {
                string[] commandArgs = e.CommandArgument.ToString().Split(new char[] { ',' });
                string mqu = commandArgs[0];
                string se = commandArgs[1];
                DropDownList dlist = (DropDownList)(e.Item.FindControl("ddlQty"));
                Response.Redirect("us_subscribe.aspx?mqu=" + mqu + "&se=" + se + "&pid=" + Request.QueryString["prod"] + "&qty=" + dlist.SelectedItem.ToString());
            }
        }

    }
}