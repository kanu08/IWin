using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using IWinBO;
using IWinBLL;
using IWinDAL;

namespace IWin
{
    public partial class ad_addSubcat : System.Web.UI.Page
    {
        int Result = 0;
        IWinDAL.dbUtil du = new IWinDAL.dbUtil();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                du.Bindddl(ddlCategory);
            }

        }
        protected void btn_saveSubCat_Click(object sender, EventArgs e)
        {
            try
            {
                IWinBO.SubCategory sc = new IWinBO.SubCategory();
                //IWinBLL.blUtil ps = new IWinBLL.blUtil();
                sc.SubcategoryName = txtSCat.Text;
                sc.CatValue = Convert.ToInt32(ddlCategory.SelectedItem.Value);
                sc.OP = 2;  //represent an insert operation 
                IWinBLL.SubCategory objbu = new IWinBLL.SubCategory();
                Result = objbu.insertSubCategory(sc);
                if (Result == 2)
                {
                    lblmessage.Text = "<span class='glyphicon glyphicon-ok'></span>" + "SubCategory added successfully";
                    lblmessage.Visible = true;
                }
            }
            catch
            {

            }
        }

        protected void Clear()
        {

        }
    }
}