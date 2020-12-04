using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using IWinDAL;


namespace IWin
{
    public partial class AddToCart1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            IWinDAL.dbUtil ut = new IWinDAL.dbUtil();
            string img = null;
            if (!IsPostBack)
            {
                if (Session["done"] != null)
                {
                    if (Session["done"].ToString() == "yes")
                    {
                        Label10.Text = "Order Placed!!";
                    }
                }
                DataTable dt = new DataTable();
                DataRow dr;
                dt.Columns.Add("sno");
                //dt.Columns.Add("product_id");
                dt.Columns.Add("Name");
                dt.Columns.Add("Image");
                dt.Columns.Add("Brand");
                dt.Columns.Add("quantity");
                dt.Columns.Add("uom");
                dt.Columns.Add("MRP");
                dt.Columns.Add("sname");
                dt.Columns.Add("sprice");
                dt.Columns.Add("sQty");
                dt.Columns.Add("dis");
                dt.Columns.Add("order");
                dt.Columns.Add("totalprice");
                dt.Columns.Add("mid");
                dt.Columns.Add("sid");

                if (Request.QueryString["mqu"] != null
                    && Request.QueryString["se"]!=null && Request.QueryString["pid"]!=null)
                {
                    if (Session["Buyitems"] == null)
                    {

                        dr = dt.NewRow();
                        DataSet ds = new DataSet();
                        IWinBO.Cart c1 = new IWinBO.Cart();
                        c1.Mqu = Request.QueryString["mqu"];
                        c1.Pid = Request.QueryString["pid"];
                        c1.Se = Request.QueryString["se"];
                        //c1.Qty = Request.QueryString["qty"];
                        IWinBLL.Cart cl = new IWinBLL.Cart();
                        ds = cl.getCart(c1);
                        //da.Fill(ds);
                        dr["sno"] = 1;
                        dr["Name"] = ds.Tables[0].Rows[0].ItemArray[0].ToString();
                        img = ds.Tables[0].Rows[0].ItemArray[1].ToString();
                        dr["Image"] = "~/images/"+img;
                        dr["Brand"] = ds.Tables[0].Rows[0].ItemArray[2].ToString();
                        dr["quantity"] = ds.Tables[0].Rows[0].ItemArray[3].ToString();
                        dr["uom"] = ds.Tables[0].Rows[0].ItemArray[4].ToString();
                        dr["MRP"] = ds.Tables[0].Rows[0].ItemArray[5].ToString();
                        dr["sname"] = ds.Tables[0].Rows[0].ItemArray[6].ToString();
                        dr["sprice"] = ds.Tables[0].Rows[0].ItemArray[7].ToString();
                        dr["sQty"] = ds.Tables[0].Rows[0].ItemArray[8].ToString();
                        dr["dis"] = ds.Tables[0].Rows[0].ItemArray[9].ToString();
                        dr["order"] = Request.QueryString["qty"];
                        //dr["totalprice"] = ds.Tables[0].Rows[0]["price"].ToString();
                        Double price = Convert.ToDouble(ds.Tables[0].Rows[0].ItemArray[7].ToString());
                        int quantity = Convert.ToInt32(Request.QueryString["qty"]);
                        Double totalprice = price * quantity;
                        dr["totalprice"] = totalprice;
                        dr["mid"] = Request.QueryString["mqu"];
                        dr["sid"] = Request.QueryString["se"];

                        dt.Rows.Add(dr);
                        GridView1.DataSource = dt;
                        GridView1.DataBind();

                        Session["buyitems"] = dt;
                        GridView1.FooterRow.Cells[10].Text = "Total Amount";
                        GridView1.FooterRow.Cells[11].Text = grandtotal().ToString();
                        Response.Redirect("AddToCart.aspx");

                    }
                    else
                    {

                        dt = (DataTable)Session["buyitems"];
                        int sr;
                        sr = dt.Rows.Count;
                        dr = dt.NewRow();
                        DataSet ds = new DataSet();
                        IWinBO.Cart c1 = new IWinBO.Cart();
                        c1.Mqu = Request.QueryString["mqu"];
                        c1.Pid = Request.QueryString["pid"];
                        c1.Se = Request.QueryString["se"];
                        IWinBLL.Cart cl = new IWinBLL.Cart();
                        ds = cl.getCart(c1);
                        //da.Fill(ds);
                        dr["sno"] = sr+1;
                        dr["Name"] = ds.Tables[0].Rows[0].ItemArray[0].ToString();
                        img = ds.Tables[0].Rows[0].ItemArray[1].ToString();
                        dr["Image"] = "~/images/" + img;
                        dr["Brand"] = ds.Tables[0].Rows[0].ItemArray[2].ToString();
                        dr["quantity"] = ds.Tables[0].Rows[0].ItemArray[3].ToString();
                        dr["uom"] = ds.Tables[0].Rows[0].ItemArray[4].ToString();
                        dr["MRP"] = ds.Tables[0].Rows[0].ItemArray[5].ToString();
                        dr["sname"] = ds.Tables[0].Rows[0].ItemArray[6].ToString();
                        dr["sprice"] = ds.Tables[0].Rows[0].ItemArray[7].ToString();
                        dr["sQty"] = ds.Tables[0].Rows[0].ItemArray[8].ToString();
                        dr["dis"] = ds.Tables[0].Rows[0].ItemArray[9].ToString();
                        dr["order"] = Request.QueryString["qty"];
                        //dr["totalprice"] = ds.Tables[0].Rows[0]["price"].ToString();
                        Double price = Convert.ToDouble(ds.Tables[0].Rows[0].ItemArray[7].ToString());
                        int quantity = Convert.ToInt32(Request.QueryString["qty"]);
                        Double totalprice = price * quantity;
                        dr["totalprice"] = totalprice;
                        dr["mid"] = Request.QueryString["mqu"];
                        dr["sid"] = Request.QueryString["se"];


                        dt.Rows.Add(dr);

                        GridView1.DataSource = dt;
                        GridView1.DataBind();

                        Session["buyitems"] = dt;
                        GridView1.FooterRow.Cells[10].Text = "Total Amount";
                        GridView1.FooterRow.Cells[11].Text = grandtotal().ToString();
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
                        GridView1.FooterRow.Cells[10].Text = "Total Amount";
                        GridView1.FooterRow.Cells[11].Text = grandtotal().ToString();

                    }


                }
                Label2.Text = GridView1.Rows.Count.ToString();

            }

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

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            DataTable dt = new DataTable();
            dt = (DataTable)Session["buyitems"];


