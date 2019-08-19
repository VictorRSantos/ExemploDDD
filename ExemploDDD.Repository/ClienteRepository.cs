using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExemploDDD.Domain;
using Dapper;
using System.Data.SqlClient;
using System.Data.Common;
using System.Data;

namespace ExemploDDD.Repository
{
    public class ClienteRepository : IClienteRepository
    {


       
        public ClienteRepository()
        {
                     

        }


        public void Alterar(Cliente cli)
        {

            DbHelper.Execute("ClienteAlterar", cli);
        }

        public void Excluir(string id)
        {

            DbHelper.Execute("ClienteExcluir", new { id = id} );

        }

        public void Incluir(Cliente cli)
        {


            DbHelper.Execute("ClienteIncluir", cli);

        }

        public List<Cliente> Listar()
        {
            return DbHelper.Query<Cliente>("ClienteListar", null);

        }

        public Cliente ObterPorId(string id)
        {
            return DbHelper.QueryFirstOrDefault<Cliente>("ClienteObterPorId", new { id });
        }
    }
}
