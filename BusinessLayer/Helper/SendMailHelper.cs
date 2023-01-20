using SendGrid.Helpers.Mail;
using SendGrid;
using System;
using System.Threading.Tasks;

namespace BusinessLayer.Helper
{
    public static class SendMailHelper
    {
        //private static void Main()
        //{
        //    Execute().Wait();
        //}

        public static  async Task Execute()
        {
            string apiKey = "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";
            //var apiKey = Environment.GetEnvironmentVariable("SENDGRID_API_KEY");
            var client = new SendGridClient(apiKey);
            var from = new EmailAddress("veznedaroglufayik2@gmail.com", "Fayik");
            var subject = "Sending with SendGrid is Fun";
            var to = new EmailAddress("veznedaroglufayik2@gmail.com", "Fayik");
            var plainTextContent = "and easy to do anywhere, even with C#";
            var htmlContent = "<strong>and easy to do anywhere, even with C#</strong>";
            var msg = MailHelper.CreateSingleEmail(from, to, subject, plainTextContent, htmlContent);
            var response = await client.SendEmailAsync(msg);
        }
    }
}
