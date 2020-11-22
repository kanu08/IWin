using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IWinBLL
{
    public class Buyer
    {
        /// <summary>
        /// This method is used to implement logic to add a buyer
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
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
        /// <summary>
        /// This method is used to implement logic to update existing buyer details
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public int updateBuyerDtl(IWinBO.Buyer obj)
        {
            try
            {
                IWinDAL.Buyer objDA = new IWinDAL.Buyer();
                return objDA.updBuyerDtl(obj);
            }
            catch (Exception ex)
            {
                //ErrHandler.WriteError(ex.ToString());
                throw ex;
            }
        }
        /// <summary>
        /// This method is used to implement logic to login a buyer
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public int loginBuyer(IWinBO.Buyer obj)
        {
            try
            {
                IWinDAL.Buyer objDA = new IWinDAL.Buyer();
                int verify= blUtil.Verifypassword(obj.Password,objDA.loginBuyer(obj));
                return verify;
            }
            catch (Exception ex)
            {
                //ErrHandler.WriteError(ex.ToString());
                throw ex;
            }

        }
        /// <summary>
        /// This method is used to return the verification status of the user
        /// </summary>
        /// <param name="em"></param>
        /// <returns></returns>
        public static DataTable getDetails(string em)
        {
            DataTable d2 = new DataTable();
            try
            {
                IWinDAL.Buyer d1 = new IWinDAL.Buyer();
                d2= d1.getDetails(em);
            }
            catch
            {

            }
            return d2;
        }
    }
}
