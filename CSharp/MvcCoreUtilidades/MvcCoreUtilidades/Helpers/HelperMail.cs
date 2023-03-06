﻿using System.Net;
using System.Net.Mail;

namespace MvcCoreUtilidades.Helpers
{
    public class HelperMail
    {
        //NECESITAMOS UPLOAD FILES AQUI?
        //PARA, ASUNTO, FROM, TO, USER, SMTP

        private IConfiguration configuration;

        public HelperMail(IConfiguration configuration)
        {
            this.configuration = configuration;
        }

        private MailMessage ConfigureMailMessage
            (string para, string asunto, string mensaje)
        {
            MailMessage mailMessage = new MailMessage();
            string email =
                this.configuration.GetValue<string>("MailSettings:Credentials:User");
            mailMessage.From = new MailAddress(email);
            mailMessage.To.Add(new MailAddress(para));
            mailMessage.Subject = asunto;
            mailMessage.Body = mensaje;
            mailMessage.IsBodyHtml = true;
            return mailMessage;
        }

        private SmtpClient ConfigureSmtpClient()
        {
            string user =
                this.configuration.GetValue<string>
                ("MailSettings:Credentials:User");
            string password = 
                this.configuration.GetValue<string>
                ("MailSettings:Credentials:Password");
            string host = this.configuration.GetValue<string>
                ("MailSettings:Smtp:Host");
            int port = this.configuration.GetValue<int>
                ("MailSettings:Smtp:Port");
            bool enableSSL = this.configuration.GetValue<bool>
                ("MailSettings:Smtp:EnableSSL");
            bool defaultCredentials = this.configuration.GetValue<bool>
                ("MailSettings:Smtp:DefaultCredentials");
            SmtpClient client = new SmtpClient();
            client.Host = host;
            client.Port = port;
            client.EnableSsl = enableSSL;
            client.UseDefaultCredentials = defaultCredentials;
            NetworkCredential credentials =
                new NetworkCredential(user, password);
            client.Credentials = credentials;
            return client;
        }

        //NECESITAMOS UN METODO PARA EVITAR UN MAIL

        public async Task
            SendMailAsync(string para, string asunto, string mensaje)
        {
            MailMessage mail = this.ConfigureMailMessage(para, asunto, mensaje);
            SmtpClient client = this.ConfigureSmtpClient();
            await client.SendMailAsync(mail);
        }

        public async Task
            SendMailAsync(string para, string asunto, string mensaje, string filePath)
        {
            MailMessage mail = this.ConfigureMailMessage(para, asunto, mensaje);
            Attachment attachment = new Attachment(filePath);
            mail.Attachments.Add(attachment);
            SmtpClient client = this.ConfigureSmtpClient();
            await client.SendMailAsync(mail);
        }

        public async Task
            SendMailAsync(string para, string asunto, string mensaje, List<string>filePath)
        {
            MailMessage mail = this.ConfigureMailMessage(para, asunto, mensaje);
            foreach (string filePathItem in filePath)
            {
                mail.Attachments.Add(new Attachment(filePathItem));
            }


            SmtpClient client = this.ConfigureSmtpClient();
            await client.SendMailAsync(mail);
        }
    }
}
