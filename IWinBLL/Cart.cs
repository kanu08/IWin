using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace IWinBLL
{
    public class Cart
    {

        public DataSet getCart(IWinBO.Cart obj)
        {
            DataSet d2 = new DataSet();
            try
            {
                IWinDAL.Cart d1 = new IWinDAL.Cart();
                d2 = d1.getCart(obj);
            }
            catch
            {

            }
            return d2;
        }
    }
}
