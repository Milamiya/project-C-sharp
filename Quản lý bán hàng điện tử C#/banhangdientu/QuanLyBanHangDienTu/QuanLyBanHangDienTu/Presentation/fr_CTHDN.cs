using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using QuanLyBanHangDienTu.Business.Component;
using QuanLyBanHangDienTu.Business.EntitiesClass;
using QuanLyBanHangDienTu.DataAccess;
using COMExcel = Microsoft.Office.Interop.Excel;

namespace QuanLyBanHangDienTu.Presentation
{
    public partial class fr_CTHDN : Form
    {
        public fr_CTHDN()
        {
            InitializeComponent();
        }
        E_tb_CTHDN thucthi = new E_tb_CTHDN();
        ConnectDB cn = new ConnectDB();
        EC_tb_CTHDN ck = new EC_tb_CTHDN();
        bool themmoi;
        int dong = 0;

        private string sohdn;
        public string SOHDN
        {
            get
            {
                return sohdn;
            }
            set
            {
                sohdn = value;
            }
        }

        public void setnull()
        {
            txtsl.Text = "0";
            txtdg.Text = "0";
            txtgg.Text = "0";
            txttt.Text = "0";
            cbhang.Text = "";
        }
        public void locktext()
        {
            txtsl.Enabled = false;
            txtdg.Enabled = false;
            txtgg.Enabled = false;
            cbhang.Enabled = false;

            btmoi.Enabled = true;
            btluu.Enabled = false;
            btsua.Enabled = true;
            btxoa.Enabled = true;
        }
        public void un_locktext()
        {
            txtsl.Enabled = true;
            txtdg.Enabled = true;
            txtgg.Enabled = true;
            cbhang.Enabled = true;

            btmoi.Enabled = false;
            btluu.Enabled = true;
            btsua.Enabled = false;
            btxoa.Enabled = false;
        }
        public void khoitaoluoi()
        {
            msds.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            msds.Columns[0].HeaderText = "Số HDN";
            msds.Columns[0].Frozen = true;
            msds.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            msds.Columns[0].Width = 100;
            msds.Columns[1].HeaderText = "Mã Hàng";
            msds.Columns[1].Width = 100;
            msds.Columns[2].HeaderText = "Số Lượng";
            msds.Columns[2].Width = 80;
            msds.Columns[3].HeaderText = "Đơn Giá";
            msds.Columns[3].Width = 80;
            msds.Columns[4].HeaderText = "Giảm Giá";
            msds.Columns[4].Width = 80;
            msds.Columns[5].HeaderText = "Thành Tiền";
            msds.Columns[5].Width = 80;
        }
        public void hienthi()
        {
            string sql = "SELECT sohdn, mahang, soluong, dongia, giamgia, thanhtien FROM tb_CTHDN";
            msds.DataSource = cn.taobang(sql);
            SqlConnection con = cn.getcon();
            con.Open();
            try
            {
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                con.Close();
            }
        }
        private void btmoi_Click(object sender, EventArgs e)
        {
            themmoi = true;
            un_locktext();
            setnull();
            string sql = "SELECT sohdn, mahang, soluong, dongia, giamgia, thanhtien FROM tb_CTHDN where sohdn='" + sohdn + "'";
            msds.DataSource = cn.taobang(sql);
            SqlConnection con = cn.getcon();
            con.Open();
            try
            {
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                con.Close();
            }
        }

