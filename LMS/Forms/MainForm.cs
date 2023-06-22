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
        StudentIdTextBox.TextChanged += StudentIdTextBox_TextChanged;
    }

    public void LoadBorrowedBooksData(DataGridView DataGridViewBorrowedBooks)
    {
        DataGridViewBorrowedBooks.ReadOnly = true;
        DataGridViewBorrowedBooks.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        List<BorrowedBooks> borrowedBooks = BorrowedBooks.GetBorrowedBooksFromDB();

        DataGridViewBorrowedBooks.DataSource = borrowedBooks;

        foreach (DataGridViewColumn column in DataGridViewBorrowedBooks.Columns)
        {
            column.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
        }
    }

    private List<Book> books;
    public void LoadBooksData(DataGridView DataGridViewBooks)
    {
        DataGridViewBooks.ReadOnly = true;
        DataGridViewBooks.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        books = Book.GetBooksFromDB();

        DataGridViewBooks.DataSource = books;

        foreach (DataGridViewColumn column in DataGridViewBooks.Columns)
        {
            column.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
        }
    }

    private void BookIdTextBox_TextChanged(object sender, EventArgs e)
    {
        string bookId = BookIdTextBox.Text;
        if (string.IsNullOrEmpty(bookId))
        {
            BookTitleLabel.Text = string.Empty;
            BookAuthorLabel.Text = string.Empty;
            BookCategoryLabel.Text = string.Empty;
            StockLabel.Text = string.Empty;
        }
        else
        {
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
    }

    private void StudentIdTextBox_TextChanged(object sender, EventArgs e)
    {
        string studentId = StudentIdTextBox.Text;
        if (string.IsNullOrEmpty(studentId))
        {
            StudentFirstNameLabel.Text = string.Empty;
            StudentLastNameLabel.Text = string.Empty;
            StudentDepartmentLabel.Text = string.Empty;
            StudentYearLabel.Text = string.Empty;
        }
        else
        {
            Student student = Student.GetStudentFromDB(studentId);
            if (student != null)
            {
                StudentFirstNameLabel.Visible = true;
                StudentLastNameLabel.Visible = true;
                StudentDepartmentLabel.Visible = true;
                StudentYearLabel.Visible = true;
                StudentFirstNameLabel.Text = student.FirstName;
                StudentLastNameLabel.Text = student.LastName;
                StudentDepartmentLabel.Text = student.Department;
                StudentYearLabel.Text = student.Year.ToString();
            }
        }
    }

    public void LoadStudentsData(DataGridView DataGridViewStudents)
    {
        DataGridViewStudents.ReadOnly = true;
        DataGridViewStudents.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        List<Student> student = Student.GetStudentsFromDB();

        DataGridViewStudents.DataSource = student;
    }

    private void LendBookButton_Click(object sender, EventArgs e)
    {
        string bookId = BookIdTextBox.Text;
        string studentId = StudentIdTextBox.Text;
        string firstName = StudentFirstNameLabel.Text;
        string lastName = StudentLastNameLabel.Text;
        string department = StudentDepartmentLabel.Text;
        int year = int.Parse(StudentYearLabel.Text);

        Book book = books.FirstOrDefault(b => b.Id == bookId);
        if (book != null && book.Stock > 0)
        {
            BorrowedBooks.RecordBorrowedBookToDB(bookId, studentId, firstName, lastName, department, year);

            book.Stock--;
            Book.UpdateBookStock(book.Id, book.Stock);

            LoadBorrowedBooksData(DataGridViewBorrowedBooks);
            DataGridViewBooks.Refresh();

            MessageBox.Show("Book borrowed successfully!");

            StockLabel.Text = book.Stock.ToString();
        }
        else
        {
            MessageBox.Show("The selected book is not available.");
        }
    }

    private void DashboardClearButton_Click(object sender, EventArgs e)
    {
        BookIdTextBox.Clear();
        StudentIdTextBox.Clear();

        BookTitleLabel.Text = string.Empty;
        BookAuthorLabel.Text = string.Empty;
        BookCategoryLabel.Text = string.Empty;
        StockLabel.Text = string.Empty;
        StudentFirstNameLabel.Text = string.Empty;
        StudentLastNameLabel.Text = string.Empty;
        StudentDepartmentLabel.Text = string.Empty;
        StudentYearLabel.Text = string.Empty;
    }
}