using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IWinDAL
{
    public class Cart
    {
        int Result = 0;
        dbUtil objcon = new dbUtil();
        DataSet dt = new DataSet();


        public DataSet getCart(IWinBO.Cart obj)
        {
            DataTable dt = new DataTable();
            DataSet ds = new DataSet();
            try
            {
                string[,] arraySell = new string[,]
                {
                    { "@pid", obj.Pid},
                    { "@sid", obj.Se },
                    {"@mquid", obj.Mqu },
                    { "@OP", "1" }
                };
                objcon.ExecuteSP("sp_user_cartView", out ds, arraySell);
            }
            catch (Exception e)
            {
                throw e;
            }
            return ds;
        }
    }
}
