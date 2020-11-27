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
        /// <summary>
        /// This method is used to implement logic to insert a product
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public int insertProduct(IWinBO.Product obj)
        {
            IWinDAL.Product objDAL = new IWinDAL.Product();
            return objDAL.ins_Product(obj);
        }
        /// <summary>
        /// This method is used to impelemnt logic to show all products 
        /// </summary>
        /// <returns></returns>
        public DataTable Init()
        {
            IWinDAL.Product objDAL = new IWinDAL.Product();
            return objDAL.search_Init();
        }
        /// <summary>
        /// This method is used to implement logic to update product details
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public int updateProduct(IWinBO.Product obj)
        {
            IWinDAL.Product objDAL = new IWinDAL.Product();
            return objDAL.update_Product(obj);
        }
        /// <summary>
        /// This method is used to implement logic to delete a product
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public int deleteProduct(IWinBO.Product obj)
        {
            IWinDAL.Product objDAL = new IWinDAL.Product();
            return objDAL.delete_Product(obj);
        }
        /// <summary>
        /// This method is used to implement logic to search a product
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public DataTable serachProduct(IWinBO.Product obj)
        {
            IWinDAL.Product objDAL = new IWinDAL.Product();
            return objDAL.search_Product(obj);
        }
        /// <summary>
        /// This method is used to implement logic to filter products
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public DataTable filterPrice(IWinBO.Product obj)
        {
            IWinDAL.Product objDAL = new IWinDAL.Product();
            return objDAL.Filter(obj);
        }
        public DataSet GetNearExpiryProducts()
        {
            IWinDAL.Product objDAL = new IWinDAL.Product();
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
