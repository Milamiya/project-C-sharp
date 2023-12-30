use  QuanLyDaoTao
GO
-------------- Khoi tao database
if exists
(
    select name from sysobjects
    where name = 'Init_Database' and type = 'p'
)
begin
 drop proc Init_Database
end;
GO
create proc Init_Database
as
BEGIN
	DECLARE @Sql NVARCHAR(500) DECLARE @Cursor CURSOR
	SET @Cursor = CURSOR FAST_FORWARD FOR
	SELECT DISTINCT sql = 'ALTER TABLE [' + tc2.TABLE_NAME + '] DROP [' + rc1.CONSTRAINT_NAME + ']'
	FROM INFORMATION_SCHEMA.REFERENTIAL_CONSTRAINTS rc1
	LEFT JOIN INFORMATION_SCHEMA.TABLE_CONSTRAINTS tc2 ON tc2.CONSTRAINT_NAME =rc1.CONSTRAINT_NAME
	OPEN @Cursor FETCH NEXT FROM @Cursor INTO @Sql
	WHILE (@@FETCH_STATUS = 0)
	BEGIN
	Exec SP_EXECUTESQL @Sql
	FETCH NEXT FROM @Cursor INTO @Sql
	END
	CLOSE @Cursor DEALLOCATE @Cursor
	EXEC sp_MSForEachTable 'DROP TABLE ?'
END
GO
EXEC Init_Database
------------------------------------------------------
GO
----------------------------------------------------------
use QuanLyDaoTao

