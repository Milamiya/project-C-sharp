using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Windows.Forms;
using QuanLyVayVonChoNHCSXH.DataLayer;
using QuanLyVayVonChoNHCSXH.BusinessObject;

namespace QuanLyVayVonChoNHCSXH.Controller
{
    public class HoSoKheUocController
    {
        HoSoKheUocLayer HSKULayer = new HoSoKheUocLayer();
        BindingSource bs = new BindingSource();

        public void HienThiDataGridViewDSKU(DataGridView dg, BindingNavigator bn)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = HSKULayer.DanhSachHoSoKheUoc();
            bn.BindingSource = bs;
            dg.DataSource = bs;
        }
        public void HienThiDataGridView(DataGridView dg, BindingNavigator bn,TextBox txtMaSoKU,ComboBox cmbMaDoiTac,ComboBox cmbMaLoaiVay,ComboBox cmbMaKVNV,ComboBox cmbMaKieuTra,ComboBox cmbMaChuongTrinh,ComboBox cmbTenToTruong,NumericUpDown numNhuCau
            ,DateTimePicker dtpNgayDuyet,NumericUpDown numMucDuyet,DateTimePicker dtpNgayVay,DateTimePicker dtpNgayTra,ComboBox cmbMaLaiSuat,ComboBox cmbMaTaiKhoan,ComboBox cmbThuLai,ComboBox cmbTKNoQuaHan,ComboBox cmbThuLaiQuaHan,ComboBox cmbMDVay,ComboBox cmbMaHTDamBao
            ,ComboBox cmbMaNV,ComboBox cmbMaHTVay,ComboBox cmbMaThoiHanVay,ComboBox cmbMaDVUT,ComboBox cmbMaVung,ComboBox cmbHotenThuaKe,NumericUpDown numTraNoGocDinhKy,NumericUpDown numSoTienHienTai)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = HSKULayer.DanhSachHoSoKheUoc();
            bn.BindingSource = bs;
            dg.DataSource = bs;
            
            txtMaSoKU.DataBindings.Clear();
            txtMaSoKU.DataBindings.Add("Text", bs, "MaSoKU");          
            
            cmbMaDoiTac.DataBindings.Clear();
            cmbMaDoiTac.DataBindings.Add("SelectedValue", bs, "MaDoiTac");

            cmbMaLoaiVay.DataBindings.Clear();
            cmbMaLoaiVay.DataBindings.Add("SelectedValue", bs, "MaLoaiVay");

            cmbMaKVNV.DataBindings.Clear();
            cmbMaKVNV.DataBindings.Add("SelectedValue", bs, "MaKVNV");

            cmbMaKieuTra.DataBindings.Clear();
            cmbMaKieuTra.DataBindings.Add("SelectedValue", bs, "MaKieuTra");

            cmbTenToTruong.DataBindings.Clear();
            cmbTenToTruong.DataBindings.Add("SelectedValue", bs, "TenToTruong");

            numNhuCau.DataBindings.Clear();
            numNhuCau.DataBindings.Add("Value", bs, "NhuCau");

            dtpNgayDuyet.DataBindings.Clear();
            dtpNgayDuyet.DataBindings.Add("Value", bs, "NgayDuyet");

            numMucDuyet.DataBindings.Clear();
            numMucDuyet.DataBindings.Add("Value", bs, "MucDuyet");

            dtpNgayVay.DataBindings.Clear();
            dtpNgayVay.DataBindings.Add("Value", bs, "NgayVay");

            dtpNgayTra.DataBindings.Clear();
            dtpNgayTra.DataBindings.Add("Value", bs, "NgayTra");

            cmbMaLaiSuat.DataBindings.Clear();
            cmbMaLaiSuat.DataBindings.Add("SelectedValue", bs, "MaLaiSuat");

            cmbMaTaiKhoan.DataBindings.Clear();
            cmbMaTaiKhoan.DataBindings.Add("SelectedValue", bs, "TKChoVay");

            cmbThuLai.DataBindings.Clear();
            cmbThuLai.DataBindings.Add("SelectedValue", bs, "ThuLai");

            cmbTKNoQuaHan.DataBindings.Clear();
            cmbTKNoQuaHan.DataBindings.Add("SelectedValue", bs, "TKNoQuaHan");

            cmbThuLaiQuaHan.DataBindings.Clear();
            cmbThuLaiQuaHan.DataBindings.Add("SelectedValue", bs, "ThuLaiQuaHan");

