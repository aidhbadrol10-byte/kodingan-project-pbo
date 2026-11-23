using System;

namespace UTANI.Models
{
    public class Lahan
    {
        private int _id_lahan;
        private string _nama_lahan;
        private double _luas_lahan;
        private string _lokasi;
        private string _keterangan;

        public int id_lahan
        {
            get { return _id_lahan; }
            set { _id_lahan = value; }
        }

        public string nama_lahan
        {
            get { return _nama_lahan; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Nama lahan dan komoditas wajib diisi.");
                _nama_lahan = value.Trim();
            }
        }

        public double luas_lahan
        {
            get { return _luas_lahan; }
            set
            {
                if (value <= 0)
                    throw new ArgumentException("Luas lahan harus lebih dari 0 hektar.");
                _luas_lahan = value;
            }
        }

        public string lokasi
        {
            get { return _lokasi; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Lokasi lahan wajib diisi.");
                _lokasi = value.Trim();
            }
        }

        public string keterangan
        {
            get { return _keterangan; }
            set { _keterangan = value != null ? value.Trim() : ""; }
        }

        public Lahan() { }

        public Lahan(int id_lahan, string nama_lahan, double luas_lahan, string lokasi, string keterangan)
        {
            this.id_lahan = id_lahan;
            this.nama_lahan = nama_lahan;
            this.luas_lahan = luas_lahan;
            this.lokasi = lokasi;
            this.keterangan = keterangan;
        }
    }
}