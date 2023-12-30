using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QuanLyDaoTao.DataAccess;
using QuanLyDaoTao.Utilities;
using System.Collections.ObjectModel;
using System.Data.Linq;
using System.Data;

namespace QuanLyDaoTao.Business
{
    public static class ThoiKhoaBieuBUS
    {
        private static dbQuanLyDaoTaoDataContextDataContext db = StaticClass.db;

        public static Collection<sp_DeNghiTheoPhongTrongTuanResult> ThongTinXepTKB(string maPhong, DateTime ngayDauTuan)
        {
            try
            {
                var x = db.sp_DeNghiTheoPhongTrongTuan(maPhong, ngayDauTuan);
                Collection<sp_DeNghiTheoPhongTrongTuanResult> kq = new Collection<sp_DeNghiTheoPhongTrongTuanResult>();
                foreach (var i in x)
                {
                    kq.Add(i);
                }
                return kq;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static Collection<sp_ThongTinTKBResult> ThongTinTKB(DateTime ngayDauTuan, string maPhong)
        {
            try
            {

                var x = db.sp_ThongTinTKB(ngayDauTuan, maPhong);
                Collection<sp_ThongTinTKBResult> kq = new Collection<sp_ThongTinTKBResult>();
                foreach (var i in x)
                {
                    kq.Add(i);
                }
                return kq;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void Them(Collection<ThoiKhoaBieu> tkbDangXep)
        {
            try
            {
                foreach (ThoiKhoaBieu x in tkbDangXep)
                {
                    db.ThoiKhoaBieus.InsertOnSubmit(x);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void Xoa(string maPC, int maBuoi)
        {
            try
            {
                db.ThoiKhoaBieus.DeleteOnSubmit(db.ThoiKhoaBieus.Single(i => i.MaPC == maPC && i.BuoiHoc == maBuoi));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Load thông tin chi tiết của 1 thời khóa biểu
        /// </summary>
        public static ISingleResult<sp_ThongTinMotTKBResult> ThongTinChiTiet(string maPC, int maBuoi)
        {
            try
            {
                return db.sp_ThongTinMotTKB(maPC, maBuoi);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Load thông tin chi tiết của 1 phân công kết hợp với 1 buổi học kiểm tra loại bỏ trùng lịch của 1 lớp
        /// </summary>
        public static ISingleResult<sp_ThongPhanCongBuoiHocResult> ThongPCBuoiHoc(string maPC, int maBuoi)
        {
            try
            {
                return db.sp_ThongPhanCongBuoiHoc(maPC, maBuoi);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// True: Lớp này đã học buổi học này rồi
        /// False: Lớp này chưa học buổi này
        /// </summary>
        public static bool KiemTraLopNayDaHocBuoiNayChua(string maPC, int maBuoi)
        {
            try
            {
                string maLop = LopBUS.LayMaLop(maPC);
                foreach (var i in db.ThoiKhoaBieus)
                {
                    if (LopBUS.LayMaLop(i.MaPC) == maLop && i.BuoiHoc == maBuoi)
                        return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static DataTable LayDuLieu()
        {
            try
            {
                return (new DataProvider()).GetTable("Select * from ThoiKhoaBieu");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static Collection<sp_XemTKBSinhVienResult> SinhVienXemTKB(string mssv, DateTime ngayDauTuan)
        {
            try
            {
                var x = db.sp_XemTKBSinhVien(mssv, ngayDauTuan);
                Collection<sp_XemTKBSinhVienResult> kq = new Collection<sp_XemTKBSinhVienResult>();
                foreach (var i in x)
                {
                    kq.Add(i);
                }
                return kq;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static Collection<sp_XemTKBSinhVienResult> PhieuGiangDay(string maLop, DateTime ngayDauTuan)
        {
            try
            {
                string mssv = (from sv in db.SinhViens
                               where sv.MaLop == maLop
                               select sv.MSSV).Take(1).ToList<string>()[0];

                var x = db.sp_XemTKBSinhVien(mssv, ngayDauTuan);
                Collection<sp_XemTKBSinhVienResult> kq = new Collection<sp_XemTKBSinhVienResult>();
                foreach (var i in x)
                {
                    kq.Add(i);
                }
                return kq;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static Collection<sp_XemTKBGiangVienResult> GiangVienXemTKB(string maGV, DateTime ngayDauTuan)
        {
            try
            {
                var x = db.sp_XemTKBGiangVien(maGV, ngayDauTuan);
                Collection<sp_XemTKBGiangVienResult> kq = new Collection<sp_XemTKBGiangVienResult>();
                foreach (var i in x)
                {
                    kq.Add(i);
                }
                return kq;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Lấy nguyên bảng thời khóa biểu thuần chủng
        /// </summary>
        public static Table<ThoiKhoaBieu> ThoiKhoaBieu()
        {
            try
            {
                return db.ThoiKhoaBieus;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static ISingleResult<sp_ThongTinThanhToanResult> ThongTinThanhToan(string maGV, DateTime ngayBD, DateTime ngayKT)
        {
            try
            {
                return db.sp_ThongTinThanhToan(maGV, ngayBD, ngayKT);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void ThanhToan(string maPC, int maBuoi)
        {
            try
            {
                QuanLyDaoTao.DataAccess.ThoiKhoaBieu tkb = db.ThoiKhoaBieus.Single(t => t.MaPC == maPC && t.BuoiHoc == maBuoi);
                if (tkb.CoDay && tkb.DaThanhToan == false)
                    tkb.DaThanhToan = true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
