using System;
using System.Windows.Forms;
using UTANI.Views;

namespace UTANI.Views.Petani

{
    partial class FormBiaya
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBiaya));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tbLahan = new System.Windows.Forms.TextBox();
            this.tbTanggal = new System.Windows.Forms.TextBox();
            this.tbKeterangan = new System.Windows.Forms.TextBox();
            this.tbJumlah = new System.Windows.Forms.TextBox();
            this.tbBiaya = new System.Windows.Forms.TextBox();
            this.btBiaya = new System.Windows.Forms.Button();
            this.sideBar1 = new UTANI.Views.SideBar();
            this.cbPeriode = new System.Windows.Forms.ComboBox();
            this.dgvBiaya = new System.Windows.Forms.DataGridView();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBiaya)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(0, 0);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            // 
            // tbLahan
            // 
            this.tbLahan.BackColor = System.Drawing.Color.Gainsboro;
            this.tbLahan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbLahan.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbLahan.Location = new System.Drawing.Point(1376, 380);
            this.tbLahan.Name = "tbLahan";
            this.tbLahan.Size = new System.Drawing.Size(440, 33);
            this.tbLahan.TabIndex = 2;
            this.tbLahan.TextChanged += new System.EventHandler(this.tbLahan_TextChanged);
            // 
            // tbTanggal
            // 
            this.tbTanggal.BackColor = System.Drawing.Color.Gainsboro;
            this.tbTanggal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbTanggal.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTanggal.Location = new System.Drawing.Point(1376, 629);
            this.tbTanggal.Name = "tbTanggal";
            this.tbTanggal.Size = new System.Drawing.Size(180, 33);
            this.tbTanggal.TabIndex = 4;
            this.tbTanggal.TextChanged += new System.EventHandler(this.tbTanggal_TextChanged);
            // 
            // tbKeterangan
            // 
            this.tbKeterangan.BackColor = System.Drawing.Color.Gainsboro;
            this.tbKeterangan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbKeterangan.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbKeterangan.Location = new System.Drawing.Point(1636, 629);
            this.tbKeterangan.Name = "tbKeterangan";
            this.tbKeterangan.Size = new System.Drawing.Size(180, 33);
            this.tbKeterangan.TabIndex = 5;
            this.tbKeterangan.TextChanged += new System.EventHandler(this.tbKeterangan_TextChanged);
            // 
            // tbJumlah
            // 
            this.tbJumlah.BackColor = System.Drawing.Color.Gainsboro;
            this.tbJumlah.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbJumlah.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbJumlah.Location = new System.Drawing.Point(1376, 753);
            this.tbJumlah.Name = "tbJumlah";
            this.tbJumlah.Size = new System.Drawing.Size(180, 33);
            this.tbJumlah.TabIndex = 6;
            this.tbJumlah.TextChanged += new System.EventHandler(this.tbJumlah_TextChanged);
            // 
            // tbBiaya
            // 
            this.tbBiaya.BackColor = System.Drawing.Color.Gainsboro;
            this.tbBiaya.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbBiaya.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbBiaya.Location = new System.Drawing.Point(1636, 753);
            this.tbBiaya.Name = "tbBiaya";
            this.tbBiaya.Size = new System.Drawing.Size(180, 33);
            this.tbBiaya.TabIndex = 7;
            this.tbBiaya.TextChanged += new System.EventHandler(this.tbBiaya_TextChanged);
            // 
            // btBiaya
            // 
            this.btBiaya.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(81)))));
            this.btBiaya.FlatAppearance.BorderSize = 0;
            this.btBiaya.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btBiaya.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btBiaya.ForeColor = System.Drawing.Color.White;
            this.btBiaya.Location = new System.Drawing.Point(1648, 932);
            this.btBiaya.Name = "btBiaya";
            this.btBiaya.Size = new System.Drawing.Size(168, 48);
            this.btBiaya.TabIndex = 8;
            this.btBiaya.Text = "Simpan";
            this.btBiaya.UseVisualStyleBackColor = false;
            this.btBiaya.Click += new System.EventHandler(this.btBiaya_Click);
            // 
            // sideBar1
            // 
            this.sideBar1.BackColor = System.Drawing.Color.Transparent;
            this.sideBar1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.sideBar1.Location = new System.Drawing.Point(0, 287);
            this.sideBar1.Name = "sideBar1";
            this.sideBar1.Size = new System.Drawing.Size(457, 756);
            this.sideBar1.TabIndex = 0;
            this.sideBar1.Load += new System.EventHandler(this.sideBar1_Load);
            // 
            // cbPeriode
            // 
            this.cbPeriode.BackColor = System.Drawing.Color.Gainsboro;
            this.cbPeriode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbPeriode.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPeriode.FormattingEnabled = true;
            this.cbPeriode.Location = new System.Drawing.Point(1390, 123);
            this.cbPeriode.Name = "cbPeriode";
            this.cbPeriode.Size = new System.Drawing.Size(416, 47);
            this.cbPeriode.TabIndex = 9;
            this.cbPeriode.SelectedIndexChanged += new System.EventHandler(this.cbPeriode_SelectedIndexChanged);
            // 
            // dgvBiaya
            // 
            this.dgvBiaya.AllowUserToOrderColumns = true;
            this.dgvBiaya.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.dgvBiaya.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvBiaya.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBiaya.Location = new System.Drawing.Point(580, 287);
            this.dgvBiaya.Name = "dgvBiaya";
            this.dgvBiaya.Size = new System.Drawing.Size(652, 437);
            this.dgvBiaya.TabIndex = 10;
            this.dgvBiaya.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBiaya_CellContentClick);
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.Gainsboro;
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox1.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(1376, 498);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(440, 47);
            this.comboBox1.TabIndex = 11;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // FormBiaya
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dgvBiaya);
            this.Controls.Add(this.cbPeriode);
            this.Controls.Add(this.btBiaya);
            this.Controls.Add(this.tbBiaya);
            this.Controls.Add(this.tbJumlah);
            this.Controls.Add(this.tbKeterangan);
            this.Controls.Add(this.tbTanggal);
            this.Controls.Add(this.tbLahan);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.sideBar1);
            this.Name = "FormBiaya";
            this.Text = "FormBiaya";
            this.Load += new System.EventHandler(this.FormBiaya_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBiaya)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SideBar sideBar1;
        private TextBox textBox1;
        private TextBox tbLahan;
        private TextBox tbTanggal;
        private TextBox tbKeterangan;
        private TextBox tbJumlah;
        private TextBox tbBiaya;
        private Button btBiaya;
        private ComboBox cbPeriode;
        private DataGridView dgvBiaya;
        private ComboBox comboBox1;
    }
}