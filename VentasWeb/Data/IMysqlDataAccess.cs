namespace VentasWeb.Data
{
    public interface IMysqlDataAccess
    {
        Task<List<T>> TraerDatos<T, U>(string sql, U parameters, string connectionString);
        Task GuardarDatos<T>(string sql, T parameters, string connectionString);
    }
}
