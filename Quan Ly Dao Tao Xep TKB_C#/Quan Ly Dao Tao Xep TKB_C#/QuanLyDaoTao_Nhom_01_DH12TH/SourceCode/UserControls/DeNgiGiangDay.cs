using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Drawing;
using System.Collections.ObjectModel;
using QuanLyDaoTao.Presentation;
using QuanLyDaoTao.Enums;
using QuanLyDaoTao.Business;
using QuanLyDaoTao.DataAccess;
using QuanLyDaoTao.Utilities;
using System.Data.Linq;

namespace QuanLyDaoTao.UserControls
{
    public partial class DeNgiGiangDay : UserControl
    {
        string maGV;

        public string MaGV
        {
            get { return maGV; }
            set
            {
                maGV = value;
                if (!string.IsNullOrEmpty(value))
                {
                    deNghis.Clear();
                    deNghis = DeNghiBUS.DanhSachDeNgiTheoTuan(value, ngayDauTuan);
                    DeNgiGiangDay_Load(null, null);
                }
            }
        }

        int namHoc;

        public int NamHoc
        {
            get { return namHoc; }
            set { namHoc = value; }
        }

        int hocKy;

        public int HocKy
        {
            get { return hocKy; }
            set { hocKy = value; }
        }

        public DeNgiGiangDay()
        {
            InitializeComponent();
            ngayDauTuan = new DateTime();
            buoiHocs = new Collection<BuoiHoc>();
            deNghis = new Collection<DeNghi>();
            maGV = string.Empty;
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
                    if (value != (new DateTime()) || value != null)
                    {
                        buoiHocs.Clear();
                        buoiHocs = BuoiHocBUS.DanhSachBuoiHocTheoTuan(value);
                    }
                    if (!string.IsNullOrEmpty(maGV))
                    {
                        deNghis.Clear();
                        deNghis = DeNghiBUS.DanhSachDeNgiTheoTuan(maGV, value);
                        DeNgiGiangDay_Load(null, null);
                    }
                }
                else
                    throw new Exception("Ngày đầu tuần phải là thứ 2");
            }
        }

        public Collection<BuoiHoc> buoiHocs;

        public Collection<DeNghi> deNghis;

        private int[] XThu = { 0, 144, 287, 431, 575, 719, 863 };
        private int[] YTiet = { 0, 41, 82, 123, 164, 205, 246, 287, 328, 369 };

        Thu thu;

        public bool ThemBuoiHoc(Thu thu, int tietBD, int soTiet, string monHoc, string lop, string maPC)
        {
            try
            {

                if (tietBD < 0 || tietBD > 9)
                    throw new Exception("Tiết bắt đầu không hợp lệ.");
                if (soTiet < 1 || soTiet > 5)
                    throw new Exception("Số tiết không hợp lệ.");

                int idBuoiHoc = idBuoiHoc = BuoiHocBUS.LayMaCuoiCung() + 1;

                //kiem tra co ton tai buoi hoc chua
                bool tonTaiBuoiHoc = false;

                foreach (BuoiHoc b in buoiHocs)
                {
                    if (b.Ngay == ngayDauTuan.AddDays((int)thu) && b.TietBatDau == tietBD && b.SoTiet == soTiet)
                    {
                        idBuoiHoc = b.BuoiHoc1;
                        tonTaiBuoiHoc = true;
                        if (deNghis.Any(i => i.MaPC == maPC && i.BuoiHoc == idBuoiHoc))
                        {
                            MsgboxUtil.Exclamation("Đã tồn tại một đề nghị như thế này rồi.");
                            return false;
                        }
                    }
                }

                //them buoi hoc
                if (!tonTaiBuoiHoc)//neu chua ton tai buoi hoc
                    buoiHocs.Add(new BuoiHoc() { BuoiHoc1 = idBuoiHoc, Ngay = ngayDauTuan.AddDays((int)thu), SoTiet = (byte)soTiet, TietBatDau = (byte)tietBD });

                //kiểm tra không cho trùng
                int tietKT = tietBD + soTiet - 1;
                DateTime ngayDangXet = ngayDauTuan.AddDays((int)thu);
                foreach (var i in deNghis)
                {
                    BuoiHoc b = buoiHocs.Single(c => c.BuoiHoc1 == i.BuoiHoc);

                    if (b.Ngay == ngayDangXet)
                    {
                        int tietKTCu = b.TietBatDau + b.SoTiet - 1;
                        if (tietBD == b.TietBatDau)
                        {
                            MsgboxUtil.Exclamation("Trùng rồi bạn ơi");
                            return false;
                        }
                        if (tietBD < b.TietBatDau && tietKT >= b.TietBatDau)
                        {
                            MsgboxUtil.Exclamation("Trùng rồi bạn ơi");
                            return false;
                        }
                        if (tietBD > b.TietBatDau && tietKT <= tietKTCu)
                        {
                            MsgboxUtil.Exclamation("Trùng rồi bạn ơi");
                            return false;
                        }
                        if (tietBD == tietKTCu)
                        {
                            MsgboxUtil.Exclamation("Trùng rồi bạn ơi");
                            return false;
                        }
                    }
                }

                //vẽ các panel
                Paint((int)thu, tietBD, soTiet, lop, monHoc);
                deNghis.Add(new DeNghi() { BuoiHoc = idBuoiHoc, MaPC = maPC });

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

                frmNhapDeNghi frm = new frmNhapDeNghi() { Text = thu.ToString(), MaGV = maGV, HocKy = hocKy, NamHoc = namHoc };
                frm.truyen += new frmNhapDeNghi.TruyenMatKhau(NhanDuLieu);
                frm.ShowDialog();
            }
            catch (Exception ex)
            {
                ExceptionUtil.ThrowMsgBox(ex.Message);
            }
        }

        private bool NhanDuLieu(int tietBD, int soTiet, string monHoc, string lop, string maPC)
        {
            return ThemBuoiHoc(thu, tietBD, soTiet, monHoc, lop, maPC);
        }

        private new void Paint(int thu, int tietBD, int soTiet, string lop, string monHoc)
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
                        pnChinh.Controls.Add(motTiet);
                        motTiet.BringToFront();
                        break;
                    case 2:
                        HaiTiet haiTiet = new HaiTiet();
                        haiTiet.PhongHoc = lop;
                        haiTiet.MonHoc = monHoc;
                        haiTiet.Location = new Point(XThu[thu], YTiet[tietBD]);
                        pnChinh.Controls.Add(haiTiet);
                        haiTiet.BringToFront();
                        break;
                    case 3:
                        BaTiet baTiet = new BaTiet();
                        baTiet.PhongHoc = lop;
                        baTiet.MonHoc = monHoc;
                        baTiet.Location = new Point(XThu[thu], YTiet[tietBD]);
                        pnChinh.Controls.Add(baTiet);
                        baTiet.BringToFront();
                        break;
                    case 4:
                        BonTiet bonTiet = new BonTiet();
                        bonTiet.PhongHoc = lop;
                        bonTiet.MonHoc = monHoc;
                        bonTiet.Location = new Point(XThu[thu], YTiet[tietBD]);
                        pnChinh.Controls.Add(bonTiet);
                        bonTiet.BringToFront();
                        break;
                    case 5:
                        NamTiet namTiet = new NamTiet();
                        namTiet.PhongHoc = lop;
                        namTiet.MonHoc = monHoc;
                        namTiet.Location = new Point(XThu[thu], YTiet[tietBD]);
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

        private void DeNgiGiangDay_Load(object sender, EventArgs e)
        {
            try
            {
                Clear();
                foreach (DeNghi d in deNghis)
                {
                    ISingleResult<sp_ThongTinDeNghiResult> thongTin = DeNghiBUS.ThongTinDeNghi(d.BuoiHoc, d.MaPC);
                    foreach (var i in thongTin)
                    {
                        Thu t = Thu.Thu2;
                        switch (i.Ngay.DayOfWeek)
                        {
                            case DayOfWeek.Monday:
                                t = Thu.Thu2;
                                break;
                            case DayOfWeek.Tuesday:
                                t = Thu.Thu3;
                                break;
                            case DayOfWeek.Wednesday:
                                t = Thu.Thu4;
                                break;
                            case DayOfWeek.Thursday:
                                t = Thu.Thu5;
                                break;
                            case DayOfWeek.Friday:
                                t = Thu.Thu6;
                                break;
                            case DayOfWeek.Saturday:
                                t = Thu.Thu7;
                                break;
                            case DayOfWeek.Sunday:
                                t = Thu.ChuNhat;
                                break;
                        }
                        Paint((int)t, i.TietBatDau, i.SoTiet, i.MaLop, i.TenMH);
                    }
                }
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

        public void Cancel()
        {
            try
            {
                deNghis.Clear();
                deNghis = DeNghiBUS.DanhSachDeNgiTheoTuan(maGV, ngayDauTuan);
                DeNgiGiangDay_Load(null, null);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void ReadOnly()
        {
            try
            {
                lbl0.LinkClicked -= new LinkLabelLinkClickedEventHandler(lblThu2_LinkClicked);
                lbl1.LinkClicked -= new LinkLabelLinkClickedEventHandler(lblThu2_LinkClicked);
                lbl2.LinkClicked -= new LinkLabelLinkClickedEventHandler(lblThu2_LinkClicked);
                lbl3.LinkClicked -= new LinkLabelLinkClickedEventHandler(lblThu2_LinkClicked);
                lbl4.LinkClicked -= new LinkLabelLinkClickedEventHandler(lblThu2_LinkClicked);
                lbl5.LinkClicked -= new LinkLabelLinkClickedEventHandler(lblThu2_LinkClicked);
                lbl6.LinkClicked -= new LinkLabelLinkClickedEventHandler(lblThu2_LinkClicked);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void UnReadOnly()
        {
            try
            {
                lbl0.LinkClicked += new LinkLabelLinkClickedEventHandler(lblThu2_LinkClicked);
                lbl1.LinkClicked += new LinkLabelLinkClickedEventHandler(lblThu2_LinkClicked);
                lbl2.LinkClicked += new LinkLabelLinkClickedEventHandler(lblThu2_LinkClicked);
                lbl3.LinkClicked += new LinkLabelLinkClickedEventHandler(lblThu2_LinkClicked);
                lbl4.LinkClicked += new LinkLabelLinkClickedEventHandler(lblThu2_LinkClicked);
                lbl5.LinkClicked += new LinkLabelLinkClickedEventHandler(lblThu2_LinkClicked);
                lbl6.LinkClicked += new LinkLabelLinkClickedEventHandler(lblThu2_LinkClicked);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
