using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IWinBLL
{
    public class Brand
    {
        /// <summary>
        /// This method is used to implement logic to insert brand
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public int insertBrand(IWinBO.Brand obj)
        {
            IWinDAL.Brand objDAL = new IWinDAL.Brand();
            return objDAL.ins_Brand(obj);
        }
        /// <summary>
        /// This method is used to implement logic to return all the brands
        /// </summary>
        /// <returns></returns>
        public DataTable Init()
        {
            IWinDAL.Brand objDAL = new IWinDAL.Brand();
            return objDAL.search_Init();
        }
        /// <summary>
        /// This method is used to implement logic to search a brand 
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public DataTable serach(IWinBO.Brand obj)
        {
            IWinDAL.Brand objDAL = new IWinDAL.Brand();
            return objDAL.search_Text(obj);
        }
        /// <summary>
        /// This method is used to implement logic to update a brand
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public int updateBrand(IWinBO.Brand obj)
        {
            IWinDAL.Brand objDAL = new IWinDAL.Brand();
            return objDAL.update_Brand(obj);
        }
        /// <summary>
        /// This method is used to implement logic to delete a brand
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public int deleteBrand(IWinBO.Brand obj)
        {
            IWinDAL.Brand objDAL = new IWinDAL.Brand();
            return objDAL.delete_Brand(obj);
        }
    }
}
