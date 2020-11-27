using System;
using System.Data;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Messaging;

using System.Web.UI;
using System.Web.UI.WebControls;

namespace IWinDAL
{
    public class Product
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["iwinConn"].ToString());
        int Result = 0;
        dbUtil objcon = new dbUtil();
        DataSet dt = new DataSet();
        /// <summary>
        /// this is to insert product BO in the database
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public int ins_Product(IWinBO.Product obj)
        {
            int res = 0;
            try
            {
                string[,] arraySell = new string[,]
                {
                    { "@In_ProductName", obj.ProductName } ,
                     //{ "@IN_CategoryID",Convert.ToString(obj.CatogoryId) } ,
                     { "@IN_SubCategoryID",Convert.ToString(obj.SubCategoryId) } ,
                    { "@IN_Price",Convert.ToString(obj.Price) } ,
                    {"@IN_Image",obj.ProductImage },
                    {"@IN_BrandId",Convert.ToString(obj.Brandid) },
                     { "@OP", Convert.ToString(obj.OP) }
                };
                // DataTable dt = new DataTable();
                objcon.ExecuteSP("sp_Admin_Product", out res, arraySell);
                Result = res;
                // Result = Convert.ToInt32(dt.Rows[0]["status"]);
            }
            catch (Exception e)
            {
                //ErrHandler.WriteError(e.ToString());
                throw e;
            }
            return Result;
        }
        /// <summary>
        /// This is to fetch all the products from the database on initial load
        /// </summary>
        /// <returns></returns>
        public DataTable search_Init()
        {
            DataTable dt = new DataTable();
            DataSet ds = new DataSet();
            try
            {
                string[,] arraySell = new string[,]
                {
                    { "@OP", "2" }
                };
                objcon.ExecuteSP("sp_Admin_Product", out ds, arraySell);

            }
            catch (Exception e)
            {
                throw e;
            }
            return dt = ds.Tables[0];
        }
        /// <summary>
        /// This method is used to update product details
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public int update_Product(IWinBO.Product obj)
        {
            int res = 0;
            try
            {
                string[,] arraySell = new string[,]
                {
                    { "@In_ProductName", obj.ProductName } ,
                     { "@IN_CategoryID",Convert.ToString(obj.CatogoryId) } ,
                     { "@IN_SubCategoryID",Convert.ToString(obj.SubCategoryId) } ,
                    { "@IN_Price",Convert.ToString(obj.Price) } ,
                     { "@IN_ProductId",Convert.ToString(obj.ProductId) } ,
                     {"@IN_BrandId" , Convert.ToString(obj.Brandid) },
                     { "@OP", "3" }
                };
                // DataTable dt = new DataTable();
                objcon.ExecuteSP("sp_Admin_Product", out res, arraySell);
                Result = res;
                // Result = Convert.ToInt32(dt.Rows[0]["status"]);
            }
            catch (Exception e)
            {
                //ErrHandler.WriteError(e.ToString());
                throw e;
            }
            return Result;
        }
        /// <summary>
        /// This method is used to delete the product from database
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public int delete_Product(IWinBO.Product obj)
        {
            int res = 0;
            try
            {
                string[,] arraySell = new string[,]
                {
                      { "@IN_ProductId",Convert.ToString(obj.ProductId) } ,
                     { "@OP",Convert.ToString(obj.OP) }
                };
                // DataTable dt = new DataTable();
                objcon.ExecuteSP("sp_Admin_Product", out res, arraySell);
                Result = res;
                // Result = Convert.ToInt32(dt.Rows[0]["status"]);
            }
            catch (Exception e)
            {
                //ErrHandler.WriteError(e.ToString());
                throw e;
            }
            return Result;
        }
        /// <summary>
        /// This method is used to search a product in the database
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public DataTable search_Product(IWinBO.Product obj)
        {
            DataTable dt = new DataTable();
            DataSet ds = new DataSet();
            try
            {
                string[,] arraySell = new string[,]{
                       {"@In_ProductName",obj.ProductName},
                    { "@OP", "5" }
                    };
                objcon.ExecuteSP("sp_Admin_Product", out ds, arraySell);

            }
            catch (Exception e)
            {
                throw e;
            }
            return dt = ds.Tables["Table"];
        }
        /// <summary>
        /// This method is used to filter the products based on their attributes
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public DataTable Filter(IWinBO.Product obj)
        {
            
            DataTable dt = new DataTable();
            DataSet ds = new DataSet();
            string constr = ConfigurationManager.ConnectionStrings["iwinConn"].ConnectionString;
            using (con = new SqlConnection(constr))
            {
                using (SqlCommand command = new SqlCommand())
                {
                    con.Open();
                    command.CommandType = CommandType.StoredProcedure;
                    SqlDataAdapter adp = new SqlDataAdapter();
                    command.CommandText = "sp_admin_filters";
                    command.CommandTimeout = 300;
                    try
                    {
                        var bList = new SqlParameter("@brandList", SqlDbType.Structured);
                        bList.TypeName = "dbo.BrandList";
                        DataTable dt2 = new DataTable();
                        dt2= dbUtil.ConvertData<int>(obj.BrandList);
                        bList.Value = dt2;
                        command.Parameters.Add(bList);
                        command.Parameters.AddWithValue("@OP","1");
                        command.Parameters.AddWithValue("@price", obj.Price.ToString());


                    }
                    catch (Exception e)
                    {
                        throw e;
                    }
                    command.Connection = con;
                    adp.SelectCommand = command;
                    adp.Fill(ds);
                    con.Close();
                    return dt = ds.Tables["Table"];
                }
            }
        }

        public DataSet GetNearExpiryProducts()
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["iwinConn"].ToString());
            DataSet ds = new DataSet();
            try
            {
                SqlCommand cmd = new SqlCommand("sp_GetNearExpiryProducts", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                adp.Fill(ds);
                cmd.Dispose();
            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                ds.Dispose();
            }
            return ds;
        }
    }
}