--1 bang giang vien
Create table GiangVien
(
	MaGV varchar(6),
	HoTen nvarchar(30) not null,
	GioiTinh bit,
	DiaChi nvarchar(50),
	MaTrinhDo varchar(5) not null,
	constraint PK_GiangVien primary key(MaGV),
	constraint MaGV_Like check (MaGV like 'GV[0-9][0-9][0-9][0-9]')
)
go
--2 bang trinh do
Create table TrinhDo
(
	MaTrinhDo varchar(5),
	TenTrinhDo nvarchar(30) not null,
	HeSoLuong float not null,
	constraint PK_TrinhDo primary key(MaTrinhDo)
)
go
--3 bang nganh hoc
Create table NganhHoc
(
	MaNganh varchar(5),
	TenNganh nvarchar(30) not null,
	Khoa nvarchar(30),
	constraint PK_NganhHoc primary key(MaNganh)
)
go
--4 bang lop hoc
Create table Lop
(
	MaLop varchar(6),
	MaNganh varchar(5) not null,
	constraint PK_Lop primary key(MaLop),
	constraint MaLop_Like check (MaLop like '[A-Z][A-Z][0-9][0-9][A-Z][A-Z]')
)
go
--5 bang mon hoc 
Create table MonHoc
(
	MaMH varchar(6),
	TenMH nvarchar(30) not null,
	STC tinyint,
	LyThuyet tinyint,
	ThucHanh tinyint default(0),
	constraint PK_MonHoc primary key(MaMH),
	constraint MaMH_Like check (MaMH like '[A-Z][A-Z][A-Z][0-9][0-9][0-9]')
)
go
--6 bang phong hoc
Create table PhongHoc
(
	MaPhong varchar(6),
	ChucNang nvarchar(30) default(N'Lý thuyết'),
	SucChua int not null,
	DiaChi nvarchar(50),
	constraint PK_PhongHoc primary key(MaPhong)
)
go
--7 bang phan cong giang day
Create table PhanCong
(
	MaPC varchar(7),
	MaGV varchar(6) not null,
	MaMH varchar(6) not null,
	MaLop varchar(6) not null,
	HocKy tinyint not null,
	NamHoc int default(Year(GetDate())) ,
	constraint PK_PhanCong primary key(MaPC),
	constraint MaPC_Like check (MaPC like 'PC[0-9][0-9][0-9][0-9][0-9]'),
	constraint MaGV_PhanCong_Like check (MaGV like 'GV[0-9][0-9][0-9][0-9]'),
	constraint MaMH_PhanCong_Like check (MaMH like '[A-Z][A-Z][A-Z][0-9][0-9][0-9]')
)
go
--8 bang buoi hoc
Create table BuoiHoc
(
	BuoiHoc int,
	Ngay date not null,
	TietBatDau tinyint not null,
	SoTiet tinyint not null,
	constraint PK_BuoiHoc primary key(BuoiHoc)
)
go
--9 bang de nghi
Create table DeNghi
(
	MaPC varchar(7),
	BuoiHoc int,
	constraint PK_DeNghi primary key(MaPC, BuoiHoc),
	constraint MaPC_DeNghi_Like check (MaPC like 'PC[0-9][0-9][0-9][0-9][0-9]'),
)
go
--10 bang thoi khoa bieu
Create table ThoiKhoaBieu
(
	MaPC varchar(7),
	BuoiHoc int,
	MaPhong varchar(6) not null,
	CoDay bit not null,
	DaThanhToan bit not null,
	constraint PK_ThoiKhoaBieu primary key(MaPC, BuoiHoc),
	constraint MaPC_ThoiKhoaBieu_Like check (MaPC like 'PC[0-9][0-9][0-9][0-9][0-9]')
)
go
--11 bang nguoi sung
Create table NguoiDung
(
	TenDangNhap varchar(20),
	MatKhau varchar(35) not null,
	TenNguoiDung nvarchar(30),
	Quyen tinyint default(0) not null ,
	MoTaQuyen nvarchar(50),
	constraint PK_NguoiDung primary key(TenDangNhap)
)
go
--insert du lieu
INSERT [dbo].[NguoiDung] ([TenDangNhap], [MatKhau], [TenNguoiDung], [Quyen], [MoTaQuyen]) VALUES (N'admin', N'202cb962ac59075b964b07152d234b70', N'Nguyễn Thiện An', 0, N'Admin')
INSERT [dbo].[NguoiDung] ([TenDangNhap], [MatKhau], [TenNguoiDung], [Quyen], [MoTaQuyen]) VALUES (N'qldt01', N'202cb962ac59075b964b07152d234b70', N'Trương Nguyễn Huỳnh Anh', 1, N'Giáo vụ')
INSERT [dbo].[NguoiDung] ([TenDangNhap], [MatKhau], [TenNguoiDung], [Quyen], [MoTaQuyen]) VALUES (N'qldt02', N'202cb962ac59075b964b07152d234b70', N'Khưu Lê Công', 1, N'Giáo vụ')
go
--12 bang sinh vien
Create table SinhVien
(
	MSSV varchar(9),
	HoTen nvarchar(30),
	NgaySinh Date,
	DiaChi nvarchar(50),
	MaLop varchar(6), 
	constraint PK_SinhVien primary key(MSSV),
	constraint MaLop_SinhVien_Like check (MaLop like '[A-Z][A-Z][0-9][0-9][A-Z][A-Z]')
)
go
--1 bang giang vien
Alter table GiangVien add constraint FK_GiangVien_TrinhDo 
	foreign key(MaTrinhDo) references TrinhDo(MaTrinhDo)
go
--4 bang lop
Alter table Lop add constraint FK_Lop_NganhHoc 
	foreign key(MaNganh) references NganhHoc(MaNganh)
go
--7 bang phan cong
Alter table PhanCong add constraint FK_PhanCong_GiangVien 
	foreign key(MaGV) references GiangVien(MaGV)
go
Alter table PhanCong add constraint FK_PhanCong_MonHoc 
	foreign key(MaMH) references MonHoc(MaMH)
go
Alter table PhanCong add constraint FK_PhanCong_Lop 
	foreign key(MaLop) references Lop(MaLop)
go
--9 bang de nghi
Alter table DeNghi add constraint FK_DeNghi_PhanCong
	foreign key(MaPC) references PhanCong(MaPC)
go
Alter table DeNghi add constraint FK_DeNghi_BuoiHoc
	foreign key(BuoiHoc) references BuoiHoc(BuoiHoc)
go
--10 bang thoi khoa bieu
Alter table ThoiKhoaBieu add constraint FK_ThoiKhoaBieu_PhanCong
	foreign key(MaPC) references PhanCong(MaPC)
go
Alter table ThoiKhoaBieu add constraint FK_ThoiKhoaBieu_BuoiHoc
	foreign key(BuoiHoc) references BuoiHoc(BuoiHoc)
go
Alter table ThoiKhoaBieu add constraint FK_ThoiKhoaBieu_PhongHoc
	foreign key(MaPhong) references PhongHoc(MaPhong)
