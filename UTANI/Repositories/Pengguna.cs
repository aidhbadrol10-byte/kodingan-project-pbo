using System;
using System.Collections.Generic;
using Npgsql;
using UTANI.Databases;
using UTANI.Models;

namespace UTANI.Repositories
{
    public class Pengguna
    {
        private readonly koneksi db  = new koneksi();

        public User GetByUsernameAndPassword(string username, string password)
        {
            User user = null;
            string query = @"SELECT id_pengguna, nama, email, password, nomor_telepon, role::text 
                             FROM pengguna 
                             WHERE (nama = @username OR email = @username) AND password = @password 
                             LIMIT 1";

            using (NpgsqlConnection conn = db.getConnection())
            {
                if (conn.State != System.Data.ConnectionState.Open)
                    conn.Open();

                using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);

                    using (NpgsqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            user = MapReaderToUser(reader);
                        }
                    }
                }
            }

            return user;
        }

        public List<User> GetAllByRole(string role)
        {
            List<User> daftarUser = new List<User>();
            string query = @"SELECT id_pengguna, nama, email, password, nomor_telepon, role::text 
                             FROM pengguna 
                             WHERE role::text = @role 
                             ORDER BY id_pengguna ASC";

            using (NpgsqlConnection conn = db.getConnection())
            {
                if (conn.State != System.Data.ConnectionState.Open)
                    conn.Open();

                using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@role", role);

                    using (NpgsqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            daftarUser.Add(MapReaderToUser(reader));
                        }
                    }
                }
            }

            return daftarUser;
        }

        public void Insert(User user)
        {
            string query = @"INSERT INTO pengguna (nama, email, password, nomor_telepon, role) 
                             VALUES (@nama, @email, @password, @nomor_telepon, @role::role_pengguna)";

            using (NpgsqlConnection conn = db.getConnection())
            {
                if (conn.State != System.Data.ConnectionState.Open)
                    conn.Open();

                using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@nama", user.nama);
                    cmd.Parameters.AddWithValue("@email", user.email);
                    cmd.Parameters.AddWithValue("@password", user.password);
                    cmd.Parameters.AddWithValue("@nomor_telepon", (object)user.nomor_telepon ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@role", string.IsNullOrEmpty(user.role) ? "buruh_tani" : user.role);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void Update(User user)
        {
            string query = @"UPDATE pengguna 
                             SET nama = @nama, 
                                 email = @email, 
                                 password = @password, 
                                 nomor_telepon = @nomor_telepon, 
                                 role = @role::role_pengguna 
                             WHERE id_pengguna = @id_pengguna";

            using (NpgsqlConnection conn = db.getConnection())
            {
                if (conn.State != System.Data.ConnectionState.Open)
                    conn.Open();

                using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id_pengguna", user.id_pengguna);
                    cmd.Parameters.AddWithValue("@nama", user.nama);
                    cmd.Parameters.AddWithValue("@email", user.email);
                    cmd.Parameters.AddWithValue("@password", user.password);
                    cmd.Parameters.AddWithValue("@nomor_telepon", (object)user.nomor_telepon ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@role", user.role);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void Delete(int idPengguna)
        {
            string query = "DELETE FROM pengguna WHERE id_pengguna = @id_pengguna";

            using (NpgsqlConnection conn = db.getConnection())
            {
                if (conn.State != System.Data.ConnectionState.Open)
                    conn.Open();

                using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id_pengguna", idPengguna);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        private User MapReaderToUser(NpgsqlDataReader reader)
        {
            return new User(
                reader.GetInt32(reader.GetOrdinal("id_pengguna")),
                reader.GetString(reader.GetOrdinal("nama")),
                reader.GetString(reader.GetOrdinal("email")),
                reader.GetString(reader.GetOrdinal("password")),
                reader.IsDBNull(reader.GetOrdinal("nomor_telepon")) ? "" : reader.GetString(reader.GetOrdinal("nomor_telepon")),
                reader.GetString(reader.GetOrdinal("role"))
            );
        }
    }
}