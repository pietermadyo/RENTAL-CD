namespace UGD_RENTAL_CD_7923
{
    partial class UC_MENU
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
            this.components = new System.ComponentModel.Container();
            this.txt_harga = new System.Windows.Forms.Label();
            this.txtHarga = new System.Windows.Forms.TextBox();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.txtJudul = new System.Windows.Forms.Label();
            this.txtStok = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtID_ktgr = new System.Windows.Forms.Label();
            this.txtjdl = new System.Windows.Forms.TextBox();
            this.txtStk = new System.Windows.Forms.TextBox();
            this.cmbKategori = new System.Windows.Forms.ComboBox();
            this.dtpTGL = new System.Windows.Forms.DateTimePicker();
            this.btnBatal = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtID = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_harga
            // 
            this.txt_harga.AutoSize = true;
            this.txt_harga.Location = new System.Drawing.Point(29, 133);
            this.txt_harga.Name = "txt_harga";
            this.txt_harga.Size = new System.Drawing.Size(36, 13);
            this.txt_harga.TabIndex = 1;
            this.txt_harga.Text = "Harga";
            this.txt_harga.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtHarga
            // 
            this.txtHarga.Location = new System.Drawing.Point(121, 126);
            this.txtHarga.Name = "txtHarga";
            this.txtHarga.Size = new System.Drawing.Size(130, 20);
            this.txtHarga.TabIndex = 5;
            this.txtHarga.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtHarga_KeyPress);
            // 
            // btnSimpan
            // 
            this.btnSimpan.Location = new System.Drawing.Point(121, 286);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(95, 23);
            this.btnSimpan.TabIndex = 11;
            this.btnSimpan.Text = "Simpan";
            this.btnSimpan.UseVisualStyleBackColor = true;
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
            // 
            // txtJudul
            // 
            this.txtJudul.AutoSize = true;
            this.txtJudul.Location = new System.Drawing.Point(29, 48);
            this.txtJudul.Name = "txtJudul";
            this.txtJudul.Size = new System.Drawing.Size(32, 13);
            this.txtJudul.TabIndex = 13;
            this.txtJudul.Text = "Judul";
            // 
            // txtStok
            // 
            this.txtStok.AutoSize = true;
            this.txtStok.Location = new System.Drawing.Point(29, 91);
            this.txtStok.Name = "txtStok";
            this.txtStok.Size = new System.Drawing.Size(29, 13);
            this.txtStok.TabIndex = 14;
            this.txtStok.Text = "Stok";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 220);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Tanggal Rilis";
            // 
            // txtID_ktgr
            // 
            this.txtID_ktgr.AutoSize = true;
            this.txtID_ktgr.Location = new System.Drawing.Point(29, 179);
            this.txtID_ktgr.Name = "txtID_ktgr";
            this.txtID_ktgr.Size = new System.Drawing.Size(49, 13);
            this.txtID_ktgr.TabIndex = 17;
            this.txtID_ktgr.Text = " Kategori";
            // 
            // txtjdl
            // 
            this.txtjdl.Location = new System.Drawing.Point(121, 41);
            this.txtjdl.Name = "txtjdl";
            this.txtjdl.Size = new System.Drawing.Size(271, 20);
            this.txtjdl.TabIndex = 18;
            // 
            // txtStk
            // 
            this.txtStk.Location = new System.Drawing.Point(121, 88);
            this.txtStk.Name = "txtStk";
            this.txtStk.Size = new System.Drawing.Size(100, 20);
            this.txtStk.TabIndex = 20;
            this.txtStk.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Stok_KeyPress);
            // 
            // cmbKategori
            // 
            this.cmbKategori.FormattingEnabled = true;
            this.cmbKategori.Location = new System.Drawing.Point(121, 171);
            this.cmbKategori.Name = "cmbKategori";
            this.cmbKategori.Size = new System.Drawing.Size(177, 21);
            this.cmbKategori.TabIndex = 22;
            // 
            // dtpTGL
            // 
            this.dtpTGL.Location = new System.Drawing.Point(121, 214);
            this.dtpTGL.Name = "dtpTGL";
            this.dtpTGL.Size = new System.Drawing.Size(217, 20);
            this.dtpTGL.TabIndex = 23;
            // 
            // btnBatal
            // 
            this.btnBatal.Location = new System.Drawing.Point(238, 286);
            this.btnBatal.Name = "btnBatal";
            this.btnBatal.Size = new System.Drawing.Size(96, 23);
            this.btnBatal.TabIndex = 24;
            this.btnBatal.Text = "Batal";
            this.btnBatal.UseVisualStyleBackColor = true;
            this.btnBatal.Click += new System.EventHandler(this.btnBatal_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(412, 15);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(27, 20);
            this.txtID.TabIndex = 25;
            this.txtID.Visible = false;
            // 
            // UC_MENU
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.btnBatal);
            this.Controls.Add(this.dtpTGL);
            this.Controls.Add(this.cmbKategori);
            this.Controls.Add(this.txtStk);
            this.Controls.Add(this.txtjdl);
            this.Controls.Add(this.txtID_ktgr);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtStok);
            this.Controls.Add(this.txtJudul);
            this.Controls.Add(this.btnSimpan);
            this.Controls.Add(this.txtHarga);
            this.Controls.Add(this.txt_harga);
            this.Name = "UC_MENU";
            this.Size = new System.Drawing.Size(465, 352);
            this.Load += new System.EventHandler(this.UC_MENU_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txt_harga;
        private System.Windows.Forms.TextBox txtHarga;
        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.Label txtJudul;
        private System.Windows.Forms.Label txtStok;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label txtID_ktgr;
        private System.Windows.Forms.TextBox txtjdl;
        private System.Windows.Forms.TextBox txtStk;
        private System.Windows.Forms.ComboBox cmbKategori;
        private System.Windows.Forms.DateTimePicker dtpTGL;
        private System.Windows.Forms.Button btnBatal;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TextBox txtID;
    }
}
