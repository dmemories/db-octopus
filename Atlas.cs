using MyDotNetProject.Services;

namespace DB_Octopus
{
    public class Atlas
    {
        private readonly DatabaseService _databaseService;
        private readonly ConfigManager _configManager;

        public Atlas(ConfigManager configManager, DatabaseService databaseService)
        {
            _databaseService = databaseService;
            _configManager = configManager;
        }
    }
}
