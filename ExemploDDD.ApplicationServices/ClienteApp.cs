using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExemploDDD.Domain;

namespace ExemploDDD.ApplicationServices
{

    //Essa classe é a parte do projeto que resolve as instâncias, interage com diversas camadas e serve como primeiro ponto
    //de conexão das interfaces de usuário.
    public class ClienteApp : IClienteApp
    {


        IClienteRepository clienteRepository;
        //Construtor
        public ClienteApp(IClienteRepository cliRepository)
        {
            this.clienteRepository = cliRepository;

        }
        
        public void Alterar(Cliente cli)
        {
            
            clienteRepository.Alterar(cli);
        }

        public void Excluir(string ID)
        {
            clienteRepository.Excluir(ID);
        }

        public void Incluir(Cliente cli)
        {
            clienteRepository.Incluir(cli);
        }

        public List<Cliente> Listar()
        {
            return clienteRepository.Listar();
        }

        public Cliente ObterPorId(string ID)
        {
            return clienteRepository.ObterPorId(ID);
        }
    }
}
