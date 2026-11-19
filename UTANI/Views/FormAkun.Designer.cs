namespace UTANI.Views
{
    partial class FormAkun
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAkun));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tbUsernameAkun = new System.Windows.Forms.TextBox();
            this.tbPasswordAkun = new System.Windows.Forms.TextBox();
            this.btSimpanAkun = new System.Windows.Forms.Button();
            this.tbEmailAkun = new System.Windows.Forms.TextBox();
            this.tbNomorAkun = new System.Windows.Forms.TextBox();
            this.btHapusAkun = new System.Windows.Forms.Button();
            this.btEditAkun = new System.Windows.Forms.Button();
            this.dgvAkun = new System.Windows.Forms.DataGridView();
            this.sideBar1 = new UTANI.Views.SideBar();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAkun)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // tbUsernameAkun
            // 
            this.tbUsernameAkun.BackColor = System.Drawing.Color.Gainsboro;
            this.tbUsernameAkun.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbUsernameAkun.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUsernameAkun.Location = new System.Drawing.Point(1377, 379);
            this.tbUsernameAkun.Name = "tbUsernameAkun";
            this.tbUsernameAkun.Size = new System.Drawing.Size(441, 37);
            this.tbUsernameAkun.TabIndex = 1;
            this.tbUsernameAkun.TextChanged += new System.EventHandler(this.tbUsernameAkun_TextChanged);
            // 
            // tbPasswordAkun
            // 
            this.tbPasswordAkun.BackColor = System.Drawing.Color.Gainsboro;
            this.tbPasswordAkun.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbPasswordAkun.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPasswordAkun.Location = new System.Drawing.Point(1377, 502);
            this.tbPasswordAkun.Name = "tbPasswordAkun";
            this.tbPasswordAkun.Size = new System.Drawing.Size(441, 37);
            this.tbPasswordAkun.TabIndex = 2;
            this.tbPasswordAkun.TextChanged += new System.EventHandler(this.tbPasswordAkun_TextChanged);
            // 
            // btSimpanAkun
            // 
            this.btSimpanAkun.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btSimpanAkun.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.btSimpanAkun.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btSimpanAkun.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSimpanAkun.ForeColor = System.Drawing.Color.White;
            this.btSimpanAkun.Location = new System.Drawing.Point(1635, 922);
            this.btSimpanAkun.Name = "btSimpanAkun";
            this.btSimpanAkun.Size = new System.Drawing.Size(193, 70);
            this.btSimpanAkun.TabIndex = 3;
            this.btSimpanAkun.Text = "Simpan";
            this.btSimpanAkun.UseVisualStyleBackColor = false;
            this.btSimpanAkun.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbEmailAkun
            // 
            this.tbEmailAkun.BackColor = System.Drawing.Color.Gainsboro;
            this.tbEmailAkun.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbEmailAkun.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEmailAkun.Location = new System.Drawing.Point(1377, 628);
            this.tbEmailAkun.Name = "tbEmailAkun";
            this.tbEmailAkun.Size = new System.Drawing.Size(441, 37);
            this.tbEmailAkun.TabIndex = 4;
            this.tbEmailAkun.TextChanged += new System.EventHandler(this.tbEmailAkun_TextChanged);
            // 
            // tbNomorAkun
            // 
            this.tbNomorAkun.BackColor = System.Drawing.Color.Gainsboro;
            this.tbNomorAkun.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbNomorAkun.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNomorAkun.Location = new System.Drawing.Point(1377, 749);
            this.tbNomorAkun.Name = "tbNomorAkun";
            this.tbNomorAkun.Size = new System.Drawing.Size(441, 37);
            this.tbNomorAkun.TabIndex = 5;
            this.tbNomorAkun.TextChanged += new System.EventHandler(this.tbNomorAkun_TextChanged);
            // 
            // btHapusAkun
            // 
            this.btHapusAkun.BackColor = System.Drawing.Color.Brown;
            this.btHapusAkun.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btHapusAkun.Font = new System.Drawing.Font("Tahoma", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btHapusAkun.ForeColor = System.Drawing.Color.White;
            this.btHapusAkun.Location = new System.Drawing.Point(1055, 920);
            this.btHapusAkun.Name = "btHapusAkun";
            this.btHapusAkun.Size = new System.Drawing.Size(200, 70);
            this.btHapusAkun.TabIndex = 9;
            this.btHapusAkun.Text = "Hapus";
            this.btHapusAkun.UseVisualStyleBackColor = false;
            this.btHapusAkun.Click += new System.EventHandler(this.btHapusAkun_Click);
            // 
            // btEditAkun
            // 
            this.btEditAkun.BackColor = System.Drawing.Color.DarkCyan;
            this.btEditAkun.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btEditAkun.Font = new System.Drawing.Font("Tahoma", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEditAkun.ForeColor = System.Drawing.Color.White;
            this.btEditAkun.Location = new System.Drawing.Point(825, 919);
            this.btEditAkun.Name = "btEditAkun";
            this.btEditAkun.Size = new System.Drawing.Size(200, 70);
            this.btEditAkun.TabIndex = 10;
            this.btEditAkun.Text = "Edit";
            this.btEditAkun.UseVisualStyleBackColor = false;
            this.btEditAkun.Click += new System.EventHandler(this.btEditAkun_Click);
            // 
            // dgvAkun
            // 
            this.dgvAkun.AllowUserToAddRows = false;
            this.dgvAkun.AllowUserToDeleteRows = false;
            this.dgvAkun.AllowUserToResizeColumns = false;
            this.dgvAkun.AllowUserToResizeRows = false;
            this.dgvAkun.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAkun.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAkun.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Coral;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAkun.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvAkun.Location = new System.Drawing.Point(556, 285);
            this.dgvAkun.Name = "dgvAkun";
            this.dgvAkun.ReadOnly = true;
            this.dgvAkun.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvAkun.ShowEditingIcon = false;
            this.dgvAkun.Size = new System.Drawing.Size(699, 553);
            this.dgvAkun.TabIndex = 15;
            this.dgvAkun.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // sideBar1
            // 
            this.sideBar1.BackColor = System.Drawing.Color.Transparent;
            this.sideBar1.Location = new System.Drawing.Point(-1, 285);
            this.sideBar1.Name = "sideBar1";
            this.sideBar1.Size = new System.Drawing.Size(457, 756);
            this.sideBar1.TabIndex = 14;
            // 
            // FormAkun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.dgvAkun);
            this.Controls.Add(this.sideBar1);
            this.Controls.Add(this.btEditAkun);
            this.Controls.Add(this.btHapusAkun);
            this.Controls.Add(this.tbNomorAkun);
            this.Controls.Add(this.tbEmailAkun);
            this.Controls.Add(this.btSimpanAkun);
            this.Controls.Add(this.tbPasswordAkun);
            this.Controls.Add(this.tbUsernameAkun);
            this.Name = "FormAkun";
            this.Text = "FormAkun";
            this.Load += new System.EventHandler(this.FormAkun_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAkun)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox tbUsernameAkun;
        private System.Windows.Forms.TextBox tbPasswordAkun;
        private System.Windows.Forms.Button btSimpanAkun;
        private System.Windows.Forms.TextBox tbEmailAkun;
        private System.Windows.Forms.TextBox tbNomorAkun;
        private System.Windows.Forms.Button btHapusAkun;
        private System.Windows.Forms.Button btEditAkun;
        private SideBar sideBar1;
        private System.Windows.Forms.DataGridView dgvAkun;
    }
}