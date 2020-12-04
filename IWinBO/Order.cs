using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IWinBO
{
    public class Order
    {
        private DataTable orderIt;

        public DataTable OrderIt { get => orderIt; set => orderIt = value; }
    }
}
