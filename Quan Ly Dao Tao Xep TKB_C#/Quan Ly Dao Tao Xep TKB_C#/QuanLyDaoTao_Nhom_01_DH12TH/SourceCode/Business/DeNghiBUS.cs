using System;
using System.Collections.Generic;
using System.Linq;
using QuanLyDaoTao.Utilities;
using QuanLyDaoTao.DataAccess;
using System.Data.Linq;
using System.Collections.ObjectModel;
using System.Data;

namespace QuanLyDaoTao.Business
{
    public static class DeNghiBUS
    {
        private static dbQuanLyDaoTaoDataContextDataContext db = StaticClass.db;

        public static ISingleResult<sp_ThongTinPhanCongTheoGVResult> ThongTinPhanCongTheoGV(string maGV, int hocKy, int namHoc)
        {
            try
            {
                return db.sp_ThongTinPhanCongTheoGV(maGV, (byte)hocKy, namHoc);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static bool KiemTraTonTai(int maBuoiHoc, string maPC)
        {
            try
            {
                return db.DeNghis.Any(d => d.BuoiHoc == maBuoiHoc && d.MaPC == maPC);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void Them(Collection<DeNghi> deNghis)
        {
            try
            {
                foreach (DeNghi d in deNghis)
                {
                    if (!KiemTraTonTai(d))
                        db.DeNghis.InsertOnSubmit(d);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static Collection<DeNghi> DanhSachDeNgiTheoTuan(string maGV, DateTime ngayDauTuan)
        {
            try
            {
                var x = db.sp_DeNghiTheoTuan(maGV, ngayDauTuan);
                Collection<DeNghi> deNghi = new Collection<DeNghi>();
                foreach (var i in x)
                {
                    deNghi.Add(new DeNghi() { BuoiHoc = i.BuoiHoc, MaPC = i.MaPC });
                }
                return deNghi;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static ISingleResult<sp_ThongTinDeNghiResult> ThongTinDeNghi(int maBuoiHoc, string maPC)
        {
            try
            {
                return db.sp_ThongTinDeNghi(maBuoiHoc, maPC);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static bool KiemTraTonTai(DeNghi d)
        {
            try
            {
                return db.DeNghis.Any(dn => dn.BuoiHoc == d.BuoiHoc && dn.MaPC == d.MaPC);
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
                return (new DataProvider()).GetTable("Select * from DeNghi");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
