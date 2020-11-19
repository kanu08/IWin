using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace IWin
{
    public partial class ad_updSubcat : System.Web.UI.Page
    {
        int result = 0;
        IWinDAL.dbUtil du = new IWinDAL.dbUtil();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                gvbind();
                du.Bindddl(ddlCategory);
            }
        }
        public void gvbind()
        {
            DataTable dt = new DataTable();
            IWinBLL.SubCategory objBLL = new IWinBLL.SubCategory();
            dt = objBLL.Init();
            GridView2.DataSource = dt;
            GridView2.DataBind();
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
            IWinBO.SubCategory obj = new IWinBO.SubCategory();
            obj.subCatId = userid;
            IWinBLL.SubCategory objBLL = new IWinBLL.SubCategory();
            result = objBLL.deleteSubCategory(obj);
            if (result == 5)
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
            string categoryid = (GridView2.Rows[e.RowIndex].FindControl("ddlCategory") as DropDownList).SelectedItem.Value;
            int userid = Convert.ToInt32(GridView2.DataKeys[e.RowIndex].Value.ToString());
            GridViewRow row = (GridViewRow)GridView2.Rows[e.RowIndex];
            //TextBox txtname=(TextBox)gr.cell[].control[];  
            TextBox textadd = (TextBox)row.Cells[1].Controls[0];
            GridView2.EditIndex = -1;
            IWinBO.SubCategory obj = new IWinBO.SubCategory();
            obj.SubcategoryName = textadd.Text;
            //obj.CategoryId = Convert.ToInt32(textc.Text);
            obj.subCatId = userid;
            obj.CatValue = Convert.ToInt32(categoryid);
            IWinBLL.SubCategory objBLL = new IWinBLL.SubCategory();
            result = objBLL.UpdateSubCategory(obj);
            if (result == 4)
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
                IWinBO.SubCategory sc = new IWinBO.SubCategory();
                //IWinBLL.blUtil ps = new IWinBLL.blUtil();
                sc.SubcategoryName = txtSubCat.Text;
                sc.CatValue = Convert.ToInt32(ddlCategory.SelectedItem.Value.ToString());
                sc.OP = 2;  //represent an insert operation 
                IWinBLL.SubCategory objbu = new IWinBLL.SubCategory();
                result = objbu.insertSubCategory(sc);
                if (result == 2)
                {
                    gvbind();
                    txtSubCat.Text = "";

                }
            }
            catch
            {

            }

        }

        protected void GridView2_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow && GridView2.EditIndex == e.Row.RowIndex)
            {
                DropDownList ddlCategory = (DropDownList)e.Row.FindControl("ddlCategory");
                du.Bindddl(ddlCategory);
                DataRowView dr1 = e.Row.DataItem as DataRowView;
                ddlCategory.SelectedValue = dr1["category_id"].ToString();

            }
        }

        protected void txtSearch_TextChanged1(object sender, EventArgs e)
        {
            try
            {
                DataTable dtt = new DataTable();
                IWinBO.SubCategory obj = new IWinBO.SubCategory();
                obj.SubcategoryName = txtSearch.Text;
                IWinBLL.SubCategory objBLL = new IWinBLL.SubCategory();
                dtt = objBLL.searching(obj);
                if (dtt.Rows.Count > 0)
                {
                    // GridView1.Rows.clear();
                    GridView2.DataSource = dtt;
                    GridView2.DataBind();
                }
            }
            catch (Exception ed)
            {
                throw ed;
            }
        }
    }
}