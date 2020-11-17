using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IWinDAL
{
    public class Product
    {
        int Result = 0;
        dbUtil objcon = new dbUtil();
        DataSet dt = new DataSet();

        public int ins_Product(IWinBO.Product obj)
        {
            int res = 0;
            try
            {
                string[,] arraySell = new string[,]
                {
                    { "@In_ProductName", obj.ProductName } ,
                     { "@IN_CategoryID",Convert.ToString(obj.CatogoryId) } ,
                     { "@IN_SubCategoryID",Convert.ToString(obj.SubCatogoryId) } ,
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
        public int update_Product(IWinBO.Product obj)
        {
            int res = 0;
            try
            {
                string[,] arraySell = new string[,]
                {
                    { "@In_ProductName", obj.ProductName } ,
                     { "@IN_CategoryID",Convert.ToString(obj.CatogoryId) } ,
                     { "@IN_SubCategoryID",Convert.ToString(obj.SubCatogoryId) } ,
                    { "@IN_Price",Convert.ToString(obj.Price) } ,
                     { "@IN_ProductId",Convert.ToString(obj.ProductId) } ,
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
        public DataTable Filter(IWinBO.Product obj)
        {
            DataTable dt = new DataTable();
            DataSet ds = new DataSet();
            try
            {
                string[,] arraySell = new string[,]{
                       {"@IN_Price",Convert.ToString(obj.Price)},
                       {"@IN_BrandName",obj.BrandName},
                    { "@OP", "6" }
                    };
                objcon.ExecuteSP("sp_Admin_Product", out ds, arraySell);

            }
            catch (Exception e)
            {
                throw e;
            }
            return dt = ds.Tables["Table"];
        }
    }
}
