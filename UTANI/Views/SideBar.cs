using System;
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
            PindahHalaman(new FormDashboard());
        }

        private void btLahan_Click(object sender, EventArgs e)
        {
            PindahHalaman(new FormLahan());
        }

        private void btPeriodeTanam_Click(object sender, EventArgs e)
        {
            PindahHalaman(new FormPeriode());
        }

        private void btBiaya_Click(object sender, EventArgs e)
        {
            PindahHalaman(new FormBiaya());
        }

        private void btPanenPenjualan_Click(object sender, EventArgs e)
        {
            PindahHalaman(new PanenPenjualan());
        }

        private void btMengelolaAkun_Click(object sender, EventArgs e)
        {
            PindahHalaman(new FormAkun());
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

                Form formLogin = Application.OpenForms["Form1"];
                if (formLogin != null)
                {
                    formLogin.Show();
                }
                else
                {
                    new Form1().Show();
                }

                Form formAktif = this.FindForm();
                if (formAktif != null)
                {
                    formAktif.Close();
                }

                IsNavigating = false;
            }
        }
    }
}