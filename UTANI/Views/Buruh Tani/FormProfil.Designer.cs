namespace UTANI.Views.Buruh_Tani
{
    partial class FormProfil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormProfil));
            this.sideBar1 = new UTANI.Views.SideBar();
            this.LbNama = new System.Windows.Forms.Label();
            this.LbUsername = new System.Windows.Forms.Label();
            this.LbNotelp = new System.Windows.Forms.Label();
            this.LbEmail = new System.Windows.Forms.Label();
            this.LbRole = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // sideBar1
            // 
            this.sideBar1.BackColor = System.Drawing.Color.Transparent;
            this.sideBar1.Location = new System.Drawing.Point(0, 297);
            this.sideBar1.Name = "sideBar1";
            this.sideBar1.Size = new System.Drawing.Size(457, 756);
            this.sideBar1.TabIndex = 0;
            this.sideBar1.Load += new System.EventHandler(this.sideBar1_Load);
            // 
            // LbNama
            // 
            this.LbNama.BackColor = System.Drawing.Color.Transparent;
            this.LbNama.Font = new System.Drawing.Font("Tahoma", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbNama.ForeColor = System.Drawing.Color.White;
            this.LbNama.Location = new System.Drawing.Point(835, 103);
            this.LbNama.Name = "LbNama";
            this.LbNama.Size = new System.Drawing.Size(488, 42);
            this.LbNama.TabIndex = 1;
            this.LbNama.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LbNama.Click += new System.EventHandler(this.LbNama_Click);
            // 
            // LbUsername
            // 
            this.LbUsername.BackColor = System.Drawing.Color.Transparent;
            this.LbUsername.Font = new System.Drawing.Font("Tahoma", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbUsername.Location = new System.Drawing.Point(891, 417);
            this.LbUsername.Name = "LbUsername";
            this.LbUsername.Size = new System.Drawing.Size(590, 56);
            this.LbUsername.TabIndex = 2;
            this.LbUsername.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LbUsername.Click += new System.EventHandler(this.LbUsername_Click);
            // 
            // LbNotelp
            // 
            this.LbNotelp.BackColor = System.Drawing.Color.Transparent;
            this.LbNotelp.Font = new System.Drawing.Font("Tahoma", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbNotelp.Location = new System.Drawing.Point(898, 559);
            this.LbNotelp.Name = "LbNotelp";
            this.LbNotelp.Size = new System.Drawing.Size(583, 51);
            this.LbNotelp.TabIndex = 3;
            this.LbNotelp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LbNotelp.Click += new System.EventHandler(this.LbNotelp_Click);
            // 
            // LbEmail
            // 
            this.LbEmail.BackColor = System.Drawing.Color.Transparent;
            this.LbEmail.Font = new System.Drawing.Font("Tahoma", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbEmail.Location = new System.Drawing.Point(898, 698);
            this.LbEmail.Name = "LbEmail";
            this.LbEmail.Size = new System.Drawing.Size(583, 52);
            this.LbEmail.TabIndex = 4;
            this.LbEmail.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LbEmail.Click += new System.EventHandler(this.LbEmail_Click);
            // 
            // LbRole
            // 
            this.LbRole.BackColor = System.Drawing.Color.Transparent;
            this.LbRole.Font = new System.Drawing.Font("Tahoma", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbRole.Location = new System.Drawing.Point(898, 835);
            this.LbRole.Name = "LbRole";
            this.LbRole.Size = new System.Drawing.Size(583, 53);
            this.LbRole.TabIndex = 5;
            this.LbRole.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LbRole.Click += new System.EventHandler(this.LbRole_Click);
            // 
            // FormProfil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.LbRole);
            this.Controls.Add(this.LbEmail);
            this.Controls.Add(this.LbNotelp);
            this.Controls.Add(this.LbUsername);
            this.Controls.Add(this.LbNama);
            this.Controls.Add(this.sideBar1);
            this.Name = "FormProfil";
            this.Text = "s";
            this.Load += new System.EventHandler(this.FormProfil_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private SideBar sideBar1;
        private System.Windows.Forms.Label LbNama;
        private System.Windows.Forms.Label LbUsername;
        private System.Windows.Forms.Label LbNotelp;
        private System.Windows.Forms.Label LbEmail;
        private System.Windows.Forms.Label LbRole;
    }
}