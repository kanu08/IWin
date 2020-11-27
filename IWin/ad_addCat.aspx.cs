using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using IWinBLL;

namespace IWin
{
    public partial class ad_addCat : System.Web.UI.Page
    {
        int Result = 0;
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btn_saveCat_Click(object sender, EventArgs e)
        {
            try
            {
                IWinBO.Category obj = new IWinBO.Category();
                IWinBLL.iwinbl objBLL = new IWinBLL.iwinbl();
                obj.CategoryName = txtCatName.Text;
                obj.OP = 1;
                Result = objBLL.insertCategory(obj);
                if (Result == 1)
                {
                    lblMessage.Text = "<span class='glyphicon glyphicon-ok'></span>" + "Category added successfully";
                    lblMessage.Visible = true;
                    Clear();
                }
            }
            catch
            {

            }
        }

        protected void Clear()
        {
            txtCatName.Text = "";
            //  lblMessage.Visible = true;
        }
    }
}