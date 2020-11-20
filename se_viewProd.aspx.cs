using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace IWin
{
    public partial class se_viewProd : System.Web.UI.Page
    {
        int Result = 0;
        IWinDAL.dbUtil du = new IWinDAL.dbUtil();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                gvbind();
                du.Bindddl(ddlCategory);
                du.Bindddl(ddlSubCategory);
                du.Bindddl(ddlBrand);
            }
        }
        public void gvbind()
        {
            DataTable dt = new DataTable();
            IWinBLL.Product objBLL = new IWinBLL.Product();
            dt = objBLL.Init();
            GridView2.DataSource = dt;
            GridView2.DataBind();
        }
        protected void GridView2_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GridView2.EditIndex = -1;
            gvbind();
        }

        protected void GridView2_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            string categoryid = (GridView2.Rows[e.RowIndex].FindControl("ddlCategory") as DropDownList).SelectedItem.Value;
            string subcategoryid = (GridView2.Rows[e.RowIndex].FindControl("ddlSubCategory") as DropDownList).SelectedItem.Value;
            int userid = Convert.ToInt32(GridView2.DataKeys[e.RowIndex].Value.ToString());
            GridViewRow row = (GridViewRow)GridView2.Rows[e.RowIndex];          
            TextBox textadd = (TextBox)row.Cells[1].Controls[0];
            TextBox textp = (TextBox)row.Cells[2].Controls[0];
            GridView2.EditIndex = -1;
            IWinBO.Product obj = new IWinBO.Product();
            obj.ProductName = textadd.Text;
            obj.Price =Convert.ToDouble(textp.Text);
            obj.CatogoryId = Convert.ToInt32(categoryid);
            obj.SubCatogoryId = Convert.ToInt32(subcategoryid);
            obj.ProductId = userid;           
            IWinBLL.Product objBLL = new IWinBLL.Product();
            Result = objBLL.updateProduct(obj);
            if (Result == 3)
            {
                gvbind();
            }
        }

        protected void GridView2_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridView2.EditIndex = e.NewEditIndex;
            gvbind();
        }

        protected void GridView2_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int userid = Convert.ToInt32(GridView2.DataKeys[e.RowIndex].Value.ToString());
            GridViewRow row = (GridViewRow)GridView2.Rows[e.RowIndex];
            IWinBO.Product obj = new IWinBO.Product();
            obj.ProductId = userid;
            obj.OP = 4;
            IWinBLL.Product objBLL = new IWinBLL.Product();
            Result = objBLL.deleteProduct(obj);
            if (Result == 4)
            {
                gvbind();
            }
        }

        protected void txtSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                DataTable dtt = new DataTable();
                IWinBO.Product obj = new IWinBO.Product();
                obj.ProductName = txtSearch.Text;
                IWinBLL.Product objBLL = new IWinBLL.Product();
                dtt = objBLL.serachProduct(obj);
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

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (FileUpload1.HasFile)
                {
                    string extension = System.IO.Path.GetExtension(FileUpload1.FileName);
                    if (extension == ".jpg" || extension == ".png" || extension == ".gif")
                    {
                        FileUpload1.SaveAs(Server.MapPath("images//" + FileUpload1.FileName));
                    }
                    else
                    {
                        Response.Write("Select Correct file format");
                    }
                }

                IWinBO.Product sc = new IWinBO.Product();
                //IWinBLL.blUtil ps = new IWinBLL.blUtil();
                sc.ProductName = txtSCat.Text;
                sc.CatogoryId = Convert.ToInt32(ddlCategory.SelectedItem.Value);
                sc.SubCatogoryId = Convert.ToInt32(ddlSubCategory.SelectedItem.Value);
                sc.Brandid = Convert.ToInt32(ddlBrand.SelectedItem.Value);
                sc.Price = Convert.ToDouble(txtPrice.Text);
                sc.ProductImage = FileUpload1.FileName;
                sc.OP = 1;  //represent an insert operation 
                IWinBLL.Product objbu = new IWinBLL.Product();
                Result = objbu.insertProduct(sc);
                if (Result == 1)
                {
                    gvbind();
                    txtSCat.Text = "";
                    txtPrice.Text = "";
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
                DropDownList ddlBrand = (DropDownList)e.Row.FindControl("ddlBrand");
                du.Bindddl(ddlBrand);
                DataRowView dr = e.Row.DataItem as DataRowView;
                ddlBrand.SelectedValue = dr["Brand_id"].ToString();

                DropDownList ddlSubCategory = (DropDownList)e.Row.FindControl("ddlSubCategory");
                du.Bindddl(ddlSubCategory);
                DataRowView dr1 = e.Row.DataItem as DataRowView;
                ddlSubCategory.SelectedValue = dr1["subcategory_id"].ToString();
                
            }
        }

        protected void btnFilter_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dtt = new DataTable();
                IWinBO.Product obj = new IWinBO.Product();
                if(txtFilter.Text!="")
                {
                    obj.Price = Convert.ToDouble(txtFilter.Text);
                }
                else
                {
                    obj.Price = 0;
                }
                obj.BrandName = txtBrand.Text;
                IWinBLL.Product objBLL = new IWinBLL.Product();
                dtt = objBLL.filterPrice(obj);
                if (dtt.Rows.Count > 0)
                {
                    // GridView1.Rows.clear();
                    GridView2.DataSource = dtt;
                    GridView2.DataBind();
                }
            }
            catch
            {

            }
        }

        protected void txtBrand_TextChanged(object sender, EventArgs e)
        {

        }
    }
}