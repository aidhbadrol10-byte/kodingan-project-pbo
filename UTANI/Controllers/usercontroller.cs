using Npgsql;
using System;
using UTANI.Databases;
using UTANI.Models;

namespace UTANI.Controllers
{
    public class usercontroller
    {
        public User Login(string email, string password)
        {
            using (NpgsqlConnection conn = new koneksi().getConnection())
            {
                conn.Open();

                string sql = "SELECT id_pengguna, nama, email, role::text " +
                             "FROM pengguna " +
                             "WHERE nama = @nama AND password = @password";

                using (NpgsqlCommand cmd = new NpgsqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@nama", email);
                    cmd.Parameters.AddWithValue("@password", password);

                    using (NpgsqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new User
                            {
                                id_pengguna = reader.GetInt32(0),
                                nama = reader.GetString(1),
                                email = reader.GetString(2),
                                role = reader.GetString(3)
                            };
                        }
                    }
                }
            }
            return null;
        }
    }
}