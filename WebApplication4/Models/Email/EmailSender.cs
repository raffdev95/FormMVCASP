using System;
using System.Net.Mail;
using System.Text;
using System.Windows.Forms;

namespace WebApplication4.Models.Email
{
    public class EmailSender
    {

        Create create = new Create();

        public void SendInfoEmail(string subject, string messageContent, params string[] recipients)
        {

            using (SmtpClient client = new SmtpClient())
            using (MailMessage message = new MailMessage())

            {

                foreach (var recipient in recipients)
                {

                    message.To.Add(recipient);

                }

                message.IsBodyHtml = true;
                message.Subject = subject;
                message.Body = CreateHtmlBodyEmail(messageContent);

              
                    client.Send(message);
                   
                    

            }


        }

        private string CreateHtmlBodyEmail(string text)
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append("<html>");
            stringBuilder.Append("<body>");
            stringBuilder.Append(text);
            stringBuilder.Append("</body>");
            stringBuilder.Append("</html>");

            return stringBuilder.ToString();
        }

        internal void SendInfoEmail(string subject, string text, string email)
        {
            throw new System.NotImplementedException();
        }
    }
}