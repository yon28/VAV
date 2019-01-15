namespace bee
{
    partial class BeeControl
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
            this.animationTimer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // animationTimer1
            // 
            this.animationTimer1.Enabled = true;
            this.animationTimer1.Interval = 150;
            this.animationTimer1.Tick += new System.EventHandler(this.animationTimer1_Tick);
            // 
            // BeeControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(175, 135);
            this.Name = "BeeControl";
            this.Text = "BeeControl_";
            this.Load += new System.EventHandler(this.BeeControl_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer animationTimer1;
    }
}