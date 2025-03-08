using MyDotNetProject.Services;

namespace DB_Octopus
{
    public partial class Form1 : Form
    {
        private readonly ConfigManager _configManager;
        private readonly MigrationService _migrationService;
        private string LAST_GEN_FILE = "";

        public Form1()
        {
            InitializeComponent();
            _configManager = new ConfigManager();
            _migrationService = new MigrationService(_configManager, new DatabaseService(_configManager));

            LoadConfig();
        }

        private void LoadConfig()
        {
            try
            {
                txtScriptMigrationPath.Text = _configManager.migrationConfig.GetConfig(_configManager.migrationConfig.SqlFolder);
                txtAtlasScriptName.Text = _configManager.atlasConfig.GetConfig(_configManager.atlasConfig.ScriptName);
                txtAtlasSubPath.Text = _configManager.atlasConfig.GetConfig(_configManager.atlasConfig.SubPath);
                txtAtlasWorkingPath.Text = _configManager.atlasConfig.GetConfig(_configManager.atlasConfig.WorkingPath);
                txtAtlasCommand.Text = _configManager.atlasConfig.GetConfig(_configManager.atlasConfig.Cmd);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading config: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btxScriptMigrationRun_Click(object sender, EventArgs e)
        {
            registerAlertEvent(e, () =>
            {
                _migrationService.RunMigration();
                MessageBox.Show("Migration Completed Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            });
        }

        private void txtScriptMigrationPath_DoubleClick(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderDialog = new FolderBrowserDialog())
            {
                if (folderDialog.ShowDialog() == DialogResult.OK)
                {
                    txtScriptMigrationPath.Text = folderDialog.SelectedPath;
                    try
                    {
                        _configManager.migrationConfig.UpdateConfig(_configManager.migrationConfig.SqlFolder, txtScriptMigrationPath.Text);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error saving config: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }


        private void registerDoubleClickEvent(EventArgs e, Action<FolderBrowserDialog> action)
        {
            using (FolderBrowserDialog folderDialog = new FolderBrowserDialog())
            {
                if (folderDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        action(folderDialog);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void registerKeyDownEvent(KeyEventArgs e, Action action)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                try
                {
                    action();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void registerAlertEvent(EventArgs e, Action action)
        {
            try
            {
                var confirmResult = MessageBox.Show(
                    "Confirm ?",
                    "",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (confirmResult == DialogResult.Yes)
                {
                    action();
                }
                MessageBox.Show("Run Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void TxtScriptMigrationPath_KeyDown(object sender, KeyEventArgs e)
        {
            registerKeyDownEvent(e, () =>
            {
                _configManager.migrationConfig.UpdateConfig(_configManager.migrationConfig.SqlFolder, txtScriptMigrationPath.Text);
            });
        }


        private void txtAtlasScriptName_KeyDown(object sender, KeyEventArgs e)
        {
            registerKeyDownEvent(e, () =>
            {
                _configManager.atlasConfig.UpdateConfig(_configManager.atlasConfig.ScriptName, txtAtlasScriptName.Text);
            });
        }

        private void txtAtlasSubPath_KeyDown(object sender, KeyEventArgs e)
        {
            registerKeyDownEvent(e, () =>
            {
                _configManager.atlasConfig.UpdateConfig(_configManager.atlasConfig.SubPath, txtAtlasSubPath.Text);
            });
        }

        private void txtAtlasWorkingPath_KeyDown(object sender, KeyEventArgs e)
        {
            registerKeyDownEvent(e, () =>
            {
                _configManager.atlasConfig.UpdateConfig(_configManager.atlasConfig.WorkingPath, txtAtlasWorkingPath.Text);
            });
        }

        private void txtAtlasCommand_KeyDown(object sender, KeyEventArgs e)
        {
            registerKeyDownEvent(e, () =>
            {
                _configManager.atlasConfig.UpdateConfig(_configManager.atlasConfig.Cmd, txtAtlasCommand.Text);
            });
        }

        private void txtAtlasWorkingPath_DoubleClick(object sender, EventArgs e)
        {
            registerDoubleClickEvent(e, (FolderBrowserDialog folderDialog) =>
            {
                txtAtlasWorkingPath.Text = folderDialog.SelectedPath;
                _configManager.atlasConfig.UpdateConfig(_configManager.atlasConfig.WorkingPath, txtAtlasWorkingPath.Text);
            });
        }

        private void btnAtlasDiffRun_Click(object sender, EventArgs e)
        {
            registerAlertEvent(e, () =>
            {
                string detectFilePath = FileHelper.GetNewFile(_configManager.migrationConfig.GetConfig(_configManager.migrationConfig.SqlFolder), () =>
                {
                    var result = CommandExecutor.RunCommand(
                        _configManager.atlasConfig.GetConfig(_configManager.atlasConfig.Cmd),
                        _configManager.atlasConfig.GetConfig(_configManager.atlasConfig.WorkingPath)
                        );

                    if (!string.IsNullOrEmpty(result.Error))
                    {
                        MessageBox.Show("Error: " + result.Error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                });

                if (string.IsNullOrWhiteSpace(detectFilePath))
                {
                    throw new ArgumentException("File path is invalid or empty.", nameof(detectFilePath));
                }

                string directory = Path.GetDirectoryName(detectFilePath) ?? throw new Exception("Failed to get directory name from file path.");
                string oldFileName = Path.GetFileNameWithoutExtension(detectFilePath);
                string suffix = _configManager.atlasConfig.GetConfig(_configManager.atlasConfig.ScriptName);
                string newFileName = $"{oldFileName}_{suffix}";
                string newFilePath = Path.Combine(directory, newFileName);

                LAST_GEN_FILE = newFilePath;
                File.Move(detectFilePath, newFilePath);
            });
        }



        private void btnAtlasCopyRun_Click(object sender, EventArgs e)
        {
            registerAlertEvent(e, () =>
            {
                if (LAST_GEN_FILE == "")
                {
                    MessageBox.Show("Error: Have no LAST_GEN_FILE", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string baseDirectory = Path.GetDirectoryName(LAST_GEN_FILE);
                string parentDirectory = Path.GetDirectoryName(baseDirectory);
                string subPath = _configManager.atlasConfig.GetConfig(_configManager.atlasConfig.SubPath);
                string[] environments = subPath.Split(',')
                               .Select(x => x.Trim())
                               .Where(x => !string.IsNullOrWhiteSpace(x))
                               .ToArray();


                if (environments == null || environments.Length == 0)
                {
                    MessageBox.Show("Error: No environments found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string sumFileName = "atlas.sum";
                string sourceSumFilePath = Path.Combine(baseDirectory, sumFileName);

                foreach (string env in environments)
                {
                    string newDir = Path.Combine(parentDirectory, env);
                    string newFilePath = Path.Combine(newDir, Path.GetFileName(LAST_GEN_FILE));
                    string sumFilePath = Path.Combine(newDir, sumFileName);

                    if (!Directory.Exists(newDir))
                    {
                        Directory.CreateDirectory(newDir);
                    }

                    File.Copy(LAST_GEN_FILE, newFilePath, true);
                    File.Copy(sourceSumFilePath, sumFilePath, true);
                }
            });
        }

    }
}
