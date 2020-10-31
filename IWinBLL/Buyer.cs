using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IWinBLL
{
    public class Buyer
    {
        public int insertBuyer(IWinBO.Buyer obj)
        {
            try
            {
                IWinDAL.Buyer objDA = new IWinDAL.Buyer();
                return objDA.insBuyer(obj);
            }
            catch (Exception ex)
            {
                //ErrHandler.WriteError(ex.ToString());
                throw ex;
            }
        }
        public int loginBuyer(IWinBO.Buyer obj)
        {
            try
            {
                IWinDAL.Buyer objDA = new IWinDAL.Buyer();
                return objDA.loginBuyer(obj);
            }
            catch (Exception ex)
            {
                //ErrHandler.WriteError(ex.ToString());
                throw ex;
            }

        }
    }
}
