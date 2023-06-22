using System.Data.SqlClient;

namespace LMSLibrary;

public static class DBConnection
{
    private static readonly string connectionString = "Data Source=DESKTOP-AAR2G77\\SQLEXPRESS;Initial Catalog=lmsDB;Integrated Security=True";

    public static SqlConnection GetConnection()
    {
        return new SqlConnection(connectionString);
    }
}
