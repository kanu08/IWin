using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace IWin
{
    public partial class us_prodReq : System.Web.UI.Page
    {
        int Result = 0;
        int val = 0;
        IWinDAL.dbUtil du = new IWinDAL.dbUtil();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                du.Bindddl(ddlProducts);
            }
            lblPro.Visible = false;
            ddlProducts.Visible = false;
            lblProduct.Visible = false;
            txtProduct.Visible = false;
            lblBrand.Visible = false;
            txtBrand.Visible = false;
            lblCmt.Visible = false;
            txtTinyMCE.Visible = false;
        }

        protected void input_2_Click(object sender, EventArgs e)
        {
            try
            {
                IWinBO.Advice obj = new IWinBO.Advice();
                IWinBLL.Advice objBLL = new IWinBLL.Advice();
                obj.ProductValid = Convert.ToInt32(RBList1.SelectedValue.ToString());
                obj.ProductName = txtProduct.Text;
                obj.BrandName = txtBrand.Text;
                obj.Details = txtTinyMCE.Text;
                if (ddlProducts.SelectedValue.ToString() != Convert.ToString(0))
                {
                    obj.ProductId = Convert.ToInt32(ddlProducts.SelectedValue.ToString());
                }
                else
                {
                    obj.ProductId = 0;
                }
                obj.OP = 1;
                Result = objBLL.insertAdvice(obj);
                if (Result == 1)
                {
                    lblmessage.Text = "<span class='glyphicon glyphicon-ok'></span>" + "Your request is sent to portal!!";
                    lblmessage.Visible = true;
                    Clear();
                }
            }
            catch
            {

            }
        }
        public void Clear()
        {
            txtBrand.Text = "";
            txtProduct.Text = "";
            txtTinyMCE.Text = "";
        }

        protected void RBList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            val = Convert.ToInt32(RBList1.SelectedValue.ToString());
            if (val == 1)
            {
                lblPro.Visible = true;
                ddlProducts.Visible = true;
                lblCmt.Visible = true;
                txtTinyMCE.Visible = true;
            }
            else if (val == 2)
            {
                lblProduct.Visible = true;
                txtProduct.Visible = true;
                lblBrand.Visible = true;
                txtBrand.Visible = true;
                lblCmt.Visible = true;
                txtTinyMCE.Visible = true;
            }
        }
    }
}