using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//menambahkan using untuk memanggil fungsi pada control
using System.Windows.Forms;
using UGD_RENTAL_CD_7923.Control_7923;

namespace UGD_RENTAL_CD_7923.Boundary_7923
{
    public partial class FormLogin : Form
    {
        
        public FormLogin()
        {
            InitializeComponent();  
        }
        //memanggil login control
        LoginControl LC = new LoginControl();  
        //untuk login dengan event klik dengan ceklogin pada role
        private void btnlogin_Click(object sender, EventArgs e)
        {
            if (LC.cekLogin(txtuser.Text, txtpass.Text) == true)
            {
                int role = LC.GetRoleUser(txtuser.Text, txtpass.Text);

                if (role == 1)
                {
                    this.Hide();
                    FormUtama fr = new FormUtama();
                    fr.setToolStripUser("Pengguna : Admin - " + txtuser.Text);
                    fr.setVisibleMenuDataMaster(true);
                    fr.setVisibleMenuTransaksi(true);
                    fr.ShowDialog();
                    this.Close();
                }
                else if (role == 2)
                {
                    this.Hide();
                    FormUtama fr = new FormUtama();
                    fr.setToolStripUser("Pengguna : Petugas - " + txtuser.Text);
                    fr.setVisibleMenuDataMaster(false);
                    fr.setVisibleMenuTransaksi(true);
                    fr.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Tidak memiliki Role");
                }
            }
            else
            {
                MessageBox.Show("Username atau Password salah");
            }
        }

        //untuk tanda ( ' ) tidak dapat diinputkan
        private void txtuser_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 39)
                e.Handled = true;
        }

        private void txtpass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 39)
                e.Handled = true;
        }
        //=======================================
        //untuk keluar dari program
        private void btnbatal_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        
    }
}