go
--12 bang sinh vien
Alter table SinhVien add constraint FK_SinhVien_Lop 
	foreign key(MaLop) references Lop(MaLop)
go
--Function chuyển có dấu thành không dấu
GO
if exists
(
    select name from sysobjects
    where name = 'fnChuyenKhongDau' and type = 'fn'
)
begin
 drop function fnChuyenKhongDau
end;
GO
CREATE FUNCTION dbo.fnChuyenKhongDau(@strInput NVARCHAR(50)) 
RETURNS NVARCHAR(50)
AS
BEGIN     
    IF @strInput IS NULL RETURN @strInput
    IF @strInput = '' RETURN @strInput
    DECLARE @RT NVARCHAR(50)
    DECLARE @SIGN_CHARS NCHAR(136)
    DECLARE @UNSIGN_CHARS NCHAR (136)

    SET @SIGN_CHARS       = N'ăâđêôơưàảãạáằẳẵặắầẩẫậấèẻẽẹéềểễệếìỉĩịíòỏõọóồổỗộốờởỡợớùủũụúừửữựứỳỷỹỵýĂÂĐÊÔƠƯÀẢÃẠÁẰẲẴẶẮẦẨẪẬẤÈẺẼẸÉỀỂỄỆẾÌỈĨỊÍÒỎÕỌÓỒỔỖỘỐỜỞỠỢỚÙỦŨỤÚỪỬỮỰỨỲỶỸỴÝ'+NCHAR(272)+ NCHAR(208)
    SET @UNSIGN_CHARS =     N'aadeoouaaaaaaaaaaaaaaaeeeeeeeeeeiiiiiooooooooooooooouuuuuuuuuuyyyyyAADEOOUAAAAAAAAAAAAAAAEEEEEEEEEEIIIIIOOOOOOOOOOOOOOOUUUUUUUUUUYYYYYDD'

    DECLARE @COUNTER int
    DECLARE @COUNTER1 int
    SET @COUNTER = 1
 
    WHILE (@COUNTER <=LEN(@strInput))
    BEGIN   
      SET @COUNTER1 = 1
      --Tim trong chuoi mau
       WHILE (@COUNTER1 <=LEN(@SIGN_CHARS)+1)
       BEGIN
     IF UNICODE(SUBSTRING(@SIGN_CHARS, @COUNTER1,1)) = UNICODE(SUBSTRING(@strInput,@COUNTER ,1) )
     BEGIN           
          IF @COUNTER=1
              SET @strInput = SUBSTRING(@UNSIGN_CHARS, @COUNTER1,1) + SUBSTRING(@strInput, @COUNTER+1,LEN(@strInput)-1)                   
          ELSE
              SET @strInput = SUBSTRING(@strInput, 1, @COUNTER-1) +SUBSTRING(@UNSIGN_CHARS, @COUNTER1,1) + SUBSTRING(@strInput, @COUNTER+1,LEN(@strInput)- @COUNTER)    
              BREAK         
               END
             SET @COUNTER1 = @COUNTER1 +1
       END
      --Tim tiep
       SET @COUNTER = @COUNTER +1
    END
    RETURN @strInput
END
GO
--1 function tra ve si so cua 1 lop
create function fc_SiSo(@maLop varchar(6))
returns tinyint
as
begin
	declare @kq tinyint
	set @kq = (select count(MSSV) from SinhVien where MaLop=@maLop)
	if(@kq is null)
		return 0
	return @kq;
end
go
--proc 
--1 proc hiển thị các thông tin cơ bản của tất cả các phân công
create proc sp_HienThiPhanCong
as
begin
	select p.MaPC, g.HoTen as GiangVien, m.TenMH as MonHoc, l.MaLop as Lop, p.HocKy, p.NamHoc
	from PhanCong p, MonHoc m, GiangVien g, Lop l
	where p.MaGV = g.MaGV and p.MaLop = l.MaLop and p.MaMH = m.MaMH
end
go
--2 proc hiển thị thông tin cơ bản của một phân công giảng dạy
create proc sp_ThongTinPhanCongTheoGV
	@maGV varchar(6),
	@hocKy tinyint,
	@namHoc int
as
begin
	select mh.TenMH, pc.MaLop, pc.MaPC, mh.MaMH
	from MonHoc mh, PhanCong pc
	where pc.MaGV=@maGV and pc.HocKy=@hocKy and pc.NamHoc=@namHoc
	      and pc.MaMH=mh.MaMH
