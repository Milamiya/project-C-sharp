using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using BLL;
using System.Text;
using Excel = Microsoft.Office.Interop.Excel;
using System.Windows.Forms;

namespace QuanLyDiem
{
    public partial class FormXemDiem : Form
    {
        public FormXemDiem()
        {
            InitializeComponent();
        }
        ClassBLL business = new ClassBLL();
        private void FormXemDiem_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cNPM_1DataSet4.HocKy' table. You can move, or remove it, as needed.
            this.hocKyTableAdapter.Fill(this.cNPM_1DataSet_HocKy.HocKy);

        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            string sql1 = "select TenSV from SinhVien where MaSV='" + txtMaSV.Text + "'";
            if (business.ShowData_where(sql1).Rows.Count!=0)
            {
                lblTenSV.Text= business.ShowData_where(sql1).Rows[0][0].ToString();
                lblTenSV.Visible = true;
            }
            if (chbXemTatCaHocKy.Checked == true)
            {
                string sql = "select HocPhan.MaHP,NhomHocPhan.MaNhomHP,HocPhan.TenHP,KetQua.DiemQT,KetQua.DiemThi,KetQua.DiemXepLoai " +
                               " From KetQua,HocPhan,NhomHocPhan,KeHoachGiangDay " +
                                " Where KetQua.MaSV='" + txtMaSV.Text + "' " +
                                   " and KetQua.MaNhomHP=NhomHocPhan.MaNhomHP " +
                                   " and NhomHocPhan.MaHP=HocPhan.MaHP " +
                                   " and NhomHocPhan.MaKHGD=KeHoachGiangDay.MaKHGD ";
                dgvKetQua.DataSource = business.ShowData_where(sql);
                if (dgvKetQua.RowCount > 0)
                {
                    string test = business.TinhDiemTB(txtMaSV.Text);
                    txtHe10.Text = test.Split(',')[0];
                    txtHe4.Text = test.Split(',')[1];
                }
                else
                {
                    txtHe10.Text = "";
                    txtHe4.Text = "";
                }
            }
            else
            {
                string sql = "select HocPhan.MaHP,NhomHocPhan.MaNhomHP,HocPhan.TenHP,KetQua.DiemQT,KetQua.DiemThi,KetQua.DiemXepLoai " +
                               " From KetQua,HocPhan,NhomHocPhan,KeHoachGiangDay " +
                                " Where KetQua.MaSV='" + txtMaSV.Text + "' " +
                                   " and KetQua.MaNhomHP=NhomHocPhan.MaNhomHP " +
                                   " and NhomHocPhan.MaHP=HocPhan.MaHP " +
                                   " and NhomHocPhan.MaKHGD=KeHoachGiangDay.MaKHGD " +
                                   " and KeHoachGiangDay.MaHK='" + cmbMaHK.SelectedValue.ToString() + "'";
                dgvKetQua.DataSource = business.ShowData_where(sql);
                if (dgvKetQua.RowCount > 0)
                {
                    string test = business.TinhDiemTB(txtMaSV.Text, cmbMaHK.SelectedValue.ToString());
                    txtHe10.Text = test.Split(',')[0];
                    txtHe4.Text = test.Split(',')[1];
                }
                else
                {
                    txtHe10.Text = "";
                    txtHe4.Text = "";
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
                objSheet.Cells[2, 5] = "BẢNG ĐIỂM CỦA SINH VIÊN";
                objSheet.Cells[5, 3] = "Mã Học Phần";
                objSheet.Cells[5, 4] = "Mã Nhóm Học Phần";
                objSheet.Cells[5, 5] = "Tên Học Phần";
                objSheet.Cells[5, 6] = "Điểm Thi";
                objSheet.Cells[5, 7] = "Điểm Quá Trình";
                objSheet.Cells[5, 8] = "Điểm Xếp Loại";
                objSheet.Cells[3, 3] = "Mã Học Kỳ : "+cmbMaHK.SelectedValue.ToString()+"";
                objSheet.Cells[4, 3] = "Mã SV : " + txtMaSV.Text + "";
                objSheet.Cells[9,10] = "ĐIỂM TỔNG KẾT";
                objSheet.Cells[10,10] = "Hệ 10 : "+txtHe10.Text+"";
                objSheet.Cells[11,10] = "Hệ 4 : "+txtHe4.Text+"";
                for (int i = 0; i < dgvKetQua.Rows.Count ; i++)
                {
                    for (int j = 0; j < dgvKetQua.Columns.GetColumnCount(DataGridViewElementStates.Displayed); j++)
                    {
                        objSheet.Cells[i + 6, j + 3] = dgvKetQua.Rows[i].Cells[j].Value.ToString();
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

        private void txtMaSV_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ' ')
                e.Handled = true;
        }
        int j = -1;
        private void chbXemTatCaHocKy_CheckedChanged(object sender, EventArgs e)
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
