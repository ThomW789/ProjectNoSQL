using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;

namespace LoginRegister
{
    public class Register
    {
        public void SendMail(string email, string password, string name)
        {
            SmtpClient smtpServer = new SmtpClient("smtp.gmail.com");
            smtpServer.Port = 587;
            smtpServer.UseDefaultCredentials = false;
            smtpServer.Credentials = new System.Net.NetworkCredential("nodeskthegardengroup@gmail.com", "5WBm0q6R0&m%");
            smtpServer.EnableSsl = true;

            MailMessage mail = new MailMessage();
            mail.From = new MailAddress("nodeskthegardengroup@gmail.com");
            try
            {
                mail.To.Add(email);
            }
            catch
            {
                mail.To.Add("nodeskthegardengroup@gmail.com");
            }
            mail.Subject = "Here is your password";
            mail.Body = $"Dear {name},\n\nYour password is: {password}";

            smtpServer.Send(mail);
        }

        public string GeneratePassword()
        {
            const string characters = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
            StringBuilder password = new StringBuilder();
            Random random = new Random();
            int lenght = 12;
            while (0 < lenght--)
            {
                password.Append(characters[random.Next(characters.Length)]);
            }
            return password.ToString();
        }
    }
}
