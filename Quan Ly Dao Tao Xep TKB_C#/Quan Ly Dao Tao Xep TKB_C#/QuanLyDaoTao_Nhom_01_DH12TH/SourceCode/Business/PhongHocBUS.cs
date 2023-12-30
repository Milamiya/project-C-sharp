using System;
using System.Collections.Generic;
using System.Linq;
using QuanLyDaoTao.DataAccess;
using QuanLyDaoTao.Utilities;
using System.Data.Linq;
using System.Data;

namespace QuanLyDaoTao.Business
{
    class PhongHocBUS
    {
        private static dbQuanLyDaoTaoDataContextDataContext db = StaticClass.db;

        public static IQueryable DanhSachPhong()
        {
            try
            {
                return (from n in db.PhongHocs
                        select new
                        {
                            MaPhong = n.MaPhong,
                            SucChua = n.SucChua,
                            ChucNang = n.ChucNang,
                            DiaChi = n.DiaChi
                        });
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
                return (new DataProvider()).GetTable("Select * from PhongHoc");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void Them(PhongHoc p)
        {
            try
            {
                db.PhongHocs.InsertOnSubmit(p);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
