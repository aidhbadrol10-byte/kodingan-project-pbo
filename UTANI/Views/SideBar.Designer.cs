namespace UTANI.Views
{
    partial class SideBar
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btLogout = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btProfil = new System.Windows.Forms.Button();
            this.btMengelolaAkun = new System.Windows.Forms.Button();
            this.btBiaya = new System.Windows.Forms.Button();
            this.btPeriodeTanam = new System.Windows.Forms.Button();
            this.btLahan = new System.Windows.Forms.Button();
            this.btDashboard = new System.Windows.Forms.Button();
            this.btPanen = new System.Windows.Forms.Button();
            this.btnPenjualan = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btLogout
            // 
            this.btLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(81)))));
            this.btLogout.FlatAppearance.BorderSize = 0;
            this.btLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btLogout.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLogout.ForeColor = System.Drawing.Color.White;
            this.btLogout.Location = new System.Drawing.Point(143, 660);
            this.btLogout.Name = "btLogout";
            this.btLogout.Size = new System.Drawing.Size(171, 60);
            this.btLogout.TabIndex = 11;
            this.btLogout.Text = "Keluar";
            this.btLogout.UseVisualStyleBackColor = false;
            this.btLogout.Click += new System.EventHandler(this.btLogout_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.btnPenjualan);
            this.panel1.Controls.Add(this.btPanen);
            this.panel1.Controls.Add(this.btProfil);
            this.panel1.Controls.Add(this.btMengelolaAkun);
            this.panel1.Controls.Add(this.btBiaya);
            this.panel1.Controls.Add(this.btPeriodeTanam);
            this.panel1.Controls.Add(this.btLahan);
            this.panel1.Controls.Add(this.btDashboard);
            this.panel1.Controls.Add(this.btLogout);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(457, 756);
            this.panel1.TabIndex = 13;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btProfil
            // 
            this.btProfil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(244)))), ((int)(((byte)(198)))));
            this.btProfil.FlatAppearance.BorderSize = 0;
            this.btProfil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btProfil.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btProfil.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(81)))));
            this.btProfil.Location = new System.Drawing.Point(178, 582);
            this.btProfil.Name = "btProfil";
            this.btProfil.Size = new System.Drawing.Size(104, 49);
            this.btProfil.TabIndex = 18;
            this.btProfil.Text = "Profil";
            this.btProfil.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btProfil.UseVisualStyleBackColor = false;
            this.btProfil.Click += new System.EventHandler(this.btProfil_Click);
            // 
            // btMengelolaAkun
            // 
            this.btMengelolaAkun.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(244)))), ((int)(((byte)(198)))));
            this.btMengelolaAkun.FlatAppearance.BorderSize = 0;
            this.btMengelolaAkun.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btMengelolaAkun.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btMengelolaAkun.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(81)))));
            this.btMengelolaAkun.Location = new System.Drawing.Point(61, 499);
            this.btMengelolaAkun.Name = "btMengelolaAkun";
            this.btMengelolaAkun.Size = new System.Drawing.Size(253, 49);
            this.btMengelolaAkun.TabIndex = 17;
            this.btMengelolaAkun.Text = "Mengelola Akun";
            this.btMengelolaAkun.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btMengelolaAkun.UseVisualStyleBackColor = false;
            this.btMengelolaAkun.Click += new System.EventHandler(this.btMengelolaAkun_Click);
            // 
            // btBiaya
            // 
            this.btBiaya.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(244)))), ((int)(((byte)(198)))));
            this.btBiaya.FlatAppearance.BorderSize = 0;
            this.btBiaya.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btBiaya.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btBiaya.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(81)))));
            this.btBiaya.Location = new System.Drawing.Point(61, 421);
            this.btBiaya.Name = "btBiaya";
            this.btBiaya.Size = new System.Drawing.Size(253, 49);
            this.btBiaya.TabIndex = 15;
            this.btBiaya.Text = "Biaya";
            this.btBiaya.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btBiaya.UseVisualStyleBackColor = false;
            this.btBiaya.Click += new System.EventHandler(this.btBiaya_Click);
            // 
            // btPeriodeTanam
            // 
            this.btPeriodeTanam.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(244)))), ((int)(((byte)(198)))));
            this.btPeriodeTanam.FlatAppearance.BorderSize = 0;
            this.btPeriodeTanam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btPeriodeTanam.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btPeriodeTanam.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(81)))));
            this.btPeriodeTanam.Location = new System.Drawing.Point(61, 178);
            this.btPeriodeTanam.Name = "btPeriodeTanam";
            this.btPeriodeTanam.Size = new System.Drawing.Size(253, 49);
            this.btPeriodeTanam.TabIndex = 14;
            this.btPeriodeTanam.Text = "Periode Tanam";
            this.btPeriodeTanam.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btPeriodeTanam.UseVisualStyleBackColor = false;
            this.btPeriodeTanam.Click += new System.EventHandler(this.btPeriodeTanam_Click);
            // 
            // btLahan
            // 
            this.btLahan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(244)))), ((int)(((byte)(198)))));
            this.btLahan.FlatAppearance.BorderSize = 0;
            this.btLahan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btLahan.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLahan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(81)))));
            this.btLahan.Location = new System.Drawing.Point(61, 100);
            this.btLahan.Name = "btLahan";
            this.btLahan.Size = new System.Drawing.Size(253, 49);
            this.btLahan.TabIndex = 13;
            this.btLahan.Text = "Lahan";
            this.btLahan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btLahan.UseVisualStyleBackColor = false;
            this.btLahan.Click += new System.EventHandler(this.btLahan_Click);
            // 
            // btDashboard
            // 
            this.btDashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(244)))), ((int)(((byte)(198)))));
            this.btDashboard.FlatAppearance.BorderSize = 0;
            this.btDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btDashboard.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDashboard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(81)))));
            this.btDashboard.Location = new System.Drawing.Point(61, 19);
            this.btDashboard.Name = "btDashboard";
            this.btDashboard.Size = new System.Drawing.Size(253, 49);
            this.btDashboard.TabIndex = 12;
            this.btDashboard.Text = "Dashboard";
            this.btDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btDashboard.UseVisualStyleBackColor = false;
            this.btDashboard.Click += new System.EventHandler(this.btDashboard_Click);
            // 
            // btPanen
            // 
            this.btPanen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(244)))), ((int)(((byte)(198)))));
            this.btPanen.FlatAppearance.BorderSize = 0;
            this.btPanen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btPanen.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btPanen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(81)))));
            this.btPanen.Location = new System.Drawing.Point(61, 262);
            this.btPanen.Name = "btPanen";
            this.btPanen.Size = new System.Drawing.Size(253, 50);
            this.btPanen.TabIndex = 20;
            this.btPanen.Text = "Panen";
            this.btPanen.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btPanen.UseVisualStyleBackColor = false;
            this.btPanen.Click += new System.EventHandler(this.btPanen_Click_1);
            // 
            // btnPenjualan
            // 
            this.btnPenjualan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(244)))), ((int)(((byte)(198)))));
            this.btnPenjualan.FlatAppearance.BorderSize = 0;
            this.btnPenjualan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPenjualan.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPenjualan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(81)))));
            this.btnPenjualan.Location = new System.Drawing.Point(61, 342);
            this.btnPenjualan.Name = "btnPenjualan";
            this.btnPenjualan.Size = new System.Drawing.Size(253, 50);
            this.btnPenjualan.TabIndex = 21;
            this.btnPenjualan.Text = "Penjualan";
            this.btnPenjualan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPenjualan.UseVisualStyleBackColor = false;
            this.btnPenjualan.Click += new System.EventHandler(this.btnPenjualan_Click);
            // 
            // SideBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "SideBar";
            this.Size = new System.Drawing.Size(457, 756);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btLogout;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btMengelolaAkun;
        private System.Windows.Forms.Button btBiaya;
        private System.Windows.Forms.Button btPeriodeTanam;
        private System.Windows.Forms.Button btLahan;
        private System.Windows.Forms.Button btDashboard;
        private System.Windows.Forms.Button btProfil;
        private System.Windows.Forms.Button btPanen;
        private System.Windows.Forms.Button btnPenjualan;
    }
}
