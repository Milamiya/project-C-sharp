using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Mail;
using System.Net;

namespace Chess_Programming
{
    public static class clsSendMail
    {
        public static bool SendMail(string Title, string Content, string StarValue)
        {
            
            MailMessage Mail = new MailMessage();
            Mail.From = new MailAddress("chessprogrammingcdth07a@yahoo.com");
            Mail.ReplyTo = Mail.From;
            Mail.To.Add(new MailAddress("fantasyboy1988@gmail.com"));
            Mail.Subject = Title;
            Mail.IsBodyHtml = false;
            Mail.BodyEncoding = Encoding.UTF8;
            Content += "\nRating: " + StarValue + " sao\n";
            Mail.Body = Content;
            

            

            SmtpClient sClient = new SmtpClient();
            sClient.Host = "smtp.mail.yahoo.com";
            sClient.Port = 25;
            sClient.Credentials = new NetworkCredential("chessprogrammingcdth07a", "123456");
            try
            {
                sClient.Send(Mail);
                return true;
            }
            catch
            {
                return false;
            }

        }
    }
}
