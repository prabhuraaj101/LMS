using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
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

    public int Borrowed { get; set; }

    public DateTime LastBorrowed { get; set; }

    public static List<Student> GetStudentsFromDB()
    {
        List<Student> students = new();

        using (SqlConnection connection = DBConnection.GetConnection())
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

    public static Student GetStudentFromDB(string studentId)
    {
        Student student = null;

        using (SqlConnection connection = DBConnection.GetConnection())
        {
            connection.Open();

            string query = "SELECT * FROM Students WHERE StudentId = @StudentId";
            using SqlCommand command = new(query, connection);
            command.Parameters.AddWithValue("@StudentId", studentId);
            using SqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                student = new Student
                {
                    Id = reader.GetString(0),
                    FirstName = reader.GetString(1),
                    LastName = reader.GetString(2),
                    Department = reader.GetString(3),
                    Year = reader.GetInt32(4)
                };
            }
        }
        return student;
    }

    public static void AddStudentToDB(string id, string firstName, string lastName, string department, int year)
    {
        using SqlConnection connection = DBConnection.GetConnection();
        connection.Open();

        string query = "INSERT INTO Students (StudentId, FirstName, LastName, Department, Year) VALUES (@id, @firstName, @lastName, @department, @year)";
        using SqlCommand command = new(query, connection);
        command.Parameters.AddWithValue("@id", id);
        command.Parameters.AddWithValue("@firstName", firstName);
        command.Parameters.AddWithValue("@lastName", lastName);
        command.Parameters.AddWithValue("@department", department);
        command.Parameters.AddWithValue("@year", year);

        command.ExecuteNonQuery();
    }
}
