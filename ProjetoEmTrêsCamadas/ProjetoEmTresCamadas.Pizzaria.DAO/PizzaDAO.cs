using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.Sqlite;
using ProjetoEmTresCamadas.Pizzaria.RegraDeNegocio;

namespace ProjetoEmTresCamadas.Pizzaria.DAO
{
    public class PizzaDAO
    {
        private const string ConnectionString = "DataSource=Pizza.db";

        public PizzaDAO() 
        {

            CriarBancoDeDados();

        }

        public void CriarBancoDeDados()
        {
            using(var sqlConnection = new SqliteConnection(ConnectionString))
            {
                sqlConnection.Open();
                using(var cmd = sqlConnection.CreateCommand())
                {
                    cmd.CommandText = @"CREATE TABLE IF NOT EXISTS Pizza
                    (
                        ID INTEGER PRIMARY KEY AUTOINCREMENT,
                        Sabor VARCHAR(50) NOT NULL,
                        Descricao VARCHAR(100),
                        TamanhoPizza INT
                    )";
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void CriaPizza(Pizza pizzaVo)
        {
            using (var sqlConnection = new SqliteConnection(ConnectionString))
            {
                sqlConnection.Open();
                using (var cmd = sqlConnection.CreateCommand())
                {
                    cmd.CommandText = $@"
                    INSERT INTO Pizza
                    (Sabor, Descricao, TamanhoPizza)
                    VALUES('{pizzaVo.Sabor}',
                           '{pizzaVo.Descricao}',
                            {(int)pizzaVo.TamanhoDePizza})";
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
