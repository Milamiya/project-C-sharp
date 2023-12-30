using System;
using System.Collections.Generic;
using System.Linq;
using QuanLyDaoTao.DataAccess;
using QuanLyDaoTao.Utilities;
using System.Data.Linq;
using System.Data;

namespace QuanLyDaoTao.Business
{
    class TrinhDoBUS
    {
        private static dbQuanLyDaoTaoDataContextDataContext db = StaticClass.db;

        public static void Them(TrinhDo td)
        {
            try
            {
                db.TrinhDos.InsertOnSubmit(td);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static DataTable DanhSachTrinhDo()
        {
            try
            {
                return (new DataProvider()).GetTable("Select * from TrinhDo");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
