using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IWinBO
{
    class MQU
    {
        private int mquId;
        private int prodId;
        private double price;
        private int qty;
        private int uomId;

        public int MquId { get => mquId; set => mquId = value; }
        public int ProdId { get => prodId; set => prodId = value; }
        public double Price { get => price; set => price = value; }
        public int Qty { get => qty; set => qty = value; }
        public int UomId { get => uomId; set => uomId = value; }
    }
}
