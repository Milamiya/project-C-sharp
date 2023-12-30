--CREATE TRIGGER t_GiaBan ON tblMatHang
--FOR INSERT
--AS
	--SELECT* FROM inserted
	--UPDATE GiaBan
	--SET GiaBan = ROUND((((tblMatHang.SoLuong*(tblMatHang.DonGia+20000))+(tblChiTietHDN.SoLuong*(tblChiTietHDN.DonGia+20000)))/(tblMatHang.SoLuong+tblChiTietHDN.SoLuong)),-4)
	--FROM inserted
	--WHERE tblMatHang.MaMatH=inserted.MaMatH
--GO

CREATE TRIGGER t_GiaBan ON tblChiTietHDN 
FOR INSERT, UPDATE
AS
	SELECT* FROM inserted
	UPDATE tblMatHang
	SET tblMatHang.GiaBan = ROUND((((tblMatHang.SoLuong*(tblMatHang.DonGia+20000))+(inserted.SoLuong*(inserted.DonGia+20000)))/(tblMatHang.SoLuong+inserted.SoLuong)),-4)
	FROM inserted
	WHERE tblMatHang.MaMatH=inserted.MaMatH
GO