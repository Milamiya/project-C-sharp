using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using BaoCaoThongKe.BusinessObject;

namespace BaoCaoThongKe.DataLayer
{
    public class BaoCaoTHTHCLDV_Data
    {
        DataService ds = new DataService();
        public DataTable ChiTietBaoCao(string ma)
        {
            SqlCommand cmd = new SqlCommand("Select BaoCaoTHTHCLDV.MaBCTHTHCLDV, DichVuBuuChinhVT.TenDichVuBuuChinhVT, DichVuBuuChinhVT.MaDichVuBuuChinhVT, DoanhNghiep.TenDoanhNghiep, DoanhNghiep.MaDoanhNghiep, BaoCaoTHTHCLDV.ThuocDanhMucBuuChinh, "
                                        + " BaoCaoTHTHCLDV.VanBanCongBo, BaoCaoTHTHCLDV.TenDoanhNghiepCongBo, BaoCaoTHTHCLDV.GhiChu, TieuChuanChatLuong.TenTieuChuanCL, TieuChuanChatLuong.MaTieuChuanCL "
                                        + " from BaoCaoTHTHCLDV, TieuChuanChatLuong, DichVuBuuChinhVT, DoanhNghiep "
                                        + " where DoanhNghiep.MaDoanhNghiep = DichVuBuuChinhVT.MaDoanhNghiep and DichVuBuuChinhVT.MaDichVuBuuChinhVT = BaoCaoTHTHCLDV.MaDichVuBuuChinhVT and TieuChuanChatLuong.MaTieuChuanCL = BaoCaoTHTHCLDV.MaTieuChuanCL and BaoCaoTHTHCLDV.MaBCTHTHCLDV = @ma");
            cmd.Parameters.Add("ma", SqlDbType.Int).Value = ma;
            ds.Load(cmd);
            return ds;
        }

        public void Update()
        {
            ds.Update();
        }

        public void Them(BaoCaoTHTHCLDV_InFo baocao)
        {
            SqlCommand cmd = new SqlCommand("insert into BaoCaoTHTHCLDV(MaBCTHTHCLDV, MaDichVuBuuChinhVT, ThuocDanhMucBuuChinh, MaTieuChuanCL, VanBanCongBo, TenDoanhNghiepCongBo, GhiChu) values(@mabaocao, @madichvu, @thuocdanhmuc, @matieuchuan, @vanban, @tendoanhnghiep, @ghichu)");
            cmd.Parameters.Add("mabaocao", SqlDbType.Int).Value = baocao.Maubaocao.Mamaubaocao;
            cmd.Parameters.Add("madichvu", SqlDbType.Int).Value = baocao.Dichvubuuchinh.MaDichVuBuuChinhVT;
            cmd.Parameters.Add("thuocdanhmuc", SqlDbType.NVarChar, 50).Value = baocao.Thuocdanhmucbuuchinh;
            cmd.Parameters.Add("matieuchuan", SqlDbType.Int).Value = baocao.Tieuchuanchatluong.MaTieuChuanCL;
            cmd.Parameters.Add("vanban", SqlDbType.NVarChar, 255).Value = baocao.Vanbancongbo;
            cmd.Parameters.Add("tendoanhnghiep", SqlDbType.NVarChar, 255).Value = baocao.Doanhnghiepcongbo;
            cmd.Parameters.Add("ghichu", SqlDbType.NVarChar, 255).Value = baocao.Ghichu;
            ds.Execute(cmd);
        }

        public void Xoa(BaoCaoTHTHCLDV_InFo baocao)
        {
            SqlCommand cmd = new SqlCommand("delete from BaoCaoTHTHCLDV where MaBCTHTHCLDV=@mabaocao and MaDichVuBuuChinhVT=@madichvu");
            cmd.Parameters.Add("mabaocao", SqlDbType.Int).Value = baocao.Maubaocao.Mamaubaocao;
            cmd.Parameters.Add("madichvu", SqlDbType.Int).Value = baocao.Dichvubuuchinh.MaDichVuBuuChinhVT;
            ds.Execute(cmd);
        }

