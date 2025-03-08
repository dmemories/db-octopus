using Npgsql;
using MyDotNetProject.Services;

namespace DB_Octopus
{
    public class MigrationService
    {
        private readonly DatabaseService _databaseService;
        private readonly ConfigManager _configManager;

        public MigrationService(ConfigManager configManager, DatabaseService databaseService)
        {
            _configManager = configManager;
            _databaseService = databaseService;
        }

        public void RunMigration()
        {

            string sqlFolder = _configManager.migrationConfig.GetConfig(_configManager.migrationConfig.SqlFolder);
            var sqlFiles = Directory.GetFiles(sqlFolder, "*.sql");


            if (sqlFiles.Length == 0)
            {
                throw new InvalidOperationException("No SQL files found in the folder. Migration aborted.");
            }

            Console.WriteLine($"Found {sqlFiles.Length} SQL files. Starting migration...");
            ClearAllTables();
            ExecuteSqlFiles();
        }

        public void ClearAllTables()
        {
            using var conn = _databaseService.GetConnection();
            conn.Open();

            Console.WriteLine("Clearing all tables...");

            using var cmd = new NpgsqlCommand(@"
                SELECT tablename FROM pg_tables WHERE schemaname = 'public';", conn);
            using var reader = cmd.ExecuteReader();

            var tables = new List<string>();
            while (reader.Read())
            {
                tables.Add(reader.GetString(0));
            }

            reader.Close();

            using (var disableCmd = new NpgsqlCommand("SET session_replication_role = 'replica';", conn))
                disableCmd.ExecuteNonQuery();

            foreach (var table in tables)
            {
                try
                {
                    using var dropCmd = new NpgsqlCommand($"DROP TABLE {table} CASCADE;", conn);
                    dropCmd.ExecuteNonQuery();
                    Console.WriteLine($"Dropped table: {table}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Failed to DROP table {table}: {ex.Message}");
                }
            }

            using (var enableCmd = new NpgsqlCommand("SET session_replication_role = 'origin';", conn))
                enableCmd.ExecuteNonQuery();

            Console.WriteLine("All tables cleared successfully.");
        }

        public void ExecuteSqlFiles()
        {
            using var conn = _databaseService.GetConnection();
            conn.Open();

            using (var extCmd = new NpgsqlCommand(@"CREATE EXTENSION IF NOT EXISTS ""uuid-ossp"";", conn))
                extCmd.ExecuteNonQuery();

            string sqlFolder = _configManager.migrationConfig.GetConfig(_configManager.migrationConfig.SqlFolder);
            var sqlFiles = Directory.GetFiles(sqlFolder, "*.sql");

            foreach (var file in sqlFiles.OrderBy(f => f))
            {
                Console.WriteLine($"Executing: {file}");

                var queries = File.ReadAllText(file).Split(';')
                                .Select(q => q.Trim())
                                .Where(q => !string.IsNullOrEmpty(q));

                foreach (var query in queries)
                {
                    try
                    {
                        using var cmd = new NpgsqlCommand(query, conn);
                        cmd.ExecuteNonQuery();
                        Console.WriteLine($"Executed: {query}");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Failed to execute query in {file}: {ex.Message}");
                    }
                }
            }

            Console.WriteLine("All SQL files executed successfully.");
        }
    }
}
