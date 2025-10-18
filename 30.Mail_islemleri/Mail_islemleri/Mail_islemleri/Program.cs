using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Mail_islemleri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EmailGonder("cobantalha19@gmail.com", "udemy.C#", "merhaba eğer bu maili almışsan sana bu maili sen gönderdin. \nKodun çalışıyor aferim");
        }

        static void EmailGonder(string kime, string Konu, string Icerik)
        {
            string mail_adress = "cobantalha19@hotmail.com";
            Encoding encoding = Encoding.GetEncoding("windows-1254");
            MailAddress From = new MailAddress(mail_adress, "udemy.C#", encoding);
            MailAddress To = new MailAddress(kime);
            MailMessage Email = new MailMessage();
            // Email.To.Add(kime);
            Email.To.Add(To);
            Email.From = From;
            // Email.Bcc.Add(""); // iletilen mesajda ana kişi cc tarafında olan kişileri göremez
            // Email.CC.Add(""); // iletilen mesajda ana kişi cc tarafında olan kişileri görebilir
            Email.Subject = Konu;
            Email.Body = Icerik;
            Email.IsBodyHtml = true;

            Email.Attachments.Add(new Attachment(@"C:\\Users\\Talha\\Desktop\\C#\\30.Mail_islemleri\\attachment.txt"));

            SmtpClient smtpMail = new SmtpClient("smtp.live.com", 587);
            smtpMail.Credentials = new System.Net.NetworkCredential(mail_adress, "Qs1693sdf567");
            smtpMail.EnableSsl = true;
        }
    }
}
