namespace OpSysPolicies
{
    partial class Form1
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
            this.addBt = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.mpGb = new System.Windows.Forms.GroupBox();
            this.nextFitRb = new System.Windows.Forms.RadioButton();
            this.worstFitRb = new System.Windows.Forms.RadioButton();
            this.bestFitRb = new System.Windows.Forms.RadioButton();
            this.firstFitRb = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.pSizeTb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pNameTb = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.outPanel = new System.Windows.Forms.Panel();
            this.inPanel = new System.Windows.Forms.Panel();
            this.psGb = new System.Windows.Forms.GroupBox();
            this.sjnRb = new System.Windows.Forms.RadioButton();
            this.fbsRb = new System.Windows.Forms.RadioButton();
            this.rbsRb = new System.Windows.Forms.RadioButton();
            this.fcfsRb = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.doProcessBt = new System.Windows.Forms.Button();
            this.psRb = new System.Windows.Forms.RadioButton();
            this.mpRb = new System.Windows.Forms.RadioButton();
            this.bothRb = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.mpGb.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.outPanel.SuspendLayout();
            this.psGb.SuspendLayout();
            this.SuspendLayout();
            // 
            // addBt
            // 
            this.addBt.Location = new System.Drawing.Point(98, 87);
            this.addBt.Name = "addBt";
            this.addBt.Size = new System.Drawing.Size(75, 23);
            this.addBt.TabIndex = 1;
            this.addBt.Text = "Add Process";
            this.addBt.UseVisualStyleBackColor = true;
            this.addBt.Click += new System.EventHandler(this.addBt_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.radioButton3);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(216, 55);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(197, 440);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Memory";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(91, 131);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 9;
            this.textBox4.Text = "A";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Total Memory Size:";
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(25, 78);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(87, 17);
            this.radioButton3.TabIndex = 6;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "User Defined";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(25, 30);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(59, 17);
            this.radioButton1.TabIndex = 6;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Default";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(25, 55);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(65, 17);
            this.radioButton2.TabIndex = 7;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Random";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(98, 188);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Add Process";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.addBt_Click);
            // 
            // mpGb
            // 
            this.mpGb.Controls.Add(this.nextFitRb);
            this.mpGb.Controls.Add(this.worstFitRb);
            this.mpGb.Controls.Add(this.bestFitRb);
            this.mpGb.Controls.Add(this.firstFitRb);
            this.mpGb.Enabled = false;
            this.mpGb.Location = new System.Drawing.Point(419, 201);
            this.mpGb.Name = "mpGb";
            this.mpGb.Size = new System.Drawing.Size(197, 126);
            this.mpGb.TabIndex = 4;
            this.mpGb.TabStop = false;
            this.mpGb.Text = "Memory Management Policies";
            // 
            // nextFitRb
            // 
            this.nextFitRb.AutoSize = true;
            this.nextFitRb.Location = new System.Drawing.Point(25, 61);
            this.nextFitRb.Name = "nextFitRb";
            this.nextFitRb.Size = new System.Drawing.Size(61, 17);
            this.nextFitRb.TabIndex = 6;
            this.nextFitRb.Text = "Next-Fit";
            this.nextFitRb.UseVisualStyleBackColor = true;
            this.nextFitRb.CheckedChanged += new System.EventHandler(this.nextFitRb_CheckedChanged);
            // 
            // worstFitRb
            // 
            this.worstFitRb.AutoSize = true;
            this.worstFitRb.Location = new System.Drawing.Point(109, 28);
            this.worstFitRb.Name = "worstFitRb";
            this.worstFitRb.Size = new System.Drawing.Size(67, 17);
            this.worstFitRb.TabIndex = 5;
            this.worstFitRb.Text = "Worst-Fit";
            this.worstFitRb.UseVisualStyleBackColor = true;
            this.worstFitRb.CheckedChanged += new System.EventHandler(this.worstFitRb_CheckedChanged);
            // 
            // bestFitRb
            // 
            this.bestFitRb.AutoSize = true;
            this.bestFitRb.Location = new System.Drawing.Point(109, 61);
            this.bestFitRb.Name = "bestFitRb";
            this.bestFitRb.Size = new System.Drawing.Size(60, 17);
            this.bestFitRb.TabIndex = 5;
            this.bestFitRb.Text = "Best-Fit";
            this.bestFitRb.UseVisualStyleBackColor = true;
            this.bestFitRb.CheckedChanged += new System.EventHandler(this.bestFitRb_CheckedChanged);
            // 
            // firstFitRb
            // 
            this.firstFitRb.AutoSize = true;
            this.firstFitRb.Checked = true;
            this.firstFitRb.Location = new System.Drawing.Point(25, 28);
            this.firstFitRb.Name = "firstFitRb";
            this.firstFitRb.Size = new System.Drawing.Size(58, 17);
            this.firstFitRb.TabIndex = 5;
            this.firstFitRb.TabStop = true;
            this.firstFitRb.Text = "First-Fit";
            this.firstFitRb.UseVisualStyleBackColor = true;
            this.firstFitRb.CheckedChanged += new System.EventHandler(this.firstFitRb_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Controls.Add(this.pSizeTb);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.pNameTb);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.addBt);
            this.groupBox3.Location = new System.Drawing.Point(12, 55);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(197, 440);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Process";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(17, 87);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Clear All";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pSizeTb
            // 
            this.pSizeTb.Location = new System.Drawing.Point(73, 52);
            this.pSizeTb.Name = "pSizeTb";
            this.pSizeTb.Size = new System.Drawing.Size(100, 20);
            this.pSizeTb.TabIndex = 2;
            this.pSizeTb.Text = "100";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Size:";
            // 
            // pNameTb
            // 
            this.pNameTb.Location = new System.Drawing.Point(73, 26);
            this.pNameTb.Name = "pNameTb";
            this.pNameTb.Size = new System.Drawing.Size(100, 20);
            this.pNameTb.TabIndex = 2;
            this.pNameTb.Text = "A";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Name:";
            // 
            // outPanel
            // 
            this.outPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.outPanel.AutoScroll = true;
            this.outPanel.Controls.Add(this.inPanel);
            this.outPanel.Location = new System.Drawing.Point(725, 12);
            this.outPanel.Name = "outPanel";
            this.outPanel.Size = new System.Drawing.Size(307, 486);
            this.outPanel.TabIndex = 6;
            // 
            // inPanel
            // 
            this.inPanel.AutoSize = true;
            this.inPanel.Location = new System.Drawing.Point(11, 3);
            this.inPanel.Name = "inPanel";
            this.inPanel.Size = new System.Drawing.Size(236, 470);
            this.inPanel.TabIndex = 0;
            this.inPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.inPanel_Paint);
            // 
            // psGb
            // 
            this.psGb.Controls.Add(this.sjnRb);
            this.psGb.Controls.Add(this.fbsRb);
            this.psGb.Controls.Add(this.rbsRb);
            this.psGb.Controls.Add(this.fcfsRb);
            this.psGb.Enabled = false;
            this.psGb.Location = new System.Drawing.Point(419, 57);
            this.psGb.Name = "psGb";
            this.psGb.Size = new System.Drawing.Size(197, 126);
            this.psGb.TabIndex = 7;
            this.psGb.TabStop = false;
            this.psGb.Text = "Process Scheduling";
            // 
            // sjnRb
            // 
            this.sjnRb.AutoSize = true;
            this.sjnRb.Location = new System.Drawing.Point(25, 61);
            this.sjnRb.Name = "sjnRb";
            this.sjnRb.Size = new System.Drawing.Size(45, 17);
            this.sjnRb.TabIndex = 6;
            this.sjnRb.Text = "SJN";
            this.sjnRb.UseVisualStyleBackColor = true;
            // 
            // fbsRb
            // 
            this.fbsRb.AutoSize = true;
            this.fbsRb.Location = new System.Drawing.Point(109, 28);
            this.fbsRb.Name = "fbsRb";
            this.fbsRb.Size = new System.Drawing.Size(46, 17);
            this.fbsRb.TabIndex = 5;
            this.fbsRb.Text = "PBS";
            this.fbsRb.UseVisualStyleBackColor = true;
            // 
            // rbsRb
            // 
            this.rbsRb.AutoSize = true;
            this.rbsRb.Location = new System.Drawing.Point(109, 61);
            this.rbsRb.Name = "rbsRb";
            this.rbsRb.Size = new System.Drawing.Size(47, 17);
            this.rbsRb.TabIndex = 5;
            this.rbsRb.Text = "RBS";
            this.rbsRb.UseVisualStyleBackColor = true;
            // 
            // fcfsRb
            // 
            this.fcfsRb.AutoSize = true;
            this.fcfsRb.Checked = true;
            this.fcfsRb.Location = new System.Drawing.Point(25, 28);
            this.fcfsRb.Name = "fcfsRb";
            this.fcfsRb.Size = new System.Drawing.Size(51, 17);
            this.fcfsRb.TabIndex = 5;
            this.fcfsRb.TabStop = true;
            this.fcfsRb.Text = "FCFS";
            this.fcfsRb.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Perform:";
            // 
            // doProcessBt
            // 
            this.doProcessBt.Location = new System.Drawing.Point(541, 346);
            this.doProcessBt.Name = "doProcessBt";
            this.doProcessBt.Size = new System.Drawing.Size(75, 23);
            this.doProcessBt.TabIndex = 0;
            this.doProcessBt.Text = "GO";
            this.doProcessBt.UseVisualStyleBackColor = true;
            this.doProcessBt.Click += new System.EventHandler(this.doProcessBt_Click);
            // 
            // psRb
            // 
            this.psRb.AutoSize = true;
            this.psRb.Checked = true;
            this.psRb.Location = new System.Drawing.Point(87, 17);
            this.psRb.Name = "psRb";
            this.psRb.Size = new System.Drawing.Size(119, 17);
            this.psRb.TabIndex = 11;
            this.psRb.TabStop = true;
            this.psRb.Text = "Process Scheduling";
            this.psRb.UseVisualStyleBackColor = true;
            this.psRb.CheckedChanged += new System.EventHandler(this.psRb_CheckedChanged);
            // 
            // mpRb
            // 
            this.mpRb.AutoSize = true;
            this.mpRb.Location = new System.Drawing.Point(219, 17);
            this.mpRb.Name = "mpRb";
            this.mpRb.Size = new System.Drawing.Size(127, 17);
            this.mpRb.TabIndex = 11;
            this.mpRb.TabStop = true;
            this.mpRb.Text = "Memory Management";
            this.mpRb.UseVisualStyleBackColor = true;
            this.mpRb.CheckedChanged += new System.EventHandler(this.mpRb_CheckedChanged);
            // 
            // bothRb
            // 
            this.bothRb.AutoSize = true;
            this.bothRb.Location = new System.Drawing.Point(360, 17);
            this.bothRb.Name = "bothRb";
            this.bothRb.Size = new System.Drawing.Size(47, 17);
            this.bothRb.TabIndex = 11;
            this.bothRb.TabStop = true;
            this.bothRb.Text = "Both";
            this.bothRb.UseVisualStyleBackColor = true;
            this.bothRb.CheckedChanged += new System.EventHandler(this.bothRb_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1049, 510);
            this.Controls.Add(this.bothRb);
            this.Controls.Add(this.mpRb);
            this.Controls.Add(this.psRb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.psGb);
            this.Controls.Add(this.outPanel);
            this.Controls.Add(this.doProcessBt);
            this.Controls.Add(this.mpGb);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Operating System Project";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.mpGb.ResumeLayout(false);
            this.mpGb.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.outPanel.ResumeLayout(false);
            this.outPanel.PerformLayout();
            this.psGb.ResumeLayout(false);
            this.psGb.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addBt;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox mpGb;
        private System.Windows.Forms.RadioButton worstFitRb;
        private System.Windows.Forms.RadioButton bestFitRb;
        private System.Windows.Forms.RadioButton firstFitRb;
        private System.Windows.Forms.RadioButton nextFitRb;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox pSizeTb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox pNameTb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Panel outPanel;
        private System.Windows.Forms.Panel inPanel;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox psGb;
        private System.Windows.Forms.RadioButton sjnRb;
        private System.Windows.Forms.RadioButton fbsRb;
        private System.Windows.Forms.RadioButton rbsRb;
        private System.Windows.Forms.RadioButton fcfsRb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button doProcessBt;
        private System.Windows.Forms.RadioButton psRb;
        private System.Windows.Forms.RadioButton mpRb;
        private System.Windows.Forms.RadioButton bothRb;
    }
}

