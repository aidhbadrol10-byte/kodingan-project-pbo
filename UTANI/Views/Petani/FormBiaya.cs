using System;
using System.Collections.Generic;
using System.Windows.Forms;
using UTANI.Controllers;
using UTANI.Models;
using UTANI.Repositories;

namespace UTANI.Views.Petani
{
    public partial class FormBiaya : Form
    {
        private readonly BiayaController biayaController = new BiayaController();
        private bool sedangMemuatPeriode = false;

        public FormBiaya()
        {
            InitializeComponent();
        }

        private void FormBiaya_Load(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbTanggal.Text))
            {
                tbTanggal.Text = DateTime.Now.ToString("yyyy-MM-dd");
            }

            MuatDaftarKategori();
            MuatDaftarPeriode();

            if (cbPeriode.SelectedValue != null && int.TryParse(cbPeriode.SelectedValue.ToString(), out int idPeriode))
            {
                MuatDataBiaya(idPeriode);
            }
        }

        private void MuatDaftarKategori()
        {
            comboBox1.Items.Clear();
            comboBox1.Items.Add("Biaya Tenaga Kerja");
            comboBox1.Items.Add("Biaya Perawatan");
            comboBox1.Items.Add("Biaya Pupuk");
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.SelectedIndex = 0;
        }

        private void MuatDaftarPeriode()
        {
            sedangMemuatPeriode = true;
            try
            {
                List<PeriodeItem> daftarPeriode = biayaController.AmbilDaftarPeriode();
                cbPeriode.DataSource = daftarPeriode;
                cbPeriode.DisplayMember = "LabelPeriode";
                cbPeriode.ValueMember = "IdPeriode";
                cbPeriode.DropDownStyle = ComboBoxStyle.DropDownList;
            }
            finally
            {
                sedangMemuatPeriode = false;
            }
        }

        private void MuatDataBiaya(int idPeriode)
        {
            List<BiayaRowView> data = biayaController.AmbilBiayaByPeriode(idPeriode);

            dgvBiaya.AutoGenerateColumns = true;
            dgvBiaya.DataSource = null;
            dgvBiaya.DataSource = data;
            dgvBiaya.ReadOnly = true;
            dgvBiaya.AllowUserToAddRows = false;
            dgvBiaya.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBiaya.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            if (dgvBiaya.Columns["IdBiaya"] != null) dgvBiaya.Columns["IdBiaya"].Visible = false;
            if (dgvBiaya.Columns["IdPeriode"] != null) dgvBiaya.Columns["IdPeriode"].Visible = false;
            if (dgvBiaya.Columns["IdPenanaman"] != null) dgvBiaya.Columns["IdPenanaman"].Visible = false;

            if (dgvBiaya.Columns["LahanKomoditas"] != null) dgvBiaya.Columns["LahanKomoditas"].HeaderText = "Lahan & Komoditas";
            if (dgvBiaya.Columns["Kategori"] != null) dgvBiaya.Columns["Kategori"].HeaderText = "Kategori";
            if (dgvBiaya.Columns["Tanggal"] != null)
            {
                dgvBiaya.Columns["Tanggal"].HeaderText = "Tanggal";
                dgvBiaya.Columns["Tanggal"].DefaultCellStyle.Format = "dd/MM/yyyy";
            }
            if (dgvBiaya.Columns["Keterangan"] != null) dgvBiaya.Columns["Keterangan"].HeaderText = "Keterangan";
            if (dgvBiaya.Columns["Kuantitas"] != null) dgvBiaya.Columns["Kuantitas"].HeaderText = "Jumlah";
            if (dgvBiaya.Columns["HargaSatuan"] != null)
            {
                dgvBiaya.Columns["HargaSatuan"].HeaderText = "Harga Satuan";
                dgvBiaya.Columns["HargaSatuan"].DefaultCellStyle.Format = "N0";
            }
            if (dgvBiaya.Columns["Nominal"] != null)
            {
                dgvBiaya.Columns["Nominal"].HeaderText = "Nominal";
                dgvBiaya.Columns["Nominal"].DefaultCellStyle.Format = "N0";
            }
            if (dgvBiaya.Columns["TotalBiaya"] != null)
            {
                dgvBiaya.Columns["TotalBiaya"].HeaderText = "Total Biaya";
                dgvBiaya.Columns["TotalBiaya"].DefaultCellStyle.Format = "N0";
            }
        }

        private void cbPeriode_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (sedangMemuatPeriode || cbPeriode.SelectedValue == null)
                return;

            if (int.TryParse(cbPeriode.SelectedValue.ToString(), out int idPeriode))
            {
                MuatDataBiaya(idPeriode);
            }
        }

        private void btBiaya_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbPeriode.SelectedValue == null || !int.TryParse(cbPeriode.SelectedValue.ToString(), out int idPeriode))
                    throw new ArgumentException("Silakan pilih periode tanam terlebih dahulu.");

                string kategoriDipilih = comboBox1.SelectedItem?.ToString() ?? string.Empty;

                UTANI.Models.Biaya tersimpan = biayaController.SimpanBiayaDariForm(
                    idPeriode,
                    tbLahan.Text,
                    kategoriDipilih,
                    tbTanggal.Text,
                    tbKeterangan.Text,
                    tbJumlah.Text,
                    tbBiaya.Text
                );

                MessageBox.Show(
                    "Biaya berhasil disimpan!\nKategori: " + tersimpan.Kategori +
                    "\nTotal Biaya: Rp " + tersimpan.HitungTotal().ToString("N0"),
                    "Sukses",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                ResetInput();
                MuatDataBiaya(idPeriode);
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Validasi Input",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal menyimpan data biaya: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ResetInput()
        {
            tbLahan.Clear();
            if (comboBox1.Items.Count > 0)
                comboBox1.SelectedIndex = 0;
            tbTanggal.Text = DateTime.Now.ToString("yyyy-MM-dd");
            tbKeterangan.Clear();
            tbJumlah.Clear();
            tbBiaya.Clear();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void dgvBiaya_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void sideBar1_Load(object sender, EventArgs e)
        {
        }

        private void tbLahan_TextChanged(object sender, EventArgs e)
        {
        }

        private void tbTanggal_TextChanged(object sender, EventArgs e)
        {
        }

        private void tbKeterangan_TextChanged(object sender, EventArgs e)
        {
        }

        private void tbJumlah_TextChanged(object sender, EventArgs e)
        {
        }

        private void tbBiaya_TextChanged(object sender, EventArgs e)
        {
        }
    }
}