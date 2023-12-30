using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CrystalDecisions.Shared;
using CrystalDecisions.CrystalReports;
using DAL;

namespace QuanLyDiem
{
    public partial class FormBaoCao : Form
    {
        public FormBaoCao()
        {
            InitializeComponent();
        }
        ClassDAL dal = new ClassDAL();
        private void FormBaoCao_Load(object sender, EventArgs e)
        {
            loadCmb();
        }
        public void loadCmb()
        {
            SqlConnection con = dal.GetConnect();
            con.Open();
            SqlCommand cm = new SqlCommand("Select *from Lop", con);
            SqlDataAdapter da = new SqlDataAdapter(cm);
            DataTable dt = new DataTable();
            da.Fill(dt);
            this.cmbMaLop.DisplayMember = "MaLop";
            this.cmbMaLop.ValueMember = "MaLop";
            this.cmbMaLop.DataSource = dt;
        }

        private void btnLoc_Click(object sender, EventArgs e)
        {
            SqlConnection con = dal.GetConnect();
            con.Open();
            string sql = "select *from SinhVien where MaLop=@MaLop";
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            da.SelectCommand.Parameters.AddWithValue("@MaLop", cmbMaLop.SelectedValue.ToString());
            DataTable dt = new DataTable();
            da.Fill(dt);
            crBaoCao cr = new crBaoCao();
            ConnectionInfo crConnectionInfo = new ConnectionInfo();
            crConnectionInfo.ServerName = "Ty-PC";
            crConnectionInfo.DatabaseName = "CNPM_1";
            crConnectionInfo.UserID = "sa";
            crConnectionInfo.Password = "04091990";
            TableLogOnInfos crTableLogonInfos = new TableLogOnInfos();
            foreach (CrystalDecisions.CrystalReports.Engine.Table table in cr.Database.Tables)
            {
                TableLogOnInfo crTableLogonInfo = new TableLogOnInfo();
                crTableLogonInfo.TableName = table.Name;
                crTableLogonInfo.ConnectionInfo = crConnectionInfo;
                crTableLogonInfos.Add(crTableLogonInfo);
                table.ApplyLogOnInfo(crTableLogonInfo);

            }
            crvHocKyHocPhan.LogOnInfo = crTableLogonInfos;
            cr.SetDataSource(dt);
            ParameterValues a = new ParameterValues();
            ParameterDiscreteValue b = new ParameterDiscreteValue();
            b.Value = cmbMaLop.SelectedValue.ToString();
            a.Add(b);
            cr.DataDefinition.ParameterFields["txtMaLop"].ApplyCurrentValues(a);
            crvHocKyHocPhan.ReportSource = cr;
            crvHocKyHocPhan.Show();
        }
    }
}
