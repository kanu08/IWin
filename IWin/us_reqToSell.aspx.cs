using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace IWin
{
    public partial class us_reqToSell : System.Web.UI.Page
    {
        int Result = 0;
        IWinDAL.dbUtil du = new IWinDAL.dbUtil();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                // du.Bindddl(ddlFeedBack);
            }
        }

        protected void input_2_Click(object sender, EventArgs e)
        {
            //  string rating = hdfRatingValue.Value;
            try
            {
                IWinBO.SellerRequest obj = new IWinBO.SellerRequest();
                IWinBLL.SellerReq objBLL = new IWinBLL.SellerReq();
                obj.SellerContact = txtContact.Text;
                //   obj.FeedBackType= Convert.ToInt32(ddlFeedBack.SelectedItem.Value);
                //   obj.Rating = Convert.ToInt32(rating);
                //   obj.UserName = txtName.Text;
                obj.OP = Convert.ToString(1);
                Result = objBLL.insertSellerReq(obj);
                if (Result >= 1)
                {
                    lblmessage.Text = "<span class='glyphicon glyphicon-ok'></span>" + "Thank You For Your Request and the RequestID is " + Result;
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
            // txtName.Text = "";
            txtTinyMCE.Text = "";
            txtContact.Text = "";
            txtPin.Text = "";
            txtProvience.Text = "";
            txtSellerName.Text = "";
        }
    }
}