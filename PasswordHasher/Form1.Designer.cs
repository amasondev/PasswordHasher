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
      this.components = new System.ComponentModel.Container();
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
      this.passBox = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.outputBox = new System.Windows.Forms.TextBox();
      this.label2 = new System.Windows.Forms.Label();
      this.saltBox = new System.Windows.Forms.ComboBox();
      this.label3 = new System.Windows.Forms.Label();
      this.removeSaltButton = new System.Windows.Forms.Button();
      this.sendButton = new System.Windows.Forms.Button();
      this.label4 = new System.Windows.Forms.Label();
      this.displayCheckBox = new System.Windows.Forms.CheckBox();
      this.trayCheckBox = new System.Windows.Forms.CheckBox();
      this.copyButton = new System.Windows.Forms.Button();
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.ontopCheckBox = new System.Windows.Forms.CheckBox();
      this.enterCheckBox = new System.Windows.Forms.CheckBox();
      this.groupBox2 = new System.Windows.Forms.GroupBox();
      this.label6 = new System.Windows.Forms.Label();
      this.lengthControl = new System.Windows.Forms.NumericUpDown();
      this.label5 = new System.Windows.Forms.Label();
      this.iterationsControl = new System.Windows.Forms.NumericUpDown();
      this.lowersCheckBox = new System.Windows.Forms.CheckBox();
      this.specialCheckBox = new System.Windows.Forms.CheckBox();
      this.numericCheckBox = new System.Windows.Forms.CheckBox();
      this.uppersCheckBox = new System.Windows.Forms.CheckBox();
      this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
      this.groupBox1.SuspendLayout();
      this.groupBox2.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.lengthControl)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.iterationsControl)).BeginInit();
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
      this.passBox.TextChanged += new System.EventHandler(this.passBox_TextChanged);
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
      this.outputBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.outputBox.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.outputBox.Location = new System.Drawing.Point(12, 238);
      this.outputBox.Name = "outputBox";
      this.outputBox.ReadOnly = true;
      this.outputBox.Size = new System.Drawing.Size(408, 20);
      this.outputBox.TabIndex = 6;
      this.toolTip1.SetToolTip(this.outputBox, "Other applications can read the clipboard without your knowledge. Use the Send bu" +
        "tton to send the output directly to a textbox in another window.");
      this.outputBox.UseSystemPasswordChar = true;
      // 
      // label2
      // 
      this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(9, 218);
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
      this.saltBox.Size = new System.Drawing.Size(147, 21);
      this.saltBox.TabIndex = 1;
      this.saltBox.SelectionChangeCommitted += new System.EventHandler(this.saltBox_SelectedIndexChanged);
      this.saltBox.TextUpdate += new System.EventHandler(this.saltBox_TextUpdate);
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(160, 19);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(46, 13);
      this.label3.TabIndex = 5;
      this.label3.Text = "Domain:";
      // 
      // removeSaltButton
      // 
      this.removeSaltButton.Location = new System.Drawing.Point(316, 34);
      this.removeSaltButton.Name = "removeSaltButton";
      this.removeSaltButton.Size = new System.Drawing.Size(35, 23);
      this.removeSaltButton.TabIndex = 5;
      this.removeSaltButton.Text = "-";
      this.removeSaltButton.UseVisualStyleBackColor = true;
      this.removeSaltButton.Click += new System.EventHandler(this.removeSaltButton_Click);
      // 
      // sendButton
      // 
      this.sendButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.sendButton.Location = new System.Drawing.Point(357, 34);
      this.sendButton.Name = "sendButton";
      this.sendButton.Size = new System.Drawing.Size(124, 47);
      this.sendButton.TabIndex = 4;
      this.sendButton.Text = "Send";
      this.sendButton.UseVisualStyleBackColor = true;
      this.sendButton.Click += new System.EventHandler(this.sendButton_Click);
      // 
      // label4
      // 
      this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(9, 269);
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
      this.displayCheckBox.Location = new System.Drawing.Point(57, 217);
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
      this.trayCheckBox.Location = new System.Drawing.Point(7, 19);
      this.trayCheckBox.Name = "trayCheckBox";
      this.trayCheckBox.Size = new System.Drawing.Size(98, 17);
      this.trayCheckBox.TabIndex = 10;
      this.trayCheckBox.Text = "Minimize to tray";
      this.trayCheckBox.UseVisualStyleBackColor = true;
      this.trayCheckBox.CheckedChanged += new System.EventHandler(this.trayCheckBox_Click);
      // 
      // copyButton
      // 
      this.copyButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.copyButton.Location = new System.Drawing.Point(425, 238);
      this.copyButton.Margin = new System.Windows.Forms.Padding(2);
      this.copyButton.Name = "copyButton";
      this.copyButton.Size = new System.Drawing.Size(56, 21);
      this.copyButton.TabIndex = 11;
      this.copyButton.Text = "Copy";
      this.copyButton.UseVisualStyleBackColor = true;
      this.copyButton.Click += new System.EventHandler(this.copyButtonClicked);
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.ontopCheckBox);
      this.groupBox1.Controls.Add(this.enterCheckBox);
      this.groupBox1.Controls.Add(this.trayCheckBox);
      this.groupBox1.Location = new System.Drawing.Point(12, 140);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(334, 69);
      this.groupBox1.TabIndex = 12;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Options";
      // 
      // ontopCheckBox
      // 
      this.ontopCheckBox.AutoSize = true;
      this.ontopCheckBox.Checked = true;
      this.ontopCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
      this.ontopCheckBox.Location = new System.Drawing.Point(111, 19);
      this.ontopCheckBox.Name = "ontopCheckBox";
      this.ontopCheckBox.Size = new System.Drawing.Size(92, 17);
      this.ontopCheckBox.TabIndex = 12;
      this.ontopCheckBox.Text = "Always on top";
      this.ontopCheckBox.UseVisualStyleBackColor = true;
      this.ontopCheckBox.CheckedChanged += new System.EventHandler(this.ontopCheckBox_CheckedChanged);
      // 
      // enterCheckBox
      // 
      this.enterCheckBox.AutoSize = true;
      this.enterCheckBox.Location = new System.Drawing.Point(7, 42);
      this.enterCheckBox.Name = "enterCheckBox";
      this.enterCheckBox.Size = new System.Drawing.Size(78, 17);
      this.enterCheckBox.TabIndex = 11;
      this.enterCheckBox.Text = "Send enter";
      this.enterCheckBox.UseVisualStyleBackColor = true;
      this.enterCheckBox.CheckedChanged += new System.EventHandler(this.enterCheckBox_CheckedChanged);
      // 
      // groupBox2
      // 
      this.groupBox2.Controls.Add(this.label6);
      this.groupBox2.Controls.Add(this.lengthControl);
      this.groupBox2.Controls.Add(this.label5);
      this.groupBox2.Controls.Add(this.iterationsControl);
      this.groupBox2.Controls.Add(this.lowersCheckBox);
      this.groupBox2.Controls.Add(this.specialCheckBox);
      this.groupBox2.Controls.Add(this.numericCheckBox);
      this.groupBox2.Controls.Add(this.uppersCheckBox);
      this.groupBox2.Location = new System.Drawing.Point(12, 62);
      this.groupBox2.Name = "groupBox2";
      this.groupBox2.Size = new System.Drawing.Size(334, 72);
      this.groupBox2.TabIndex = 13;
      this.groupBox2.TabStop = false;
      this.groupBox2.Text = "Hash Options";
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.Location = new System.Drawing.Point(232, 20);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(43, 13);
      this.label6.TabIndex = 7;
      this.label6.Text = "Length:";
      this.label6.TextAlign = System.Drawing.ContentAlignment.TopRight;
      // 
      // lengthControl
      // 
      this.lengthControl.Location = new System.Drawing.Point(281, 16);
      this.lengthControl.Maximum = new decimal(new int[] {
            256,
            0,
            0,
            0});
      this.lengthControl.Minimum = new decimal(new int[] {
            8,
            0,
            0,
            0});
      this.lengthControl.Name = "lengthControl";
      this.lengthControl.Size = new System.Drawing.Size(47, 20);
      this.lengthControl.TabIndex = 6;
      this.lengthControl.Value = new decimal(new int[] {
            32,
            0,
            0,
            0});
      this.lengthControl.ValueChanged += new System.EventHandler(this.lengthControl_ValueChanged);
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Location = new System.Drawing.Point(222, 43);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(53, 13);
      this.label5.TabIndex = 5;
      this.label5.Text = "Iterations:";
      this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
      // 
      // iterationsControl
      // 
      this.iterationsControl.Location = new System.Drawing.Point(281, 41);
      this.iterationsControl.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
      this.iterationsControl.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
      this.iterationsControl.Name = "iterationsControl";
      this.iterationsControl.Size = new System.Drawing.Size(47, 20);
      this.iterationsControl.TabIndex = 4;
      this.iterationsControl.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
      this.iterationsControl.ValueChanged += new System.EventHandler(this.iterationsControl_ValueChanged);
      // 
      // lowersCheckBox
      // 
      this.lowersCheckBox.AutoSize = true;
      this.lowersCheckBox.Checked = true;
      this.lowersCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
      this.lowersCheckBox.Location = new System.Drawing.Point(7, 42);
      this.lowersCheckBox.Name = "lowersCheckBox";
      this.lowersCheckBox.Size = new System.Drawing.Size(46, 17);
      this.lowersCheckBox.TabIndex = 3;
      this.lowersCheckBox.Text = "asdf";
      this.lowersCheckBox.UseVisualStyleBackColor = true;
      this.lowersCheckBox.CheckedChanged += new System.EventHandler(this.lowersCheckBox_CheckedChanged);
      // 
      // specialCheckBox
      // 
      this.specialCheckBox.AutoSize = true;
      this.specialCheckBox.Checked = true;
      this.specialCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
      this.specialCheckBox.Location = new System.Drawing.Point(123, 19);
      this.specialCheckBox.Name = "specialCheckBox";
      this.specialCheckBox.Size = new System.Drawing.Size(53, 17);
      this.specialCheckBox.TabIndex = 2;
      this.specialCheckBox.Text = "!@#$";
      this.specialCheckBox.UseVisualStyleBackColor = true;
      this.specialCheckBox.CheckedChanged += new System.EventHandler(this.specialCheckBox_CheckedChanged);
      // 
      // numericCheckBox
      // 
      this.numericCheckBox.AutoSize = true;
      this.numericCheckBox.Checked = true;
      this.numericCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
      this.numericCheckBox.Location = new System.Drawing.Point(67, 19);
      this.numericCheckBox.Name = "numericCheckBox";
      this.numericCheckBox.Size = new System.Drawing.Size(50, 17);
      this.numericCheckBox.TabIndex = 1;
      this.numericCheckBox.Text = "1234";
      this.numericCheckBox.UseVisualStyleBackColor = true;
      this.numericCheckBox.CheckedChanged += new System.EventHandler(this.numericCheckBox_CheckedChanged);
      // 
      // uppersCheckBox
      // 
      this.uppersCheckBox.AutoSize = true;
      this.uppersCheckBox.Checked = true;
      this.uppersCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
      this.uppersCheckBox.Location = new System.Drawing.Point(7, 19);
      this.uppersCheckBox.Name = "uppersCheckBox";
      this.uppersCheckBox.Size = new System.Drawing.Size(54, 17);
      this.uppersCheckBox.TabIndex = 0;
      this.uppersCheckBox.Text = "ASDF";
      this.uppersCheckBox.UseVisualStyleBackColor = true;
      this.uppersCheckBox.CheckedChanged += new System.EventHandler(this.uppersCheckBox_CheckedChanged);
      // 
      // toolTip1
      // 
      this.toolTip1.AutomaticDelay = 200;
      // 
      // Form1
      // 
      this.AcceptButton = this.sendButton;
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(492, 298);
      this.Controls.Add(this.groupBox1);
      this.Controls.Add(this.groupBox2);
      this.Controls.Add(this.copyButton);
      this.Controls.Add(this.displayCheckBox);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.sendButton);
      this.Controls.Add(this.removeSaltButton);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.saltBox);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.outputBox);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.passBox);
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.KeyPreview = true;
      this.MaximizeBox = false;
      this.MinimumSize = new System.Drawing.Size(500, 325);
      this.Name = "Form1";
      this.Text = "Password Hasher";
      this.TopMost = true;
      this.Load += new System.EventHandler(this.Form1_Load);
      this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
      this.Resize += new System.EventHandler(this.Form1_Resize);
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      this.groupBox2.ResumeLayout(false);
      this.groupBox2.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.lengthControl)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.iterationsControl)).EndInit();
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
        private System.Windows.Forms.Button removeSaltButton;
        private System.Windows.Forms.Button sendButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox displayCheckBox;
        private System.Windows.Forms.CheckBox trayCheckBox;
        private System.Windows.Forms.Button copyButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox enterCheckBox;
        private System.Windows.Forms.CheckBox ontopCheckBox;
    private System.Windows.Forms.GroupBox groupBox2;
    private System.Windows.Forms.CheckBox lowersCheckBox;
    private System.Windows.Forms.CheckBox specialCheckBox;
    private System.Windows.Forms.CheckBox numericCheckBox;
    private System.Windows.Forms.CheckBox uppersCheckBox;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.NumericUpDown lengthControl;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.NumericUpDown iterationsControl;
    private System.Windows.Forms.ToolTip toolTip1;
  }
}

