using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using IWinBO;
using IWinBLL;
using System.Data;

namespace IWin
{
    public partial class us_bbfProd : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                // Bind Gridview during pageload
                BindProductRecordsGridView();
            }
        }

        private void BindProductRecordsGridView()
        {
            DataSet ds = new DataSet();
            try
            {
                IWinBLL.Product objProduct = new IWinBLL.Product();
                ds = objProduct.GetNearExpiryProducts();
                if (ds.Tables[0].Rows.Count > 0)
                {
                    grdproductDetails.DataSource = ds;
                    grdproductDetails.DataBind();
                }
                else
                {
                    grdproductDetails.DataSource = null;
                    grdproductDetails.DataBind();
                }
            }
            catch (Exception ex)
            {
                Response.Write(" error occured :" + ex.Message.ToString());
            }
            finally
            {

            }
        }
        #region "Paging in GridView"
        protected void grdproductDetails_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            grdproductDetails.PageIndex = e.NewPageIndex;
            BindProductRecordsGridView();
        }
        #endregion
    }
}
