namespace WinForms
{
    partial class DelReward
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
            this.lblDelReward2 = new System.Windows.Forms.Label();
            this.lblDelReward = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblDelReward2
            // 
            this.lblDelReward2.AutoSize = true;
            this.lblDelReward2.Location = new System.Drawing.Point(37, 68);
            this.lblDelReward2.Name = "lblDelReward2";
            this.lblDelReward2.Size = new System.Drawing.Size(299, 13);
            this.lblDelReward2.TabIndex = 14;
            this.lblDelReward2.Text = "При этом награда также удалится у всех пользователей.";
            // 
            // lblDelReward
            // 
            this.lblDelReward.AutoSize = true;
            this.lblDelReward.Location = new System.Drawing.Point(37, 42);
            this.lblDelReward.Name = "lblDelReward";
            this.lblDelReward.Size = new System.Drawing.Size(283, 13);
            this.lblDelReward.TabIndex = 15;
            this.lblDelReward.Text = "Вы действительно хотите удалить награду из списка?";
            // 
            // btnOK
            // 
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Location = new System.Drawing.Point(256, 128);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 16;
            this.btnOK.Text = "Да";
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(336, 128);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 17;
            this.btnCancel.Text = "Нет";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // DelReward
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 185);
            this.Controls.Add(this.lblDelReward2);
            this.Controls.Add(this.lblDelReward);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnCancel);
            this.Name = "DelReward";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "DelReward";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDelReward2;
        private System.Windows.Forms.Label lblDelReward;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
    }
}