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
            txtScriptMigrationPath = new TextBox();
            labMigrationTitle = new Label();
            btxScriptMigrationRun = new Button();
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
            // btxScriptMigrationRun
            // 
            btxScriptMigrationRun.Location = new Point(1152, 88);
            btxScriptMigrationRun.Name = "btxScriptMigrationRun";
            btxScriptMigrationRun.Size = new Size(170, 40);
            btxScriptMigrationRun.TabIndex = 4;
            btxScriptMigrationRun.Text = "Execute Scripts";
            btxScriptMigrationRun.UseVisualStyleBackColor = true;
            btxScriptMigrationRun.Click += btxScriptMigrationRun_Click;
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
            btnAtlasCmdRun.Location = new Point(446, 466);
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
            labAtlasCommand.Location = new Point(37, 381);
            labAtlasCommand.Name = "labAtlasCommand";
            labAtlasCommand.Size = new Size(136, 35);
            labAtlasCommand.TabIndex = 7;
            labAtlasCommand.Text = "Command";
            // 
            // txtAtlasCommand
            // 
            txtAtlasCommand.Location = new Point(270, 381);
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
            laxAtlasTitle.Location = new Point(37, 191);
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
            labAtlasWorkingPath.Location = new Point(37, 319);
            labAtlasWorkingPath.Name = "labAtlasWorkingPath";
            labAtlasWorkingPath.Size = new Size(179, 35);
            labAtlasWorkingPath.TabIndex = 7;
            labAtlasWorkingPath.Text = "Working Path";
            // 
            // txtAtlasWorkingPath
            // 
            txtAtlasWorkingPath.Location = new Point(270, 321);
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
            labAtlasScriptName.Location = new Point(37, 261);
            labAtlasScriptName.Name = "labAtlasScriptName";
            labAtlasScriptName.Size = new Size(165, 35);
            labAtlasScriptName.TabIndex = 7;
            labAtlasScriptName.Text = "Script Name";
            // 
            // txtAtlasScriptName
            // 
            txtAtlasScriptName.Location = new Point(270, 261);
            txtAtlasScriptName.Name = "txtAtlasScriptName";
            txtAtlasScriptName.Size = new Size(353, 35);
            txtAtlasScriptName.TabIndex = 5;
            txtAtlasScriptName.KeyDown += txtAtlasScriptName_KeyDown;
            // 
            // txtAtlasSubPath
            // 
            txtAtlasSubPath.Location = new Point(791, 261);
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
            labAtlasSubPath.Location = new Point(651, 261);
            labAtlasSubPath.Name = "labAtlasSubPath";
            labAtlasSubPath.Size = new Size(119, 35);
            labAtlasSubPath.TabIndex = 7;
            labAtlasSubPath.Text = "Sub Path";
            // 
            // btnAtlasNewRun
            // 
            btnAtlasNewRun.Location = new Point(153, 466);
            btnAtlasNewRun.Name = "btnAtlasNewRun";
            btnAtlasNewRun.Size = new Size(151, 40);
            btnAtlasNewRun.TabIndex = 8;
            btnAtlasNewRun.Text = "New";
            btnAtlasNewRun.UseVisualStyleBackColor = true;
            btnAtlasNewRun.Click += btnAtlasDiffRun_Click;
            // 
            // btnAtlasCopyRun
            // 
            btnAtlasCopyRun.Location = new Point(720, 466);
            btnAtlasCopyRun.Name = "btnAtlasCopyRun";
            btnAtlasCopyRun.Size = new Size(151, 40);
            btnAtlasCopyRun.TabIndex = 8;
            btnAtlasCopyRun.Text = "Copy";
            btnAtlasCopyRun.UseVisualStyleBackColor = true;
            btnAtlasCopyRun.Click += btnAtlasCopyRun_Click;
            // 
            // btnAtlasHashRun
            // 
            btnAtlasHashRun.Location = new Point(1004, 466);
            btnAtlasHashRun.Name = "btnAtlasHashRun";
            btnAtlasHashRun.Size = new Size(151, 40);
            btnAtlasHashRun.TabIndex = 8;
            btnAtlasHashRun.Text = "Hash";
            btnAtlasHashRun.UseVisualStyleBackColor = true;
            btnAtlasHashRun.Click += btnAtlasDiffRun_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InfoText;
            ClientSize = new Size(1354, 572);
            Controls.Add(btnAtlasNewRun);
            Controls.Add(btnAtlasHashRun);
            Controls.Add(btnAtlasCopyRun);
            Controls.Add(btnAtlasCmdRun);
            Controls.Add(labAtlasSubPath);
            Controls.Add(labAtlasScriptName);
            Controls.Add(labAtlasWorkingPath);
            Controls.Add(labAtlasCommand);
            Controls.Add(txtAtlasSubPath);
            Controls.Add(txtAtlasScriptName);
            Controls.Add(txtAtlasWorkingPath);
            Controls.Add(txtAtlasCommand);
            Controls.Add(btxScriptMigrationRun);
            Controls.Add(labScriptMigrationPath);
            Controls.Add(laxAtlasTitle);
            Controls.Add(labMigrationTitle);
            Controls.Add(txtScriptMigrationPath);
            Name = "Form1";
            Text = "DB Octopus 1.0.0";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtScriptMigrationPath;
        private Label labMigrationTitle;
        private Button btxScriptMigrationRun;
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
    }
}
