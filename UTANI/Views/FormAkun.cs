using System;
using System.Collections.Generic;
using System.Windows.Forms;
using UTANI.Controllers;
using UTANI.Models;

namespace UTANI.Views
{
    public partial class FormAkun : Form
    {
        private readonly UserController userController = new UserController();

       
        private int selectedIdPengguna = 0;

        public FormAkun()
        {
            InitializeComponent();

           
            dgvAkun.CellClick += dgvAkun_CellClick;

       
            dgvAkun.DataBindingComplete += (s, e) =>
            {
                if (dgvAkun.Columns.Contains("No"))
                {
                    for (int i = 0; i < dgvAkun.Rows.Count; i++)
                    {
                        dgvAkun.Rows[i].Cells["No"].Value = i + 1;
                    }
                }
            };
        }

        private void FormAkun_Load(object sender, EventArgs e)
        {
            if (BaseController.CurrentUser != null)
            {
                this.Text = "Kelola Akun - Login sebagai: " +
                            BaseController.CurrentUser.nama +
                            " (" + BaseController.CurrentUser.role + ")";
            }

            LoadDataAkun();
        }

        private void LoadDataAkun()
        {
            try
            {
                List<User> daftarBuruh = userController.AmbilSemuaBuruhTani();

                dgvAkun.Columns.Clear();
                dgvAkun.DataSource = null;
                dgvAkun.DataSource = daftarBuruh;

                dgvAkun.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvAkun.RowHeadersVisible = false;

                if (dgvAkun.Columns.Count > 0)
                {
                    dgvAkun.Columns["id_pengguna"].Visible = false;
                    dgvAkun.Columns["password"].Visible = false;

                    DataGridViewTextBoxColumn colNo = new DataGridViewTextBoxColumn();
                    colNo.Name = "No";
                    colNo.HeaderText = "No";
                    colNo.FillWeight = 25;
                    dgvAkun.Columns.Insert(0, colNo);

                    for (int i = 0; i < dgvAkun.Rows.Count; i++)
                    {
                        dgvAkun.Rows[i].Cells["No"].Value = i + 1;
                    }

                    dgvAkun.Columns["nama"].HeaderText = "Username";
                    dgvAkun.Columns["email"].HeaderText = "Email";
                    dgvAkun.Columns["nomor_telepon"].HeaderText = "No. Telp";
                    dgvAkun.Columns["role"].HeaderText = "Role";
                    dgvAkun.Columns["role"].FillWeight = 60;
                }

                dgvAkun.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memuat daftar akun: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ResetForm()
        {
            selectedIdPengguna = 0;
            tbUsernameAkun.Clear();
            tbEmailAkun.Clear();
            tbPasswordAkun.Clear();
            tbNomorAkun.Clear();
            dgvAkun.ClearSelection();
        }

       
        private void dgvAkun_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvAkun.Rows.Count)
            {
                User userTerpilih = dgvAkun.Rows[e.RowIndex].DataBoundItem as User;
                if (userTerpilih != null)
                {
                    selectedIdPengguna = userTerpilih.id_pengguna;
                    tbUsernameAkun.Text = userTerpilih.nama;
                    tbEmailAkun.Text = userTerpilih.email;
                    tbPasswordAkun.Text = userTerpilih.password;
                    tbNomorAkun.Text = userTerpilih.nomor_telepon;
                }
            }
        }

        private void tbPasswordAkun_TextChanged(object sender, EventArgs e)
        {
        }

        private void tbUsernameAkun_TextChanged(object sender, EventArgs e)
        {
        }

        private void tbNomorAkun_TextChanged(object sender, EventArgs e)
        {
        }

        private void tbEmailAkun_TextChanged(object sender, EventArgs e)
        {
        }


        private void button1_Click(object sender, EventArgs e)
        {
            string nama = tbUsernameAkun.Text.Trim();
            string email = tbEmailAkun.Text.Trim();
            string password = tbPasswordAkun.Text;
            string nomorTelepon = tbNomorAkun.Text.Trim();

            try
            {
                userController.TambahAkunBuruh(nama, email, password, nomorTelepon);

                MessageBox.Show("Akun buruh tani '" + nama + "' berhasil ditambahkan!",
                    "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);

                ResetForm();
                LoadDataAkun();
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
                MessageBox.Show("Gagal menyimpan data ke database: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

       
        private void btEditAkun_Click(object sender, EventArgs e)
        {
            if (selectedIdPengguna <= 0)
            {
                MessageBox.Show("Pilih terlebih dahulu baris akun buruh tani pada tabel yang ingin diubah.",
                    "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string nama = tbUsernameAkun.Text.Trim();
            string email = tbEmailAkun.Text.Trim();
            string password = tbPasswordAkun.Text;
            string nomorTelepon = tbNomorAkun.Text.Trim();

            try
            {
               
                userController.UbahAkunBuruh(selectedIdPengguna, nama, email, password, nomorTelepon);

                MessageBox.Show("Data akun buruh tani berhasil diperbarui!",
                    "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);

                ResetForm();
                LoadDataAkun();
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
                MessageBox.Show("Gagal memperbarui data akun: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

     
        private void btHapusAkun_Click(object sender, EventArgs e)
        {
            if (selectedIdPengguna <= 0)
            {
                MessageBox.Show("Pilih terlebih dahulu baris akun buruh tani pada tabel yang ingin dihapus.",
                    "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult konfirmasi = MessageBox.Show(
                "Apakah Anda yakin ingin menghapus akun '" + tbUsernameAkun.Text + "'?",
                "Konfirmasi Hapus",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (konfirmasi == DialogResult.Yes)
            {
                try
                {
                    
                    userController.HapusAkunBuruh(selectedIdPengguna);

                    MessageBox.Show("Akun buruh tani berhasil dihapus!",
                        "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    ResetForm();
                    LoadDataAkun();
                }
                catch (UnauthorizedAccessException ex)
                {
                    MessageBox.Show(ex.Message, "Peringatan Hak Akses",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Gagal menghapus akun (pastikan akun tidak sedang terhubung ke data penanaman): " + ex.Message,
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btLogout_Click(object sender, EventArgs e)
        {

        }

        private void btMengelolaAkun_Click(object sender, EventArgs e)
        {

        }

        private void btPanenPenjualan_Click(object sender, EventArgs e)
        {

        }

        private void btBiaya_Click(object sender, EventArgs e)
        {

        }

        private void btPeriodeTanam_Click(object sender, EventArgs e)
        {

        }

        private void btDashboard_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_2(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}