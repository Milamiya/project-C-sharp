
-------------------------Tao CSDL Quan Ly Ben Xe phuc vu cho cac ben xe khach------------------------
-----Database is written by group simple: Nguyen Minh Tan, Bui Thanh Thoai, Tran Van Tu--------------

/* Kiem tra Database 'QuanLyBenXe' da ton tai chua, neu co ta se xoa va tao moi */
--If Exists (Select name From sysdatabases where name = 'QuanLyBenXe')
Drop Database QuanLyBenXe
Go
-------------Tao Database moi
Create database QuanLyBenXe
Go
------------Xem thong tin database vua tao
Exec sp_helpdb QuanLyBenXe
Go
------Chuyen vao database vua tao de su dung
Use QuanLyBenXe
Go

-----------------------------------Tao Bang------------------------------

------------------------------Tabl1.NguoiDung----------------------------
-------------------------------------------------------------------------
create table NguoiDung
(
	IdNguoiDung varchar(30) not null,
	PassND varchar(30),
	HoTen nvarchar(30) not null,
	NgaySinh datetime,
	GioiTinh nvarchar(3) not null,
	DiaChi nvarchar(100),
	SoDT varchar(15),
	IdLoaiND varchar(30) not null
)

------------------------------------Tabl2.LoaiNguoiDung----------------------
-----------------------------------------------------------------------------
create table LoaiNguoiDung
(
	IdLoaiND varchar(30) not null,
	TenLoaiND nvarchar(30) not null
)

create table PhanQuyen
(
	IdNhanVien varchar(30) not null,
	Xe int not null,
	TuyenXe int not null,
	ThoiDiem int not null,
	ChuyenXe int not null,
	BanVe int not null
)
------------------------------------Tabl3.Xe-----------------------------------------
-------------------------------------------------------------------------------------
create table Xe
(
	So_Xe varchar(8) not null,
	Hieu_Xe varchar(50),
	Doi_Xe varchar(4),
	So_Cho_Ngoi int
)

-----------------------------------Tabl4.DiaDiem--------------------------------
--------------------------------------------------------------------------------
create table DiaDiem
(
	IdDiaDiem varchar(30) not null,
	TenDiaDiem nvarchar(30) not null
)

------------------------------------Tabl5.TuyenXe-----------------------------
------------------------------------------------------------------------------
create table TuyenXe
(
	IdTuyen varchar(30) not null,
	TenTuyen nvarchar(30) unique,
	DiaDiemDi nvarchar(30),
	DiaDiemDen nvarchar(30)
)

------------------------------------Tabl5.ThoiDiem----------------------------------
------------------------------------------------------------------------------------
create table ThoiDiem
(
	IdThoiDiem varchar(30) not null,
	Ngay datetime not null,
	Gio varchar(10) not null,
)

-----------------------------------Tabl6.ChiTietTuyen-----------------------------
----------------------------------------------------------------------------------
create table ChiTietTuyen
(
	IdTuyen varchar(30) not null,
	IdThoiDiem varchar(30) not null
)

------------------------------------Tabl7.ChuyenXe------------------------------------
--------------------------------------------------------------------------------------
create table ChuyenXe
(
	IdChuyen varchar(30) not null,
	IdTuyen varchar(30),
	NgayDi datetime,
	Gio varchar(10),
	So_Xe varchar(8)
)
------------------------------------Tabl8.ChoNgoi---------------------------------------
----------------------------------------------------------------------------------------
create table ChoNgoi
(
	IdChuyen varchar(30) not null,
	So_Xe varchar(8) not null,
	TenChoNgoi nvarchar(10)not null
)


------------------------------------Tabl10.BanVe-----------------------------------------
-----------------------------------------------------------------------------------------
create table BanVe
(
	IdVe varchar(30) not null,
	IdChuyen varchar(30),
	TenHanhKhach nvarchar(30),
	SDTHanhKhach int
)
Go
---------------------------------------------------------------------------
/* Tao 1 function Xe dung de cap nhat tang ma so tu dong cho cac Table () */
---------------------------------------------------------------------------
--Tu dong tang IdThoiDiem cho bang thoi diem
CREATE FUNCTION Addmaso(@makt char(2))
RETURNS char(6)
AS
BEGIN 
	DECLARE @iMaso int 
  	DECLARE @vMaso varchar(9) 
  	IF @makt='TD' SET @iMaso= (SELECT MAX(RIGHT(IdThoiDiem, 4)) FROM ThoiDiem)  	
	IF (@iMaso IS NULL) SET @vMaso= @makt+ CONVERT(varchar(6),'0001')
	ELSE
	BEGIN
		SET @iMaso= @iMaso+1
	    	SET @vMaso= '000'+ CONVERT(varchar,@iMaso) 
	    	SET @vMaso= @makt+ RIGHT(@vMaso,4)
	END
