using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IWinBO
{
    public class Product
    {

        public string ProductName { get; set; }
        public int CatogoryId { get; set; }
        public int SubCategoryId { get; set; }
        public double Price { get; set; }
        public int ProductId { get; set; }
        public string ProductImage { get; set; }
        public int Brandid { get; set; }
        public string BrandName { get; set; }
        public DateTime ProductExpiryDate { get; set; }
        public int OP { get; set; }

        public List<int> BrandList { get; set; }
    }
}
