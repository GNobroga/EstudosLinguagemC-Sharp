using Npgsql;

namespace POO.Config;

public static class PostgresConfig 
{

    public static NpgsqlConnection GetConnection() 
    {
        string host = "localhost";
        string username = "postgres";
        string password = "postgres";
        string port = "5432";

        return new NpgsqlConnection($"Host={host};Username={username};Password={password};Port={port}");
    }

}