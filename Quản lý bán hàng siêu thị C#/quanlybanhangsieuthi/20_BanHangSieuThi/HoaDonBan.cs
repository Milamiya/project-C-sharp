using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using COMExcel = Microsoft.Office.Interop.Excel;
using System.Data.SqlClient;

namespace _20_BanHangSieuThi
{
    public partial class HoaDonBan : Form
    {
        DataTable tblChiTietHDB;
        public HoaDonBan()
        {
            InitializeComponent();
        }

        private void HoaDonBan_Load(object sender, EventArgs e)
        {
            btnThemhoadon.Enabled = true;
            btnLuuhoadon.Enabled = false;
            btnHuyhoadon.Enabled = false;
            btnInhoadon.Enabled = false;
            txtMahoadon.ReadOnly = true;
            txtTennhanvien.ReadOnly = true;
            txtTenkhach.ReadOnly = true;
            txtDiachi.ReadOnly = true;
            mskDienthoai.ReadOnly = true;
            txtTenhang.ReadOnly = true;
            //txtDongia.ReadOnly = true;
            txtThanhtien.ReadOnly = true;
            txtTongtien.ReadOnly = true;
            txtGiamgia.Text = "";
            txtTongtien.Text = "0";
            Data.FillCombo("SELECT Makhach FROM tblKhach", cboMakhach, "Makhach", "Makhach");
            cboMakhach.SelectedIndex = -1;
            Data.FillCombo("SELECT Manhanvien FROM tblNhanVien", cboManhanvien, "Manhanvien", "Manhanvien");
            cboManhanvien.SelectedIndex = -1;
            Data.FillCombo("SELECT Mavach FROM tblDMHangHoa", cboMahang, "Mavach", "Mavach");
            cboMahang.SelectedIndex = -1;
            Data.FillCombo("SELECT Sohoadonban FROM tblHoaDonBan", cboMahoadon, "Sohoadonban", "Sohoadonban");
            cboMahoadon.SelectedIndex = -1;
            if (txtMahoadon.Text != "")
            {
                Load_ThongtinHD();
                btnHuyhoadon.Enabled = true;
                btnInhoadon.Enabled = true;
            }
            Load_DataGridViewchitiet();
        }

        private void Load_DataGridViewchitiet()
        {
            string sql;
            sql = "SELECT a.Mavach, b.Tenhanghoa, a.Soluong, b.Dongiaxuat, a.Giamgia, a.Thanhtien FROM tblChiTietHDB AS a, tblDMHangHoa AS b WHERE a.Sohoadonban=N'" + txtMahoadon.Text + "' AND a.Mavach=b.Mavach";
            tblChiTietHDB = Data.GetDataToTable(sql);
            DataGridViewChitiet.DataSource = tblChiTietHDB;
            DataGridViewChitiet.Columns[0].HeaderText = "Mã vạch";
            DataGridViewChitiet.Columns[1].HeaderText = "Tên hàng";
            DataGridViewChitiet.Columns[2].HeaderText = "Số lượng";
            DataGridViewChitiet.Columns[3].HeaderText = "Đơn giá xuất";
            DataGridViewChitiet.Columns[4].HeaderText = "Giảm giá %";
            DataGridViewChitiet.Columns[5].HeaderText = "Thành tiền";
            DataGridViewChitiet.Columns[0].Width = 150;
            DataGridViewChitiet.Columns[1].Width = 200;
            DataGridViewChitiet.Columns[2].Width = 120;
            DataGridViewChitiet.Columns[3].Width = 120;
            DataGridViewChitiet.Columns[4].Width = 120;
            DataGridViewChitiet.Columns[5].Width = 120;
            DataGridViewChitiet.AllowUserToAddRows = false;
            DataGridViewChitiet.EditMode = DataGridViewEditMode.EditProgrammatically;
        }
        private void Load_ThongtinHD()
        {
            string str;
            str = "SELECT Ngayban FROM tblHoaDonBan WHERE Sohoadonban=N'" + txtMahoadon.Text + "'";
            txtNgayban.Text = Data.ConvertDateTime(Data.GetFieldValues(str));
            str = "SELECT Manhanvien FROM tblHoaDonBan WHERE Sohoadonban=N'" + txtMahoadon.Text + "'";
            cboManhanvien.Text = Data.GetFieldValues(str);
            str = "SELECT Makhach FROM tblHoaDonBan WHERE Sohoadonban=N'" + txtMahoadon.Text + "'";
            cboMakhach.Text = Data.GetFieldValues(str);
            str = "SELECT Tongtien FROM tblHoaDonBan WHERE Sohoadonban=N'" + txtMahoadon.Text + "'";
            txtTongtien.Text = Data.GetFieldValues(str);
            str = "SELECT Mavach FROM tblChiTietHDB WHERE Sohoadonban=N'" + txtMahoadon.Text + "'";
            cboMahang.Text = Data.GetFieldValues(str);
            lblBangchu.Text = "Bằng chữ: " + Data.ChuyenSoSangChu(txtTongtien.Text);

        }

