--View In hoa don nhap
CREATE VIEW vInHDN
AS
	SELECT tblHoaDonNhap.MaHD,TenNCC,TenMatH,tblChiTietHDN.SoLuong,tblChiTietHDN.SoLuong*tblChiTietHDN.DonGia TongTien,NgayNhap,tblChiTietHDN.DonGia,Thue,DonViTinh,tblHoaDonNhap.GhiChu 
           FROM tblHoaDonNhap INNER JOIN tblChiTietHDN ON tblHoaDonNhap.MaHD=tblChiTietHDN.MaHD
           INNER JOIN tblMatHang ON tblChiTietHDN.MaMatH=tblMatHang.MaMatH
           INNER JOIN tblNhaCungCap ON tblNhaCungCap.MaNCC=tblHoaDonNhap.MaNCC
GO
DROP VIEW vInHDX

--View In hoa don xuat
CREATE VIEW vInHDX
AS
	SELECT tblHoaDonXuat.MaHD,tblNhanVien.TenNhanVien,tblMatHang.TenMatH,tblChiTietHDX.SoLuong,tblChiTietHDX.SoLuong*tblChiTietHDX.DonGia TongTien,tblHoaDonXuat.NgayXuat,tblChiTietHDX.DonGia,Thue,DonViTinh,tblHoaDonXuat.GhiChu
        FROM tblHoaDonXuat INNER JOIN tblChiTietHDX ON tblHoaDonXuat.MaHD=tblChiTietHDX.MaHD
        INNER JOIN tblMatHang ON tblMatHang.MaMatH=tblChiTietHDX.MaMatH
        INNER JOIN tblNhanVien ON tblNhanVien.MaNhanVien=tblHoaDonXuat.MaNhanVien
GO

--View In phieu dat hang
CREATE VIEW vInPhieu
AS
	select tblDatHangCT.MaPhieu,tblDatHangCT.MaMatH,TenMatH,TenKhachH,tblDatHangCT.SoLuong,NgayDat,NgayNhan,DienThoai,GhiChu from tblDatHangCT inner join tblMatHang on tblDatHangCT.MaMatH=tblMatHang.MaMatH
                INNER JOIN tblDatHang ON tblDatHang.MaPhieu=tblDatHangCT.MaPhieu
GO
SELECT* FROM vInPhieu
DROP VIEW vInHDX