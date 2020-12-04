using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IWinBLL
{
    public class SellerAttribute
    {
        /// <summary>
        /// This method is used to implement logic to insert seller attributes
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public int insertSellerAttr(IWinBO.SellerAttribute obj)
        {
            IWinDAL.SellerAttribute objDAL = new IWinDAL.SellerAttribute();
            return objDAL.ins_SellerAttr(obj);
        }
    }
}
