using System;
using System.Collections.Generic;

namespace UTANI.Models
{
    public class Penanaman
    {
        private int id_penanaman;
        private int id_periode;
        private string komoditas;

        
        private Lahan lahan;
        private User pengelola;

        
        private List<Panen> daftar_panen = new List<Panen>();

        public int IdPenanaman
        {
            get { return id_penanaman; }
            set { id_penanaman = value; }
        }

        public int IdPeriode
        {
            get { return id_periode; }
            set { id_periode = value; }
        }

        public string Komoditas
        {
            get { return komoditas; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Komoditas tidak boleh kosong.");
                komoditas = value;
            }
        }

        public Lahan Lahan
        {
            get { return lahan; }
            set
            {
                if (value == null)
                    throw new ArgumentException("Lahan harus dipilih.");
                lahan = value;
            }
        }

        public User Pengelola
        {
            get { return pengelola; }
            set { pengelola = value; }
        }

        public IReadOnlyList<Panen> DaftarPanen
        {
            get { return daftar_panen.AsReadOnly(); }
        }

        public Penanaman(int id_periode, Lahan lahan, User pengelola, string komoditas)
        {
            IdPeriode = id_periode;
            Lahan = lahan;
            Pengelola = pengelola;
            Komoditas = komoditas;
        }

        public Panen CatatPanen(DateTime tanggal_panen, decimal jumlah_kg)
        {
            Panen panen = new Panen(0, id_periode, tanggal_panen, jumlah_kg, id_penanaman);
            daftar_panen.Add(panen);
            return panen;
        }

        public decimal HitungTotalPanenKg()
        {
            decimal total = 0;
            foreach (Panen p in daftar_panen)
            {
                total += p.JumlahKg;
            }
            return total;
        }

        public decimal HitungPendapatan()
        {
            decimal total = 0;
            foreach (Panen p in daftar_panen)
            {
                total += p.HitungTotalPendapatan();
            }
            return total;
        }
    }

    public class PeriodeTanam
    {
        private int id_periode;
        private int bulan_mulai;
        private int tahun_mulai;
        private int? bulan_selesai;
        private int? tahun_selesai;

       
        private List<Penanaman> daftar_penanaman = new List<Penanaman>();
        private List<Biaya> daftar_biaya = new List<Biaya>();
        private List<Panen> daftar_panen = new List<Panen>();

        public int IdPeriode
        {
            get { return id_periode; }
            set { id_periode = value; }
        }

        // [PILAR 1 - ENKAPSULASI]
        public int BulanMulai
        {
            get { return bulan_mulai; }
            private set
            {
                if (value < 1 || value > 12)
                    throw new ArgumentException("Bulan mulai harus antara 1 sampai 12.");
                bulan_mulai = value;
            }
        }

        public int TahunMulai
        {
            get { return tahun_mulai; }
            private set
            {
                if (value <= 0)
                    throw new ArgumentException("Tahun mulai tidak valid.");
                tahun_mulai = value;
            }
        }

        public int? BulanSelesai
        {
            get { return bulan_selesai; }
        }

        public int? TahunSelesai
        {
            get { return tahun_selesai; }
        }

        public IReadOnlyList<Penanaman> DaftarPenanaman
        {
            get { return daftar_penanaman.AsReadOnly(); }
        }

        public IReadOnlyList<Biaya> DaftarBiaya
        {
            get { return daftar_biaya.AsReadOnly(); }
        }

        public IReadOnlyList<Panen> DaftarPanen
        {
            get { return daftar_panen.AsReadOnly(); }
        }

        public PeriodeTanam(int id_periode, int bulan_mulai, int tahun_mulai)
        {
            IdPeriode = id_periode;
            BulanMulai = bulan_mulai;
            TahunMulai = tahun_mulai;
        }

       
        public void TetapkanPeriodeSelesai(int bulan, int tahun)
        {
            if (bulan < 1 || bulan > 12)
                throw new ArgumentException("Bulan selesai harus antara 1 sampai 12.");

            if (tahun < tahun_mulai || (tahun == tahun_mulai && bulan < bulan_mulai))
                throw new ArgumentException("Bulan/tahun selesai tidak boleh sebelum bulan/tahun mulai.");

            bulan_selesai = bulan;
            tahun_selesai = tahun;
        }

        
        public void TambahPenanaman(Lahan lahan, User pengelola, string komoditas)
        {
            daftar_penanaman.Add(new Penanaman(id_periode, lahan, pengelola, komoditas));
        }

        public void CatatBiayaPupuk(DateTime tanggal, string keterangan, int kg, int harga_per_kg, int? id_penanaman = null)
        {
            daftar_biaya.Add(new BiayaPupuk(id_periode, tanggal, keterangan, kg, harga_per_kg, id_penanaman));
        }

        public void CatatBiayaTenagaKerja(DateTime tanggal, string keterangan, int jumlah_hari, int upah_per_hari, int? id_penanaman = null)
        {
            daftar_biaya.Add(new BiayaTenagaKerja(id_periode, tanggal, keterangan, jumlah_hari, upah_per_hari, id_penanaman));
        }

        public void CatatBiayaPerawatan(DateTime tanggal, string keterangan, int nominal, int? id_penanaman = null)
        {
            daftar_biaya.Add(new BiayaPerawatan(id_periode, tanggal, keterangan, nominal, id_penanaman));
        }

        public void TambahBiaya(Biaya biaya)
        {
            if (biaya == null)
                throw new ArgumentException("Objek biaya tidak boleh kosong.");
            daftar_biaya.Add(biaya);
        }

        public Panen CatatPanen(DateTime tanggal_panen, decimal jumlah_kg, int? id_penanaman = null)
        {
            Panen panen = new Panen(0, id_periode, tanggal_panen, jumlah_kg, id_penanaman);
            daftar_panen.Add(panen);
            return panen;
        }

        public void TambahObjekPanen(Panen panen)
        {
            if (panen != null)
            {
                daftar_panen.Add(panen);
            }
        }

       
        public decimal HitungTotalBiaya()
        {
            decimal total = 0;
            foreach (Biaya b in daftar_biaya)
            {
                total += b.HitungTotal();
            }
            return total;
        }

        public decimal HitungTotalPendapatan()
        {
            decimal total = 0;
            foreach (Panen p in daftar_panen)
            {
                total += p.HitungTotalPendapatan();
            }
            foreach (Penanaman pn in daftar_penanaman)
            {
                total += pn.HitungPendapatan();
            }
            return total;
        }

    
        public decimal HitungLaba()
        {
            return HitungTotalPendapatan() - HitungTotalBiaya();
        }

        public decimal HitungHargaPokokPerKg()
        {
            decimal totalKg = 0;
            foreach (Panen p in daftar_panen)
            {
                totalKg += p.JumlahKg;
            }
            foreach (Penanaman pn in daftar_penanaman)
            {
                totalKg += pn.HitungTotalPanenKg();
            }

            if (totalKg <= 0)
                return 0;

            return HitungTotalBiaya() / totalKg;
        }
    }
}