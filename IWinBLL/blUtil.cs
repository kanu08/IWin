using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;


namespace IWinBLL
{
    public class blUtil
    {
        public static string PBKDF2password(string password)
        {
            var rfc2898DeriveBytes = new Rfc2898DeriveBytes(password, 32, 10000);

            byte[] hash = rfc2898DeriveBytes.GetBytes(20);

            byte[] salt = rfc2898DeriveBytes.Salt;

            return Convert.ToBase64String(salt) + "|" + Convert.ToBase64String(hash);
        }

        public static int Verifypassword(string enteredPassword, List<string> ls)
        {
            if (!ls.Any())
            {
                return 3;
            }
            else
            {
                string dbHash = ls[0];
                string dbSalt = ls[1];
                var saltBytes = Convert.FromBase64String(dbSalt);
                var rfc2898DeriveBytes = new Rfc2898DeriveBytes(enteredPassword, saltBytes, 10000);
                if (Convert.ToBase64String(rfc2898DeriveBytes.GetBytes(20)) == dbHash)
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
            }
        }

        public static int getRole(string em)
        {
            int role=0;
            try
            {
                IWinDAL.dbUtil d1 = new IWinDAL.dbUtil();
                d1.ExecuteSProle(out role, em);
            }
            catch
            {

            }
            return role;
        }
    }
}
