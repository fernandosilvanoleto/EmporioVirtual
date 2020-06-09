using EmporioVirtual.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmporioVirtual.Libraries.Login
{
    public class LoginColaborador
    {
        // instalado o pacto de newtonsoft.json
        public string Key = "Login.Colaborador";
        private Sessao.Sessao _sessao;
        public LoginColaborador(Sessao.Sessao sessao)
        {
            _sessao = sessao;
        }
        public void Login(Colaborador colaborador)
        {
            //ARMAZENAR NA SESSÃO
            //_sessao.Cadastrar(Key, cliente);
            string colaboradorString = JsonConvert.SerializeObject(colaborador);
            _sessao.Cadastrar(Key, colaboradorString);
        }

        public Colaborador GetColaborador()
        {
            if (_sessao.Existe(Key))
            {
                string colaboradorJsonString = _sessao.Consultar(Key);
                return JsonConvert.DeserializeObject<Colaborador>(colaboradorJsonString);
            }
            else
            {
                return null;
            }

        }

        public void Logout()
        {
            _sessao.RemoverTodos();
        }
    }
}