            cmbMDVay.DataBindings.Clear();
            cmbMDVay.DataBindings.Add("SelectedValue", bs, "MaMucDichVay");

            cmbMaHTDamBao.DataBindings.Clear();
            cmbMaHTDamBao.DataBindings.Add("SelectedValue", bs, "MaHTDamBao");

            cmbMaNV.DataBindings.Clear();
            cmbMaNV.DataBindings.Add("SelectedValue", bs, "MaNV");

            cmbMaHTVay.DataBindings.Clear();
            cmbMaHTVay.DataBindings.Add("SelectedValue", bs, "MaHTVay");

            cmbMaThoiHanVay.DataBindings.Clear();
            cmbMaThoiHanVay.DataBindings.Add("SelectedValue", bs, "MaThoiHanVay");

            cmbMaDVUT.DataBindings.Clear();
            cmbMaDVUT.DataBindings.Add("SelectedValue", bs, "MaDonViUyThac");

            cmbMaVung.DataBindings.Clear();
            cmbMaVung.DataBindings.Add("SelectedValue", bs, "MaVung");

            numTraNoGocDinhKy.DataBindings.Clear();
            numTraNoGocDinhKy.DataBindings.Add("Value", bs, "TraNoGocDinhKy");

            cmbHotenThuaKe.DataBindings.Clear();
            cmbHotenThuaKe.DataBindings.Add("SelectedValue", bs, "HoTenThuaKe");

