using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IWinBLL
{
    public class Suggestions
    {
        /// <summary>
        /// This logic is used to implement logic to insert suggestion 
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public int insertSuggestion(IWinBO.Suggestions obj)
        {
            IWinDAL.Suggestions objDAL = new IWinDAL.Suggestions();
            return objDAL.ins_Suggestion(obj);
        }
    }
}
