using System;
using System.Net;
using System.Net.Mail;

namespace AIM_JForce
{
    public static class AOL
    {
        // Methods
        private static string FormatUsername(string username)
        {
            if (username.Contains("@"))
                return username.Split(new char[] { '@' })[0] + "@aim.com";
            return username + "@aim.com";
        }
        public static bool Login(string username, string password)
        {
            string email = FormatUsername(username);
            MailMessage message = new MailMessage(email, email, "", "");
            SmtpClient smtp = new SmtpClient("smtp.aim.com", 587);
            NetworkCredential credential = new NetworkCredential(email, password);
            smtp.Credentials = credential;
            smtp.UseDefaultCredentials = false;

            try
            {
                smtp.Send(message);
            }
            catch (Exception ex)
            {
                return false;
            }

            return true;
        }
    }
}