        private void btnThemhoadon_Click(object sender, EventArgs e)
        {
            btnHuyhoadon.Enabled = false;
            btnLuuhoadon.Enabled = true;
            btnInhoadon.Enabled = false;
            btnThemhoadon.Enabled = false;
            ResetValues();
            txtMahoadon.Text = Data.CreateKey("HDB");
            Load_DataGridViewchitiet();

        }
        private void ResetValues()
        {
            txtMahoadon.Text = "";
            txtNgayban.Text = DateTime.Now.ToShortDateString();
            cboManhanvien.Text = "";
            txtTongtien.Text = "0";
            cboMakhach.Text = "";
            lblBangchu.Text = "Bằng chữ: ";
            cboMahang.Text = "";
            txtSoluong.Text = "";
            txtGiamgia.Text = "0";
            txtThanhtien.Text = "0";
        }

        private void btnLuuhoadon_Click(object sender, EventArgs e)
        {
            string sql;
            double sl, SLcon, tong, Tongmoi;
            sql = "SELECT Sohoadonban FROM tblHoaDonBan WHERE Sohoadonban =N'" + txtMahoadon.Text + "'";
            if (!Data.Checkey(sql))
            {
                if (txtNgayban.Text.Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập ngày bán!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtNgayban.Focus();
                    return;
                }
                if (cboManhanvien.Text.Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập nhân viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cboManhanvien.Focus();
                    return;
                }
                if (cboMakhach.Text.Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập khách hàng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cboMakhach.Focus();
                    return;
                }
                sql = "INSERT INTO tblHoaDonBan(Sohoadonban, Ngayban, Manhanvien, Makhach, Tongtien) VALUES (N'" + txtMahoadon.Text.Trim() + "','" + Data.ConvertDateTime(txtNgayban.Text.Trim()) + "',N'" + cboManhanvien.Text.Trim() + "',N'" + cboMakhach.Text.Trim() + "'," + txtTongtien.Text + ")";
                Data.RunSql(sql);
            }
            if (cboMahang.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã hàng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboMahang.Focus();
                return;
            }
            if ((txtSoluong.Text.Trim().Length == 0) || (txtSoluong.Text == "0"))
            {
                MessageBox.Show("Bạn phải nhập số lượng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSoluong.Text = "";
                txtSoluong.Focus();
                return;
            }
            if (txtGiamgia.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập giảm giá!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtGiamgia.Focus();
                return;
            }
            sql = "SELECT Mavach FROM tblChiTietHDB WHERE Mavach=N'" + cboMahang.Text + "'AND Sohoadonban=N'" + txtMahoadon.Text.Trim() + "'";
            if (Data.Checkey(sql))
            {
                MessageBox.Show("Mã hàng này đã có, bạn phải nhập mã khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ResetValues();
                cboMahang.Focus();
                return;
            }
            sl = Convert.ToDouble(Data.GetFieldValues("SELECT Soluong FROM tblDMHangHoa WHERE Mavach=N'" + cboMahang.Text + "'"));
            if (Convert.ToDouble(txtSoluong.Text) > sl)
            {
                MessageBox.Show("Số lượng mặt hàng này chỉ còn " + sl, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtSoluong.Text = "";
                txtSoluong.Focus();
                return;
            }
            sql = "INSERT INTO tblChiTietHDB(Sohoadonban,Mavach,Soluong,Giamgia,Dongiaxuat,Thanhtien) VALUES(N'" + txtMahoadon.Text.Trim() + "',N'" + cboMahang.Text.ToString() + "'," + txtSoluong.Text + "," + txtGiamgia.Text + "," + txtDongia.Text + "," + txtThanhtien.Text + ")";
            Data.RunSql(sql);
            Load_DataGridViewchitiet();
            SLcon = sl - Convert.ToDouble(txtSoluong.Text);
            sql = "UPDATE tblDMHangHoa SET Soluong =" + SLcon + " WHERE Mavach=N'" + cboMahang.Text + "'";
            Data.RunSql(sql);
            tong = Convert.ToDouble(Data.GetFieldValues("SELECT Tongtien FROM tblHoaDonBan WHERE Sohoadonban=N'" + txtMahoadon.Text + "'"));
            Tongmoi = tong + Convert.ToDouble(txtThanhtien.Text);
            Tongmoi = Math.Round(Tongmoi, 0);
            sql = "UPDATE tblHoaDonBan SET TongTien=" + Tongmoi + " WHERE Sohoadonban=N'" + txtMahoadon.Text + "'";
            Data.RunSql(sql);
            sql = "UPDATE tblChiTietHDB SET Thanhtien=" + txtThanhtien.Text + "WHERE Sohoadonban=N'" + txtMahoadon.Text + "'";
            Data.RunSql(sql);
            txtTongtien.Text = Tongmoi.ToString();
            lblBangchu.Text = "Bằng chữ: " + Data.ChuyenSoSangChu(Tongmoi.ToString());
            ResetValuesHang();
            btnHuyhoadon.Enabled = true;
            btnThemhoadon.Enabled = true;
            btnInhoadon.Enabled = true;
        }

        private void ResetValuesHang()
        {
            cboMahang.Text = "";
            txtSoluong.Text = "";
            txtGiamgia.Text = "";
            txtThanhtien.Text = "0";
        }

        private void DataGridViewChitiet_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string mahang;
            Double Thanhtien;
            if (tblChiTietHDB.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                mahang = DataGridViewChitiet.CurrentRow.Cells["Mavach"].Value.ToString();
                DelHang(txtMahoadon.Text, mahang);
                Thanhtien = Convert.ToDouble(DataGridViewChitiet.CurrentRow.Cells["Thanhtien"].Value.ToString());
                DelUpdateTongTien(txtMahoadon.Text, Thanhtien);
                Load_DataGridViewchitiet();
            }
        }

        private void DelHang(string Mahoadon, string Mahang)
        {
            Double s, sl, Slcon;
            string sql;
            sql = "SELECT Soluong FROM tblChiTietHDB WHERE Sohoadonban =N'" + Mahoadon + "' AND Mavach=N'" + Mahang + "'";
            s = Convert.ToDouble(Data.GetFieldValues(sql));
            sql = "DELETE tblChiTietHDB WHERE Sohoadonban =N'" + Mahoadon + "' AND Mavach=N'" + Mahang + "'";
            Data.RunSql(sql);
            sql = "SELECT Soluong FROM tblDMHangHoa WHERE Mavach=N'" + Mahang + "'";
            sl = Convert.ToDouble(Data.GetFieldValues(sql));
            Slcon = sl + s;
            sql = "UPDATE tblDMHangHoa SET Soluong=" + Slcon + " WHERE Mavach=N'" + Mahang + "'";
            Data.RunSql(sql);

        }
        private void DelUpdateTongTien(string Mahoadon, double Thanhtien)
        {
            Double Tong, Tongmoi;
            string sql;
            sql = "SELECT TongTien FROM tblHoaDonBan WHERE Sohoadonban=N'" + Mahoadon + "'";
            Tong = Convert.ToDouble(Data.GetFieldValues(sql));
            Tongmoi = Tong - Thanhtien;
            sql = "UPDATE tblHoaDonBan SET TongTien=" + Tongmoi + " WHERE Sohoadonban=N'" + Mahoadon + "'";
            Data.RunSql(sql);
            txtTongtien.Text = Tongmoi.ToString();
            lblBangchu.Text = "Bằng chữ: " + Data.ChuyenSoSangChu(Tongmoi.ToString());
        }

        private void btnHuyhoadon_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string[] Mahang = new string[20];
                string sql;
                int n = 0;
                int i;
                sql = "SELECT Mavach FROM tblChiTietHDB WHERE Sohoadonban=N'" + txtMahoadon.Text + "'";
                SqlCommand cmd = new SqlCommand(sql, Data.Conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Mahang[n] = reader.GetString(0).ToString();
                    n = n + 1;
                }
                reader.Close();
                for (i = 0; i <= n - 1; i++)
                    DelHang(txtMahoadon.Text, Mahang[i]);
                sql = "DELETE tblHoaDonBan WHERE Sohoadonban=N'" + txtMahoadon.Text + "'";
                Data.RunSql(sql);
                ResetValues();
                Load_DataGridViewchitiet();
                btnHuyhoadon.Enabled = false;
                btnInhoadon.Enabled = false;
            }
        }

