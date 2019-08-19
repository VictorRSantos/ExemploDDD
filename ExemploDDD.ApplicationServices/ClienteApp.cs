using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExemploDDD.Domain;

namespace ExemploDDD.ApplicationServices
{
    public class ClienteApp : IClienteRepository
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
            throw new NotImplementedException();
        }

        public Cliente ObterPorId(string ID)
        {
            throw new NotImplementedException();
        }
    }
}
