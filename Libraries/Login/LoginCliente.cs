using EmporioVirtual.Models;
using EmporioVirtual.Libraries.Sessao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace EmporioVirtual.Libraries.Login
{
    public class LoginCliente
    {
        // instalado o pacto de newtonsoft.json
        public string Key = "Login.Cliente";
        private Sessao.Sessao _sessao;
       public LoginCliente(Sessao.Sessao sessao)
        {
            _sessao = sessao;
        }
        public void Login(Cliente cliente)
        {
            //ARMAZENAR NA SESSÃO
            //_sessao.Cadastrar(Key, cliente);
            string clienteString = JsonConvert.SerializeObject(cliente);
            _sessao.Cadastrar(Key, clienteString);
        }

        public Cliente GetCliente()
        {
            if(_sessao.Existe(Key))
            {
                string clienteJsonString = _sessao.Consultar(Key);
                return JsonConvert.DeserializeObject<Cliente>(clienteJsonString);
            } else
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
