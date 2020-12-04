using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IWinBLL
{
    public  class Advice
    {
        /// <summary>
        /// To implement logic to save advice by user
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public int insertAdvice(IWinBO.Advice obj)
        {
            IWinDAL.Advice objDAL = new IWinDAL.Advice();
            return objDAL.ins_Advice(obj);
        }
    }
}
