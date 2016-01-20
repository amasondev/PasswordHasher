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
            this.SuspendLayout();
            // 
            // passBox
            // 
            this.passBox.AllowDrop = true;
            this.passBox.Location = new System.Drawing.Point(16, 44);
            this.passBox.Margin = new System.Windows.Forms.Padding(4);
            this.passBox.Name = "passBox";
            this.passBox.Size = new System.Drawing.Size(192, 22);
            this.passBox.TabIndex = 0;
            this.passBox.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Password:";
            // 
            // outputBox
            // 
            this.outputBox.Location = new System.Drawing.Point(15, 136);
            this.outputBox.Margin = new System.Windows.Forms.Padding(4);
            this.outputBox.Name = "outputBox";
            this.outputBox.ReadOnly = true;
            this.outputBox.Size = new System.Drawing.Size(309, 22);
            this.outputBox.TabIndex = 6;
            this.outputBox.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 109);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Output:";
            // 
            // saltBox
            // 
            this.saltBox.AllowDrop = true;
            this.saltBox.FormattingEnabled = true;
            this.saltBox.Location = new System.Drawing.Point(217, 43);
            this.saltBox.Margin = new System.Windows.Forms.Padding(4);
            this.saltBox.Name = "saltBox";
            this.saltBox.Size = new System.Drawing.Size(132, 24);
            this.saltBox.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(213, 23);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Salt:";
            // 
            // generateButton
            // 
            this.generateButton.Location = new System.Drawing.Point(440, 42);
            this.generateButton.Margin = new System.Windows.Forms.Padding(4);
            this.generateButton.Name = "generateButton";
            this.generateButton.Size = new System.Drawing.Size(172, 60);
            this.generateButton.TabIndex = 3;
            this.generateButton.Text = "Generate";
            this.generateButton.UseVisualStyleBackColor = true;
            this.generateButton.Click += new System.EventHandler(this.generateButton_Click);
            // 
            // removeSaltButton
            // 
            this.removeSaltButton.Location = new System.Drawing.Point(359, 43);
            this.removeSaltButton.Margin = new System.Windows.Forms.Padding(4);
            this.removeSaltButton.Name = "removeSaltButton";
            this.removeSaltButton.Size = new System.Drawing.Size(47, 26);
            this.removeSaltButton.TabIndex = 5;
            this.removeSaltButton.Text = "-";
            this.removeSaltButton.UseVisualStyleBackColor = true;
            this.removeSaltButton.Click += new System.EventHandler(this.removeSaltButton_Click);
            // 
            // sendButton
            // 
            this.sendButton.Location = new System.Drawing.Point(440, 114);
            this.sendButton.Margin = new System.Windows.Forms.Padding(4);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(172, 44);
            this.sendButton.TabIndex = 4;
            this.sendButton.Text = "Send";
            this.sendButton.UseVisualStyleBackColor = true;
            this.sendButton.Click += new System.EventHandler(this.sendButton_Click);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(139, 174);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(468, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Use the Send button to avoid using the insecure method of copy + paste.";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // displayCheckBox
            // 
            this.displayCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.displayCheckBox.AutoSize = true;
            this.displayCheckBox.Location = new System.Drawing.Point(330, 109);
            this.displayCheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.displayCheckBox.Name = "displayCheckBox";
            this.displayCheckBox.Size = new System.Drawing.Size(76, 21);
            this.displayCheckBox.TabIndex = 9;
            this.displayCheckBox.Text = "Display";
            this.displayCheckBox.UseVisualStyleBackColor = true;
            this.displayCheckBox.Click += new System.EventHandler(this.displayCheckBox_Click);
            // 
            // trayCheckBox
            // 
            this.trayCheckBox.AutoSize = true;
            this.trayCheckBox.Location = new System.Drawing.Point(16, 172);
            this.trayCheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.trayCheckBox.Name = "trayCheckBox";
            this.trayCheckBox.Size = new System.Drawing.Size(59, 21);
            this.trayCheckBox.TabIndex = 10;
            this.trayCheckBox.Text = "Tray";
            this.trayCheckBox.UseVisualStyleBackColor = true;
            this.trayCheckBox.CheckedChanged += new System.EventHandler(this.trayCheckBox_Click);
            // 
            // hashClearButton
            // 
            this.hashClearButton.Location = new System.Drawing.Point(331, 135);
            this.hashClearButton.Name = "hashClearButton";
            this.hashClearButton.Size = new System.Drawing.Size(75, 23);
            this.hashClearButton.TabIndex = 11;
            this.hashClearButton.Text = "Clear";
            this.hashClearButton.UseVisualStyleBackColor = true;
            this.hashClearButton.Click += new System.EventHandler(this.clearOutput);
            // 
            // Form1
            // 
            this.AcceptButton = this.generateButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 201);
            this.Controls.Add(this.hashClearButton);
            this.Controls.Add(this.trayCheckBox);
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
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Password Hasher";
            this.TopMost = true;
            this.Resize += new System.EventHandler(this.Form1_Resize);
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
    }
}

