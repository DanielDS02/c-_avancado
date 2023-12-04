using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEmTresCamadas.Pizzaria.DAO
{
    public class ClienteDAO
    {
        private const string ConnectionString = "DataSource=Pizza.db";

        public ClienteDAO()
        {

            CriarBancoDeDados();

        }

        public void CriarBancoDeDados()
        {
            using (var sqlConnection = new SqliteConnection(ConnectionString))
            {
                sqlConnection.Open();
                using (var cmd = sqlConnection.CreateCommand())
                {
                    cmd.CommandText = @"CREATE TABLE IF NOT EXISTS  Cliente
                    (
                        ID INTEGER PRIMARY KEY AUTOINCREMENT,
                        Nome VARCHAR(60) NOT NULL,

                    )";
                    cmd.ExecuteNonQuery();
                }
            }
        }


    }
}