RETURN @vMaso 
END
go
--------------------------Function cho bang chuyen xe
CREATE FUNCTION AddmasoChuyen(@makt char(2))
RETURNS char(6)
AS
BEGIN 
	DECLARE @iMaso int 
  	DECLARE @vMaso varchar(9) 
  	IF @makt='CX' SET @iMaso= (SELECT MAX(RIGHT(IdChuyen, 4)) FROM ChuyenXe)  	
	IF (@iMaso IS NULL) SET @vMaso= @makt+ CONVERT(varchar(6),'0001')
	ELSE
	BEGIN
		SET @iMaso= @iMaso+1
	    	SET @vMaso= '000'+ CONVERT(varchar,@iMaso) 
	    	SET @vMaso= @makt+ RIGHT(@vMaso,4)
	END
RETURN @vMaso 
END
go

--------------------------Function cho bang ban ve
CREATE FUNCTION AddmasoVe(@makt char(2))
RETURNS char(6)
AS
BEGIN 
	DECLARE @iMaso int 
  	DECLARE @vMaso varchar(9) 
  	IF @makt='VE' SET @iMaso= (SELECT MAX(RIGHT(IdVe, 4)) FROM BanVe)  	
	IF (@iMaso IS NULL) SET @vMaso= @makt+ CONVERT(varchar(6),'0001')
	ELSE
	BEGIN
		SET @iMaso= @iMaso+1
	    	SET @vMaso= '000'+ CONVERT(varchar,@iMaso) 
	    	SET @vMaso= @makt+ RIGHT(@vMaso,4)
	END
RETURN @vMaso 
END
go


-----------------------------------Tao Rang Buoc Toan Ven---------------------------------

------------------------------------Tao Khoa Chinh----------------------------------------
------------------------------------------------------------------------------------------
Alter table NguoiDung 
Add constraint pk_NguoiDung primary key(IdNguoiDung)

Alter table LoaiNguoiDung 
Add constraint pk_LoaiNguoiDung primary key(IdLoaiND)

Alter table PhanQuyen
Add constraint pk_PhanQuyen primary key(IdNhanVien, Xe, TuyenXe, ThoiDiem, ChuyenXe, BanVe)

Alter table Xe 
Add constraint pk_Xe primary key(So_Xe)

Alter table DiaDiem
Add constraint pk_DiaDiem primary key(IdDiaDiem)

Alter table TuyenXe 
Add constraint pk_TuyenXe primary key(IdTuyen)

Alter table ThoiDiem
Add constraint pk_ThoiDiem primary key(IdThoiDiem)

Alter table ChiTietTuyen
Add constraint pk_ChiTietTuyen primary key(IdTuyen, IdThoiDiem)

Alter table ChuyenXe
Add constraint pk_ChuyenXe primary key(IdChuyen)

Alter table ChoNgoi 
Add constraint pk_ChoNgoi primary key(IdChuyen, So_Xe, TenChoNgoi)

Alter table BanVe 
Add constraint pk_BanVe primary key(IdVe)

---------------------------------------Tao Khoa Ngoai------------------------------
-----------------------------------------------------------------------------------
Alter table NguoiDung 
Add constraint fk_NguoiDung_LoaiNguoiDung foreign key(IDLoaiND) references LoaiNguoiDung(IDLoaiND)
Go

Alter table PhanQuyen
Add constraint fk_PhanQuyen_NguoiDung foreign key(IdNhanVien) references NguoiDung(IdNguoiDung)
Go

Alter table ChiTietTuyen 
Add constraint fk_ChiTietTuyen_TuyenXe foreign key(IdTuyen) references TuyenXe(IdTuyen)

