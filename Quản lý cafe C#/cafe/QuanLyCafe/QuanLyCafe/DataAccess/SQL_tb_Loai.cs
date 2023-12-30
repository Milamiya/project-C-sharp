using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QuanLyCafe.Business.EntitiesClass;
namespace QuanLyCafe.DataAccess
{
    class SQL_tb_Loai
    {
        ConnectDB cn = new ConnectDB();
        public bool kiemtra(string maloai)
        {
            return cn.kiemtra("select count(*) from [tb_Loai] where maloai=N'" + maloai + "'");
        }
        public void themmoi(EC_tb_Loai q)
        {
            cn.ExcuteNonQuery(@"INSERT INTO tb_Loai
                      (maloai, tenloai) VALUES   (N'" + q.MALOAI + "',N'" + q.TENLOAI + "')");
        }
        public void xoa(EC_tb_Loai q)
        {
            cn.ExcuteNonQuery("DELETE FROM [tb_Loai] WHERE [maloai] = N'" + q.MALOAI + "'");
        }

        public void sua(EC_tb_Loai q)
        {
            string sql = (@"UPDATE tb_Loai
            SET tenloai =N'" + q.TENLOAI + "' where  maloai =N'" + q.MALOAI + "'");
            cn.ExcuteNonQuery(sql);
        }
    }
}
