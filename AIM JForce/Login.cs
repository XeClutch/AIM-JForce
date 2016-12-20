using System.Net;
using System.Security.Cryptography;
using System.Text;

namespace AIM_JForce
{
    public static class Login
    {
        // Methods
        public static bool Authenticate(string username, string password)
        {
            MD5CryptoServiceProvider service = new MD5CryptoServiceProvider();
            byte[] passbyte = Encoding.ASCII.GetBytes(password);
            byte[] hash = service.ComputeHash(service.ComputeHash(service.ComputeHash(passbyte)));
            string buffer = HashToString(hash);
            
            return new WebClient().DownloadString("http://pastebin.com/raw/p6gjgFQg").Contains(username.ToLower() + "<|>" + buffer);
        }
        private static string HashToString(byte[] hash)
        {
            string str = "";
            foreach (byte block in hash)
                str += block.ToString("X2");
            return str;
        }
    }
}