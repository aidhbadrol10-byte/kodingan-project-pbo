using System;
using System.Collections.Generic;
using System.Windows.Forms;
using UTANI.Controllers;

namespace UTANI.Views.Buruh_Tani
{
    public partial class FormLahan : Form
    {
        private readonly LahanComtroller lahanController = new LahanComtroller();

        public FormLahan()
        {
            InitializeComponent();

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

            this.Load += FormLahan_Load;
            LoadDataLahan();
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
                if (dgvLahan == null) return;

                List<Models.Lahan> daftarLahan = lahanController.AmbilSemuaLahan() ?? new List<Models.Lahan>();

                dgvLahan.Visible = true;
                dgvLahan.BringToFront();

                dgvLahan.Columns.Clear();
                dgvLahan.DataSource = null;
                dgvLahan.DataSource = daftarLahan;

                dgvLahan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvLahan.RowHeadersVisible = false;
                dgvLahan.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dgvLahan.MultiSelect = false;
                dgvLahan.ReadOnly = true;
                dgvLahan.AllowUserToAddRows = false;
                dgvLahan.AllowUserToDeleteRows = false;

                if (dgvLahan.Columns.Count > 0)
                {
                    if (dgvLahan.Columns.Contains("id_lahan"))
                        dgvLahan.Columns["id_lahan"].Visible = false;

                    // Tambahkan kolom nomor urut otomatis (1, 2, 3...)
                    DataGridViewTextBoxColumn colNo = new DataGridViewTextBoxColumn
                    {
                        Name = "No",
                        HeaderText = "No",
                        FillWeight = 25
                    };
                    dgvLahan.Columns.Insert(0, colNo);

                    for (int i = 0; i < dgvLahan.Rows.Count; i++)
                    {
                        dgvLahan.Rows[i].Cells["No"].Value = i + 1;
                    }

                    if (dgvLahan.Columns.Contains("nama_lahan"))
                        dgvLahan.Columns["nama_lahan"].HeaderText = "Nama Lahan & Komoditas";

                    if (dgvLahan.Columns.Contains("luas_lahan"))
                    {
                        dgvLahan.Columns["luas_lahan"].HeaderText = "Luas (Ha)";
                        dgvLahan.Columns["luas_lahan"].FillWeight = 55;
                    }

                    if (dgvLahan.Columns.Contains("lokasi"))
                        dgvLahan.Columns["lokasi"].HeaderText = "Lokasi";

                    if (dgvLahan.Columns.Contains("keterangan"))
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

        private void dgvLahan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Mode read-only: tidak perlu aksi edit/pilih ke form input
        }

        private void dgvLahan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Mode read-only: tidak perlu aksi edit/pilih ke form input
        }

        private void sideBar1_Load_1(object sender, EventArgs e)
        {

        }

        private void FormLahan_Load_1(object sender, EventArgs e)
        {

        }
    }
}