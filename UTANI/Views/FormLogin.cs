using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

                    FormAkun formAkun = new FormAkun();
                    formAkun.FormClosed += (s, args) =>
                    {
                        
                        if (!SideBar.IsNavigating)
                        {
                            Application.Exit();
                        }
                    };

                    tbPassword.Clear();
                    formAkun.Show();
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