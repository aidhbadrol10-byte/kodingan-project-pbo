using System;
using System.Collections.Generic;
using System.Data;
using Npgsql;
using UTANI.Databases;
using UTANI.Models;

namespace UTANI.Repositories
{
    public class PeriodeItem
    {
        public int IdPeriode { get; set; }
        public string LabelPeriode { get; set; }
    }

    public class BiayaRowView
    {
        public int IdBiaya { get; set; }
        public int IdPeriode { get; set; }
        public int? IdPenanaman { get; set; }
        public string LahanKomoditas { get; set; }
        public string Kategori { get; set; }
        public DateTime Tanggal { get; set; }
        public string Keterangan { get; set; }
        public int Kuantitas { get; set; }
        public int HargaSatuan { get; set; }
        public int Nominal { get; set; }
        public int TotalBiaya { get; set; }
    }

    public class Biaya
    {
        private readonly koneksi db = new koneksi();

        public (int idPenanaman, int idPeriode)? CariPenanamanByNama(string keyword, int? filterPeriode = null)
        {
            string query = @"SELECT pn.id_penanaman, pn.id_periode
                             FROM penanaman pn
                             JOIN lahan l ON pn.id_lahan = l.id_lahan
                             WHERE (LOWER(l.nama_lahan) LIKE LOWER(@kw)
                                 OR LOWER(pn.komoditas) LIKE LOWER(@kw)
                                 OR LOWER(l.nama_lahan || ' - ' || pn.komoditas) LIKE LOWER(@kw))";

            if (filterPeriode.HasValue)
            {
                query += " AND pn.id_periode = @id_periode";
            }

            query += " ORDER BY pn.id_penanaman DESC LIMIT 1";

            using (NpgsqlConnection conn = db.getConnection())
            {
                if (conn.State != ConnectionState.Open)
                    conn.Open();

                using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@kw", "%" + keyword.Trim() + "%");
                    if (filterPeriode.HasValue)
                    {
                        cmd.Parameters.AddWithValue("@id_periode", filterPeriode.Value);
                    }

                    using (NpgsqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return (
                                Convert.ToInt32(reader["id_penanaman"]),
                                Convert.ToInt32(reader["id_periode"])
                            );
                        }
                    }
                }
            }

