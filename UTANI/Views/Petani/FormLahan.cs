using System;
using System.Collections.Generic;
using System.Windows.Forms;
using UTANI.Controllers;

namespace UTANI.Views.Petani
{
    public partial class FormLahan : Form
    {
        private readonly LahanComtroller lahanController = new LahanComtroller();
        private int selectedIdLahan = 0;

        public FormLahan()
        {
            InitializeComponent();

            // Klik di area mana pun pada baris tabel langsung mengisi form input
            dgvLahan.CellClick += dgvLahan_CellClick;

            // Menjamin nomor urut 1, 2, 3... tetap rapi setelah data di-render
            dgvLahan.DataBindingComplete += (s, e) =>
            {
                if (dgvLahan.Columns.Contains("No"))
                {
                    for (int i = 0; i < dgvLahan.Rows.Count; i++)
                    {
                        dgvLahan.Rows[i].Cells["No"].Value = i + 1;
                    }
                }
            };
        }

        private void FormLahan_Load(object sender, EventArgs e)
        {
            if (BaseController.CurrentUser != null)
            {
                this.Text = "Kelola Lahan - Login sebagai: " +
                            BaseController.CurrentUser.nama +
                            " (" + BaseController.CurrentUser.role + ")";
            }

            LoadDataLahan();
        }

        private void LoadDataLahan()
        {
            try
            {
                List<Models.Lahan> daftarLahan = lahanController.AmbilSemuaLahan();

                dgvLahan.Columns.Clear();
                dgvLahan.DataSource = null;
                dgvLahan.DataSource = daftarLahan;

                dgvLahan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvLahan.RowHeadersVisible = false;
                dgvLahan.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dgvLahan.MultiSelect = false;
                dgvLahan.ReadOnly = true;
                dgvLahan.AllowUserToAddRows = false;

                if (dgvLahan.Columns.Count > 0)
                {
                    // Sembunyikan ID asli PostgreSQL
                    dgvLahan.Columns["id_lahan"].Visible = false;

                    // Tambahkan kolom nomor urut otomatis (1, 2, 3...)
                    DataGridViewTextBoxColumn colNo = new DataGridViewTextBoxColumn();
                    colNo.Name = "No";
                    colNo.HeaderText = "No";
                    colNo.FillWeight = 25;
                    dgvLahan.Columns.Insert(0, colNo);

                    for (int i = 0; i < dgvLahan.Rows.Count; i++)
                    {
                        dgvLahan.Rows[i].Cells["No"].Value = i + 1;
                    }

                    dgvLahan.Columns["nama_lahan"].HeaderText = "Nama Lahan & Komoditas";
                    dgvLahan.Columns["luas_lahan"].HeaderText = "Luas (Ha)";
                    dgvLahan.Columns["luas_lahan"].FillWeight = 55;
                    dgvLahan.Columns["lokasi"].HeaderText = "Lokasi";
                    dgvLahan.Columns["keterangan"].HeaderText = "Keterangan";
                }

                dgvLahan.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memuat data lahan: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ResetForm()
        {
            selectedIdLahan = 0;
            tbNamaLahan.Clear();
            tbLuas.Clear();
            tbLokasi.Clear();
            tbKeterangan.Clear();
            dgvLahan.ClearSelection();
        }

        private void PilihBarisLahan(int rowIndex)
        {
            if (rowIndex >= 0 && rowIndex < dgvLahan.Rows.Count)
            {
                Models.Lahan lahanTerpilih = dgvLahan.Rows[rowIndex].DataBoundItem as Models.Lahan;
                if (lahanTerpilih != null)
                {
                    selectedIdLahan = lahanTerpilih.id_lahan;
                    tbNamaLahan.Text = lahanTerpilih.nama_lahan;
                    tbLuas.Text = lahanTerpilih.luas_lahan.ToString();
                    tbLokasi.Text = lahanTerpilih.lokasi;
                    tbKeterangan.Text = lahanTerpilih.keterangan;
                }
            }
        }

        private void dgvLahan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            PilihBarisLahan(e.RowIndex);
        }

        private void dgvLahan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            PilihBarisLahan(e.RowIndex);
        }

        // --- TAMBAH LAHAN ---
        private void btTambahkanLahan_Click(object sender, EventArgs e)
        {
            try
            {
                lahanController.TambahLahan(
                    tbNamaLahan.Text,
                    tbLuas.Text,
                    tbLokasi.Text,
                    tbKeterangan.Text
                );

                MessageBox.Show("Data lahan berhasil ditambahkan!",
                    "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);

                ResetForm();
                LoadDataLahan();
            }
            catch (UnauthorizedAccessException ex)
            {
                MessageBox.Show(ex.Message, "Peringatan Hak Akses",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Input Tidak Valid",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal menyimpan data lahan: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // --- UBAH LAHAN ---
        private void btUbah_Click(object sender, EventArgs e)
        {
            if (selectedIdLahan <= 0)
            {
                MessageBox.Show("Pilih terlebih dahulu baris lahan pada tabel yang ingin diubah.",
                    "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                lahanController.UbahLahan(
                    selectedIdLahan,
                    tbNamaLahan.Text,
                    tbLuas.Text,
                    tbLokasi.Text,
                    tbKeterangan.Text
                );

                MessageBox.Show("Data lahan berhasil diperbarui!",
                    "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);

                ResetForm();
                LoadDataLahan();
            }
            catch (UnauthorizedAccessException ex)
            {
                MessageBox.Show(ex.Message, "Peringatan Hak Akses",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Input Tidak Valid",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memperbarui data lahan: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // --- HAPUS LAHAN ---
        private void btHapus_Click(object sender, EventArgs e)
        {
            if (selectedIdLahan <= 0)
            {
                MessageBox.Show("Pilih terlebih dahulu baris lahan pada tabel yang ingin dihapus.",
                    "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult konfirmasi = MessageBox.Show(
                "Apakah Anda yakin ingin menghapus lahan '" + tbNamaLahan.Text + "'?",
                "Konfirmasi Hapus",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (konfirmasi == DialogResult.Yes)
            {
                try
                {
                    lahanController.HapusLahan(selectedIdLahan);

                    MessageBox.Show("Data lahan berhasil dihapus!",
                        "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    ResetForm();
                    LoadDataLahan();
                }
                catch (UnauthorizedAccessException ex)
                {
                    MessageBox.Show(ex.Message, "Peringatan Hak Akses",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Gagal menghapus lahan (pastikan lahan tidak sedang digunakan pada periode tanam): " + ex.Message,
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void tbKeterangan_TextChanged(object sender, EventArgs e)
        {
        }

        private void tbLokasi_TextChanged(object sender, EventArgs e)
        {
        }

        private void tbLuas_TextChanged(object sender, EventArgs e)
        {
        }

        private void tbNamaLahan_TextChanged(object sender, EventArgs e)
        {
        }

        private void sideBar1_Load(object sender, EventArgs e)
        {

        }
    }
}