using System;
using System.Data;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Messaging;

using System.Web.UI;
using System.Web.UI.WebControls;


namespace IWinDAL
{
   /// <summary>
   /// The following class contains all the utility methods that are required in 
   /// the DAL project to insert, select or update data
   ///</summary>
    public class dbUtil
    {

        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["iwinConn"].ToString());
        int result;
        ///<summary>
        ///method to return a dataset from db with command param
        ///</summary>
        /// <param name="command"></param>
        /// <returns>DataSet</returns>
        public DataSet GetDataSetForSP(SqlCommand command)
        {
            DataSet ds = new DataSet();
            SqlDataAdapter da;
            try
            {
                con.Open();
                command.CommandType = CommandType.StoredProcedure;
                command.Connection = con;
                da = new SqlDataAdapter(command);
                da.Fill(ds, "Table");
                con.Close();
                return ds;
            }
            catch (Exception ex)
            {
                MsgBox("Unable to connect to Database");
                //ErrHandler.WriteError(ex.ToString());
                return ds;
            }
        }
        ///<summary>
        ///method to execute a stored procedure with single int param
        ///</summary>
        /// <param name="StoredProcedureName"></param><param name="val"></param>
        /// <returns></returns>
        public void ExecuteSPint(string StoredProcedureName, out DataTable dtemp, [Optional] int val)
        {
            string constr = ConfigurationManager.ConnectionStrings["iwinConn"].ConnectionString;
            using (SqlConnection con = new SqlConnection(constr))
            {
                using (SqlCommand command = new SqlCommand())
                {
                    con.Open();
                    command.CommandType = CommandType.StoredProcedure;
                    SqlDataAdapter adp = new SqlDataAdapter();
                    DataTable dt = new DataTable();
                    command.CommandText = StoredProcedureName;
                    command.CommandTimeout = 300;
                    try
                    {
                        command.Parameters.AddWithValue("@thing", val);
                    }
                    catch (Exception ex)
                    {
                        //ErrHandler.WriteError(ex.ToString());
                        throw ex;
                    }
                    command.Connection = con;
                    adp.SelectCommand = command;
                    adp.Fill(dt);
                    con.Close();
                    dtemp = dt;
                }
            }
        }
        /// <summary>
        /// method to return dataset on executing dataset
        /// </summary>
        /// <param name="command"></param>
        /// <returns></returns>
        public DataSet GetDataSetForQuery(SqlCommand command)
        {
            DataSet ds = new DataSet();
            SqlDataAdapter da;
            try
            {
                con.Open();
                command.Connection = con;
                da = new SqlDataAdapter(command);
                da.Fill(ds, "Table");
                con.Close();
                return ds;
            }
            catch (Exception ex)
            {
                MsgBox("Unable to connect to Database");
                //ErrHandler.WriteError(ex.ToString());
                return ds;
            }
        }
        /// <summary>
        /// execute query with db connection from config
        /// </summary>
        /// <param name="query"></param>
        /// <returns></returns>
        public int ExecuteQuery(String query)
        {
            DataSet ds = new DataSet();
            try
            {
                result = -1;
                if (query.Length > 0)
                {
                    SqlCommand command = new SqlCommand(query);
                    command.CommandType = CommandType.Text;
                    con.Open();
                    command.Connection = con;
                    result = command.ExecuteNonQuery();
                    con.Close();
                }
                return result;
            }
            catch (Exception ex)
            {
                MsgBox("Unable to connect to Database");
                //ErrHandler.WriteError(ex.ToString());
                return result;
            }
        }
        /// <summary>
        /// execute stored procedure to return dataset in return to string parameters in array
        /// </summary>
        /// <param name="StoredProcedureName"></param>
        /// <param name="dtemp"></param>
        /// <param name="aryParameters"></param>
        public void ExecuteSP(string StoredProcedureName, out DataSet dtemp, [Optional] string[,] aryParameters)
        {
            string constr = ConfigurationManager.ConnectionStrings["iwinConn"].ConnectionString;
            using (con = new SqlConnection(constr))
            {
                using (SqlCommand command = new SqlCommand())
                {
                    con.Open();
                    command.CommandType = CommandType.StoredProcedure;
                    SqlDataAdapter adp = new SqlDataAdapter();
                    DataSet dt = new DataSet();
                    command.CommandText = StoredProcedureName;
                    command.CommandTimeout = 300;
                    try
                    {
                        for (int i = 0; i < aryParameters.GetLength(0); i++)
                        {

                            command.Parameters.AddWithValue(aryParameters[i, 0], aryParameters[i, 1]);
                        }
                    }
                    catch (Exception ex)
                    {
                        //ErrHandler.WriteError(ex.ToString());
                        throw ex;
                    }
                    command.Connection = con;
                    adp.SelectCommand = command;
                    adp.Fill(dt);
                    con.Close();
                    dtemp = dt;
                    //string hh;
                    int a = 0;
                    //string an = dtemp.Tables[0].Rows[0].ToString();
                    foreach (DataRow pRow in dtemp.Tables[0].Rows)
                    {
                        a++;
                    }
                }
            }
        }
        /// <summary>
        /// execute stored procedure to return int value in return to string params in array
        /// </summary>
        /// <param name="StoredProcedureName"></param>
        /// <param name="res"></param>
        /// <param name="aryParameters"></param>
        public void ExecuteSP(string StoredProcedureName, [Optional] out int res, [Optional] string[,] aryParameters)
        {
            string constr = ConfigurationManager.ConnectionStrings["iwinConn"].ConnectionString;
            using (SqlConnection con = new SqlConnection(constr))
            {
                using (SqlCommand command = new SqlCommand())
                {
                    con.Open();
                    command.CommandType = CommandType.StoredProcedure;
                    int result = 0;
                    command.CommandText = StoredProcedureName;
                    command.CommandTimeout = 300;
                    try
                    {
                        for (int i = 0; i < aryParameters.GetLength(0); i++)
                        {

                            command.Parameters.Add(new SqlParameter(aryParameters[i, 0], aryParameters[i, 1]));
                        }
                    }
                    catch (Exception ex)
                    {
                        //ErrHandler.WriteError(ex.ToString());
                        throw ex;
                    }
                    command.Connection = con;
                    SqlDataReader reader = command.ExecuteReader();
                    reader.Read();
                    result = Convert.ToInt32(reader["status"]);
                    con.Close();
                    res = result;
                }
            }
        }
        /// <summary>
        /// execute stored procedure to return role id in return of email string
        /// </summary>
        /// <param name="role"></param>
        /// <param name="em"></param>
        public void ExecuteSProle([Optional] out int role, [Optional] string em)
        {
            string constr = ConfigurationManager.ConnectionStrings["iwinConn"].ConnectionString;
            using (SqlConnection con = new SqlConnection(constr))
            {
                using (SqlCommand command = new SqlCommand())
                {
                    con.Open();
                    command.CommandType = CommandType.StoredProcedure;
                    int result = 0;
                    command.CommandText = "sp_user_Buyer";
                    command.CommandTimeout = 300;
                    try
                    {
                        command.Parameters.Add(new SqlParameter("@UEmail", em));
                        command.Parameters.Add(new SqlParameter("@OP", 3));
                    }
                    catch (Exception ex)
                    {
                        //ErrHandler.WriteError(ex.ToString());
                        throw ex;
                    }
                    command.Connection = con;
                    SqlDataReader reader = command.ExecuteReader();
                    reader.Read();
                    result = Convert.ToInt32(reader["RoleId"]);
                    con.Close();
                    role = result;
                }
            }
        }
        /// <summary>
        /// execute stored procedure to return email in return to contact 
        /// </summary>
        /// <param name="reEmail"></param>
        /// <param name="nu"></param>
        public void ExecuteSPem([Optional] out string reEmail, [Optional] string nu)
        {
            string constr = ConfigurationManager.ConnectionStrings["iwinConn"].ConnectionString;
            using (SqlConnection con = new SqlConnection(constr))
            {
                using (SqlCommand command = new SqlCommand())
                {
                    con.Open();
                    command.CommandType = CommandType.StoredProcedure;
                    string result = null;
                    command.CommandText = "sp_user_Buyer";
                    command.CommandTimeout = 300;
                    try
                    {
                        command.Parameters.Add(new SqlParameter("@UContact", nu));
                        command.Parameters.Add(new SqlParameter("@OP", 4));
                    }
                    catch (Exception ex)
                    {
                        //ErrHandler.WriteError(ex.ToString());
                        throw ex;
                    }
                    command.Connection = con;
                    SqlDataReader reader = command.ExecuteReader();
                    reader.Read();
                    result = reader["Email"].ToString();
                    con.Close();
                    reEmail = result;
                }
            }
        }
        /// <summary>
        /// execute stored procedure to return a list of params in return to strings in array
        /// </summary>
        /// <param name="StoredProcedureName"></param>
        /// <param name="ds"></param>
        /// <param name="aryParameters"></param>
        public void ExecuteSP(string StoredProcedureName, out List<string> ds, [Optional] string[,] aryParameters)
        {
            string constr = ConfigurationManager.ConnectionStrings["iwinConn"].ConnectionString;
            using (con = new SqlConnection(constr))
            {
                using (SqlCommand command = new SqlCommand())
                {
                    con.Open();
                    command.CommandType = CommandType.StoredProcedure;
                    List<string> hh = new List<string>();
                    //SqlDataAdapter adp = new SqlDataAdapter();
                    DataTable dtemp = new DataTable();
                    command.CommandText = StoredProcedureName;
                    command.CommandTimeout = 300;
                    try
                    {
                        for (int i = 0; i < aryParameters.GetLength(0); i++)
                        {
                            command.Parameters.Add(new SqlParameter(aryParameters[i, 0], aryParameters[i, 1]));
                        }
                    }
                    catch (Exception ex)
                    {
                        //ErrHandler.WriteError(ex.ToString());
                        throw ex;
                    }
                    command.Connection = con;
                    SqlDataReader reader = command.ExecuteReader();
                    
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            
                                hh.Add(reader.GetString(0));
                                hh.Add(reader.GetString(1));
                            
                        }
                    }
                    
                    ds = hh;
                    reader.Close();
                    con.Close();
                }
            }
        }
        /// <summary>
        /// This is to display error message in above util methods
        /// </summary>
        /// <param name="sMessage"></param>
        public void MsgBox(String sMessage)
        {
            string msg = "<script language=\"javascript\">";
            msg += "alert('" + sMessage + "');";
            msg += "</script>";
            System.Web.HttpContext.Current.Response.Write(msg);
        }
        /// <summary>
        /// This is to bind dropdown with their respective lookup table
        /// </summary>
        /// <param name="ctb"></param>
        public void Bindddl(DropDownList ctb)
        {
            DataTable dt1 = new DataTable();
            string ctname = ctb.ID.ToString();
            int ps = getctbtype(ctname);
            ExecuteSPint("sp_lookups", out dt1, ps);
            ctb.DataSource = dt1;
            ctb.DataTextField = dt1.Columns[1].ToString();
            ctb.DataValueField = dt1.Columns[0].ToString();
            string ctname2 = ctname.Substring(3);
            ctb.DataBind();
            ctb.Items.Insert(0, new ListItem("Choose a " + ctname2, "0"));
        }
        /// <summary>
        /// This is to bind multiple dropdown controls in a webpage through single transaction
        /// </summary>
        /// <param name="ctblist"></param>
        public void Bindddl(List<DropDownList> ctblist)
        {
            foreach (DropDownList ctb in ctblist)
            {
                Bindddl(ctb);          //possible improvements to make an overloading method returning a dataset and passing parameters not just 
                                       //as a single int but as 12 or 124 and later using each int to return Dataset in a single transaction
            }

        }
        /// <summary>
        /// This is to get type for particlar dropdown
        /// </summary>
        /// <param name="ctl"></param>
        /// <returns></returns>
        public int getctbtype(string ctl)
        {
            int n = 0;
            switch (ctl)
            {
                case "ddlCategory":
                    n = 1;
                    break;
                case "ddlCountry":
                    n = 2;
                    break;
                case "ddlPin":
                    n = 3;
                    break;
                case "ddlSubCategory":
                    n = 4;
                    break;
                case "ddlBrand":
                    n = 5;
                    break;
                default:
                    n = 0;
                    break;
            }
            return n;
        }
    }
}