end
go
--3 proc load buổi học trong một tuần
create proc sp_BuoiHocTheoTuan
	@ngayDauTuan date
as
begin
	select * 
	from BuoiHoc
	where Ngay between @ngayDauTuan and DATEADD(day,7,@ngayDauTuan)
end
go
--4 proc load đề nghị theo tuần
create proc sp_DeNghiTheoTuan
	@maGV varchar(6),
	@ngayDauTuan date
as
begin
	select d.BuoiHoc, d.MaPC
	from DeNghi d, PhanCong pc, BuoiHoc bh
	where d.MaPC=pc.MaPC and pc.MaGV=@maGV and d.BuoiHoc=bh.BuoiHoc 
		  and bh.Ngay between @ngayDauTuan and DATEADD(day,7,@ngayDauTuan)
end
go
--5 proc load thong tin cua mot de nghi
create proc sp_ThongTinDeNghi
	@maBuoiHoc int,
	@maPC varchar(7)
as
begin
	select b.Ngay, b.SoTiet, b.TietBatDau, p.MaLop, m.TenMH
	from BuoiHoc b, DeNghi d, PhanCong p, MonHoc m
	where d.BuoiHoc=b.BuoiHoc and d.MaPC=p.MaPC and p.MaMH=m.MaMH
		  and d.BuoiHoc=@maBuoiHoc and d.MaPC=@maPC
end
go
--6 proc load cac de nghi trong mot tuan mà phòng có sức chứa lớn hơn sĩ số các lớp 
--và chưa được xếp thời khóa biểu
create proc sp_DeNghiTheoPhongTrongTuan
	@maPhong varchar(6),
	@ngayDauTuan date
as
begin
	select pc.MaPC, pc.MaGV, gv.HoTen as TenGV, pc.MaMH, mh.TenMH, pc.MaLop,
	       b.BuoiHoc, b.Ngay, b.TietBatDau, b.SoTiet
	from DeNghi d, BuoiHoc b, GiangVien gv, MonHoc mh,
		 (select pc.MaPC, pc.MaGV, pc.MaMH, pc.MaLop
		  from PhanCong pc, PhongHoc ph 
		  where dbo.fc_SiSo(pc.MaLop)<=ph.SucChua and ph.MaPhong=@maPhong) pc
	where d.MaPC=pc.MaPC and b.BuoiHoc=d.BuoiHoc 
	      and b.Ngay between @ngayDauTuan and DATEADD(day,7,@ngayDauTuan)
	      and pc.MaGV=gv.MaGV and pc.MaMH=mh.MaMH
	      and not exists (select * 
	                      from ThoiKhoaBieu
	                      where d.BuoiHoc=BuoiHoc and d.MaPC=MaPC)
	order by b.Ngay, b.TietBatDau, b.SoTiet, gv.MaGV
end
go
--7 load thong tin thời khóa cụ thể của 1 phòng
create proc sp_ThongTinTKB
	@ngayDauTuan date,
	@maPhong varchar(6)
as
begin
	select tkb.MaPC, pc.MaGV, gv.HoTen as TenGV, pc.MaMH, mh.TenMH, pc.MaLop,
	       b.BuoiHoc, b.Ngay, b.TietBatDau, b.SoTiet,
	       tkb.MaPhong, tkb.CoDay, tkb.DaThanhToan
	from ThoiKhoaBieu tkb, BuoiHoc b, GiangVien gv, MonHoc mh, PhanCong pc,
	     (select t.MaPC,t.BuoiHoc
	      from ThoiKhoaBieu t, BuoiHoc h
	      where t.BuoiHoc=h.BuoiHoc 
	            and h.Ngay between @ngayDauTuan and DATEADD(day,7,@ngayDauTuan)) as x
	where tkb.BuoiHoc=b.BuoiHoc and tkb.MaPC=pc.MaPC and pc.MaGV=gv.MaGV 
		  and pc.MaMH=mh.MaMH 
		  and tkb.MaPC=x.MaPC and tkb.BuoiHoc=x.BuoiHoc and tkb.MaPhong=@maPhong
	order by b.Ngay, b.TietBatDau, b.SoTiet, pc.MaGV
