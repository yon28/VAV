namespace WinForms
{
	partial class EmployeeForm
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.lblFullName = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblBirth = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.lbLastName = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.lbRewards = new System.Windows.Forms.Label();
            this.chRewards = new System.Windows.Forms.CheckedListBox();
            this.dtBirth = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(300, 224);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Location = new System.Drawing.Point(220, 224);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 6;
            this.btnOK.Text = "Сохранить";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.OK_Click);
            // 
            // lblFullName
            // 
            this.lblFullName.AutoSize = true;
            this.lblFullName.Location = new System.Drawing.Point(12, 44);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(30, 13);
            this.lblFullName.TabIndex = 0;
            this.lblFullName.Text = "Имя:";
            // 
            // txtFirstName
            // 
            this.errorProvider.SetIconPadding(this.txtFirstName, 2);
            this.txtFirstName.Location = new System.Drawing.Point(124, 44);
            this.txtFirstName.MaxLength = 64;
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(248, 21);
            this.txtFirstName.TabIndex = 1;
            this.txtFirstName.Validating += new System.ComponentModel.CancelEventHandler(this.FirstName_Validating);
            this.txtFirstName.Validated += new System.EventHandler(this.FirstName_Validated);
            // 
            // lblBirth
            // 
            this.lblBirth.AutoSize = true;
            this.lblBirth.Location = new System.Drawing.Point(12, 71);
            this.lblBirth.Name = "lblBirth";
            this.lblBirth.Size = new System.Drawing.Size(91, 13);
            this.lblBirth.TabIndex = 4;
            this.lblBirth.Text = "Дата рождения:";
            // 
            // errorProvider
            // 
            this.errorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.AlwaysBlink;
            this.errorProvider.ContainerControl = this;
            // 
            // lbLastName
            // 
            this.lbLastName.AutoSize = true;
            this.lbLastName.Location = new System.Drawing.Point(12, 17);
            this.lbLastName.Name = "lbLastName";
            this.lbLastName.Size = new System.Drawing.Size(55, 13);
            this.lbLastName.TabIndex = 0;
            this.lbLastName.Text = "Фамилия:";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(124, 17);
            this.txtLastName.MaxLength = 64;
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(248, 21);
            this.txtLastName.TabIndex = 1;
            this.txtLastName.Validating += new System.ComponentModel.CancelEventHandler(this.LastName_Validating);
            this.txtLastName.Validated += new System.EventHandler(this.LastName_Validated);
            // 
            // lbRewards
            // 
            this.lbRewards.AutoSize = true;
            this.lbRewards.Location = new System.Drawing.Point(12, 98);
            this.lbRewards.Name = "lbRewards";
            this.lbRewards.Size = new System.Drawing.Size(56, 13);
            this.lbRewards.TabIndex = 0;
            this.lbRewards.Text = "Награды:";
            // 
            // chRewards
            // 
            this.chRewards.FormattingEnabled = true;
            this.chRewards.Location = new System.Drawing.Point(124, 98);
            this.chRewards.Name = "chRewards";
            this.chRewards.Size = new System.Drawing.Size(120, 84);
            this.chRewards.TabIndex = 8;
            // 
            // dtBirth
            // 
            this.dtBirth.Location = new System.Drawing.Point(124, 71);
            this.dtBirth.Name = "dtBirth";
            this.dtBirth.Size = new System.Drawing.Size(120, 21);
            this.dtBirth.TabIndex = 9;
            this.dtBirth.Value = new System.DateTime(2010, 11, 22, 0, 0, 0, 0);
            this.dtBirth.Validating += new System.ComponentModel.CancelEventHandler(this.Birth_Validating);
            this.dtBirth.Validated += new System.EventHandler(this.Birth_Validated);
            /////
            // 
            // EmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(390, 265);
            this.Controls.Add(this.dtBirth);
            this.Controls.Add(this.chRewards);
            this.Controls.Add(this.lblBirth);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.lbLastName);
            this.Controls.Add(this.lbRewards);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.lblFullName);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnCancel);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EmployeeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EmployeeForm";
            this.Load += new System.EventHandler(this.Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.Button btnOK;
		private System.Windows.Forms.Label lblFullName;
		private System.Windows.Forms.TextBox txtFirstName;
		private System.Windows.Forms.Label lblBirth;
		private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label lbLastName;
        private System.Windows.Forms.Label lbRewards;
        public System.Windows.Forms.CheckedListBox chRewards;
        private System.Windows.Forms.DateTimePicker dtBirth;
    }
}