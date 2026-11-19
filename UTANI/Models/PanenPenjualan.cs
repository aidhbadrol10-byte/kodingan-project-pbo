using System;
using System.Collections.Generic;

namespace UTANI.Models
{
    public class Penjualan
    {
        private int id_penjualan;
        private int id_panen;
        private DateTime tanggal;
        private decimal jumlah_kg;
        private decimal harga_per_kg;

        public int IdPenjualan
        {
            get { return id_penjualan; }
            set { id_penjualan = value; }
        }

        public int IdPanen
        {
            get { return id_panen; }
            set { id_panen = value; }
        }

        public DateTime Tanggal
        {
            get { return tanggal; }
            set { tanggal = value; }
        }

        
        public decimal JumlahKg
        {
            get { return jumlah_kg; }
            set
            {
                if (value <= 0)
                    throw new ArgumentException("Jumlah kg penjualan harus lebih dari 0.");
                jumlah_kg = value;
            }
        }

        public decimal HargaPerKg
        {
            get { return harga_per_kg; }
            set
            {
                if (value < 0)
                    throw new ArgumentException("Harga per kg tidak boleh negatif.");
                harga_per_kg = value;
            }
        }

        public Penjualan(DateTime tanggal, decimal jumlah_kg, decimal harga_per_kg)
        {
            Tanggal = tanggal;
            JumlahKg = jumlah_kg;
            HargaPerKg = harga_per_kg;
        }

        public Penjualan(int id_penjualan, int id_panen, DateTime tanggal, decimal jumlah_kg, decimal harga_per_kg)
            : this(tanggal, jumlah_kg, harga_per_kg)
        {
            IdPenjualan = id_penjualan;
            IdPanen = id_panen;
        }

        public decimal HitungNilaiPenjualan()
        {
            return jumlah_kg * harga_per_kg;
        }
    }

    public class Panen
    {
        private int id_panen;
        private int id_periode;
        private int? id_penanaman;
        private DateTime tanggal_panen;
        private decimal jumlah_kg;

        private List<Penjualan> daftar_penjualan = new List<Penjualan>();

        public int IdPanen
        {
            get { return id_panen; }
            set { id_panen = value; }
        }

        public int IdPeriode
        {
            get { return id_periode; }
            set { id_periode = value; }
        }

        public int? IdPenanaman
        {
            get { return id_penanaman; }
            set { id_penanaman = value; }
        }

        public DateTime TanggalPanen
        {
            get { return tanggal_panen; }
            set { tanggal_panen = value; }
        }

        
        public decimal JumlahKg
        {
            get { return jumlah_kg; }
            set
            {
                if (value <= 0)
                    throw new ArgumentException("Jumlah kg panen harus lebih dari 0.");
                jumlah_kg = value;
            }
        }

        public IReadOnlyList<Penjualan> DaftarPenjualan
        {
            get { return daftar_penjualan.AsReadOnly(); }
        }

        public Panen(DateTime tanggal_panen, decimal jumlah_kg)
        {
            TanggalPanen = tanggal_panen;
            JumlahKg = jumlah_kg;
        }

        public Panen(int id_panen, int id_periode, DateTime tanggal_panen, decimal jumlah_kg, int? id_penanaman = null)
            : this(tanggal_panen, jumlah_kg)
        {
            IdPanen = id_panen;
            IdPeriode = id_periode;
            IdPenanaman = id_penanaman;
        }

       
        public void CatatPenjualan(DateTime tanggal, decimal jumlah_kg, decimal harga_per_kg)
        {
            Penjualan penjualan = new Penjualan(tanggal, jumlah_kg, harga_per_kg);
            penjualan.IdPanen = id_panen;
            daftar_penjualan.Add(penjualan);
        }

        public void TambahObjekPenjualan(Penjualan penjualan)
        {
            if (penjualan != null)
            {
                daftar_penjualan.Add(penjualan);
            }
        }

        public decimal HitungTotalPendapatan()
        {
            decimal total = 0;
            foreach (Penjualan p in daftar_penjualan)
            {
                total += p.HitungNilaiPenjualan();
            }
            return total;
        }
    }
}