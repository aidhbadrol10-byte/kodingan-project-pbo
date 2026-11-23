using System;
using System.Collections.Generic;
using Npgsql;
using UTANI.Databases;

namespace UTANI.Repositories
{
    public class Lahan
    {
        private readonly koneksi db = new koneksi();

        public List<Models.Lahan> GetAll()
        {
            List<Models.Lahan> listLahan = new List<Models.Lahan>();
            string query = @"SELECT id_lahan, nama_lahan, luas_lahan, lokasi, keterangan 
                             FROM lahan 
                             ORDER BY id_lahan ASC";

            using (NpgsqlConnection conn = db.getConnection())
            {
                if (conn.State != System.Data.ConnectionState.Open)
                    conn.Open();

                using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                using (NpgsqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Models.Lahan item = new Models.Lahan
                        {
                            id_lahan = Convert.ToInt32(reader["id_lahan"]),
                            nama_lahan = reader["nama_lahan"].ToString(),
                            luas_lahan = Convert.ToDouble(reader["luas_lahan"]),
                            lokasi = reader["lokasi"].ToString(),
                            keterangan = reader["keterangan"] == DBNull.Value ? "" : reader["keterangan"].ToString()
                        };
                        listLahan.Add(item);
                    }
                }
            }

            return listLahan;
        }

        public void Insert(Models.Lahan data)
        {
            string query = @"INSERT INTO lahan (id_lahan, nama_lahan, luas_lahan, lokasi, keterangan) 
                             VALUES ((SELECT COALESCE(MAX(id_lahan), 0) + 1 FROM lahan), @nama_lahan, @luas_lahan, @lokasi, @keterangan)";

            using (NpgsqlConnection conn = db.getConnection())
            {
                if (conn.State != System.Data.ConnectionState.Open)
                    conn.Open();

                using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id_lahan", data.id_lahan);
                    cmd.Parameters.AddWithValue("@nama_lahan", data.nama_lahan);
                    cmd.Parameters.AddWithValue("@luas_lahan", data.luas_lahan);
                    cmd.Parameters.AddWithValue("@lokasi", data.lokasi);
                    cmd.Parameters.AddWithValue("@keterangan",
                        string.IsNullOrWhiteSpace(data.keterangan) ? (object)DBNull.Value : data.keterangan);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void Update(Models.Lahan data)
        {
            string query = @"UPDATE lahan 
                             SET id_lahan = @id_lahan, 
                                 nama_lahan = @nama_lahan, 
                                 luas_lahan = @luas_lahan, 
                                 lokasi = @lokasi, 
                                 keterangan = @keterangan 
                             WHERE id_lahan = @id_lahan";

            using (NpgsqlConnection conn = db.getConnection())
            {
                if (conn.State != System.Data.ConnectionState.Open)
                    conn.Open();

                using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id_lahan", data.id_lahan);
                    cmd.Parameters.AddWithValue("@nama_lahan", data.nama_lahan);
                    cmd.Parameters.AddWithValue("@luas_lahan", data.luas_lahan);
                    cmd.Parameters.AddWithValue("@lokasi", data.lokasi);
                    cmd.Parameters.AddWithValue("@keterangan",
                        string.IsNullOrWhiteSpace(data.keterangan) ? (object)DBNull.Value : data.keterangan);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void Delete(int id_lahan)
        {
            string query = "DELETE FROM lahan WHERE id_lahan = @id_lahan";

            using (NpgsqlConnection conn = db.getConnection())
            {
                if (conn.State != System.Data.ConnectionState.Open)
                    conn.Open();

                using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id_lahan", id_lahan);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}