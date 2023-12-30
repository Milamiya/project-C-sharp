using System;
using System.Collections.Generic;
using System.Linq;
using QuanLyDaoTao.Utilities;
using QuanLyDaoTao.DataAccess;
using System.Data.Linq;
using System.Data;

namespace QuanLyDaoTao.Business
{
    public static class LopBUS
    {
        private static dbQuanLyDaoTaoDataContextDataContext db = StaticClass.db;

        public static void Them(Lop lop)
        {
            try
            {
                db.Lops.InsertOnSubmit(lop);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static IQueryable DanhSachTuyChinh()
        {
            try
            {
                return from l in db.Lops
                               join n in db.NganhHocs
                               on l.MaNganh equals n.MaNganh
                               select new { l.MaLop, n.TenNganh };
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static string LayMaLop(string maPC)
        {
            try
            {
                return db.PhanCongs.Single(i => i.MaPC == maPC).MaLop;
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
                return (new DataProvider()).GetTable("Select * from Lop");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
