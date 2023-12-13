using Dapper;
using MySql.Data.MySqlClient;



namespace Produto.Infrastructure
{
    public class Connection
    {
        protected string connectionString = "Server=localHost;Database=divisio_db;User=root;Password=root;";


        protected MySqlConnection GetConnection()
        {
            return new MySqlConnection(connectionString);
        }

        protected async Task<int> Execute(string sql, object obj)
        {
            using(MySqlConnection con = GetConnection())
            { 
              return await con.ExecuteAsync(sql, obj);
            }
        }
    
    
    }
}
