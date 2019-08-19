using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploDDD.Domain
{
    public interface IClienteRepository
    {

        void Incluir(Cliente cli);

        void Alterar(Cliente cli);

        void Excluir(string ID);

        Cliente ObterPorId(string ID);

        List<Cliente> Listar(); 

    }
}
