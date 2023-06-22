using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace LMSLibrary;

public class Admin
{
    public int Id { get; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public string? UserName { get; set; }

    public string? Password { get; set; }

    public static bool AuthenticateLogin(string userName, string password)
    {
        using SqlConnection connection = DBConnection.GetConnection();
        connection.Open();

        using SqlCommand command = new("SELECT COUNT(*) FROM Admins WHERE UserName = @UserName AND Password = @Password", connection);
        command.Parameters.AddWithValue("@UserName", userName);
        command.Parameters.AddWithValue("@Password", password);

        int matchingRows = (int)command.ExecuteScalar();
        return matchingRows > 0;
    }
}