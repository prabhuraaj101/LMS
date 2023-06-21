using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMSLibrary;

public class Borrower
{
    public int Id { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }
}

public class Book
{
    public int Id { get; set; }

    public string? Title { get; set; }

    public string? Author { get; set; }

    public string? Category { get; set; }

    public Borrower? Student { get; set; }

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
                Book book = new Book();
                book.Id = reader.GetInt32(0);
                book.Title = reader.GetString(1);
                book.Author = reader.GetString(2);
                book.Category = reader.GetString(3);
                books.Add(book);
            }
        }

        return books;
    }
}
