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
            this.ctlFile = new System.Windows.Forms.ToolStripMenuItem();
            this.ctlExit = new System.Windows.Forms.ToolStripMenuItem();
            this.ctlEmployee = new System.Windows.Forms.ToolStripMenuItem();
            this.ctlRegister = new System.Windows.Forms.ToolStripMenuItem();
            this.ctlEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.ctlRemove = new System.Windows.Forms.ToolStripMenuItem();
            this.ctlRewards = new System.Windows.Forms.ToolStripMenuItem();
            this.ctlRewardRegister = new System.Windows.Forms.ToolStripMenuItem();
            this.ctlRewardEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.ctlRewardRemove = new System.Windows.Forms.ToolStripMenuItem();
            this.ctlHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.ctlHelpAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.ctlContextRegister = new System.Windows.Forms.ToolStripMenuItem();
            this.ctlContextEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.ctlContextRemove = new System.Windows.Forms.ToolStripMenuItem();
            this.ctlContextRegisterReward = new System.Windows.Forms.ToolStripMenuItem();
            this.ctlContextEditReward = new System.Windows.Forms.ToolStripMenuItem();
            this.ctlContextRemoveReward = new System.Windows.Forms.ToolStripMenuItem();
            this.splashTimer = new System.Windows.Forms.Timer(this.components);
            this.ctlRewardPage = new System.Windows.Forms.TabPage();
            this.dgvRewards = new System.Windows.Forms.DataGridView();
            this.dgvTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ctlContextMenuReward = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ctlEmployeePage = new System.Windows.Forms.TabPage();
            this.dgvEmployees = new System.Windows.Forms.DataGridView();
            this.ctlContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ctlTab = new System.Windows.Forms.TabControl();
            this.dgvLastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvFirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvBirth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvAge = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvReward = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mainMenu.SuspendLayout();
            this.ctlRewardPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRewards)).BeginInit();
            this.ctlContextMenuReward.SuspendLayout();
            this.ctlEmployeePage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployees)).BeginInit();
            this.ctlContextMenu.SuspendLayout();
            this.ctlTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenu
            // 
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ctlFile,
            this.ctlEmployee,
            this.ctlRewards,
            this.ctlHelp});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(895, 24);
            this.mainMenu.TabIndex = 0;
            // 
            // ctlFile
            // 
            this.ctlFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ctlExit});
            this.ctlFile.Name = "ctlFile";
            this.ctlFile.Size = new System.Drawing.Size(48, 20);
            this.ctlFile.Text = "Файл";
            // 
            // ctlExit
            // 
            this.ctlExit.Name = "ctlExit";
            this.ctlExit.Size = new System.Drawing.Size(108, 22);
            this.ctlExit.Text = "Выход";
            this.ctlExit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // ctlEmployee
            // 
            this.ctlEmployee.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ctlRegister,
            this.ctlEdit,
            this.ctlRemove});
            this.ctlEmployee.Name = "ctlEmployee";
            this.ctlEmployee.Size = new System.Drawing.Size(97, 20);
            this.ctlEmployee.Text = "Пользователи";
            // 
            // ctlRegister
            // 
            this.ctlRegister.Name = "ctlRegister";
            this.ctlRegister.Size = new System.Drawing.Size(183, 22);
            this.ctlRegister.Text = "Зарегистрировать...";
            this.ctlRegister.Click += new System.EventHandler(this.FileRegister_Click);
            // 
            // ctlEdit
            // 
            this.ctlEdit.Name = "ctlEdit";
            this.ctlEdit.Size = new System.Drawing.Size(183, 22);
            this.ctlEdit.Text = "Редактировать..";
            this.ctlEdit.Click += new System.EventHandler(this.FileEdit_Click);
            // 
            // ctlRemove
            // 
            this.ctlRemove.Name = "ctlRemove";
            this.ctlRemove.Size = new System.Drawing.Size(183, 22);
            this.ctlRemove.Text = "Удалить";
            this.ctlRemove.Click += new System.EventHandler(this.FileRemove_Click);
            // 
            // ctlRewards
            // 
            this.ctlRewards.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ctlRewardRegister,
            this.ctlRewardEdit,
            this.ctlRewardRemove});
            this.ctlRewards.Name = "ctlRewards";
            this.ctlRewards.Size = new System.Drawing.Size(67, 20);
            this.ctlRewards.Text = "Награды";
            // 
            // ctlRewardRegister
            // 
            this.ctlRewardRegister.Name = "ctlRewardRegister";
            this.ctlRewardRegister.Size = new System.Drawing.Size(183, 22);
            this.ctlRewardRegister.Text = "Зарегистрировать...";
            this.ctlRewardRegister.Click += new System.EventHandler(this.FileRewardRegister_Click);
            // 
            // ctlRewardEdit
            // 
            this.ctlRewardEdit.Name = "ctlRewardEdit";
            this.ctlRewardEdit.Size = new System.Drawing.Size(183, 22);
            this.ctlRewardEdit.Text = "Редактировать..";
            this.ctlRewardEdit.Click += new System.EventHandler(this.FileRewardEdit_Click);
            // 
            // ctlRewardRemove
            // 
            this.ctlRewardRemove.Name = "ctlRewardRemove";
            this.ctlRewardRemove.Size = new System.Drawing.Size(183, 22);
            this.ctlRewardRemove.Text = "Удалить";
            this.ctlRewardRemove.Click += new System.EventHandler(this.ctlFileRewardRemove_Click);
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
            // ctlContextRegisterReward
            // 
            this.ctlContextRegisterReward.Name = "ctlContextRegisterReward";
            this.ctlContextRegisterReward.Size = new System.Drawing.Size(220, 22);
            this.ctlContextRegisterReward.Text = "Зарегистрировать награду";
            this.ctlContextRegisterReward.Click += new System.EventHandler(this.ContextRegisterReward_Click);
            // 
            // ctlContextEditReward
            // 
            this.ctlContextEditReward.Name = "ctlContextEditReward";
            this.ctlContextEditReward.Size = new System.Drawing.Size(220, 22);
            this.ctlContextEditReward.Text = "Редактировать награду";
            this.ctlContextEditReward.Click += new System.EventHandler(this.ContextEditReward_Click);
            // 
            // ctlContextRemoveReward
            // 
            this.ctlContextRemoveReward.Name = "ctlContextRemoveReward";
            this.ctlContextRemoveReward.Size = new System.Drawing.Size(220, 22);
            this.ctlContextRemoveReward.Text = "Удалить награду";
            this.ctlContextRemoveReward.Click += new System.EventHandler(this.ContextRemoveReward_Click);
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
            this.ctlRewardPage.Size = new System.Drawing.Size(887, 385);
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
            this.dgvRewards.Size = new System.Drawing.Size(881, 379);
            this.dgvRewards.TabIndex = 1;
            this.dgvRewards.ColumnHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.Rewards_ColumnClick);
            this.dgvRewards.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgvRewards_MouseClick);
            // 
            // dgvTitle
            // 
            this.dgvTitle.ContextMenuStrip = this.ctlContextMenuReward;
            this.dgvTitle.DataPropertyName = "Title";
            this.dgvTitle.HeaderText = "Title";
            this.dgvTitle.Name = "dgvTitle";
            this.dgvTitle.ReadOnly = true;
            // 
            // ctlContextMenuReward
            // 
            this.ctlContextMenuReward.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ctlContextRegisterReward,
            this.ctlContextEditReward,
            this.ctlContextRemoveReward});
            this.ctlContextMenuReward.Name = "ctlContextMenuReward";
            this.ctlContextMenuReward.Size = new System.Drawing.Size(221, 70);
            // 
            // ctlEmployeePage
            // 
            this.ctlEmployeePage.Controls.Add(this.dgvEmployees);
            this.ctlEmployeePage.Location = new System.Drawing.Point(4, 22);
            this.ctlEmployeePage.Name = "ctlEmployeePage";
            this.ctlEmployeePage.Padding = new System.Windows.Forms.Padding(3);
            this.ctlEmployeePage.Size = new System.Drawing.Size(887, 385);
            this.ctlEmployeePage.TabIndex = 0;
            this.ctlEmployeePage.Text = "Пользователи";
            this.ctlEmployeePage.UseVisualStyleBackColor = true;
            // 
            // dgvEmployees
            // 
            this.dgvEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployees.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvLastName,
            this.dgvFirstName,
            this.dgvBirth,
            this.dgvAge,
            this.dgvReward,
            this.dgvID});
            this.dgvEmployees.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvEmployees.Location = new System.Drawing.Point(3, 3);
            this.dgvEmployees.Name = "dgvEmployees";
            this.dgvEmployees.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEmployees.Size = new System.Drawing.Size(881, 379);
            this.dgvEmployees.TabIndex = 0;
            this.dgvEmployees.ColumnHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.Employees_ColumnClick);
            this.dgvEmployees.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgvEmployees_MouseClick);
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
            // ctlTab
            // 
            this.ctlTab.Controls.Add(this.ctlEmployeePage);
            this.ctlTab.Controls.Add(this.ctlRewardPage);
            this.ctlTab.Dock = System.Windows.Forms.DockStyle.Top;
            this.ctlTab.Location = new System.Drawing.Point(0, 24);
            this.ctlTab.Name = "ctlTab";
            this.ctlTab.SelectedIndex = 0;
            this.ctlTab.Size = new System.Drawing.Size(895, 411);
            this.ctlTab.TabIndex = 5;
            // 
            // dgvLastName
            // 
            this.dgvLastName.ContextMenuStrip = this.ctlContextMenu;
            this.dgvLastName.DataPropertyName = "LastName";
            this.dgvLastName.HeaderText = "Фамилия";
            this.dgvLastName.Name = "dgvLastName";
            this.dgvLastName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // dgvFirstName
            // 
            this.dgvFirstName.ContextMenuStrip = this.ctlContextMenu;
            this.dgvFirstName.DataPropertyName = "FirstName";
            this.dgvFirstName.HeaderText = "Имя";
            this.dgvFirstName.Name = "dgvFirstName";
            this.dgvFirstName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // dgvBirth
            // 
            this.dgvBirth.ContextMenuStrip = this.ctlContextMenu;
            this.dgvBirth.DataPropertyName = "Birth";
            this.dgvBirth.HeaderText = "Дата рождения";
            this.dgvBirth.Name = "dgvBirth";
            this.dgvBirth.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // dgvAge
            // 
            this.dgvAge.ContextMenuStrip = this.ctlContextMenu;
            this.dgvAge.DataPropertyName = "Age";
            this.dgvAge.HeaderText = "Возраст";
            this.dgvAge.Name = "dgvAge";
            this.dgvAge.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // dgvReward
            // 
            this.dgvReward.ContextMenuStrip = this.ctlContextMenuReward;
            this.dgvReward.HeaderText = "Награды";
            this.dgvReward.Name = "dgvReward";
            this.dgvReward.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // dgvID
            // 
            this.dgvID.DataPropertyName = "ID";
            this.dgvID.HeaderText = "ID";
            this.dgvID.Name = "dgvID";
            this.dgvID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 436);
            this.Controls.Add(this.ctlTab);
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
            this.ctlRewardPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRewards)).EndInit();
            this.ctlContextMenuReward.ResumeLayout(false);
            this.ctlEmployeePage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployees)).EndInit();
            this.ctlContextMenu.ResumeLayout(false);
            this.ctlTab.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.MenuStrip mainMenu;
		private System.Windows.Forms.ToolStripMenuItem ctlEmployee;
		private System.Windows.Forms.ToolStripMenuItem ctlHelp;
		private System.Windows.Forms.ToolStripMenuItem ctlHelpAbout;
		private System.Windows.Forms.ToolStripMenuItem ctlRegister;
		private System.Windows.Forms.ToolStripMenuItem ctlEdit;
		private System.Windows.Forms.ToolStripMenuItem ctlRemove;
		private System.Windows.Forms.ContextMenuStrip ctlContextMenu;
		private System.Windows.Forms.ToolStripMenuItem ctlContextRegister;
		private System.Windows.Forms.ToolStripMenuItem ctlContextRemove;
		private System.Windows.Forms.ToolStripMenuItem ctlContextEdit;
		private System.Windows.Forms.Timer splashTimer;
        private System.Windows.Forms.TabPage ctlRewardPage;
        private System.Windows.Forms.TabPage ctlEmployeePage;
        public System.Windows.Forms.DataGridView dgvEmployees;
        private System.Windows.Forms.TabControl ctlTab;
        private System.Windows.Forms.DataGridView dgvRewards;
        private System.Windows.Forms.ToolStripMenuItem ctlFile;
        private System.Windows.Forms.ToolStripMenuItem ctlExit;
        private System.Windows.Forms.ToolStripMenuItem ctlRewards;
        private System.Windows.Forms.ToolStripMenuItem ctlRewardRegister;
        private System.Windows.Forms.ToolStripMenuItem ctlRewardEdit;
        private System.Windows.Forms.ToolStripMenuItem ctlRewardRemove;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTitle;
        private System.Windows.Forms.ContextMenuStrip ctlContextMenuReward;
        private System.Windows.Forms.ToolStripMenuItem ctlContextRegisterReward;
        private System.Windows.Forms.ToolStripMenuItem ctlContextRemoveReward;
        private System.Windows.Forms.ToolStripMenuItem ctlContextEditReward;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvLastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvFirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvBirth;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvAge;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvReward;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvID;
    }
}

