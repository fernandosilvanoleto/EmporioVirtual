using EmporioVirtual.Models;
using Microsoft.AspNetCore.Mvc.ModelBinding.Binders;
using Microsoft.AspNetCore.Razor.Language.Intermediate;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

namespace EmporioVirtual.Libraries.Email
{
    public class GerenciarEmail
    {
        private SmtpClient _smtp;
        private IConfiguration _configuration;
        public GerenciarEmail(SmtpClient smtpclient, IConfiguration configuration)
        {
            _smtp = smtpclient;
            _configuration = configuration;
        }
        public void EnviarContatoPorEmail (Contato contato)
        {
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
            mensagem.From = new MailAddress(_configuration.GetValue<string>("Email:UserEmail"));
            mensagem.To.Add(contato.Email);
            mensagem.Subject = "Contato - Empório Virtual - E-mail: " + contato.Email;
            mensagem.Body = corpoMsg;
            mensagem.IsBodyHtml = true;

            //enviar email
            _smtp.Send(mensagem);
        }

        public void EnvarEmailParaColaboradorPorEmail(Colaborador colaborador)
        {
            string corpoMsg = string.Format("<h2>Colaborador - Empório Virtual</h2>" +
                "Sua senha é: " +
                "<h3>{0}</h3>", colaborador.Senha);
            /*
             * MailMessage -> contruir mensagem
             */
            MailMessage mensagem = new MailMessage();
            mensagem.From = new MailAddress(_configuration.GetValue<string>("Email:UserEmail"));
            mensagem.To.Add(colaborador.Email);
            mensagem.Subject = "Colaborador - Empório Virtual - Senha do Colaborador: " + colaborador.Email;
            mensagem.Body = corpoMsg;
            mensagem.IsBodyHtml = true;

            //enviar email
            _smtp.Send(mensagem);
        }

    }
}