        private void cboManhanvien_TextChanged(object sender, EventArgs e)
        {
            string str;
            if (cboManhanvien.Text == "")
                txtTennhanvien.Text = "";
            str = "Select Tennhanvien from tblNhanVien where Manhanvien=N'" + cboManhanvien.Text + "'";
            txtTennhanvien.Text = Data.GetFieldValues(str);
        }

        private void cboMakhach_TextChanged(object sender, EventArgs e)
        {
            string str;
            if (cboMakhach.Text == "")
            {
                txtTenkhach.Text = "";
                txtDiachi.Text = "";
                mskDienthoai.Text = "";
            }
            str = "Select Tenkhach from tblKhach where Makhach=N'" + cboMakhach.Text + "'";
            txtTenkhach.Text = Data.GetFieldValues(str);
            str = "Select Diachi from tblKhach where Makhach=N'" + cboMakhach.Text + "'";
            txtDiachi.Text = Data.GetFieldValues(str);
            str = "Select Dienthoai from tblKhach where Makhach=N'" + cboMakhach.Text + "'";
            mskDienthoai.Text = Data.GetFieldValues(str);
        }

        private void cboMahang_TextChanged(object sender, EventArgs e)
        {
            string str;
            if (cboMahang.Text == "")
            {
                txtTenhang.Text = "";
                txtDongia.Text = "";

            }
            str = "Select TenhangHoa from tblDMHangHoa where Mavach=N'" + cboMahang.Text + "'";
            txtTenhang.Text = Data.GetFieldValues(str);
            str = "Select Dongiaxuat from tblDMHangHoa where Mavach=N'" + cboMahang.Text + "'";
            txtDongia.Text = Data.GetFieldValues(str);
        }

