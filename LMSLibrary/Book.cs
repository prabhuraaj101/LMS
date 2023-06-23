using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMSLibrary;

public class Book
{
    public string? Id { get; set; }

    public string? Title { get; set; }

    public string? Author { get; set; }

    public string? Category { get; set; }

    public int Stock { get; set; }

    public static List<Book> GetBooksFromDB()
    {
        List<Book> books = new();

        using (SqlConnection connection = DBConnection.GetConnection())
        {
            connection.Open();

            string query = "SELECT * FROM Books";

            using SqlCommand command = new(query, connection);
            using SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Book book = new()
                {
                    Id = reader.GetString(0),
                    Title = reader.GetString(1),
                    Author = reader.GetString(2),
                    Category = reader.GetString(3),
                    Stock = reader.GetInt32(4)
                };
                books.Add(book);
            }
        }
        return books;
    }

    public static Book GetBookFromDB(string bookId)
    {
        Book book = null;

        using (SqlConnection connection = DBConnection.GetConnection())
        {
            connection.Open();

            string query = "SELECT * FROM Books WHERE Id = @bookId";
            using SqlCommand command = new(query, connection);
            command.Parameters.AddWithValue("@bookId", bookId);
            using SqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                book = new Book
                {
                    Id = reader.GetString(0),
                    Title = reader.GetString(1),
                    Author = reader.GetString(2),
                    Category = reader.GetString(3),
                    Stock = reader.GetInt32(4)
                };
            }
        }
        return book;
    }

    public static void UpdateBookStock(string bookId, int stock)
    {
        using SqlConnection connection = DBConnection.GetConnection();
        connection.Open();

        string query = "UPDATE Books SET Stock = @stock WHERE Id = @bookId";
        using SqlCommand command = new(query, connection);
        command.Parameters.AddWithValue("@stock", stock);
        command.Parameters.AddWithValue("@bookId", bookId);
        command.ExecuteNonQuery();
    }

    public static bool AddBookToDB(string id, string title, string author, string category, int stock)
    {
        bool newBookAdded = false;

        using (SqlConnection connection = DBConnection.GetConnection())
        {
            connection.Open();

            string checkTitleQuery = "SELECT COUNT(*) FROM Books WHERE Title = @title";
            using SqlCommand checkTitleCommand = new(checkTitleQuery, connection);
            checkTitleCommand.Parameters.AddWithValue("@title", title);
            int titleCount = (int)checkTitleCommand.ExecuteScalar();

            if (titleCount > 0)
            {
                string updateStockQuery = "UPDATE Books SET Stock = Stock + @stock WHERE Title = @title";
                using SqlCommand updateStockCommand = new(updateStockQuery, connection);
                updateStockCommand.Parameters.AddWithValue("@stock", stock);
                updateStockCommand.Parameters.AddWithValue("@title", title);
                updateStockCommand.ExecuteNonQuery();
            }
            else
            {
                string query = "INSERT INTO Books (Id, Title, Author, Category, Stock) VALUES (@id, @title, @author, @category, @stock)";
                using SqlCommand command = new(query, connection);
                command.Parameters.AddWithValue("@id", id);
                command.Parameters.AddWithValue("@title", title);
                command.Parameters.AddWithValue("@author", author);
                command.Parameters.AddWithValue("@category", category);
                command.Parameters.AddWithValue("@stock", stock);

                command.ExecuteNonQuery();
                newBookAdded = true;
            }
        }

        return newBookAdded;
    }

    public static void UpdateBookInDB(string id, string title, string author, string category, int stock)
    {
        using (SqlConnection connection = DBConnection.GetConnection())
        {
            connection.Open();

            string query = "UPDATE Books SET Title = @title, Author = @author, Category = @category, Stock = @stock WHERE Id = @id";
            using SqlCommand command = new(query, connection);
            command.Parameters.AddWithValue("@id", id);
            command.Parameters.AddWithValue("@title", title);
            command.Parameters.AddWithValue("@author", author);
            command.Parameters.AddWithValue("@category", category);
            command.Parameters.AddWithValue("@stock", stock);

            command.ExecuteNonQuery();
        }
    }

    public static void DeleteBookFromDB(string id)
    {
        using (SqlConnection connection = DBConnection.GetConnection())
        {
            connection.Open();

            string query = "DELETE FROM Books WHERE Id = @id";
            using SqlCommand command = new(query, connection);
            command.Parameters.AddWithValue("@id", id);

            command.ExecuteNonQuery();
        }
    }
}

