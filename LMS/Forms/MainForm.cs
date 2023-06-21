using LMSLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LMS;

public partial class MainForm : Form
{
    public MainForm()
    {
        InitializeComponent();
        LoadBorrowedBooksData(DataGridViewBorrowedBooks);
        LoadBooksData(DataGridViewBooks);
        BookIdTextBox.TextChanged += BookIdTextBox_TextChanged;
        LoadStudentsData(DataGridViewStudents);
    }

    public void LoadBorrowedBooksData(DataGridView DataGridViewBorrowedBooks)
    {
        DataGridViewBorrowedBooks.ReadOnly = true;
        DataGridViewBorrowedBooks.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        List<BorrowedBooks> borrowedBooks = BorrowedBooks.GetBorrowedBooksFromDB();

        DataGridViewBorrowedBooks.DataSource = borrowedBooks;
    }

    public void LoadBooksData(DataGridView DataGridViewBooks)
    {
        DataGridViewBooks.ReadOnly = true;
        DataGridViewBooks.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        List<Book> book = Book.GetBooksFromDB();

        DataGridViewBooks.DataSource = book;
    }

    private void BookIdTextBox_TextChanged(object sender, EventArgs e)
    {
        string bookId = BookIdTextBox.Text;
        Book book = Book.GetBookFromDB(bookId);
        if (book != null)
        {
            BookTitleLabel.Visible = true;
            BookAuthorLabel.Visible = true;
            BookCategoryLabel.Visible = true;
            StockLabel.Visible = true;
            BookTitleLabel.Text = book.Title;
            BookAuthorLabel.Text = book.Author;
            BookCategoryLabel.Text = book.Category;
            StockLabel.Text = book.Stock.ToString();
        }
    }

    public void LoadStudentsData(DataGridView DataGridViewStudents)
    {
        DataGridViewStudents.ReadOnly = true;
        DataGridViewStudents.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        List<Student> student = Student.GetStudentsFromDB();

        DataGridViewStudents.DataSource = student;
    }
}
