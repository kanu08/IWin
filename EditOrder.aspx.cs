using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class EditOrder : System.Web.UI.Page
{
    DataTable dt;
    protected void Page_Load(object sender, EventArgs e)
    {
        if(IsPostBack)
        {
        }
        else
        {
            if (Request.QueryString["sno"] != null)
            {
                dt = (DataTable)Session["buyitems"];


                for (int i = 0; i <= dt.Rows.Count - 1; i++)
                {
                    int sr;
                    int sr1;
                    sr = Convert.ToInt32(dt.Rows[i]["sno"].ToString());
                    Label3.Text = Request.QueryString["sno"];
                    Label4.Text = sr.ToString();
                    sr1 = Convert.ToInt32(Label3.Text);
                    //sr1 = sr1 + 1;


                    if (sr == sr1)
                    {
                        Label3.Text = dt.Rows[i]["sno"].ToString();
                        Label4.Text = dt.Rows[i]["product_id"].ToString();
                        Label5.Text = dt.Rows[i]["product_Name"].ToString();
                        DropDownList1.Text = dt.Rows[i]["quantity"].ToString();
                        Label6.Text = dt.Rows[i]["product_price"].ToString();
                        Label7.Text = dt.Rows[i]["totalprice"].ToString();

                        break;

                    }
                }
            }
            else
            {
            }

        }
    }


    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        int s = Convert.ToInt32(DropDownList1.SelectedValue);
        Double q = Convert.ToDouble(Label6.Text);
        Double r=s*q;
        
       // int number;
     //   if (!int.TryParse(Label6.Text, out number))
      //  { }
            Label7.Text = Convert.ToString(r);
        
        
        
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        dt = (DataTable)Session["buyitems"];


        for (int i = 0; i <= dt.Rows.Count - 1; i++)
        {
            int sr;
            int sr1;
            sr = Convert.ToInt32(dt.Rows[i]["sno"].ToString());

            sr1 = Convert.ToInt32(Label3.Text);



            if (sr == sr1)
            {
                dt.Rows[i]["sno"] = Label3.Text;
                dt.Rows[i]["product_id"] = Label4.Text;
                dt.Rows[i]["product_Name"] = Label5.Text;
                dt.Rows[i]["quantity"] = DropDownList1.Text;
                dt.Rows[i]["product_price"] = Label6.Text;
                dt.Rows[i]["totalprice"] = Label7.Text;
                dt.AcceptChanges();

                break;

            }
        }
        Response.Redirect("AddToCart.aspx");
    }

}

