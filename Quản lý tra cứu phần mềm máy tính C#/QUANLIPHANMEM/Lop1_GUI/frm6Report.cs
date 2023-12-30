using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


using System.Data.OleDb;

namespace Lop1_GUI
{
    public partial class frm6Report : Form
    {
        public frm6Report()
        {
            InitializeComponent();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
    {
            OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=QLSP.accdb");
            OleDbCommand cmd=new OleDbCommand("Select * from PHANMEM",con);
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds, "PHANMEM");
            // Khai báo đối tượng
            CrystalReport1 r = new CrystalReport1();

            // Gán soure cho crystalreport
            r.SetDataSource(ds);

            //Liên kết crystalreport với crystalreport view
            crystalReportViewer1.ReportSource = r;
	
        }

        private void BtnTroVe_Click(object sender, EventArgs e)
        {

        }
    }
}
