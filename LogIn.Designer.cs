namespace WindowsFormsApp1
{
    partial class LogIn
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
            this.DBSubmit = new System.Windows.Forms.Button();
            this.UserNameTextBox = new System.Windows.Forms.TextBox();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.UserNameLabel = new System.Windows.Forms.Label();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.CreateUserName = new System.Windows.Forms.GroupBox();
            this.LabelError2 = new System.Windows.Forms.Label();
            this.NoAccountLabel = new System.Windows.Forms.Label();
            this.OpenCreateCredentialsButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.CreateUserName.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // DBSubmit
            // 
            this.DBSubmit.Location = new System.Drawing.Point(118, 299);
            this.DBSubmit.Margin = new System.Windows.Forms.Padding(2);
            this.DBSubmit.Name = "DBSubmit";
            this.DBSubmit.Size = new System.Drawing.Size(57, 24);
            this.DBSubmit.TabIndex = 0;
            this.DBSubmit.Text = "Log In";
            this.DBSubmit.UseVisualStyleBackColor = true;
            this.DBSubmit.UseWaitCursor = true;
            this.DBSubmit.Click += new System.EventHandler(this.DBSubmit_Click);
            // 
            // UserNameTextBox
            // 
            this.UserNameTextBox.Location = new System.Drawing.Point(118, 238);
            this.UserNameTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.UserNameTextBox.Name = "UserNameTextBox";
            this.UserNameTextBox.Size = new System.Drawing.Size(188, 20);
            this.UserNameTextBox.TabIndex = 2;
            this.UserNameTextBox.UseWaitCursor = true;
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Location = new System.Drawing.Point(118, 275);
            this.PasswordTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.Size = new System.Drawing.Size(188, 20);
            this.PasswordTextBox.TabIndex = 3;
            this.PasswordTextBox.UseWaitCursor = true;
            // 
            // UserNameLabel
            // 
            this.UserNameLabel.AutoSize = true;
            this.UserNameLabel.Location = new System.Drawing.Point(115, 223);
            this.UserNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.UserNameLabel.Name = "UserNameLabel";
            this.UserNameLabel.Size = new System.Drawing.Size(57, 13);
            this.UserNameLabel.TabIndex = 4;
            this.UserNameLabel.Text = "UserName";
            this.UserNameLabel.UseWaitCursor = true;
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Location = new System.Drawing.Point(119, 260);
            this.PasswordLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(53, 13);
            this.PasswordLabel.TabIndex = 5;
            this.PasswordLabel.Text = "Password";
            this.PasswordLabel.UseWaitCursor = true;
            // 
            // CreateUserName
            // 
            this.CreateUserName.Controls.Add(this.LabelError2);
            this.CreateUserName.Controls.Add(this.NoAccountLabel);
            this.CreateUserName.Controls.Add(this.OpenCreateCredentialsButton);
            this.CreateUserName.Controls.Add(this.pictureBox1);
            this.CreateUserName.Controls.Add(this.PasswordTextBox);
            this.CreateUserName.Controls.Add(this.UserNameLabel);
            this.CreateUserName.Controls.Add(this.DBSubmit);
            this.CreateUserName.Controls.Add(this.PasswordLabel);
            this.CreateUserName.Controls.Add(this.UserNameTextBox);
            this.CreateUserName.Location = new System.Drawing.Point(141, 11);
            this.CreateUserName.Margin = new System.Windows.Forms.Padding(2);
            this.CreateUserName.Name = "CreateUserName";
            this.CreateUserName.Padding = new System.Windows.Forms.Padding(2);
            this.CreateUserName.Size = new System.Drawing.Size(452, 421);
            this.CreateUserName.TabIndex = 10;
            this.CreateUserName.TabStop = false;
            this.CreateUserName.UseWaitCursor = true;
            // 
            // LabelError2
            // 
            this.LabelError2.AutoSize = true;
            this.LabelError2.ForeColor = System.Drawing.Color.Red;
            this.LabelError2.Location = new System.Drawing.Point(115, 340);
            this.LabelError2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelError2.Name = "LabelError2";
            this.LabelError2.Size = new System.Drawing.Size(0, 13);
            this.LabelError2.TabIndex = 18;
            this.LabelError2.UseWaitCursor = true;
            // 
            // NoAccountLabel
            // 
            this.NoAccountLabel.AutoSize = true;
            this.NoAccountLabel.Location = new System.Drawing.Point(151, 363);
            this.NoAccountLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.NoAccountLabel.Name = "NoAccountLabel";
            this.NoAccountLabel.Size = new System.Drawing.Size(123, 13);
            this.NoAccountLabel.TabIndex = 16;
            this.NoAccountLabel.Text = "Dont Have an Account?";
            this.NoAccountLabel.UseWaitCursor = true;
            // 
            // OpenCreateCredentialsButton
            // 
            this.OpenCreateCredentialsButton.Location = new System.Drawing.Point(136, 378);
            this.OpenCreateCredentialsButton.Margin = new System.Windows.Forms.Padding(2);
            this.OpenCreateCredentialsButton.Name = "OpenCreateCredentialsButton";
            this.OpenCreateCredentialsButton.Size = new System.Drawing.Size(154, 29);
            this.OpenCreateCredentialsButton.TabIndex = 15;
            this.OpenCreateCredentialsButton.Text = "Create New Account ";
            this.OpenCreateCredentialsButton.UseVisualStyleBackColor = true;
            this.OpenCreateCredentialsButton.UseWaitCursor = true;
            this.OpenCreateCredentialsButton.Click += new System.EventHandler(this.OpenCreateCredentialsButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.BT_Logo;
            this.pictureBox1.Location = new System.Drawing.Point(114, 17);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(201, 201);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.UseWaitCursor = true;
            // 
            // LogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 452);
            this.Controls.Add(this.CreateUserName);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "LogIn";
            this.Text = "Form1";
            this.UseWaitCursor = true;
            this.CreateUserName.ResumeLayout(false);
            this.CreateUserName.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button DBSubmit;
        private System.Windows.Forms.TextBox UserNameTextBox;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.Label UserNameLabel;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox CreateUserName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label ErrorLabel;
        private System.Windows.Forms.Button OpenCreateCredentialsButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label NoAccountLabel;
        private System.Windows.Forms.Label LabelError2;
    }
}

