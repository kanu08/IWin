using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IWinBLL
{
    public class FeedBack
    {
        public int insertFeedBack(IWinBO.FeedBack obj)
        {
            IWinDAL.FeedBack objDAL = new IWinDAL.FeedBack();
            return objDAL.ins_FeedBack(obj);
        }
    }
}
