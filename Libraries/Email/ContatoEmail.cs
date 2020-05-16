using EmporioVirtual.Models;
using Microsoft.AspNetCore.Mvc.ModelBinding.Binders;
using Microsoft.AspNetCore.Razor.Language.Intermediate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

namespace EmporioVirtual.Libraries.Email
{
    public class ContatoEmail
    {
        public static void EnviarContatoPorEmail (Contato contato)
        {
            /*
                SMTP - Servidor que vai enviar a mensagem
             */
            SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);

            smtp.UseDefaultCredentials = false;
            smtp.Credentials = new NetworkCredential("boloteca.teste@gmail.com", "684@Fgvkab37_2");
            smtp.EnableSsl = true;

            string corpoMsg = string.Format("<h2>Contato - Empório Virtual</h2>"+
                "<b>Nome: </b> {0} <br />"+
                "<b>Email: </b> {1} <br />"+
                "<b>Email: </b> {2} <br />"+
                "<br /> E-mail enviado automaticamente do site EmporioVirtual",
                contato.Nome,
                contato.Email,
                contato.Texto);
            /*
             * MailMessage -> contruir mensagem
             */
            MailMessage mensagem = new MailMessage();
            mensagem.From = new MailAddress("boloteca.teste@gmail.com");
            mensagem.To.Add("boloteca.teste@gmail.com");
            mensagem.Subject = "Contato - Empório Virtual - E-mail: " + contato.Email;
            mensagem.Body = corpoMsg;
            mensagem.IsBodyHtml = true;

            //enviar email
            smtp.Send(mensagem);
        }
    }
}
