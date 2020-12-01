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
using IWinBO;
using IWinBLL;


namespace IWin
{
    public partial class se_MgInventory : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        //protected void Button1_Click(object sender, EventArgs e)
        //{
        //    foreach (GridViewRow row in GridView1.Rows)
        //    {
        //        DropDownList dlist = (row.Cells[2].FindControl("DropDownList1") as DropDownList);
        //        int rollno = Convert.ToInt32(row.Cells[0].Text);
        //        updaterow(rollno, dlist.Text);
        //    }
        //    GridView1.DataBind();
        //}

        //protected void updaterow(decimal price,int qty, int mqu)
        //{
        //    String constr = ConfigurationManager.ConnectionStrings["iwinConn"].ConnectionString;
        //    using (SqlConnection con = new SqlConnection(constr))
        //    {
        //        using (SqlCommand command = new SqlCommand())
        //        {
        //            command.CommandType = CommandType.StoredProcedure;
        //            int result = 0;
        //            command.CommandText = "sp_user_Seller";
        //            SqlConnection con = new SqlConnection(mycon);
        //            con.Open();
        //            SqlCommand cmd = new SqlCommand();
        //            cmd.CommandText = updatedata;
        //            cmd.Connection = con;
        //            cmd.ExecuteNonQuery();
        //            try
        //            {
        //                command.Parameters.Add(new SqlParameter("@SEmail", em));
        //                command.Parameters.Add(new SqlParameter("@OP", 4));
        //            }
        //            catch (Exception ex)
        //            {
        //                //ErrHandler.WriteError(ex.ToString());
        //                throw ex;
        //            }
        //            command.Connection = con;
        //            SqlDataReader reader = command.ExecuteReader();
        //            reader.Read();
        //            result = Convert.ToInt32(reader["Id"]);
        //            con.Close();
        //            Label4.Text = "Data Has Been Updated";
        //        }
        //    }
        //}

        protected bool GetAv(string sellPrice,string sellQty )
        {
            string s1 = sellPrice;
            string s2 = sellQty;
            if ((s1.Trim() == "") || (s2.Trim() == "") || s1 == null || s2 == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        //protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        //{
           

        //}

        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "Update")
            {
                try
                {
                    int r;
                    int ind = Convert.ToInt32(e.CommandArgument);
                    //GridViewRow row = GridView1.Rows[Convert.ToInt32(e.CommandArgument)];
                    //string eno;
                    GridViewRow row = GridView1.Rows[ind];
                    HiddenField eno2 = row.Cells[0].FindControl("HiddenField1") as HiddenField;
                    string eno = GridView1.Rows[Convert.ToInt32(e.CommandArgument)].Cells[2].Text;
                    TextBox tSPrice = (TextBox)row.FindControl("TextBox1");
                    TextBox tSQty = (TextBox)row.FindControl("TextBox2");
                    IWinBO.SellerInventory si1 = new IWinBO.SellerInventory();
                    si1.OP = "1";
                    si1.mqu = eno2.Value;
                    si1.SId = Session["Si"].ToString();
                    if (tSPrice.Text == "" || tSQty.Text == "")
                    {
                        si1.SPrice = "0";
                        si1.SQty = "0";
                    }
                    else
                    {
                        si1.SPrice = tSPrice.Text;
                        si1.SQty = tSQty.Text;
                    }
                    IWinBLL.Seller si2 = new IWinBLL.Seller();
                    r = si2.updInventory(si1);
                    if (r == 1)
                    {
                        Label4.Text = "DONE";
                        Response.Redirect("se_MgInventory.aspx");
                    }


                }
                catch
                {

                }
            }
        }
    }
}