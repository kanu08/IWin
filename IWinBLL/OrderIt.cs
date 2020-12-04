using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IWinBLL
{
    public class OrderIt
    {
        public int insertBrand(IWinBO.Brand obj)
        {
            IWinDAL.Brand objDAL = new IWinDAL.Brand();
            return objDAL.ins_Brand(obj);
        }
    }
}
