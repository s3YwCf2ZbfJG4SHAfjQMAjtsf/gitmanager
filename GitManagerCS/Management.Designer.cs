namespace GitManager
{
    partial class Management
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
            this.btnSave = new System.Windows.Forms.Button();
            this.dgvProjects = new System.Windows.Forms.DataGridView();
            this.ProjectName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProjectGuid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OutputFileName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblProjects = new System.Windows.Forms.Label();
            this.txtProjectGuid = new System.Windows.Forms.TextBox();
            this.lblProjectGuid = new System.Windows.Forms.Label();
            this.pnlProjects = new System.Windows.Forms.Panel();
            this.btnProjectClear = new System.Windows.Forms.Button();
            this.chkProjectActive = new System.Windows.Forms.CheckBox();
            this.txtProjectOutputFileName = new System.Windows.Forms.TextBox();
            this.lblProjectOutputFileName = new System.Windows.Forms.Label();
            this.btnSaveProject = new System.Windows.Forms.Button();
            this.txtProjectName = new System.Windows.Forms.TextBox();
            this.lblProjectName = new System.Windows.Forms.Label();
            this.lblAddProject = new System.Windows.Forms.Label();
            this.btnProjectGuidGenerator = new System.Windows.Forms.Button();
            this.pnlBranches = new System.Windows.Forms.Panel();
            this.chkBranchActive = new System.Windows.Forms.CheckBox();
            this.lblBranchMergeFrom = new System.Windows.Forms.Label();
            this.cbBranchMergeFromBranch = new System.Windows.Forms.ComboBox();
            this.chkBranchPullFirst = new System.Windows.Forms.CheckBox();
            this.chkBranchUndoAnyChanges = new System.Windows.Forms.CheckBox();
            this.rbBranchAppliesTo = new System.Windows.Forms.GroupBox();
            this.rdBranchAppliesToClearRepositoryBranches = new System.Windows.Forms.RadioButton();
            this.rdBranchAppliesToAllRepositoriesInCurrentProject = new System.Windows.Forms.RadioButton();
            this.rdBranchEditMode = new System.Windows.Forms.RadioButton();
            this.chklBranchesAppliesToSpecificRepositories = new System.Windows.Forms.CheckedListBox();
            this.rdBranchAppliesToAllRepositoriesAllProjects = new System.Windows.Forms.RadioButton();
            this.rdBranchAppliesToSpecificRepositories = new System.Windows.Forms.RadioButton();
            this.btnBranchClear = new System.Windows.Forms.Button();
            this.btnSaveBranch = new System.Windows.Forms.Button();
            this.dgvBranches = new System.Windows.Forms.DataGridView();
            this.Repository = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BranchName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BranchGuid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtBranchName = new System.Windows.Forms.TextBox();
            this.lblAddBranch = new System.Windows.Forms.Label();
            this.lblBranchName = new System.Windows.Forms.Label();
            this.txtBranchGuid = new System.Windows.Forms.TextBox();
            this.lblBranchGuid = new System.Windows.Forms.Label();
            this.btnBranchGenerateGuid = new System.Windows.Forms.Button();
            this.btnBuildBashFile = new System.Windows.Forms.Button();
            this.lblBranches = new System.Windows.Forms.Label();
            this.lblRepositories = new System.Windows.Forms.Label();
            this.pnlRepositories = new System.Windows.Forms.Panel();
            this.lblRepositoryBranches = new System.Windows.Forms.Label();
            this.chklRepositoryBranches = new System.Windows.Forms.CheckedListBox();
            this.btnRepositoryClear = new System.Windows.Forms.Button();
            this.chkRepositoryActive = new System.Windows.Forms.CheckBox();
            this.chkRepositoryPerformPruneAtEnd = new System.Windows.Forms.CheckBox();
            this.txtRepositoryFolderPath = new System.Windows.Forms.TextBox();
            this.lblRepositoryFolderPath = new System.Windows.Forms.Label();
            this.btnSaveRepository = new System.Windows.Forms.Button();
            this.dgvRepositories = new System.Windows.Forms.DataGridView();
            this.RepositoryName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RepositoryGuid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FolderPath = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtRepositoryName = new System.Windows.Forms.TextBox();
            this.lblAddRepository = new System.Windows.Forms.Label();
            this.lblRepositoryName = new System.Windows.Forms.Label();
            this.txtRepositoryGuid = new System.Windows.Forms.TextBox();
            this.lblRepositoryGuid = new System.Windows.Forms.Label();
            this.btnRepositoryGuidGenerator = new System.Windows.Forms.Button();
            this.btnView = new System.Windows.Forms.Button();
            this.btnViewBashFile = new System.Windows.Forms.Button();
            this.lblGitCommands = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtGitCommandCode = new System.Windows.Forms.TextBox();
            this.lblGitCommandCode = new System.Windows.Forms.Label();
            this.btnGitCommandsClear = new System.Windows.Forms.Button();
            this.chkGitCommandActive = new System.Windows.Forms.CheckBox();
            this.txtGitCommandValue = new System.Windows.Forms.TextBox();
            this.lblGitCommandValue = new System.Windows.Forms.Label();
            this.btnGitCommandsSave = new System.Windows.Forms.Button();
            this.txtGitCommandName = new System.Windows.Forms.TextBox();
            this.lblGitCommandName = new System.Windows.Forms.Label();
            this.lblGitCommandsAddEdit = new System.Windows.Forms.Label();
            this.btnGitCommandsGenerateGuid = new System.Windows.Forms.Button();
            this.lblGitCommandGuid = new System.Windows.Forms.Label();
            this.dgvGitCommands = new System.Windows.Forms.DataGridView();
            this.txtGitCommandGuid = new System.Windows.Forms.TextBox();
            this.GitCommandName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GitCommandValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GitCommandActive = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GitCommandCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GitCommandGuid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProjects)).BeginInit();
            this.pnlProjects.SuspendLayout();
            this.pnlBranches.SuspendLayout();
            this.rbBranchAppliesTo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBranches)).BeginInit();
            this.pnlRepositories.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRepositories)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGitCommands)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(1431, 109);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(188, 44);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // dgvProjects
            // 
            this.dgvProjects.AllowUserToAddRows = false;
            this.dgvProjects.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProjects.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProjectName,
            this.ProjectGuid,
            this.OutputFileName});
            this.dgvProjects.Location = new System.Drawing.Point(19, 16);
            this.dgvProjects.MultiSelect = false;
            this.dgvProjects.Name = "dgvProjects";
            this.dgvProjects.RowTemplate.Height = 33;
            this.dgvProjects.Size = new System.Drawing.Size(418, 137);
            this.dgvProjects.TabIndex = 1;
            this.dgvProjects.SelectionChanged += new System.EventHandler(this.dgvProjects_SelectionChanged);
            // 
            // ProjectName
            // 
            this.ProjectName.DataPropertyName = "EntityName";
            this.ProjectName.HeaderText = "Name";
            this.ProjectName.Name = "ProjectName";
            this.ProjectName.Width = 75;
            // 
            // ProjectGuid
            // 
            this.ProjectGuid.DataPropertyName = "EntityGuid";
            this.ProjectGuid.HeaderText = "Guid";
            this.ProjectGuid.Name = "ProjectGuid";
            this.ProjectGuid.Visible = false;
            // 
            // OutputFileName
            // 
            this.OutputFileName.DataPropertyName = "OutputFileName";
            this.OutputFileName.HeaderText = "Output FileName";
            this.OutputFileName.Name = "OutputFileName";
            this.OutputFileName.Width = 250;
            // 
            // lblProjects
            // 
            this.lblProjects.AutoSize = true;
            this.lblProjects.Location = new System.Drawing.Point(26, 9);
            this.lblProjects.Name = "lblProjects";
            this.lblProjects.Size = new System.Drawing.Size(90, 25);
            this.lblProjects.TabIndex = 2;
            this.lblProjects.Text = "Projects";
            // 
            // txtProjectGuid
            // 
            this.txtProjectGuid.Location = new System.Drawing.Point(654, 112);
            this.txtProjectGuid.Name = "txtProjectGuid";
            this.txtProjectGuid.Size = new System.Drawing.Size(463, 31);
            this.txtProjectGuid.TabIndex = 4;
            // 
            // lblProjectGuid
            // 
            this.lblProjectGuid.AutoSize = true;
            this.lblProjectGuid.Location = new System.Drawing.Point(474, 109);
            this.lblProjectGuid.Name = "lblProjectGuid";
            this.lblProjectGuid.Size = new System.Drawing.Size(57, 25);
            this.lblProjectGuid.TabIndex = 4;
            this.lblProjectGuid.Text = "Guid";
            // 
            // pnlProjects
            // 
            this.pnlProjects.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pnlProjects.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlProjects.Controls.Add(this.btnProjectClear);
            this.pnlProjects.Controls.Add(this.chkProjectActive);
            this.pnlProjects.Controls.Add(this.txtProjectOutputFileName);
            this.pnlProjects.Controls.Add(this.lblProjectOutputFileName);
            this.pnlProjects.Controls.Add(this.btnSaveProject);
            this.pnlProjects.Controls.Add(this.txtProjectName);
            this.pnlProjects.Controls.Add(this.lblProjectName);
            this.pnlProjects.Controls.Add(this.lblAddProject);
            this.pnlProjects.Controls.Add(this.btnProjectGuidGenerator);
            this.pnlProjects.Controls.Add(this.lblProjectGuid);
            this.pnlProjects.Controls.Add(this.dgvProjects);
            this.pnlProjects.Controls.Add(this.txtProjectGuid);
            this.pnlProjects.Location = new System.Drawing.Point(31, 46);
            this.pnlProjects.Name = "pnlProjects";
            this.pnlProjects.Size = new System.Drawing.Size(1352, 207);
            this.pnlProjects.TabIndex = 5;
            // 
            // btnProjectClear
            // 
            this.btnProjectClear.Location = new System.Drawing.Point(1140, 137);
            this.btnProjectClear.Name = "btnProjectClear";
            this.btnProjectClear.Size = new System.Drawing.Size(80, 31);
            this.btnProjectClear.TabIndex = 7;
            this.btnProjectClear.Text = "Clear";
            this.btnProjectClear.UseVisualStyleBackColor = true;
            this.btnProjectClear.Click += new System.EventHandler(this.btnProjectClear_Click);
            // 
            // chkProjectActive
            // 
            this.chkProjectActive.AutoSize = true;
            this.chkProjectActive.Location = new System.Drawing.Point(869, 66);
            this.chkProjectActive.Name = "chkProjectActive";
            this.chkProjectActive.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chkProjectActive.Size = new System.Drawing.Size(103, 29);
            this.chkProjectActive.TabIndex = 3;
            this.chkProjectActive.Text = "Active";
            this.chkProjectActive.UseVisualStyleBackColor = true;
            // 
            // txtProjectOutputFileName
            // 
            this.txtProjectOutputFileName.Location = new System.Drawing.Point(654, 160);
            this.txtProjectOutputFileName.Name = "txtProjectOutputFileName";
            this.txtProjectOutputFileName.Size = new System.Drawing.Size(463, 31);
            this.txtProjectOutputFileName.TabIndex = 5;
            // 
            // lblProjectOutputFileName
            // 
            this.lblProjectOutputFileName.AutoSize = true;
            this.lblProjectOutputFileName.Location = new System.Drawing.Point(474, 160);
            this.lblProjectOutputFileName.Name = "lblProjectOutputFileName";
            this.lblProjectOutputFileName.Size = new System.Drawing.Size(173, 25);
            this.lblProjectOutputFileName.TabIndex = 10;
            this.lblProjectOutputFileName.Text = "Output FileName";
            // 
            // btnSaveProject
            // 
            this.btnSaveProject.Location = new System.Drawing.Point(1235, 137);
            this.btnSaveProject.Name = "btnSaveProject";
            this.btnSaveProject.Size = new System.Drawing.Size(97, 31);
            this.btnSaveProject.TabIndex = 6;
            this.btnSaveProject.Text = "Save";
            this.btnSaveProject.UseVisualStyleBackColor = true;
            this.btnSaveProject.Click += new System.EventHandler(this.btnSaveProject_Click);
            // 
            // txtProjectName
            // 
            this.txtProjectName.Location = new System.Drawing.Point(654, 66);
            this.txtProjectName.Name = "txtProjectName";
            this.txtProjectName.Size = new System.Drawing.Size(204, 31);
            this.txtProjectName.TabIndex = 2;
            // 
            // lblProjectName
            // 
            this.lblProjectName.AutoSize = true;
            this.lblProjectName.Location = new System.Drawing.Point(474, 63);
            this.lblProjectName.Name = "lblProjectName";
            this.lblProjectName.Size = new System.Drawing.Size(68, 25);
            this.lblProjectName.TabIndex = 7;
            this.lblProjectName.Text = "Name";
            // 
            // lblAddProject
            // 
            this.lblAddProject.AutoSize = true;
            this.lblAddProject.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddProject.Location = new System.Drawing.Point(472, 16);
            this.lblAddProject.Name = "lblAddProject";
            this.lblAddProject.Size = new System.Drawing.Size(139, 37);
            this.lblAddProject.TabIndex = 6;
            this.lblAddProject.Text = "Add/Edit";
            // 
            // btnProjectGuidGenerator
            // 
            this.btnProjectGuidGenerator.Location = new System.Drawing.Point(1140, 80);
            this.btnProjectGuidGenerator.Name = "btnProjectGuidGenerator";
            this.btnProjectGuidGenerator.Size = new System.Drawing.Size(192, 31);
            this.btnProjectGuidGenerator.TabIndex = 9;
            this.btnProjectGuidGenerator.Text = "Generate Guid";
            this.btnProjectGuidGenerator.UseVisualStyleBackColor = true;
            this.btnProjectGuidGenerator.Click += new System.EventHandler(this.btnProjectGuidGenerator_Click);
            // 
            // pnlBranches
            // 
            this.pnlBranches.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pnlBranches.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlBranches.Controls.Add(this.chkBranchActive);
            this.pnlBranches.Controls.Add(this.lblBranchMergeFrom);
            this.pnlBranches.Controls.Add(this.cbBranchMergeFromBranch);
            this.pnlBranches.Controls.Add(this.chkBranchPullFirst);
            this.pnlBranches.Controls.Add(this.chkBranchUndoAnyChanges);
            this.pnlBranches.Controls.Add(this.rbBranchAppliesTo);
            this.pnlBranches.Controls.Add(this.btnBranchClear);
            this.pnlBranches.Controls.Add(this.btnSaveBranch);
            this.pnlBranches.Controls.Add(this.dgvBranches);
            this.pnlBranches.Controls.Add(this.txtBranchName);
            this.pnlBranches.Controls.Add(this.lblAddBranch);
            this.pnlBranches.Controls.Add(this.lblBranchName);
            this.pnlBranches.Controls.Add(this.txtBranchGuid);
            this.pnlBranches.Controls.Add(this.lblBranchGuid);
            this.pnlBranches.Controls.Add(this.btnBranchGenerateGuid);
            this.pnlBranches.Location = new System.Drawing.Point(31, 705);
            this.pnlBranches.Name = "pnlBranches";
            this.pnlBranches.Size = new System.Drawing.Size(1962, 496);
            this.pnlBranches.TabIndex = 6;
            // 
            // chkBranchActive
            // 
            this.chkBranchActive.AutoSize = true;
            this.chkBranchActive.Location = new System.Drawing.Point(869, 66);
            this.chkBranchActive.Name = "chkBranchActive";
            this.chkBranchActive.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chkBranchActive.Size = new System.Drawing.Size(103, 29);
            this.chkBranchActive.TabIndex = 33;
            this.chkBranchActive.Text = "Active";
            this.chkBranchActive.UseVisualStyleBackColor = true;
            // 
            // lblBranchMergeFrom
            // 
            this.lblBranchMergeFrom.AutoSize = true;
            this.lblBranchMergeFrom.Location = new System.Drawing.Point(730, 192);
            this.lblBranchMergeFrom.Name = "lblBranchMergeFrom";
            this.lblBranchMergeFrom.Size = new System.Drawing.Size(128, 25);
            this.lblBranchMergeFrom.TabIndex = 35;
            this.lblBranchMergeFrom.Text = "Merge From";
            // 
            // cbBranchMergeFromBranch
            // 
            this.cbBranchMergeFromBranch.DisplayMember = "EntityName";
            this.cbBranchMergeFromBranch.FormattingEnabled = true;
            this.cbBranchMergeFromBranch.ItemHeight = 25;
            this.cbBranchMergeFromBranch.Location = new System.Drawing.Point(869, 184);
            this.cbBranchMergeFromBranch.Name = "cbBranchMergeFromBranch";
            this.cbBranchMergeFromBranch.Size = new System.Drawing.Size(248, 33);
            this.cbBranchMergeFromBranch.TabIndex = 34;
            this.cbBranchMergeFromBranch.ValueMember = "EntityGuid";
            // 
            // chkBranchPullFirst
            // 
            this.chkBranchPullFirst.AutoSize = true;
            this.chkBranchPullFirst.Location = new System.Drawing.Point(474, 188);
            this.chkBranchPullFirst.Name = "chkBranchPullFirst";
            this.chkBranchPullFirst.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chkBranchPullFirst.Size = new System.Drawing.Size(128, 29);
            this.chkBranchPullFirst.TabIndex = 36;
            this.chkBranchPullFirst.Text = "Pull First";
            this.chkBranchPullFirst.UseVisualStyleBackColor = true;
            // 
            // chkBranchUndoAnyChanges
            // 
            this.chkBranchUndoAnyChanges.AutoSize = true;
            this.chkBranchUndoAnyChanges.Location = new System.Drawing.Point(474, 153);
            this.chkBranchUndoAnyChanges.Name = "chkBranchUndoAnyChanges";
            this.chkBranchUndoAnyChanges.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chkBranchUndoAnyChanges.Size = new System.Drawing.Size(230, 29);
            this.chkBranchUndoAnyChanges.TabIndex = 34;
            this.chkBranchUndoAnyChanges.Text = "Undo Any Changes";
            this.chkBranchUndoAnyChanges.UseVisualStyleBackColor = true;
            // 
            // rbBranchAppliesTo
            // 
            this.rbBranchAppliesTo.Controls.Add(this.rdBranchAppliesToClearRepositoryBranches);
            this.rbBranchAppliesTo.Controls.Add(this.rdBranchAppliesToAllRepositoriesInCurrentProject);
            this.rbBranchAppliesTo.Controls.Add(this.rdBranchEditMode);
            this.rbBranchAppliesTo.Controls.Add(this.chklBranchesAppliesToSpecificRepositories);
            this.rbBranchAppliesTo.Controls.Add(this.rdBranchAppliesToAllRepositoriesAllProjects);
            this.rbBranchAppliesTo.Controls.Add(this.rdBranchAppliesToSpecificRepositories);
            this.rbBranchAppliesTo.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.rbBranchAppliesTo.Location = new System.Drawing.Point(474, 243);
            this.rbBranchAppliesTo.Name = "rbBranchAppliesTo";
            this.rbBranchAppliesTo.Size = new System.Drawing.Size(1463, 235);
            this.rbBranchAppliesTo.TabIndex = 31;
            this.rbBranchAppliesTo.TabStop = false;
            this.rbBranchAppliesTo.Text = "Applies To";
            // 
            // rdBranchAppliesToClearRepositoryBranches
            // 
            this.rdBranchAppliesToClearRepositoryBranches.AutoSize = true;
            this.rdBranchAppliesToClearRepositoryBranches.Location = new System.Drawing.Point(352, 135);
            this.rdBranchAppliesToClearRepositoryBranches.Name = "rdBranchAppliesToClearRepositoryBranches";
            this.rdBranchAppliesToClearRepositoryBranches.Size = new System.Drawing.Size(296, 29);
            this.rdBranchAppliesToClearRepositoryBranches.TabIndex = 41;
            this.rdBranchAppliesToClearRepositoryBranches.TabStop = true;
            this.rdBranchAppliesToClearRepositoryBranches.Text = "Clear from all Repositories";
            this.rdBranchAppliesToClearRepositoryBranches.UseVisualStyleBackColor = true;
            // 
            // rdBranchAppliesToAllRepositoriesInCurrentProject
            // 
            this.rdBranchAppliesToAllRepositoriesInCurrentProject.AutoSize = true;
            this.rdBranchAppliesToAllRepositoriesInCurrentProject.Location = new System.Drawing.Point(352, 83);
            this.rdBranchAppliesToAllRepositoriesInCurrentProject.Name = "rdBranchAppliesToAllRepositoriesInCurrentProject";
            this.rdBranchAppliesToAllRepositoriesInCurrentProject.Size = new System.Drawing.Size(366, 29);
            this.rdBranchAppliesToAllRepositoriesInCurrentProject.TabIndex = 40;
            this.rdBranchAppliesToAllRepositoriesInCurrentProject.TabStop = true;
            this.rdBranchAppliesToAllRepositoriesInCurrentProject.Text = "All Repositories in Current Project";
            this.rdBranchAppliesToAllRepositoriesInCurrentProject.UseVisualStyleBackColor = true;
            // 
            // rdBranchEditMode
            // 
            this.rdBranchEditMode.AutoSize = true;
            this.rdBranchEditMode.Location = new System.Drawing.Point(192, 31);
            this.rdBranchEditMode.Name = "rdBranchEditMode";
            this.rdBranchEditMode.Size = new System.Drawing.Size(140, 29);
            this.rdBranchEditMode.TabIndex = 38;
            this.rdBranchEditMode.TabStop = true;
            this.rdBranchEditMode.Text = "Edit Mode";
            this.rdBranchEditMode.UseVisualStyleBackColor = true;
            this.rdBranchEditMode.CheckedChanged += new System.EventHandler(this.rdBranchEditMode_CheckedChanged);
            // 
            // chklBranchesAppliesToSpecificRepositories
            // 
            this.chklBranchesAppliesToSpecificRepositories.FormattingEnabled = true;
            this.chklBranchesAppliesToSpecificRepositories.Location = new System.Drawing.Point(761, 61);
            this.chklBranchesAppliesToSpecificRepositories.Name = "chklBranchesAppliesToSpecificRepositories";
            this.chklBranchesAppliesToSpecificRepositories.Size = new System.Drawing.Size(507, 186);
            this.chklBranchesAppliesToSpecificRepositories.TabIndex = 43;
            this.chklBranchesAppliesToSpecificRepositories.Visible = false;
            // 
            // rdBranchAppliesToAllRepositoriesAllProjects
            // 
            this.rdBranchAppliesToAllRepositoriesAllProjects.AutoSize = true;
            this.rdBranchAppliesToAllRepositoriesAllProjects.Location = new System.Drawing.Point(352, 31);
            this.rdBranchAppliesToAllRepositoriesAllProjects.Name = "rdBranchAppliesToAllRepositoriesAllProjects";
            this.rdBranchAppliesToAllRepositoriesAllProjects.Size = new System.Drawing.Size(330, 29);
            this.rdBranchAppliesToAllRepositoriesAllProjects.TabIndex = 39;
            this.rdBranchAppliesToAllRepositoriesAllProjects.TabStop = true;
            this.rdBranchAppliesToAllRepositoriesAllProjects.Text = "All Repositories in All Projects";
            this.rdBranchAppliesToAllRepositoriesAllProjects.UseVisualStyleBackColor = true;
            this.rdBranchAppliesToAllRepositoriesAllProjects.CheckedChanged += new System.EventHandler(this.rdBranchAppliesToAllRepositories_CheckedChanged);
            // 
            // rdBranchAppliesToSpecificRepositories
            // 
            this.rdBranchAppliesToSpecificRepositories.AutoSize = true;
            this.rdBranchAppliesToSpecificRepositories.Location = new System.Drawing.Point(761, 30);
            this.rdBranchAppliesToSpecificRepositories.Name = "rdBranchAppliesToSpecificRepositories";
            this.rdBranchAppliesToSpecificRepositories.Size = new System.Drawing.Size(245, 29);
            this.rdBranchAppliesToSpecificRepositories.TabIndex = 42;
            this.rdBranchAppliesToSpecificRepositories.TabStop = true;
            this.rdBranchAppliesToSpecificRepositories.Text = "Specific Repositories";
            this.rdBranchAppliesToSpecificRepositories.UseVisualStyleBackColor = true;
            this.rdBranchAppliesToSpecificRepositories.CheckedChanged += new System.EventHandler(this.rdBranchAppliesToSpecificRepositories_CheckedChanged);
            // 
            // btnBranchClear
            // 
            this.btnBranchClear.Location = new System.Drawing.Point(1705, 75);
            this.btnBranchClear.Name = "btnBranchClear";
            this.btnBranchClear.Size = new System.Drawing.Size(80, 31);
            this.btnBranchClear.TabIndex = 45;
            this.btnBranchClear.Text = "Clear";
            this.btnBranchClear.UseVisualStyleBackColor = true;
            this.btnBranchClear.Click += new System.EventHandler(this.btnBranchClear_Click);
            // 
            // btnSaveBranch
            // 
            this.btnSaveBranch.Location = new System.Drawing.Point(1821, 78);
            this.btnSaveBranch.Name = "btnSaveBranch";
            this.btnSaveBranch.Size = new System.Drawing.Size(76, 31);
            this.btnSaveBranch.TabIndex = 44;
            this.btnSaveBranch.Text = "Save";
            this.btnSaveBranch.UseVisualStyleBackColor = true;
            this.btnSaveBranch.Click += new System.EventHandler(this.btnSaveBranch_Click);
            // 
            // dgvBranches
            // 
            this.dgvBranches.AllowUserToAddRows = false;
            this.dgvBranches.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBranches.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Repository,
            this.BranchName,
            this.BranchGuid});
            this.dgvBranches.Location = new System.Drawing.Point(19, 13);
            this.dgvBranches.MultiSelect = false;
            this.dgvBranches.Name = "dgvBranches";
            this.dgvBranches.RowTemplate.Height = 33;
            this.dgvBranches.Size = new System.Drawing.Size(418, 465);
            this.dgvBranches.TabIndex = 30;
            this.dgvBranches.SelectionChanged += new System.EventHandler(this.dgvBranches_SelectionChanged);
            // 
            // Repository
            // 
            this.Repository.DataPropertyName = "Repository";
            this.Repository.HeaderText = "Repository";
            this.Repository.Name = "Repository";
            this.Repository.Visible = false;
            this.Repository.Width = 125;
            // 
            // BranchName
            // 
            this.BranchName.DataPropertyName = "Name";
            this.BranchName.HeaderText = "Name";
            this.BranchName.Name = "BranchName";
            this.BranchName.Width = 175;
            // 
            // BranchGuid
            // 
            this.BranchGuid.DataPropertyName = "Guid";
            this.BranchGuid.HeaderText = "Guid";
            this.BranchGuid.Name = "BranchGuid";
            this.BranchGuid.Visible = false;
            this.BranchGuid.Width = 250;
            // 
            // txtBranchName
            // 
            this.txtBranchName.Location = new System.Drawing.Point(654, 63);
            this.txtBranchName.Name = "txtBranchName";
            this.txtBranchName.Size = new System.Drawing.Size(204, 31);
            this.txtBranchName.TabIndex = 31;
            // 
            // lblAddBranch
            // 
            this.lblAddBranch.AutoSize = true;
            this.lblAddBranch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddBranch.Location = new System.Drawing.Point(474, 13);
            this.lblAddBranch.Name = "lblAddBranch";
            this.lblAddBranch.Size = new System.Drawing.Size(139, 37);
            this.lblAddBranch.TabIndex = 20;
            this.lblAddBranch.Text = "Add/Edit";
            // 
            // lblBranchName
            // 
            this.lblBranchName.AutoSize = true;
            this.lblBranchName.Location = new System.Drawing.Point(474, 66);
            this.lblBranchName.Name = "lblBranchName";
            this.lblBranchName.Size = new System.Drawing.Size(68, 25);
            this.lblBranchName.TabIndex = 21;
            this.lblBranchName.Text = "Name";
            // 
            // txtBranchGuid
            // 
            this.txtBranchGuid.Location = new System.Drawing.Point(654, 110);
            this.txtBranchGuid.Name = "txtBranchGuid";
            this.txtBranchGuid.Size = new System.Drawing.Size(463, 31);
            this.txtBranchGuid.TabIndex = 32;
            // 
            // lblBranchGuid
            // 
            this.lblBranchGuid.AutoSize = true;
            this.lblBranchGuid.Location = new System.Drawing.Point(474, 113);
            this.lblBranchGuid.Name = "lblBranchGuid";
            this.lblBranchGuid.Size = new System.Drawing.Size(57, 25);
            this.lblBranchGuid.TabIndex = 18;
            this.lblBranchGuid.Text = "Guid";
            // 
            // btnBranchGenerateGuid
            // 
            this.btnBranchGenerateGuid.Location = new System.Drawing.Point(1705, 32);
            this.btnBranchGenerateGuid.Name = "btnBranchGenerateGuid";
            this.btnBranchGenerateGuid.Size = new System.Drawing.Size(192, 31);
            this.btnBranchGenerateGuid.TabIndex = 46;
            this.btnBranchGenerateGuid.Text = "Generate Guid";
            this.btnBranchGenerateGuid.UseVisualStyleBackColor = true;
            this.btnBranchGenerateGuid.Click += new System.EventHandler(this.btnBranchGenerateGuid_Click);
            // 
            // btnBuildBashFile
            // 
            this.btnBuildBashFile.Location = new System.Drawing.Point(1635, 44);
            this.btnBuildBashFile.Name = "btnBuildBashFile";
            this.btnBuildBashFile.Size = new System.Drawing.Size(256, 46);
            this.btnBuildBashFile.TabIndex = 0;
            this.btnBuildBashFile.Text = "Build Bash File";
            this.btnBuildBashFile.UseVisualStyleBackColor = true;
            this.btnBuildBashFile.Click += new System.EventHandler(this.btnBuildBashFile_Click);
            // 
            // lblBranches
            // 
            this.lblBranches.AutoSize = true;
            this.lblBranches.Location = new System.Drawing.Point(26, 664);
            this.lblBranches.Name = "lblBranches";
            this.lblBranches.Size = new System.Drawing.Size(103, 25);
            this.lblBranches.TabIndex = 8;
            this.lblBranches.Text = "Branches";
            // 
            // lblRepositories
            // 
            this.lblRepositories.AutoSize = true;
            this.lblRepositories.Location = new System.Drawing.Point(26, 269);
            this.lblRepositories.Name = "lblRepositories";
            this.lblRepositories.Size = new System.Drawing.Size(132, 25);
            this.lblRepositories.TabIndex = 9;
            this.lblRepositories.Text = "Repositories";
            // 
            // pnlRepositories
            // 
            this.pnlRepositories.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pnlRepositories.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlRepositories.Controls.Add(this.lblRepositoryBranches);
            this.pnlRepositories.Controls.Add(this.chklRepositoryBranches);
            this.pnlRepositories.Controls.Add(this.btnRepositoryClear);
            this.pnlRepositories.Controls.Add(this.chkRepositoryActive);
            this.pnlRepositories.Controls.Add(this.chkRepositoryPerformPruneAtEnd);
            this.pnlRepositories.Controls.Add(this.txtRepositoryFolderPath);
            this.pnlRepositories.Controls.Add(this.lblRepositoryFolderPath);
            this.pnlRepositories.Controls.Add(this.btnSaveRepository);
            this.pnlRepositories.Controls.Add(this.dgvRepositories);
            this.pnlRepositories.Controls.Add(this.txtRepositoryName);
            this.pnlRepositories.Controls.Add(this.lblAddRepository);
            this.pnlRepositories.Controls.Add(this.lblRepositoryName);
            this.pnlRepositories.Controls.Add(this.txtRepositoryGuid);
            this.pnlRepositories.Controls.Add(this.lblRepositoryGuid);
            this.pnlRepositories.Controls.Add(this.btnRepositoryGuidGenerator);
            this.pnlRepositories.Location = new System.Drawing.Point(31, 309);
            this.pnlRepositories.Name = "pnlRepositories";
            this.pnlRepositories.Size = new System.Drawing.Size(1962, 337);
            this.pnlRepositories.TabIndex = 10;
            // 
            // lblRepositoryBranches
            // 
            this.lblRepositoryBranches.AutoSize = true;
            this.lblRepositoryBranches.Location = new System.Drawing.Point(1137, 64);
            this.lblRepositoryBranches.Name = "lblRepositoryBranches";
            this.lblRepositoryBranches.Size = new System.Drawing.Size(103, 25);
            this.lblRepositoryBranches.TabIndex = 13;
            this.lblRepositoryBranches.Text = "Branches";
            // 
            // chklRepositoryBranches
            // 
            this.chklRepositoryBranches.FormattingEnabled = true;
            this.chklRepositoryBranches.Location = new System.Drawing.Point(1140, 90);
            this.chklRepositoryBranches.Name = "chklRepositoryBranches";
            this.chklRepositoryBranches.Size = new System.Drawing.Size(472, 238);
            this.chklRepositoryBranches.Sorted = true;
            this.chklRepositoryBranches.TabIndex = 16;
            this.chklRepositoryBranches.Visible = false;
            // 
            // btnRepositoryClear
            // 
            this.btnRepositoryClear.Location = new System.Drawing.Point(1705, 75);
            this.btnRepositoryClear.Name = "btnRepositoryClear";
            this.btnRepositoryClear.Size = new System.Drawing.Size(80, 31);
            this.btnRepositoryClear.TabIndex = 18;
            this.btnRepositoryClear.Text = "Clear";
            this.btnRepositoryClear.UseVisualStyleBackColor = true;
            this.btnRepositoryClear.Click += new System.EventHandler(this.btnRepositoryClear_Click);
            // 
            // chkRepositoryActive
            // 
            this.chkRepositoryActive.AutoSize = true;
            this.chkRepositoryActive.Location = new System.Drawing.Point(869, 64);
            this.chkRepositoryActive.Name = "chkRepositoryActive";
            this.chkRepositoryActive.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chkRepositoryActive.Size = new System.Drawing.Size(103, 29);
            this.chkRepositoryActive.TabIndex = 15;
            this.chkRepositoryActive.Text = "Active";
            this.chkRepositoryActive.UseVisualStyleBackColor = true;
            // 
            // chkRepositoryPerformPruneAtEnd
            // 
            this.chkRepositoryPerformPruneAtEnd.AutoSize = true;
            this.chkRepositoryPerformPruneAtEnd.Location = new System.Drawing.Point(474, 195);
            this.chkRepositoryPerformPruneAtEnd.Name = "chkRepositoryPerformPruneAtEnd";
            this.chkRepositoryPerformPruneAtEnd.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chkRepositoryPerformPruneAtEnd.Size = new System.Drawing.Size(250, 29);
            this.chkRepositoryPerformPruneAtEnd.TabIndex = 34;
            this.chkRepositoryPerformPruneAtEnd.Text = "Perform Prune at End";
            this.chkRepositoryPerformPruneAtEnd.UseVisualStyleBackColor = true;
            // 
            // txtRepositoryFolderPath
            // 
            this.txtRepositoryFolderPath.Location = new System.Drawing.Point(654, 154);
            this.txtRepositoryFolderPath.Name = "txtRepositoryFolderPath";
            this.txtRepositoryFolderPath.Size = new System.Drawing.Size(463, 31);
            this.txtRepositoryFolderPath.TabIndex = 13;
            this.txtRepositoryFolderPath.TextChanged += new System.EventHandler(this.txtRepositoryFolderPath_TextChanged);
            // 
            // lblRepositoryFolderPath
            // 
            this.lblRepositoryFolderPath.AutoSize = true;
            this.lblRepositoryFolderPath.Location = new System.Drawing.Point(474, 154);
            this.lblRepositoryFolderPath.Name = "lblRepositoryFolderPath";
            this.lblRepositoryFolderPath.Size = new System.Drawing.Size(123, 25);
            this.lblRepositoryFolderPath.TabIndex = 17;
            this.lblRepositoryFolderPath.Text = "Folder Path";
            // 
            // btnSaveRepository
            // 
            this.btnSaveRepository.Location = new System.Drawing.Point(1800, 75);
            this.btnSaveRepository.Name = "btnSaveRepository";
            this.btnSaveRepository.Size = new System.Drawing.Size(97, 31);
            this.btnSaveRepository.TabIndex = 17;
            this.btnSaveRepository.Text = "Save";
            this.btnSaveRepository.UseVisualStyleBackColor = true;
            this.btnSaveRepository.Click += new System.EventHandler(this.btnSaveRepository_Click);
            // 
            // dgvRepositories
            // 
            this.dgvRepositories.AllowUserToAddRows = false;
            this.dgvRepositories.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRepositories.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RepositoryName,
            this.RepositoryGuid,
            this.FolderPath});
            this.dgvRepositories.Location = new System.Drawing.Point(19, 15);
            this.dgvRepositories.MultiSelect = false;
            this.dgvRepositories.Name = "dgvRepositories";
            this.dgvRepositories.RowTemplate.Height = 33;
            this.dgvRepositories.Size = new System.Drawing.Size(418, 301);
            this.dgvRepositories.TabIndex = 10;
            this.dgvRepositories.SelectionChanged += new System.EventHandler(this.dgvRepositories_SelectionChanged);
            // 
            // RepositoryName
            // 
            this.RepositoryName.DataPropertyName = "EntityName";
            this.RepositoryName.HeaderText = "Name";
            this.RepositoryName.Name = "RepositoryName";
            this.RepositoryName.Width = 125;
            // 
            // RepositoryGuid
            // 
            this.RepositoryGuid.DataPropertyName = "EntityGuid";
            this.RepositoryGuid.HeaderText = "Guid";
            this.RepositoryGuid.Name = "RepositoryGuid";
            this.RepositoryGuid.Visible = false;
            this.RepositoryGuid.Width = 250;
            // 
            // FolderPath
            // 
            this.FolderPath.DataPropertyName = "FolderPath";
            this.FolderPath.HeaderText = "Folder Path";
            this.FolderPath.Name = "FolderPath";
            this.FolderPath.Width = 200;
            // 
            // txtRepositoryName
            // 
            this.txtRepositoryName.Location = new System.Drawing.Point(656, 64);
            this.txtRepositoryName.Name = "txtRepositoryName";
            this.txtRepositoryName.Size = new System.Drawing.Size(204, 31);
            this.txtRepositoryName.TabIndex = 11;
            // 
            // lblAddRepository
            // 
            this.lblAddRepository.AutoSize = true;
            this.lblAddRepository.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddRepository.Location = new System.Drawing.Point(472, 15);
            this.lblAddRepository.Name = "lblAddRepository";
            this.lblAddRepository.Size = new System.Drawing.Size(139, 37);
            this.lblAddRepository.TabIndex = 13;
            this.lblAddRepository.Text = "Add/Edit";
            // 
            // lblRepositoryName
            // 
            this.lblRepositoryName.AutoSize = true;
            this.lblRepositoryName.Location = new System.Drawing.Point(474, 64);
            this.lblRepositoryName.Name = "lblRepositoryName";
            this.lblRepositoryName.Size = new System.Drawing.Size(68, 25);
            this.lblRepositoryName.TabIndex = 14;
            this.lblRepositoryName.Text = "Name";
            // 
            // txtRepositoryGuid
            // 
            this.txtRepositoryGuid.Location = new System.Drawing.Point(654, 107);
            this.txtRepositoryGuid.Name = "txtRepositoryGuid";
            this.txtRepositoryGuid.Size = new System.Drawing.Size(463, 31);
            this.txtRepositoryGuid.TabIndex = 12;
            // 
            // lblRepositoryGuid
            // 
            this.lblRepositoryGuid.AutoSize = true;
            this.lblRepositoryGuid.Location = new System.Drawing.Point(474, 107);
            this.lblRepositoryGuid.Name = "lblRepositoryGuid";
            this.lblRepositoryGuid.Size = new System.Drawing.Size(57, 25);
            this.lblRepositoryGuid.TabIndex = 11;
            this.lblRepositoryGuid.Text = "Guid";
            // 
            // btnRepositoryGuidGenerator
            // 
            this.btnRepositoryGuidGenerator.Location = new System.Drawing.Point(1705, 15);
            this.btnRepositoryGuidGenerator.Name = "btnRepositoryGuidGenerator";
            this.btnRepositoryGuidGenerator.Size = new System.Drawing.Size(192, 31);
            this.btnRepositoryGuidGenerator.TabIndex = 19;
            this.btnRepositoryGuidGenerator.Text = "Generate Guid";
            this.btnRepositoryGuidGenerator.UseVisualStyleBackColor = true;
            this.btnRepositoryGuidGenerator.Click += new System.EventHandler(this.btnRepositoryGuidGenerator_Click);
            // 
            // btnView
            // 
            this.btnView.Location = new System.Drawing.Point(1431, 46);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(188, 44);
            this.btnView.TabIndex = 0;
            this.btnView.Text = "View";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // btnViewBashFile
            // 
            this.btnViewBashFile.Location = new System.Drawing.Point(1635, 109);
            this.btnViewBashFile.Name = "btnViewBashFile";
            this.btnViewBashFile.Size = new System.Drawing.Size(256, 44);
            this.btnViewBashFile.TabIndex = 0;
            this.btnViewBashFile.Text = "View Bash File";
            this.btnViewBashFile.UseVisualStyleBackColor = true;
            this.btnViewBashFile.Click += new System.EventHandler(this.btnViewBashFile_Click);
            // 
            // lblGitCommands
            // 
            this.lblGitCommands.AutoSize = true;
            this.lblGitCommands.Location = new System.Drawing.Point(26, 1221);
            this.lblGitCommands.Name = "lblGitCommands";
            this.lblGitCommands.Size = new System.Drawing.Size(153, 25);
            this.lblGitCommands.TabIndex = 13;
            this.lblGitCommands.Text = "Git Commands";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txtGitCommandCode);
            this.panel1.Controls.Add(this.lblGitCommandCode);
            this.panel1.Controls.Add(this.btnGitCommandsClear);
            this.panel1.Controls.Add(this.chkGitCommandActive);
            this.panel1.Controls.Add(this.txtGitCommandValue);
            this.panel1.Controls.Add(this.lblGitCommandValue);
            this.panel1.Controls.Add(this.btnGitCommandsSave);
            this.panel1.Controls.Add(this.txtGitCommandName);
            this.panel1.Controls.Add(this.lblGitCommandName);
            this.panel1.Controls.Add(this.lblGitCommandsAddEdit);
            this.panel1.Controls.Add(this.btnGitCommandsGenerateGuid);
            this.panel1.Controls.Add(this.lblGitCommandGuid);
            this.panel1.Controls.Add(this.dgvGitCommands);
            this.panel1.Controls.Add(this.txtGitCommandGuid);
            this.panel1.Location = new System.Drawing.Point(31, 1261);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1352, 323);
            this.panel1.TabIndex = 14;
            // 
            // txtGitCommandCode
            // 
            this.txtGitCommandCode.Location = new System.Drawing.Point(656, 107);
            this.txtGitCommandCode.Name = "txtGitCommandCode";
            this.txtGitCommandCode.Size = new System.Drawing.Size(204, 31);
            this.txtGitCommandCode.TabIndex = 42;
            // 
            // lblGitCommandCode
            // 
            this.lblGitCommandCode.AutoSize = true;
            this.lblGitCommandCode.Location = new System.Drawing.Point(474, 104);
            this.lblGitCommandCode.Name = "lblGitCommandCode";
            this.lblGitCommandCode.Size = new System.Drawing.Size(63, 25);
            this.lblGitCommandCode.TabIndex = 40;
            this.lblGitCommandCode.Text = "Code";
            // 
            // btnGitCommandsClear
            // 
            this.btnGitCommandsClear.Location = new System.Drawing.Point(1140, 137);
            this.btnGitCommandsClear.Name = "btnGitCommandsClear";
            this.btnGitCommandsClear.Size = new System.Drawing.Size(80, 31);
            this.btnGitCommandsClear.TabIndex = 47;
            this.btnGitCommandsClear.Text = "Clear";
            this.btnGitCommandsClear.UseVisualStyleBackColor = true;
            this.btnGitCommandsClear.Click += new System.EventHandler(this.btnGitCommandsClear_Click);
            // 
            // chkGitCommandActive
            // 
            this.chkGitCommandActive.AutoSize = true;
            this.chkGitCommandActive.Location = new System.Drawing.Point(869, 66);
            this.chkGitCommandActive.Name = "chkGitCommandActive";
            this.chkGitCommandActive.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chkGitCommandActive.Size = new System.Drawing.Size(103, 29);
            this.chkGitCommandActive.TabIndex = 43;
            this.chkGitCommandActive.Text = "Active";
            this.chkGitCommandActive.UseVisualStyleBackColor = true;
            // 
            // txtGitCommandValue
            // 
            this.txtGitCommandValue.Location = new System.Drawing.Point(654, 188);
            this.txtGitCommandValue.Multiline = true;
            this.txtGitCommandValue.Name = "txtGitCommandValue";
            this.txtGitCommandValue.Size = new System.Drawing.Size(463, 125);
            this.txtGitCommandValue.TabIndex = 45;
            // 
            // lblGitCommandValue
            // 
            this.lblGitCommandValue.AutoSize = true;
            this.lblGitCommandValue.Location = new System.Drawing.Point(474, 182);
            this.lblGitCommandValue.Name = "lblGitCommandValue";
            this.lblGitCommandValue.Size = new System.Drawing.Size(142, 25);
            this.lblGitCommandValue.TabIndex = 10;
            this.lblGitCommandValue.Text = "Git Command";
            // 
            // btnGitCommandsSave
            // 
            this.btnGitCommandsSave.Location = new System.Drawing.Point(1235, 137);
            this.btnGitCommandsSave.Name = "btnGitCommandsSave";
            this.btnGitCommandsSave.Size = new System.Drawing.Size(97, 31);
            this.btnGitCommandsSave.TabIndex = 46;
            this.btnGitCommandsSave.Text = "Save";
            this.btnGitCommandsSave.UseVisualStyleBackColor = true;
            this.btnGitCommandsSave.Click += new System.EventHandler(this.btnGitCommandsSave_Click);
            // 
            // txtGitCommandName
            // 
            this.txtGitCommandName.Location = new System.Drawing.Point(654, 66);
            this.txtGitCommandName.Name = "txtGitCommandName";
            this.txtGitCommandName.Size = new System.Drawing.Size(204, 31);
            this.txtGitCommandName.TabIndex = 41;
            // 
            // lblGitCommandName
            // 
            this.lblGitCommandName.AutoSize = true;
            this.lblGitCommandName.Location = new System.Drawing.Point(474, 63);
            this.lblGitCommandName.Name = "lblGitCommandName";
            this.lblGitCommandName.Size = new System.Drawing.Size(68, 25);
            this.lblGitCommandName.TabIndex = 7;
            this.lblGitCommandName.Text = "Name";
            // 
            // lblGitCommandsAddEdit
            // 
            this.lblGitCommandsAddEdit.AutoSize = true;
            this.lblGitCommandsAddEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGitCommandsAddEdit.Location = new System.Drawing.Point(472, 16);
            this.lblGitCommandsAddEdit.Name = "lblGitCommandsAddEdit";
            this.lblGitCommandsAddEdit.Size = new System.Drawing.Size(139, 37);
            this.lblGitCommandsAddEdit.TabIndex = 6;
            this.lblGitCommandsAddEdit.Text = "Add/Edit";
            // 
            // btnGitCommandsGenerateGuid
            // 
            this.btnGitCommandsGenerateGuid.Location = new System.Drawing.Point(1140, 80);
            this.btnGitCommandsGenerateGuid.Name = "btnGitCommandsGenerateGuid";
            this.btnGitCommandsGenerateGuid.Size = new System.Drawing.Size(192, 31);
            this.btnGitCommandsGenerateGuid.TabIndex = 48;
            this.btnGitCommandsGenerateGuid.Text = "Generate Guid";
            this.btnGitCommandsGenerateGuid.UseVisualStyleBackColor = true;
            this.btnGitCommandsGenerateGuid.Click += new System.EventHandler(this.btnGitCommandsGenerateGuid_Click);
            // 
            // lblGitCommandGuid
            // 
            this.lblGitCommandGuid.AutoSize = true;
            this.lblGitCommandGuid.Location = new System.Drawing.Point(474, 142);
            this.lblGitCommandGuid.Name = "lblGitCommandGuid";
            this.lblGitCommandGuid.Size = new System.Drawing.Size(57, 25);
            this.lblGitCommandGuid.TabIndex = 4;
            this.lblGitCommandGuid.Text = "Guid";
            // 
            // dgvGitCommands
            // 
            this.dgvGitCommands.AllowUserToAddRows = false;
            this.dgvGitCommands.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGitCommands.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.GitCommandName,
            this.GitCommandValue,
            this.GitCommandActive,
            this.GitCommandCode,
            this.GitCommandGuid});
            this.dgvGitCommands.Location = new System.Drawing.Point(19, 16);
            this.dgvGitCommands.MultiSelect = false;
            this.dgvGitCommands.Name = "dgvGitCommands";
            this.dgvGitCommands.RowTemplate.Height = 33;
            this.dgvGitCommands.Size = new System.Drawing.Size(418, 300);
            this.dgvGitCommands.TabIndex = 40;
            this.dgvGitCommands.SelectionChanged += new System.EventHandler(this.dgvGitCommands_SelectionChanged);
            // 
            // txtGitCommandGuid
            // 
            this.txtGitCommandGuid.Location = new System.Drawing.Point(656, 146);
            this.txtGitCommandGuid.Name = "txtGitCommandGuid";
            this.txtGitCommandGuid.Size = new System.Drawing.Size(463, 31);
            this.txtGitCommandGuid.TabIndex = 44;
            // 
            // GitCommandName
            // 
            this.GitCommandName.DataPropertyName = "EntityName";
            this.GitCommandName.HeaderText = "Name";
            this.GitCommandName.Name = "GitCommandName";
            this.GitCommandName.Width = 150;
            // 
            // GitCommandValue
            // 
            this.GitCommandValue.DataPropertyName = "EntityValue";
            this.GitCommandValue.HeaderText = "EntityValue";
            this.GitCommandValue.Name = "GitCommandValue";
            this.GitCommandValue.Visible = false;
            // 
            // GitCommandActive
            // 
            this.GitCommandActive.DataPropertyName = "Active";
            this.GitCommandActive.HeaderText = "Active";
            this.GitCommandActive.Name = "GitCommandActive";
            this.GitCommandActive.Visible = false;
            // 
            // GitCommandCode
            // 
            this.GitCommandCode.DataPropertyName = "EntityCode";
            this.GitCommandCode.HeaderText = "Code";
            this.GitCommandCode.Name = "GitCommandCode";
            this.GitCommandCode.Width = 150;
            // 
            // GitCommandGuid
            // 
            this.GitCommandGuid.DataPropertyName = "EntityGuid";
            this.GitCommandGuid.HeaderText = "Guid";
            this.GitCommandGuid.Name = "GitCommandGuid";
            this.GitCommandGuid.Visible = false;
            // 
            // Management
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2012, 1596);
            this.Controls.Add(this.lblGitCommands);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnViewBashFile);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.pnlRepositories);
            this.Controls.Add(this.lblRepositories);
            this.Controls.Add(this.lblBranches);
            this.Controls.Add(this.btnBuildBashFile);
            this.Controls.Add(this.pnlBranches);
            this.Controls.Add(this.lblProjects);
            this.Controls.Add(this.pnlProjects);
            this.Controls.Add(this.btnSave);
            this.Name = "Management";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Git Bash Management";
            this.Load += new System.EventHandler(this.Management_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProjects)).EndInit();
            this.pnlProjects.ResumeLayout(false);
            this.pnlProjects.PerformLayout();
            this.pnlBranches.ResumeLayout(false);
            this.pnlBranches.PerformLayout();
            this.rbBranchAppliesTo.ResumeLayout(false);
            this.rbBranchAppliesTo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBranches)).EndInit();
            this.pnlRepositories.ResumeLayout(false);
            this.pnlRepositories.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRepositories)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGitCommands)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridView dgvProjects;
        private System.Windows.Forms.Label lblProjects;
        private System.Windows.Forms.TextBox txtProjectGuid;
        private System.Windows.Forms.Label lblProjectGuid;
        private System.Windows.Forms.Panel pnlProjects;
        private System.Windows.Forms.Button btnProjectGuidGenerator;
        private System.Windows.Forms.Button btnSaveProject;
        private System.Windows.Forms.TextBox txtProjectName;
        private System.Windows.Forms.Label lblProjectName;
        private System.Windows.Forms.Label lblAddProject;
        private System.Windows.Forms.Panel pnlBranches;
        private System.Windows.Forms.Button btnBuildBashFile;
        private System.Windows.Forms.Label lblBranches;
        private System.Windows.Forms.Label lblRepositories;
        private System.Windows.Forms.Panel pnlRepositories;
        private System.Windows.Forms.Button btnSaveBranch;
        private System.Windows.Forms.DataGridView dgvBranches;
        private System.Windows.Forms.TextBox txtBranchName;
        private System.Windows.Forms.Label lblAddBranch;
        private System.Windows.Forms.Label lblBranchName;
        private System.Windows.Forms.TextBox txtBranchGuid;
        private System.Windows.Forms.Label lblBranchGuid;
        private System.Windows.Forms.Button btnBranchGenerateGuid;
        private System.Windows.Forms.Button btnSaveRepository;
        private System.Windows.Forms.DataGridView dgvRepositories;
        private System.Windows.Forms.TextBox txtRepositoryName;
        private System.Windows.Forms.Label lblAddRepository;
        private System.Windows.Forms.Label lblRepositoryName;
        private System.Windows.Forms.TextBox txtRepositoryGuid;
        private System.Windows.Forms.Label lblRepositoryGuid;
        private System.Windows.Forms.Button btnRepositoryGuidGenerator;
        private System.Windows.Forms.TextBox txtProjectOutputFileName;
        private System.Windows.Forms.Label lblProjectOutputFileName;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Button btnViewBashFile;
        private System.Windows.Forms.Button btnBranchClear;
        private System.Windows.Forms.CheckedListBox chklBranchesAppliesToSpecificRepositories;
        private System.Windows.Forms.RadioButton rdBranchAppliesToSpecificRepositories;
        private System.Windows.Forms.RadioButton rdBranchAppliesToAllRepositoriesAllProjects;
        private System.Windows.Forms.RadioButton rdBranchEditMode;
        private System.Windows.Forms.GroupBox rbBranchAppliesTo;
        private System.Windows.Forms.CheckBox chkBranchUndoAnyChanges;
        private System.Windows.Forms.CheckBox chkBranchPullFirst;
        private System.Windows.Forms.Label lblBranchMergeFrom;
        private System.Windows.Forms.ComboBox cbBranchMergeFromBranch;
        private System.Windows.Forms.TextBox txtRepositoryFolderPath;
        private System.Windows.Forms.Label lblRepositoryFolderPath;
        private System.Windows.Forms.CheckBox chkRepositoryPerformPruneAtEnd;
        private System.Windows.Forms.DataGridViewTextBoxColumn RepositoryName;
        private System.Windows.Forms.DataGridViewTextBoxColumn RepositoryGuid;
        private System.Windows.Forms.DataGridViewTextBoxColumn FolderPath;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProjectName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProjectGuid;
        private System.Windows.Forms.DataGridViewTextBoxColumn OutputFileName;
        private System.Windows.Forms.CheckBox chkProjectActive;
        private System.Windows.Forms.CheckBox chkBranchActive;
        private System.Windows.Forms.CheckBox chkRepositoryActive;
        private System.Windows.Forms.Button btnProjectClear;
        private System.Windows.Forms.Button btnRepositoryClear;
        private System.Windows.Forms.RadioButton rdBranchAppliesToAllRepositoriesInCurrentProject;
        private System.Windows.Forms.CheckedListBox chklRepositoryBranches;
        private System.Windows.Forms.Label lblRepositoryBranches;
        private System.Windows.Forms.RadioButton rdBranchAppliesToClearRepositoryBranches;
        private System.Windows.Forms.DataGridViewTextBoxColumn Repository;
        private System.Windows.Forms.DataGridViewTextBoxColumn BranchName;
        private System.Windows.Forms.DataGridViewTextBoxColumn BranchGuid;
        private System.Windows.Forms.Label lblGitCommands;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnGitCommandsClear;
        private System.Windows.Forms.CheckBox chkGitCommandActive;
        private System.Windows.Forms.TextBox txtGitCommandValue;
        private System.Windows.Forms.Label lblGitCommandValue;
        private System.Windows.Forms.Button btnGitCommandsSave;
        private System.Windows.Forms.TextBox txtGitCommandName;
        private System.Windows.Forms.Label lblGitCommandName;
        private System.Windows.Forms.Label lblGitCommandsAddEdit;
        private System.Windows.Forms.Button btnGitCommandsGenerateGuid;
        private System.Windows.Forms.Label lblGitCommandGuid;
        private System.Windows.Forms.DataGridView dgvGitCommands;
        private System.Windows.Forms.TextBox txtGitCommandGuid;
        private System.Windows.Forms.TextBox txtGitCommandCode;
        private System.Windows.Forms.Label lblGitCommandCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn GitCommandName;
        private System.Windows.Forms.DataGridViewTextBoxColumn GitCommandValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn GitCommandActive;
        private System.Windows.Forms.DataGridViewTextBoxColumn GitCommandCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn GitCommandGuid;
    }
}

