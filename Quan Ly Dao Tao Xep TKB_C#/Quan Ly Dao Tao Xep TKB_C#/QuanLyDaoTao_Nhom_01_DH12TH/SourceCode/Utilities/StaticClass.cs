using System;
using System.Collections.Generic;
using System.Linq;
using QuanLyDaoTao.DataAccess;

namespace QuanLyDaoTao.Utilities
{
    public static class StaticClass
    {
        /// <summary>
        /// Người dùng đang đăng nhập hệ thống
        /// </summary>
        public static NguoiDung User;

        /// <summary>
        /// Cho biết đang đăng nhập hay đã đăng xuất.
        /// </summary>
        public static bool DangNhap = false;

        /// <summary>
        /// Database dùng chung cho toàn chương trình
        /// </summary>
        public static dbQuanLyDaoTaoDataContextDataContext db = new dbQuanLyDaoTaoDataContextDataContext();

        public static void LuuThayDoi()
        {
            try
            {
                db.SubmitChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void Refresh()
        {
            try
            {
                db = new dbQuanLyDaoTaoDataContextDataContext();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Ghi file lịch sử
        /// </summary>
        public static LogFile Log = new LogFile();
    }
}
