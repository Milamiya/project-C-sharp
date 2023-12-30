using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using clsDATABASE;

namespace QLTTTH
{
    public partial class frmBaocao : Form
    {
        public frmBaocao()
        {
            InitializeComponent();
        }

        clsQLTTTH obj = new clsQLTTTH();

        private void frmBaocao_Load(object sender, EventArgs e)
        {
            cboChonlop.DisplayMember = "TenLop";
            cboChonlop.ValueMember = "MaLop";
            cboChonlop.DataSource = obj.GetDataTable("Lop");
            //cboChonlop.SelectedIndex = -1;
        }

        private void cboChonlop_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable tbl = new DataTable();
            rptBaocao rptReport = new rptBaocao();
            string Malop = "";
            Malop = cboChonlop.SelectedValue.ToString();
            tbl = obj.GetDataTableReport(Malop);
            rptReport.SetDataSource(tbl);
            rptReport.Refresh();
            crvReport.ReportSource = rptReport;
        }

        private void frmBaocao_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult d = MessageBox.Show("Bạn muốn đóng báo cáo kết quả ?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (DialogResult.No == d)
                e.Cancel = true;
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}