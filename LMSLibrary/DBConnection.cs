using System.Data.SqlClient;

namespace LMSLibrary;

public static class DBConnection
{
    private static readonly string connectionString = "Data Source=DESKTOP-6F1MDD5\\SQLEXPRESS;Initial Catalog=lmsDB;Integrated Security=True";

    public static SqlConnection GetConnection()
    {
        return new SqlConnection(connectionString);
    }
}
