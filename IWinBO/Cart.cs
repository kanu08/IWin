using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IWinBO
{
    public class Cart
    {
        private string mqu;
        private string se;
        private string pid;
        private string qty;

        public string Mqu { get => mqu; set => mqu = value; }
        public string Se { get => se; set => se = value; }
        public string Pid { get => pid; set => pid = value; }
        public string Qty { get => qty; set => qty = value; }
    }
}