        private void txtSoluong_TextChanged(object sender, EventArgs e)
        {
            double tt, sl, dg, gg;
            if (txtSoluong.Text == "")
                sl = 0;
            else
                sl = Convert.ToDouble(txtSoluong.Text);
            if (txtGiamgia.Text == "")
                gg = 0;
            else
                gg = Convert.ToDouble(txtGiamgia.Text);
            if (txtDongia.Text == "")
                dg = 0;
            else
                dg = Convert.ToDouble(txtDongia.Text);
            tt = sl * dg - sl * dg * gg / 100;
            txtThanhtien.Text = tt.ToString();
        }

        private void txtGiamgia_TextChanged(object sender, EventArgs e)
        {
            double tt, sl, dg, gg;
            if (txtSoluong.Text == "")
                sl = 0;
            else
                sl = Convert.ToDouble(txtSoluong.Text);
            if (txtGiamgia.Text == "")
                gg = 0;
            else
                gg = Convert.ToDouble(txtGiamgia.Text);
            if (txtDongia.Text == "")
                dg = 0;
            else
                dg = Convert.ToDouble(txtDongia.Text);
            tt = sl * dg - sl * dg * gg / 100;
            txtThanhtien.Text = tt.ToString();
        }

        private void txtSoluong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar >= '0') && (e.KeyChar <= '9') || (Convert.ToInt32(e.KeyChar) == 8)) || (Convert.ToInt32(e.KeyChar) == 13))
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void txtGiamgia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar >= '0') && (e.KeyChar <= '9') || (Convert.ToInt32(e.KeyChar) == 8)) || (Convert.ToInt32(e.KeyChar) == 13))
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void cboMahoadon_DropDown(object sender, EventArgs e)
        {
            Data.FillCombo("SELECT Sohoadonban FROM tblHoaDonBan", cboMahoadon, "Sohoadonban", "Sohoadonban");
            cboMahoadon.SelectedIndex = -1;
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (cboMahoadon.Text == "")
            {
                MessageBox.Show("Bạn phải chọn một mã hóa đơn để tìm kiếm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboMahoadon.Focus();
                return;
            }
            txtMahoadon.Text = cboMahoadon.Text;
            Load_ThongtinHD();
            Load_DataGridViewchitiet();
            cboMahoadon.Text = Data.GetFieldValues("SELECT Sohoadonban FROM tblChiTietHDB WHERE Sohoadonban =N'" + cboMahoadon.Text + "'");
            txtDongia.Text = Data.GetFieldValues("SELECT Dongiaxuat FROM tblChiTietHDB WHERE Sohoadonban =N'" + cboMahoadon.Text + "'");
            txtGiamgia.Text = Data.GetFieldValues("SELECT Giamgia FROM tblChiTietHDB WHERE Sohoadonban=N'" + cboMahoadon.Text + "'");
            txtSoluong.Text = Data.GetFieldValues("SELECT Soluong FROM tblChiTietHDB WHERE Sohoadonban=N'" + cboMahoadon.Text + "'");
            btnHuyhoadon.Enabled = true;
            btnLuuhoadon.Enabled = true;
            btnInhoadon.Enabled = true;
            cboMahoadon.SelectedIndex = -1;
        }

        private void btnInhoadon_Click(object sender, EventArgs e)
        {
            // Khởi động chương trình Excel
            COMExcel.Application exApp = new COMExcel.Application();
            COMExcel.Workbook exBook;
            COMExcel.Worksheet exSheet;
            COMExcel.Range exRange;
            string sql;
            int hang = 0, cot = 0;
            DataTable tblThongtinHD, tblThongtinHang;
            exBook = exApp.Workbooks.Add(COMExcel.XlWBATemplate.xlWBATWorksheet);
            exSheet = exBook.Worksheets[1];
            // Định dạng chung
            exRange = exSheet.Cells[1, 1];
            exRange.Range["A1:B3"].Font.Size = 10;
            exRange.Range["A1:B3"].Font.Name = "Times new roman";
            exRange.Range["A1:B3"].Font.Bold = true;
            exRange.Range["A1:B3"].Font.ColorIndex = 5; //Màu xanh da trời
            exRange.Range["A1:A1"].ColumnWidth = 7;
            exRange.Range["B1:B1"].ColumnWidth = 15;
            exRange.Range["A1:B1"].MergeCells = true;
            exRange.Range["A1:B1"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A1:B1"].Value = "Thế Giới Siêu Thị";
            exRange.Range["A2:B2"].MergeCells = true;
            exRange.Range["A2:B2"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A2:B2"].Value = "Việt Nam";
            exRange.Range["A3:B3"].MergeCells = true;
            exRange.Range["A3:B3"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A3:B3"].Value = "Điện thoại: 0972594994";
            exRange.Range["C2:E2"].Font.Size = 16;
            exRange.Range["C2:E2"].Font.Name = "Times new roman";
            exRange.Range["C2:E2"].Font.Bold = true;
            exRange.Range["C2:E2"].Font.ColorIndex = 3; //Màu đỏ
            exRange.Range["C2:E2"].MergeCells = true;
            exRange.Range["C2:E2"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["C2:E2"].Value = "HÓA ĐƠN BÁN";
            // Biểu diễn thông tin chung của hóa đơn bán
            sql = @"SELECT     tblHoaDonBan.Sohoadonban, tblKhach.TenKhach, tblKhach.DiaChi, tblKhach.DienThoai, tblNhanVien.Tennhanvien, tblHoaDonBan.Ngayban
FROM         tblHoaDonBan INNER JOIN
                      tblKhach ON tblHoaDonBan.Makhach = tblKhach.MaKhach INNER JOIN
                      tblNhanVien ON tblHoaDonBan.Mahanvien = tblNhanVien.Manhanvien where tblHoaDonBan.Sohoadonban='" + txtMahoadon.Text + "'";
            tblThongtinHD = Data.GetDataToTable(sql);
            exRange.Range["B6:C9"].Font.Size = 12;
            exRange.Range["B6:C9"].Font.Name = "Times new roman";
            exRange.Range["B6:B6"].Value = "Mã hóa đơn:";
            exRange.Range["C6:E6"].MergeCells = true;
            exRange.Range["C6:E6"].Value = tblThongtinHD.Rows[0][0].ToString();
            exRange.Range["B7:B7"].Value = "Khách hàng:";
            exRange.Range["C7:E7"].MergeCells = true;
            exRange.Range["C7:E7"].Value = tblThongtinHD.Rows[0][1].ToString();
            exRange.Range["B8:B8"].Value = "Địa chỉ:";
            exRange.Range["C8:E8"].MergeCells = true;
            exRange.Range["C8:E8"].Value = tblThongtinHD.Rows[0][2].ToString();
            exRange.Range["B9:B9"].Value = "Điện thoại:";
            exRange.Range["C9:E9"].MergeCells = true;
            exRange.Range["C9:E9"].Value = tblThongtinHD.Rows[0][3].ToString();
            //Lấy thông tin các mặt hàng
            sql = @"SELECT     tblDMHangHoa.Tenhanghoa, tblChiTietHDB.Soluong, tblDMHangHoa.Dongiaxuat, tblChiTietHDB.Giamgia, tblChiTietHDB.Thanhtien
FROM         tblChiTietHDB INNER JOIN
                      tblDMHangHoa ON tblChiTietHDB.Mavach = tblDMHangHoa.Mavach
                       where tblChiTietHDB.Sohoadonban='" + txtMahoadon.Text + "'";
            tblThongtinHang = Data.GetDataToTable(sql);
            //Tạo dòng tiêu đề bảng
            exRange.Range["A11:F11"].Font.Bold = true;
            exRange.Range["A11:F11"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["C11:F11"].ColumnWidth = 12;
            exRange.Range["A11:A11"].Value = "STT";
            exRange.Range["B11:B11"].Value = "Tên hàng";
            exRange.Range["C11:C11"].Value = "Số lượng";
            exRange.Range["D11:D11"].Value = "Đơn giá";
            exRange.Range["E11:E11"].Value = "Khuyên Mãi";
            exRange.Range["F11:F11"].Value = "Thành tiền";
            for (hang = 0; hang <= tblThongtinHang.Rows.Count - 1; hang++)
            {
                //Điền số thứ tự vào cột 1 từ dòng 12
                exSheet.Cells[1][hang + 12] = hang + 1;
                for (cot = 0; cot <= tblThongtinHang.Columns.Count - 1; cot++)
                    //Điền thông tin hàng từ cột thứ 2, dòng 12
                    exSheet.Cells[cot + 2][hang + 12] = tblThongtinHang.Rows[hang][cot].ToString();
            }
            exRange.Value2 = tblThongtinHD.Rows[0][2].ToString();
            exRange = exSheet.Cells[1][hang + 15]; //Ô A1 
            exRange.Range["A1:F1"].MergeCells = true;
            exRange.Range["A1:F1"].Font.Bold = true;
            exRange.Range["A1:F1"].Font.Italic = true;
            exRange.Range["A1:F1"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignRight;
            exRange = exSheet.Cells[4][hang + 17]; //Ô A1 
            exRange.Range["A1:C1"].MergeCells = true;
            exRange.Range["A1:C1"].Font.Italic = true;
            exRange.Range["A1:C1"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            DateTime d = Convert.ToDateTime(tblThongtinHD.Rows[0][5]);
            exRange.Range["A1:C1"].Value = "Hà Nội, ngày " + d.Day + " tháng " + d.Month + " năm " + d.Year;
            exRange.Range["A2:C2"].MergeCells = true;
            exRange.Range["A2:C2"].Font.Italic = true;
            exRange.Range["A2:C2"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A2:C2"].Value = "Nhân viên bán hàng";
            exRange.Range["A6:C6"].MergeCells = true;
            exRange.Range["A6:C6"].Font.Italic = true;
            exRange.Range["A6:C6"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A6:C6"].Value = tblThongtinHD.Rows[0][4];
            exSheet.Name = "Hóa Đơn Bán";
            exApp.Visible = true;
        }
    }
}