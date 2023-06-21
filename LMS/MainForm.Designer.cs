namespace LMS
{
    partial class MainForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            tabControl1 = new System.Windows.Forms.TabControl();
            tabPage1 = new System.Windows.Forms.TabPage();
            DataGridViewBooks = new System.Windows.Forms.DataGridView();
            groupBox2 = new System.Windows.Forms.GroupBox();
            button2 = new System.Windows.Forms.Button();
            button1 = new System.Windows.Forms.Button();
            textBox4 = new System.Windows.Forms.TextBox();
            label4 = new System.Windows.Forms.Label();
            textBox3 = new System.Windows.Forms.TextBox();
            label3 = new System.Windows.Forms.Label();
            textBox6 = new System.Windows.Forms.TextBox();
            label5 = new System.Windows.Forms.Label();
            groupBox1 = new System.Windows.Forms.GroupBox();
            label7 = new System.Windows.Forms.Label();
            comboBox1 = new System.Windows.Forms.ComboBox();
            textBox5 = new System.Windows.Forms.TextBox();
            label6 = new System.Windows.Forms.Label();
            textBox2 = new System.Windows.Forms.TextBox();
            label2 = new System.Windows.Forms.Label();
            textBox1 = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            tabPage2 = new System.Windows.Forms.TabPage();
            tabPage3 = new System.Windows.Forms.TabPage();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridViewBooks).BeginInit();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Font = new System.Drawing.Font("Lucida Console", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            tabControl1.Location = new System.Drawing.Point(7, 13);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new System.Drawing.Size(1363, 628);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(DataGridViewBooks);
            tabPage1.Controls.Add(groupBox2);
            tabPage1.Controls.Add(groupBox1);
            tabPage1.Location = new System.Drawing.Point(4, 27);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new System.Windows.Forms.Padding(3);
            tabPage1.Size = new System.Drawing.Size(1355, 597);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Dashboard";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // DataGridViewBooks
            // 
            DataGridViewBooks.BackgroundColor = System.Drawing.SystemColors.Control;
            DataGridViewBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Lucida Console", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            DataGridViewBooks.DefaultCellStyle = dataGridViewCellStyle1;
            DataGridViewBooks.Location = new System.Drawing.Point(318, 15);
            DataGridViewBooks.Name = "DataGridViewBooks";
            DataGridViewBooks.RowHeadersWidth = 51;
            DataGridViewBooks.RowTemplate.Height = 29;
            DataGridViewBooks.Size = new System.Drawing.Size(1031, 576);
            DataGridViewBooks.TabIndex = 5;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button2);
            groupBox2.Controls.Add(button1);
            groupBox2.Controls.Add(textBox4);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(textBox3);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(textBox6);
            groupBox2.Controls.Add(label5);
            groupBox2.Location = new System.Drawing.Point(9, 251);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new System.Drawing.Size(303, 184);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "Student Info";
            // 
            // button2
            // 
            button2.Location = new System.Drawing.Point(150, 135);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(94, 29);
            button2.TabIndex = 7;
            button2.Text = "Return";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new System.Drawing.Point(50, 135);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(94, 29);
            button1.TabIndex = 6;
            button1.Text = "Lend";
            button1.UseVisualStyleBackColor = true;
            // 
            // textBox4
            // 
            textBox4.Location = new System.Drawing.Point(127, 97);
            textBox4.Name = "textBox4";
            textBox4.Size = new System.Drawing.Size(163, 24);
            textBox4.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(6, 104);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(38, 17);
            label4.TabIndex = 4;
            label4.Text = "ID:";
            // 
            // textBox3
            // 
            textBox3.Location = new System.Drawing.Point(127, 66);
            textBox3.Name = "textBox3";
            textBox3.Size = new System.Drawing.Size(163, 24);
            textBox3.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(6, 73);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(108, 17);
            label3.TabIndex = 2;
            label3.Text = "Last Name:";
            // 
            // textBox6
            // 
            textBox6.Location = new System.Drawing.Point(127, 36);
            textBox6.Name = "textBox6";
            textBox6.Size = new System.Drawing.Size(163, 24);
            textBox6.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(6, 42);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(118, 17);
            label5.TabIndex = 0;
            label5.Text = "First Name:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(textBox5);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new System.Drawing.Point(9, 78);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(303, 167);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Book Info";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(6, 129);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(98, 17);
            label7.TabIndex = 7;
            label7.Text = "Category:";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Art", "Business", "Economics", "Mathematics", "Philosophy", "Science" });
            comboBox1.Location = new System.Drawing.Point(127, 121);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new System.Drawing.Size(163, 25);
            comboBox1.TabIndex = 6;
            // 
            // textBox5
            // 
            textBox5.Location = new System.Drawing.Point(127, 90);
            textBox5.Name = "textBox5";
            textBox5.Size = new System.Drawing.Size(163, 24);
            textBox5.TabIndex = 5;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(6, 97);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(78, 17);
            label6.TabIndex = 4;
            label6.Text = "Author:";
            // 
            // textBox2
            // 
            textBox2.Location = new System.Drawing.Point(127, 60);
            textBox2.Name = "textBox2";
            textBox2.Size = new System.Drawing.Size(163, 24);
            textBox2.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(6, 67);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(68, 17);
            label2.TabIndex = 2;
            label2.Text = "Title:";
            // 
            // textBox1
            // 
            textBox1.Location = new System.Drawing.Point(127, 30);
            textBox1.Name = "textBox1";
            textBox1.Size = new System.Drawing.Size(163, 24);
            textBox1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(6, 37);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(38, 17);
            label1.TabIndex = 0;
            label1.Text = "ID:";
            // 
            // tabPage2
            // 
            tabPage2.Location = new System.Drawing.Point(4, 27);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new System.Windows.Forms.Padding(3);
            tabPage2.Size = new System.Drawing.Size(1255, 597);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Books";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            tabPage3.Location = new System.Drawing.Point(4, 27);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new System.Drawing.Size(1255, 597);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Students";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1382, 653);
            Controls.Add(tabControl1);
            MaximizeBox = false;
            Name = "MainForm";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "MainForm";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DataGridViewBooks).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView DataGridViewBooks;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label7;
    }
}