public class BorrowedBooks
{
    public int BorrowId { get; set; }

    public string? BookId { get; set; }

    public string? StudentId { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public string? Department { get; set; }

    public int Year { get; set; }

    public DateTime Date { get; set; }

    public static List<BorrowedBooks> GetBorrowedBooksFromDB()
    {
        List<BorrowedBooks> borrowedBooks = new();

        using (SqlConnection connection = DBConnection.GetConnection())
        {
            connection.Open();

            string query = "SELECT * FROM BorrowedBooks";

            using SqlCommand command = new(query, connection);
            using SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                BorrowedBooks borrowedBook = new()
                {
                    BorrowId = reader.GetInt32(0),
                    BookId = reader.IsDBNull(1) ? null : reader.GetString(1),
                    StudentId = reader.IsDBNull(2) ? null : reader.GetString(2),
                    FirstName = reader.IsDBNull(3) ? null : reader.GetString(3),
                    LastName = reader.IsDBNull(4) ? null : reader.GetString(4),
                    Department = reader.IsDBNull(5) ? null : reader.GetString(5),
                    Year = reader.IsDBNull(6) ? 0 : reader.GetInt32(6),
                    Date = reader.IsDBNull(7) ? DateTime.MinValue : reader.GetDateTime(7)
                };
                borrowedBooks.Add(borrowedBook);
            }
        }
        return borrowedBooks;
    }

    public static int RecordBorrowedBookToDB(string bookId, string studentId, string firstName, string lastName, string department, int year)
    {
        int borrowId = 0;
        using (SqlConnection connection = DBConnection.GetConnection())
        {
            connection.Open();

            string query = "INSERT INTO BorrowedBooks (BookId, StudentId, FirstName, LastName, Department, Year, Date) OUTPUT INSERTED.BorrowId VALUES (@bookId, @studentId, @firstName, @lastName, @department, @year, @date)";
            using SqlCommand command = new(query, connection);
            command.Parameters.AddWithValue("@bookId", bookId);
            command.Parameters.AddWithValue("@studentId", studentId);
            command.Parameters.AddWithValue("@firstName", firstName);
            command.Parameters.AddWithValue("@lastName", lastName);
            command.Parameters.AddWithValue("@department", department);
            command.Parameters.AddWithValue("@year", year);

            command.Parameters.AddWithValue("@date", DateTime.Now);

            borrowId = (int)command.ExecuteScalar();
        }
        return borrowId;
    }

    public static void DeleteBorrowedBookFromDB(int borrowId)
    {
        using SqlConnection connection = DBConnection.GetConnection();
        connection.Open();
        using SqlCommand command = new("DELETE FROM BorrowedBooks WHERE BorrowId = @BorrowId", connection);
        command.Parameters.AddWithValue("@BorrowId", borrowId);
        command.ExecuteNonQuery();
    }

    public static BorrowedBooks GetBorrowedBookFromDB(int borrowId)
    {
        BorrowedBooks borrowedBook = null;

        using (SqlConnection connection = DBConnection.GetConnection())
        {
            connection.Open();

            string query = "SELECT * FROM BorrowedBooks WHERE BorrowId = @borrowId";
            using SqlCommand command = new(query, connection);
            command.Parameters.AddWithValue("@borrowId", borrowId);
            using SqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                borrowedBook = new BorrowedBooks
                {
                    BorrowId = reader.GetInt32(0),
                    BookId = reader.IsDBNull(1) ? null : reader.GetString(1),
                    StudentId = reader.IsDBNull(2) ? null : reader.GetString(2),
                    FirstName = reader.IsDBNull(3) ? null : reader.GetString(3),
                    LastName = reader.IsDBNull(4) ? null : reader.GetString(4),
                    Department = reader.IsDBNull(5) ? null : reader.GetString(5),
                    Year = reader.IsDBNull(6) ? 0 : reader.GetInt32(6),
                    Date = reader.IsDBNull(7) ? DateTime.MinValue : reader.GetDateTime(7)
                };
            }
        }
        return borrowedBook;
    }
}