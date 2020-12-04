using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IWinDAL
{
    public class Advice
    {
        int Result = 0;
        dbUtil objcon = new dbUtil();
      /// <summary>
      /// To insert advised change into the database
      /// </summary>
      /// <param name="obj"></param>
      /// <returns></returns>
        public int ins_Advice(IWinBO.Advice obj)
        {
            int res = 0;
            try
            {
                string[,] arraySell = new string[,]
                {
                    { "@In_ProductValid",Convert.ToString(obj.ProductValid) } ,
                    { "@IN_ProductId",Convert.ToString(obj.ProductId) } ,
                    { "@IN_ProductName", obj.ProductName } ,
                    { "@IN_BrandName", obj.BrandName } ,
                      { "@IN_Details", obj.Details } ,
                    { "@OP", obj.OP.ToString() }
                };
                // DataTable dt = new DataTable();
                objcon.ExecuteSP("sp_User_Advice", out res, arraySell);
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