Alter table ChiTietTuyen 
Add constraint fk_ChiTietTuyen_ThoiDiem foreign key(IdThoiDiem) references ThoiDiem(IdThoiDiem)

Alter table ChuyenXe 
Add constraint fk_ChuyenXe_Xe foreign key(So_Xe) references Xe(So_Xe)

Alter table ChuyenXe 
Add constraint fk_ChuyenXe_TuyenXe foreign key(IdTuyen) references TuyenXe(IdTuyen)

Alter table ChoNgoi
Add constraint fk_ChoNgoi_Xe foreign key(So_Xe) references Xe(So_Xe)

Alter table ChoNgoi
Add constraint fk_ChoNgoi_ChuyenXe foreign key(IdChuyen) references ChuyenXe(IdChuyen)

Alter table BanVe
Add constraint fk_BanVe_ChuyenXe foreign key(IdChuyen) references ChuyenXe(IdChuyen)

-----------------------------------Them Du Lieu Cho Cac Bang---------------------------------

-----------------------------------Tabl.LoaiNguoiDung--------------------------------------------
---------------------------------------------------------------------------------------------
insert into LoaiNguoiDung values('Admin',N'Administrator')
insert into LoaiNguoiDung values('Quan_Ly',N'Quản Lý')
insert into LoaiNguoiDung values('Nhan_Vien',N'Nhân Viên')

-----------------------------------Tabl.NguoiDung--------------------------------------------
---------------------------------------------------------------------------------------------
Insert into NguoiDung(IdNguoiDung, PassND, HoTen, NgaySinh, GioiTinh, DiaChi, SoDT, IdLoaiND) 
Values('lytieulong','aloneforever',N'Bùi Thanh Thoại','1990/06/26',N'Nam',N'1118, Tỉnh lộ 10, P.Tân Tạo, Q.Bình Tân','0922571760','Admin')

Insert into NguoiDung(IdNguoiDung, PassND, HoTen, NgaySinh, GioiTinh, DiaChi, SoDT, IdLoaiND) 
Values('thanhthoai','123456',N'Bùi Thanh Thoại','1990/06/26',N'Nam',N'1118, Tỉnh lộ 10, P.Tân Tạo, Q.Bình Tân','0922571760','Quan_Ly')

Insert into NguoiDung(IdNguoiDung, PassND, HoTen, NgaySinh, GioiTinh, DiaChi, SoDT, IdLoaiND) 
Values('minhtan','123456',N'Nguyễn Minh Tân','1990/03/08',N'Nam',N'48, Nguyễn Ảnh Thủ, Hậu Lân, Bà Điểm, Hóc Môn','0979039205','Quan_Ly')

Insert into NguoiDung(IdNguoiDung, PassND, HoTen, NgaySinh, GioiTinh, DiaChi, SoDT, IdLoaiND) 
Values('vantoan','123456',N'Mai Văn Toàn','1990/10/01',N'Nam',N'123,Hai Bà Trưng, P.1, Q.1','0988101914','Nhan_Vien')

Insert into NguoiDung(IdNguoiDung, PassND, HoTen, NgaySinh, GioiTinh, DiaChi, SoDT, IdLoaiND) 
Values('toanh','123456',N'Trịnh Tố Anh','1990/10/04',N'Nữ',N'284, Lý Thường Kiệt, P.14, Q.10','01212117450','Nhan_Vien')

Insert into NguoiDung(IdNguoiDung, PassND, HoTen, NgaySinh, GioiTinh, DiaChi, SoDT, IdLoaiND) 
Values('mytien','123456',N'Quách Mỹ Tiên','1990/10/17',N'Nữ',N'56, Lý Thái Tổ, P.4, Q.10','0988296997','Nhan_Vien')

--Select * from NguoiDung 


-----------------------------------Tabl.Xe-------------------------------------------------
-------------------------------------------------------------------------------------------
---------------------------------------------------------------------
/* Gan function Addmaso vao cac Table cho tang tu dong ma so*/
---------------------------------------------------------------------

insert into Xe(So_Xe, Hieu_Xe, Doi_Xe, So_Cho_Ngoi) 
values('55Y-7777', 'Ford Transit', '2010', '16')

