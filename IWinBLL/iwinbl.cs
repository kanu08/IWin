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
        /// <summary>
        /// This method is used to implement logic to insert a category
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public int insertCategory(IWinBO.Category obj)
        {
            IWinDAL.Category objDAL = new IWinDAL.Category();
            return objDAL.ins_Category(obj);
        }
        /// <summary>
        /// This method is used to implement logic to search a category
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public DataTable Search_Category(IWinBO.Category obj)
        {
            IWinDAL.Category objDAL = new IWinDAL.Category();
            return objDAL.search_Category(obj);
        }
        /// <summary>
        /// This method is used to implement logic to show all categories 
        /// </summary>
        /// <returns></returns>
        public DataTable Search_init()
        {
            IWinDAL.Category objDAL = new IWinDAL.Category();
            return objDAL.search_Init();
        }
        /// <summary>
        /// This method is used to implement logic to update category details
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public int Update_Category(IWinBO.Category obj)
        {
            IWinDAL.Category objDAL = new IWinDAL.Category();
            return objDAL.Update_Category(obj);
        }
        /// <summary>
        /// This method is used to implement logic to delete a category
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public int delete_Category(IWinBO.Category obj)
        {
            IWinDAL.Category objDAL = new IWinDAL.Category();
            return objDAL.Delete_Category(obj);
        }
    }
}