        public void Sua(BaoCaoTHTHCLDV_InFo baocao)
        {
            SqlCommand cmd = new SqlCommand("Update BaoCaoTHTHCLDV set ThuocDanhMucBuuChinh=@thuocdanhmuc, MaTieuChuanCL = @matieuchuan, VanBanCongBo = @vanban, TenDoanhNghiepCongBo=@tendoanhnghiep, GhiChu = @ghichu where MaBCTHTHCLDV = @mabaocao and MaDichVuBuuChinhVT = @madichvu");
            cmd.Parameters.Add("mabaocao", SqlDbType.Int).Value = baocao.Maubaocao.Mamaubaocao;
            cmd.Parameters.Add("madichvu", SqlDbType.Int).Value = baocao.Dichvubuuchinh.MaDichVuBuuChinhVT;
            cmd.Parameters.Add("thuocdanhmuc", SqlDbType.NVarChar, 50).Value = baocao.Thuocdanhmucbuuchinh;
            cmd.Parameters.Add("matieuchuan", SqlDbType.Int).Value = baocao.Tieuchuanchatluong.MaTieuChuanCL;
            cmd.Parameters.Add("vanban", SqlDbType.NVarChar, 255).Value = baocao.Vanbancongbo;
            cmd.Parameters.Add("tendoanhnghiep", SqlDbType.NVarChar, 255).Value = baocao.Doanhnghiepcongbo;
            cmd.Parameters.Add("ghichu", SqlDbType.NVarChar, 255).Value = baocao.Ghichu;
            ds.Execute(cmd);
        }

        public void XoaToanBo(string ma)
        {
            SqlCommand cmd = new SqlCommand("delete from BaoCaoTHTHCLDV where MaBCTHTHCLDV=@mabaocao");
            cmd.Parameters.Add("mabaocao", SqlDbType.Int).Value = ma;
            ds.Execute(cmd);
        }

        public DataTable Laybaocao_DVBCVT(string doanhnghiep, string loaibaocao, string nam)
        {
            SqlCommand cmd = new SqlCommand("Select MauBaoCaoTHTHCLDV.TenBCTHTHCLDV,BaoCaoTHTHCLDV.MaBCTHTHCLDV,DichVuBuuChinhVT.TenDichVuBuuChinhVT,DichVuBuuChinhVT.MaDichVuBuuChinhVT, DoanhNghiep.TenDoanhNghiep, DoanhNghiep.MaDoanhNghiep, BaoCaoTHTHCLDV.ThuocDanhMucBuuChinh, BaoCaoTHTHCLDV.VanBanCongBo, BaoCaoTHTHCLDV.TenDoanhNghiepCongBo, "
                                        + " BaoCaoTHTHCLDV.GhiChu, TieuChuanChatLuong.TenTieuChuanCL, TieuChuanChatLuong.MaTieuChuanCL "
                                        + " from BaoCaoTHTHCLDV, TieuChuanChatLuong, DichVuBuuChinhVT, DoanhNghiep, MauBaoCaoTHTHCLDV "
                                        + " where DoanhNghiep.MaDoanhNghiep = DichVuBuuChinhVT.MaDoanhNghiep and DichVuBuuChinhVT.MaDichVuBuuChinhVT = BaoCaoTHTHCLDV.MaDichVuBuuChinhVT and TieuChuanChatLuong.MaTieuChuanCL = BaoCaoTHTHCLDV.MaTieuChuanCL and "
                                        + " MauBaoCaoTHTHCLDV.MaBCTHTHCLDV = BaoCaoTHTHCLDV.MaBCTHTHCLDV and MauBaoCaoTHTHCLDV.MaLoaiBaoCao = @loaibaocao and MauBaoCaoTHTHCLDV.Nam = @nam and DoanhNghiep.MaDoanhNghiep = @doanhnghiep");
            cmd.Parameters.Add("doanhnghiep", SqlDbType.Int).Value = doanhnghiep;
            cmd.Parameters.Add("loaibaocao", SqlDbType.Int).Value = loaibaocao;
            cmd.Parameters.Add("nam", SqlDbType.Int).Value = nam;
            ds.Load(cmd);
            return ds;
        }
    }
}
