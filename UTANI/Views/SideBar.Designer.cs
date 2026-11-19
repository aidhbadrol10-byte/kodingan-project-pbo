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
            this.btMengelolaAkun = new System.Windows.Forms.Button();
            this.btPanenPenjualan = new System.Windows.Forms.Button();
            this.btBiaya = new System.Windows.Forms.Button();
            this.btPeriodeTanam = new System.Windows.Forms.Button();
            this.btLahan = new System.Windows.Forms.Button();
            this.btDashboard = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btLogout
            // 
            this.btLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(81)))));
            this.btLogout.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btLogout.Font = new System.Drawing.Font("Tahoma", 41.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLogout.ForeColor = System.Drawing.Color.White;
            this.btLogout.Location = new System.Drawing.Point(45, 629);
            this.btLogout.Name = "btLogout";
            this.btLogout.Size = new System.Drawing.Size(370, 108);
            this.btLogout.TabIndex = 11;
            this.btLogout.Text = "Keluar";
            this.btLogout.UseVisualStyleBackColor = false;
            this.btLogout.Click += new System.EventHandler(this.btLogout_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.btMengelolaAkun);
            this.panel1.Controls.Add(this.btPanenPenjualan);
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
            // btMengelolaAkun
            // 
            this.btMengelolaAkun.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(244)))), ((int)(((byte)(198)))));
            this.btMengelolaAkun.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btMengelolaAkun.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btMengelolaAkun.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(81)))));
            this.btMengelolaAkun.Location = new System.Drawing.Point(61, 408);
            this.btMengelolaAkun.Name = "btMengelolaAkun";
            this.btMengelolaAkun.Size = new System.Drawing.Size(238, 49);
            this.btMengelolaAkun.TabIndex = 17;
            this.btMengelolaAkun.Text = "Mengelola Akun";
            this.btMengelolaAkun.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btMengelolaAkun.UseVisualStyleBackColor = false;
            this.btMengelolaAkun.Click += new System.EventHandler(this.btMengelolaAkun_Click);
            // 
            // btPanenPenjualan
            // 
            this.btPanenPenjualan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(244)))), ((int)(((byte)(198)))));
            this.btPanenPenjualan.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btPanenPenjualan.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btPanenPenjualan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(81)))));
            this.btPanenPenjualan.Location = new System.Drawing.Point(61, 332);
            this.btPanenPenjualan.Name = "btPanenPenjualan";
            this.btPanenPenjualan.Size = new System.Drawing.Size(311, 49);
            this.btPanenPenjualan.TabIndex = 16;
            this.btPanenPenjualan.Text = "Panen dan Penjualan";
            this.btPanenPenjualan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btPanenPenjualan.UseVisualStyleBackColor = false;
            this.btPanenPenjualan.Click += new System.EventHandler(this.btPanenPenjualan_Click);
            // 
            // btBiaya
            // 
            this.btBiaya.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(244)))), ((int)(((byte)(198)))));
            this.btBiaya.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btBiaya.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btBiaya.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(81)))));
            this.btBiaya.Location = new System.Drawing.Point(61, 251);
            this.btBiaya.Name = "btBiaya";
            this.btBiaya.Size = new System.Drawing.Size(104, 49);
            this.btBiaya.TabIndex = 15;
            this.btBiaya.Text = "Biaya";
            this.btBiaya.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btBiaya.UseVisualStyleBackColor = false;
            this.btBiaya.Click += new System.EventHandler(this.btBiaya_Click);
            // 
            // btPeriodeTanam
            // 
            this.btPeriodeTanam.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(244)))), ((int)(((byte)(198)))));
            this.btPeriodeTanam.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btPeriodeTanam.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btPeriodeTanam.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(81)))));
            this.btPeriodeTanam.Location = new System.Drawing.Point(61, 178);
            this.btPeriodeTanam.Name = "btPeriodeTanam";
            this.btPeriodeTanam.Size = new System.Drawing.Size(231, 49);
            this.btPeriodeTanam.TabIndex = 14;
            this.btPeriodeTanam.Text = "Periode Tanam";
            this.btPeriodeTanam.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btPeriodeTanam.UseVisualStyleBackColor = false;
            this.btPeriodeTanam.Click += new System.EventHandler(this.btPeriodeTanam_Click);
            // 
            // btLahan
            // 
            this.btLahan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(244)))), ((int)(((byte)(198)))));
            this.btLahan.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btLahan.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLahan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(81)))));
            this.btLahan.Location = new System.Drawing.Point(61, 100);
            this.btLahan.Name = "btLahan";
            this.btLahan.Size = new System.Drawing.Size(104, 49);
            this.btLahan.TabIndex = 13;
            this.btLahan.Text = "Lahan";
            this.btLahan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btLahan.UseVisualStyleBackColor = false;
            this.btLahan.Click += new System.EventHandler(this.btLahan_Click);
            // 
            // btDashboard
            // 
            this.btDashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(244)))), ((int)(((byte)(198)))));
            this.btDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btDashboard.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDashboard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(81)))));
            this.btDashboard.Location = new System.Drawing.Point(61, 19);
            this.btDashboard.Name = "btDashboard";
            this.btDashboard.Size = new System.Drawing.Size(169, 49);
            this.btDashboard.TabIndex = 12;
            this.btDashboard.Text = "Dashboard";
            this.btDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btDashboard.UseVisualStyleBackColor = false;
            this.btDashboard.Click += new System.EventHandler(this.btDashboard_Click);
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
        private System.Windows.Forms.Button btPanenPenjualan;
        private System.Windows.Forms.Button btBiaya;
        private System.Windows.Forms.Button btPeriodeTanam;
        private System.Windows.Forms.Button btLahan;
        private System.Windows.Forms.Button btDashboard;
    }
}
