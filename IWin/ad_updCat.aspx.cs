using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using IWinBLL;


namespace IWin
{
    public partial class mainProdview : System.Web.UI.Page
    {
        int result = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                gvbind();
            }
        }
        public void gvbind()
        {
            DataTable dt = new DataTable();
            IWinBLL.iwinbl objBLL = new IWinBLL.iwinbl();
            dt = objBLL.Search_init();
            GridView2.DataSource = dt;
            GridView2.DataBind();
        }
        protected void txtSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                DataTable dtt = new DataTable();
                IWinBO.Category obj = new IWinBO.Category();
                obj.CategoryName = txtSearch.Text;
                IWinBLL.iwinbl objBLL = new IWinBLL.iwinbl();
                dtt = objBLL.Search_Category(obj);
                if (dtt.Rows.Count > 0)
                {
                    // GridView1.Rows.clear();
                    GridView2.DataSource = dtt;
                    GridView2.DataBind();
                }
            }
            catch (Exception ef)
            {
                throw ef;
            }
        }

        protected void GridView2_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GridView2.EditIndex = -1;
            gvbind();
        }

        protected void GridView2_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int userid = Convert.ToInt32(GridView2.DataKeys[e.RowIndex].Value.ToString());
            GridViewRow row = (GridViewRow)GridView2.Rows[e.RowIndex];
            IWinBO.Category obj = new IWinBO.Category();
            obj.ID = userid;
            obj.OP = 3;
            IWinBLL.iwinbl objBLL = new IWinBLL.iwinbl();
            result = objBLL.delete_Category(obj);
            if (result == 3)
            {
                gvbind();
            }
        }

        protected void GridView2_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridView2.EditIndex = e.NewEditIndex;
            gvbind();
        }

        protected void GridView2_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            int userid = Convert.ToInt32(GridView2.DataKeys[e.RowIndex].Value.ToString());
            GridViewRow row = (GridViewRow)GridView2.Rows[e.RowIndex];
            //TextBox txtname=(TextBox)gr.cell[].control[];  
            TextBox textadd = (TextBox)row.Cells[1].Controls[0];
            //TextBox textc = (TextBox)row.Cells[2].Controls[0];
            //TextBox textadd = (TextBox)row.FindControl("txtadd");  
            //TextBox textc = (TextBox)row.FindControl("txtc");  
            GridView2.EditIndex = -1;
            IWinBO.Category obj = new IWinBO.Category();
            obj.CategoryName = textadd.Text;
            //obj.CategoryId = Convert.ToInt32(textc.Text);
            obj.ID = userid;
            obj.OP = 2;
            IWinBLL.iwinbl objBLL = new IWinBLL.iwinbl();
            result = objBLL.Update_Category(obj);
            if (result == 2)
            {
                gvbind();
            }

        }

        protected void GridView2_RowCreated(object sender, GridViewRowEventArgs e)
        {

        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                IWinBO.Category obj = new IWinBO.Category();
                IWinBLL.iwinbl objBLL = new IWinBLL.iwinbl();
                obj.CategoryName = txtCategory.Text;
                obj.OP = 1;
                result = objBLL.insertCategory(obj);
                if (result == 1)
                {
                    gvbind();
                    txtCategory.Text = "";
                }
            }
            catch
            {

            }

        }


    }
}