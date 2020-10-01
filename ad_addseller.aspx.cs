using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using Microsoft.Ajax.Utilities;

namespace IWin.UI
{
    public partial class ad_addstore : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_saveSeller_Click(object sender, EventArgs e)
        {
            try
            {
                iwinBO se = new iwinBO();
                se.SellerName = txtSName.Text;
                se.SellerImage = txtSImage.Text;
                se.SellerLocation = txtSLoc.Text;
                se.SellerContact = txtSContact.Text;

            }
        }
    }
}