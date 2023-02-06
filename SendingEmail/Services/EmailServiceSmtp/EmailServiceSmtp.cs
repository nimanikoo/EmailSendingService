using MailKit.Net.Smtp;
using MailKit.Security;
using MimeKit;
using MimeKit.Text;
using SendingEmail.Models;

namespace SendingEmail.Services.EmailServiceSmtp
{
    public class EmailServiceSmtp : IEmailServiceSmtp
    {
        public void SendEmail(EmailDetails emailRequest)
        {
            var Email = new MimeMessage();
            Email.From.Add(MailboxAddress.Parse("your smtp.gmail.com"));
            Email.To.Add(MailboxAddress.Parse(emailRequest.EmailTo));
            Email.Subject = emailRequest.EmailSubject;
            Email.Body = new TextPart(TextFormat.Text) { Text = emailRequest.EmailBody };

            using var smtp = new SmtpClient();

            //USE THE FAVORITE SMTP SERVER FOR SENDING MAIL AND CUSTOM PORT(TLS)
            smtp.Connect("your smtp Service", 587, SecureSocketOptions.StartTls);

            // USE YOUR USERNAME & PASSWORD FOR Authentication
            smtp.Authenticate("Your Smtp Username", "Your Smtp Password");
            smtp.Send(Email);
            smtp.Disconnect(true);

            //Gmail Ports = 465(SSL) or 587 (TLS)
            //smtp.Host = "smtp.gmail.com"
            //Outlook Ports = 465(SSL) or 587 (TLS)
            //smtp.Host = "smtp.office365.com"


        }
    }
}
