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
    public partial class HoaDonNhap : Form
    {
        public HoaDonNhap()
        {
            InitializeComponent();
        }
        DataTable tblChiTietHDN;
        private void HoaDonNhap_Load(object sender, EventArgs e)
        {
            btnThem.Enabled = true;
            btnLuu.Enabled = false;
            btnXoa.Enabled = false;
            btnIn.Enabled = false;
            txtMaHD.ReadOnly = true;
            txtTenhanghoa.ReadOnly = true;
            txtDongianhap.ReadOnly = true;
            txtSoluong.ReadOnly = true;
            txtGiamgia.Text = "0" ;
            txtThanhtien.ReadOnly = true;
            txtTongtien.Text = "0";

            Data.FillCombo("SELECT Manhanvien,Tennhanvien FROM tblNhanVien", cboManhanvien, "Manhanvien", "Tennhanvien");
            cboManhanvien.SelectedIndex = -1;
            Data.FillCombo("SELECT Manhacungcap,Tennhacungcap FROM NhaCungCap", cboManhacungcap, "Manhacungcap", "Tennhacungcap");
            cboManhacungcap.SelectedIndex = -1;

            //Hiển thị thông tin chi tiết của một hóa đơn đc gọi từ form tìm kiếm
            if (txtMaHD.Text != "")
            {
                Load_ThongTinHD();
                btnXoa.Enabled = true;
                btnIn.Enabled = true;
            }
            Load_DataGridView();
        }

        private void Load_DataGridView()
        {
            string sql = "SELECT a.Tennhacungcap,b.Tenhanghoa,a.Soluong, b.Dongianhap,a.Giamgia,a.Thanhtien FROM tblChiTietHDN AS a, tblDMHangHoa AS b WHERE a.Sohoadonnhap=N'" + txtMaHD.Text + "'AND a.Tennhacungcap=b.Tennhacungcap";
            tblChiTietHDN = Data.GetDataToTable(sql);
            dgvNhapHang.DataSource = tblChiTietHDN;
            dgvNhapHang.Columns[0].HeaderText = "Mã vạch";
            dgvNhapHang.Columns[0].HeaderText="Tên hàng";
            dgvNhapHang.Columns[0].HeaderText="Số lượng";
            dgvNhapHang.Columns[0].HeaderText="Đơn giá:";
            dgvNhapHang.Columns[0].HeaderText="Giảm giá %";
            dgvNhapHang.Columns[0].HeaderText = "Thành tiền";
            dgvNhapHang.Columns[0].Width=150;
            dgvNhapHang.Columns[0].Width=250;
            dgvNhapHang.Columns[0].Width=150;
            dgvNhapHang.Columns[0].Width=150;
            dgvNhapHang.Columns[0].Width = 150;
            dgvNhapHang.Columns[0].Width = 150;
            dgvNhapHang.AllowUserToAddRows=false;
            dgvNhapHang.EditMode=DataGridViewEditMode.EditProgrammatically;
        }

        private void Load_ThongTinHD()
        {
            string str = "SELECT Ngaynhap FROM tblHDN WHERE Sohoadonnhap=N'" + txtMaHD.Text + "'";
            txtNgay.Text = Data.ConvertDateTime(Data.GetFieldValues(str));
            str = "SELECT Manhanvien FROM tblHDN WHERE Sohoadonnhap =N '" + txtMaHD.Text + "'";
            cboManhanvien.Text = Data.GetFieldValues(str);
            str = "SELECT Manhacungcap FROM tblHDN WHERE Sohoadonnhap=N'" + txtMaHD.Text + "'";
            cboManhacungcap.Text = Data.GetFieldValues(str);
            str = "SELECT Tongtien FROM tblHDN WHERE Sohoadonnhap=N'" + txtMaHD.Text + "'";
            txtTongtien.Text = Data.GetFieldValues(str);
            lblBangchu.Text = "Bằng chữ: " + Data.ChuyenSoSangChu(txtTongtien.Text);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            btnXoa.Enabled = false;
            btnIn.Enabled = false;
            btnThem.Enabled = false;
            btnLuu.Enabled = true;
            ResetValues();
            txtMaHD.Text = Data.CreateKey("HDN");
            Load_DataGridView();
        }

        private void ResetValues()
        {
            txtMaHD.Text = "";
            txtNgay.Text = DateTime.Now.ToShortDateString();
            cboManhanvien.Text = "";
            cboManhacungcap.Text = "";
            txtTongtien.Text = "0";
            lblBangchu.Text = "Bằng chữ:";
            txtTennhacungcap.Text = "";
            txtSoluong.Text = "";
            txtGiamgia.Text = "0";
            txtThanhtien.Text = "0";
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql = "SELECT Sohoadonnhap FROM tblHDN WHERE Sohoadonnhap=N'" + txtMaHD.Text + "'";
            double sl, SLcon, tong, TongMoi;
            if(! Data.Checkey(sql))
            {
                //Mã hóa đơn chưa có, tiến hành lưu các thông tin chung
                //Mã HDN đc sinh ra tự động nên ko có trường hợp trùng khóa
                if(txtNgay.Text.Length==0)
                {
                    MessageBox.Show("Bạn phải nhập ngày nhập hàng!","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    txtNgay.Focus();
                    return;
                }

                if(cboManhanvien.Text.Length==0)
                {
                    MessageBox.Show("Bạn phải nhập nhân viên","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    cboManhanvien.Focus();
                    return;
                }
                if(cboManhacungcap.Text.Length==0)
                {
                    MessageBox.Show("Bạn phải nhập nhà cung cấp!","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    cboManhacungcap.Focus();
                    return;
                }
                sql="INSERT INTO HoaDonNhap(Sohoadonnhap,Manhanvien,NgayNhap,Manhacungcap,Tongtien)VALUES (N'"+txtMaHD.Text.Trim()+"',N'"+cboManhanvien.Text.ToString()+"','"+Data.ConvertDateTime(txtNgay.Text.Trim())+"',N'"+cboManhacungcap.Text.Trim()+"',"+txtTongtien.Text+")";
                Data.RunSql(sql);
            }
            //luu thong tin cac mat hang

            if(txtTennhacungcap.Text.Trim().Length==0)
            {
                MessageBox.Show("Bạn phải nhập mã hàng!","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
                txtTennhacungcap.Focus();
                return;
            }
            if(txtSoluong.Text.Trim().Length==0)
            {
                MessageBox.Show("Bạn phải nhập số lượng!","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
                txtSoluong.Text="";
                txtSoluong.Focus();
                return;
            }
            if(txtGiamgia.Text.Trim().Length==0)
            {
                MessageBox.Show("Bạn phải nhập giảm giá!","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
                txtGiamgia.Focus();
                return;
            }

            sql="SELECT Tennhacungcap FROM tblChiTietHDN WHERE Tennhacungcap =N'"+txtTennhacungcap.Text+"' AND Sohoadonnhap=N'"+txtMaHD.Text.Trim()+"'";

            if(Data.Checkey(sql))
            {
                MessageBox.Show("Mã hàng này đã có,bạn phải nhập mã khác!","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
                ResetValuesHang();
                txtTennhacungcap.Focus();
                return;
            }

           sl=Convert.ToDouble(Data.GetFieldValues("SELECT Soluong FROM tblDMHangHoa WHERE Tennhacungcap=N'"+txtTennhacungcap.Text+"'"));
            sql="INSERT INTO tblChiTietHDN(Sohoadonnhap,Tennhacungcap,Soluong,Giamgia,Thanhtien)VALUES (N'"+txtMaHD.Text.Trim()+"',N'"+txtTennhacungcap.Text.ToString()+"',N'"+txtSoluong.Text+","+txtGiamgia.Text+","+txtThanhtien.Text+")";
            Data.RunSql(sql);
            Load_DataGridView();

            //Cập nhật lại số lượng của mặt hàng vào bảng HangHoa

            SLcon=sl-Convert.ToDouble(txtSoluong.Text);
            sql="UPDATE tblDMHangHoa SET Soluong="+SLcon+"WHERE Tennhacungcap=N'"+txtTennhacungcap.Text+"'";
            Data.RunSql(sql);

            //Cập nhật tổng tiền cho HDN

            tong =Convert.ToDouble(Data.GetFieldValues("SELECT Tongtien FROM tblHDN WHERE Sohoadonnhap=N'"+txtMaHD.Text+"'"));
            TongMoi=tong+Convert.ToDouble(txtThanhtien.Text);
            sql="UPDATE tblHDN SET Tongtien="+TongMoi+"WHERE Sohoadonnhap=N'"+txtMaHD.Text+"'";
            Data.RunSql(sql);
            txtTongtien.Text=TongMoi.ToString();
            lblBangchu.Text="Bằng chữ: "+Data.ChuyenSoSangChu(TongMoi.ToString());
            ResetValuesHang();
            btnXoa.Enabled=true;
            btnIn.Enabled=true;
            btnThem.Enabled=true;
        }

        private void ResetValuesHang()
        {
            txtTennhacungcap.Text = "";
            txtSoluong.Text = "";
            txtGiamgia.Text = "0";
            txtThanhtien.Text = "0";
        }

        private void dgvNhapHang_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
            //cho phép người dùng kích đúp vào 1 mặt hàng trong lưới để xóa

        {
            string mahang;
            Double Thanhtien;
            if(tblChiTietHDN.Rows.Count==0)
            {
                MessageBox.Show("Không có dữ liệu!","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
                return;
            }

            if((MessageBox.Show("Bạn có chắc chắn muốn xóa không?","Thông báo",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes))
            {
                //xóa hàng và cập nhật lại số lượng hàng
                mahang=dgvNhapHang.CurrentRow.Cells["Tennhacungcap"].Value.ToString();
                DelHang(txtMaHD.Text,mahang);

                //Cập nhật lại tổng tiền cho hóa đơn nhập
                Thanhtien=Convert.ToDouble(dgvNhapHang.CurrentRow.Cells["Thanhtien"].Value.ToString());
                DelUpdateTongtien(txtMaHD.Text,Thanhtien);
                Load_DataGridView();
            }
        }

        public void DelHang(string MaHoaDon, string Tennhacungcap)
        {
            Double s, sl, Slcon;
            string sql = "SELECT Soluong FROM tblChiTietHDN WHERE Sohoadonnhap=N'" + MaHoaDon + "' AND Tennhacungcap=N'" + Tennhacungcap + "'";
            s = Convert.ToDouble(Data.GetFieldValues(sql));
            sql = "DELETE tblChiTietHDN WHERE Sohoadonnhap=N'" + MaHoaDon + "' AND Tennhacungcap =N'" + Tennhacungcap + "'";
            Data.RunSqlDel(sql);

            //Cập nhật lại số lượng cho các mặt hàng
            sql = "SELECT Soluong FROM tblDMHangHoa WHERE Tennhacungcap=N'" + Tennhacungcap + "'";
            sl = Convert.ToDouble(Data.GetFieldValues(sql));
            Slcon = sl + s;
            sql = "UPDATE tblDMHangHoa SET Soluong=" + Slcon + "WHERE Tennhacungcap =N'" + Tennhacungcap + "'";
            Data.RunSql(sql);

        }

        public void DelUpdateTongtien(string MaHoaDon, double Thanhtien)
        {
            Double tong, tongmoi;
            string sql = "SELECT Tongtien FROM tblHDN WHERE Sohoadonnhap=N'" + MaHoaDon + "'";
            tong = Convert.ToDouble(Data.GetFieldValues(sql));
            tongmoi = tong - Thanhtien;
            sql = "UPDATE tblHDN SET Tongtien=" + tongmoi + "WHERE Sohoadonnhap+N'" + MaHoaDon + "'";
            Data.RunSql(sql);
            txtTongtien.Text = tongmoi.ToString();
            lblBangchu.Text = "Bằng chữ: " + Data.ChuyenSoSangChu(tongmoi.ToString());

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string[] Tennhacungcap = new String[20];
                string sql;
                int n = 0;
                int i;
                sql = "SELECT Tennhacungcap FROM tblChiTietHDN WHERE Sohoadonnhap=N'" + txtMaHD.Text + "'";
                SqlCommand cmd = new SqlCommand(sql, Data.Conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Tennhacungcap[n] = reader.GetString(0).ToString();
                    n = n + 1;
                }
                reader.Close();
                //xóa danh sách các mặt hàng của hóa đơn
                for (i = 0; i <= n - 1; i++)
                {
                    DelHang(txtMaHD.Text, Tennhacungcap[i]);
                    //Xóa hóa đơn
                    sql = "DELETE tblHDN WHERE Sohoadonnhap ='" + txtMaHD.Text + "'";
                    Data.RunSqlDel(sql);
                    ResetValues();
                    Load_DataGridView();
                    btnXoa.Enabled = false;
                    btnIn.Enabled = false;
                }
            }
        }

        private void txtTennhacungcap_TextChanged(object sender, EventArgs e)
        {
            string str;
            if (txtTennhacungcap.Text == "")
            {
                txtTenhanghoa.Text = "";
                txtDongianhap.Text = "";
            }
            //khi kích chọn mã hàng thì tên hàng và đơn giá sẽ tự động hiện ra
            str = "SELECT Tenhanghoa FROM tblDMHangHoa WHERE Tennhacungcap=N'" + txtTennhacungcap.Text + "'";
            txtTenhanghoa.Text = Data.GetFieldValues(str);
            str = "SELECT Dongianhap FROM tblDMHangHoa WHERE Tennhacungcap=N'" + txtTennhacungcap.Text + "'";
            txtDongianhap.Text = Data.GetFieldValues(str);
        }

        private void txtSoluong_TextChanged(object sender, EventArgs e)
        {
            //khi thay đổi số lượng, giảm giá thì thành tiền tự động cập nhật lại giá trị
            double tt, sl, dg, gg;
            if (txtSoluong.Text == "")
                sl = 0;
            else
                sl = Convert.ToDouble(txtSoluong.Text);
            if (txtGiamgia.Text == "")
                gg = 0;
            else
                gg = Convert.ToDouble(txtGiamgia.Text);
            if (txtDongianhap.Text == "")
                dg = 0;
            else
                dg = Convert.ToDouble(txtDongianhap.Text);
            tt = sl * dg - sl * dg * gg / 100;
            txtThanhtien.Text = tt.ToString();

        }

        private void txtGiamgia_TextChanged(object sender, EventArgs e)
        {
            //Khi thay đổi số lượng, giám giá thì thành tiền tự động cập nhật lại giá trị
            double tt, sl, dg, gg;
            if (txtSoluong.Text == "")
                sl = 0;
            else
                sl = Convert.ToDouble(txtSoluong.Text);
            if (txtGiamgia.Text == "")
                gg = 0;
            else
                gg = Convert.ToDouble(txtGiamgia.Text);
            if (txtDongianhap.Text == "")
                dg = 0;
            else
                dg = Convert.ToDouble(txtDongianhap.Text);
            tt = sl * dg - sl * dg * gg / 100;
            txtThanhtien.Text = tt.ToString();

        }

        private void cboMaHDN_DropDown(object sender, EventArgs e)
        {
            Data.FillCombo("SELECT Sohoadonnhap FROM tblHDN", cboMahoadon, "Sohoadonnhap", "Sohoadonnhap");
            cboMahoadon.SelectedIndex = -1;
        }

        private void txtSoluong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar >= '0') && (e.KeyChar <= '9')) || (Convert.ToInt32(e.KeyChar) == 8))
                e.Handled = true;
            else
                e.Handled = false;
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if(cboMahoadon.Text=="")
            {
                MessageBox.Show("Bạn phải chọn một mã hóa đơn để tìm!","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                cboMahoadon.Focus();
                return;
            }
            txtMaHD.Text = cboMahoadon.Text;
            Load_ThongTinHD();
            Load_DataGridView();
            btnXoa.Enabled = true;
            btnLuu.Enabled = true;
            btnIn.Enabled = true;
            cboMahoadon.SelectedIndex = -1;

        }

        private void btnIn_Click(object sender, EventArgs e)
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
            exRange.Range["C2:E2"].Value = "HÓA ĐƠN NHẬP";
            // Biểu diễn thông tin chung của hóa đơn bán
            sql = @"SELECT     tblHDN.Sohoadonnhap, NhaCungCap.Tennhacungcap, NhaCungCap.Diachi, NhaCungCap.Dienthoai, tblNhanVien.Tennhanvien, tblHDN.Ngaynhap
FROM         NhaCungCap INNER JOIN
                      tblHDN ON NhaCungCap.Manhacungcap = tblHDN.Manhacungcap INNER JOIN
                      tblNhanVien ON tblHDN.Manhanvien = tblNhanVien.Manhanvien where  tblHDN.Sohoadonnhap='" + txtMaHD.Text + "'";
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
            sql = @"SELECT     tblDMHangHoa.Tenhanghoa, tblChiTietHDN.Soluong, tblChiTietHDN.Dongia, tblChiTietHDN.Giamgia, tblChiTietHDN.Thanhtien
FROM         tblDMHangHoa INNER JOIN
                      tblChiTietHDN ON tblDMHangHoa.Mavach = tblChiTietHDN.Mavach
                       where tblHDN.Sohoadonnhap='" + txtMaHD.Text + "'";
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
            exRange.Range["A2:C2"].Value = "Nhân viên nhập hàng";
            exRange.Range["A6:C6"].MergeCells = true;
            exRange.Range["A6:C6"].Font.Italic = true;
            exRange.Range["A6:C6"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A6:C6"].Value = tblThongtinHD.Rows[0][4];
            exSheet.Name = "Hóa Đơn Nhập";
            exApp.Visible = true;
        }

        
    }
}
