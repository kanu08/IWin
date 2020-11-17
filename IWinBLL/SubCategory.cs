using System;
using System.Collections.Generic;
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

    }
}