insert into Xe(So_Xe, Hieu_Xe, Doi_Xe, So_Cho_Ngoi)
values('52N-3333', 'Huyndai Country', '2008', '30')

insert into Xe(So_Xe, Hieu_Xe, Doi_Xe, So_Cho_Ngoi)
values('50Y-3669', 'Toyota', '2009', '16')

insert into Xe(So_Xe, Hieu_Xe, Doi_Xe, So_Cho_Ngoi)
values('53Y-7788', 'Ford Everest', '2009', '7')

insert into Xe(So_Xe, Hieu_Xe, Doi_Xe, So_Cho_Ngoi) 
values('50S-2934', 'Hyundai Country', '2005', '25')

insert into Xe(So_Xe, Hieu_Xe, Doi_Xe, So_Cho_Ngoi)  
values('54H-1234', 'Hyundai Country', '2008', '30')

insert into Xe(So_Xe, Hieu_Xe, Doi_Xe, So_Cho_Ngoi)  
values('50S-9999', 'Huyndai', '2003', '45')

--Select * from Xe
-----------------------------------Tabl.DiaDiem--------------------------------------------
-------------------------------------------------------------------------------------------

insert into DiaDiem values('SG',N'Sài gòn')
insert into DiaDiem values('DL',N'Đà lạt')
insert into DiaDiem values('NT',N'Nha trang')
insert into DiaDiem values('CT',N'Cần thơ')
insert into DiaDiem values('BL',N'Bạc liêu')
insert into DiaDiem values('TN',N'Tây ninh')
insert into DiaDiem values('KT',N'Kom tum')
insert into DiaDiem values('PT',N'Phan thiết')
insert into DiaDiem values('VT',N'Vũng tàu')
insert into DiaDiem values('KG',N'Kiên giang')
insert into DiaDiem values('BT',N'Bình thuận')

-----------------------------------Table.TuyenXe--------------------------------------------
-------------------------------------------------------------------------------------------

insert into TuyenXe values('107',N'Sài Gòn - Nha Trang', N'Sài Gòn', N'Nha Trang')
insert into TuyenXe values('23',N'Sài Gòn - Đà Lạt', N'Sài Gòn', N'Đà Lạt')
insert into TuyenXe values('250',N'Sài Gòn - Cần Thơ', N'Sài Gòn', N'Cần Thơ')
insert into TuyenXe values('303',N'Sài Gòn - Tây Ninh', N'Sài Gòn', N'Tây Ninh')
insert into TuyenXe values('547',N'Sài Gòn - Phan Thiết', N'Sài Gòn', N'Phan Thiết')
insert into TuyenXe values('503',N'Sài Gòn - Kon Tum', N'Sài Gòn', N'Kon Tom')
insert into TuyenXe values('284',N'Sài Gòn - Bình Thuận', N'Sài Gòn', N'Bình Thuận')
insert into TuyenXe values('153',N'Sài Gòn - Kiên Giang', N'Sài Gòn', N'Kiên Giang')
insert into TuyenXe values('173',N'Sài Gòn - Bạc Liêu', N'Sài Gòn', N'Bạc Liêu')
insert into TuyenXe values('602',N'Sài Gòn - Vũng Tàu', N'Sài Gòn', N'Vũng Tàu')

-----------------------------------Tabl.ThoiDiem-------------------------------------------
-------------------------------------------------------------------------------------------
--Goi ham tu dong tang ma thoi diem cho bang thoi diem
ALTER TABLE ThoiDiem ADD CONSTRAINT def_ThoiDiem DEFAULT dbo.Addmaso('TD') FOR IdThoiDiem
go

insert into ThoiDiem(Ngay, Gio) 
values('2011/01/12', '5h35')

insert into ThoiDiem(Ngay, Gio) 
values('2010/01/12', '8h')

insert into ThoiDiem(Ngay, Gio)  
values('2011/01/12', '12h')

insert into ThoiDiem(Ngay, Gio)
values('2011/01/13', '6h')

insert into ThoiDiem(Ngay, Gio)
values('2011/01/13', '9h')

insert into ThoiDiem(Ngay, Gio)
values('2011/01/13', '13h')

insert into ThoiDiem(Ngay, Gio)
values('2011/01/13', '15h')

