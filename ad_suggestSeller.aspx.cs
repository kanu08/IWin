using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace IWin
{
    public partial class ad_suggestSeller : System.Web.UI.Page
    {
        int Result = 0;
        IWinDAL.dbUtil du = new IWinDAL.dbUtil();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                du.Bindddl(ddlPinCode);
            }
            lblCmt.Visible = false;
            txtTinyMCE.Visible = false;
            lbltypes.Visible = false;
            ddlTypes.Visible = false;
            lblPincode.Visible = false;
            ddlPinCode.Visible = false;
            lblSeller.Visible = false;
            txtSeller.Visible = false;
        }
        protected void btn_saveSubCat_Click(object sender, EventArgs e)
        {
            try
            {
                IWinBO.Suggestions sc = new IWinBO.Suggestions();
                sc.OP = 1;  //represent an insert operation 
                if (txtSeller.Text != "")
                {
                    sc.SellerId = Convert.ToInt32(txtSeller.Text);
                }
                else
                {
                    sc.SellerId = 0;
                }
                sc.SuggesChioces = ddlChoices.SelectedItem.Text;
                sc.SuggesComment = txtTinyMCE.Text;
                sc.SuggesPinCode = Convert.ToInt32(ddlPinCode.SelectedValue.ToString());
                sc.SuggesType = ddlTypes.SelectedItem.Text;
                IWinBLL.Suggestions objbu = new IWinBLL.Suggestions();
                Result = objbu.insertSuggestion(sc);
                if (Result == 1)
                {
                    lblmessage.Text = "<span class='glyphicon glyphicon-ok'></span>" + "Successfully Sent to Seller";
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
            txtTinyMCE.Text = "";
            ddlChoices.SelectedIndex = 0;
            ddlTypes.SelectedIndex = 0;
        }

        protected void ddlChoices_SelectedIndexChanged(object sender, EventArgs e)
        {
            int val = Convert.ToInt32(ddlChoices.SelectedValue.ToString());
            if (val == 1)
            {
                lblCmt.Visible = true;
                txtTinyMCE.Visible = true;
                lbltypes.Visible = true;
                ddlTypes.Visible = true;
            }
            else if (val == 2)
            {
                lblCmt.Visible = true;
                txtTinyMCE.Visible = true;
                lbltypes.Visible = true;
                ddlTypes.Visible = true;
                lblPincode.Visible = true;
                ddlPinCode.Visible = true;
            }
            else if (val == 3)
            {
                lblCmt.Visible = true;
                txtTinyMCE.Visible = true;
                lbltypes.Visible = true;
                ddlTypes.Visible = true;
                lblSeller.Visible = true;
                txtSeller.Visible = true;
            }
            else if (val == 0)
            {
                lblCmt.Visible = false;
                txtTinyMCE.Visible = false;
                lbltypes.Visible = false;
                ddlTypes.Visible = false;
                lblPincode.Visible = false;
                ddlPinCode.Visible = false;
                lblSeller.Visible = false;
                txtSeller.Visible = false;
            }
        }
    }
}