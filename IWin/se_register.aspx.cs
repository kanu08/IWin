using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using IWinBLL;


namespace IWin
{
    public partial class se_register : System.Web.UI.Page
    {
        int Result;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_regSell_Click(object sender, EventArgs e)
        {
            int FindDtlId;
            try
            {
                string en_password = null;
                int dtlId = Convert.ToInt32(txtDtlId.Text);
                IWinBO.Seller se = new IWinBO.Seller();
                IWinBLL.Seller objse = new IWinBLL.Seller();
                FindDtlId = objse.FindDtlId(dtlId);
                if (FindDtlId == 3)
                {
                    lblmessage.Text = "The Seller with above detail ID is already registered.Please check faq for more help.";
                    lblmessage.Visible = true;
                }
                else if(FindDtlId == 4)
                {
                    se.SellerDetailId = dtlId;
                    se.SellerEmail = txtEmail.Text;
                    se.Active = chkActive.Checked;
                    en_password = blUtil.PBKDF2password(txtPass.Text);
                    se.Password = en_password;
                    se.OP = 3;  //represent a register operation 
                    Result = objse.regSeller(se);
                    if (Result == 6)
                    {
                        lblmessage.Text = "<span class='glyphicon glyphicon-ok'></span>" + "Seller registered successfully";
                        lblmessage.Visible = true;
                        Clear();
                    }
                }
                else if(FindDtlId == 5)
                {
                    lblmessage.Text = "The Seller with above detail ID seems not approved by Admin.Please check faq for more help.";
                    lblmessage.Visible = true;
                }
                
            }
            catch
            {

            }
        }

        protected void Clear()
        {
            txtDtlId.Text = "";
            txtEmail.Text = "";
            txtPass.Text = "";
            chkActive.Checked = false;
        }
    }
}