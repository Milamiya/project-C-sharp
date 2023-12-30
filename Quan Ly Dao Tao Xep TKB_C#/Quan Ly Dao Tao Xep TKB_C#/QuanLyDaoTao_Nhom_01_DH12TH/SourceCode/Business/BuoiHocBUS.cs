using System;
using System.Collections.Generic;
using System.Linq;
using QuanLyDaoTao.DataAccess;
using QuanLyDaoTao.Utilities;
using System.Data.Linq;
using System.Collections.ObjectModel;
using System.Data;

namespace QuanLyDaoTao.Business
{
    public static class BuoiHocBUS
    {
        private static dbQuanLyDaoTaoDataContextDataContext db = StaticClass.db;

        public static void Them(BuoiHoc bh)
        {
            try
            {
                db.BuoiHocs.InsertOnSubmit(bh);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static int LayMaCuoiCung()
        {
            try
            {
                int id = -1;
                var x = db.BuoiHocs.OrderByDescending(b => b.BuoiHoc1).Take(1);
                foreach (var i in x)
                {
                    id = i.BuoiHoc1;
                }
                if (id == -1)
                    return 1;
                return id;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static Collection<BuoiHoc> DanhSachBuoiHocTheoTuan(DateTime ngayDauTuan)
        {
            try
            {
                var x = from b in db.BuoiHocs
                        where b.Ngay >= ngayDauTuan && b.Ngay <= ngayDauTuan.AddDays(6)
                        select b;
                Collection<BuoiHoc> bh = new Collection<BuoiHoc>();
                foreach (BuoiHoc b in x)
                {
                    bh.Add(b);
                }
                return bh;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void Them(Collection<BuoiHoc> buoiHocs)
        {
            try
            {
                foreach (BuoiHoc b in buoiHocs)
                {
                    if(!KiemTraTonTai(b))
                        db.BuoiHocs.InsertOnSubmit(b);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static bool KiemTraTonTai(BuoiHoc b)
        {
            try
            {
                return db.BuoiHocs.Any(bh => bh.Ngay == b.Ngay && bh.SoTiet == b.SoTiet && bh.TietBatDau == b.TietBatDau);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static bool KiemTraTonTai(int maBuoi)
        {
            try
            {
                return db.BuoiHocs.Any(bh => bh.BuoiHoc1 == maBuoi);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static BuoiHoc LayThongTin(int maBuoiHoc)
        {
            try
            {
                return db.BuoiHocs.Single(b => b.BuoiHoc1 == maBuoiHoc);
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
                return (new DataProvider()).GetTable("Select * from BuoiHoc");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
