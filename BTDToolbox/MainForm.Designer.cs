﻿namespace BTDToolbox
{
    partial class TD_Toolbox_Window
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TD_Toolbox_Window));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.File_ToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.New_ToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.New_BTD5_Proj = new System.Windows.Forms.ToolStripMenuItem();
            this.New_BTDB_Proj = new System.Windows.Forms.ToolStripMenuItem();
            this.NewProject_From_Backup = new System.Windows.Forms.ToolStripMenuItem();
            this.btdpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.Open_Existing_JetFile = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenExistingProject = new System.Windows.Forms.ToolStripMenuItem();
            this.openRecentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Find_Button = new System.Windows.Forms.ToolStripMenuItem();
            this.Replace_Button = new System.Windows.Forms.ToolStripMenuItem();
            this.Launch_Program_ToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ToggleConsole = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenJetExplorer = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RestoreBackup = new System.Windows.Forms.ToolStripMenuItem();
            this.remakeBackupjetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Credits = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.debugToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.themedFormToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nullJetFormToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.versionTag = new System.Windows.Forms.Label();
            this.spriteEditingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.spriteSheetDecompilerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.spriteAnimationVisualizerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contactUsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.File_ToolStrip,
            this.viewToolStripMenuItem,
            this.Launch_Program_ToolStrip,
            this.viewToolStripMenuItem1,
            this.helpToolStripMenuItem,
            this.debugToolStripMenuItem,
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1483, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "File";
            // 
            // File_ToolStrip
            // 
            this.File_ToolStrip.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.New_ToolStrip,
            this.openToolStripMenuItem1,
            this.openRecentToolStripMenuItem,
            this.settingsToolStripMenuItem,
            this.saveToolStripMenuItem});
            this.File_ToolStrip.ForeColor = System.Drawing.Color.White;
            this.File_ToolStrip.Name = "File_ToolStrip";
            this.File_ToolStrip.Size = new System.Drawing.Size(37, 20);
            this.File_ToolStrip.Text = "File";
            // 
            // New_ToolStrip
            // 
            this.New_ToolStrip.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.New_BTD5_Proj,
            this.New_BTDB_Proj,
            this.NewProject_From_Backup,
            this.btdpToolStripMenuItem});
            this.New_ToolStrip.Name = "New_ToolStrip";
            this.New_ToolStrip.Size = new System.Drawing.Size(180, 22);
            this.New_ToolStrip.Text = "New";
            // 
            // New_BTD5_Proj
            // 
            this.New_BTD5_Proj.Name = "New_BTD5_Proj";
            this.New_BTD5_Proj.Size = new System.Drawing.Size(180, 22);
            this.New_BTD5_Proj.Text = "BTD5 Project";
            this.New_BTD5_Proj.Click += new System.EventHandler(this.New_BTD5_Proj_Click);
            // 
            // New_BTDB_Proj
            // 
            this.New_BTDB_Proj.Name = "New_BTDB_Proj";
            this.New_BTDB_Proj.Size = new System.Drawing.Size(180, 22);
            this.New_BTDB_Proj.Text = "BTD Battles Project";
            this.New_BTDB_Proj.Click += new System.EventHandler(this.New_BTDB_Proj_Click);
            // 
            // NewProject_From_Backup
            // 
            this.NewProject_From_Backup.Name = "NewProject_From_Backup";
            this.NewProject_From_Backup.Size = new System.Drawing.Size(180, 22);
            this.NewProject_From_Backup.Text = "Project from .jet";
            this.NewProject_From_Backup.Click += new System.EventHandler(this.NewProject_From_Backup_Click);
            // 
            // btdpToolStripMenuItem
            // 
            this.btdpToolStripMenuItem.Name = "btdpToolStripMenuItem";
            this.btdpToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.btdpToolStripMenuItem.Text = "Project from .btdp";
            // 
            // openToolStripMenuItem1
            // 
            this.openToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Open_Existing_JetFile,
            this.OpenExistingProject});
            this.openToolStripMenuItem1.Name = "openToolStripMenuItem1";
            this.openToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.openToolStripMenuItem1.Text = "Open";
            // 
            // Open_Existing_JetFile
            // 
            this.Open_Existing_JetFile.Name = "Open_Existing_JetFile";
            this.Open_Existing_JetFile.Size = new System.Drawing.Size(180, 22);
            this.Open_Existing_JetFile.Text = "Existing .jet";
            this.Open_Existing_JetFile.Click += new System.EventHandler(this.Open_Existing_JetFile_Click);
            // 
            // OpenExistingProject
            // 
            this.OpenExistingProject.Name = "OpenExistingProject";
            this.OpenExistingProject.Size = new System.Drawing.Size(180, 22);
            this.OpenExistingProject.Text = "Existing project";
            this.OpenExistingProject.Click += new System.EventHandler(this.OpenExistingProject_Click);
            // 
            // openRecentToolStripMenuItem
            // 
            this.openRecentToolStripMenuItem.Name = "openRecentToolStripMenuItem";
            this.openRecentToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.openRecentToolStripMenuItem.Text = "Open Recent";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.SaveToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Find_Button,
            this.Replace_Button});
            this.viewToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.viewToolStripMenuItem.Text = "Edit";
            // 
            // Find_Button
            // 
            this.Find_Button.Name = "Find_Button";
            this.Find_Button.Size = new System.Drawing.Size(115, 22);
            this.Find_Button.Text = "Find";
            this.Find_Button.Click += new System.EventHandler(this.Find_Button_Click);
            // 
            // Replace_Button
            // 
            this.Replace_Button.Name = "Replace_Button";
            this.Replace_Button.Size = new System.Drawing.Size(115, 22);
            this.Replace_Button.Text = "Replace";
            this.Replace_Button.Click += new System.EventHandler(this.Replace_Button_Click);
            // 
            // Launch_Program_ToolStrip
            // 
            this.Launch_Program_ToolStrip.ForeColor = System.Drawing.Color.White;
            this.Launch_Program_ToolStrip.Name = "Launch_Program_ToolStrip";
            this.Launch_Program_ToolStrip.Size = new System.Drawing.Size(73, 20);
            this.Launch_Program_ToolStrip.Text = "Launch 🚀";
            this.Launch_Program_ToolStrip.Click += new System.EventHandler(this.LaunchProgram_Click);
            // 
            // viewToolStripMenuItem1
            // 
            this.viewToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToggleConsole,
            this.OpenJetExplorer});
            this.viewToolStripMenuItem1.ForeColor = System.Drawing.Color.White;
            this.viewToolStripMenuItem1.Name = "viewToolStripMenuItem1";
            this.viewToolStripMenuItem1.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem1.Text = "View";
            // 
            // ToggleConsole
            // 
            this.ToggleConsole.Name = "ToggleConsole";
            this.ToggleConsole.Size = new System.Drawing.Size(180, 22);
            this.ToggleConsole.Text = "Console";
            this.ToggleConsole.Click += new System.EventHandler(this.ToggleConsole_Click);
            // 
            // OpenJetExplorer
            // 
            this.OpenJetExplorer.Name = "OpenJetExplorer";
            this.OpenJetExplorer.Size = new System.Drawing.Size(180, 22);
            this.OpenJetExplorer.Text = "Jet Explorer";
            this.OpenJetExplorer.Click += new System.EventHandler(this.OpenJetExplorer_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.RestoreBackup,
            this.remakeBackupjetToolStripMenuItem,
            this.contactUsToolStripMenuItem,
            this.Credits});
            this.helpToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // RestoreBackup
            // 
            this.RestoreBackup.Name = "RestoreBackup";
            this.RestoreBackup.Size = new System.Drawing.Size(224, 22);
            this.RestoreBackup.Text = "Restore game  .jet to backup";
            this.RestoreBackup.Click += new System.EventHandler(this.RestoreBackup_Click);
            // 
            // remakeBackupjetToolStripMenuItem
            // 
            this.remakeBackupjetToolStripMenuItem.Name = "remakeBackupjetToolStripMenuItem";
            this.remakeBackupjetToolStripMenuItem.Size = new System.Drawing.Size(224, 22);
            this.remakeBackupjetToolStripMenuItem.Text = "Get a new backup  .jet";
            this.remakeBackupjetToolStripMenuItem.Click += new System.EventHandler(this.RemakeBackupjetToolStripMenuItem_Click);
            // 
            // Credits
            // 
            this.Credits.Name = "Credits";
            this.Credits.Size = new System.Drawing.Size(224, 22);
            this.Credits.Text = "Credits";
            this.Credits.Click += new System.EventHandler(this.OpenCredits_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.toolStripMenuItem3,
            this.spriteEditingToolStripMenuItem});
            this.toolStripMenuItem1.ForeColor = System.Drawing.Color.White;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(79, 20);
            this.toolStripMenuItem1.Text = "Other Tools";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem2.Text = "Mod Loader";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem3.Text = "NKHook";
            // 
            // debugToolStripMenuItem
            // 
            this.debugToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.themedFormToolStripMenuItem,
            this.nullJetFormToolStripMenuItem});
            this.debugToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.debugToolStripMenuItem.Name = "debugToolStripMenuItem";
            this.debugToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.debugToolStripMenuItem.Text = "Debug";
            // 
            // themedFormToolStripMenuItem
            // 
            this.themedFormToolStripMenuItem.Name = "themedFormToolStripMenuItem";
            this.themedFormToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.themedFormToolStripMenuItem.Text = "Themed Form";
            this.themedFormToolStripMenuItem.Click += new System.EventHandler(this.Debug_ThemedForm_Click);
            // 
            // nullJetFormToolStripMenuItem
            // 
            this.nullJetFormToolStripMenuItem.Name = "nullJetFormToolStripMenuItem";
            this.nullJetFormToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            // 
            // versionTag
            // 
            this.versionTag.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.versionTag.AutoSize = true;
            this.versionTag.BackColor = System.Drawing.Color.Transparent;
            this.versionTag.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.versionTag.ForeColor = System.Drawing.Color.White;
            this.versionTag.Location = new System.Drawing.Point(12, 677);
            this.versionTag.Name = "versionTag";
            this.versionTag.Size = new System.Drawing.Size(98, 55);
            this.versionTag.TabIndex = 3;
            this.versionTag.Text = "null";
            // 
            // spriteEditingToolStripMenuItem
            // 
            this.spriteEditingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.spriteSheetDecompilerToolStripMenuItem,
            this.spriteAnimationVisualizerToolStripMenuItem});
            this.spriteEditingToolStripMenuItem.Name = "spriteEditingToolStripMenuItem";
            this.spriteEditingToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.spriteEditingToolStripMenuItem.Text = "Sprite Editing";
            // 
            // spriteSheetDecompilerToolStripMenuItem
            // 
            this.spriteSheetDecompilerToolStripMenuItem.Name = "spriteSheetDecompilerToolStripMenuItem";
            this.spriteSheetDecompilerToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.spriteSheetDecompilerToolStripMenuItem.Text = "Sprite Sheet Decompiler";
            // 
            // spriteAnimationVisualizerToolStripMenuItem
            // 
            this.spriteAnimationVisualizerToolStripMenuItem.Name = "spriteAnimationVisualizerToolStripMenuItem";
            this.spriteAnimationVisualizerToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.spriteAnimationVisualizerToolStripMenuItem.Text = "Sprite/Animation Visualizer";
            // 
            // contactUsToolStripMenuItem
            // 
            this.contactUsToolStripMenuItem.Name = "contactUsToolStripMenuItem";
            this.contactUsToolStripMenuItem.Size = new System.Drawing.Size(224, 22);
            this.contactUsToolStripMenuItem.Text = "Contact Us";
            // 
            // TD_Toolbox_Window
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1483, 741);
            this.Controls.Add(this.versionTag);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "TD_Toolbox_Window";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Toolbox - Made by DisabledMallis and Gurrenm3";
            this.Load += new System.EventHandler(this.TD_Toolbox_Window_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TD_Toolbox_Window_KeyDown);
            this.Resize += new System.EventHandler(this.TD_Toolbox_Window_Resize);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem File_ToolStrip;
        private System.Windows.Forms.ToolStripMenuItem New_ToolStrip;
        private System.Windows.Forms.ToolStripMenuItem btdpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Launch_Program_ToolStrip;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ToggleConsole;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem RestoreBackup;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem OpenExistingProject;
        private System.Windows.Forms.ToolStripMenuItem debugToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Find_Button;
        private System.Windows.Forms.ToolStripMenuItem Replace_Button;
        private System.Windows.Forms.ToolStripMenuItem Credits;
        private System.Windows.Forms.ToolStripMenuItem openRecentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OpenJetExplorer;
        private System.Windows.Forms.ToolStripMenuItem nullJetFormToolStripMenuItem;
        private System.Windows.Forms.Label versionTag;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem NewProject_From_Backup;
        private System.Windows.Forms.ToolStripMenuItem remakeBackupjetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Open_Existing_JetFile;
        private System.Windows.Forms.ToolStripMenuItem New_BTD5_Proj;
        private System.Windows.Forms.ToolStripMenuItem New_BTDB_Proj;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem themedFormToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem spriteEditingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem spriteSheetDecompilerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem spriteAnimationVisualizerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contactUsToolStripMenuItem;
    }
}

