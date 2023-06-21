using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMSLibrary;

public class Student
{
    public string? Id { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public string? Department { get; set; }

    public int Year { get; set; }

    public static List<Student> GetStudentsFromDB()
    {
        List<Student> students = new();

        string connectionString = "Data Source=DESKTOP-AAR2G77\\SQLEXPRESS;Initial Catalog=lmsDB;Integrated Security=True";

        using (SqlConnection connection = new(connectionString))
        {
            connection.Open();

            string query = "SELECT * FROM Students";

            using SqlCommand command = new(query, connection);
            using SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Student student = new()
                {
                    Id = reader.GetString(0),
                    FirstName = reader.GetString(1),
                    LastName = reader.GetString(2),
                    Department = reader.GetString(3),
                    Year = reader.GetInt32(4)
                };
                students.Add(student);
            }
        }
        return students;
    }
}
