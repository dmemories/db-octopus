namespace DB_Octopus
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            txtScriptMigrationPath = new TextBox();
            labMigrationTitle = new Label();
            btnScriptMigrationRun = new Button();
            labScriptMigrationPath = new Label();
            btnAtlasCmdRun = new Button();
            labAtlasCommand = new Label();
            txtAtlasCommand = new TextBox();
            laxAtlasTitle = new Label();
            labAtlasWorkingPath = new Label();
            txtAtlasWorkingPath = new TextBox();
            labAtlasScriptName = new Label();
            txtAtlasScriptName = new TextBox();
            txtAtlasSubPath = new TextBox();
            labAtlasSubPath = new Label();
            btnAtlasNewRun = new Button();
            btnAtlasCopyRun = new Button();
            btnAtlasHashRun = new Button();
            txtAtlasEnvironment = new TextBox();
            labAtlasEnv = new Label();
            btnScriptMigrationClear = new Button();
            SuspendLayout();
            // 
            // txtScriptMigrationPath
            // 
            txtScriptMigrationPath.Location = new Point(270, 88);
            txtScriptMigrationPath.Name = "txtScriptMigrationPath";
            txtScriptMigrationPath.Size = new Size(847, 35);
            txtScriptMigrationPath.TabIndex = 0;
            txtScriptMigrationPath.DoubleClick += txtScriptMigrationPath_DoubleClick;
            txtScriptMigrationPath.KeyDown += TxtScriptMigrationPath_KeyDown;
            // 
            // labMigrationTitle
            // 
            labMigrationTitle.AutoSize = true;
            labMigrationTitle.BackColor = SystemColors.InfoText;
            labMigrationTitle.Font = new Font("Sitka Small", 15.8571434F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labMigrationTitle.ForeColor = SystemColors.ActiveCaption;
            labMigrationTitle.Location = new Point(28, 19);
            labMigrationTitle.Name = "labMigrationTitle";
            labMigrationTitle.Size = new Size(207, 54);
            labMigrationTitle.TabIndex = 3;
            labMigrationTitle.Text = "Migration";
            // 
            // btnScriptMigrationRun
            // 
            btnScriptMigrationRun.Location = new Point(406, 158);
            btnScriptMigrationRun.Name = "btnScriptMigrationRun";
            btnScriptMigrationRun.Size = new Size(170, 40);
            btnScriptMigrationRun.TabIndex = 4;
            btnScriptMigrationRun.Text = "Migrate";
            btnScriptMigrationRun.UseVisualStyleBackColor = true;
            btnScriptMigrationRun.Click += btxScriptMigrationRun_Click;
            // 
            // labScriptMigrationPath
            // 
            labScriptMigrationPath.AutoSize = true;
            labScriptMigrationPath.BackColor = SystemColors.InfoText;
            labScriptMigrationPath.Font = new Font("Sitka Small", 9.857143F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labScriptMigrationPath.ForeColor = SystemColors.AppWorkspace;
            labScriptMigrationPath.ImageAlign = ContentAlignment.BottomCenter;
            labScriptMigrationPath.Location = new Point(37, 88);
            labScriptMigrationPath.Name = "labScriptMigrationPath";
            labScriptMigrationPath.Size = new Size(160, 35);
            labScriptMigrationPath.TabIndex = 3;
            labScriptMigrationPath.Text = "Scripts Path";
            // 
            // btnAtlasCmdRun
            // 
            btnAtlasCmdRun.Location = new Point(425, 452);
            btnAtlasCmdRun.Name = "btnAtlasCmdRun";
            btnAtlasCmdRun.Size = new Size(151, 40);
            btnAtlasCmdRun.TabIndex = 8;
            btnAtlasCmdRun.Text = "Cmd";
            btnAtlasCmdRun.UseVisualStyleBackColor = true;
            btnAtlasCmdRun.Click += btnAtlasDiffRun_Click;
            // 
            // labAtlasCommand
            // 
            labAtlasCommand.AutoSize = true;
            labAtlasCommand.BackColor = SystemColors.InfoText;
            labAtlasCommand.Font = new Font("Sitka Small", 9.857143F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labAtlasCommand.ForeColor = SystemColors.AppWorkspace;
            labAtlasCommand.ImageAlign = ContentAlignment.BottomCenter;
            labAtlasCommand.Location = new Point(37, 395);
            labAtlasCommand.Name = "labAtlasCommand";
            labAtlasCommand.Size = new Size(136, 35);
            labAtlasCommand.TabIndex = 7;
            labAtlasCommand.Text = "Command";
            // 
            // txtAtlasCommand
            // 
            txtAtlasCommand.Location = new Point(270, 395);
            txtAtlasCommand.Name = "txtAtlasCommand";
            txtAtlasCommand.Size = new Size(847, 35);
            txtAtlasCommand.TabIndex = 5;
            txtAtlasCommand.KeyDown += txtAtlasCommand_KeyDown;
            // 
            // laxAtlasTitle
            // 
            laxAtlasTitle.AutoSize = true;
            laxAtlasTitle.BackColor = SystemColors.InfoText;
            laxAtlasTitle.Font = new Font("Sitka Small", 15.8571434F, FontStyle.Regular, GraphicsUnit.Point, 0);
            laxAtlasTitle.ForeColor = SystemColors.ActiveCaption;
            laxAtlasTitle.Location = new Point(37, 205);
            laxAtlasTitle.Name = "laxAtlasTitle";
            laxAtlasTitle.Size = new Size(76, 54);
            laxAtlasTitle.TabIndex = 3;
            laxAtlasTitle.Text = "Atl";
            // 
            // labAtlasWorkingPath
            // 
            labAtlasWorkingPath.AutoSize = true;
            labAtlasWorkingPath.BackColor = SystemColors.InfoText;
            labAtlasWorkingPath.Font = new Font("Sitka Small", 9.857143F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labAtlasWorkingPath.ForeColor = SystemColors.AppWorkspace;
            labAtlasWorkingPath.ImageAlign = ContentAlignment.BottomCenter;
            labAtlasWorkingPath.Location = new Point(37, 333);
            labAtlasWorkingPath.Name = "labAtlasWorkingPath";
            labAtlasWorkingPath.Size = new Size(179, 35);
            labAtlasWorkingPath.TabIndex = 7;
            labAtlasWorkingPath.Text = "Working Path";
            // 
            // txtAtlasWorkingPath
            // 
            txtAtlasWorkingPath.Location = new Point(270, 335);
            txtAtlasWorkingPath.Name = "txtAtlasWorkingPath";
            txtAtlasWorkingPath.Size = new Size(847, 35);
            txtAtlasWorkingPath.TabIndex = 5;
            txtAtlasWorkingPath.DoubleClick += txtAtlasWorkingPath_DoubleClick;
            txtAtlasWorkingPath.KeyDown += txtAtlasWorkingPath_KeyDown;
            // 
            // labAtlasScriptName
            // 
            labAtlasScriptName.AutoSize = true;
            labAtlasScriptName.BackColor = SystemColors.InfoText;
            labAtlasScriptName.Font = new Font("Sitka Small", 9.857143F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labAtlasScriptName.ForeColor = SystemColors.AppWorkspace;
            labAtlasScriptName.ImageAlign = ContentAlignment.BottomCenter;
            labAtlasScriptName.Location = new Point(37, 275);
            labAtlasScriptName.Name = "labAtlasScriptName";
            labAtlasScriptName.Size = new Size(165, 35);
            labAtlasScriptName.TabIndex = 7;
            labAtlasScriptName.Text = "Script Name";
            // 
            // txtAtlasScriptName
            // 
            txtAtlasScriptName.Location = new Point(270, 275);
            txtAtlasScriptName.Name = "txtAtlasScriptName";
            txtAtlasScriptName.Size = new Size(353, 35);
            txtAtlasScriptName.TabIndex = 5;
            txtAtlasScriptName.KeyDown += txtAtlasScriptName_KeyDown;
            // 
            // txtAtlasSubPath
            // 
            txtAtlasSubPath.Location = new Point(791, 275);
            txtAtlasSubPath.Name = "txtAtlasSubPath";
            txtAtlasSubPath.Size = new Size(326, 35);
            txtAtlasSubPath.TabIndex = 5;
            txtAtlasSubPath.KeyDown += txtAtlasSubPath_KeyDown;
            // 
            // labAtlasSubPath
            // 
            labAtlasSubPath.AutoSize = true;
            labAtlasSubPath.BackColor = SystemColors.InfoText;
            labAtlasSubPath.Font = new Font("Sitka Small", 9.857143F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labAtlasSubPath.ForeColor = SystemColors.AppWorkspace;
            labAtlasSubPath.ImageAlign = ContentAlignment.BottomCenter;
            labAtlasSubPath.Location = new Point(651, 275);
            labAtlasSubPath.Name = "labAtlasSubPath";
            labAtlasSubPath.Size = new Size(119, 35);
            labAtlasSubPath.TabIndex = 7;
            labAtlasSubPath.Text = "Sub Path";
            // 
            // btnAtlasNewRun
            // 
            btnAtlasNewRun.Location = new Point(425, 595);
            btnAtlasNewRun.Name = "btnAtlasNewRun";
            btnAtlasNewRun.Size = new Size(151, 40);
            btnAtlasNewRun.TabIndex = 8;
            btnAtlasNewRun.Text = "New";
            btnAtlasNewRun.UseVisualStyleBackColor = true;
            btnAtlasNewRun.Click += btnAtlasNewRun_Click;
            // 
            // btnAtlasCopyRun
            // 
            btnAtlasCopyRun.Location = new Point(763, 452);
            btnAtlasCopyRun.Name = "btnAtlasCopyRun";
            btnAtlasCopyRun.Size = new Size(151, 40);
            btnAtlasCopyRun.TabIndex = 8;
            btnAtlasCopyRun.Text = "Copy";
            btnAtlasCopyRun.UseVisualStyleBackColor = true;
            btnAtlasCopyRun.Click += btnAtlasCopyRun_Click;
            // 
            // btnAtlasHashRun
            // 
            btnAtlasHashRun.Location = new Point(763, 595);
            btnAtlasHashRun.Name = "btnAtlasHashRun";
            btnAtlasHashRun.Size = new Size(151, 40);
            btnAtlasHashRun.TabIndex = 8;
            btnAtlasHashRun.Text = "Hash";
            btnAtlasHashRun.UseVisualStyleBackColor = true;
            btnAtlasHashRun.Click += btnAtlasHashRun_Click;
            // 
            // txtAtlasEnvironment
            // 
            txtAtlasEnvironment.Location = new Point(270, 528);
            txtAtlasEnvironment.Name = "txtAtlasEnvironment";
            txtAtlasEnvironment.Size = new Size(847, 35);
            txtAtlasEnvironment.TabIndex = 5;
            txtAtlasEnvironment.KeyDown += txtAtlasEnvironment_KeyDown;
            // 
            // labAtlasEnv
            // 
            labAtlasEnv.AutoSize = true;
            labAtlasEnv.BackColor = SystemColors.InfoText;
            labAtlasEnv.Font = new Font("Sitka Small", 9.857143F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labAtlasEnv.ForeColor = SystemColors.AppWorkspace;
            labAtlasEnv.ImageAlign = ContentAlignment.BottomCenter;
            labAtlasEnv.Location = new Point(37, 528);
            labAtlasEnv.Name = "labAtlasEnv";
            labAtlasEnv.Size = new Size(175, 35);
            labAtlasEnv.TabIndex = 7;
            labAtlasEnv.Text = "Environment";
            // 
            // btnScriptMigrationClear
            // 
            btnScriptMigrationClear.Location = new Point(763, 158);
            btnScriptMigrationClear.Name = "btnScriptMigrationClear";
            btnScriptMigrationClear.Size = new Size(170, 40);
            btnScriptMigrationClear.TabIndex = 4;
            btnScriptMigrationClear.Text = "Clear Tables";
            btnScriptMigrationClear.UseVisualStyleBackColor = true;
            btnScriptMigrationClear.Click += btnScriptMigrationClear_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InfoText;
            ClientSize = new Size(1178, 660);
            Controls.Add(btnAtlasNewRun);
            Controls.Add(btnAtlasHashRun);
            Controls.Add(btnAtlasCopyRun);
            Controls.Add(btnAtlasCmdRun);
            Controls.Add(labAtlasSubPath);
            Controls.Add(labAtlasScriptName);
            Controls.Add(labAtlasWorkingPath);
            Controls.Add(labAtlasEnv);
            Controls.Add(labAtlasCommand);
            Controls.Add(txtAtlasSubPath);
            Controls.Add(txtAtlasScriptName);
            Controls.Add(txtAtlasWorkingPath);
            Controls.Add(txtAtlasEnvironment);
            Controls.Add(txtAtlasCommand);
            Controls.Add(btnScriptMigrationClear);
            Controls.Add(btnScriptMigrationRun);
            Controls.Add(labScriptMigrationPath);
            Controls.Add(laxAtlasTitle);
            Controls.Add(labMigrationTitle);
            Controls.Add(txtScriptMigrationPath);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "DB Octopus 1.0.1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtScriptMigrationPath;
        private Label labMigrationTitle;
        private Button btnScriptMigrationRun;
        private Label labScriptMigrationPath;
        private Button btnAtlasCmdRun;
        private Label labAtlasCommand;
        private TextBox txtAtlasCommand;
        private Label laxAtlasTitle;
        private Label labAtlasWorkingPath;
        private TextBox txtAtlasWorkingPath;
        private Label labAtlasScriptName;
        private TextBox txtAtlasScriptName;
        private TextBox txtAtlasSubPath;
        private Label labAtlasSubPath;
        private Button btnAtlasNewRun;
        private Button btnAtlasCopyRun;
        private Button btnAtlasHashRun;
        private TextBox txtAtlasEnvironment;
        private Label labAtlasEnv;
        private Button btnScriptMigrationClear;
    }
}
