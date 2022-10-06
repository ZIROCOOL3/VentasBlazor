namespace VentasWeb.Data
{
    public interface IMysqlDataAccess
    {
        Task<List<T>> TraerTodasVentas<T, U>(string sql, U parameters, string connectionString);
        Task<List<T>> TraerTodosProductos<T, U>(string sql, U parameters, string connectionString);
        Task<List<T>> TraerTodasCategorias<T, U>(string sql, U parameters, string connectionString);
        Task GuardarDatos<T>(string sql, T parameters, string connectionString);
    }
}