insert into ThoiDiem(Ngay, Gio)
values('2011/01/14', '8h30')

insert into ThoiDiem(Ngay, Gio)
values('2011/01/14', '10h')

insert into ThoiDiem(Ngay, Gio)
values('2011/01/15', '11h15')

insert into ThoiDiem(Ngay, Gio)
values('2011/01/14', '13h')
-----------------------------------Tabl.ChiTietTuyen---------------------------------------
-------------------------------------------------------------------------------------------
insert into ChiTietTuyen values('107','TD0001')
insert into ChiTietTuyen values('107','TD0008')
insert into ChiTietTuyen values('23', 'TD0002')
insert into ChiTietTuyen values('23', 'TD0006')
insert into ChiTietTuyen values('250','TD0004') 
insert into ChiTietTuyen values('250','TD0007') 
insert into ChiTietTuyen values('547','TD0006')
insert into ChiTietTuyen values('503','TD0008')
insert into ChiTietTuyen values('284','TD0011')
insert into ChiTietTuyen values('173','TD0009')
insert into ChiTietTuyen values('602','TD0010')
insert into ChiTietTuyen values('303','TD0005')
insert into ChiTietTuyen values('153','TD0007')
insert into ChiTietTuyen values('173','TD0003')

--Select * from ThoiDiem
-----------------------------------Tabl.ChuyenXe---------------------------------------
-------------------------------------------------------------------------------------------

--Goi ham tu dong tang ma thoi diem cho bang thoi diem
ALTER TABLE ChuyenXe ADD CONSTRAINT def_ChuyenXe DEFAULT dbo.AddmasoChuyen('CX') FOR IdChuyen
go

Insert into ChuyenXe(IdTuyen, So_Xe, NgayDi, Gio)
Values('107', '55Y-7777', '2011/01/12', '5h35')

Insert into ChuyenXe(IdTuyen, So_Xe, NgayDi, Gio)
Values('107', '53Y-7788', '2011/01/14', '8h30')

Insert into ChuyenXe(IdTuyen, So_Xe, NgayDi, Gio)
Values('250', '50S-2934', '2011/01/13', '15h')

Insert into ChuyenXe(IdTuyen, So_Xe, NgayDi, Gio)
Values('284', '52N-3333', '2011/01/14', '13h')

Insert into ChuyenXe(IdTuyen, So_Xe, NgayDi, Gio)
Values('284', '54H-1234', '2011/01/14', '6h')
--
--select * from ChuyenXe

--delete from ChuyenXe where IdChuyen = 'CX0005'
-----------------------------------------Table.BanVe-------------------------------------------
-----------------------------------------------------------------------------------------------
ALTER TABLE BanVe ADD CONSTRAINT def_BanVe DEFAULT dbo.AddmasoVe('VE') FOR IdVe
go

Insert into BanVe(IdChuyen, TenHanhKhach, SDTHanhKhach)
Values('CX0001', N'Hoàng Văn Bình', '091843256')

Insert into BanVe(IdChuyen, TenHanhKhach, SDTHanhKhach)
Values('CX0001', N'Hoàng Văn Bình', '091843256')

Insert into BanVe(IdChuyen, TenHanhKhach, SDTHanhKhach)
Values('CX0001', N'Nguyễn Ngọc Quang Sáng', '090276189')

Insert into BanVe(IdChuyen, TenHanhKhach, SDTHanhKhach)
Values('CX0001', N'Nguyễn Thị Thanh Thúy', '091847916')


--Select * from BanVe

------------------------------------------Tabl.ChoNgoi--------------------------------------
--------------------------------------------------------------------------------------------
Insert Into ChoNgoi
Values('CX0001', '55Y-7777', '1')

Insert Into ChoNgoi
Values('CX0001', '55Y-7777', '5')

Insert Into ChoNgoi
Values('CX0001', '55Y-7777', '8')

Insert Into ChoNgoi
Values('CX0001', '55Y-7777', '15')

--select * from ChoNgoi
--Select * from BanVe

Insert into PhanQuyen values('vantoan', 0, 1, 1, 0, 0)
Insert into PhanQuyen values('mytien', 0, 1, 0, 1, 1)

--select * from NguoiDung
--select count(*) from ChiTietTuyen