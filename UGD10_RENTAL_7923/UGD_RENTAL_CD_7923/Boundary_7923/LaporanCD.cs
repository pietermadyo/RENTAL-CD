using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UGD_RENTAL_CD_7923.DS_RentalTableAdapters;

namespace UGD_RENTAL_CD_7923.Boundary_7923
{
    public partial class LaporanCD : Form
    {
        public LaporanCD()
        {
            InitializeComponent();
        }
        //memanggil tableadapter pada dataset
        private TBL_CDTableAdapter TM = new TBL_CDTableAdapter();

        //event load untuk mengambil nilai pada datatable dengan methot getdata() dan menampilkan pada report
        private void LaporanCD_Load(object sender, EventArgs e)
        {
            RptCD rpt = new RptCD();
            DataTable data = new DataTable();
            data = TM.GetData();
            rpt.SetDataSource(data);

            crystalReportViewer1.ReportSource = rpt;
            crystalReportViewer1.Show();
        }
    }
}
