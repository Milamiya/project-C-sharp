using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using QuanLyDaoTao.DataAccess;
using System.Collections.ObjectModel;
using QuanLyDaoTao.Business;
using System.Linq;
using QuanLyDaoTao.Enums;
using System.Data.Linq;
using QuanLyDaoTao.Utilities;

namespace QuanLyDaoTao.Presentation
{
    public partial class frmNhapTKB : XtraForm
    {
        public frmNhapTKB()
        {
            try
            {
                InitializeComponent();
                source = new List<sp_DeNghiTheoPhongTrongTuanResult>();
                maPhong = string.Empty;
                ngayDauTuan = new DateTime();
                TKBDangXep = new Collection<ThoiKhoaBieu>();
            }
            catch (Exception ex)
            {
                throw ex;
            } 
        }

        /// <summary>
        /// Các thời khóa biểu đang xếp
        /// </summary>
        public Collection<ThoiKhoaBieu> TKBDangXep;

        /// <summary>
        /// Các thời khóa biểu đã được xếp
        /// </summary>
        public Collection<sp_ThongTinTKBResult> TKBs;

        string maPhong;

        public string MaPhong
        {
            get { return maPhong; }
            set { maPhong = value; }
        }

        DateTime ngayDauTuan;

        public DateTime NgayDauTuan
        {
            get { return ngayDauTuan; }
            set { ngayDauTuan = value; }
        }

        Thu thu = Thu.Thu2;

        public Thu Thu
        {
            get { return thu; }
            set { thu = value; }
        }

        public delegate bool TruyenMatKhau(sp_DeNghiTheoPhongTrongTuanResult t);
        public TruyenMatKhau truyen;
        private List<sp_DeNghiTheoPhongTrongTuanResult> source;


        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {
                if (selectedRowIndex >= 0)
                {
                    sp_DeNghiTheoPhongTrongTuanResult x = source[gridView1.GetDataSourceRowIndex(selectedRowIndex)];
                    if (truyen != null)
                    {
                        truyen(x);
                        this.DialogResult = DialogResult.OK;
                    }
                }
                Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            Close();
        }

        private void frmNhapTKB_Load(object sender, EventArgs e)
        {
            try
            {
                groupControl1.Text = "Các đề nghị giảng dạy ngày: " + ngayDauTuan.AddDays((int)thu).ToString("dd/MM/yyyy");
                //load cac de nghi cho mot ngay
                source = ThoiKhoaBieuBUS.ThongTinXepTKB(maPhong, ngayDauTuan).Where(i => i.Ngay == ngayDauTuan.AddDays((int)thu)).ToList<sp_DeNghiTheoPhongTrongTuanResult>();
                
                foreach (var x in TKBDangXep)//loại bỏ các đề nghị đang được xếp thời khóa biểu (chưa lưu vào CSDL)
                {
                    for (int i = source.Count - 1; i >= 0; i--)//loại bỏ những đề nghị trùng buổi với cái đã xếp
                    {
                        if (source[i].BuoiHoc == x.BuoiHoc)
                            source.Remove(source[i]);
                    }
                }

                foreach (var x in TKBs)//loại bỏ các đề nghị trùng với thời khóa biểu đã được xếp rồi (đã lưu trong CSDL)
                {
                    BuoiHoc buoi = BuoiHocBUS.LayThongTin(x.BuoiHoc);
                    if (source.Any(i => i.MaLop == LopBUS.LayMaLop(x.MaPC) && i.TietBatDau == buoi.TietBatDau && i.SoTiet == buoi.SoTiet))
                        source.Remove(source.Single(i => i.MaLop == LopBUS.LayMaLop(x.MaPC) && i.TietBatDau == buoi.TietBatDau && i.SoTiet == buoi.SoTiet));
                }

                //loại bỏ các đề nghị mà mã lớp của đề nghị đó đã được xếp vào học buổi đang chọn rồi
                //để tránh trường hợp 1 lớp học 2 môn cùng 1 buổi
                for (int i = source.Count - 1; i >= 0; i--)
                {
                    if (ThoiKhoaBieuBUS.KiemTraLopNayDaHocBuoiNayChua(source[i].MaPC,source[i].BuoiHoc))
                        source.Remove(source[i]);
                }

                //loại bỏ các trường hợp trùng 1 số tiết với thời khóa biểu đã xếp
                for (int i = source.Count - 1; i >= 0; i--)
                {
                    int tietKT = source[i].TietBatDau + source[i].SoTiet - 1;
                    DateTime ngayDangXet = ngayDauTuan.AddDays((int)thu);

                    foreach (var tkb in TKBs)
                    {
                        BuoiHoc b = BuoiHocBUS.LayThongTin(tkb.BuoiHoc);
                        if (b.Ngay == ngayDangXet)
                        {
                            int tietKTCu = b.TietBatDau + b.SoTiet - 1;
                            if (source[i].TietBatDau == b.TietBatDau)
                            {
                                source.Remove(source[i]);
                                break;
                            }
                            if (source[i].TietBatDau < b.TietBatDau && tietKT >= b.TietBatDau)
                            {
                                source.Remove(source[i]);
                                break;
                            }
                            if (source[i].TietBatDau > b.TietBatDau && tietKT <= tietKTCu)
                            {
                                source.Remove(source[i]);
                                break;
                            }
                            if (source[i].TietBatDau == tietKTCu)
                            {
                                source.Remove(source[i]);
                                break;
                            }
                        }
                    }
                }

                //loại bỏ các trường hợp trùng 1 số tiết với thời khóa biểu đang xếp
                for (int i = source.Count - 1; i >= 0; i--)
                {
                    int tietKT = source[i].TietBatDau + source[i].SoTiet - 1;
                    DateTime ngayDangXet = ngayDauTuan.AddDays((int)thu);

                    foreach (var tkb in TKBDangXep)
                    {
                        BuoiHoc b = BuoiHocBUS.LayThongTin(tkb.BuoiHoc);
                        if (b.Ngay == ngayDangXet)
                        {
                            int tietKTCu = b.TietBatDau + b.SoTiet - 1;
                            if (source[i].TietBatDau == b.TietBatDau)
                            {
                                source.Remove(source[i]);
                                break;
                            }
                            if (source[i].TietBatDau < b.TietBatDau && tietKT >= b.TietBatDau)
                            {
                                source.Remove(source[i]);
                                break;
                            }
                            if (source[i].TietBatDau > b.TietBatDau && tietKT <= tietKTCu)
                            {
                                source.Remove(source[i]);
                                break;
                            }
                            if (source[i].TietBatDau > b.TietBatDau && source[i].TietBatDau<= tietKTCu && tietKT > tietKTCu)
                            {
                                source.Remove(source[i]);
                                break;
                            }
                            if (source[i].TietBatDau == tietKTCu)
                            {
                                source.Remove(source[i]);
                                break;
                            }
                        }
                    }
                }

                gridControl1.DataSource = source;
                if (source.Count > 0)
                    selectedRowIndex = gridView1.GetDataSourceRowIndex(0);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        int selectedRowIndex = -1;
        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            selectedRowIndex = e.RowHandle;
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                simpleButton1_Click(null, null);
            }
            catch (Exception ex)
            {
                ExceptionUtil.ThrowMsgBox(ex.Message);
            }
        }
    }
}