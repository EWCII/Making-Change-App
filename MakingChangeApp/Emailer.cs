using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;

namespace MakingChangeApp
{
    public class Emailer
    {
        private const string From = "MakingChangeHappen32018@gmail.com";
        private const string Pass = "oyoecoihznpraiyh";
        private const string Host = "smtp.gmail.com";
        private const int Port = 587;

        public static void Send(string To, string Subject, string Body)
        {
            using (var client = new SmtpClient(Host, Port))
            {
                client.EnableSsl = true;
                client.UseDefaultCredentials = false;
                client.Credentials = new NetworkCredential(From, Pass);

                //Send email to multiple people
                using (var message = new MailMessage())
                {
                    message.From = new MailAddress(From);
                    message.Subject = Subject;
                    message.Body = Body;
                    message.IsBodyHtml = false;

                    var toAddresses = To.Split(';');
                    foreach (var address in toAddresses)
                    {
                        message.To.Add(new MailAddress(address));
                    }

                    client.Send(message);
                }
            }
        }
    }
}