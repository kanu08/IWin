using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace IWin
{
    public partial class ad_SetMQU : System.Web.UI.Page
    {
        IWinDAL.dbUtil du = new IWinDAL.dbUtil();
        public int prodId = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            prodId = Convert.ToInt32(Request.QueryString["id"]);
            if (!IsPostBack) {
         
            }
           
        }

        protected void GridView1_PreRender(object sender, EventArgs e)
        {
            for (int index = 0; index < GridView1.Rows.Count - 1; index++)
            {

                GridView1.Rows[index].Cells[1].Controls[1].Visible = false;
            }
        }

        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            // Insert data if the CommandName == "Insert" 
            // and the validation controls indicate valid data...
            if (e.CommandName == "Insert" && Page.IsValid)
            {
                var index = GridView1.FooterRow.RowIndex;

                DropDownList d1 = (DropDownList)GridView1.FooterRow.Controls[5].FindControl("ddlUOMi");
                TextBox t1 = (TextBox)GridView1.FooterRow.FindControl("txtPrice");
                TextBox t2 = (TextBox)GridView1.FooterRow.FindControl("txtQty");
                // var dropDownctr = GridView1.Rows[index].Controls[4].FindControl("ddlUOMi"); 
                SqlDataSource1.InsertParameters["prodid"].DefaultValue = Request.QueryString["id"].ToString();
                SqlDataSource1.InsertParameters["price"].DefaultValue = t1.Text;
                SqlDataSource1.InsertParameters["quantity"].DefaultValue = t2.Text;
                SqlDataSource1.InsertParameters["UOM_id"].DefaultValue = d1.SelectedValue;
                SqlDataSource1.Insert();
            }

        }

        protected void InsertNewMqu(object sender, EventArgs e)
        {
            try
            {
                SqlDataSource1.InsertParameters["prodid"].DefaultValue = Request.QueryString["id"].ToString();
                SqlDataSource1.InsertParameters["price"].DefaultValue = txtPrice2.Text;
                SqlDataSource1.InsertParameters["quantity"].DefaultValue = txtQty2.Text;
                SqlDataSource1.InsertParameters["UOM_id"].DefaultValue = ddlUOMi2.SelectedValue;
                //SqlDataSource1.InsertParameters.Add("@prod_id", Request.QueryString["id"]);
                // Insert new record
                SqlDataSource1.Insert();
                
            }
            catch
            {

            }
        }

        protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            int r = GridView1.Rows.Count;
            if (r == 0)
            {
                newM.Visible = true;
            }
            else
            {
                newM.Visible = false;
            }
            SqlDataSource1.DataBind();
        }

      
    }
}