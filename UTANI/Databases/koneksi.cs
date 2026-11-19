using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;


namespace UTANI.Databases
{
    public class koneksi
    {
        private string connectionString;

        public koneksi()
        {
            string host = "localhost";
            string port = "5432";
            string database = "UTANI";
            string username = "postgres";
            string password = "1234";

            connectionString = $"Host={host};Port={port};Database={database};Username={username};Password={password}";
        }

        public NpgsqlConnection getConnection()
        {
            return new NpgsqlConnection(connectionString);  
        }
    }
}