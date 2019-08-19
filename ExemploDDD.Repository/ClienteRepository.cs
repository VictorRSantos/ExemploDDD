using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExemploDDD.Domain;

namespace ExemploDDD.Repository
{
    public class ClienteRepository : IClienteRepository
    {
        public void Alterar(Cliente cli)
        {
            throw new NotImplementedException();
        }

        public void Excluir(string ID)
        {
            throw new NotImplementedException();
        }

        public void Incluir(Cliente cli)
        {
            throw new NotImplementedException();
        }

        public List<Cliente> Listar()
        {
            var lista = new List<Cliente>();
            lista.Add(new Cliente() { Id = "1", Nome = "Jose" });
            lista.Add(new Cliente() { Id = "2", Nome = "Maria" });
            return lista;

        }

        public Cliente ObterPorId(string ID)
        {
            throw new NotImplementedException();
        }
    }
}
