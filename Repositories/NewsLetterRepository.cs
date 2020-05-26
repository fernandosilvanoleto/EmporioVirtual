using EmporioVirtual.Database;
using EmporioVirtual.Models;
using EmporioVirtual.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmporioVirtual.Repositories
{
    public class NewsLetterRepository : INewsLetterRepository
    {
        private EmporioVirtualContext _banco;
        public NewsLetterRepository(EmporioVirtualContext banco)
        {
            _banco = banco;
        }
        public void Cadastrar(NewsletterEmail newsletter)
        {
            _banco.NewsletterEmail.Add(newsletter);
            _banco.SaveChanges();
        }

        public IEnumerable<NewsletterEmail> ObterTodosNewsLetter()
        {
            return _banco.NewsletterEmail.ToList();
        }
    }
}
