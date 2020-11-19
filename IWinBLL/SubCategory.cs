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
        public DataTable Init()
        {
            IWinDAL.SubCategory objDA = new IWinDAL.SubCategory();
            return objDA.search_Init();
        }
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
        public DataTable searching(IWinBO.SubCategory obj)
        {
            IWinDAL.SubCategory objDA = new IWinDAL.SubCategory();
            return objDA.search(obj);
        }

    }
}
