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

namespace UTANI.Views.Buruh_Tani
{
    public partial class FormProfil : Form
    {
        public FormProfil()
        {
            InitializeComponent();
        }

        private void FormProfil_Load(object sender, EventArgs e)
        {
            TampilkanProfil();
        }

        private void TampilkanProfil()
        {
            var user = BaseController.CurrentUser;
            if (user == null) return;

            LbNama.Text = user.nama;
            LbUsername.Text = user.nama;
            LbNotelp.Text = user.nomor_telepon;
            LbEmail.Text = user.email;
            LbRole.Text = user.role == "buruh tani" ? "buruh tani" : "buruh tani";
        }

        private void sideBar1_Load(object sender, EventArgs e) { }
        private void LbNama_Click(object sender, EventArgs e) { }
        private void LbUsername_Click(object sender, EventArgs e) { }
        private void LbNotelp_Click(object sender, EventArgs e) { }
        private void LbEmail_Click(object sender, EventArgs e) { }
        private void LbRole_Click(object sender, EventArgs e) { }
    }
}