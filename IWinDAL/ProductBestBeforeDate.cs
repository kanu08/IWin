using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IWinDAL
{
    public class ProductBestBeforeDate
    {
        // establishing connection with the database
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["iwinConn"].ToString());
        public DataSet GetNearExpiryProducts()
        {
            DataSet ds = new DataSet();
            try
            {
                SqlCommand cmd = new SqlCommand("GetNearExpiryProducts_SP", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                adp.Fill(ds);
                cmd.Dispose();
            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                ds.Dispose();
            }
            return ds;
        }
    }
}


