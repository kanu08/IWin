using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IWinDAL
{
    public class SelleReq
    {
        int Result = 0;
        dbUtil objcon = new dbUtil();
       /// <summary>
       /// This method is used to save request by buyers to become sellers
       /// </summary>
       /// <param name="obj"></param>
       /// <returns></returns>
        public int ins_SellerReq(IWinBO.SellerRequest obj)
        {
            int res = 0;
            try
            {
                string[,] arraySell = new string[,]
                {
                    { "@IN_SellerContact", obj.SellerContact } ,
                    { "@OP", Convert.ToString(obj.OP) }
                };
                // DataTable dt = new DataTable();
                objcon.ExecuteSP("sp_User_SellerReq", out res, arraySell);
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
