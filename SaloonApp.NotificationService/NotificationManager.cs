using Microsoft.EntityFrameworkCore;
using SaloonApp.DB;
using SaloonApp.Email.Domain.Models;
using SaloonApp.Notification.Domain;
using SaloonApp.UserDom.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace SaloonApp.NotificationService
{
    public class NotificationManager : INotificationActor
    {
        private readonly AppDbContext _ctx;

        public NotificationManager()
        {
            this._ctx = new AppDbContext();
        }

        private string confirmationEmailUrl = "http://app1-74.apphb.com/Account/ValidateEmail";

        public async Task CreateChangePasswordEmailAsync(User user)
        {
            throw new NotImplementedException();
        }

        public async Task CreateConfirmationEmailAsync(User user)
        {
            string callbackUrl = $"{confirmationEmailUrl}?userId={user.Id}&validationCode={user.ValidationCode}";
            string link = $"<a href='{ callbackUrl}'>here</a>!";
            string message = $"To confirm your account click  -> {link}";
            var emailTempl = new EmailTempl(user.Email, "SaloonApp registration request", message);
            await CreateEmailAsync(emailTempl);
            //SendEmailAsync().Start();
        }

        public async Task CreateEmailAsync(EmailTempl email)
        {
            await _ctx.Emails.AddAsync(email);
            await _ctx.SaveChangesAsync();
        }


        public Task SendEmailAsync()
        {

            SmtpClient client = new SmtpClient("smtp.gmail.com", 587)
            {
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential("gabrov.pv@gmail.com", "ivan9610264441")
            };
            while (true)
            {
                System.Threading.Thread.Sleep(2000);
                var emails = GetAllEmailsForSending();
                try
                {
                    foreach (var email in emails)
                    {
                        MailMessage mailMessage = new MailMessage
                        {
                            From = new MailAddress("gabrov.pv@gmail.com")
                        };
                        mailMessage.To.Add(email.Email);
                        mailMessage.Body = email.Message;
                        mailMessage.IsBodyHtml = true;
                        mailMessage.Subject = email.Subject;
                        client.EnableSsl = true;
                        client.SendMailAsync(mailMessage);
                    }
                }
                catch (Exception ex)
                {
                    //await _logger.LogCustomExceptionAsync(ex, null);
                    throw new ApplicationException($"Unable to load : '{ex.Message}'.");
                }
            }
        }

        public List<EmailTempl> GetAllEmailsForSending()
        {
            return _ctx.Emails.Where(e => e.Status == EmailStatus.Pending).ToList();
        }
    }
}