            for (int i = 0; i <= dt.Rows.Count - 1; i++)
            {
                int sr;
                int sr1;
                string qdata;
                string dtdata;
                sr = Convert.ToInt32(dt.Rows[i]["sno"].ToString());
                TableCell cell = GridView1.Rows[e.RowIndex].Cells[0];
                qdata = cell.Text;
                dtdata = sr.ToString();
                sr1 = Convert.ToInt32(qdata);

                if (sr == sr1)
                {
                    dt.Rows[i].Delete();
                    dt.AcceptChanges();
                    //Label1.Text = "Item Has Been Deleted From Shopping Cart";
                    break;

                }
            }

            for (int i = 1; i <= dt.Rows.Count; i++)
            {
                dt.Rows[i - 1]["sno"] = i;
                dt.AcceptChanges();
            }

            Session["buyitems"] = dt;
            Response.Redirect("AddToCart.aspx");
        }

        protected void ddlQty_SelectedIndexChanged(object sender, EventArgs e)
        {
            DropDownList ddl = (DropDownList)sender;
            GridViewRow row = (GridViewRow)ddl.Parent.Parent;
            int idx = row.RowIndex;
            DataTable dt2 = (DataTable)Session["buyitems"];
            Double price = Convert.ToDouble(dt2.Rows[idx].ItemArray[8].ToString());
            int quantity = Convert.ToInt32(ddl.SelectedValue);
            Double totalprice = price * quantity;
            DataRow row2 = (DataRow)dt2.Rows[idx];
            //dt2.Rows[idx].ItemArray.SetValue(quantity.ToString(), 11);
            //dt2.Rows[idx].ItemArray.SetValue(totalprice.ToString(),12);
            row2.SetField<string>(11, quantity.ToString());
            row2.SetField<string>(12, totalprice.ToString());
            //dr["totalprice"] = totalprice;
            GridView1.DataSource = dt2;
            GridView1.DataBind();
            if (GridView1.Rows.Count > 0)
            {
                GridView1.FooterRow.Cells[10].Text = "Total Amount";
                GridView1.FooterRow.Cells[11].Text = grandtotal().ToString();

            }
            Response.Redirect("AddToCart.aspx");
        }

        protected void btnPlaceOrder_Click(object sender, EventArgs e)
        {
            DataTable d1 = (DataTable)Session["buyitems"];
            int k = 0;
            int which = 0;
            foreach (DataRow dr in d1.Rows)
            {
                if (Convert.ToInt32(dr["sqty"].ToString()) >= Convert.ToInt32(dr["order"].ToString()))
                {
                    k += 1;
                }
                else
                {
                    which = d1.Rows.IndexOf(dr) + 1;
                    Label10.Text = "Please reduce qty for item at number"+which.ToString();
                    break;
                }
            }
            if (k == d1.Rows.Count)
            {
                IWinBO.Order o1 = new IWinBO.Order();
                o1.OrderIt = (DataTable)Session["buyitems"];
                Session["buyitems"] = null;
                Session["done"] = "yes";
                Response.Redirect("AddToCart.aspx");
            }
            
        }
    }
}