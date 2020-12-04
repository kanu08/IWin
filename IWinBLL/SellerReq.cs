using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IWinBLL
{
    public class SellerReq
    {
        /// <summary>
        /// This method is used to implement logic to insert the request to become a seller
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public int insertSellerReq(IWinBO.SellerRequest obj)
        {
            IWinDAL.SelleReq objDAL = new IWinDAL.SelleReq();
            return objDAL.ins_SellerReq(obj);
        }
    }
}
