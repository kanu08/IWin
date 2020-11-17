using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IWinBLL
{
    public class Brand
    {
        public int insertBrand(IWinBO.Brand obj)
        {
            IWinDAL.Brand objDAL = new IWinDAL.Brand();
            return objDAL.ins_Brand(obj);
        }
        public DataTable Init()
        {
            IWinDAL.Brand objDAL = new IWinDAL.Brand();
            return objDAL.search_Init();
        }
        public DataTable serach(IWinBO.Brand obj)
        {
            IWinDAL.Brand objDAL = new IWinDAL.Brand();
            return objDAL.search_Text(obj);
        }
        public int updateBrand(IWinBO.Brand obj)
        {
            IWinDAL.Brand objDAL = new IWinDAL.Brand();
            return objDAL.update_Brand(obj);
        }
        public int deleteBrand(IWinBO.Brand obj)
        {
            IWinDAL.Brand objDAL = new IWinDAL.Brand();
            return objDAL.delete_Brand(obj);
        }
    }
}