end
go
--8 load thong tin chi tiet cua 1 thoi khoa bieu
create proc sp_ThongTinMotTKB
	@maPC varchar(7),
	@maBuoiHoc int
as
begin
	select tkb.MaPC, pc.MaGV, gv.HoTen as TenGV, pc.MaMH, mh.TenMH, pc.MaLop,
	       b.BuoiHoc, b.Ngay, b.TietBatDau, b.SoTiet,
	       tkb.MaPhong, tkb.CoDay, tkb.DaThanhToan
	from ThoiKhoaBieu tkb, PhanCong pc, BuoiHoc b, GiangVien gv, MonHoc mh
	where tkb.BuoiHoc=b.BuoiHoc and tkb.MaPC=pc.MaPC and pc.MaGV=gv.MaGV 
		  and pc.MaMH=mh.MaMH and tkb.MaPC=@maPC and tkb.BuoiHoc=@maBuoiHoc
end
go
--9 load thong tin cua buoi hoc va phan cong
create proc sp_ThongPhanCongBuoiHoc
	@maPC varchar(7),
	@maBuoiHoc int
as
begin
	select pc.MaPC, pc.MaGV, gv.HoTen as TenGV, pc.MaMH, mh.TenMH, pc.MaLop,
	       b.BuoiHoc, b.Ngay, b.TietBatDau, b.SoTiet
	from PhanCong pc, BuoiHoc b, GiangVien gv, MonHoc mh
	where pc.MaGV=gv.MaGV and pc.MaMH=mh.MaMH 
	      and pc.MaPC=@maPC and b.BuoiHoc=@maBuoiHoc
end
go
--10 load thong tin chi tiet thoi khoa bieu 1 tuan cua 1 sv
create proc sp_XemTKBSinhVien
	@mssv varchar(9),
	@ngayDauTuan date
as
begin
	select pc1.MaPC, pc1.MaGV, gv.HoTen as TenGV, pc1.MaMH, mh.TenMH, pc1.MaLop,
	       b.BuoiHoc, b.Ngay, b.TietBatDau, b.SoTiet,
	       tkb.MaPhong, tkb.CoDay, tkb.DaThanhToan,
	       p.ChucNang, p.DiaChi, p.SucChua
	from ThoiKhoaBieu tkb, BuoiHoc b, GiangVien gv, MonHoc mh, PhongHoc p,
	     (select distinct pc.MaPC, pc.MaGV, pc.MaLop, pc.MaMH
	      from PhanCong pc, ThoiKhoaBieu tkb, 
	           BuoiHoc b, Lop l, SinhVien sv
	      where pc.MaPC=tkb.MaPC and tkb.BuoiHoc=b.BuoiHoc
	            and pc.MaLop=l.MaLop and sv.MaLop=l.MaLop
	            and sv.MSSV=@mssv 
	            and b.Ngay between @ngayDauTuan and DATEADD(day,7,@ngayDauTuan)) pc1
	where tkb.BuoiHoc=b.BuoiHoc and tkb.MaPhong=p.MaPhong and tkb.MaPC=pc1.MaPC
		  and gv.MaGV=pc1.MaGV and mh.MaMH=pc1.MaMH
	order by b.Ngay, b.TietBatDau, b.SoTiet, pc1.MaGV
end
go
--11 load thong tin chi tiet thoi khoa bieu 1 tuan cua 1 giang vien
create proc sp_XemTKBGiangVien
	@maGV varchar(6),
	@ngayDauTuan date
as
begin
	select pc1.MaPC, pc1.MaGV, gv.HoTen as TenGV, pc1.MaMH, mh.TenMH, pc1.MaLop,
	       b.BuoiHoc, b.Ngay, b.TietBatDau, b.SoTiet,
	       tkb.MaPhong, tkb.CoDay, tkb.DaThanhToan,
	       p.ChucNang, p.DiaChi, p.SucChua
	from ThoiKhoaBieu tkb, BuoiHoc b, GiangVien gv, MonHoc mh, PhongHoc p,
	     (select distinct pc.MaPC, pc.MaGV, pc.MaLop, pc.MaMH
	      from PhanCong pc, ThoiKhoaBieu tkb, 
	           BuoiHoc b, Lop l, GiangVien gv
	      where pc.MaPC=tkb.MaPC and tkb.BuoiHoc=b.BuoiHoc
	            and pc.MaLop=l.MaLop and gv.MaGV=@maGV
	            and gv.MaGV=pc.MaGV
	            and b.Ngay between @ngayDauTuan and DATEADD(day,7,@ngayDauTuan)) pc1
	where tkb.BuoiHoc=b.BuoiHoc and tkb.MaPhong=p.MaPhong and tkb.MaPC=pc1.MaPC
		  and gv.MaGV=pc1.MaGV and mh.MaMH=pc1.MaMH
	order by b.Ngay, b.TietBatDau, b.SoTiet, pc1.MaGV
