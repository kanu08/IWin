using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IWinBO
{
    public class SellerInventory
    {
        private string Mqu;
        private string sId;
        private string sPrice;
        private string sQty;
        private string oP;

        public string mqu { get => Mqu; set => Mqu = value; }
        public string SId { get => sId; set => sId = value; }
        public string SPrice { get => sPrice; set => sPrice = value; }
        public string SQty { get => sQty; set => sQty = value; }
        public string OP { get => oP; set => oP = value; }
    }
}
