using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QuanLyCafe.Business.EntitiesClass;

namespace QuanLyCafe.DataAccess
{
    class SQL_tb_NCC
    {
        ConnectDB cn = new ConnectDB();
        public bool kiemtrancc(string mancc)
        {
            return cn.kiemtra("select count(*) from [tb_NCC] where mancc=N'" + mancc + "'");
        }
        public void themmoincc(EC_tb_NCC ncc)
        {
            cn.ExcuteNonQuery(@"INSERT INTO tb_NCC
                      (mancc, tenncc, diachi, sdt) VALUES   (N'" + ncc.MANCC + "',N'" + ncc.TENNCC + "',N'" + ncc.DIACHI + "',N'" + ncc.DIENTHOAI + "')");
        }
        public void xoancc(EC_tb_NCC ncc)
        {
            cn.ExcuteNonQuery("DELETE FROM [tb_NCC] WHERE mancc=N'" + ncc.MANCC + "'");
        }

        public void suancc(EC_tb_NCC ncc)
        {
            string sql = (@"UPDATE    tb_NCC
            SET tenncc =N'" + ncc.TENNCC + "', diachi =N'" + ncc.DIACHI + "', sdt =N'" + ncc.DIENTHOAI + "' where mancc=N'" + ncc.MANCC + "'");
            cn.ExcuteNonQuery(sql);
        }
    }
}
