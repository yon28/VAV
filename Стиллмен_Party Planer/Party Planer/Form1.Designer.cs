namespace Party_Planer
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.Party = new System.Windows.Forms.TabControl();
            this.dinnerParty1 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.Cost = new System.Windows.Forms.Label();
            this.labelCost = new System.Windows.Forms.TextBox();
            this.healthyBox = new System.Windows.Forms.CheckBox();
            this.fancyBox = new System.Windows.Forms.CheckBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.birthParty = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cakeWriting = new System.Windows.Forms.TextBox();
            this.labelCost2 = new System.Windows.Forms.TextBox();
            this.healthyBox2 = new System.Windows.Forms.CheckBox();
            this.fancyBox2 = new System.Windows.Forms.CheckBox();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.Party.SuspendLayout();
            this.dinnerParty1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.birthParty.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            this.SuspendLayout();
            // 
            // Party
            // 
            this.Party.Controls.Add(this.dinnerParty1);
            this.Party.Controls.Add(this.birthParty);
            this.Party.Location = new System.Drawing.Point(1, 1);
            this.Party.Name = "Party";
            this.Party.SelectedIndex = 0;
            this.Party.Size = new System.Drawing.Size(368, 200);
            this.Party.TabIndex = 4;
            // 
            // dinnerParty1
            // 
            this.dinnerParty1.Controls.Add(this.label2);
            this.dinnerParty1.Controls.Add(this.Cost);
            this.dinnerParty1.Controls.Add(this.labelCost);
            this.dinnerParty1.Controls.Add(this.healthyBox);
            this.dinnerParty1.Controls.Add(this.fancyBox);
            this.dinnerParty1.Controls.Add(this.numericUpDown1);
            this.dinnerParty1.Location = new System.Drawing.Point(4, 22);
            this.dinnerParty1.Name = "dinnerParty1";
            this.dinnerParty1.Padding = new System.Windows.Forms.Padding(3);
            this.dinnerParty1.Size = new System.Drawing.Size(360, 174);
            this.dinnerParty1.TabIndex = 0;
            this.dinnerParty1.Text = " DinnerParty";
            this.dinnerParty1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(102, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Number of People";
            // 
            // Cost
            // 
            this.Cost.AutoSize = true;
            this.Cost.Location = new System.Drawing.Point(102, 103);
            this.Cost.Name = "Cost";
            this.Cost.Size = new System.Drawing.Size(28, 13);
            this.Cost.TabIndex = 9;
            this.Cost.Text = "Cost";
            // 
            // labelCost
            // 
            this.labelCost.Location = new System.Drawing.Point(136, 100);
            this.labelCost.Name = "labelCost";
            this.labelCost.Size = new System.Drawing.Size(100, 20);
            this.labelCost.TabIndex = 7;
            // 
            // healthyBox
            // 
            this.healthyBox.AutoSize = true;
            this.healthyBox.Location = new System.Drawing.Point(105, 74);
            this.healthyBox.Name = "healthyBox";
            this.healthyBox.Size = new System.Drawing.Size(99, 17);
            this.healthyBox.TabIndex = 5;
            this.healthyBox.Text = " Healthy Option";
            this.healthyBox.UseVisualStyleBackColor = true;
            this.healthyBox.CheckedChanged += new System.EventHandler(this.healthyBox_CheckedChanged_1);
            // 
            // fancyBox
            // 
            this.fancyBox.AutoSize = true;
            this.fancyBox.Checked = true;
            this.fancyBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.fancyBox.Location = new System.Drawing.Point(105, 51);
            this.fancyBox.Name = "fancyBox";
            this.fancyBox.Size = new System.Drawing.Size(115, 17);
            this.fancyBox.TabIndex = 6;
            this.fancyBox.Text = "Fancy Decorations";
            this.fancyBox.UseVisualStyleBackColor = true;
            this.fancyBox.CheckedChanged += new System.EventHandler(this.fancyBox_CheckedChanged_1);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(200, 17);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(58, 20);
            this.numericUpDown1.TabIndex = 4;
            this.numericUpDown1.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged_1);
            // 
            // birthParty
            // 
            this.birthParty.Controls.Add(this.label1);
            this.birthParty.Controls.Add(this.label4);
            this.birthParty.Controls.Add(this.label3);
            this.birthParty.Controls.Add(this.cakeWriting);
            this.birthParty.Controls.Add(this.labelCost2);
            this.birthParty.Controls.Add(this.healthyBox2);
            this.birthParty.Controls.Add(this.fancyBox2);
            this.birthParty.Controls.Add(this.numericUpDown2);
            this.birthParty.Location = new System.Drawing.Point(4, 22);
            this.birthParty.Name = "birthParty";
            this.birthParty.Padding = new System.Windows.Forms.Padding(3);
            this.birthParty.Size = new System.Drawing.Size(360, 174);
            this.birthParty.TabIndex = 1;
            this.birthParty.Text = "BirthDayParty";
            this.birthParty.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(102, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Number of People";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(102, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Writing";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(102, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Cost";
            // 
            // cakeWriting
            // 
            this.cakeWriting.Location = new System.Drawing.Point(148, 111);
            this.cakeWriting.Name = "cakeWriting";
            this.cakeWriting.Size = new System.Drawing.Size(181, 20);
            this.cakeWriting.TabIndex = 13;
            this.cakeWriting.Text = "Happy Birthday";
            this.cakeWriting.TextChanged += new System.EventHandler(this.cakeWriting_TextChanged);
            // 
            // labelCost2
            // 
            this.labelCost2.Location = new System.Drawing.Point(136, 140);
            this.labelCost2.Name = "labelCost2";
            this.labelCost2.Size = new System.Drawing.Size(100, 20);
            this.labelCost2.TabIndex = 13;
            // 
            // healthyBox2
            // 
            this.healthyBox2.AutoSize = true;
            this.healthyBox2.Location = new System.Drawing.Point(105, 74);
            this.healthyBox2.Name = "healthyBox2";
            this.healthyBox2.Size = new System.Drawing.Size(99, 17);
            this.healthyBox2.TabIndex = 11;
            this.healthyBox2.Text = " Healthy Option";
            this.healthyBox2.UseVisualStyleBackColor = true;
            this.healthyBox2.CheckedChanged += new System.EventHandler(this.healthyBox2_CheckedChanged);
            // 
            // fancyBox2
            // 
            this.fancyBox2.AutoSize = true;
            this.fancyBox2.Checked = true;
            this.fancyBox2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.fancyBox2.Location = new System.Drawing.Point(105, 51);
            this.fancyBox2.Name = "fancyBox2";
            this.fancyBox2.Size = new System.Drawing.Size(115, 17);
            this.fancyBox2.TabIndex = 12;
            this.fancyBox2.Text = "Fancy Decorations";
            this.fancyBox2.UseVisualStyleBackColor = true;
            this.fancyBox2.CheckedChanged += new System.EventHandler(this.fancyBox2_CheckedChanged);
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(200, 17);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(58, 20);
            this.numericUpDown2.TabIndex = 10;
            this.numericUpDown2.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDown2.ValueChanged += new System.EventHandler(this.numericUpDown2_ValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 201);
            this.Controls.Add(this.Party);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Party.ResumeLayout(false);
            this.dinnerParty1.ResumeLayout(false);
            this.dinnerParty1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.birthParty.ResumeLayout(false);
            this.birthParty.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl Party;
        private System.Windows.Forms.TabPage dinnerParty1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Cost;
        private System.Windows.Forms.TextBox labelCost;
        private System.Windows.Forms.CheckBox healthyBox;
        private System.Windows.Forms.CheckBox fancyBox;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.TabPage birthParty;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox labelCost2;
        private System.Windows.Forms.CheckBox healthyBox2;
        private System.Windows.Forms.CheckBox fancyBox2;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox cakeWriting;
    }
}

