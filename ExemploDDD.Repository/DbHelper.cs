using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Data;
using System.Data.SqlClient;

namespace ExemploDDD.Repository
{
    public static class DbHelper
    {

        //String de conexão com Banco de Dados
        private const string stringDeConexao = @"Data Source=DESKTOP;Initial Catalog=TesteDDD;Integrated Security=True;Pooling=False";


      
        public static SqlConnection obterConexao()
        {
            return new SqlConnection(stringDeConexao);
        }

                        
        public static int Execute(string sql, object parametro)
        {
            using (var db = obterConexao())
            {
                return db.Execute(sql, parametro, commandType:CommandType.StoredProcedure);
            }
        }

        public static List<T> Query<T>(string sql, object parametro)
        {
            using (var db = obterConexao())
            {
                return db.Query<T>(sql, parametro, commandType: CommandType.StoredProcedure).ToList();
            }
        }


        public static T QueryFirstOrDefault<T>(string sql, object parametro)
        {
            using (var db = obterConexao())
            {
                return db.QueryFirstOrDefault(sql, parametro, commandType:CommandType.StoredProcedure);
            }
        }


    }
}
