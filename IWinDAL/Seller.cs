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
    public class Seller
    {
        int Result = 0;
        dbUtil objcon = new dbUtil();
        DataSet dt = new DataSet();
        /// <summary>
        /// This method is used to insert a seller in the database
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public int insSeller(IWinBO.Seller obj)
        {
            int res = 0;
            try
            {
                string[,] arraySell = new string[,]
                {
                    { "@SName", obj.SellerName } ,
                    { "@SImage", obj.SellerImage },
                    { "@SProvince", obj.SellerProvince.ToString() },
                    { "@SAddress", obj.SellerAddr },
                    { "@SContact", obj.SellerContact },
                    { "@SPincode", obj.SellerPin.ToString() },
                    { "@OP", obj.OP.ToString() }
                };
                //DataTable dt = new DataTable();

                objcon.ExecuteSP("sp_user_Seller", out res, arraySell);
                Result = res;
                //Result = Convert.ToInt32(dt.Rows[0]["status"]);
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

