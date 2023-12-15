using System;
using System.Net;
using System.Net.Mail;

namespace servicios
{
    public static class EnviarMail
    {
        public static void sendMail(string to, string asunto, string body)
        {
            string from = "Santi543luque@gmail.com"; //correo de la empresa
            string displayName = "contraseña"; //Lo que se ve al recibir el mail
                MailMessage mail = new MailMessage
                {
                    From = new MailAddress(from, displayName)
                };
                mail.To.Add(to);

                mail.Subject = asunto;
                mail.Body = body;
                mail.IsBodyHtml = true;

                SmtpClient client = new SmtpClient("smtp.gmail.com")
                {
                    Port = 587,
                    Credentials = new NetworkCredential(from, "uiin mvrr tule urft"),
                    EnableSsl = true,
                };
                client.Send(mail);

        }
    }
}


