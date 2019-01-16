namespace bee
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.assignJob = new System.Windows.Forms.Button();
            this.nextShift = new System.Windows.Forms.Button();
            this.workerBeeJob = new System.Windows.Forms.ComboBox();
            this.shifts = new System.Windows.Forms.NumericUpDown();
            this.report = new System.Windows.Forms.TextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.StartSimulation = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.Open = new System.Windows.Forms.ToolStripButton();
            this.сохранитьToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.печатьToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Bees = new System.Windows.Forms.Label();
            this.Flowers = new System.Windows.Forms.Label();
            this.HoneyInHive = new System.Windows.Forms.Label();
            this.NectarInFlowers = new System.Windows.Forms.Label();
            this.FramesRun = new System.Windows.Forms.Label();
            this.FrameRate = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.shifts)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // assignJob
            // 
            this.assignJob.Location = new System.Drawing.Point(10, 230);
            this.assignJob.Name = "assignJob";
            this.assignJob.Size = new System.Drawing.Size(75, 23);
            this.assignJob.TabIndex = 0;
            this.assignJob.Text = "assignJob";
            this.assignJob.UseVisualStyleBackColor = true;
            this.assignJob.Click += new System.EventHandler(this.assignJob_Click);
            // 
            // nextShift
            // 
            this.nextShift.Location = new System.Drawing.Point(118, 230);
            this.nextShift.Name = "nextShift";
            this.nextShift.Size = new System.Drawing.Size(75, 23);
            this.nextShift.TabIndex = 1;
            this.nextShift.Text = "nextShift";
            this.nextShift.UseVisualStyleBackColor = true;
            this.nextShift.Click += new System.EventHandler(this.nextShift_Click);
            // 
            // workerBeeJob
            // 
            this.workerBeeJob.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.workerBeeJob.FormattingEnabled = true;
            this.workerBeeJob.Items.AddRange(new object[] {
            "Nectar collector",
            "Honey manufacturing",
            "Egg care",
            "Baby bee tutoring",
            "Hive maintenance",
            "Sting patrol"});
            this.workerBeeJob.Location = new System.Drawing.Point(10, 203);
            this.workerBeeJob.Name = "workerBeeJob";
            this.workerBeeJob.Size = new System.Drawing.Size(87, 21);
            this.workerBeeJob.TabIndex = 2;
            // 
            // shifts
            // 
            this.shifts.Location = new System.Drawing.Point(118, 203);
            this.shifts.Name = "shifts";
            this.shifts.Size = new System.Drawing.Size(75, 20);
            this.shifts.TabIndex = 3;
            this.shifts.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // report
            // 
            this.report.Location = new System.Drawing.Point(10, 261);
            this.report.Multiline = true;
            this.report.Name = "report";
            this.report.Size = new System.Drawing.Size(183, 114);
            this.report.TabIndex = 4;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StartSimulation,
            this.toolStripButton2,
            this.Open,
            this.сохранитьToolStripButton,
            this.печатьToolStripButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(336, 25);
            this.toolStrip1.TabIndex = 5;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // StartSimulation
            // 
            this.StartSimulation.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.StartSimulation.Image = ((System.Drawing.Image)(resources.GetObject("StartSimulation.Image")));
            this.StartSimulation.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.StartSimulation.Name = "StartSimulation";
            this.StartSimulation.Size = new System.Drawing.Size(92, 22);
            this.StartSimulation.Text = "StartSimulation";
            this.StartSimulation.Click += new System.EventHandler(this.StartSimulation_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(39, 22);
            this.toolStripButton2.Text = "Reset";
            this.toolStripButton2.Click += new System.EventHandler(this.Reset_Click);
            // 
            // Open
            // 
            this.Open.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Open.Image = ((System.Drawing.Image)(resources.GetObject("Open.Image")));
            this.Open.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Open.Name = "Open";
            this.Open.Size = new System.Drawing.Size(23, 22);
            this.Open.Text = "&Открыть";
            this.Open.Click += new System.EventHandler(this.Open_Click);
            // 
            // сохранитьToolStripButton
            // 
            this.сохранитьToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.сохранитьToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("сохранитьToolStripButton.Image")));
            this.сохранитьToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.сохранитьToolStripButton.Name = "сохранитьToolStripButton";
            this.сохранитьToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.сохранитьToolStripButton.Text = "&Сохранить";
            this.сохранитьToolStripButton.Click += new System.EventHandler(this.Save_Click);
            // 
            // печатьToolStripButton
            // 
            this.печатьToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.печатьToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("печатьToolStripButton.Image")));
            this.печатьToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.печатьToolStripButton.Name = "печатьToolStripButton";
            this.печатьToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.печатьToolStripButton.Text = "&Печать";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Dock = System.Windows.Forms.DockStyle.Top;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 25);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(336, 22);
            this.statusStrip1.TabIndex = 6;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(45, 17);
            this.toolStripStatusLabel1.Text = "Paused";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.Bees, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.Flowers, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.HoneyInHive, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.NectarInFlowers, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.FramesRun, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.FrameRate, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 5);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(10, 50);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(183, 122);
            this.tableLayoutPanel1.TabIndex = 7;
            // 
            // Bees
            // 
            this.Bees.AutoSize = true;
            this.Bees.Location = new System.Drawing.Point(94, 0);
            this.Bees.Name = "Bees";
            this.Bees.Size = new System.Drawing.Size(31, 13);
            this.Bees.TabIndex = 8;
            this.Bees.Text = "Bees";
            // 
            // Flowers
            // 
            this.Flowers.AutoSize = true;
            this.Flowers.Location = new System.Drawing.Point(94, 21);
            this.Flowers.Name = "Flowers";
            this.Flowers.Size = new System.Drawing.Size(43, 13);
            this.Flowers.TabIndex = 8;
            this.Flowers.Text = "Flowers";
            // 
            // HoneyInHive
            // 
            this.HoneyInHive.AutoSize = true;
            this.HoneyInHive.Location = new System.Drawing.Point(94, 42);
            this.HoneyInHive.Name = "HoneyInHive";
            this.HoneyInHive.Size = new System.Drawing.Size(69, 13);
            this.HoneyInHive.TabIndex = 8;
            this.HoneyInHive.Text = "HoneyInHive";
            // 
            // NectarInFlowers
            // 
            this.NectarInFlowers.AutoSize = true;
            this.NectarInFlowers.Location = new System.Drawing.Point(94, 62);
            this.NectarInFlowers.Name = "NectarInFlowers";
            this.NectarInFlowers.Size = new System.Drawing.Size(84, 13);
            this.NectarInFlowers.TabIndex = 8;
            this.NectarInFlowers.Text = "NectarInFlowers";
            // 
            // FramesRun
            // 
            this.FramesRun.AutoSize = true;
            this.FramesRun.Location = new System.Drawing.Point(94, 82);
            this.FramesRun.Name = "FramesRun";
            this.FramesRun.Size = new System.Drawing.Size(61, 13);
            this.FramesRun.TabIndex = 8;
            this.FramesRun.Text = "FramesRun";
            // 
            // FrameRate
            // 
            this.FrameRate.AutoSize = true;
            this.FrameRate.Location = new System.Drawing.Point(94, 102);
            this.FrameRate.Name = "FrameRate";
            this.FrameRate.Size = new System.Drawing.Size(59, 13);
            this.FrameRate.TabIndex = 8;
            this.FrameRate.Text = "FrameRate";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Bees";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Flowers";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "HoneyInHive";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "NectarInFlowers";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "FramesRun";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 102);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "FrameRate";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(199, 51);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(134, 121);
            this.listBox1.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 379);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.report);
            this.Controls.Add(this.shifts);
            this.Controls.Add(this.workerBeeJob);
            this.Controls.Add(this.nextShift);
            this.Controls.Add(this.assignJob);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Move += new System.EventHandler(this.Form1_Move);
            ((System.ComponentModel.ISupportInitialize)(this.shifts)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button assignJob;
        private System.Windows.Forms.Button nextShift;
        private System.Windows.Forms.ComboBox workerBeeJob;
        private System.Windows.Forms.NumericUpDown shifts;
        private System.Windows.Forms.TextBox report;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton StartSimulation;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label Bees;
        private System.Windows.Forms.Label Flowers;
        private System.Windows.Forms.Label HoneyInHive;
        private System.Windows.Forms.Label NectarInFlowers;
        private System.Windows.Forms.Label FramesRun;
        private System.Windows.Forms.Label FrameRate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ToolStripButton Open;
        private System.Windows.Forms.ToolStripButton сохранитьToolStripButton;
        private System.Windows.Forms.ToolStripButton печатьToolStripButton;
    }
}

