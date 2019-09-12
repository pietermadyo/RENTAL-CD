using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//memanggil fungsi dari control
using System.Windows.Forms;
using UGD_RENTAL_CD_7923.Control_7923;
namespace UGD_RENTAL_CD_7923
{
    public partial class form1 : Form
    {
        public form1()
        {
            InitializeComponent();
        }

        MenuControl MC = new MenuControl();

        //untuk menampilkan data ke datagrid dan membuat paging untuk halaman pada datagrid
        public void setDatagridview(DataGridView DG)
        {
            DG.DataSource = MC.showMenu();

            DataTable DT = MC.showMenu();
            //==================================
            BindingList<DataTable> listTbl = new BindingList<DataTable>();

            if(DT.Rows.Count>0)
            {
                int counter = 0, subTblIndex = -1;
                foreach (DataRow dr in DT.Rows)
                {
                    if (counter == 0)
                    {
                        listTbl.Add(DT.Clone());
                        subTblIndex++;
                    }
                    listTbl[subTblIndex].Rows.Add(dr.ItemArray);
                    counter++;
                    //pengaturan banyak baris pada datagrid
                    if (counter == 10) counter = 0;
                }
            }
            bindingSource1.DataSource = listTbl;
            bindingNavigator1.BindingSource = bindingSource1;
            DG.DataSource = (DT.Rows.Count > 0 ? listTbl[bindingSource1.Position] : DT);

            DG.Columns[0].HeaderText = "ID CD";
            DG.Columns[1].HeaderText = "JUDUL CD";
            DG.Columns[2].HeaderText = "STOK CD";
            DG.Columns[3].HeaderText = "HARGA";
            DG.Columns[4].HeaderText = "Tanggal";
            DG.Columns[5].HeaderText = "Nama Kategori";

            DG.Columns[0].Width = 85;
            DG.Columns[1].Width = 150;
            DG.Columns[2].Width = 125;
            DG.Columns[3].Width = 100;
            DG.Columns[4].Width = 125;
            DG.Columns[5].Width = 160;

            
        }

        private void Form1(object sender, EventArgs e)
        {
            setDatagridview(this.dataGridView1);
            uC_MENU1.Visible = false;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        //mencari data langsung dari ketikan textboxcari
        private void txt_cari_TextChanged(object sender, EventArgs e)
        {
            searchdatagridview(dataGridView1, txt_cari.Text);
        }

        //untuk menampilkan data ke datagrid setelah di search dan membuat paging untuk halaman pada datagrid
        public void searchdatagridview(DataGridView DG,string keyword)
        {
            DG.DataSource = MC.searchMenu(keyword);

            DataTable DT = MC.searchMenu(keyword);
            //========================================
            BindingList<DataTable> listTbl = new BindingList<DataTable>();

            if (DT.Rows.Count > 0)
            {
                int counter = 0, subTblIndex = -1;
                foreach (DataRow dr in DT.Rows)
                {
                    if (counter == 0)
                    {
                        listTbl.Add(DT.Clone());
                        subTblIndex++;
                    }
                    listTbl[subTblIndex].Rows.Add(dr.ItemArray);
                    counter++;
                    //pengaturan banyak baris pada datagrid
                    if (counter == 10) counter = 0;
                }
            }
            bindingSource1.DataSource = listTbl;
            bindingNavigator1.BindingSource = bindingSource1;
            DG.DataSource = (DT.Rows.Count > 0 ? listTbl[bindingSource1.Position] : DT);

            DG.Columns[0].HeaderText = "ID CD";
            DG.Columns[1].HeaderText = "JUDUL CD";
            DG.Columns[2].HeaderText = "STOK CD";
            DG.Columns[3].HeaderText = "HARGA";
            DG.Columns[4].HeaderText = "TANGGAL";
            DG.Columns[5].HeaderText = "Nama Kategori";

            DG.Columns[0].Width = 85;
            DG.Columns[1].Width = 150;
            DG.Columns[2].Width = 125;
            DG.Columns[3].Width = 100;
            DG.Columns[4].Width = 125;
            DG.Columns[5].Width = 160;
           
        }
        //untuk tidak mengaktifkan button dan teksBox
        public void disable()
        {
            txt_cari.Enabled = false;
            dataGridView1.Enabled = false;
            btn_Batal.Enabled = false;
            btn_hapus.Enabled = false;
            btn_tambah.Enabled = false;
            btn_ubah.Enabled = false;
        }
        //untuk  mengaktifkan button dan teksBox dan agar tidak terjadinya error ketika data kosong di datagrid
        public void enable()
        {
            txt_cari.Enabled = true;
            dataGridView1.Enabled = true;
            btn_Batal.Enabled = true;
            btn_hapus.Enabled = true;
            btn_tambah.Enabled = true;
            btn_ubah.Enabled = true;

            setDatagridview(this.dataGridView1);
            if(dataGridView1.RowCount>0)
            {
                dataGridView1.Rows[0].Selected = true;
                txtID.Text = getKolom(dataGridView1, 0);
            }
            dataGridView1.Rows[0].Selected = true;
        }

        //menampilkan form uc_menu1 ketika btntambah ditekan
        private void btn_tambah_Click(object sender, EventArgs e)
        {
            uC_MENU1.setFlag(1);
            uC_MENU1.Visible = true;
            disable();
        }
        //untuk mendapatkan nilai pada edit dan delete
        private string getKolom(DataGridView dg, int i)
        {
            return dg[dg.Columns[i].Index, dg.CurrentRow.Index].Value.ToString();
        }

        private string getKolomEdit(DataGridView dg, int i)
        {
            return dg[dg.Columns[0].Index, dg.Rows[i].Index].Value.ToString();
        }

        private string getRow(DataGridView dg)
        {
            return dg.CurrentRow.Index.ToString();
        }
        //====================================================
        //untuk menampung data sementara yang ada pada teksbox id dan row, ketika edit 
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtID.Text = getKolom(dataGridView1,0);
            txtRow.Text = getRow(dataGridView1); 
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            txtID.Text = getKolom(dataGridView1, 0);
            txtRow.Text = getRow(dataGridView1);
        }

