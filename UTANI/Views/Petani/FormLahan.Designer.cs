namespace UTANI.Views.Petani
{
    partial class FormLahan
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLahan));
            this.tbNamaLahan = new System.Windows.Forms.TextBox();
            this.tbLuas = new System.Windows.Forms.TextBox();
            this.tbLokasi = new System.Windows.Forms.TextBox();
            this.tbKeterangan = new System.Windows.Forms.TextBox();
            this.btUbah = new System.Windows.Forms.Button();
            this.btHapus = new System.Windows.Forms.Button();
            this.btTambahkanLahan = new System.Windows.Forms.Button();
            this.dgvLahan = new System.Windows.Forms.DataGridView();
            this.sideBar1 = new UTANI.Views.SideBar();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLahan)).BeginInit();
            this.SuspendLayout();
            // 
            // tbNamaLahan
            // 
            this.tbNamaLahan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.tbNamaLahan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbNamaLahan.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F);
            this.tbNamaLahan.Location = new System.Drawing.Point(1362, 390);
            this.tbNamaLahan.Name = "tbNamaLahan";
            this.tbNamaLahan.Size = new System.Drawing.Size(424, 34);
            this.tbNamaLahan.TabIndex = 1;
            this.tbNamaLahan.TextChanged += new System.EventHandler(this.tbNamaLahan_TextChanged);
            // 
            // tbLuas
            // 
            this.tbLuas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.tbLuas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbLuas.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F);
            this.tbLuas.Location = new System.Drawing.Point(1361, 524);
            this.tbLuas.Name = "tbLuas";
            this.tbLuas.Size = new System.Drawing.Size(424, 34);
            this.tbLuas.TabIndex = 2;
            this.tbLuas.TextChanged += new System.EventHandler(this.tbLuas_TextChanged);
            // 
            // tbLokasi
            // 
            this.tbLokasi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.tbLokasi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbLokasi.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F);
            this.tbLokasi.Location = new System.Drawing.Point(1361, 666);
            this.tbLokasi.Name = "tbLokasi";
            this.tbLokasi.Size = new System.Drawing.Size(424, 34);
            this.tbLokasi.TabIndex = 3;
            this.tbLokasi.TextChanged += new System.EventHandler(this.tbLokasi_TextChanged);
            // 
            // tbKeterangan
            // 
            this.tbKeterangan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.tbKeterangan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbKeterangan.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F);
            this.tbKeterangan.Location = new System.Drawing.Point(1361, 805);
            this.tbKeterangan.Name = "tbKeterangan";
            this.tbKeterangan.Size = new System.Drawing.Size(424, 34);
            this.tbKeterangan.TabIndex = 4;
            this.tbKeterangan.TextChanged += new System.EventHandler(this.tbKeterangan_TextChanged);
            // 
            // btUbah
            // 
            this.btUbah.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.btUbah.FlatAppearance.BorderSize = 0;
            this.btUbah.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btUbah.Font = new System.Drawing.Font("Tahoma", 22F, System.Drawing.FontStyle.Bold);
            this.btUbah.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btUbah.Location = new System.Drawing.Point(612, 930);
            this.btUbah.Name = "btUbah";
            this.btUbah.Size = new System.Drawing.Size(144, 53);
            this.btUbah.TabIndex = 5;
            this.btUbah.Text = "Ubah";
            this.btUbah.UseVisualStyleBackColor = false;
            this.btUbah.Click += new System.EventHandler(this.btUbah_Click);
            // 
            // btHapus
            // 
            this.btHapus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(34)))), ((int)(((byte)(31)))));
            this.btHapus.FlatAppearance.BorderSize = 0;
            this.btHapus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btHapus.Font = new System.Drawing.Font("Tahoma", 22F, System.Drawing.FontStyle.Bold);
            this.btHapus.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btHapus.Location = new System.Drawing.Point(1052, 929);
            this.btHapus.Name = "btHapus";
            this.btHapus.Size = new System.Drawing.Size(120, 53);
            this.btHapus.TabIndex = 6;
            this.btHapus.Text = "Hapus";
            this.btHapus.UseVisualStyleBackColor = false;
            this.btHapus.Click += new System.EventHandler(this.btHapus_Click);
            // 
            // btTambahkanLahan
            // 
            this.btTambahkanLahan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.btTambahkanLahan.FlatAppearance.BorderSize = 0;
            this.btTambahkanLahan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btTambahkanLahan.Font = new System.Drawing.Font("Tahoma", 19F, System.Drawing.FontStyle.Bold);
            this.btTambahkanLahan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(146)))), ((int)(((byte)(68)))));
            this.btTambahkanLahan.Location = new System.Drawing.Point(1576, 132);
            this.btTambahkanLahan.Name = "btTambahkanLahan";
            this.btTambahkanLahan.Size = new System.Drawing.Size(267, 55);
            this.btTambahkanLahan.TabIndex = 7;
            this.btTambahkanLahan.Text = "Tambahkan Lahan";
            this.btTambahkanLahan.UseVisualStyleBackColor = false;
            this.btTambahkanLahan.Click += new System.EventHandler(this.btTambahkanLahan_Click);
            // 
            // dgvLahan
            // 
            this.dgvLahan.AllowUserToOrderColumns = true;
            this.dgvLahan.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.dgvLahan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvLahan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLahan.Location = new System.Drawing.Point(567, 263);
            this.dgvLahan.Name = "dgvLahan";
            this.dgvLahan.Size = new System.Drawing.Size(652, 437);
            this.dgvLahan.TabIndex = 8;
            this.dgvLahan.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLahan_CellContentClick);
            // 
            // sideBar1
            // 
            this.sideBar1.BackColor = System.Drawing.Color.Transparent;
            this.sideBar1.Location = new System.Drawing.Point(0, 286);
            this.sideBar1.Name = "sideBar1";
            this.sideBar1.Size = new System.Drawing.Size(457, 756);
            this.sideBar1.TabIndex = 0;
            this.sideBar1.Load += new System.EventHandler(this.sideBar1_Load);
            // 
            // FormLahan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.dgvLahan);
            this.Controls.Add(this.btTambahkanLahan);
            this.Controls.Add(this.btHapus);
            this.Controls.Add(this.btUbah);
            this.Controls.Add(this.tbKeterangan);
            this.Controls.Add(this.tbLokasi);
            this.Controls.Add(this.tbLuas);
            this.Controls.Add(this.tbNamaLahan);
            this.Controls.Add(this.sideBar1);
            this.Name = "FormLahan";
            this.Text = "FormLahan";
            this.Load += new System.EventHandler(this.FormLahan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLahan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SideBar sideBar1;
        private System.Windows.Forms.TextBox tbNamaLahan;
        private System.Windows.Forms.TextBox tbLuas;
        private System.Windows.Forms.TextBox tbLokasi;
        private System.Windows.Forms.TextBox tbKeterangan;
        private System.Windows.Forms.Button btUbah;
        private System.Windows.Forms.Button btHapus;
        private System.Windows.Forms.Button btTambahkanLahan;
        private System.Windows.Forms.DataGridView dgvLahan;
    }
}