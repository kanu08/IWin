using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace IWin
{
    public partial class ad_updBrand : System.Web.UI.Page
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
            IWinBLL.Brand objBLL = new IWinBLL.Brand();
            dt = objBLL.Init();
            GridView2.DataSource = dt;
            GridView2.DataBind();
        }
        protected void txtSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                DataTable dtt = new DataTable();
                IWinBO.Brand obj = new IWinBO.Brand();
                obj.BrandName = txtSearch.Text;
                IWinBLL.Brand objBLL = new IWinBLL.Brand();
                dtt = objBLL.serach(obj);
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
// method to undo editing of the rows in the GridView
        protected void GridView2_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GridView2.EditIndex = -1;
            gvbind();
        }
// if the user selects the "delete" button for a particular row, the content of that row is removed from the grid 
        protected void GridView2_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int userid = Convert.ToInt32(GridView2.DataKeys[e.RowIndex].Value.ToString());
            GridViewRow row = (GridViewRow)GridView2.Rows[e.RowIndex];
            IWinBO.Brand obj = new IWinBO.Brand();
            obj.BrandId = userid;
            obj.OP = 4;
            IWinBLL.Brand objBLL = new IWinBLL.Brand();
            result = objBLL.deleteBrand(obj);
            if (result == 4)
            {
                gvbind();
            }
        }

        protected void GridView2_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridView2.EditIndex = e.NewEditIndex;
            gvbind();
        }
// this method allows the user to edit brand name,  fro a particular row in the GridView
        protected void GridView2_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            int userid = Convert.ToInt32(GridView2.DataKeys[e.RowIndex].Value.ToString());
            GridViewRow row = (GridViewRow)GridView2.Rows[e.RowIndex];
            //TextBox txtname=(TextBox)gr.cell[].control[];  
            TextBox textadd = (TextBox)row.Cells[1].Controls[0];

            GridView2.EditIndex = -1;
            IWinBO.Brand obj = new IWinBO.Brand();
            obj.BrandName = textadd.Text;
            //obj.CategoryId = Convert.ToInt32(textc.Text);
            obj.BrandId = userid;

            IWinBLL.Brand objBLL = new IWinBLL.Brand();
            result = objBLL.updateBrand(obj);
            if (result == 3)
            {
                gvbind();
            }

        }

        protected void GridView2_RowCreated(object sender, GridViewRowEventArgs e)
        {

        }
// this method allows the user to insert a new row for a Ptoduct
        protected void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                IWinBO.Brand sc = new IWinBO.Brand();
                //IWinBLL.blUtil ps = new IWinBLL.blUtil();
                sc.BrandName = txtBrand.Text;
                sc.OP = 1;  //represent an insert operation 
                IWinBLL.Brand objbu = new IWinBLL.Brand();
                result = objbu.insertBrand(sc);
                if (result == 1)
                {
                    gvbind();
                    txtBrand.Text = "";

                }
            }
            catch
            {

            }

        }


    }
}
