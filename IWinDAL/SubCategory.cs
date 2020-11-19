using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IWinBO;

namespace IWinDAL
{
    public class SubCategory
    {
        int Result = 0;
        dbUtil objcon = new dbUtil();
        DataSet dt = new DataSet();
        /// <summary>
        /// This method is used to insert a sub category in the database
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public int insSubCat(IWinBO.SubCategory obj)
        {
            int res = 0;
            try
            {
                string[,] arraySell = new string[,]
                {
                    { "@sCat", obj.SubcategoryName } ,
                    { "@catId", obj.CatValue.ToString() },
                    { "@OP", obj.OP.ToString() }
                };
                objcon.ExecuteSP("sp_lookups_insert", out res, arraySell);
                Result = res;
            }
            catch (Exception e)
            {
                //ErrHandler.WriteError(e.ToString());
                throw e;
            }
            return Result;
        }
        /// <summary>
        /// This method return all subcategories in the database
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
                    { "@OP", "3" }
                };
                objcon.ExecuteSP("sp_lookups_insert", out ds, arraySell);
            }
            catch (Exception e)
            {
                throw e;
            }
            return dt = ds.Tables[0];
        }
        /// <summary>
        /// This method is used to update subcategory details in the database
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public int updateSubCategory(IWinBO.SubCategory obj)
        {
            int res = 0;
            try
            {
                string[,] arraySell = new string[,]
                {
                    { "@sCat", obj.SubcategoryName } ,
                    { "@catId", obj.CatValue.ToString() },
                    { "@SubCatid",Convert.ToString(obj.subCatId)},
                    { "@OP", "4" }
                };
                objcon.ExecuteSP("sp_lookups_insert", out res, arraySell);
                Result = res;
            }
            catch (Exception e)
            {
                //ErrHandler.WriteError(e.ToString());
                throw e;
            }
            return Result;
        }
        /// <summary>
        /// This method is used to delete subcategory in the database
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public int deleteSubCategory(IWinBO.SubCategory obj)
        {
            int res = 0;
            try
            {
                string[,] arraySell = new string[,]
                {
                    { "@SubCatid",Convert.ToString(obj.subCatId)},
                    { "@OP", "5" }
                };
                objcon.ExecuteSP("sp_lookups_insert", out res, arraySell);
                Result = res;
            }
            catch (Exception e)
            {
                //ErrHandler.WriteError(e.ToString());
                throw e;
            }
            return Result;
        }
        /// <summary>
        /// This method is used to search a sub category in the database
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public DataTable search(IWinBO.SubCategory obj)
        {
            DataTable dt = new DataTable();
            DataSet ds = new DataSet();
            try
            {
                string[,] arraySell = new string[,]
                {
                    {"@SubCatName",obj.SubcategoryName },
                    { "@OP", "6" }
                };
                objcon.ExecuteSP("sp_lookups_insert", out ds, arraySell);
            }
            catch (Exception e)
            {
                throw e;
            }
            return dt = ds.Tables[0];
        }
    }
}

