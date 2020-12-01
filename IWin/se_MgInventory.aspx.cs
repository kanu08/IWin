using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace IWin
{
    public partial class se_MgInventory : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            foreach (GridViewRow row in GridView1.Rows)
            {
                DropDownList dlist = (row.Cells[2].FindControl("DropDownList1") as DropDownList);
                int rollno = Convert.ToInt32(row.Cells[0].Text);
                updaterow(rollno, dlist.Text);



            }
            GridView1.DataBind();
        }

        protected void updaterow(decimal price,int qty, int mqu)
        {
            String constr = ConfigurationManager.ConnectionStrings["iwinConn"].ConnectionString;
            using (SqlConnection con = new SqlConnection(constr))
            {
                using (SqlCommand command = new SqlCommand())
                {
                    command.CommandType = CommandType.StoredProcedure;
                    int result = 0;
                    command.CommandText = "sp_user_Seller";
                    SqlConnection con = new SqlConnection(mycon);
                    con.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandText = updatedata;
                    cmd.Connection = con;
                    cmd.ExecuteNonQuery();
                    try
                    {
                        command.Parameters.Add(new SqlParameter("@SEmail", em));
                        command.Parameters.Add(new SqlParameter("@OP", 4));
                    }
                    catch (Exception ex)
                    {
                        //ErrHandler.WriteError(ex.ToString());
                        throw ex;
                    }
                    command.Connection = con;
                    SqlDataReader reader = command.ExecuteReader();
                    reader.Read();
                    result = Convert.ToInt32(reader["Id"]);
                    con.Close();
                    Label2.Text = "Data Has Been Updated";
                }
            }
        }
    }
}