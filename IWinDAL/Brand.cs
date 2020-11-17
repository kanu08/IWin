using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IWinDAL
{
    public class Brand
    {
        int Result = 0;
        dbUtil objcon = new dbUtil();
        DataSet dt = new DataSet();

        public int ins_Brand(IWinBO.Brand obj)
        {
            int res = 0;
            try
            {
                string[,] arraySell = new string[,]
                {
                    { "@In_BrandName", obj.BrandName } ,
                    { "@OP", obj.OP.ToString() }
                };
                // DataTable dt = new DataTable();
                objcon.ExecuteSP("sp_Admin_Brand", out res, arraySell);
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
                objcon.ExecuteSP("sp_Admin_Brand", out ds, arraySell);
            }
            catch (Exception e)
            {
                throw e;
            }
            return dt = ds.Tables[0];
        }
        public DataTable search_Text(IWinBO.Brand obj)
        {
            DataTable dt = new DataTable();
            DataSet ds = new DataSet();
            try
            {
                string[,] arraySell = new string[,]
                {
                    {"@In_BrandName",obj.BrandName },
                    { "@OP", "5" }
                };
                objcon.ExecuteSP("sp_Admin_Brand", out ds, arraySell);
            }
            catch (Exception e)
            {
                throw e;
            }
            return dt = ds.Tables[0];
        }
        public int update_Brand(IWinBO.Brand obj)
        {
            int res = 0;
            try
            {
                string[,] arraySell = new string[,]
                {
                    { "@In_BrandName", obj.BrandName } ,
                    { "@In_BrandId",Convert.ToString(obj.BrandId) } ,
                    { "@OP", "3" }
                };
                // DataTable dt = new DataTable();
                objcon.ExecuteSP("sp_Admin_Brand", out res, arraySell);
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
        public int delete_Brand(IWinBO.Brand obj)
        {
            int res = 0;
            try
            {
                string[,] arraySell = new string[,]
                {

                    { "@In_BrandId",Convert.ToString(obj.BrandId) } ,
                    { "@OP", "4" }
                };
                // DataTable dt = new DataTable();
                objcon.ExecuteSP("sp_Admin_Brand", out res, arraySell);
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
