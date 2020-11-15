using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;


namespace IWinBLL
{
    public class iwinbl
    {
        public int insertCategory(IWinBO.Category obj)
        {
            IWinDAL.Category objDAL = new IWinDAL.Category();
            return objDAL.ins_Category(obj);
        }
        public DataTable Search_Category(IWinBO.Category obj)
        {
            IWinDAL.Category objDAL = new IWinDAL.Category();
            return objDAL.search_Category(obj);
        }
        public DataTable Search_init()
        {
            IWinDAL.Category objDAL = new IWinDAL.Category();
            return objDAL.search_Init();
        }
        public int Update_Category(IWinBO.Category obj)
        {
            IWinDAL.Category objDAL = new IWinDAL.Category();
            return objDAL.Update_Category(obj);
        }
        public int delete_Category(IWinBO.Category obj)
        {
            IWinDAL.Category objDAL = new IWinDAL.Category();
            return objDAL.Delete_Category(obj);
        }
    }
}
