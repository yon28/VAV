using System;

namespace WinForms
{
	partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem7 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem11 = new System.Windows.Forms.ToolStripMenuItem();
            this.ctlFile = new System.Windows.Forms.ToolStripMenuItem();
            this.ctlFileRegister = new System.Windows.Forms.ToolStripMenuItem();
            this.ctlFileEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.ctlFileRemove = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.ctlFileRewardRegister = new System.Windows.Forms.ToolStripMenuItem();
            this.ctlFileRewardEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.ctlFileRewardRemove = new System.Windows.Forms.ToolStripMenuItem();
            this.ctlHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.ctlHelpAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.ctlContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ctlContextRegister = new System.Windows.Forms.ToolStripMenuItem();
            this.ctlContextEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.ctlContextRemove = new System.Windows.Forms.ToolStripMenuItem();
            this.ctlStatusPanel = new System.Windows.Forms.StatusStrip();
            this.ctlProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.splashTimer = new System.Windows.Forms.Timer(this.components);
            this.ctlRewardPage = new System.Windows.Forms.TabPage();
            this.dgvRewards = new System.Windows.Forms.DataGridView();
            this.ctlEmployeePage = new System.Windows.Forms.TabPage();
            this.ctlEmployees = new System.Windows.Forms.DataGridView();
            this.ctlTab = new System.Windows.Forms.TabControl();
            this.dgvID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvLastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvFirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvBirth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvAge = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvReward = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mainMenu.SuspendLayout();
            this.ctlContextMenu.SuspendLayout();
            this.ctlStatusPanel.SuspendLayout();
            this.ctlRewardPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRewards)).BeginInit();
            this.ctlEmployeePage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ctlEmployees)).BeginInit();
            this.ctlTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenu
            // 
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem7,
            this.ctlFile,
            this.toolStripMenuItem2,
            this.ctlHelp});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(659, 24);
            this.mainMenu.TabIndex = 0;
            // 
            // toolStripMenuItem7
            // 
            this.toolStripMenuItem7.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem11});
            this.toolStripMenuItem7.Name = "toolStripMenuItem7";
            this.toolStripMenuItem7.Size = new System.Drawing.Size(48, 20);
            this.toolStripMenuItem7.Text = "Файл";
            // 
            // toolStripMenuItem11
            // 
            this.toolStripMenuItem11.Name = "toolStripMenuItem11";
            this.toolStripMenuItem11.Size = new System.Drawing.Size(108, 22);
            this.toolStripMenuItem11.Text = "Выход";
            this.toolStripMenuItem11.Click += new System.EventHandler(this.Exit_Click);
            // 
            // ctlFile
            // 
            this.ctlFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ctlFileRegister,
            this.ctlFileEdit,
            this.ctlFileRemove});
            this.ctlFile.Name = "ctlFile";
            this.ctlFile.Size = new System.Drawing.Size(97, 20);
            this.ctlFile.Text = "Пользователи";
            // 
            // ctlFileRegister
            // 
            this.ctlFileRegister.Name = "ctlFileRegister";
            this.ctlFileRegister.Size = new System.Drawing.Size(183, 22);
            this.ctlFileRegister.Text = "Зарегистрировать...";
            this.ctlFileRegister.Click += new System.EventHandler(this.FileRegister_Click);
            // 
            // ctlFileEdit
            // 
            this.ctlFileEdit.Name = "ctlFileEdit";
            this.ctlFileEdit.Size = new System.Drawing.Size(183, 22);
            this.ctlFileEdit.Text = "Редактировать..";
            this.ctlFileEdit.Click += new System.EventHandler(this.FileEdit_Click);
            // 
            // ctlFileRemove
            // 
            this.ctlFileRemove.Name = "ctlFileRemove";
            this.ctlFileRemove.Size = new System.Drawing.Size(183, 22);
            this.ctlFileRemove.Text = "Удалить";
            this.ctlFileRemove.Click += new System.EventHandler(this.FileRemove_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ctlFileRewardRegister,
            this.ctlFileRewardEdit,
            this.ctlFileRewardRemove});
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(67, 20);
            this.toolStripMenuItem2.Text = "Награды";
            // 
            // ctlFileRewardRegister
            // 
            this.ctlFileRewardRegister.Name = "ctlFileRewardRegister";
            this.ctlFileRewardRegister.Size = new System.Drawing.Size(183, 22);
            this.ctlFileRewardRegister.Text = "Зарегистрировать...";
            this.ctlFileRewardRegister.Click += new System.EventHandler(this.FileRewardRegister_Click);
            // 
            // ctlFileRewardEdit
            // 
            this.ctlFileRewardEdit.Name = "ctlFileRewardEdit";
            this.ctlFileRewardEdit.Size = new System.Drawing.Size(183, 22);
            this.ctlFileRewardEdit.Text = "Редактировать..";
            this.ctlFileRewardEdit.Click += new System.EventHandler(this.FileRewardEdit_Click);
            // 
            // ctlFileRewardRemove
            // 
            this.ctlFileRewardRemove.Name = "ctlFileRewardRemove";
            this.ctlFileRewardRemove.Size = new System.Drawing.Size(183, 22);
            this.ctlFileRewardRemove.Text = "Удалить";
            this.ctlFileRewardRemove.Click += new System.EventHandler(this.ctlFileRewardRemove_Click);
            // 
            // ctlHelp
            // 
            this.ctlHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ctlHelpAbout});
            this.ctlHelp.Name = "ctlHelp";
            this.ctlHelp.Size = new System.Drawing.Size(68, 20);
            this.ctlHelp.Text = "Помощь";
            // 
            // ctlHelpAbout
            // 
            this.ctlHelpAbout.Name = "ctlHelpAbout";
            this.ctlHelpAbout.Size = new System.Drawing.Size(158, 22);
            this.ctlHelpAbout.Text = "О программе...";
            // 
            // ctlContextMenu
            // 
            this.ctlContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ctlContextRegister,
            this.ctlContextEdit,
            this.ctlContextRemove});
            this.ctlContextMenu.Name = "ctlContextMenu";
            this.ctlContextMenu.Size = new System.Drawing.Size(177, 70);
            // 
            // ctlContextRegister
            // 
            this.ctlContextRegister.Name = "ctlContextRegister";
            this.ctlContextRegister.Size = new System.Drawing.Size(176, 22);
            this.ctlContextRegister.Text = "Зарегистировать...";
            this.ctlContextRegister.Click += new System.EventHandler(this.ContextRegister_Click);
            // 
            // ctlContextEdit
            // 
            this.ctlContextEdit.Name = "ctlContextEdit";
            this.ctlContextEdit.Size = new System.Drawing.Size(176, 22);
            this.ctlContextEdit.Text = "Редактировать...";
            this.ctlContextEdit.Click += new System.EventHandler(this.ContextEdit_Click);
            // 
            // ctlContextRemove
            // 
            this.ctlContextRemove.Name = "ctlContextRemove";
            this.ctlContextRemove.Size = new System.Drawing.Size(176, 22);
            this.ctlContextRemove.Text = "Удалить";
            this.ctlContextRemove.Click += new System.EventHandler(this.ContextRemove_Click);
            // 
            // ctlStatusPanel
            // 
            this.ctlStatusPanel.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ctlProgressBar});
            this.ctlStatusPanel.Location = new System.Drawing.Point(0, 361);
            this.ctlStatusPanel.Name = "ctlStatusPanel";
            this.ctlStatusPanel.Size = new System.Drawing.Size(659, 22);
            this.ctlStatusPanel.TabIndex = 3;
            this.ctlStatusPanel.Text = "statusStrip1";
            // 
            // ctlProgressBar
            // 
            this.ctlProgressBar.Maximum = 20;
            this.ctlProgressBar.Name = "ctlProgressBar";
            this.ctlProgressBar.Size = new System.Drawing.Size(100, 16);
            this.ctlProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            // 
            // splashTimer
            // 
            this.splashTimer.Enabled = true;
            this.splashTimer.Interval = 5000;
            this.splashTimer.Tick += new System.EventHandler(this.SplashTimer_Tick);
            // 
            // ctlRewardPage
            // 
            this.ctlRewardPage.Controls.Add(this.dgvRewards);
            this.ctlRewardPage.Location = new System.Drawing.Point(4, 22);
            this.ctlRewardPage.Name = "ctlRewardPage";
            this.ctlRewardPage.Padding = new System.Windows.Forms.Padding(3);
            this.ctlRewardPage.Size = new System.Drawing.Size(651, 274);
            this.ctlRewardPage.TabIndex = 1;
            this.ctlRewardPage.Text = "Награды";
            this.ctlRewardPage.UseVisualStyleBackColor = true;
            // 
            // dgvRewards
            // 
            this.dgvRewards.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRewards.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvTitle});
            this.dgvRewards.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRewards.Location = new System.Drawing.Point(3, 3);
            this.dgvRewards.Name = "dgvRewards";
            this.dgvRewards.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRewards.Size = new System.Drawing.Size(645, 268);
            this.dgvRewards.TabIndex = 1;
            // 
            // ctlEmployeePage
            // 
            this.ctlEmployeePage.Controls.Add(this.ctlEmployees);
            this.ctlEmployeePage.Location = new System.Drawing.Point(4, 22);
            this.ctlEmployeePage.Name = "ctlEmployeePage";
            this.ctlEmployeePage.Padding = new System.Windows.Forms.Padding(3);
            this.ctlEmployeePage.Size = new System.Drawing.Size(651, 274);
            this.ctlEmployeePage.TabIndex = 0;
            this.ctlEmployeePage.Text = "Пользователи";
            this.ctlEmployeePage.UseVisualStyleBackColor = true;
            // 
            // ctlEmployees
            // 
            this.ctlEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ctlEmployees.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvID,
            this.dgvLastName,
            this.dgvFirstName,
            this.dgvBirth,
            this.dgvAge,
            this.dgvReward});
            this.ctlEmployees.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctlEmployees.Location = new System.Drawing.Point(3, 3);
            this.ctlEmployees.Name = "ctlEmployees";
            this.ctlEmployees.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ctlEmployees.Size = new System.Drawing.Size(645, 268);
            this.ctlEmployees.TabIndex = 0;
            this.ctlEmployees.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ctlEmployees_CellContentClick);
            // 
            // ctlTab
            // 
            this.ctlTab.Controls.Add(this.ctlEmployeePage);
            this.ctlTab.Controls.Add(this.ctlRewardPage);
            this.ctlTab.Dock = System.Windows.Forms.DockStyle.Top;
            this.ctlTab.Location = new System.Drawing.Point(0, 24);
            this.ctlTab.Name = "ctlTab";
            this.ctlTab.SelectedIndex = 0;
            this.ctlTab.Size = new System.Drawing.Size(659, 300);
            this.ctlTab.TabIndex = 5;
            // 
            // dgvID
            // 
            this.dgvID.DataPropertyName = "IDNumber";
            this.dgvID.HeaderText = "ID";
            this.dgvID.Name = "dgvID";
            this.dgvID.Visible = false;
            // 
            // dgvLastName
            // 
            this.dgvLastName.DataPropertyName = "LastName";
            this.dgvLastName.HeaderText = "Фамилия";
            this.dgvLastName.Name = "dgvLastName";
            // 
            // dgvFirstName
            // 
            this.dgvFirstName.DataPropertyName = "FirstName";
            this.dgvFirstName.HeaderText = "Имя";
            this.dgvFirstName.Name = "dgvFirstName";
            // 
            // dgvBirth
            // 
            this.dgvBirth.DataPropertyName = "Birth";
            this.dgvBirth.HeaderText = "Дата рождения";
            this.dgvBirth.Name = "dgvBirth";
            // 
            // dgvAge
            // 
            this.dgvAge.DataPropertyName = "Age";
            this.dgvAge.HeaderText = "Возраст";
            this.dgvAge.Name = "dgvAge";
            // 
            // dgvReward
            // 
            this.dgvReward.DataPropertyName = "RewardE";
            this.dgvReward.HeaderText = "Награды";
            this.dgvReward.Name = "dgvReward";
            // 
            // dgvTitle
            // 
            this.dgvTitle.DataPropertyName = "Title";
            this.dgvTitle.HeaderText = "Title";
            this.dgvTitle.Name = "dgvTitle";
            this.dgvTitle.ReadOnly = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 383);
            this.Controls.Add(this.ctlTab);
            this.Controls.Add(this.ctlStatusPanel);
            this.Controls.Add(this.mainMenu);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MainMenuStrip = this.mainMenu;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Список пользователей";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            this.ctlContextMenu.ResumeLayout(false);
            this.ctlStatusPanel.ResumeLayout(false);
            this.ctlStatusPanel.PerformLayout();
            this.ctlRewardPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRewards)).EndInit();
            this.ctlEmployeePage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ctlEmployees)).EndInit();
            this.ctlTab.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}


        #endregion

        private System.Windows.Forms.MenuStrip mainMenu;
		private System.Windows.Forms.ToolStripMenuItem ctlFile;
		private System.Windows.Forms.ToolStripMenuItem ctlHelp;
		private System.Windows.Forms.ToolStripMenuItem ctlHelpAbout;
		private System.Windows.Forms.StatusStrip ctlStatusPanel;
		private System.Windows.Forms.ToolStripMenuItem ctlFileRegister;
		private System.Windows.Forms.ToolStripMenuItem ctlFileEdit;
		private System.Windows.Forms.ToolStripMenuItem ctlFileRemove;
		private System.Windows.Forms.ContextMenuStrip ctlContextMenu;
		private System.Windows.Forms.ToolStripMenuItem ctlContextRegister;
		private System.Windows.Forms.ToolStripMenuItem ctlContextRemove;
		private System.Windows.Forms.ToolStripMenuItem ctlContextEdit;
		private System.Windows.Forms.Timer splashTimer;
		private System.Windows.Forms.ToolStripProgressBar ctlProgressBar;
        private System.Windows.Forms.TabPage ctlRewardPage;
        private System.Windows.Forms.TabPage ctlEmployeePage;
        public System.Windows.Forms.DataGridView ctlEmployees;
        private System.Windows.Forms.TabControl ctlTab;
        private System.Windows.Forms.DataGridView dgvRewards;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem7;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem11;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem ctlFileRewardRegister;
        private System.Windows.Forms.ToolStripMenuItem ctlFileRewardEdit;
        private System.Windows.Forms.ToolStripMenuItem ctlFileRewardRemove;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvLastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvFirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvBirth;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvAge;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvReward;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTitle;
    }
}

