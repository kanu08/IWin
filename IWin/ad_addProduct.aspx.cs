using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using IWinDAL;

namespace IWin
{
    public partial class ad_addProduct : System.Web.UI.Page
    {
        int Result = 0;
        IWinDAL.dbUtil du = new IWinDAL.dbUtil();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                //du.Bindddl(ddlCategory);
                du.Bindddl(ddlSubCategory);
                du.Bindddl(ddlBrand);
            }

        }

        protected void btn_saveProd_Click(object sender, EventArgs e)
        {
            try
            {
                if (FileUpload1.HasFile)
                {
                    string extension = System.IO.Path.GetExtension(FileUpload1.FileName);
                    if (extension == ".jpg" || extension == ".png" || extension == ".gif")
                    {
                        FileUpload1.SaveAs(Server.MapPath("images//" + FileUpload1.FileName));
                    }
                    else
                    {
                        Response.Write("Select Correct file format");
                    }
                }
                IWinBO.Product sc = new IWinBO.Product();
                //IWinBLL.blUtil ps = new IWinBLL.blUtil();
                sc.ProductName = txtSCat.Text;
                //sc.CatogoryId = Convert.ToInt32(ddlCategory.SelectedItem.Value);
                sc.SubCategoryId = Convert.ToInt32(ddlSubCategory.SelectedItem.Value);
                sc.Brandid = Convert.ToInt32(ddlBrand.SelectedItem.Value);
                sc.Price = Convert.ToDouble(txtPrice.Text);
                sc.ProductImage = FileUpload1.FileName;
                sc.OP = 1;  //represent an insert operation 
                IWinBLL.Product objbu = new IWinBLL.Product();
                Result = objbu.insertProduct(sc);
                if (Result == 1)
                {
                    lblmessage.Text = "<span class='glyphicon glyphicon-ok'></span>" + "Product added successfully";
                    lblmessage.Visible = true;
                    txtSCat.Text = "";
                    txtPrice.Text = "";
                    ddlBrand.ClearSelection();
                    ddlSubCategory.ClearSelection();
                }
            }
            catch
            {

            }
        }

        protected void btn_clearCat_Click(object sender, EventArgs e)
        {
            txtSCat.Text = "";
            txtPrice.Text = "";

        }
    }
}