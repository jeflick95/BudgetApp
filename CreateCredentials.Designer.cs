namespace WindowsFormsApp1
{
    partial class CreateCredentials
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CreateUserNameTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CreatePasswordTextBox = new System.Windows.Forms.TextBox();
            this.CreateConfirmPasswordTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LabelError2 = new System.Windows.Forms.Label();
            this.CreateCredentialButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.BT_Logo;
            this.pictureBox1.Location = new System.Drawing.Point(201, 17);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(202, 200);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(203, 234);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "UserName";
            // 
            // CreateUserNameTextBox
            // 
            this.CreateUserNameTextBox.Location = new System.Drawing.Point(206, 249);
            this.CreateUserNameTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.CreateUserNameTextBox.Name = "CreateUserNameTextBox";
            this.CreateUserNameTextBox.Size = new System.Drawing.Size(185, 20);
            this.CreateUserNameTextBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(207, 274);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(207, 311);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Confirm Password";
            // 
            // CreatePasswordTextBox
            // 
            this.CreatePasswordTextBox.Location = new System.Drawing.Point(206, 289);
            this.CreatePasswordTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.CreatePasswordTextBox.Name = "CreatePasswordTextBox";
            this.CreatePasswordTextBox.Size = new System.Drawing.Size(185, 20);
            this.CreatePasswordTextBox.TabIndex = 5;
            // 
            // CreateConfirmPasswordTextBox
            // 
            this.CreateConfirmPasswordTextBox.Location = new System.Drawing.Point(206, 326);
            this.CreateConfirmPasswordTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.CreateConfirmPasswordTextBox.Name = "CreateConfirmPasswordTextBox";
            this.CreateConfirmPasswordTextBox.Size = new System.Drawing.Size(185, 20);
            this.CreateConfirmPasswordTextBox.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LabelError2);
            this.groupBox1.Controls.Add(this.CreateConfirmPasswordTextBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.CreatePasswordTextBox);
            this.groupBox1.Controls.Add(this.CreateCredentialButton);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.CreateUserNameTextBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(76, 24);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(572, 526);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // LabelError2
            // 
            this.LabelError2.AutoSize = true;
            this.LabelError2.ForeColor = System.Drawing.Color.Red;
            this.LabelError2.Location = new System.Drawing.Point(207, 357);
            this.LabelError2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelError2.Name = "LabelError2";
            this.LabelError2.Size = new System.Drawing.Size(0, 13);
            this.LabelError2.TabIndex = 7;
            // 
            // CreateCredentialButton
            // 
            this.CreateCredentialButton.Location = new System.Drawing.Point(206, 382);
            this.CreateCredentialButton.Margin = new System.Windows.Forms.Padding(2);
            this.CreateCredentialButton.Name = "CreateCredentialButton";
            this.CreateCredentialButton.Size = new System.Drawing.Size(56, 25);
            this.CreateCredentialButton.TabIndex = 0;
            this.CreateCredentialButton.Text = "Submit";
            this.CreateCredentialButton.UseVisualStyleBackColor = true;
            this.CreateCredentialButton.Click += new System.EventHandler(this.CreateCredentialButton_Click);
            // 
            // CreateCredentials
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 575);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "CreateCredentials";
            this.Text = "CreateCredentials";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox CreateUserNameTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox CreatePasswordTextBox;
        private System.Windows.Forms.TextBox CreateConfirmPasswordTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button CreateCredentialButton;
        private System.Windows.Forms.Label LabelError;
        private System.Windows.Forms.Label LabelError2;
    }
}