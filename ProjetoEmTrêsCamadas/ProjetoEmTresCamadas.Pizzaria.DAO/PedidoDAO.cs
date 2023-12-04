using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEmTresCamadas.Pizzaria.DAO
{
    public class PedidoDAO
    {

        private const string ConnectionString = "DataSource=Pizza.db";

        public PedidoDAO()
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
                        idPizza int not null,
	                    idCliente int not null,
	                    constraint FK_nomePizza Foreign Key (idPizza)
	                    references Pizza (ID) on delete cascade on update cascade,
	                    constraint FK_nomeCliente Foreign Key (idCliente)
	                    references Cliente (IDCliente) on delete cascade on update cascade

                    )";
                    cmd.ExecuteNonQuery();
                }
            }
        }


    }
}

