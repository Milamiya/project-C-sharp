using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QuanLyBanHangDienTu.Business.EntitiesClass;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QuanLyBanHangDienTu.DataAccess
{
    class SQL_tb_Nhomhang
    {
        ConnectDB cn = new ConnectDB();
        public bool kiemtral(string loai)
        {
            return cn.kiemtra("select count(*) from [tb_Nhomhang] where manhom=N'" + loai + "'");
        }
        public void themmoi(EC_tb_Nhomhang l)
        {
            cn.ExcuteNonQuery(@"INSERT INTO tb_Nhomhang
                      (manhom, tennhom, congcu) VALUES   (N'" + l.MANHOM + "',N'" + l.TENNHOM + "',N'" + l.CONGCU + "')");
        }
        public void xoa(EC_tb_Nhomhang l)
        {
            cn.ExcuteNonQuery("DELETE FROM [tb_Nhomhang] WHERE [manhom] = N'" + l.MANHOM + "'");
        }

        public void sua(EC_tb_Nhomhang l)
        {
            string sql = (@"UPDATE tb_Nhomhang
            SET tennhom =N'" + l.TENNHOM + "', congcu =N'" + l.CONGCU + "' where  manhom =N'" + l.MANHOM + "'");
            cn.ExcuteNonQuery(sql);
        }
    }
}
