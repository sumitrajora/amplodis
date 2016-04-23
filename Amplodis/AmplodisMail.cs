using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace Amplodis
{
     public static class AmplodisMail
    {
       
        private static MailMessage m;
        static AmplodisMail()
        {
            m = new MailMessage();
            m.Sender = m.From = new MailAddress(ConfigurationManager.AppSettings["SendMailMessagesFromAddress"].ToString());
            m.IsBodyHtml = true;
        }

        public static bool isHTML
        {
            set
            {
                m.IsBodyHtml = value;
            }
        }

        public static string to
        {
            set
            {
                m.To.Add(value);
            }
        }

        public static string from
        {
            set
            {
                m.Sender = m.From = new MailAddress(value);
            }
        }

        public static string subject
        {
            set
            {
                m.Subject = value;
            }
        }

        public static string body
        {
            get
            {
                return body;
            }
            set
            {
                m.Body = value;

            }
        }

        public static void send()
        {
            try
            {
                SmtpClient sc = new SmtpClient();
                sc.Host = ConfigurationManager.AppSettings["SendMailSTMPHostAddress"].ToString();
                sc.DeliveryMethod = SmtpDeliveryMethod.Network;
                sc.UseDefaultCredentials = false;
                sc.Port = 25;
                sc.Credentials = new System.Net.NetworkCredential(
                        ConfigurationManager.AppSettings["SendMailSMTPUserName"].ToString(),
                        ConfigurationManager.AppSettings["SendMailSMTPUserPassword"].ToString()
                );

                sc.Send(m);
            }
            catch (Exception e)
            {
                //Log error somehow
            }
        }
     }
}
