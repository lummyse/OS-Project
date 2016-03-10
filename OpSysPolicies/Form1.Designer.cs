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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.outPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // addBt
            // 
            this.addBt.Location = new System.Drawing.Point(98, 87);
            this.addBt.Name = "addBt";
            this.addBt.Size = new System.Drawing.Size(75, 23);
            this.addBt.TabIndex = 0;
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
            this.groupBox1.Location = new System.Drawing.Point(216, 142);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(197, 245);
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
            this.radioButton3.Location = new System.Drawing.Point(25, 72);
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
            this.radioButton1.Location = new System.Drawing.Point(25, 39);
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
            this.radioButton2.Location = new System.Drawing.Point(98, 39);
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.nextFitRb);
            this.groupBox2.Controls.Add(this.worstFitRb);
            this.groupBox2.Controls.Add(this.bestFitRb);
            this.groupBox2.Controls.Add(this.firstFitRb);
            this.groupBox2.Location = new System.Drawing.Point(12, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(197, 126);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Policies";
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
            this.bestFitRb.Checked = true;
            this.bestFitRb.Location = new System.Drawing.Point(109, 61);
            this.bestFitRb.Name = "bestFitRb";
            this.bestFitRb.Size = new System.Drawing.Size(60, 17);
            this.bestFitRb.TabIndex = 5;
            this.bestFitRb.TabStop = true;
            this.bestFitRb.Text = "Best-Fit";
            this.bestFitRb.UseVisualStyleBackColor = true;
            this.bestFitRb.CheckedChanged += new System.EventHandler(this.bestFitRb_CheckedChanged);
            // 
            // firstFitRb
            // 
            this.firstFitRb.AutoSize = true;
            this.firstFitRb.Location = new System.Drawing.Point(25, 28);
            this.firstFitRb.Name = "firstFitRb";
            this.firstFitRb.Size = new System.Drawing.Size(58, 17);
            this.firstFitRb.TabIndex = 5;
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
            this.groupBox3.Location = new System.Drawing.Point(216, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(197, 126);
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
            this.outPanel.Location = new System.Drawing.Point(589, 12);
            this.outPanel.Name = "outPanel";
            this.outPanel.Size = new System.Drawing.Size(265, 486);
            this.outPanel.TabIndex = 6;
            // 
            // inPanel
            // 
            this.inPanel.AutoSize = true;
            this.inPanel.Location = new System.Drawing.Point(3, 13);
            this.inPanel.Name = "inPanel";
            this.inPanel.Size = new System.Drawing.Size(236, 470);
            this.inPanel.TabIndex = 0;
            this.inPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.inPanel_Paint);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Control;
            this.textBox1.Location = new System.Drawing.Point(406, 443);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(158, 20);
            this.textBox1.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 510);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.outPanel);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Operating System Project";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.outPanel.ResumeLayout(false);
            this.outPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addBt;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
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
        private System.Windows.Forms.TextBox textBox1;
    }
}