end
go
--12 proc hien thi thong tin cua tat ca giang vien
create proc sp_ThongTinGiangVien
as
begin
	select MaGV, HoTen, GioiTinh, TenTrinhDo, HeSoLuong as LuongTiet
	from GiangVien gv, TrinhDo td
	where gv.MaTrinhDo=td.MaTrinhDo
end
go
--proc 13 load thong tin thoi khoa bieu de dua len form thanh toan
create proc sp_ThongTinThanhToan
	@maGV varchar(6),
	@ngayBD date,
	@ngayKT date
as
begin
	select pc1.MaPC, pc1.MaGV, gv.HoTen as TenGV, pc1.MaMH, mh.TenMH, pc1.MaLop,
	       b.BuoiHoc, b.Ngay, b.TietBatDau, b.SoTiet,
	       tkb.MaPhong, tkb.CoDay, tkb.DaThanhToan,
	       p.ChucNang, p.DiaChi, p.SucChua
	from ThoiKhoaBieu tkb, BuoiHoc b, GiangVien gv, MonHoc mh, PhongHoc p,
	     (select distinct pc.MaPC, pc.MaGV, pc.MaLop, pc.MaMH, b.BuoiHoc
	      from PhanCong pc, ThoiKhoaBieu tkb, 
	           BuoiHoc b, Lop l, GiangVien gv
	      where pc.MaPC=tkb.MaPC and tkb.BuoiHoc=b.BuoiHoc
	            and pc.MaLop=l.MaLop and gv.MaGV=@maGV
	            and gv.MaGV=pc.MaGV
	            and b.Ngay between @ngayBD and @ngayKT) pc1
	where tkb.BuoiHoc=b.BuoiHoc and tkb.MaPhong=p.MaPhong and tkb.MaPC=pc1.MaPC
		  and gv.MaGV=pc1.MaGV and mh.MaMH=pc1.MaMH
		  and b.Ngay between @ngayBD and @ngayKT
		  and pc1.BuoiHoc=tkb.BuoiHoc
	order by b.Ngay, b.TietBatDau, b.SoTiet, pc1.MaGV
end
go
--trigger
--1 trigger update nguoi dung khi update sinh vien
create trigger tg_SinhVien_update
	on SinhVien
	for update
	as
		begin
			declare @mssv varchar(9), @tenSV nvarchar(50)
			set @mssv=(select MSSV from inserted)
			set @tenSV=(select HoTen from inserted)
			update NguoiDung set TenNguoiDung = @tenSV where TenDangNhap = @mssv
		end
go
--2 trigger update nguoi dung khi update giang vien
create trigger tg_GiangVien_update
	on GiangVien
	for update
	as
		begin
			declare @maGV varchar(8), @tenGV nvarchar(50)
			set @maGV=(select MaGV from inserted)
			set @tenGV=(select HoTen from inserted)
			update NguoiDung set TenNguoiDung = @tenGV where TenDangNhap = @maGV
		end
go
--3 trigger xoa nguoi dung khi xoa sinh vien
create trigger tg_SinhVien_delete
	on SinhVien
	for delete
	as
		begin
			declare @mssv varchar(5)
			set @mssv=(select MSSV from deleted)
			delete from NguoiDung where TenDangNhap = @mssv
			if(@@error<>0)
				begin
					rollback tran
					return
				end
		end
go
--4 trigger xoa nguoi dung khi xoa giang vien
create trigger tg_GiangVien_delete
	on GiangVien
	for delete
	as
		begin
			declare @maGV varchar(5)
			set @maGV=(select MaGV from deleted)
			delete from NguoiDung where TenDangNhap = @maGV
			if(@@error<>0)
				begin
					rollback tran
					return
				end
		end
go