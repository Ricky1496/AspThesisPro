using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

namespace AspThesisPro.Services
{
    public class MyEmailSender : IEmailSender
    {
        private readonly IConfiguration _config;
        private readonly ILogger<MyEmailSender> _logger;

        public MyEmailSender(
            IConfiguration config,
            ILogger<MyEmailSender> logger)
        {
            _config = config;
            _logger = logger;
        }

        #region Microsoft.AspNetCore.Identity.UI.Services.IEmailSender members

        public Task SendEmailAsync(
            string email, string subject, string htmlMessage)
        {
            var smtpServer = _config.GetValue<string>("MySmtpSettings:SmtpServer");
            var smtpServerSSL = _config.GetValue<bool>("MySmtpSettings : SmtpServerSSL");
            var smtpPort = _config.GetValue<int>("MySmtpSettings: SmtpPort");
            var smtpFromEmail = _config.GetValue<string>("MySmtpSettings:FromEmail");
            var smtpFromEmailAlias = _config.GetValue<string>("MySmtpSettings:FromEmailAlias");
            var smtpUsername = _config.GetValue<string>("MySmtpSettings:Username");
            var smtpPassword = _config.GetValue<string>("MySmtpSettings:Password");

            var client = new SmtpClient(smtpServer)
            {
                UseDefaultCredentials = false,
                EnableSsl = smtpServerSSL,
                Port = smtpPort,
                DeliveryMethod = SmtpDeliveryMethod.Network,

                Credentials = new NetworkCredential(
                    userName : smtpUsername,
                    password : smtpPassword)
            };

            var mailMessage = new MailMessage
            {
                From = new MailAddress(smtpFromEmail, smtpFromEmailAlias),
                Subject = subject
            };

            // need to split multiple email addresses apart before adding to the collection 

            mailMessage.To.Add(email);
            mailMessage.Priority = MailPriority.High;
            mailMessage.IsBodyHtml = true;
            mailMessage.Body = htmlMessage;

            MyEmailSenderException myexception;

            try
            {
                client.SendMailAsync(mailMessage).Wait();
                return Task.CompletedTask;
            }
            catch(SmtpFailedRecipientsException exp)
            {
                myexception = new MyEmailSenderException(
                    $"Unable to send eamil to {exp.FailedRecipient}",exp);
            }
            catch (SmtpFailedRecipientException exp)
            {
                myexception = new MyEmailSenderException(
                    $"Unable to send email to {exp.FailedRecipient}", exp);
            }
            catch (SmtpException exp)
            {
                myexception = new MyEmailSenderException(
                    $"There was problem sending email:{exp.Message}", exp);
            }
            catch (Exception exp)
            {
                myexception = new MyEmailSenderException(
                    $"Something went wrong! : {exp.Message}", exp);
            }

            return Task.FromException<MyEmailSenderException>(myexception);
        }

        #endregion
    }
}
