using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace IWinBLL
{
    public class Product
    {
        public int insertProduct(IWinBO.Product obj)
        {
            IWinDAL.Product objDAL = new IWinDAL.Product();
            return objDAL.ins_Product(obj);
        }
        public DataTable Init()
        {
            IWinDAL.Product objDAL = new IWinDAL.Product();
            return objDAL.search_Init();
        }
        public int updateProduct(IWinBO.Product obj)
        {
            IWinDAL.Product objDAL = new IWinDAL.Product();
            return objDAL.update_Product(obj);
        }
        public int deleteProduct(IWinBO.Product obj)
        {
            IWinDAL.Product objDAL = new IWinDAL.Product();
            return objDAL.delete_Product(obj);
        }
        public DataTable serachProduct(IWinBO.Product obj)
        {
            IWinDAL.Product objDAL = new IWinDAL.Product();
            return objDAL.search_Product(obj);
        }
        public DataTable filterPrice(IWinBO.Product obj)
        {
            IWinDAL.Product objDAL = new IWinDAL.Product();
            return objDAL.Filter(obj);
        }
        public DataSet GetNearExpiryProducts()
        {
            IWinDAL.ProductBestBeforeDate objDAL = new IWinDAL.ProductBestBeforeDate();
            try
            {
                return objDAL.GetNearExpiryProducts();
            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                objDAL = null;
            }
        }

    }
}
