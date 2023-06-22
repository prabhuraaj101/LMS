using System;
using System.Collections.Generic;
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
}

public class BorrowedBooks
{
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
                    BookId = reader.GetString(1),
                    StudentId = reader.GetString(2),
                    FirstName = reader.GetString(3),
                    LastName = reader.GetString(4),
                    Department = reader.GetString(5),
                    Year = reader.GetInt32(6),
                    Date = reader.GetDateTime(7)
                };
                borrowedBooks.Add(borrowedBook);
            }
        }
        return borrowedBooks;
    }


    public static void RecordBorrowedBookToDB(string bookId, string studentId, string firstName, string lastName, string department, int year)
    {
        using SqlConnection connection = DBConnection.GetConnection();
        connection.Open();

        var query = "INSERT INTO BorrowedBooks (BookId, StudentId, FirstName, LastName, Department, Year, Date) VALUES (@bookId, @studentId, @firstName, @lastName, @department, @year, @date)";
        using SqlCommand command = new(query, connection);
        command.Parameters.AddWithValue("@bookId", bookId);
        command.Parameters.AddWithValue("@studentId", studentId);
        command.Parameters.AddWithValue("@firstName", firstName);
        command.Parameters.AddWithValue("@lastName", lastName);
        command.Parameters.AddWithValue("@department", department);
        command.Parameters.AddWithValue("@year", year);
        command.Parameters.AddWithValue("@date", DateTime.Now);
        command.ExecuteNonQuery();
    }
}