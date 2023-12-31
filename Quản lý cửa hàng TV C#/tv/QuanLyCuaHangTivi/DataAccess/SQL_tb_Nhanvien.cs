﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QuanLyCuaHangTivi.Business.EntitiesClass;
using System.Windows.Forms;


namespace QuanLyCuaHangTivi.DataAccess
{
    class SQL_tb_Nhanvien
    {
        ConnectDB cn = new ConnectDB();
        public bool kiemtranv(string manv)
        {
            return cn.kiemtra("select count(*) from [tb_Nhanvien] where manv=N'" + manv + "'");
        }
        public void themmoinv(EC_tb_Nhanvien nv)
        {
            string sql = @"INSERT INTO tb_Nhanvien
                      (manv, tennv, gioitinh, ngaysinh, dienthoai, diachi, maca, macv)
                        VALUES   (N'" + nv.MANV + "',N'" + nv.TENNV + "',N'" + nv.GIOITINH + "',N'" + nv.NGAYSINH + "',N'" + nv.DIENTHOAI + "',N'" + nv.DIACHI + "',N'" + nv.MACA + "',N'" + nv.MACV + "')";
            cn.ExcuteNonQuery(sql);
        }
        public void xoanv(EC_tb_Nhanvien nv)
        {
            cn.ExcuteNonQuery("DELETE FROM [tb_Nhanvien] WHERE manv=N'" + nv.MANV + "'");
        }

        public void suanv(EC_tb_Nhanvien nv)
        {
            string sql = (@"UPDATE    tb_Nhanvien
                    SET tennv =N'" + nv.TENNV + "', gioitinh =N'" + nv.GIOITINH + "', ngaysinh =N'" + nv.NGAYSINH + "', dienthoai =N'" + nv.DIENTHOAI + "', diachi =N'" + nv.DIACHI + "', maca =N'" + nv.MACA + "', macv=N'" + nv.MACV + "'  where manv=N'" + nv.MANV + "'");
            cn.ExcuteNonQuery(sql);
        }
        //load công việc
        public void loadmacv(ComboBox macv)
        {
            cn.LoadLenCombobox(macv, "SELECT     macv FROM tb_Congviec", 0);
        }
        public string Loadtencv(string tencv, string macv)
        {
            tencv = cn.LoadLable("SELECT [tencv] From [tb_Congviec] where macv= N'" + macv + "'");
            return tencv;
        }
        //load ca làm
        public void loadmaca(ComboBox maca)
        {
            cn.LoadLenCombobox(maca, "SELECT     maca FROM tb_Calam", 0);
        }
        public string Loadtenca(string tenca, string maca)
        {
            tenca = cn.LoadLable("SELECT [tenca] From [tb_Calam] where maca= N'" + maca + "'");
            return tenca;
        }
    }
}
