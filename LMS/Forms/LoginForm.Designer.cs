namespace LMS
{
    partial class LoginForm
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
            pictureBox1 = new System.Windows.Forms.PictureBox();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            UserNameTextBox = new System.Windows.Forms.TextBox();
            PasswordTextBox = new System.Windows.Forms.TextBox();
            groupBox1 = new System.Windows.Forms.GroupBox();
            ClearButton = new System.Windows.Forms.Button();
            LoginButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logo;
            pictureBox1.Location = new System.Drawing.Point(24, 121);
            pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(256, 320);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(82, 91);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(136, 24);
            label1.TabIndex = 1;
            label1.Text = "Username:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(82, 144);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(136, 24);
            label2.TabIndex = 2;
            label2.Text = "Password:";
            // 
            // UserNameTextBox
            // 
            UserNameTextBox.Location = new System.Drawing.Point(234, 91);
            UserNameTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            UserNameTextBox.Name = "UserNameTextBox";
            UserNameTextBox.Size = new System.Drawing.Size(207, 31);
            UserNameTextBox.TabIndex = 3;
            // 
            // PasswordTextBox
            // 
            PasswordTextBox.Location = new System.Drawing.Point(234, 137);
            PasswordTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            PasswordTextBox.Name = "PasswordTextBox";
            PasswordTextBox.PasswordChar = '*';
            PasswordTextBox.Size = new System.Drawing.Size(207, 31);
            PasswordTextBox.TabIndex = 4;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(ClearButton);
            groupBox1.Controls.Add(LoginButton);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(PasswordTextBox);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(UserNameTextBox);
            groupBox1.Font = new System.Drawing.Font("Lucida Console", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            groupBox1.Location = new System.Drawing.Point(286, 118);
            groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            groupBox1.Size = new System.Drawing.Size(483, 324);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Login";
            // 
            // ClearButton
            // 
            ClearButton.Location = new System.Drawing.Point(264, 209);
            ClearButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            ClearButton.Name = "ClearButton";
            ClearButton.Size = new System.Drawing.Size(132, 38);
            ClearButton.TabIndex = 6;
            ClearButton.Text = "Clear";
            ClearButton.UseVisualStyleBackColor = true;
            ClearButton.Click += ClearButton_Click;
            // 
            // LoginButton
            // 
            LoginButton.Location = new System.Drawing.Point(126, 209);
            LoginButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            LoginButton.Name = "LoginButton";
            LoginButton.Size = new System.Drawing.Size(132, 38);
            LoginButton.TabIndex = 5;
            LoginButton.Text = "Login";
            LoginButton.UseVisualStyleBackColor = true;
            LoginButton.Click += LoginButton_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 562);
            Controls.Add(groupBox1);
            Controls.Add(pictureBox1);
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "LoginForm";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "LMS - Login";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox UserNameTextBox;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button LoginButton;
    }
}

