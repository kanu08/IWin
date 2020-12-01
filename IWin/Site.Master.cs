using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using IWinBLL;


namespace IWin
{
    public partial class SiteMaster : MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            //loggedUser.Visible = false;
            //loggedAdmin.Visible = false;
            //withLogin.Visible = false;
            if (Session["user"] != null)
            {
                withoutLogin.Visible = false;
                withLogin.Visible = true;
                username.InnerHtml= Session["user"].ToString();
                int r = IWinBLL.blUtil.getRole(Session["user"].ToString());
                if ( r == 1)
                {
                    loggedUser.Visible = true;
                }
                else if (r==2)
                {
                    loggedAdmin.Visible = true;
                }
                else if (r == 3)
                {
                    loggedSell.Visible = true;
                    int Si = IWinBLL.blUtil.getSelId(Session["user"].ToString());
                    Session["Si"] = Si;
                }
                
            }
            
            // System.Threading.Thread.Sleep(3000);
        }

        protected void btn_logOut_Click(object sender, EventArgs e)
        {
            try
            {
                Session["user"] = null;
                Response.Redirect("UserHome.aspx");
            }
            catch
            {

            }
        }

    }
}