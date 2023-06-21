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

        string connectionString = "Data Source=DESKTOP-AAR2G77\\SQLEXPRESS;Initial Catalog=lmsDB;Integrated Security=True";

        using (SqlConnection connection = new(connectionString))
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

        string connectionString = "Data Source=DESKTOP-AAR2G77\\SQLEXPRESS;Initial Catalog=lmsDB;Integrated Security=True";

        using (SqlConnection connection = new(connectionString))
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
}

public class BorrowedBooks
{
    public string? BookId { get; set; }

    public string? StudentId { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public DateTime Date { get; set; }

    public static List<BorrowedBooks> GetBorrowedBooksFromDB()
    {
        List<BorrowedBooks> borrowedBooks = new();

        string connectionString = "Data Source=DESKTOP-AAR2G77\\SQLEXPRESS;Initial Catalog=lmsDB;Integrated Security=True";

        using (SqlConnection connection = new(connectionString))
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
                    Date = reader.GetDateTime(5)
                };
                borrowedBooks.Add(borrowedBook);
            }
        }
        return borrowedBooks;
    }
}