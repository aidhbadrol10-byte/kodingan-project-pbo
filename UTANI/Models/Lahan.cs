using System;

namespace UTANI.Models
{
    public class Lahan
    {
        private int id_lahan;
        private string nama_lahan;
        private decimal luas_lahan;
        private string lokasi;
        private string keterangan;

        public int IdLahan
        {
            get { return id_lahan; }
            set { id_lahan = value; }
        }

        public string NamaLahan
        {
            get { return nama_lahan; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Nama lahan tidak boleh kosong.");
                nama_lahan = value;
            }
        }

      
        public decimal LuasLahan
        {
            get { return luas_lahan; }
            set
            {
                if (value <= 0)
                    throw new ArgumentException("Luas lahan harus lebih dari 0.");
                luas_lahan = value;
            }
        }

        public string Lokasi
        {
            get { return lokasi; }
            set { lokasi = value; }
        }

        public string Keterangan
        {
            get { return keterangan; }
            set { keterangan = value; }
        }

        public Lahan()
        {
        }

        public Lahan(int id_lahan, string nama_lahan, decimal luas_lahan, string lokasi, string keterangan)
        {
            IdLahan = id_lahan;
            NamaLahan = nama_lahan;
            LuasLahan = luas_lahan;
            Lokasi = lokasi;
            Keterangan = keterangan;
        }

        public Lahan(string nama_lahan, decimal luas_lahan, string lokasi, string keterangan)
            : this(0, nama_lahan, luas_lahan, lokasi, keterangan)
        {
        }
    }
}