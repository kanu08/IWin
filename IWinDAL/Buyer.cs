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
    public class Buyer
    {
        int Result = 0;
        dbUtil objcon = new dbUtil();
        DataSet dt = new DataSet();
        /// <summary>
        /// This method is used to insert a buyer in database
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public int insBuyer(IWinBO.Buyer obj)
        {
            int res = 0;
            try
            {
                string[,] arraySell = new string[,]
                {
                    { "@UName", obj.Name } ,
                    { "@UContact", obj.Contact },
                    { "@UEmail", obj.Email },
                    { "@UPassword", obj.Password },
                    { "@OP", obj.OP.ToString() }
                };
                objcon.ExecuteSP("sp_user_Buyer", out res, arraySell);
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
        /// This method is used to return details of buyer on login
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public List<string> loginBuyer(IWinBO.Buyer obj)
        {
            List<string> hh2 = new List<string>();
            try
            {
                string[,] arraylog = new string[,]
                {
                    { "@UEmail", obj.Email } ,
                    { "@OP", obj.OP.ToString() }
                };
                objcon.ExecuteSP("sp_user_Buyer", out hh2, arraylog);
                //string dbhash = hh2[0];
                //string dbsalt = hh2[1];
            }
            catch (Exception e)
            {
                //ErrHandler.WriteError(e.ToString());
                throw e;
            }
            return hh2;
        }
    }
}
