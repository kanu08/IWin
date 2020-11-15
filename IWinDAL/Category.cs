using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using IWinBO;

namespace IWinDAL
{
    public class Category
    {
        int Result = 0;
        dbUtil objcon = new dbUtil();
        DataSet dt = new DataSet();

        public int ins_Category(IWinBO.Category obj)
        {
            int res = 0;
            try
            {
                string[,] arraySell = new string[,]
                {
                    { "@In_CategoryName", obj.CategoryName } ,
                    { "@OP", obj.OP.ToString() }
                };
                // DataTable dt = new DataTable();
                objcon.ExecuteSP("sp_Admin_AddCategory", out res, arraySell);
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
        public DataTable search_Category(IWinBO.Category obj)
        {
            DataTable dt = new DataTable();
            DataSet ds = new DataSet();
            try
            {
                string query1 = "select * from [tbl_lookup_category] where category_Name like '%" + obj.CategoryName + "%'";
                SqlCommand cmd = new SqlCommand(query1);
                ds = objcon.GetDataSetForQuery(cmd);

            }
            catch (Exception e)
            {
                throw e;
            }
            return dt = ds.Tables["Table"];
        }
        public DataTable search_Init()
        {
            DataTable dt = new DataTable();
            DataSet ds = new DataSet();
            try
            {
                string query1 = "select * from [tbl_lookup_category]";
                SqlCommand cmd = new SqlCommand(query1);
                ds = objcon.GetDataSetForQuery(cmd);

            }
            catch (Exception e)
            {
                throw e;
            }
            return dt = ds.Tables["Table"];
        }
        public int Update_Category(IWinBO.Category obj)
        {
            int res = 0;
            try
            {
                string[,] arraySell = new string[,]
                {
                    { "@In_CategoryName", obj.CategoryName } ,
                    { "@IN_CategoryID",Convert.ToString(obj.ID) },
                    { "@OP", obj.OP.ToString() }
                };
                // DataTable dt = new DataTable();
                objcon.ExecuteSP("sp_Admin_AddCategory", out res, arraySell);
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

        public int Delete_Category(IWinBO.Category obj)
        {
            int res = 0;
            try
            {
                string[,] arraySell = new string[,]
                {
                    { "@IN_CategoryID",Convert.ToString(obj.ID) },
                    { "@OP", obj.OP.ToString() }
                };
                // DataTable dt = new DataTable();
                objcon.ExecuteSP("sp_Admin_AddCategory", out res, arraySell);
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

    }
}
