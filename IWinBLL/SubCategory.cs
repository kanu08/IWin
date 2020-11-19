using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IWinBLL
{
    public class SubCategory
    {
        /// <summary>
        /// This method is used to implement logic to insert a subcategory
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public int insertSubCategory(IWinBO.SubCategory obj)
        {
            try
            {
                IWinDAL.SubCategory objDA = new IWinDAL.SubCategory();
                return objDA.insSubCat(obj);
            }
            catch (Exception ex)
            {
                //ErrHandler.WriteError(ex.ToString());
                throw ex;
            }
        }
        /// <summary>
        /// This method is used to implement logic to show all subcategories
        /// </summary>
        /// <returns></returns>
        public DataTable Init()
        {
            IWinDAL.SubCategory objDA = new IWinDAL.SubCategory();
            return objDA.search_Init();
        }
        /// <summary>
        /// This method is used to implement logic to update a subcategory
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public int UpdateSubCategory(IWinBO.SubCategory obj)
        {
            try
            {
                IWinDAL.SubCategory objDA = new IWinDAL.SubCategory();
                return objDA.updateSubCategory(obj);
            }
            catch (Exception ex)
            {
                //ErrHandler.WriteError(ex.ToString());
                throw ex;
            }
        }
        /// <summary>
        /// This method is used to implement logic to delete a subcategory
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public int deleteSubCategory(IWinBO.SubCategory obj)
        {
            try
            {
                IWinDAL.SubCategory objDA = new IWinDAL.SubCategory();
                return objDA.deleteSubCategory(obj);
            }
            catch (Exception ex)
            {
                //ErrHandler.WriteError(ex.ToString());
                throw ex;
            }
        }
        /// <summary>
        /// This method is used to implement logic to search a sub category
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public DataTable searching(IWinBO.SubCategory obj)
        {
            IWinDAL.SubCategory objDA = new IWinDAL.SubCategory();
            return objDA.search(obj);
        }

    }
}
