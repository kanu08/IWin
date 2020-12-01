using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IWinBO
{
    public class FeedBack
    {
        public int FeedbackId { get; set; }
        public int FeedBackType { get; set; }
        public int Rating { get; set; }
        public string Comments { get; set; }
        public string UserName { get; set; }
        public int OP { get; set; }

    }
}
