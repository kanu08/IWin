using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IWinBO
{
    public class Buyer
    {
        private string name;
        private string contact;
        private string email;
        private string password;
        private string city;
        private string pinCode;
        private int oP;

        public string Name { get => name; set => name = value; }
        public string Contact { get => contact; set => contact = value; }
        public string Email { get => email; set => email = value; }
        public string Password { get => password; set => password = value; }
        public int OP { get => oP; set => oP = value; }
        public string City { get => city; set => city = value; }
        public string PinCode { get => pinCode; set => pinCode = value; }
    }
}
