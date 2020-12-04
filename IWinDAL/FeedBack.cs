using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace IWinDAL
{
   public class FeedBack
    {
        int Result = 0;
        dbUtil objcon = new dbUtil();
        DataSet dt = new DataSet();
        /// <summary>
        /// to insert feedback into the database
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public int ins_FeedBack(IWinBO.FeedBack obj)
        {
            int res = 0;
            try
            {
                string[,] arraySell = new string[,]
                {
                    { "@In_Comments", obj.Comments } ,
                     { "@IN_UserName", obj.UserName } ,
                      { "@IN_Rating",Convert.ToString(obj.Rating )} ,
                       { "@IN_FeedBackType",Convert.ToString(obj.FeedBackType )} ,
                    { "@OP", obj.OP.ToString() }
                };
                // DataTable dt = new DataTable();
                objcon.ExecuteSP("sp_User_FeedBack", out res, arraySell);
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
