using System.Net;
using System.Net.Mail;
using Kbide_desenvolvimento.Models;

namespace Kbide_desenvolvimento.Libraries.Email
{
    public class ContatoEmail
    {
        public static void EnviarContatoPorEmail(Contato contato)
        {
            /*
             * SMTP -> Servidor que vai enviar a mensagem.
             */
            SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
            smtp.UseDefaultCredentials = false;
            smtp.Credentials = new NetworkCredential("nathan90001@gmail.com", "");
            smtp.EnableSsl = true;

            string corpoMsg = string.Format("<h2>Contato - Kbide</h2>" +
                "<b>Nome: </b> {0} <br />" +
                "<b>E-mail: </b> {1} <br />" +
                "<b>Texto: </b> {2} <br />" +
                "<br /> E-mail enviado automaticamente do site Kbide.",
                contato.Nome,
                contato.Email,
                contato.Texto
            );

            /*
             * MailMessage -> Construir a mensagem
             */
            MailMessage mensagem = new MailMessage();
            mensagem.From = new MailAddress("nathan90001@gmail.com");
            mensagem.To.Add("nathan90001@gmail.com");
            //mensagem.To.Add("samuellemesdeoliveira1@gmail.com");
            mensagem.Subject = "Contato - Kbide - E-mail: " + contato.Email;
            mensagem.Body = corpoMsg;
            mensagem.IsBodyHtml = true;

            //Enviar Mensagem via SMTP
            smtp.Send(mensagem);

        }
    }
}