        private void dataGridView1_KeyUp(object sender, KeyEventArgs e)
        {
            txtID.Text = getKolom(dataGridView1, 0);
            txtRow.Text = getRow(dataGridView1);
        }
        //=========================================================
        //untuk mengaktif kan btn dan txt pada waktu edit
        public void enableEdit()
        {
            txt_cari.Enabled = true;
            dataGridView1.Enabled = true;
            btn_Batal.Enabled = true;
            btn_hapus.Enabled = true;
            btn_ubah.Enabled = true;
            btn_tambah.Enabled = true;

            setDatagridview(this.dataGridView1);
            dataGridView1.Rows[int.Parse(txtRow.Text)].Selected = true;
            txtID.Text = getKolomEdit(dataGridView1,int.Parse(txtRow.Text));
        }

        //untuk event klik pada pengubahan data
        private void btn_ubah_Click(object sender, EventArgs e)
        {
            if (txtID.Text == "")
            {
                MessageBox.Show("Silahkan data yang hendak di ubah ?", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dataGridView1.Focus();
            }
            else
            {
                //melakukan pengubahan pada masing2 kolom dengan menampung nilai yang akan diubah pada form uc_menu
                uC_MENU1.setFlag(2);
                string judul = getKolom(dataGridView1, 1);
                string stok = getKolom(dataGridView1,2);
                string harga = getKolom(dataGridView1, 3);
                string kategori = getKolom(dataGridView1, 5);
                string tanggal = getKolom(dataGridView1, 4);
                uC_MENU1.isiTextBox(judul, stok, harga, kategori, tanggal, txtID.Text);
                uC_MENU1.Visible = true;
                txtID.Clear();
                disable();
            }

        }

        //untuk mengahapus data pada event klik di form1
        private void btn_hapus_Click(object sender, EventArgs e)
        {
            if (txtID.Text == "")
            {
                MessageBox.Show("Silahkan data yang akan dihapus ?", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dataGridView1.Focus();
            }
            else
            {
                DialogResult dr = MessageBox.Show("Apakah anda yakin akan menghapus data menu CD ?"+getKolom(dataGridView1,1),"Pertanyaan",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                if(dr == DialogResult.Yes)
                {
                    MC.deleteMenu(int.Parse(txtID.Text));
                }
                txtID.Clear();
                this.enable();
            }
        }

        //untuk refrest inputan data menjadi seperti awal

        private void btn_Batal_Click(object sender, EventArgs e)
        {
            this.enable(); 
        }

        //harus dibuat untuk pasangan binding navigator ,jika pada pencarian tidak ada maka binding ini tetap menampilkan data dari datagrid dan bila ada maka akan menampilkan data yang dicari
        private void bindingSource1_PositionChanged(object sender, EventArgs e)
        {
            this.searchdatagridview(dataGridView1, this.txt_cari.Text);
            if (txt_cari.Text == "")
            {
                this.setDatagridview(dataGridView1);
            }
        }
    }
}
