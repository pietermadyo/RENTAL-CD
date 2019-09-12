using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UGD_RENTAL_CD_7923.Boundary_7923
{
    public partial class FormUtama : Form
    {
        public FormUtama()
        {
            InitializeComponent();
        }

        //Menampilkan form1 atau dataMaster Rental untuk event klik
        private void dataMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            form1 fr = new form1();
            fr.MdiParent = this;
            fr.Show();
        }

        //untuk menampilkan nama pada tool stripuser bagian bawah form utama
        public void setToolStripUser(string text)
        {
            this.toolStripUser.Text = text; 
        }
        //=============================================

        //prosedur menampilkan data master dan transakasi untuk role
        public void setVisibleMenuDataMaster(bool set)
        {
            this.dataMasterToolStripMenuItem.Visible = set;
        }

        public void setVisibleMenuTransaksi(bool set)
        {
            this.transaksiToolStripMenuItem.Visible = set;
        }
        //=======================================================
        //untuk log uot event klik pada menu di form utama
        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult fr = MessageBox.Show("Apakah anda yakin ingin LogOut ?" , "Pertanyaan", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (fr == DialogResult.Yes)
            {
                Application.Restart();
            }      
        }
        //untuk exit event klik pada menu di form utama
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult fr = MessageBox.Show("Apakah anda ingin exit ?", "Pertanyaan", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (fr == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        //untuk menampilkan laporan dengan event klik pada menu laporan CD
        private void laporanCDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LaporanCD fr = new LaporanCD();
            fr.MdiParent = this;
            fr.Show();
        }
        //untuk menampilkan laporan dengan event klik pada menu laporan CD Filter
        private void laporanCDFilterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LaporanCDFilter fr = new LaporanCDFilter();
            fr.MdiParent = this;
            fr.Show();
        }
    }
}
