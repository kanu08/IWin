using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace IWin
{
    public partial class us_Feedback : System.Web.UI.Page
    {
        int Result = 0;
        IWinDAL.dbUtil du = new IWinDAL.dbUtil();
        protected void Page_Load(object sender, EventArgs e)
        {
            du.Bindddl(ddlFeedBack);
        }

        protected void input_2_Click(object sender, EventArgs e)
        {
            string rating = hdfRatingValue.Value;
            try
            {
                IWinBO.FeedBack obj = new IWinBO.FeedBack();
                IWinBLL.FeedBack objBLL = new IWinBLL.FeedBack();
                obj.Comments = txtTinyMCE.Text;
                obj.FeedBackType = Convert.ToInt32(ddlFeedBack.SelectedItem.Value);
                obj.Rating = Convert.ToInt32(rating);
                obj.UserName = txtName.Text;
                obj.OP = 1;
                Result = objBLL.insertFeedBack(obj);
                if (Result == 1)
                {
                    lblmessage.Text = "<span class='glyphicon glyphicon-ok'></span>" + "Thank You For Your FeedBack !!";
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
            txtName.Text = "";
            txtTinyMCE.Text = "";
        }
    }
}