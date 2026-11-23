using System;
using System.Windows.Forms;
using UTANI.Controllers;
using UTANI.Models;
using UTANI.Views;

namespace UTANI
{
    public partial class Form1 : Form
    {
        private readonly UserController userController = new UserController();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            string nama = tbUsername.Text.Trim();
            string password = tbPassword.Text;

            if (nama == "" || password == "")
            {
                MessageBox.Show("Username dan password wajib diisi.", "Peringatan",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                User user = userController.Login(nama, password);

                if (user != null)
                {
                    MessageBox.Show("Login berhasil. Selamat datang, " + user.nama + " (" + user.role + ")",
                        "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Form formDashboard;
                    if (user.role == "buruh_tani")
                    {
                        formDashboard = new UTANI.Views.Buruh_Tani.FormDashboard();
                    }
                    else
                    {
                        formDashboard = new UTANI.Views.Petani.FormDashboard();
                    }

                    formDashboard.FormClosed += (s, args) =>
                    {
                        if (!SideBar.IsNavigating)
                        {
                            Application.Exit();
                        }
                    };

                    tbPassword.Clear();
                    formDashboard.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Username atau password salah.", "Login Gagal",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal terhubung ke database: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}