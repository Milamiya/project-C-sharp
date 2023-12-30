using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QuanLyBanHangDienTu.Business.EntitiesClass;
using QuanLyBanHangDienTu.DataAccess;
using System.Windows.Forms;

namespace QuanLyBanHangDienTu.Business.Component
{
    class E_tb_CTHDB
    {
        SQL_tb_CTHDB cthdbsql = new SQL_tb_CTHDB();
        public void themoicthdb(EC_tb_CTHDB cthdb)
        {
            if (!cthdbsql.kiemtracthdb(cthdb.SOHDB, cthdb.MAHANG))
            {
                cthdbsql.themmoicthdb(cthdb);
            }
            else
            {
                MessageBox.Show("Mã này đã tồn tại,xin chọn Mã khác", "Chú Ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public void suacthdb(EC_tb_CTHDB cthdb)
        {
            cthdbsql.suacthdb(cthdb);
        }
        public void xoacthdb(EC_tb_CTHDB cthdb)
        {
            cthdbsql.xoacthdb(cthdb);
        }
        //load hóa đơn
        public void loadmahd(ComboBox cbhd)
        {
            cthdbsql.loadmahd(cbhd);
        }
        //load hóa đơn
        public void loadmasp(ComboBox cbsp)
        {
            cthdbsql.loadmasp(cbsp);
        }
        public string loadtensp(string Tensp, string Masp)
        {
            Tensp = cthdbsql.Loadtenhang(Tensp, Masp);
            return Tensp;
        }

        public string loaddg(string dg, string Masp)
        {
            dg = cthdbsql.Loaddgb(dg, Masp);
            return dg;
        }
    }
}
