using System;
using System.Collections.Generic;
using System.Linq;
using QuanLyDaoTao.DataAccess;
using QuanLyDaoTao.Utilities;
using System.Data;
using System.Data.Linq;

namespace QuanLyDaoTao.Business
{
    public static class SinhVienBUS
    {
        private static dbQuanLyDaoTaoDataContextDataContext db = StaticClass.db;

        public static string SinhMa(string dinhDang)
        {
            try
            {
                string id = "", newId;
                IQueryable<SinhVien> y = from sv in db.SinhViens
                                         where sv.MSSV.StartsWith(dinhDang)
                                         select sv;
                var x = y.OrderByDescending(sv => sv.MSSV).Take(1);
                foreach (var i in x)
                {
                    id = i.MSSV;
                }
                if (!string.IsNullOrEmpty(id))
                {
                    newId = dinhDang + (int.Parse(id.Substring(5)) + 1).ToString("0000");
                    return newId;
                }
                return dinhDang + "0001";
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void Them(SinhVien sv)
        {
            try
            {
                db.SinhViens.InsertOnSubmit(sv);
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
                return (new DataProvider()).GetTable("Select * from SinhVien");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void NhapTuExcel(string duongDan)
        {
            try
            {
                (new DataProvider()).ImportDataFromExcel(duongDan, "SinhVien", "Select MaKH, TenKH, DiaChi, DienThoai, Email from [KhachHang$]");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static Table<SinhVien> DanhSachSV()
        {
            try
            {
                return db.SinhViens;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void Xoa(string mssv)
        {
            try
            {
                SinhVien sv = db.SinhViens.Single(v => v.MSSV == mssv);
                db.SinhViens.DeleteOnSubmit(sv);
            }
            catch (Exception ex)
            {
                ExceptionUtil.Throw(ex.Message);
            }
        }
    }
}
