using System.Net;
using System.Net.Mail;

namespace AAETravel.Services;

public class EmailSender : IEmailSender
{
    public async Task SendEmailAsync(string emailAddress, string subject, string htmlMessage)
    {
        var mail = "aaetravel834499@gmail.com";
        var pw = "834499Travel";

        var client = new SmtpClient("smtp-mail.gmail.com", 587)
        {
            EnableSsl = true,
            Credentials = new NetworkCredential(mail, pw)
        };

        MailMessage sendMail = new(
            from: mail,
            to: emailAddress,
            subject,
            htmlMessage
        );
        sendMail.IsBodyHtml = true;

        await client.SendMailAsync(sendMail);
    }
}