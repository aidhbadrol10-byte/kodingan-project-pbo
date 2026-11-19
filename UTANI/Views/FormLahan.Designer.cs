namespace UTANI.Views
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
            System.Windows.Forms.TextBox lokasi;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLahan));
            this.sideBar1 = new UTANI.Views.SideBar();
            this.tbNamaLahan = new System.Windows.Forms.TextBox();
            this.tbLuas = new System.Windows.Forms.TextBox();
            this.tbKeterangan = new System.Windows.Forms.TextBox();
            this.btSimpanLahan = new System.Windows.Forms.Button();
            lokasi = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // sideBar1
            // 
            this.sideBar1.BackColor = System.Drawing.Color.Transparent;
            this.sideBar1.Location = new System.Drawing.Point(1, 284);
            this.sideBar1.Name = "sideBar1";
            this.sideBar1.Size = new System.Drawing.Size(457, 756);
            this.sideBar1.TabIndex = 0;
            // 
            // tbNamaLahan
            // 
            this.tbNamaLahan.BackColor = System.Drawing.Color.Gainsboro;
            this.tbNamaLahan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbNamaLahan.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNamaLahan.Location = new System.Drawing.Point(1361, 390);
            this.tbNamaLahan.Name = "tbNamaLahan";
            this.tbNamaLahan.Size = new System.Drawing.Size(424, 33);
            this.tbNamaLahan.TabIndex = 1;
            this.tbNamaLahan.TextChanged += new System.EventHandler(this.tbNamaLahan_TextChanged);
            // 
            // tbLuas
            // 
            this.tbLuas.BackColor = System.Drawing.Color.Gainsboro;
            this.tbLuas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbLuas.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbLuas.Location = new System.Drawing.Point(1361, 529);
            this.tbLuas.Name = "tbLuas";
            this.tbLuas.Size = new System.Drawing.Size(424, 33);
            this.tbLuas.TabIndex = 2;
            // 
            // lokasi
            // 
            lokasi.BackColor = System.Drawing.Color.Gainsboro;
            lokasi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            lokasi.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lokasi.Location = new System.Drawing.Point(1361, 666);
            lokasi.Name = "lokasi";
            lokasi.Size = new System.Drawing.Size(424, 33);
            lokasi.TabIndex = 3;
            lokasi.TextChanged += new System.EventHandler(this.lokasi_TextChanged);
            // 
            // tbKeterangan
            // 
            this.tbKeterangan.BackColor = System.Drawing.Color.Gainsboro;
            this.tbKeterangan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbKeterangan.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbKeterangan.Location = new System.Drawing.Point(1361, 802);
            this.tbKeterangan.Name = "tbKeterangan";
            this.tbKeterangan.Size = new System.Drawing.Size(424, 33);
            this.tbKeterangan.TabIndex = 4;
            this.tbKeterangan.TextChanged += new System.EventHandler(this.tbKeterangan_TextChanged);
            // 
            // btSimpanLahan
            // 
            this.btSimpanLahan.BackColor = System.Drawing.Color.ForestGreen;
            this.btSimpanLahan.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSimpanLahan.ForeColor = System.Drawing.Color.White;
            this.btSimpanLahan.Location = new System.Drawing.Point(1618, 920);
            this.btSimpanLahan.Name = "btSimpanLahan";
            this.btSimpanLahan.Size = new System.Drawing.Size(198, 68);
            this.btSimpanLahan.TabIndex = 5;
            this.btSimpanLahan.Text = "Simpan";
            this.btSimpanLahan.UseVisualStyleBackColor = false;
            this.btSimpanLahan.Click += new System.EventHandler(this.btSimpanLahan_Click);
            // 
            // FormLahan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.btSimpanLahan);
            this.Controls.Add(this.tbKeterangan);
            this.Controls.Add(lokasi);
            this.Controls.Add(this.tbLuas);
            this.Controls.Add(this.tbNamaLahan);
            this.Controls.Add(this.sideBar1);
            this.Name = "FormLahan";
            this.Text = "FormLahan";
            this.Load += new System.EventHandler(this.FormLahan_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SideBar sideBar1;
        private System.Windows.Forms.TextBox tbNamaLahan;
        private System.Windows.Forms.TextBox tbLuas;
        private System.Windows.Forms.TextBox tbKeterangan;
        private System.Windows.Forms.Button btSimpanLahan;
    }
}