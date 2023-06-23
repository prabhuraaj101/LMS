using LMSLibrary;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace LMS;

public partial class MainForm : Form
{
    public MainForm()
    {
        InitializeComponent();
        this.FormClosing += MainForm_FormClosing;
        LoadBorrowedBooksData(DataGridViewBorrowedBooks);
        LoadBooksData(DataGridViewBooks);
        BookIdTextBox.TextChanged += BookIdTextBox_TextChanged;
        LoadStudentsData(DataGridViewStudents);
        StudentIdTextBox.TextChanged += StudentIdTextBox_TextChanged;
        BorrowClearButton.Click += BorrowClearButton_Click;
        BorrowIdTextBox.TextChanged += BookIdTextBox_TextChanged;
        ReturnClearButton.Click += ReturnClearButton_Click;
        ModifyBookIdTextBox.TextChanged += ModifyBookIdTextBox_TextChanged;
    }

    private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
    {
        DialogResult result = MessageBox.Show("Are you sure to exit?", "Confirm exit", MessageBoxButtons.YesNo);

        if (result == DialogResult.No)
        {
            e.Cancel = true;
        }
        else
        {
            LoginForm loginForm = new();
            loginForm.Show();
        }
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
        if (string.IsNullOrEmpty(StudentIdTextBox.Text) || string.IsNullOrEmpty(BookIdTextBox.Text))
        {
            MessageBox.Show("Invalid Book ID and/or Student ID. Please try again...");
            return;
        }

        try
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
                int borrowId = BorrowedBooks.RecordBorrowedBookToDB(bookId, studentId, firstName, lastName, department, year);

                book.Stock--;
                Book.UpdateBookStock(book.Id, book.Stock);

                LoadBorrowedBooksData(DataGridViewBorrowedBooks);
                DataGridViewBooks.Refresh();

                MessageBox.Show($"Borrow ID: {borrowId}");

                StockLabel.Text = book.Stock.ToString();
            }
            else
            {
                MessageBox.Show("The selected book is not available.");
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show($"An error occured: {ex.Message}.");
        }
    }


    private void BorrowClearButton_Click(object sender, EventArgs e)
    {
        BookIdTextBox.Clear();
        StudentIdTextBox.Clear();
    }


    private void BorrowIdTextBox_TextChanged(object sender, EventArgs e)
    {
        if (int.TryParse(BorrowIdTextBox.Text, out int borrowId))
        {
            BorrowedBooks borrowedBook = BorrowedBooks.GetBorrowedBookFromDB(borrowId);
            if (borrowedBook != null)
            {
                ReturnBookIDLabel.Visible = true;
                ReturnStudentIDLabel.Visible = true;
                ReturnStudentFirstNameLabel.Visible = true;
                ReturnStudentLastNameLabel.Visible = true;
                ReturnStudentDepartmentLabel.Visible = true;
                ReturnStudentYearLabel.Visible = true;
                ReturnDateBorrowedLabel.Visible = true;

                ReturnBookIDLabel.Text = borrowedBook.BookId;
                ReturnStudentIDLabel.Text = borrowedBook.StudentId;
                ReturnStudentFirstNameLabel.Text = borrowedBook.FirstName;
                ReturnStudentLastNameLabel.Text = borrowedBook.LastName;
                ReturnStudentDepartmentLabel.Text = borrowedBook.Department;
                ReturnStudentYearLabel.Text = borrowedBook.Year.ToString();
                ReturnDateBorrowedLabel.Text = borrowedBook.Date.ToString();
            }
            else
            {
                ReturnBookIDLabel.Text = string.Empty;
                ReturnStudentIDLabel.Text = string.Empty;
                ReturnStudentFirstNameLabel.Text = string.Empty;
                ReturnStudentLastNameLabel.Text = string.Empty;
                ReturnStudentDepartmentLabel.Text = string.Empty;
                ReturnStudentYearLabel.Text = string.Empty;
                ReturnDateBorrowedLabel.Text = string.Empty;
            }
        }
    }


    private void ReturnBookButton_Click(object sender, EventArgs e)
    {
        int borrowId = int.Parse(BorrowIdTextBox.Text);

        BorrowedBooks borrowedBook = BorrowedBooks.GetBorrowedBookFromDB(borrowId);
        if (borrowedBook != null)
        {
            Book book = Book.GetBookFromDB(borrowedBook.BookId);
            if (book != null)
            {
                book.Stock++;
                Book.UpdateBookStock(book.Id, book.Stock);
                MessageBox.Show($"Book {book.Id} returned successfully!");
            }

            BorrowedBooks.DeleteBorrowedBookFromDB(borrowId);

            LoadBorrowedBooksData(DataGridViewBorrowedBooks);
            LoadBooksData(DataGridViewBooks);
        }
    }


    private void ReturnClearButton_Click(object sender, EventArgs e)
    {
        BorrowIdTextBox.Text = "";
        ReturnBookIDLabel.Text = "";
        ReturnStudentIDLabel.Text = "";
        ReturnStudentFirstNameLabel.Text = "";
        ReturnStudentLastNameLabel.Text = "";
        ReturnStudentDepartmentLabel.Text = "";
        ReturnStudentYearLabel.Text = "";
        ReturnDateBorrowedLabel.Text = "";
    }

    private string GenerateBookId(string title)
    {
        string[] words = title.Split(' ');

        string[] substrings = words.Select(word => word.Substring(0, Math.Min(3, word.Length))).ToArray();

        string prefix = new string(string.Concat(substrings).Take(6).ToArray());

        Random random = new();
        int randomNumber = random.Next(100, 1000);

        string id = prefix + randomNumber;

        id = id.ToUpper();

        return id;
    }


    private void AddBookButton_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrEmpty(AddBookTitleTextBox.Text) || string.IsNullOrEmpty(AddBookAuthorTextBox.Text) || string.IsNullOrEmpty(AddBookCategoryComboBox.Text))
        {
            MessageBox.Show("Please fill in all required fields.");
            return;
        }

        string id = GenerateBookId(AddBookTitleTextBox.Text);
        string title = AddBookTitleTextBox.Text;
        string author = AddBookAuthorTextBox.Text;
        string category = AddBookCategoryComboBox.Text;
        int stock = (int)AddBookStockNumericUpDown.Value;

        bool newBookAdded = Book.AddBookToDB(id, title, author, category, stock);

        if (newBookAdded)
        {
            MessageBox.Show($"Book: {title} ({id}) added.");
        }
        else
        {
            DialogResult result = MessageBox.Show("Do you want to update the stock instead?", "Book already exists", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                MessageBox.Show($"Book: {title} stock updated.");
            }
            else
            {
                return;
            }
        }
        LoadBooksData(DataGridViewBooks);
    }

    private void AddBookClearButton_Click(object sender, EventArgs e)
    {
        AddBookCategoryComboBox.Text = "";
        AddBookTitleTextBox.Text = "";
        AddBookAuthorTextBox.Text = "";
        AddBookStockNumericUpDown.Value = 1;
    }

    private void ModifyBookIdTextBox_TextChanged(object sender, EventArgs e)
    {
        string bookId = ModifyBookIdTextBox.Text;
        if (string.IsNullOrEmpty(bookId))
        {
            ModifyBookCategoryComboBox.Text = string.Empty;
            ModifyBookTitleTextBox.Text = string.Empty;
            ModifyBookAuthorTextBox.Text = string.Empty;
            ModifyBookStockNumericUpDown.Value = 1;
        }
        else
        {
            Book book = Book.GetBookFromDB(bookId);
            if (book != null)
            {
                ModifyBookCategoryComboBox.Text = book.Category;
                ModifyBookTitleTextBox.Text = book.Title;
                ModifyBookAuthorTextBox.Text = book.Author;
                ModifyBookStockNumericUpDown.Value = book.Stock;
            }
        }
    }

    private void UpdateBookButton_Click(object sender, EventArgs e)
    {
        string id = ModifyBookIdTextBox.Text;
        string title = ModifyBookTitleTextBox.Text;
        string author = ModifyBookAuthorTextBox.Text;
        string category = ModifyBookCategoryComboBox.Text;
        int stock = (int)ModifyBookStockNumericUpDown.Value;

        DialogResult result = MessageBox.Show("Are you sure to update?", "Confirm update", MessageBoxButtons.YesNo);

        if (result == DialogResult.Yes)
        {
            Book.UpdateBookInDB(id, title, author, category, stock);

            MessageBox.Show("Book successfully updated!");

            LoadBooksData(DataGridViewBooks);
        }
        else
        {
            return;
        }
    }

    private void ModifyBookClearButton_Click(object sender, EventArgs e)
    {
        ModifyBookIdTextBox.Text = string.Empty;
        ModifyBookCategoryComboBox.Text = string.Empty;
        ModifyBookTitleTextBox.Text = string.Empty;
        ModifyBookAuthorTextBox.Text = string.Empty;
        ModifyBookStockNumericUpDown.Value = 1;
    }

    private void DeleteBookButton_Click(object sender, EventArgs e)
    {
        string id = ModifyBookIdTextBox.Text;

        DialogResult result = MessageBox.Show("Are you sure to delete?", "Confirm delete", MessageBoxButtons.YesNo);

        if (result == DialogResult.Yes)
        {

            Book.DeleteBookFromDB(id);

            MessageBox.Show("Book successfully deleted!");

            LoadBooksData(DataGridViewBooks);
        }
        else
        {
            return;
        }
    }

    private void AddStudentButton_Click(object sender, EventArgs e)
    {
        string id = AddStudentIdTextBox.Text;
        string firstName = AddStudentFirstNameTextBox.Text;
        string lastName = AddStudentLastNameTextBox.Text;
        string department = AddStudentDepartmentTextBox.Text;
        int year = int.Parse(AddStudentYearTextBox.Text);

        Student.AddStudentToDB(id, firstName, lastName, department, year);

        MessageBox.Show("Student successfully added!");

        LoadStudentsData(DataGridViewStudents);
    }
}