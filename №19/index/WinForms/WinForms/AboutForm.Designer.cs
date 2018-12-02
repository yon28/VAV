namespace WinForms
{
	partial class AboutForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutForm));
            this.ctlPicture = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ctlPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // ctlPicture
            // 
            this.ctlPicture.Image = ((System.Drawing.Image)(resources.GetObject("ctlPicture.Image")));
            this.ctlPicture.Location = new System.Drawing.Point(-37, 83);
            this.ctlPicture.Name = "ctlPicture";
            this.ctlPicture.Size = new System.Drawing.Size(376, 56);
            this.ctlPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ctlPicture.TabIndex = 5;
            this.ctlPicture.TabStop = false;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(-33, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(368, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Copyright (c) 2014";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(-37, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(372, 36);
            this.label1.TabIndex = 3;
            this.label1.Text = "NET_2014";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AboutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 211);
            this.Controls.Add(this.ctlPicture);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AboutForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AboutForm";
            this.Load += new System.EventHandler(this.AboutForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ctlPicture)).EndInit();
            this.ResumeLayout(false);

		}

        #endregion

        private System.Windows.Forms.PictureBox ctlPicture;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}