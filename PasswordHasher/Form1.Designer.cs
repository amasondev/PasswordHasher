namespace PasswordHasher
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.passBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.outputBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.saltBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.generateButton = new System.Windows.Forms.Button();
            this.removeSaltButton = new System.Windows.Forms.Button();
            this.sendButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.displayCheckBox = new System.Windows.Forms.CheckBox();
            this.trayCheckBox = new System.Windows.Forms.CheckBox();
            this.hashClearButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.enterCheckBox = new System.Windows.Forms.CheckBox();
            this.ontopCheckBox = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // passBox
            // 
            this.passBox.AllowDrop = true;
            this.passBox.Location = new System.Drawing.Point(12, 36);
            this.passBox.Name = "passBox";
            this.passBox.Size = new System.Drawing.Size(145, 20);
            this.passBox.TabIndex = 0;
            this.passBox.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Password:";
            // 
            // outputBox
            // 
            this.outputBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.outputBox.Location = new System.Drawing.Point(12, 165);
            this.outputBox.Name = "outputBox";
            this.outputBox.ReadOnly = true;
            this.outputBox.Size = new System.Drawing.Size(232, 20);
            this.outputBox.TabIndex = 6;
            this.outputBox.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Output:";
            // 
            // saltBox
            // 
            this.saltBox.AllowDrop = true;
            this.saltBox.FormattingEnabled = true;
            this.saltBox.Location = new System.Drawing.Point(163, 35);
            this.saltBox.Name = "saltBox";
            this.saltBox.Size = new System.Drawing.Size(100, 21);
            this.saltBox.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(160, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Salt:";
            // 
            // generateButton
            // 
            this.generateButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.generateButton.Location = new System.Drawing.Point(330, 34);
            this.generateButton.Name = "generateButton";
            this.generateButton.Size = new System.Drawing.Size(129, 49);
            this.generateButton.TabIndex = 3;
            this.generateButton.Text = "Generate";
            this.generateButton.UseVisualStyleBackColor = true;
            this.generateButton.Click += new System.EventHandler(this.generateButton_Click);
            // 
            // removeSaltButton
            // 
            this.removeSaltButton.Location = new System.Drawing.Point(269, 35);
            this.removeSaltButton.Name = "removeSaltButton";
            this.removeSaltButton.Size = new System.Drawing.Size(35, 21);
            this.removeSaltButton.TabIndex = 5;
            this.removeSaltButton.Text = "-";
            this.removeSaltButton.UseVisualStyleBackColor = true;
            this.removeSaltButton.Click += new System.EventHandler(this.removeSaltButton_Click);
            // 
            // sendButton
            // 
            this.sendButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.sendButton.Location = new System.Drawing.Point(330, 93);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(129, 36);
            this.sendButton.TabIndex = 4;
            this.sendButton.Text = "Send";
            this.sendButton.UseVisualStyleBackColor = true;
            this.sendButton.Click += new System.EventHandler(this.sendButton_Click);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(352, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Use the Send button to avoid using the insecure method of copy + paste.";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // displayCheckBox
            // 
            this.displayCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.displayCheckBox.AutoSize = true;
            this.displayCheckBox.Location = new System.Drawing.Point(245, 144);
            this.displayCheckBox.Name = "displayCheckBox";
            this.displayCheckBox.Size = new System.Drawing.Size(60, 17);
            this.displayCheckBox.TabIndex = 9;
            this.displayCheckBox.Text = "Display";
            this.displayCheckBox.UseVisualStyleBackColor = true;
            this.displayCheckBox.Click += new System.EventHandler(this.displayCheckBox_Click);
            // 
            // trayCheckBox
            // 
            this.trayCheckBox.AutoSize = true;
            this.trayCheckBox.Location = new System.Drawing.Point(6, 19);
            this.trayCheckBox.Name = "trayCheckBox";
            this.trayCheckBox.Size = new System.Drawing.Size(98, 17);
            this.trayCheckBox.TabIndex = 10;
            this.trayCheckBox.Text = "Minimize to tray";
            this.trayCheckBox.UseVisualStyleBackColor = true;
            this.trayCheckBox.CheckedChanged += new System.EventHandler(this.trayCheckBox_Click);
            // 
            // hashClearButton
            // 
            this.hashClearButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.hashClearButton.Location = new System.Drawing.Point(248, 165);
            this.hashClearButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.hashClearButton.Name = "hashClearButton";
            this.hashClearButton.Size = new System.Drawing.Size(56, 19);
            this.hashClearButton.TabIndex = 11;
            this.hashClearButton.Text = "Clear";
            this.hashClearButton.UseVisualStyleBackColor = true;
            this.hashClearButton.Click += new System.EventHandler(this.clearOutput);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.ontopCheckBox);
            this.groupBox1.Controls.Add(this.enterCheckBox);
            this.groupBox1.Controls.Add(this.trayCheckBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 62);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(294, 69);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Options";
            // 
            // enterCheckBox
            // 
            this.enterCheckBox.AutoSize = true;
            this.enterCheckBox.Location = new System.Drawing.Point(6, 42);
            this.enterCheckBox.Name = "enterCheckBox";
            this.enterCheckBox.Size = new System.Drawing.Size(78, 17);
            this.enterCheckBox.TabIndex = 11;
            this.enterCheckBox.Text = "Send enter";
            this.enterCheckBox.UseVisualStyleBackColor = true;
            this.enterCheckBox.CheckedChanged += new System.EventHandler(this.enterCheckBox_CheckedChanged);
            // 
            // ontopCheckBox
            // 
            this.ontopCheckBox.AutoSize = true;
            this.ontopCheckBox.Checked = true;
            this.ontopCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ontopCheckBox.Location = new System.Drawing.Point(111, 20);
            this.ontopCheckBox.Name = "ontopCheckBox";
            this.ontopCheckBox.Size = new System.Drawing.Size(92, 17);
            this.ontopCheckBox.TabIndex = 12;
            this.ontopCheckBox.Text = "Always on top";
            this.ontopCheckBox.UseVisualStyleBackColor = true;
            this.ontopCheckBox.CheckedChanged += new System.EventHandler(this.ontopCheckBox_CheckedChanged);
            // 
            // Form1
            // 
            this.AcceptButton = this.generateButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 218);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.hashClearButton);
            this.Controls.Add(this.displayCheckBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.sendButton);
            this.Controls.Add(this.removeSaltButton);
            this.Controls.Add(this.generateButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.saltBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.outputBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.passBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Password Hasher";
            this.TopMost = true;
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox passBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox outputBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox saltBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button generateButton;
        private System.Windows.Forms.Button removeSaltButton;
        private System.Windows.Forms.Button sendButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox displayCheckBox;
        private System.Windows.Forms.CheckBox trayCheckBox;
        private System.Windows.Forms.Button hashClearButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox enterCheckBox;
        private System.Windows.Forms.CheckBox ontopCheckBox;
    }
}

