using System;
using System.Collections.Generic;
using System.Globalization;

namespace UTANI.Controllers
{
    public class LahanComtroller : BaseController
    {
        private readonly Repositories.Lahan lahanRepo = new Repositories.Lahan();

        public List<Models.Lahan> AmbilSemuaLahan()
        {
            return lahanRepo.GetAll();
        }

        public void TambahLahan(string namaLahan, string luasText, string lokasi, string keterangan)
        {
            ValidasiAksesPetani();

            double luas = ParseLuas(luasText);
            Models.Lahan lahanBaru = new Models.Lahan(0, namaLahan, luas, lokasi, keterangan);

            lahanRepo.Insert(lahanBaru);
        }

        public void UbahLahan(int idLahan, string namaLahan, string luasText, string lokasi, string keterangan)
        {
            ValidasiAksesPetani();

            if (idLahan <= 0)
                throw new ArgumentException("Pilih data lahan pada tabel terlebih dahulu.");

            double luas = ParseLuas(luasText);
            Models.Lahan lahanUpdate = new Models.Lahan(idLahan, namaLahan, luas, lokasi, keterangan);

            lahanRepo.Update(lahanUpdate);
        }

        public void HapusLahan(int idLahan)
        {
            ValidasiAksesPetani();

            if (idLahan <= 0)
                throw new ArgumentException("Pilih data lahan pada tabel terlebih dahulu.");

            lahanRepo.Delete(idLahan);
        }

        private double ParseLuas(string luasText)
        {
            if (string.IsNullOrWhiteSpace(luasText))
                throw new ArgumentException("Luas lahan wajib diisi.");

            // Mendukung input desimal menggunakan koma (1,5) maupun titik (1.5)
            string normalized = luasText.Trim().Replace(',', '.');
            if (!double.TryParse(normalized, NumberStyles.Any, CultureInfo.InvariantCulture, out double hasil))
                throw new ArgumentException("Luas lahan harus berupa angka (contoh: 1.5 atau 2).");

            return hasil;
        }
    }
}