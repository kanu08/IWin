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
    }
}