using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;
using System.Threading.Tasks;

namespace IWin
{
    public class iwinBO
    {
        private string sellerName;
        private string sellerImage;
        private string sellerLocation;
        private string sellerContact;

        public string SellerName { get => sellerName; set => sellerName = value; }
        public string SellerImage { get => sellerImage; set => sellerImage = value; }
        public string SellerLocation { get => sellerLocation; set => sellerLocation = value; }
        public string SellerContact { get => sellerContact; set => sellerContact = value; }
    }
}