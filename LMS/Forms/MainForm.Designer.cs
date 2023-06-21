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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            tabControl1 = new System.Windows.Forms.TabControl();
            tabPage1 = new System.Windows.Forms.TabPage();
            groupBox3 = new System.Windows.Forms.GroupBox();
            label3 = new System.Windows.Forms.Label();
            textBox1 = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            BookIdTextBox = new System.Windows.Forms.TextBox();
            DataGridViewBorrowedBooks = new System.Windows.Forms.DataGridView();
            groupBox2 = new System.Windows.Forms.GroupBox();
            label10 = new System.Windows.Forms.Label();
            label11 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label9 = new System.Windows.Forms.Label();
            label12 = new System.Windows.Forms.Label();
            label13 = new System.Windows.Forms.Label();
            label14 = new System.Windows.Forms.Label();
            groupBox1 = new System.Windows.Forms.GroupBox();
            BookTitleLabel = new System.Windows.Forms.Label();
            BookCategoryLabel = new System.Windows.Forms.Label();
            BookAuthorLabel = new System.Windows.Forms.Label();
            StockLabel = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            tabPage2 = new System.Windows.Forms.TabPage();
            DataGridViewBooks = new System.Windows.Forms.DataGridView();
            tabPage3 = new System.Windows.Forms.TabPage();
            DataGridViewStudents = new System.Windows.Forms.DataGridView();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridViewBorrowedBooks).BeginInit();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridViewBooks).BeginInit();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridViewStudents).BeginInit();
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
            tabPage1.Controls.Add(groupBox3);
            tabPage1.Controls.Add(DataGridViewBorrowedBooks);
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
            // groupBox3
            // 
            groupBox3.Controls.Add(label3);
            groupBox3.Controls.Add(textBox1);
            groupBox3.Controls.Add(label1);
            groupBox3.Controls.Add(BookIdTextBox);
            groupBox3.Location = new System.Drawing.Point(1, 42);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new System.Drawing.Size(397, 119);
            groupBox3.TabIndex = 6;
            groupBox3.TabStop = false;
            groupBox3.Text = "ID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(88, 72);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(88, 17);
            label3.TabIndex = 2;
            label3.Text = "Student:";
            // 
            // textBox1
            // 
            textBox1.Location = new System.Drawing.Point(182, 65);
            textBox1.Name = "textBox1";
            textBox1.Size = new System.Drawing.Size(116, 24);
            textBox1.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(88, 34);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(58, 17);
            label1.TabIndex = 0;
            label1.Text = "Book:";
            // 
            // BookIdTextBox
            // 
            BookIdTextBox.Location = new System.Drawing.Point(182, 27);
            BookIdTextBox.Name = "BookIdTextBox";
            BookIdTextBox.Size = new System.Drawing.Size(116, 24);
            BookIdTextBox.TabIndex = 1;
            // 
            // DataGridViewBorrowedBooks
            // 
            DataGridViewBorrowedBooks.BackgroundColor = System.Drawing.SystemColors.Control;
            DataGridViewBorrowedBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Lucida Console", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            DataGridViewBorrowedBooks.DefaultCellStyle = dataGridViewCellStyle1;
            DataGridViewBorrowedBooks.Location = new System.Drawing.Point(404, 15);
            DataGridViewBorrowedBooks.Name = "DataGridViewBorrowedBooks";
            DataGridViewBorrowedBooks.RowHeadersWidth = 51;
            DataGridViewBorrowedBooks.RowTemplate.Height = 29;
            DataGridViewBorrowedBooks.Size = new System.Drawing.Size(945, 576);
            DataGridViewBorrowedBooks.TabIndex = 5;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(label11);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(label12);
            groupBox2.Controls.Add(label13);
            groupBox2.Controls.Add(label14);
            groupBox2.Location = new System.Drawing.Point(7, 358);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new System.Drawing.Size(392, 180);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "Student Info";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new System.Drawing.Point(130, 140);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(48, 17);
            label10.TabIndex = 22;
            label10.Text = "Year";
            label10.Visible = false;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new System.Drawing.Point(6, 140);
            label11.Name = "label11";
            label11.Size = new System.Drawing.Size(58, 17);
            label11.TabIndex = 21;
            label11.Text = "Year:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(130, 46);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(108, 17);
            label4.TabIndex = 20;
            label4.Text = "First Name";
            label4.Visible = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(130, 107);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(108, 17);
            label5.TabIndex = 19;
            label5.Text = "Department";
            label5.Visible = false;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new System.Drawing.Point(130, 76);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(98, 17);
            label9.TabIndex = 18;
            label9.Text = "Last Name";
            label9.Visible = false;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new System.Drawing.Point(6, 107);
            label12.Name = "label12";
            label12.Size = new System.Drawing.Size(118, 17);
            label12.TabIndex = 15;
            label12.Text = "Department:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new System.Drawing.Point(6, 76);
            label13.Name = "label13";
            label13.Size = new System.Drawing.Size(108, 17);
            label13.TabIndex = 14;
            label13.Text = "Last Name:";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new System.Drawing.Point(6, 46);
            label14.Name = "label14";
            label14.Size = new System.Drawing.Size(118, 17);
            label14.TabIndex = 13;
            label14.Text = "First Name:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(BookTitleLabel);
            groupBox1.Controls.Add(BookCategoryLabel);
            groupBox1.Controls.Add(BookAuthorLabel);
            groupBox1.Controls.Add(StockLabel);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new System.Drawing.Point(4, 167);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(392, 185);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Book Info";
            // 
            // BookTitleLabel
            // 
            BookTitleLabel.AutoSize = true;
            BookTitleLabel.Location = new System.Drawing.Point(133, 50);
            BookTitleLabel.Name = "BookTitleLabel";
            BookTitleLabel.Size = new System.Drawing.Size(58, 17);
            BookTitleLabel.TabIndex = 12;
            BookTitleLabel.Text = "Title";
            BookTitleLabel.Visible = false;
            // 
            // BookCategoryLabel
            // 
            BookCategoryLabel.AutoSize = true;
            BookCategoryLabel.Location = new System.Drawing.Point(133, 111);
            BookCategoryLabel.Name = "BookCategoryLabel";
            BookCategoryLabel.Size = new System.Drawing.Size(88, 17);
            BookCategoryLabel.TabIndex = 11;
            BookCategoryLabel.Text = "Category";
            BookCategoryLabel.Visible = false;
            // 
            // BookAuthorLabel
            // 
            BookAuthorLabel.AutoSize = true;
            BookAuthorLabel.Location = new System.Drawing.Point(133, 80);
            BookAuthorLabel.Name = "BookAuthorLabel";
            BookAuthorLabel.Size = new System.Drawing.Size(68, 17);
            BookAuthorLabel.TabIndex = 10;
            BookAuthorLabel.Text = "Author";
            BookAuthorLabel.Visible = false;
            // 
            // StockLabel
            // 
            StockLabel.AutoSize = true;
            StockLabel.Location = new System.Drawing.Point(133, 141);
            StockLabel.Name = "StockLabel";
            StockLabel.Size = new System.Drawing.Size(18, 17);
            StockLabel.TabIndex = 9;
            StockLabel.Text = "0";
            StockLabel.Visible = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new System.Drawing.Point(6, 141);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(68, 17);
            label8.TabIndex = 8;
            label8.Text = "Stock:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(6, 111);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(98, 17);
            label7.TabIndex = 7;
            label7.Text = "Category:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(6, 80);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(78, 17);
            label6.TabIndex = 4;
            label6.Text = "Author:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(6, 50);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(68, 17);
            label2.TabIndex = 2;
            label2.Text = "Title:";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(DataGridViewBooks);
            tabPage2.Location = new System.Drawing.Point(4, 27);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new System.Windows.Forms.Padding(3);
            tabPage2.Size = new System.Drawing.Size(1355, 597);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Books";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // DataGridViewBooks
            // 
            DataGridViewBooks.BackgroundColor = System.Drawing.SystemColors.Control;
            DataGridViewBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Lucida Console", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            DataGridViewBooks.DefaultCellStyle = dataGridViewCellStyle2;
            DataGridViewBooks.Location = new System.Drawing.Point(404, 15);
            DataGridViewBooks.Name = "DataGridViewBooks";
            DataGridViewBooks.RowHeadersWidth = 51;
            DataGridViewBooks.RowTemplate.Height = 29;
            DataGridViewBooks.Size = new System.Drawing.Size(945, 576);
            DataGridViewBooks.TabIndex = 6;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(DataGridViewStudents);
            tabPage3.Location = new System.Drawing.Point(4, 27);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new System.Drawing.Size(1355, 597);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Students";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // DataGridViewStudents
            // 
            DataGridViewStudents.BackgroundColor = System.Drawing.SystemColors.Control;
            DataGridViewStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Lucida Console", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            DataGridViewStudents.DefaultCellStyle = dataGridViewCellStyle3;
            DataGridViewStudents.Location = new System.Drawing.Point(403, 15);
            DataGridViewStudents.Name = "DataGridViewStudents";
            DataGridViewStudents.RowHeadersWidth = 51;
            DataGridViewStudents.RowTemplate.Height = 29;
            DataGridViewStudents.Size = new System.Drawing.Size(945, 576);
            DataGridViewStudents.TabIndex = 7;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1382, 653);
            Controls.Add(tabControl1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "MainForm";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "LMS";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridViewBorrowedBooks).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DataGridViewBooks).EndInit();
            tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DataGridViewStudents).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox BookIdTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView DataGridViewBorrowedBooks;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView DataGridViewBooks;
        private System.Windows.Forms.Label StockLabel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label BookAuthorLabel;
        private System.Windows.Forms.Label BookCategoryLabel;
        private System.Windows.Forms.Label BookTitleLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView DataGridViewStudents;
    }
}