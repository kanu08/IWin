using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace IWin
{
    public partial class ad_addbrand : System.Web.UI.Page
    {
        int result = 0;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_SaveBrand_Click(object sender, EventArgs e)
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
                    lblmessage.Text = "<span class='glyphicon glyphicon-ok'></span>" + "Brand added successfully";
                    lblmessage.Visible = true;
                    txtBrand.Text = "";

                }
            }
            catch
            {

            }

        }
    }
}