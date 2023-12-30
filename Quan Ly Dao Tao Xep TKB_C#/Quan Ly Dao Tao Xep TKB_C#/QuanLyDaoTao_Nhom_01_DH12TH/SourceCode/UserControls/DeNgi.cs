using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Drawing;
using System.Collections.ObjectModel;
using QuanLyDaoTao.Presentation;

namespace QuanLyDaoTao.UserControls
{
    public partial class TimeTableViewer : UserControl
    {
        public TimeTableViewer()
        {
            InitializeComponent();
            ngayDauTuan = new DateTime();
            buoiHocs = new Collection<BuoiHoc>();
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
                }
                else
                    throw new Exception("Ngày đầu tuần phải là thứ 2");
            }
        }
        private Collection<BuoiHoc> buoiHocs;
        private int[] XThu = { 0, 144, 287, 431, 575, 719, 863 };
        private int[] YTiet = { 0, 41, 82, 123, 164, 205, 246, 287, 328, 369 };
        Thu thu;

        public bool ThemBuoiHoc(Thu thu, int tietBD, int soTiet, string monHoc, string phong)
        {
            try
            {
			    if (tietBD < 0 || tietBD > 9)
                    throw new Exception("Tiết bắt đầu không hợp lệ.");
                if (soTiet < 1 || soTiet > 5)
                    throw new Exception("Số tiết không hợp lệ.");
                //kiem tra co trung ko
                foreach (BuoiHoc b in buoiHocs)
                {
                    if (b.Ngay == ngayDauTuan.AddDays((int)thu) && tietBD < (b.SoTiet + b.TietDB))
                        return false;
                }
                switch (soTiet)
                {
                    case 1:
                        MotTiet motTiet = new MotTiet();
                        motTiet.PhongHoc = phong;
                        motTiet.MonHoc = monHoc;
                        motTiet.Location = new Point(XThu[(int)thu], YTiet[tietBD]);
                        pnChinh.Controls.Add(motTiet);
                        motTiet.BringToFront();
                        break;
                    case 2:
                        HaiTiet haiTiet = new HaiTiet();
                        haiTiet.PhongHoc = phong;
                        haiTiet.MonHoc = monHoc;
                        haiTiet.Location = new Point(XThu[(int)thu], YTiet[tietBD]);
                        pnChinh.Controls.Add(haiTiet);
                        haiTiet.BringToFront();
                        break;
                    case 3:
                        BaTiet baTiet = new BaTiet();
                        baTiet.PhongHoc = phong;
                        baTiet.MonHoc = monHoc;
                        baTiet.Location = new Point(XThu[(int)thu], YTiet[tietBD]);
                        pnChinh.Controls.Add(baTiet);
                        baTiet.BringToFront();
                        break;
                    case 4:
                        BonTiet bonTiet = new BonTiet();
                        bonTiet.PhongHoc = phong;
                        bonTiet.MonHoc = monHoc;
                        bonTiet.Location = new Point(XThu[(int)thu], YTiet[tietBD]);
                        pnChinh.Controls.Add(bonTiet);
                        bonTiet.BringToFront();
                        break;
                    case 5:
                        NamTiet namTiet = new NamTiet();
                        namTiet.PhongHoc = phong;
                        namTiet.MonHoc = monHoc;
                        namTiet.Location = new Point(XThu[(int)thu], YTiet[tietBD]);
                        pnChinh.Controls.Add(namTiet);
                        namTiet.BringToFront();
                        break;
                }
                buoiHocs.Add(new BuoiHoc() { Ngay = ngayDauTuan.AddDays((int)thu), SoTiet = soTiet, TietDB = tietBD });
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void lblThu2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                string lbl = ((LinkLabel)sender).Name;
                if (lbl == "lbl0")
                    thu = Thu.Thu2;
                else if (lbl == "lbl1")
                    thu = Thu.Thu3;
                else if (lbl == "lbl2")
                    thu = Thu.Thu4;
                else if (lbl == "lbl3")
                    thu = Thu.Thu5;
                else if (lbl == "lbl4")
                    thu = Thu.Thu6;
                else if (lbl == "lbl5")
                    thu = Thu.Thu7;
                else
                    thu = Thu.ChuNhat;

                frmInput frm = new frmInput();
                frm.Text = thu.ToString();
                frm.truyen += new frmInput.TruyenMatKhau(NhanDuLieu);
                frm.ShowDialog();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private bool NhanDuLieu(int tietBD, int soTiet, string monHoc, string phong)
        {
            return ThemBuoiHoc(thu, tietBD, soTiet, monHoc, phong);
        }
    }

    public class BuoiHoc
    {
        DateTime ngay;

        public DateTime Ngay
        {
            get { return ngay; }
            set { ngay = value; }
        }
        int tietDB;

        public int TietDB
        {
            get { return tietDB; }
            set { tietDB = value; }
        }
        int soTiet;

        public int SoTiet
        {
            get { return soTiet; }
            set { soTiet = value; }
        }

        public BuoiHoc()
        {
            ngay = new DateTime();
            tietDB = 0;
            soTiet = 0;
        }
    }

    public enum Thu
    {
        Thu2 = 0,
        Thu3 = 1,
        Thu4 = 2,
        Thu5 = 3,
        Thu6 = 4,
        Thu7 = 5,
        ChuNhat = 6
    }
}
