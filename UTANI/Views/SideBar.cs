using System;
using System.Drawing;
using System.Windows.Forms;
using UTANI.Controllers;

namespace UTANI.Views
{
    public partial class SideBar : UserControl
    {
        public static bool IsNavigating { get; set; } = false;

        public SideBar()
        {
            InitializeComponent();
            AturMenuBerdasarkanRole();
        }

        private void AturMenuBerdasarkanRole()
        {
            // Mencegah error saat Form dibuka di tampilan Visual Studio Designer
            if (this.DesignMode || BaseController.CurrentUser == null)
                return;

            string role = BaseController.CurrentUser.role;

            if (role == "buruh_tani")
            {
                // Sembunyikan menu yang khusus untuk petani
                btMengelolaAkun.Visible = false;
                btBiaya.Visible = false;
                btnPenjualan.Visible = false;
                btProfil.Visible = true;
            }
            else if (role == "petani")
            {
                // Petani dapat melihat seluruh menu kecuali Profil khusus buruh tani
                btProfil.Visible = false;
                btDashboard.Visible = true;
                btLahan.Visible = true;
                btPeriodeTanam.Visible = true;
                btPanen.Visible = true;
                btBiaya.Visible = true;
                btnPenjualan.Visible = true;
                btMengelolaAkun.Visible = true;
            }

            // Susun ulang posisi Y tombol yang tampil agar rapat dan tidak ada jarak kosong
            Button[] daftarMenu = {
                btDashboard,
                btLahan,
                btPeriodeTanam,
                btBiaya,
                btPanen,
                btMengelolaAkun,
                btnPenjualan
            };

            int posisiY = 19; // Posisi Y awal (sejajar posisi btDashboard)
            int jarakAntarMenu = 78;

            foreach (Button btn in daftarMenu)
            {
                if (btn.Visible)
                {
                    btn.Location = new Point(btn.Location.X, posisiY);
                    posisiY += jarakAntarMenu;
                }
            }
        }

        private void PindahHalaman(Form formTujuan)
        {
            Form formAktif = this.FindForm();

            if (formAktif != null && formAktif.GetType() == formTujuan.GetType())
            {
                formTujuan.Dispose();
                return;
            }

            IsNavigating = true;

            formTujuan.FormClosed += (s, args) =>
            {
                if (!IsNavigating)
                {
                    Application.Exit();
                }
            };

            if (formAktif != null)
            {
                formTujuan.StartPosition = FormStartPosition.Manual;
                formTujuan.Location = formAktif.Location;
                formTujuan.Size = formAktif.Size;
            }

            formTujuan.Show();

            if (formAktif != null)
            {
                formAktif.Close();
            }

            formTujuan.BringToFront();
            formTujuan.Activate();

            IsNavigating = false;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void btDashboard_Click(object sender, EventArgs e)
        {
            if (BaseController.CurrentUser == null) return;

            if (BaseController.CurrentUser.role == "petani")
            {
                PindahHalaman(new Petani.FormDashboard());
            }
            else if (BaseController.CurrentUser.role == "buruh_tani")
            {
                PindahHalaman(new Buruh_Tani.FormDashboard());
            }
        }

        private void btLahan_Click(object sender, EventArgs e)
        {
            if (BaseController.CurrentUser == null) return;

            if (BaseController.CurrentUser.role == "petani")
            {
                PindahHalaman(new Petani.FormLahan());
            }
            else if (BaseController.CurrentUser.role == "buruh_tani")
            {
                PindahHalaman(new Buruh_Tani.FormLahan());
            }
        }

        private void btPeriodeTanam_Click(object sender, EventArgs e)
        {
            if (BaseController.CurrentUser == null) return;

            if (BaseController.CurrentUser.role == "petani")
            {
                PindahHalaman(new Petani.FormPeriodeTanam());
            }
            else if (BaseController.CurrentUser.role == "buruh_tani")
            {
                PindahHalaman(new Buruh_Tani.FormPeriodeTanam());
            }
        }

        private void btBiaya_Click(object sender, EventArgs e)
        {
            if (BaseController.CurrentUser == null) return;

            if (BaseController.CurrentUser.role == "petani")
            {
                PindahHalaman(new Petani.FormBiaya());
            }
        }

        private void btPanen_Click_1(object sender, EventArgs e)
        {
            if (BaseController.CurrentUser == null) return;

            if (BaseController.CurrentUser.role == "petani")
            {
                PindahHalaman(new Petani.FormPanen());
            }
            else if (BaseController.CurrentUser.role == "buruh_tani")
            {
                PindahHalaman(new Buruh_Tani.FormPanen());
            }
        }


        private void btMengelolaAkun_Click(object sender, EventArgs e)
        {
            if (BaseController.CurrentUser == null) return;

            if (BaseController.CurrentUser.role == "petani")
            {
                PindahHalaman(new Petani.FormAkun());
            }
        }

        private void btLogout_Click(object sender, EventArgs e)
        {
            DialogResult konfirmasi = MessageBox.Show(
                "Apakah Anda yakin ingin keluar dari akun?",
                "Konfirmasi Keluar",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (konfirmasi == DialogResult.Yes)
            {
                IsNavigating = true;
                BaseController.CurrentUser = null;

                Form formAktif = this.FindForm();
                if (formAktif != null)
                {
                    formAktif.Close();
                }

                Form formLogin = Application.OpenForms["Form1"];
                if (formLogin != null)
                {
                    formLogin.Show();
                    formLogin.BringToFront();
                    formLogin.Activate();
                }
                else
                {
                    new Form1().Show();
                }

                IsNavigating = false;
            }
        }

        private void btProfil_Click(object sender, EventArgs e)
        {
            if (BaseController.CurrentUser == null) return;

            if (BaseController.CurrentUser.role == "buruh_tani")
            {
                PindahHalaman(new Buruh_Tani.FormProfil());
            }
        }

        private void btnPenjualan_Click(object sender, EventArgs e)
        {
            if (BaseController.CurrentUser == null) return;

            if (BaseController.CurrentUser.role == "petani")
            {
                PindahHalaman(new Petani.FormPenjualan());
            }
        }
    }
}