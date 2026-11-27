using System;
using System.Collections.Generic;
using System.Globalization;
using UTANI.Models;
using UTANI.Repositories;

namespace UTANI.Controllers
{
    public class BiayaController : BaseController
    {
        private readonly Repositories.Biaya biayaRepo = new Repositories.Biaya();

        public List<PeriodeItem> AmbilDaftarPeriode()
        {
            return biayaRepo.GetDaftarPeriode();
        }

        public List<Models.Biaya> AmbilSemuaBiaya()
        {
            return biayaRepo.GetAll();
        }

        public List<BiayaRowView> AmbilBiayaByPeriode(int idPeriode)
        {
            if (idPeriode <= 0)
                return new List<BiayaRowView>();

            return biayaRepo.GetByPeriode(idPeriode);
        }

        public Models.Biaya SimpanBiayaDariForm(
            int idPeriode,
            string namaLahanText,
            string kategoriText,
            string tanggalText,
            string keteranganText,
            string jumlahText,
            string biayaText)
        {
            ValidasiAksesPetani();

            if (idPeriode <= 0)
                throw new ArgumentException("Silakan pilih periode tanam terlebih dahulu.");

            if (string.IsNullOrWhiteSpace(namaLahanText))
                throw new ArgumentException("Nama lahan wajib diisi.");

            if (string.IsNullOrWhiteSpace(kategoriText))
                throw new ArgumentException("Kategori biaya wajib diisi (pupuk, tenaga_kerja, atau perawatan).");

            if (!DateTime.TryParse(tanggalText.Trim(), out DateTime tanggal))
                throw new ArgumentException("Format tanggal tidak valid (contoh: 2026-11-27 atau 27/11/2026).");

            var penanaman = biayaRepo.CariPenanamanByNama(namaLahanText, idPeriode)
                           ?? biayaRepo.CariPenanamanByNama(namaLahanText);

            if (!penanaman.HasValue)
                throw new ArgumentException("Data penanaman untuk lahan '" + namaLahanText.Trim() + "' tidak ditemukan.");

            int idPenanaman = penanaman.Value.idPenanaman;
            int idPeriodeFinal = penanaman.Value.idPeriode;
            string kategoriNorm = kategoriText.Trim().ToLower().Replace(" ", "_");

            Models.Biaya objekBiaya;

            if (kategoriNorm == "pupuk")
            {
                int jumlahKg = ParseBilanganBulat(jumlahText, "Jumlah (kg) pupuk");
                int hargaPerKg = ParseBilanganBulat(biayaText, "Harga per kg pupuk");
                objekBiaya = new BiayaPupuk(idPeriodeFinal, tanggal, keteranganText, jumlahKg, hargaPerKg, idPenanaman);
            }
            else if (kategoriNorm == "tenaga_kerja")
            {
                int jumlahHari = ParseBilanganBulat(jumlahText, "Jumlah hari kerja");
                int upahPerHari = ParseBilanganBulat(biayaText, "Upah per hari");
                objekBiaya = new BiayaTenagaKerja(idPeriodeFinal, tanggal, keteranganText, jumlahHari, upahPerHari, idPenanaman);
            }
            else if (kategoriNorm == "perawatan")
            {
                int nominalBiaya = ParseBilanganBulat(biayaText, "Nominal biaya perawatan");
                objekBiaya = new BiayaPerawatan(idPeriodeFinal, tanggal, keteranganText, nominalBiaya, idPenanaman);
            }
            else
            {
                throw new ArgumentException("Kategori tidak dikenal. Gunakan: pupuk, tenaga_kerja, atau perawatan.");
            }

            biayaRepo.Insert(objekBiaya);
            return objekBiaya;
        }

        private int ParseBilanganBulat(string text, string namaField)
        {
            if (string.IsNullOrWhiteSpace(text))
                throw new ArgumentException(namaField + " wajib diisi.");

            string bersih = text.Trim().Replace(".", "").Replace(",", "");
            if (!int.TryParse(bersih, NumberStyles.Integer, CultureInfo.InvariantCulture, out int nilai))
                throw new ArgumentException(namaField + " harus berupa angka.");

            return nilai;
        }
    }
}