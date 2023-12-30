using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using DAL;
using BLL;
using Excel = Microsoft.Office.Interop.Excel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QuanLyDiem
{
    public partial class FormXemDiemLop : Form
    {
        public FormXemDiemLop()
        {
            InitializeComponent();
        }
        ClassDAL dal = new ClassDAL();
        ClassBLL business = new ClassBLL();
        public void loadCmbMaLop()
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
        public void loadCmbMaHK()
        {
            SqlConnection con = dal.GetConnect();
            con.Open();
            SqlCommand cm = new SqlCommand("Select *from HocKy", con);
            SqlDataAdapter da = new SqlDataAdapter(cm);
            DataTable dt = new DataTable();
            da.Fill(dt);
            this.cmbMaHK.DisplayMember = "MaHK";
            this.cmbMaHK.ValueMember = "MaHK";
            this.cmbMaHK.DataSource = dt;
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormXemDiemLop_Load(object sender, EventArgs e)
        {
            loadCmbMaHK();
            loadCmbMaLop();
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            if (chbXemTatCa.Checked == true)
            {
                if (Convert.ToInt32(cmbMaLop.SelectedIndex) != -1)
                {
                    dgvKetQua.DataSource = business.XemDiemLop(cmbMaLop.SelectedValue.ToString());
                }
            }
            else
            {
                if (Convert.ToInt32(cmbMaLop.SelectedIndex) != -1 && Convert.ToInt32(cmbMaHK.SelectedIndex) != -1)
                {
                    dgvKetQua.DataSource = business.XemDiemLop(cmbMaHK.SelectedValue.ToString(), cmbMaLop.SelectedValue.ToString());
                }
            }
        }

        private void btnXuatRaExcel_Click(object sender, EventArgs e)
        {
             try
            {

                Excel.Application objExcelApp = new Excel.Application();
                Excel.Workbook objExcelWorkbook = objExcelApp.Workbooks.Add(Excel.XlWBATemplate.xlWBATWorksheet);
                Excel.Worksheet objSheet = (Excel.Worksheet)objExcelWorkbook.Worksheets[1];
                //objSheet.Cells.Interior.Color.ToString() = 'blue';
                objSheet = (Excel.Worksheet)objExcelWorkbook.Sheets[1];
                objSheet.Cells.HorizontalAlignment = Excel.Constants.xlCenter;
                objSheet.Cells[2, 5] = "BẢNG ĐIỂM CỦA LỚP";
                objSheet.Cells[3, 3] = "Mã Học Kỳ : "+cmbMaHK.SelectedValue.ToString()+"";
                objSheet.Cells[4, 3] = "Mã Lớp : " + cmbMaLop.SelectedValue.ToString() + "";
                objSheet.Cells[5, 4] = "Mã Sinh Viên";
                objSheet.Cells[5, 5] = "Tên Sinh Viên";
                objSheet.Cells[5, 6] = "Điểm Trung Bình";
                //select sv.MaSV,TenSV,TrungBinhCuoiKyHe10
                
                for (int i = 0; i < dgvKetQua.Rows.Count ; i++)
                {
                    for (int j = 0; j < dgvKetQua.Columns.GetColumnCount(DataGridViewElementStates.Displayed); j++)
                    {
                        objSheet.Cells[i + 6, j + 4] = dgvKetQua.Rows[i].Cells[j].Value.ToString();
                        objSheet.Columns.AutoFit();
                    }
                }
                objExcelApp.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        int j = -1;
        private void chbXemTatCa_CheckedChanged(object sender, EventArgs e)
        {
            int i = -1;
            i = i * j;
            if (i == 1)
            {
                cmbMaHK.Enabled = false;
            }
            else
            {
                cmbMaHK.Enabled = true;
            }
            j = -j;
        }

    }
}
