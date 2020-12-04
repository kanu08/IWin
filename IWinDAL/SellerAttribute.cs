using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IWinDAL
{
    public class SellerAttribute
    {
        int Result = 0;
        dbUtil objcon = new dbUtil();
       /// <summary>
       /// This method is used to save the request any attribute change by seller
       /// </summary>
       /// <param name="obj"></param>
       /// <returns></returns>
        public int ins_SellerAttr(IWinBO.SellerAttribute obj)
        {
            int res = 0;
            try
            {
                string[,] arraySell = new string[,]
                {
                    { "@IN_SellerAttr", obj.SellerAttr } ,
                    { "@IN_SellerDesc", obj.Seller } ,
                    { "@OP", obj.OP.ToString() }
                };
                // DataTable dt = new DataTable();
                objcon.ExecuteSP("sp_Admin_SellerCR", out res, arraySell);
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
