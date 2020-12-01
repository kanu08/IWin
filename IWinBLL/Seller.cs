using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using IWinBO;
using IWinDAL;

namespace IWinBLL
{
    public class Seller
    {
        /// <summary>
        /// This method is used to implement logic to insert a seller
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public int insertSeller(IWinBO.Seller obj)
        {
            try
            {
                IWinDAL.Seller objDA = new IWinDAL.Seller();
                return objDA.insSeller(obj);
            }
            catch (Exception ex)
            {
                //ErrHandler.WriteError(ex.ToString());
                throw ex;
            }
        }
    
        public int FindDtlId(int detailId)
        {
            try
            {
                IWinDAL.Seller objDA = new IWinDAL.Seller();
                return objDA.FindDtlId(detailId);
            }
            catch (Exception ex)
            {
                //ErrHandler.WriteError(ex.ToString());
                throw ex;
            }
        }

        public int regSeller(IWinBO.Seller obj)
        {
            try
            {
                IWinDAL.Seller objDA = new IWinDAL.Seller();
                return objDA.regSeller(obj);
            }
            catch (Exception ex)
            {
                //ErrHandler.WriteError(ex.ToString());
                throw ex;
            }
        }


    }
}