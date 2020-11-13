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
    }
}
