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
        /// <summary>
        /// This method is used to hash password with salt
        /// </summary>
        /// <param name="password"></param>
        /// <returns></returns>
        public static string PBKDF2password(string password)
        {
            var rfc2898DeriveBytes = new Rfc2898DeriveBytes(password, 32, 10000);

            byte[] hash = rfc2898DeriveBytes.GetBytes(20);

            byte[] salt = rfc2898DeriveBytes.Salt;

            return Convert.ToBase64String(salt) + "|" + Convert.ToBase64String(hash);
        }
        /// <summary>
        /// This method is used to verify the hashed password in the database
        /// </summary>
        /// <param name="enteredPassword"></param>
        /// <param name="ls"></param>
        /// <returns></returns>
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
        /// <summary>
        /// This method is used to return role for the user 
        /// </summary>
        /// <param name="em"></param>
        /// <returns></returns>
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
        /// <summary>
        /// This method is used to return the email for the user
        /// </summary>
        /// <param name="nu"></param>
        /// <returns></returns>
        public static string getEmail(string nu)
        {
            string reEmail = null;
            try
            {
                IWinDAL.dbUtil d1 = new IWinDAL.dbUtil();
                d1.ExecuteSPem(out reEmail, nu);
            }
            catch
            {

            }
            return reEmail;
        }
        /// <summary>
        ///This method is used to return ID for the seller
        /// </summary>
        /// <param name="em"></param>
        /// <returns></returns>
        public static int getSelId(string em)
        {
            int sid = 0;
            try
            {
                IWinDAL.dbUtil d1 = new IWinDAL.dbUtil();
                d1.ExecuteSPsid(out sid, em);
            }
            catch
            {

            }
            return sid;
        }

    }
}