            numSoTienHienTai.DataBindings.Clear();
            numSoTienHienTai.DataBindings.Add("Value", bs, "SoTienHienTai");

        }

     
        public HoSoKheUoc LayHoSoKheUoc(String ma)
        {
            HoSoKheUoc ku = null;
            DataTable tbl = HSKULayer.LayHoSoKheUoc(ma);
            if ((tbl.Rows.Count) > 0)
            {
                ku = new HoSoKheUoc();
                
                ku.MASOKU = Convert.ToString(tbl.Rows[0]["MaSoKU"]);
                ku.MADOITAC= Convert.ToString(tbl.Rows[0]["MaDoiTac"]);
                ku.MALOAIVAY = Convert.ToString(tbl.Rows[0]["MaLoaiVay"]);
                ku.MAKVNV= Convert.ToString(tbl.Rows[0]["MaKVNV"]);
                ku.MAKIEUTRA = Convert.ToString(tbl.Rows[0]["MaKieuTra"]);
                ku.TENTOTRUONG= Convert.ToString(tbl.Rows[0]["TenToTruong"]);
                ku.NHUCAU = Convert.ToDouble(tbl.Rows[0]["NhuCau"]);
                ku.SOTIENHIENTAI = Convert.ToDouble(tbl.Rows[0]["SoTienHienTai"]);
                ku.NGAYDUYET= Convert.ToDateTime(tbl.Rows[0]["NgayDuyet"]);
                ku.MUCDUYET= Convert.ToDouble(tbl.Rows[0]["MucDuyet"]);
                ku.NGAYVAY= Convert.ToDateTime(tbl.Rows[0]["NgayVay"]);
                ku.NGAYTRA= Convert.ToDateTime(tbl.Rows[0]["NgayTra"]);              
                ku.MALAISUAT = Convert.ToString(tbl.Rows[0]["MaLaiSuat"]);
                ku.TKCHOVAY= Convert.ToString(tbl.Rows[0]["TKChoVay"]);
                ku.THULAI= Convert.ToString(tbl.Rows[0]["ThuLai"]);
                ku.TKNOQUAHAN= Convert.ToString(tbl.Rows[0]["TKNoQuaHan"]);
                ku.THUlAIQUAHAN= Convert.ToString(tbl.Rows[0]["ThuLaiQuaHan"]);
                ku.MAMUCDICHVAY= Convert.ToString(tbl.Rows[0]["MaMucDichVay"]);
                ku.MAHTDAMBAO= Convert.ToString(tbl.Rows[0]["MaHTDamBao"]);
                ku.MANV= Convert.ToString(tbl.Rows[0]["MaNV"]);
                ku.MATHOIHANVAY= Convert.ToString(tbl.Rows[0]["MaThoiHanVay"]);
                ku.MAHTVAY= Convert.ToString(tbl.Rows[0]["MaHTVay"]);
                ku.MADONVIUYTHAC= Convert.ToString(tbl.Rows[0]["MaDonViUyThac"]);
                ku.MAVUNG= Convert.ToString(tbl.Rows[0]["MaVung"]);
                ku.TRANOGOCDINHKY= Convert.ToInt32(tbl.Rows[0]["TraNoGocDinhKy"]);
                ku.HOTENTHUAKE= Convert.ToString(tbl.Rows[0]["HoTenThuaKe"]);

            }
            return ku;
        }

        public void TimHoSoKheUocTheoMaSoKUDS(String maku)
        {

           HSKULayer.TimHoSoKheUocTheoMa(maku);
        }


        public void TimHoSoKheUocTheoMaSoKU(DataGridView dg, BindingNavigator bn, TextBox txtMaSoKU, ComboBox cmbMaDoiTac, ComboBox cmbMaLoaiVay, ComboBox cmbMaKVNV, ComboBox cmbMaKieuTra, ComboBox cmbMaChuongTrinh, ComboBox cmbTenToTruong, NumericUpDown numNhuCau
            , DateTimePicker dtpNgayDuyet, NumericUpDown numMucDuyet, DateTimePicker dtpNgayVay, DateTimePicker dtpNgayTra, ComboBox cmbMaLaiSuat, ComboBox cmbMaTaiKhoan, ComboBox cmbThuLai, ComboBox cmbTKNoQuaHan, ComboBox cmbThuLaiQuaHan, ComboBox cmbMDVay, ComboBox cmbMaHTDamBao
            , ComboBox cmbMaNV, ComboBox cmbMaHTVay, ComboBox cmbMaThoiHanVay, ComboBox cmbMaDVUT, ComboBox cmbMaVung, ComboBox cmbHotenThuaKe, NumericUpDown numTraNoGocDinhKy, NumericUpDown numSoTienHienTai, String maku)
        {

            BindingSource bs = new BindingSource();
            bs.DataSource = HSKULayer.TimHoSoKheUocTheoMa(maku);
            bn.BindingSource = bs;
            dg.DataSource = bs;

            txtMaSoKU.DataBindings.Clear();
            txtMaSoKU.DataBindings.Add("Text", bs, "MaSoKU");

            cmbMaDoiTac.DataBindings.Clear();
            cmbMaDoiTac.DataBindings.Add("SelectedValue", bs, "MaDoiTac");

            cmbMaLoaiVay.DataBindings.Clear();
            cmbMaLoaiVay.DataBindings.Add("SelectedValue", bs, "MaLoaiVay");

            cmbMaKVNV.DataBindings.Clear();
            cmbMaKVNV.DataBindings.Add("SelectedValue", bs, "MaKVNV");

            cmbMaKieuTra.DataBindings.Clear();
            cmbMaKieuTra.DataBindings.Add("SelectedValue", bs, "MaKieuTra");

            cmbTenToTruong.DataBindings.Clear();
            cmbTenToTruong.DataBindings.Add("SelectedValue", bs, "TenToTruong");

            numNhuCau.DataBindings.Clear();
            numNhuCau.DataBindings.Add("Value", bs, "NhuCau");

            dtpNgayDuyet.DataBindings.Clear();
            dtpNgayDuyet.DataBindings.Add("Value", bs, "NgayDuyet");

            numMucDuyet.DataBindings.Clear();
            numMucDuyet.DataBindings.Add("Value", bs, "MucDuyet");

            dtpNgayVay.DataBindings.Clear();
            dtpNgayVay.DataBindings.Add("Value", bs, "NgayVay");

            dtpNgayTra.DataBindings.Clear();
            dtpNgayTra.DataBindings.Add("Value", bs, "NgayTra");

            cmbMaLaiSuat.DataBindings.Clear();
            cmbMaLaiSuat.DataBindings.Add("SelectedValue", bs, "MaLaiSuat");

            cmbMaTaiKhoan.DataBindings.Clear();
            cmbMaTaiKhoan.DataBindings.Add("SelectedValue", bs, "TKChoVay");

            cmbThuLai.DataBindings.Clear();
            cmbThuLai.DataBindings.Add("SelectedValue", bs, "ThuLai");

            cmbTKNoQuaHan.DataBindings.Clear();
            cmbTKNoQuaHan.DataBindings.Add("SelectedValue", bs, "TKNoQuaHan");

            cmbThuLaiQuaHan.DataBindings.Clear();
            cmbThuLaiQuaHan.DataBindings.Add("SelectedValue", bs, "ThuLaiQuaHan");

            cmbMDVay.DataBindings.Clear();
            cmbMDVay.DataBindings.Add("SelectedValue", bs, "MaMucDichVay");

            cmbMaHTDamBao.DataBindings.Clear();
            cmbMaHTDamBao.DataBindings.Add("SelectedValue", bs, "MaHTDamBao");

            cmbMaNV.DataBindings.Clear();
            cmbMaNV.DataBindings.Add("SelectedValue", bs, "MaNV");

            cmbMaHTVay.DataBindings.Clear();
            cmbMaHTVay.DataBindings.Add("SelectedValue", bs, "MaHTVay");

            cmbMaThoiHanVay.DataBindings.Clear();
            cmbMaThoiHanVay.DataBindings.Add("SelectedValue", bs, "MaThoiHanVay");

            cmbMaDVUT.DataBindings.Clear();
            cmbMaDVUT.DataBindings.Add("SelectedValue", bs, "MaDonViUyThac");

            cmbMaVung.DataBindings.Clear();
            cmbMaVung.DataBindings.Add("SelectedValue", bs, "MaVung");

            numTraNoGocDinhKy.DataBindings.Clear();
            numTraNoGocDinhKy.DataBindings.Add("Value", bs, "TraNoGocDinhKy");

            cmbHotenThuaKe.DataBindings.Clear();
            cmbHotenThuaKe.DataBindings.Add("SelectedValue", bs, "HoTenThuaKe");

            numSoTienHienTai.DataBindings.Clear();
            numSoTienHienTai.DataBindings.Add("Value", bs, "SoTienHienTai");
        }



        public void TimHSKUTheoMaDoiTacDS(String madoitac)
        {
            HSKULayer.TimHoSoKheUocTheoMaDoiTac(madoitac);
        }
        public void TimHSKUTheoMaDoiTac(DataGridView dg, BindingNavigator bn, TextBox txtMaSoKU, ComboBox cmbMaDoiTac, ComboBox cmbMaLoaiVay, ComboBox cmbMaKVNV, ComboBox cmbMaKieuTra, ComboBox cmbMaChuongTrinh, ComboBox cmbTenToTruong, NumericUpDown numNhuCau
            , DateTimePicker dtpNgayDuyet, NumericUpDown numMucDuyet, DateTimePicker dtpNgayVay, DateTimePicker dtpNgayTra, ComboBox cmbMaLaiSuat, ComboBox cmbMaTaiKhoan, ComboBox cmbThuLai, ComboBox cmbTKNoQuaHan, ComboBox cmbThuLaiQuaHan, ComboBox cmbMDVay, ComboBox cmbMaHTDamBao
            , ComboBox cmbMaNV, ComboBox cmbMaHTVay, ComboBox cmbMaThoiHanVay, ComboBox cmbMaDVUT, ComboBox cmbMaVung, ComboBox cmbHotenThuaKe, NumericUpDown numTraNoGocDinhKy, NumericUpDown numSoTienHienTai, String madoitac)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = HSKULayer.TimHoSoKheUocTheoMaDoiTac(madoitac);
            bn.BindingSource = bs;
            dg.DataSource = bs;

            txtMaSoKU.DataBindings.Clear();
            txtMaSoKU.DataBindings.Add("Text", bs, "MaSoKU");

            cmbMaDoiTac.DataBindings.Clear();
            cmbMaDoiTac.DataBindings.Add("SelectedValue", bs, "MaDoiTac");

            cmbMaLoaiVay.DataBindings.Clear();
            cmbMaLoaiVay.DataBindings.Add("SelectedValue", bs, "MaLoaiVay");

            cmbMaKVNV.DataBindings.Clear();
            cmbMaKVNV.DataBindings.Add("SelectedValue", bs, "MaKVNV");

            cmbMaKieuTra.DataBindings.Clear();
            cmbMaKieuTra.DataBindings.Add("SelectedValue", bs, "MaKieuTra");

            cmbTenToTruong.DataBindings.Clear();
            cmbTenToTruong.DataBindings.Add("SelectedValue", bs, "TenToTruong");

            numNhuCau.DataBindings.Clear();
            numNhuCau.DataBindings.Add("Value", bs, "NhuCau");

            dtpNgayDuyet.DataBindings.Clear();
            dtpNgayDuyet.DataBindings.Add("Value", bs, "NgayDuyet");

            numMucDuyet.DataBindings.Clear();
            numMucDuyet.DataBindings.Add("Value", bs, "MucDuyet");

            dtpNgayVay.DataBindings.Clear();
            dtpNgayVay.DataBindings.Add("Value", bs, "NgayVay");

            dtpNgayTra.DataBindings.Clear();
            dtpNgayTra.DataBindings.Add("Value", bs, "NgayTra");

            cmbMaLaiSuat.DataBindings.Clear();
            cmbMaLaiSuat.DataBindings.Add("SelectedValue", bs, "MaLaiSuat");

            cmbMaTaiKhoan.DataBindings.Clear();
            cmbMaTaiKhoan.DataBindings.Add("SelectedValue", bs, "TKChoVay");

            cmbThuLai.DataBindings.Clear();
            cmbThuLai.DataBindings.Add("SelectedValue", bs, "ThuLai");

            cmbTKNoQuaHan.DataBindings.Clear();
            cmbTKNoQuaHan.DataBindings.Add("SelectedValue", bs, "TKNoQuaHan");

            cmbThuLaiQuaHan.DataBindings.Clear();
            cmbThuLaiQuaHan.DataBindings.Add("SelectedValue", bs, "ThuLaiQuaHan");

            cmbMDVay.DataBindings.Clear();
            cmbMDVay.DataBindings.Add("SelectedValue", bs, "MaMucDichVay");

            cmbMaHTDamBao.DataBindings.Clear();
            cmbMaHTDamBao.DataBindings.Add("SelectedValue", bs, "MaHTDamBao");

            cmbMaNV.DataBindings.Clear();
            cmbMaNV.DataBindings.Add("SelectedValue", bs, "MaNV");

            cmbMaHTVay.DataBindings.Clear();
            cmbMaHTVay.DataBindings.Add("SelectedValue", bs, "MaHTVay");

            cmbMaThoiHanVay.DataBindings.Clear();
            cmbMaThoiHanVay.DataBindings.Add("SelectedValue", bs, "MaThoiHanVay");

            cmbMaDVUT.DataBindings.Clear();
            cmbMaDVUT.DataBindings.Add("SelectedValue", bs, "MaDonViUyThac");

            cmbMaVung.DataBindings.Clear();
            cmbMaVung.DataBindings.Add("SelectedValue", bs, "MaVung");

            numTraNoGocDinhKy.DataBindings.Clear();
            numTraNoGocDinhKy.DataBindings.Add("Value", bs, "TraNoGocDinhKy");

            cmbHotenThuaKe.DataBindings.Clear();
            cmbHotenThuaKe.DataBindings.Add("SelectedValue", bs, "HoTenThuaKe");

            numSoTienHienTai.DataBindings.Clear();
            numSoTienHienTai.DataBindings.Add("Value", bs, "SoTienHienTai");
        }

        public void HienThiCombobox(ComboBox cmb)
        {
            cmb.DataSource = HSKULayer.DanhSachHoSoKheUoc();
            cmb.DisplayMember = "MaSoKU";
            cmb.ValueMember = "MaSoKU";

        }


        public DataRow NewRow()
        {
            return HSKULayer.NewRow();
        }
        public void Add(DataRow row)
        {
            HSKULayer.Add(row);
        }
        public bool Save()
        {
            return HSKULayer.Save();
        }

        public void Update()
        {

            bs.MoveNext();
            HSKULayer.Save();
        }

        GiaiNganLayer GNplayer = new GiaiNganLayer();
        public void CapNhatSoTienHienTai(String maso,  long sotienhientai)
        {
         
            HSKULayer.UPDATE(maso, sotienhientai);
            //DataTable tbl = HSKULayer.LayHoSoKheUocTheoMa(maso);
            //DataTable tbl1 = GNplayer.LayGiaiNganTheoKU(maso);
            //if (tbl.Rows.Count > 0)
            //{
            //    //long conlai = Convert.ToInt64(tbl1.Rows[0]["ConLai"]);
            //   // long tong_gia = Convert.ToInt64(tbl.Rows[0]["DON_GIA_NHAP"]);
            //    //if (conlai != sotienhientai)
            // //   {
            //        //long thanh_tien = gia_moi * so_luong + tong_gia * tong_so;
            //        //tong_so += so_luong;
            //        //tbl.Rows[0]["DON_GIA_NHAP"] = thanh_tien / tong_so;
            //     tbl.Rows[0]["SoTienHienTai"] = Convert.ToInt64(tbl1.Rows[0]["ConLai"]);
            //    //}
            //    HSKULayer.Save();
            //}

        }

        public void CapNhatNgayTinhLai(String maso, DateTime ngaytinhlai)
        {

            HSKULayer.UPDATENGAY(maso, ngaytinhlai);


        }


    }
}
