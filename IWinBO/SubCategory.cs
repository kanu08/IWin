using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IWinBO
{
    public class SubCategory
    {
        private string subcategoryName;
        private int catValue;
        private int oP;

        public string SubcategoryName { get => subcategoryName; set => subcategoryName = value; }
        public int CatValue { get => catValue; set => catValue = value; }
        public int OP { get => oP; set => oP = value; }
    }
}
