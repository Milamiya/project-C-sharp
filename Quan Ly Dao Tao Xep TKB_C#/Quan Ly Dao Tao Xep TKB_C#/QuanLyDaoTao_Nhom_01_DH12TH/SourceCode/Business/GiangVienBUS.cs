using System;
using System.Collections.Generic;
using System.Linq;
using QuanLyDaoTao.Utilities;
using QuanLyDaoTao.DataAccess;
using System.Data.Linq;
using System.Data;

namespace QuanLyDaoTao.Business
{
    public static class GiangVienBUS
    {
        private static dbQuanLyDaoTaoDataContextDataContext db = StaticClass.db;

        public static string SinhMa()
        {
            try
            {
                string id = "", newId;
                var x = db.GiangViens.OrderByDescending(gv => gv.MaGV).Take(1);
                foreach (var i in x)
                {
                    id = i.MaGV;
                }
                if (!string.IsNullOrEmpty(id))
                {
                    newId = "GV" + (int.Parse(id.Substring(2)) + 1).ToString("0000");
                    return newId;
                }
                return "GV0001";
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void Them(GiangVien gv)
        {
            try
            {
                db.GiangViens.InsertOnSubmit(gv);
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
                return (from gv in db.GiangViens
                        join td in db.TrinhDos
                            on gv.MaTrinhDo equals td.MaTrinhDo
                        select new
                        {
                            gv.MaGV,
                            gv.HoTen,
                            TrinhDo = td.TenTrinhDo
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
                return (new DataProvider()).GetTable("Select * from GiangVien");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static ISingleResult<sp_ThongTinGiangVienResult> DanhSachGiangVien()
        {
            try
            {
                return db.sp_ThongTinGiangVien();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
