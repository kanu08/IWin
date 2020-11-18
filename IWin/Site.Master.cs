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
    {       // this method is used to fetch the client's status( i.e. user or admin) from the list
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
                if ( r == 1)    // if first option is selected. the client is a user
                {
                    loggedUser.Visible = true;
                }
                else if (r==2)  // if second option is selected. the client is an admin of the application
                {
                    loggedAdmin.Visible = true;
                }
            }
            
            // System.Threading.Thread.Sleep(3000);
        }

        protected void btn_logOut_Click(object sender, EventArgs e)
        {   // if the client clicks on logout button, he is directed to the home page i.e. UserHome
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
