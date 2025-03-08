using System.Text.Json;
using System.Text.Json.Nodes;
using Microsoft.Extensions.Configuration;

namespace DB_Octopus
{
    public class ConfigManager
    {
        private readonly string _configFilePath;
        private IConfigurationRoot _configuration;

        public abstract class AppConfig
        {
            public string Section { get; }
            private IConfigurationRoot Configuration;
            private string ConfigFilePath;

            public AppConfig(IConfigurationRoot _configuration, string _configFilePath, string section)
            {
                Configuration = _configuration;
                ConfigFilePath = _configFilePath;
                Section = section;
            }

            public string GetConfig(string key)
            {
                return Configuration[$"{Section}:{key}"] ?? "Not Set";
            }

            public void UpdateConfig(string key, string newValue)
            {
                try
                {
                    var json = File.ReadAllText(ConfigFilePath);
                    var jsonObject = JsonNode.Parse(json)?.AsObject() ?? new JsonObject();

                    if (!jsonObject.ContainsKey(Section) || jsonObject[Section] == null)
                    {
                        jsonObject[Section] = new JsonObject();
                    }

                    var sectionObject = jsonObject[Section]?.AsObject();
                    if (sectionObject != null)
                    {
                        sectionObject[key] = newValue;
                    }

                    File.WriteAllText(ConfigFilePath, jsonObject.ToJsonString(new JsonSerializerOptions { WriteIndented = true }));
                }
                catch (Exception ex)
                {
                    throw new Exception($"Error updating {Section}:{key}: " + ex.Message);
                }
            }
        }

        public sealed class DatabaseConfig : AppConfig
        {
            public string ConnectionString { get; } = "ConnectionString";
            public DatabaseConfig(IConfigurationRoot _configuration, string _configFilePath, string section) : base(_configuration, _configFilePath, section) { }
        }

        public sealed class MigrationConfig : AppConfig
        {
            public string SqlFolder { get; } = "SqlFolder";
            public MigrationConfig(IConfigurationRoot _configuration, string _configFilePath, string section) : base(_configuration, _configFilePath, section) { }
        }

        public sealed class AtlasConfig : AppConfig
        {
            public string ScriptName { get; } = "ScriptName";
            public string SubPath { get; } = "SubPath";
            public string WorkingPath { get; } = "WorkingPath";
            public string Cmd { get; } = "Cmd";
            public AtlasConfig(IConfigurationRoot _configuration, string _configFilePath, string section) : base(_configuration, _configFilePath, section) { }
        }


        public DatabaseConfig dbConfig;
        public MigrationConfig migrationConfig;
        public AtlasConfig atlasConfig;

        public ConfigManager()
        {
            _configFilePath = GetConfigFilePath();
            LoadConfig();

            dbConfig = new DatabaseConfig(_configuration, _configFilePath, "Database");
            migrationConfig = new MigrationConfig(_configuration, _configFilePath, "Migration");
            atlasConfig = new AtlasConfig(_configuration, _configFilePath, "Atlas");
        }

        private string GetConfigFilePath()
        {
            string basePath = AppDomain.CurrentDomain.BaseDirectory;
            return Path.Combine(basePath, "..", "..", "..", "appsettings.json");
        }

        private void LoadConfig()
        {
            if (!File.Exists(_configFilePath))
            {
                throw new FileNotFoundException("Config file not found!");
            }

            var builder = new ConfigurationBuilder().AddJsonFile(_configFilePath, optional: false, reloadOnChange: true);
            _configuration = builder.Build();
        }
    }
}
