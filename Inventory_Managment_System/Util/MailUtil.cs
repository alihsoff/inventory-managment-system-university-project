using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_Managment_System.Util
{
    class MailUtil
    {
        private static SmtpClient smtpClient = new SmtpClient();
        private static MailMessage message = new MailMessage();
        private static MailAddress address = new MailAddress("xxx@gmail.com");
        private static NetworkCredential credential = new NetworkCredential("xxx@gmail.com", "xxxx");

        static MailUtil()
        {
            smtpClient.Credentials = credential;
            smtpClient.EnableSsl = true;
            smtpClient.Port = 587;
            smtpClient.Host = "smtp.gmail.com";
        }

        public static void sendMail(String to, String subject, String content)
        {
            message.To.Add(to);
            message.From = address;
            message.Subject = subject;
            message.Body = content;

            smtpClient.Send(message);
        }
        public static void sendMail(String to, String subject, String content, Attachment attachment)
        {
            message.To.Add(to);
            message.From = address;
            message.Subject = subject;
            message.Body = content;
            message.Attachments.Add(attachment);

            smtpClient.Send(message);
        }
    }
}