        private void btluu_Click(object sender, EventArgs e)
        {
            if (cbhang.Text != "")
            {
                if (themmoi == true)
                {
                    try
                    {
                        float tt = (float.Parse(txtsl.Text) * float.Parse(txtdg.Text)) - float.Parse(txtgg.Text);

                        ck.SOHDN = cbhd.Text;
                        ck.MAHANG = cbhang.Text;
                        ck.SOLUONG = txtsl.Text;
                        ck.DONGIA = txtdg.Text;
                        ck.GIAMGIA = txtgg.Text;
                        ck.THANHTIEN = tt.ToString();

                        thucthi.themoicthdn(ck);
                        locktext();
                        hienthi();
                        MessageBox.Show("Đã Lưu Thành Công", "Chú Ý", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString(), "Chú Ý", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                    try
                    {
                        float tt = (float.Parse(txtsl.Text) * float.Parse(txtdg.Text)) - float.Parse(txtgg.Text);
                        ck.SOHDN = cbhd.Text;
                        ck.MAHANG = cbhang.Text;
                        ck.SOLUONG = txtsl.Text;
                        ck.DONGIA = txtdg.Text;
                        ck.GIAMGIA = txtgg.Text;
                        ck.THANHTIEN = tt.ToString();

                        thucthi.suacthdn(ck);
                        MessageBox.Show("Đã Sửa Thành Công Thành Công", "Chú Ý", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString(), "Chú Ý", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                float gn = float.Parse(txtdg.Text);
                float gb = (gn * 110) / 100;

                string upsl = "UPDATE tb_Hanghoa SET soluong =soluong + '" + txtsl.Text + "' where mahang='" + cbhang.Text + "'";
                string upsl1 = "UPDATE tb_Hanghoa SET dongianhap ='" + txtdg.Text + "' where mahang ='" + cbhang.Text + "'";
                string upsl2 = "UPDATE tb_Hanghoa SET dongiaban ='" + gb + "'where mahang='" + cbhang.Text + "'";
                string uptt = "update tb_HDN set tongtien=(SELECT sum(thanhtien) FROM tb_CTHDN) where sohdn='" + cbhd.Text + "'";
                cn.ExcuteNonQuery(uptt);
                cn.ExcuteNonQuery(upsl);
                cn.ExcuteNonQuery(upsl1);
                cn.ExcuteNonQuery(upsl2);
                locktext();
                hienthi();
                float t1 = (float.Parse(txtsl.Text) * float.Parse(txtdg.Text)) - float.Parse(txtgg.Text);
                txttt.Text = t1.ToString();
            }
            else
            {
                MessageBox.Show("Mã Không được để trống", "Chú Ý", MessageBoxButtons.OK);
                cbhang.Focus();
            }
        }

        private void btsua_Click(object sender, EventArgs e)
        {
            themmoi = false;
            un_locktext();
        }

        private void btxoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xóa dữ liệu này?", "Chú Ý", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    ck.SOHDN = cbhd.Text;
                    ck.MAHANG = cbhang.Text;

                    thucthi.xoacthdn(ck);
                    MessageBox.Show("Đã Xóa Thành Công", "Chú Ý", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    hienthi();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Lỗi");
                }
            }
        }
        private void msds_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dong = e.RowIndex;
            cbhd.Text = msds.Rows[dong].Cells[0].Value.ToString();
            cbhang.Text = msds.Rows[dong].Cells[1].Value.ToString();
            txtsl.Text = msds.Rows[dong].Cells[2].Value.ToString();
            txtdg.Text = msds.Rows[dong].Cells[3].Value.ToString();
            txtgg.Text = msds.Rows[dong].Cells[4].Value.ToString();
            txttt.Text = msds.Rows[dong].Cells[5].Value.ToString();
            locktext();
        }

        private void fr_CTHDN_Load(object sender, EventArgs e)
        {
            cbhd.Text = sohdn;
            thucthi.loadmahd(cbhd);
            thucthi.loadmasp(cbhang);
            hienthi();
            khoitaoluoi();
            locktext();
        }

        private void btquaylai_Click(object sender, EventArgs e)
        {
            fr_HDN fr = new fr_HDN();
            this.Close();
            fr.Show();
        }
        private void cbhang_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbhang.Text = thucthi.loadtensp(lbhang.Text, cbhang.Text);
        }

        private void txtsl_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtgg_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtdg_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
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
            exRange.Range["A1:B1"].Value = "E Store";
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
            sql = @"SELECT     tb_CTHDN.sohdn, tb_NCC.tenncc, tb_NCC.diachi, tb_NCC.dienthoai, tb_Nhanvien.tennv,tb_HDN.ngaynhap
                        FROM         tb_HDN INNER JOIN
                      tb_NCC ON tb_HDN.mancc = tb_NCC.mancc INNER JOIN
                      tb_CTHDN ON tb_HDN.sohdn = tb_CTHDN.sohdn INNER JOIN
                      tb_Nhanvien ON tb_HDN.manv = tb_Nhanvien.manv where tb_HDN.sohdn='" + cbhd.Text + "'";
            tblThongtinHD = cn.taobang(sql);
            exRange.Range["B6:C9"].Font.Size = 12;
            exRange.Range["B6:C9"].Font.Name = "Times new roman";
            exRange.Range["B6:B6"].Value = "Mã hóa đơn:";
            exRange.Range["C6:E6"].MergeCells = true;
            exRange.Range["C6:E6"].Value = tblThongtinHD.Rows[0][0].ToString();
            exRange.Range["B7:B7"].Value = "Nhà Cung Cấp:";
            exRange.Range["C7:E7"].MergeCells = true;
            exRange.Range["C7:E7"].Value = tblThongtinHD.Rows[0][1].ToString();
            exRange.Range["B8:B8"].Value = "Địa chỉ:";
            exRange.Range["C8:E8"].MergeCells = true;
            exRange.Range["C8:E8"].Value = tblThongtinHD.Rows[0][2].ToString();
            exRange.Range["B9:B9"].Value = "Điện thoại:";
            exRange.Range["C9:E9"].MergeCells = true;
            exRange.Range["C9:E9"].Value = tblThongtinHD.Rows[0][3].ToString();
            //Lấy thông tin các mặt hàng
            sql = @"SELECT    tb_Hanghoa.tenhang , tb_CTHDN.soluong, tb_CTHDN.dongia, tb_CTHDN.giamgia, tb_CTHDN.thanhtien
FROM         tb_CTHDN INNER JOIN
                      tb_Hanghoa ON tb_CTHDN.mahang = tb_Hanghoa.mahang where tb_CTHDN.sohdn='" + cbhd.Text + "'";
            tblThongtinHang = cn.taobang(sql);
            //Tạo dòng tiêu đề bảng
            exRange.Range["A11:F11"].Font.Bold = true;
            exRange.Range["A11:F11"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["C11:F11"].ColumnWidth = 12;
            exRange.Range["A11:A11"].Value = "STT";
            exRange.Range["B11:B11"].Value = "Tên hàng";
            exRange.Range["C11:C11"].Value = "Số lượng";
            exRange.Range["D11:D11"].Value = "Đơn giá";
            exRange.Range["E11:E11"].Value = "Giảm giá";
            exRange.Range["F11:F11"].Value = "Thành tiền";
            for (hang = 0; hang <= tblThongtinHang.Rows.Count - 1; hang++)
            {
                //Điền số thứ tự vào cột 1 từ dòng 12
                exSheet.Cells[1][hang + 12] = hang + 1;
                for (cot = 0; cot <= tblThongtinHang.Columns.Count - 1; cot++)
                    //Điền thông tin hàng từ cột thứ 2, dòng 12
                    exSheet.Cells[cot + 2][hang + 12] = tblThongtinHang.Rows[hang][cot].ToString();
            }
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
            exRange.Range["A2:C2"].Value = "Nhân viên Nhập hàng";
            exRange.Range["A6:C6"].MergeCells = true;
            exRange.Range["A6:C6"].Font.Italic = true;
            exRange.Range["A6:C6"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A6:C6"].Value = tblThongtinHD.Rows[0][4];
            exSheet.Name = "Hóa đơn Nhập";
            exApp.Visible = true;
        }
    }
}
