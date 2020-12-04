using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IWinBLL
{
    public class FeedBack
    {
        /// <summary>
        /// This method is used to implement logic to save the feedback by user
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public int insertFeedBack(IWinBO.FeedBack obj)
        {
            IWinDAL.FeedBack objDAL = new IWinDAL.FeedBack();
            return objDAL.ins_FeedBack(obj);
        }
    }
}
