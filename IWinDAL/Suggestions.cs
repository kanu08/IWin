using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IWinDAL
{
    public class Suggestions
    {
        int Result = 0;
        dbUtil objcon = new dbUtil();
        /// <summary>
        /// This method is used to save suggestion sent by admin to seller in the database
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public int ins_Suggestion(IWinBO.Suggestions obj)
        {
            int res = 0;
            try
            {
                string[,] arraySell = new string[,]
                {
                    { "@In_SuggesChioces", obj.SuggesChioces } ,
                     { "@IN_SuggesType",Convert.ToString(obj.SuggesType) } ,
                     { "@IN_SuggesComment",Convert.ToString(obj.SuggesComment) } ,
                    { "@IN_SuggesPinCode",Convert.ToString(obj.SuggesPinCode) } ,
                    {"@IN_SellerId",Convert.ToString(obj.SellerId) },                  
                     { "@OP", Convert.ToString(obj.OP) }
                };
                // DataTable dt = new DataTable();
                objcon.ExecuteSP("sp_Admin_Suggestions", out res, arraySell);
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
