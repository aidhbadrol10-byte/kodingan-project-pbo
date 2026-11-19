using System;

namespace UTANI.Models
{
    
    public abstract class Biaya
    {
        private int id_biaya;
        private int id_periode;
        private int? id_penanaman;
        private string kategori;
        private DateTime tanggal;
        private string keterangan;

        public int IdBiaya
        {
            get { return id_biaya; }
            set { id_biaya = value; }
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

        public string Kategori
        {
            get { return kategori; }
            protected set { kategori = value; }
        }

        public DateTime Tanggal
        {
            get { return tanggal; }
            set { tanggal = value; }
        }

        public string Keterangan
        {
            get { return keterangan; }
            set { keterangan = value; }
        }

        protected Biaya(int id_periode, string kategori, DateTime tanggal, string keterangan, int? id_penanaman = null)
        {
            IdPeriode = id_periode;
            IdPenanaman = id_penanaman;
            Kategori = kategori;
            Tanggal = tanggal;
            Keterangan = keterangan;
        }

       
        public abstract decimal HitungTotal();
    }

    public class BiayaPupuk : Biaya
    {
        private int kuantitas;
        private int harga_satuan;

       
        public int Kuantitas
        {
            get { return kuantitas; }
            set
            {
                if (value < 0)
                    throw new ArgumentException("Jumlah kg pupuk tidak boleh negatif.");
                kuantitas = value;
            }
        }

        public int HargaSatuan
        {
            get { return harga_satuan; }
            set
            {
                if (value < 0)
                    throw new ArgumentException("Harga per kg tidak boleh negatif.");
                harga_satuan = value;
            }
        }

        public BiayaPupuk(int id_periode, DateTime tanggal, string keterangan, int kuantitas, int harga_satuan, int? id_penanaman = null)
            : base(id_periode, "pupuk", tanggal, keterangan, id_penanaman)
        {
            Kuantitas = kuantitas;
            HargaSatuan = harga_satuan;
        }

        public override decimal HitungTotal()
        {
            return (decimal)kuantitas * harga_satuan;
        }
    }

  
    public class BiayaTenagaKerja : Biaya
    {
        private int kuantitas;
        private int harga_satuan;

        
        public int Kuantitas
        {
            get { return kuantitas; }
            set
            {
                if (value < 0)
                    throw new ArgumentException("Jumlah hari kerja tidak boleh negatif.");
                kuantitas = value;
            }
        }

        public int HargaSatuan
        {
            get { return harga_satuan; }
            set
            {
                if (value < 0)
                    throw new ArgumentException("Upah per hari tidak boleh negatif.");
                harga_satuan = value;
            }
        }

        public BiayaTenagaKerja(int id_periode, DateTime tanggal, string keterangan, int kuantitas, int harga_satuan, int? id_penanaman = null)
            : base(id_periode, "tenaga_kerja", tanggal, keterangan, id_penanaman)
        {
            Kuantitas = kuantitas;
            HargaSatuan = harga_satuan;
        }

        public override decimal HitungTotal()
        {
            return (decimal)kuantitas * harga_satuan;
        }
    }

   
    public class BiayaPerawatan : Biaya
    {
        private int nominal;

    
        public int Nominal
        {
            get { return nominal; }
            set
            {
                if (value < 0)
                    throw new ArgumentException("Nominal biaya perawatan tidak boleh negatif.");
                nominal = value;
            }
        }

        public BiayaPerawatan(int id_periode, DateTime tanggal, string keterangan, int nominal, int? id_penanaman = null)
            : base(id_periode, "perawatan", tanggal, keterangan, id_penanaman)
        {
            Nominal = nominal;
        }

        public override decimal HitungTotal()
        {
            return nominal;
        }
    }
}