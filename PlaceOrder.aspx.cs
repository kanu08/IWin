using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class PlaceOrder : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            DataTable dt = new DataTable();
            DataRow dr;
            dt.Columns.Add("sno");
            dt.Columns.Add("product_id");
            dt.Columns.Add("product_Name");
            dt.Columns.Add("quantity");
            dt.Columns.Add("product_price");
            dt.Columns.Add("totalprice");


            if (Request.QueryString["id"] != null)
            {
                if (Session["Buyitems"] == null)
                {

                    dr = dt.NewRow();
                    String mycon = "Data Source=DESKTOP-MFL6VGP\\SQLEXPRESS06;Initial Catalog=iwin;Integrated Security=True";
                    SqlConnection scon = new SqlConnection(mycon);
                    String myquery = "select * from dbo.tbl_lookup_product where product_id=" + Request.QueryString["id"];
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandText = myquery;
                    cmd.Connection = scon;
                    SqlDataAdapter da = new SqlDataAdapter();
                    da.SelectCommand = cmd;
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    dr["sno"] = 1;
                    dr["product_id"] = ds.Tables[0].Rows[0]["product_id"].ToString();
                    dr["product_Name"] = ds.Tables[0].Rows[0]["product_Name"].ToString();
                    dr["quantity"] = Request.QueryString["quantity"];
                    dr["product_price"] = ds.Tables[0].Rows[0]["product_price"].ToString();
                    Double price = Convert.ToDouble(ds.Tables[0].Rows[0]["product_price"].ToString());
                    int quantity = Convert.ToInt32(Request.QueryString["quantity"].ToString());
                    Double totalprice = price * quantity;
                    dr["totalprice"] = totalprice;

                    dt.Rows.Add(dr);
                    GridView1.DataSource = dt;
                    GridView1.DataBind();

                    Session["buyitems"] = dt;
                    GridView1.FooterRow.Cells[5].Text = "Total Amount";
                    GridView1.FooterRow.Cells[6].Text = grandtotal().ToString();
                    Response.Redirect("AddToCart.aspx");

                }
                else
                {

                    dt = (DataTable)Session["buyitems"];
                    int sr;
                    sr = dt.Rows.Count;

                    dr = dt.NewRow();
                    String mycon = "Data Source=DESKTOP-MFL6VGP\\SQLEXPRESS06;Initial Catalog=iwin;Integrated Security=True";
                    SqlConnection scon = new SqlConnection(mycon);
                    String myquery = "select * from dbo.tbl_lookup_product where product_id=" + Request.QueryString["id"];
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandText = myquery;
                    cmd.Connection = scon;
                    SqlDataAdapter da = new SqlDataAdapter();
                    da.SelectCommand = cmd;
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    dr["sno"] = sr + 1;
                    dr["product_id"] = ds.Tables[0].Rows[0]["product_id"].ToString();
                    dr["product_Name"] = ds.Tables[0].Rows[0]["product_Name"].ToString();
                    dr["quantity"] = Request.QueryString["quantity"];
                    dr["product_price"] = ds.Tables[0].Rows[0]["product_price"].ToString();
                    Double price = Convert.ToDouble(ds.Tables[0].Rows[0]["product_price"].ToString());
                    int quantity = Convert.ToInt16(Request.QueryString["quantity"].ToString());
                    Double totalprice = price * quantity;
                    dr["totalprice"] = totalprice;

                    dt.Rows.Add(dr);
                    GridView1.DataSource = dt;
                    GridView1.DataBind();

                    Session["buyitems"] = dt;
                    GridView1.FooterRow.Cells[5].Text = "Total Amount";
                    GridView1.FooterRow.Cells[6].Text = grandtotal().ToString();
                    Response.Redirect("AddToCart.aspx");

                }
            }
            else
            {
                dt = (DataTable)Session["buyitems"];
                GridView1.DataSource = dt;
                GridView1.DataBind();
                if (GridView1.Rows.Count > 0)
                {
                    GridView1.FooterRow.Cells[5].Text = "Total Amount";
                    GridView1.FooterRow.Cells[6].Text = grandtotal().ToString();

                }


            }
            //Label2.Text = GridView1.Rows.Count.ToString();

        }
        Label4.Text = DateTime.Now.ToShortDateString();
        findorderid();

    }
    public Double grandtotal()
    {
        DataTable dt = new DataTable();
        dt = (DataTable)Session["buyitems"];
        Double nrow = dt.Rows.Count;
        int i = 0;
        Double gtotal = 0;
        while (i < nrow)
        {
            gtotal = gtotal + Convert.ToDouble(dt.Rows[i]["totalprice"].ToString());

            i = i + 1;
        }
        return gtotal;
    }
    public void findorderid()
    {
        String pass = "abcdefghijklmnopqrstuvwxyz123456789";
        Random r = new Random();
        char[] mypass = new char[5];
        for (int i = 0; i < 5; i++)
        {
            mypass[i] = pass[(int)(35 * r.NextDouble())];

        }
        String orderid;
        orderid = "Order" + DateTime.Now.Hour.ToString() + DateTime.Now.Minute.ToString() + DateTime.Now.Second.ToString() + DateTime.Now.Day.ToString() + DateTime.Now.Month.ToString() + DateTime.Now.Year.ToString() + new string(mypass);

        Label3.Text = orderid;


    }

    public void saveaddress()
    {
        String updatepass = "insert into dbo.tbl_order(orderid,Addressid,delivery_date) values('" + Label3.Text + "','" + TextBox1.Text + "',' + TextBox2.Text + ')";
        String mycon1 = "Data Source=DESKTOP-MFL6VGP\\SQLEXPRESS06;Initial Catalog=iwin;Integrated Security=True";
        SqlConnection s = new SqlConnection(mycon1);
        s.Open();
        SqlCommand cmd1 = new SqlCommand();
        cmd1.CommandText = updatepass;
        cmd1.Connection = s;
        cmd1.ExecuteNonQuery();
        s.Close();
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        DataTable dt;
        dt = (DataTable)Session["buyitems"];



        for (int i = 0; i <= dt.Rows.Count - 1; i++)
        {
            String updatepass = "insert into dbo.tbl_order(orderid,sno,product_id,product_Name,product_price,quantity,delivery_date) values('" + Label3.Text + "'," + dt.Rows[i]["sno"] + "," + dt.Rows[i]["product_id"] + ",'" + dt.Rows[i]["product_Name"] + "'," + dt.Rows[i]["product_price"] + "," + dt.Rows[i]["quantity"] + ",'" + Label4.Text + "')";
            String mycon1 = "Data Source=DESKTOP-MFL6VGP\\SQLEXPRESS06;Initial Catalog=iwin;Integrated Security=True";
            SqlConnection s = new SqlConnection(mycon1);
            s.Open();
            SqlCommand cmd1 = new SqlCommand();
            cmd1.CommandText = updatepass;
            cmd1.Connection = s;
            cmd1.ExecuteNonQuery();
            s.Close();

        }
        saveaddress();
        Response.Redirect("PlacedSuccessfully.aspx");
    }
}