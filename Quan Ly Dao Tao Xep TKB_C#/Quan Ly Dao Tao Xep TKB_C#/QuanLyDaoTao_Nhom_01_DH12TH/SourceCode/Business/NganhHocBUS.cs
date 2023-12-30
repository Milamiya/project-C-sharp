using System;
using System.Collections.Generic;
using System.Linq;
using QuanLyDaoTao.DataAccess;
using QuanLyDaoTao.Utilities;
using System.Data.Linq;
using System.Data;

namespace QuanLyDaoTao.Business
{
    public static class NganhHocBUS
    {
        private static dbQuanLyDaoTaoDataContextDataContext db = StaticClass.db;

        public static void Them(NganhHoc nh)
        {
            try
            {
                db.NganhHocs.InsertOnSubmit(nh);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static Table<NganhHoc> DanhSachNganhHoc()
        {
            try
            {
                return db.NganhHocs;
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
                return (new DataProvider()).GetTable("Select * from NganhHoc");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
