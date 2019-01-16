namespace bee
{
    partial class HiveForm
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
            this.SuspendLayout();
            // 
            // HiveForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(177, 151);
            this.Name = "HiveForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "HiveForm";
            this.Load += new System.EventHandler(this.The_Hive_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.HiveForm_MouseClick);
            this.ResumeLayout(false);

        }

        #endregion
    }
}