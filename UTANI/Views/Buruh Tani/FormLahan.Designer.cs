namespace UTANI.Views.Buruh_Tani
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
            this.dgvLahan = new System.Windows.Forms.DataGridView();
            this.sideBar1 = new UTANI.Views.SideBar();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLahan)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvLahan
            // 
            this.dgvLahan.AllowUserToOrderColumns = true;
            this.dgvLahan.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.dgvLahan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvLahan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLahan.Location = new System.Drawing.Point(628, 297);
            this.dgvLahan.Name = "dgvLahan";
            this.dgvLahan.Size = new System.Drawing.Size(1117, 585);
            this.dgvLahan.TabIndex = 9;
            this.dgvLahan.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLahan_CellContentClick);
            // 
            // sideBar1
            // 
            this.sideBar1.BackColor = System.Drawing.Color.Transparent;
            this.sideBar1.Location = new System.Drawing.Point(0, 268);
            this.sideBar1.Name = "sideBar1";
            this.sideBar1.Size = new System.Drawing.Size(457, 756);
            this.sideBar1.TabIndex = 10;
            this.sideBar1.Load += new System.EventHandler(this.sideBar1_Load_1);
            // 
            // FormLahan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.sideBar1);
            this.Controls.Add(this.dgvLahan);
            this.Name = "FormLahan";
            this.Text = "FormLahan";
            this.Load += new System.EventHandler(this.FormLahan_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLahan)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvLahan;
        private SideBar sideBar1;
    }
}