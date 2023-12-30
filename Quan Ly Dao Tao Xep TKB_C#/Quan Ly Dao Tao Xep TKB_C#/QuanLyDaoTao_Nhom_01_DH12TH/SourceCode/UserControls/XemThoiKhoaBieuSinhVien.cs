using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Drawing;
using System.Collections.ObjectModel;
using QuanLyDaoTao.Enums;
using QuanLyDaoTao.DataAccess;
using QuanLyDaoTao.Business;
using DevExpress.Utils;

namespace QuanLyDaoTao.UserControls
{
    public partial class XemThoiKhoaBieuSinhVien : UserControl
    {
        public XemThoiKhoaBieuSinhVien()
        {
            try
            {
                InitializeComponent();
                mssv = string.Empty;
                ngayDauTuan = new DateTime();
                TKBs = new Collection<sp_XemTKBSinhVienResult>();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private string mssv;

        public string MSSV
        {
            get { return mssv; }
            set
            {
                mssv = value;
                if (!string.IsNullOrEmpty(value))
                {
                    TKBs.Clear();
                    TKBs = ThoiKhoaBieuBUS.SinhVienXemTKB(mssv, ngayDauTuan);
                    ThoiKhoaBieu_Load(null, null);
                }
            }
        }

        private DateTime ngayDauTuan;

        public DateTime NgayDauTuan
        {
            get { return ngayDauTuan; }
            set
            {
                if (value.DayOfWeek == DayOfWeek.Monday)
                {
                    ngayDauTuan = value;
                    lbl0.Text = "Thứ 2\n" + ngayDauTuan.ToString("dd/MM/yyyy");
                    ngayDauTuan = ngayDauTuan.AddDays(1);
                    lbl1.Text = "Thứ 3\n" + ngayDauTuan.ToString("dd/MM/yyyy");
                    ngayDauTuan = ngayDauTuan.AddDays(1);
                    lbl2.Text = "Thứ 4\n" + ngayDauTuan.ToString("dd/MM/yyyy");
                    ngayDauTuan = ngayDauTuan.AddDays(1);
                    lbl3.Text = "Thứ 5\n" + ngayDauTuan.ToString("dd/MM/yyyy");
                    ngayDauTuan = ngayDauTuan.AddDays(1);
                    lbl4.Text = "Thứ 6\n" + ngayDauTuan.ToString("dd/MM/yyyy");
                    ngayDauTuan = ngayDauTuan.AddDays(1);
                    lbl5.Text = "Thứ 7\n" + ngayDauTuan.ToString("dd/MM/yyyy");
                    ngayDauTuan = ngayDauTuan.AddDays(1);
                    lbl6.Text = "Chủ nhật\n" + ngayDauTuan.ToString("dd/MM/yyyy");
                    ngayDauTuan = ngayDauTuan.AddDays(-6);
                    if (value != (new DateTime()))
                    {
                        TKBs.Clear();
                        TKBs = ThoiKhoaBieuBUS.SinhVienXemTKB(mssv, ngayDauTuan);
                        ThoiKhoaBieu_Load(null, null);
                    }
                }
                else
                    throw new Exception("Ngày đầu tuần phải là thứ 2");
            }
        }

        /// <summary>
        /// Các thời khóa biểu đã được xếp
        /// </summary>
        public Collection<sp_XemTKBSinhVienResult> TKBs;

        private int[] XThu = { 0, 144, 287, 431, 575, 719, 863 };
        private int[] YTiet = { 0, 41, 82, 123, 164, 205, 246, 287, 328, 369 };

        //mode == 2: thời khóa biểu đã lưu vào CSDL rồi
        private new void Paint(string maPC, int maBuoiHoc, int thu, int tietBD, int soTiet, string monHoc, string giangVien, string lop, int mode, string diaChi)
        {
            try
            {
                switch (soTiet)
                {
                    case 1:
                        MotTiet motTiet = new MotTiet();
                        motTiet.PhongHoc = lop;
                        motTiet.MonHoc = monHoc;
                        motTiet.Location = new Point(XThu[thu], YTiet[tietBD]);
                        motTiet.BackColor = Color.Gold;
                        ThongTinChiTietTKB(motTiet.lblMonHoc, motTiet.toolTipController1, monHoc, tietBD, soTiet, giangVien, lop, diaChi);
                        motTiet.lblMonHoc.Cursor = Cursors.Hand;
                        motTiet.Name = "1" + ngayDauTuan.AddDays((int)thu).ToString("dd/MM/yyyy") + tietBD.ToString() + soTiet.ToString() + mode.ToString() + maPC + maBuoiHoc.ToString();
                        pnChinh.Controls.Add(motTiet);
                        motTiet.BringToFront();
                        break;
                    case 2:
                        HaiTiet haiTiet = new HaiTiet();
                        haiTiet.PhongHoc = lop;
                        haiTiet.MonHoc = monHoc;
                        haiTiet.Location = new Point(XThu[thu], YTiet[tietBD]);
                        haiTiet.BackColor = Color.Gold;
                        ThongTinChiTietTKB(haiTiet.lblMonHoc, haiTiet.toolTipController1, monHoc, tietBD, soTiet, giangVien, lop, diaChi);
                        haiTiet.lblMonHoc.Cursor = Cursors.Hand;
                        haiTiet.Name = "2" + ngayDauTuan.AddDays((int)thu).ToString("dd/MM/yyyy") + tietBD.ToString() + soTiet.ToString() + mode.ToString() + maPC + maBuoiHoc.ToString();
                        pnChinh.Controls.Add(haiTiet);
                        haiTiet.BringToFront();
                        break;
                    case 3:
                        BaTiet baTiet = new BaTiet();
                        baTiet.PhongHoc = lop;
                        baTiet.MonHoc = monHoc;
                        baTiet.Location = new Point(XThu[thu], YTiet[tietBD]);
                        baTiet.BackColor = Color.Gold;
                        ThongTinChiTietTKB(baTiet.lblMonHoc, baTiet.toolTipController1, monHoc, tietBD, soTiet, giangVien, lop, diaChi);
                        baTiet.lblMonHoc.Cursor = Cursors.Hand;
                        baTiet.Name = "3" + ngayDauTuan.AddDays((int)thu).ToString("dd/MM/yyyy") + tietBD.ToString() + soTiet.ToString() + mode.ToString() + maPC + maBuoiHoc.ToString();
                        pnChinh.Controls.Add(baTiet);
                        baTiet.BringToFront();
                        break;
                    case 4:
                        BonTiet bonTiet = new BonTiet();
                        bonTiet.PhongHoc = lop;
                        bonTiet.MonHoc = monHoc;
                        bonTiet.Location = new Point(XThu[thu], YTiet[tietBD]);
                        bonTiet.BackColor = Color.Gold;
                        ThongTinChiTietTKB(bonTiet.lblMonHoc, bonTiet.toolTipController1, monHoc, tietBD, soTiet, giangVien, lop, diaChi);
                        bonTiet.lblMonHoc.Cursor = Cursors.Hand;
                        bonTiet.Name = "4" + ngayDauTuan.AddDays((int)thu).ToString("dd/MM/yyyy") + tietBD.ToString() + soTiet.ToString() + mode.ToString() + maPC + maBuoiHoc.ToString();
                        pnChinh.Controls.Add(bonTiet);
                        bonTiet.BringToFront();
                        break;
                    case 5:
                        NamTiet namTiet = new NamTiet();
                        namTiet.PhongHoc = lop;
                        namTiet.MonHoc = monHoc;
                        namTiet.Location = new Point(XThu[thu], YTiet[tietBD]);
                        namTiet.BackColor = Color.Gold;
                        ThongTinChiTietTKB(namTiet.lblMonHoc, namTiet.toolTipController1, monHoc, tietBD, soTiet, giangVien, lop, diaChi);
                        namTiet.lblMonHoc.Cursor = Cursors.Hand;
                        namTiet.Name = "5" + ngayDauTuan.AddDays((int)thu).ToString("dd/MM/yyyy") + tietBD.ToString() + soTiet.ToString() + mode.ToString() + maPC + maBuoiHoc.ToString();
                        pnChinh.Controls.Add(namTiet);
                        namTiet.BringToFront();
                        break;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void ThoiKhoaBieu_Load(object sender, EventArgs e)
        {
            try
            {
                Clear();

                #region Vẽ các thời khóa biểu đã xếp
                foreach (sp_XemTKBSinhVienResult t in TKBs)
                {
                    Thu th = Thu.Thu2;
                    switch (t.Ngay.DayOfWeek)
                    {
                        case DayOfWeek.Monday:
                            th = Thu.Thu2;
                            break;
                        case DayOfWeek.Tuesday:
                            th = Thu.Thu3;
                            break;
                        case DayOfWeek.Wednesday:
                            th = Thu.Thu4;
                            break;
                        case DayOfWeek.Thursday:
                            th = Thu.Thu5;
                            break;
                        case DayOfWeek.Friday:
                            th = Thu.Thu6;
                            break;
                        case DayOfWeek.Saturday:
                            th = Thu.Thu7;
                            break;
                        case DayOfWeek.Sunday:
                            th = Thu.ChuNhat;
                            break;
                    }
                    Paint(t.MaPC, t.BuoiHoc, (int)th, t.TietBatDau, t.SoTiet, t.TenMH, t.TenGV, t.MaPhong, 2, t.DiaChi);
                }
                #endregion
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void Clear()
        {
            try
            {
                while (pnChinh.Controls.Count > 19)
                {
                    foreach (Control x in pnChinh.Controls)
                    {
                        if (x is UserControl)
                            pnChinh.Controls.Remove(x);
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void ThongTinChiTietTKB(Label lbl, ToolTipController toolTipController1, string tenMH, int tietBD, int soTiet, string tenGV, string phongHoc, string diaChi)
        {
            try
            {
                SuperToolTip superToolTip1 = new SuperToolTip();

                ToolTipTitleItem toolTipTitleItem1 = new ToolTipTitleItem();
                toolTipTitleItem1.Appearance.Image = global::QuanLyDaoTao.Properties.Resources.non_32;
                toolTipTitleItem1.Appearance.Options.UseImage = true;
                toolTipTitleItem1.Image = global::QuanLyDaoTao.Properties.Resources.non_32;
                toolTipTitleItem1.Text = "Thông tin chi tiết thời khóa biểu";

                ToolTipItem toolTipItem1 = new ToolTipItem();
                toolTipItem1.LeftIndent = 6;
                toolTipItem1.Text += "Tên môn học: " + tenMH;
                toolTipItem1.Text += "\nTiết bắt đầu: " + (tietBD + 1).ToString();
                toolTipItem1.Text += "\nSố tiết: " + soTiet.ToString();
                toolTipItem1.Text += "\nGiảng viên: " + tenGV;
                toolTipItem1.Text += "\nPhòng học: " + phongHoc;
                toolTipItem1.Text += "\nĐịa chỉ: " + diaChi;

                ToolTipTitleItem toolTipTitleItem2 = new ToolTipTitleItem();
                toolTipTitleItem2.LeftIndent = 6;
                toolTipTitleItem2.Text = "Hệ thống quản lý đào tạo";
                superToolTip1.Items.Add(toolTipTitleItem1);
                superToolTip1.Items.Add(toolTipItem1);

                ToolTipSeparatorItem toolTipSeparatorItem1 = new ToolTipSeparatorItem();
                superToolTip1.Items.Add(toolTipSeparatorItem1);
                superToolTip1.Items.Add(toolTipTitleItem2);

                toolTipController1.SetSuperTip(lbl, superToolTip1);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
