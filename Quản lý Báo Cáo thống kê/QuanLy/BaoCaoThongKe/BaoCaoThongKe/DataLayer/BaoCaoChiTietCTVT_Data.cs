using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Data.OleDb;
using BaoCaoThongKe.BusinessObject;

namespace BaoCaoThongKe.DataLayer
{
    public class BaoCaoChiTietCTVT_Data
    {
        DataService ds = new DataService();
        public DataTable ChiTietBaoCao(string mabaocao, string macongtrinh)
        {
            SqlCommand cmd = new SqlCommand("Select ChiTietCongTrinhVienThong.MaChiTietCongTrinh,ChiTietCongTrinhVienThong.ThoiDiemSuDung,ChiTietCongTrinhVienThong.DiaDiemXayDung,ChiTietCongTrinhVienThong.DaiTanSo,ChiTietCongTrinhVienThong.MoTaMotSoDacTinh from ChiTietCongTrinhVienThong,BaoCaoTKTHKD where ChiTietCongTrinhVienThong.MaBCTKTHKD=BaoCaoTKTHKD.MaBCTKTHKD and ChiTietCongTrinhVienThong.MaCongTrinh=BaoCaoTKTHKD.MaCongTrinh and ChiTietCongTrinhVienThong.MaCongTrinh=@macongtrinh and ChiTietCongTrinhVienThong.MaBCTKTHKD=@mabaocao");
            cmd.Parameters.Add("mabaocao", SqlDbType.Int).Value = mabaocao;
            cmd.Parameters.Add("macongtrinh", SqlDbType.Int).Value = macongtrinh;
            ds.Load(cmd);
            return ds;
        }
        public DataTable LayMaMax()
        {
            SqlCommand cmd = new SqlCommand("select Max(MaChiTietCongTrinh) from ChiTietCongTrinhVienThong");
            ds.Load(cmd);
            return ds;
        }

        public void Update()
        {
            ds.Update();
        }

        public void Them(BaoCaoChiTietCTVT_InFo baocao)
        {
            SqlCommand cmd = new SqlCommand("insert into ChiTietCongTrinhVienThong(MaBCTKTHKD,MaCongTrinh,MaChiTietCongTrinh,ThoiDiemSuDung,DiaDiemXayDung,DaiTanSo,MoTaMotSoDacTinh) values(@mabaocao,@macongtrinh,@machitiet,@thoidiem,@diadiem,@daitanso,@mota)");
            cmd.Parameters.Add("mabaocao", SqlDbType.Int).Value = baocao.Mabaocao.Maubaocao.Mamaubaocao;
            cmd.Parameters.Add("macongtrinh", SqlDbType.Int).Value = baocao.Macongtrinh.MaCongTrinh;
            cmd.Parameters.Add("machitiet", SqlDbType.Int).Value = baocao.Machitiet;
            cmd.Parameters.Add("thoidiem", SqlDbType.DateTime).Value = baocao.Thoidiem;
            cmd.Parameters.Add("diadiem", SqlDbType.NVarChar, 200).Value = baocao.Diadiem;
            cmd.Parameters.Add("daitanso", SqlDbType.NVarChar, 200).Value = baocao.Daitanso;
            cmd.Parameters.Add("mota", SqlDbType.NVarChar, 200).Value = baocao.Mota;
            ds.Execute(cmd);
        }

        public void Sua(BaoCaoChiTietCTVT_InFo baocao)
        {
            SqlCommand cmd = new SqlCommand("Update ChiTietCongTrinhVienThong set ThoiDiemSuDung=@thoidiem,DiaDiemXayDung=@diadiem,DaiTanSo=@daitanso,MoTaMotSoDacTinh=@mota where MaBCTKTHKD=@mabaocao and MaCongTrinh=@macongtrinh and MaChiTietCongTrinh=@machitiet");
            cmd.Parameters.Add("mabaocao", SqlDbType.Int).Value = baocao.Mabaocao.Maubaocao.Mamaubaocao;
            cmd.Parameters.Add("macongtrinh", SqlDbType.Int).Value = baocao.Macongtrinh.MaCongTrinh;
            cmd.Parameters.Add("machitiet", SqlDbType.Int).Value = baocao.Machitiet;
            cmd.Parameters.Add("thoidiem", SqlDbType.DateTime).Value = baocao.Thoidiem;
            cmd.Parameters.Add("diadiem", SqlDbType.NVarChar, 200).Value = baocao.Diadiem;
            cmd.Parameters.Add("daitanso", SqlDbType.NVarChar, 200).Value = baocao.Daitanso;
            cmd.Parameters.Add("mota", SqlDbType.NVarChar, 200).Value = baocao.Mota;
            ds.Execute(cmd);
        }

        public void Xoa(BaoCaoChiTietCTVT_InFo baocao)
        {
            SqlCommand cmd = new SqlCommand("Delete from ChiTietCongTrinhVienThong where MaBCTKTHKD=@mabaocao and MaCongTrinh=@macongtrinh and MaChiTietCongTrinh=@machitiet");
            cmd.Parameters.Add("mabaocao", SqlDbType.Int).Value = baocao.Mabaocao.Maubaocao.Mamaubaocao;
            cmd.Parameters.Add("macongtrinh", SqlDbType.Int).Value = baocao.Macongtrinh.MaCongTrinh;
            cmd.Parameters.Add("machitiet", SqlDbType.Int).Value = baocao.Machitiet;

            ds.Execute(cmd);
        }

        public void XoaToanBo(string mabaocao, string macongtrinh)
        {
            SqlCommand cmd = new SqlCommand("Delete from ChiTietCongTrinhVienThong where MaBCTKTHKD=@mabaocao and MaCongTrinh=@macongtrinh");
            cmd.Parameters.Add("mabaocao", SqlDbType.Int).Value = mabaocao;
            cmd.Parameters.Add("macongtrinh", SqlDbType.Int).Value = macongtrinh;

            ds.Execute(cmd);
        }

        public DataTable Laybaocao_ChitietCTVT(string mabaocao, string macongtrinh)
        {
            SqlCommand cmd = new SqlCommand("Select ChiTietCongTrinhVienThong.MaChiTietCongTrinh,ChiTietCongTrinhVienThong.ThoiDiemSuDung,ChiTietCongTrinhVienThong.DiaDiemXayDung,ChiTietCongTrinhVienThong.DaiTanSo,ChiTietCongTrinhVienThong.MoTaMotSoDacTinh from ChiTietCongTrinhVienThong,BaoCaoTKTHKD where ChiTietCongTrinhVienThong.MaBCTKTHKD=BaoCaoTKTHKD.MaBCTKTHKD and ChiTietCongTrinhVienThong.MaCongTrinh=BaoCaoTKTHKD.MaCongTrinh and ChiTietCongTrinhVienThong.MaCongTrinh=@macongtrinh and ChiTietCongTrinhVienThong.MaBCTKTHKD=@mabaocao");
            cmd.Parameters.Add("mabaocao", SqlDbType.Int).Value = mabaocao;
            cmd.Parameters.Add("macongtrinh", SqlDbType.Int).Value = macongtrinh;
            ds.Load(cmd);
            return ds;
        }
    }
}
