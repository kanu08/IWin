using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IWinBO
{
    public class Seller
    {
        private string sellerName;
        private string sellerImage;
        private string sellerAddr;
        private int sellerProvince;
        private int sellerPin;
        private string sellerContact;
        private int sellerDetailId;
        private string sellerEmail;
        private string password;
        private bool active;
        private int oP;

        public string SellerName { get => sellerName; set => sellerName = value; }
        public string SellerImage { get => sellerImage; set => sellerImage = value; }
        public string SellerContact { get => sellerContact; set => sellerContact = value; }
        public string SellerAddr { get => sellerAddr; set => sellerAddr = value; }
        public int SellerProvince { get => sellerProvince; set => sellerProvince = value; }
        public int SellerPin { get => sellerPin; set => sellerPin = value; }
        public int OP { get => oP; set => oP = value; }
        public int SellerDetailId { get => sellerDetailId; set => sellerDetailId = value; }
        public string SellerEmail { get => sellerEmail; set => sellerEmail = value; }
        public string Password { get => password; set => password = value; }
        public bool Active { get => active; set => active = value; }
    }
}
