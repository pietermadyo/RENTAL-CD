using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//memanggil control pada menu control
using System.Windows.Forms;
using UGD_RENTAL_CD_7923.Control_7923;

namespace UGD_RENTAL_CD_7923
{
    public partial class UC_MENU : UserControl
    {
        public UC_MENU()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_kategori_Click(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txt_deskripsi_Click(object sender, EventArgs e)
        {

        }
        //prosedur perintah untuk input dan edit
        int flagperintah = 0;

        public void setFlag(int flag)
        {
            flagperintah = flag;
        }
        //===================================
        //mengambil nilai untuk comboBox dengan event load
        MenuControl MC = new MenuControl();
        private void UC_MENU_Load(object sender, EventArgs e)
        {
            cmbKategori.DataSource = MC.getKategori();
            cmbKategori.DisplayMember = "nama_kategori";
        }
        //===========================================
        //pengecekan dengan errorprovider jika teks tidak diisi 
        public bool cektxt()
        {
            bool temp = true;

            if (txtjdl.Text == "")
            {
                errorProvider1.SetError(txtjdl,"Silahkan isi Judul");
                txtjdl.Focus();
                temp = false;
            }

            if (txtStk.Text == "")
            {
                errorProvider1.SetError(txtStk, "Silahkan isi Stok");
                txtStk.Focus();
                temp = false;
            }

            if (txtHarga.Text == "")
            {
                errorProvider1.SetError(txtHarga, "Silahkan isi Harga");
                txtHarga.Focus();
                temp = false;
            }

            if (cmbKategori.Text == "")
            {
                errorProvider1.SetError(cmbKategori, "Silahkan isi Kategori");
                cmbKategori.Focus();
                temp = false;
            }

            if (dtpTGL.Text == "")
            {
                errorProvider1.SetError(dtpTGL, "Silahkan isi Tanggal");
                dtpTGL.Focus();
                temp = false;
            } return temp;

        }

        //agar inputan hanya angka
        private void txtHarga_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(char.IsDigit(e.KeyChar) || (int)e.KeyChar==8 )
            {
                e.Handled = false;
            }else
            {
                e.Handled = true;
            }
        }

        private void Stok_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || (int)e.KeyChar == 8)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
        //============================
        //prosedur untuk menghapus nilai pada textbox dan comboBox
        private void cleartxt()
        {
            txtjdl.Clear();
            txtStk.Clear();
            txtHarga.Clear();
            cmbKategori.SelectedIndex = -1;
        }

       
        //membatalkan inputan dengan prosedur 
        private void btnBatal_Click(object sender, EventArgs e)
        {
            cleartxt();
            errorProvider1.Clear();
            this.Hide();
            form1 myParent = (form1)this.Parent;
            myParent.enable();
        }

        //event klik untuk menambahkan data dengan perintah flag dan memasukan ke entity
        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (flagperintah == 1)
            {
                if (cektxt() == true)
                {
                    errorProvider1.Clear();
                    int IDKategori = MC.GetIdKategori(cmbKategori.Text);
                    UGD_RENTAL_CD_7923.Entity.Menu M = new Entity.Menu(Convert.ToInt32(txtStk.Text), IDKategori, txtjdl.Text, dtpTGL.Value.ToLongDateString(), Convert.ToDouble(txtHarga.Text));
                    MC.addMenu(M);
                    cleartxt();
                    this.Hide();
                    form1 myParent = (form1)this.Parent;
                    myParent.enable();
                }
                
            }
            else
            {
                if (cektxt() == true)
                {
                    errorProvider1.Clear();
                    int IDKategori = MC.GetIdKategori(cmbKategori.Text);
                    UGD_RENTAL_CD_7923.Entity.Menu M = new Entity.Menu(Convert.ToInt32(txtStk.Text), IDKategori, txtjdl.Text, dtpTGL.Value.ToLongDateString(), Convert.ToDouble(txtHarga.Text));
                    DialogResult dr = MessageBox.Show("Apakah anda yakin ingin mengupdate data menu ? " + temp_menu, "Pertanyaan", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr == DialogResult.Yes)
                    {
                        MC.editMenu(M, int.Parse(txtID.Text));
                    }
                    cleartxt();
                    this.Hide();
                    form1 myParent = (form1)this.Parent;
                    myParent.enableEdit();
                }
            }

        }

        //temp_menu digunakan untuk menampung pengeditan data pada dialog dan prosedur isiteksbox harus untuk kondisi pengeditan di fungsi edit di form 1
        string temp_menu = "";
        public void isiTextBox(string judul,string stok, string harga,string kategori,string tanggal,string ID)
        {
            txtjdl.Text = judul;
            temp_menu = judul;
            txtStk.Text = stok;
            txtHarga.Text = harga;
            cmbKategori.Text = kategori;
            dtpTGL.Text = tanggal;
            txtID.Text = ID; 
        }
    }
}
