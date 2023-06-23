using Dapper;
using MySql.Data.MySqlClient;
using System.Data;

namespace VentasWeb.Data
{
    public class MySqlDataAccess : IMysqlDataAccess
    {
        public Task GuardarDatos<T>(string sql, T parameters, string connectionString)
        {
            using (IDbConnection connection = new MySqlConnection(connectionString))
            {
                return connection.ExecuteAsync(sql, parameters);
            }
        }

        public async Task<List<T>> TraerDatos<T, U>(string sql, U parameters, string connectionString)
        {
            using (IDbConnection connection = new MySqlConnection(connectionString))
            {
                var rows = await connection.QueryAsync<T>(sql, parameters);
                return rows.ToList();
            }
        }

       
    }
}
