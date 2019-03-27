namespace WindowsFormsApp1
{
    partial class LogOut
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
            this.LogOutGroupBox = new System.Windows.Forms.GroupBox();
            this.Question1Label = new System.Windows.Forms.Label();
            this.LogOutButton = new System.Windows.Forms.Button();
            this.ReturnButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LogOutGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // LogOutGroupBox
            // 
            this.LogOutGroupBox.Controls.Add(this.pictureBox1);
            this.LogOutGroupBox.Controls.Add(this.ReturnButton);
            this.LogOutGroupBox.Controls.Add(this.LogOutButton);
            this.LogOutGroupBox.Controls.Add(this.Question1Label);
            this.LogOutGroupBox.Location = new System.Drawing.Point(196, 12);
            this.LogOutGroupBox.Name = "LogOutGroupBox";
            this.LogOutGroupBox.Size = new System.Drawing.Size(463, 380);
            this.LogOutGroupBox.TabIndex = 0;
            this.LogOutGroupBox.TabStop = false;
            // 
            // Question1Label
            // 
            this.Question1Label.AutoSize = true;
            this.Question1Label.Location = new System.Drawing.Point(68, 236);
            this.Question1Label.Name = "Question1Label";
            this.Question1Label.Size = new System.Drawing.Size(281, 13);
            this.Question1Label.TabIndex = 0;
            this.Question1Label.Text = "Are you sure you would like you log out of the application?";
            // 
            // LogOutButton
            // 
            this.LogOutButton.Location = new System.Drawing.Point(104, 289);
            this.LogOutButton.Name = "LogOutButton";
            this.LogOutButton.Size = new System.Drawing.Size(75, 23);
            this.LogOutButton.TabIndex = 1;
            this.LogOutButton.Text = "Yes";
            this.LogOutButton.UseVisualStyleBackColor = true;
            this.LogOutButton.Click += new System.EventHandler(this.LogOutButton_Click);
            // 
            // ReturnButton
            // 
            this.ReturnButton.Location = new System.Drawing.Point(234, 289);
            this.ReturnButton.Name = "ReturnButton";
            this.ReturnButton.Size = new System.Drawing.Size(72, 23);
            this.ReturnButton.TabIndex = 2;
            this.ReturnButton.Text = "Cancel";
            this.ReturnButton.UseVisualStyleBackColor = true;
            this.ReturnButton.Click += new System.EventHandler(this.ReturnButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.BT_Logo;
            this.pictureBox1.Location = new System.Drawing.Point(104, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(202, 196);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // LogOut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LogOutGroupBox);
            this.Name = "LogOut";
            this.Text = "LogOut";
            this.LogOutGroupBox.ResumeLayout(false);
            this.LogOutGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox LogOutGroupBox;
        private System.Windows.Forms.Button ReturnButton;
        private System.Windows.Forms.Button LogOutButton;
        private System.Windows.Forms.Label Question1Label;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}