            return null;
        }

        public List<PeriodeItem> GetDaftarPeriode()
        {
            List<PeriodeItem> daftar = new List<PeriodeItem>();
            string query = @"SELECT id_periode, nama_periode, bulan_mulai, tahun_mulai
                             FROM periode_penanaman
                             ORDER BY id_periode DESC";

            using (NpgsqlConnection conn = db.getConnection())
            {
                if (conn.State != ConnectionState.Open)
                    conn.Open();

                using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                using (NpgsqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int id = Convert.ToInt32(reader["id_periode"]);
                        string nama = reader["nama_periode"] == DBNull.Value
                            ? "Periode #" + id
                            : reader["nama_periode"].ToString();
                        int bulan = Convert.ToInt32(reader["bulan_mulai"]);
                        int tahun = Convert.ToInt32(reader["tahun_mulai"]);

                        daftar.Add(new PeriodeItem
                        {
                            IdPeriode = id,
                            LabelPeriode = $"{nama} ({bulan:00}/{tahun})"
                        });
                    }
                }
            }

            return daftar;
        }

        public List<Models.Biaya> GetAll()
        {
            List<Models.Biaya> daftarBiaya = new List<Models.Biaya>();
            string query = @"SELECT id_biaya, id_periode, id_penanaman, kategori, tanggal,
                                    keterangan, kuantitas, harga_satuan, nominal
                             FROM biaya
                             ORDER BY id_biaya DESC";

            using (NpgsqlConnection conn = db.getConnection())
            {
                if (conn.State != ConnectionState.Open)
                    conn.Open();

                using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                using (NpgsqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        daftarBiaya.Add(MapReaderToModel(reader));
                    }
                }
            }

            return daftarBiaya;
        }

        public List<BiayaRowView> GetByPeriode(int idPeriode)
        {
            List<BiayaRowView> hasil = new List<BiayaRowView>();
            string query = @"SELECT b.id_biaya, b.id_periode, b.id_penanaman, b.kategori, b.tanggal,
                                    b.keterangan, b.kuantitas, b.harga_satuan, b.nominal,
                                    l.nama_lahan, pn.komoditas
                             FROM biaya b
                             LEFT JOIN penanaman pn ON b.id_penanaman = pn.id_penanaman
                             LEFT JOIN lahan l ON pn.id_lahan = l.id_lahan
                             WHERE b.id_periode = @id_periode
                             ORDER BY b.id_biaya DESC";

            using (NpgsqlConnection conn = db.getConnection())
            {
                if (conn.State != ConnectionState.Open)
                    conn.Open();

                using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id_periode", idPeriode);

                    using (NpgsqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Models.Biaya modelObj = MapReaderToModel(reader);

                            string namaLahan = reader["nama_lahan"] == DBNull.Value ? "-" : reader["nama_lahan"].ToString();
                            string komoditas = reader["komoditas"] == DBNull.Value ? "" : reader["komoditas"].ToString();
                            string labelLahan = string.IsNullOrWhiteSpace(komoditas)
                                ? namaLahan
                                : $"{namaLahan} - {komoditas}";

                            hasil.Add(new BiayaRowView
                            {
                                IdBiaya = modelObj.IdBiaya,
                                IdPeriode = modelObj.IdPeriode,
                                IdPenanaman = modelObj.IdPenanaman,
                                LahanKomoditas = labelLahan,
                                Kategori = modelObj.Kategori,
                                Tanggal = modelObj.Tanggal,
                                Keterangan = modelObj.Keterangan,
                                Kuantitas = reader["kuantitas"] == DBNull.Value ? 0 : Convert.ToInt32(reader["kuantitas"]),
                                HargaSatuan = reader["harga_satuan"] == DBNull.Value ? 0 : Convert.ToInt32(reader["harga_satuan"]),
                                Nominal = reader["nominal"] == DBNull.Value ? 0 : Convert.ToInt32(reader["nominal"]),
                                TotalBiaya = (int)modelObj.HitungTotal()
                            });
                        }
                    }
                }
            }

            return hasil;
        }

        public void Insert(Models.Biaya biaya)
        {
            string query = @"INSERT INTO biaya
                                (id_periode, id_penanaman, kategori, tanggal, keterangan, kuantitas, harga_satuan, nominal)
                             VALUES
                                (@id_periode, @id_penanaman, @kategori, @tanggal, @keterangan, @kuantitas, @harga_satuan, @nominal)";

            int? kuantitas = null;
            int? hargaSatuan = null;
            int? nominal = null;

            if (biaya is BiayaPupuk pupuk)
            {
                kuantitas = pupuk.Kuantitas;
                hargaSatuan = pupuk.HargaSatuan;
            }
            else if (biaya is BiayaTenagaKerja tenagaKerja)
            {
                kuantitas = tenagaKerja.Kuantitas;
                hargaSatuan = tenagaKerja.HargaSatuan;
            }
            else if (biaya is BiayaPerawatan perawatan)
            {
                nominal = perawatan.Nominal;
            }

            using (NpgsqlConnection conn = db.getConnection())
            {
                if (conn.State != ConnectionState.Open)
                    conn.Open();

                using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id_periode", biaya.IdPeriode);
                    cmd.Parameters.AddWithValue("@id_penanaman",
                        biaya.IdPenanaman.HasValue ? (object)biaya.IdPenanaman.Value : DBNull.Value);
                    cmd.Parameters.AddWithValue("@kategori", biaya.Kategori);
                    cmd.Parameters.AddWithValue("@tanggal", biaya.Tanggal.Date);
                    cmd.Parameters.AddWithValue("@keterangan",
                        string.IsNullOrWhiteSpace(biaya.Keterangan) ? (object)DBNull.Value : biaya.Keterangan.Trim());
                    cmd.Parameters.AddWithValue("@kuantitas",
                        kuantitas.HasValue ? (object)kuantitas.Value : DBNull.Value);
                    cmd.Parameters.AddWithValue("@harga_satuan",
                        hargaSatuan.HasValue ? (object)hargaSatuan.Value : DBNull.Value);
                    cmd.Parameters.AddWithValue("@nominal",
                        nominal.HasValue ? (object)nominal.Value : DBNull.Value);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        private Models.Biaya MapReaderToModel(NpgsqlDataReader reader)
        {
            string kategoriRaw = reader["kategori"].ToString();
            string kategoriNorm = kategoriRaw.Trim().ToLower().Replace(" ", "_");
            int idPeriode = Convert.ToInt32(reader["id_periode"]);
            int? idPenanaman = reader["id_penanaman"] == DBNull.Value
                ? (int?)null
                : Convert.ToInt32(reader["id_penanaman"]);
            DateTime tanggal = Convert.ToDateTime(reader["tanggal"]);
            string keterangan = reader["keterangan"] == DBNull.Value ? "" : reader["keterangan"].ToString();
            int kuantitas = reader["kuantitas"] == DBNull.Value ? 0 : Convert.ToInt32(reader["kuantitas"]);
            int hargaSatuan = reader["harga_satuan"] == DBNull.Value ? 0 : Convert.ToInt32(reader["harga_satuan"]);
            int nominal = reader["nominal"] == DBNull.Value ? 0 : Convert.ToInt32(reader["nominal"]);

            Models.Biaya model;
            if (kategoriNorm == "pupuk")
            {
                model = new BiayaPupuk(idPeriode, tanggal, keterangan, kuantitas, hargaSatuan, idPenanaman);
            }
            else if (kategoriNorm == "tenaga_kerja")
            {
                model = new BiayaTenagaKerja(idPeriode, tanggal, keterangan, kuantitas, hargaSatuan, idPenanaman);
            }
            else
            {
                model = new BiayaPerawatan(idPeriode, tanggal, keterangan, nominal, idPenanaman);
            }

            model.IdBiaya = Convert.ToInt32(reader["id_biaya"]);
            return model;
        }
    }
}