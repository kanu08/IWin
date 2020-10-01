using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IWin
{
    public class iwinBll
    {
        public int insertSeller(iwinBO obj)
        {
            try
            {

                iwinDal objDA = new iwinDal();
                return objDA.ins_Seller(obj);
            }
            catch (Exception ex)
            {
                ErrHandler.WriteError(ex.ToString());
                throw ex;
            }
        }
    }
}