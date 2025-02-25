using Microsoft.Extensions.Configuration;

namespace GAME.Infra.ConnectionDb
{
    public class ConnectionDB
    {
        private readonly string _DbConnectionString;

        public ConnectionDB(IConfiguration configuration)
        {
            _DbConnectionString = configuration.GetSection("ConnectionStrings").GetSection("PostgresConnection").Value;

        }
        public string GetString()
        {
            return _DbConnectionString;
        }
    }
}
