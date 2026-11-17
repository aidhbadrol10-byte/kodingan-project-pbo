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

namespace UTANI
{
    public partial class Form1 : Form
    {
        private readonly usercontroller userController = new usercontroller();

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
                MessageBox.Show("Email dan password wajib diisi");
                return;
            }

            try
            {
                User user = userController.Login(nama, password);

                if (user != null)
                {
                    MessageBox.Show("Login berhasil. Selamat datang, " + user.nama + " (" + user.role + ")");
                    // TODO: buka form dashboard sesuai role, lalu this.Hide();
                }
                else
                {
                    MessageBox.Show("Email atau password salah");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal terhubung ke database: " + ex.Message);
            }
        }
    }
}