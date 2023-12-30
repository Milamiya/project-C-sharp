using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QuanLyBanHangDienTu.Business.EntitiesClass;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QuanLyBanHangDienTu.DataAccess
{
    class SQL_tb_Loaihang
    {
        ConnectDB cn = new ConnectDB();
        public bool kiemtral(string loai)
        {
            return cn.kiemtra("select count(*) from [tb_Loaihang] where maloai=N'" + loai + "'");
        }
        public void themmoil(EC_tb_Loaihang l)
        {
            cn.ExcuteNonQuery(@"INSERT INTO tb_Loaihang
                      (maloai, manhom, tenloai) VALUES   (N'" + l.MALOAI + "',N'" + l.MANHOM + "',N'" + l.TENLOAI + "')");
        }
        public void xoal(EC_tb_Loaihang l)
        {
            cn.ExcuteNonQuery("DELETE FROM [tb_Loaihang] WHERE [maloai] = N'" + l.MALOAI + "'");
        }

        public void sual(EC_tb_Loaihang l)
        {
            string sql = (@"UPDATE tb_Loaihang
            SET tenloai =N'" + l.TENLOAI + "', manhom =N'" + l.MANHOM + "' where  maloai =N'" + l.MALOAI + "'");
            cn.ExcuteNonQuery(sql);
        }
        //load ca
        public void loadman(ComboBox man)
        {
            cn.LoadLenCombobox(man, "SELECT     manhom FROM tb_Nhomhang", 0);
        }
        public string Loadtenn(string tenn, string man)
        {
            tenn = cn.LoadLable("SELECT [tennhom] From [tb_Nhomhang] where manhom= N'" + man + "'");
            return tenn;
        }
    }
}
