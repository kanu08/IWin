using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace IWin
{
    public partial class se_reqChange : System.Web.UI.Page
    {
        int Result = 0;
        IWinDAL.dbUtil du = new IWinDAL.dbUtil();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                //du.Bindddl(ddlCategory);
            }

        }
        protected void btn_saveSubCat_Click(object sender, EventArgs e)
        {
            try
            {
                IWinBO.SellerAttribute sc = new IWinBO.SellerAttribute();
                sc.SellerAttr = Convert.ToString(ddlSellerAttr.SelectedItem.Text);
                sc.Seller = txtSeller.Text;
                sc.OP = 1;  //represent an insert operation 
                IWinBLL.SellerAttribute objbu = new IWinBLL.SellerAttribute();
                Result = objbu.insertSellerAttr(sc);
                if (Result == 1)
                {
                    lblmessage.Text = "<span class='glyphicon glyphicon-ok'></span>" + "Seller Details added successfully";
                    lblmessage.Visible = true;
                    Clear();
                }
            }
            catch
            {

            }
        }

        protected void Clear()
        {
            txtSeller.Text = "";
            ddlSellerAttr.SelectedIndex = 0;
        }
    }
}