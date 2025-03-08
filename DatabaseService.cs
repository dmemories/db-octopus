using Npgsql;
using DB_Octopus;

namespace MyDotNetProject.Services
{
    public class DatabaseService
    {
        private readonly string _connectionString;

        public DatabaseService(ConfigManager configuration)
        {
            _connectionString = configuration.dbConfig.GetConfig(configuration.dbConfig.ConnectionString) ?? throw new Exception("Database connection string is missing.");
        }

        public NpgsqlConnection GetConnection()
        {
            return new NpgsqlConnection(_connectionString);
        }
    }
}
