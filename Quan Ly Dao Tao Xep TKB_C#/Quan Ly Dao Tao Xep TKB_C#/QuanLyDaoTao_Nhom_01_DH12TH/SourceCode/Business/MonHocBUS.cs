using System;
using System.Collections.Generic;
using System.Linq;
using QuanLyDaoTao.Utilities;
using QuanLyDaoTao.DataAccess;
using System.Data.Linq;
using System.Data;

namespace QuanLyDaoTao.Business
{
    public static class MonHocBUS
    {
        private static dbQuanLyDaoTaoDataContextDataContext db = StaticClass.db;

        public static void Them(MonHoc mh)
        {
            try
            {
                db.MonHocs.InsertOnSubmit(mh);
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
                return from mh in db.MonHocs
                       select new
                       {
                           mh.MaMH,
                           mh.TenMH,
                           mh.STC
                       };
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
                return (new DataProvider()).GetTable("Select * from MonHoc");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
