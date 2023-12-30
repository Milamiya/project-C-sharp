use master
GO
drop database QLHS_HCMUS_23
GO
create database QLHS_HCMUS_23
GO
use QLHS_HCMUS_23
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
--1. Create table and its columns
CREATE TABLE [dbo].[NAMHOC] (
	[MaNamHoc]		[varchar](6) NOT NULL,
	[TenNamHoc]		[nvarchar](30) NOT NULL);
GO
--2. Create table and its columns
CREATE TABLE [dbo].[MONHOC] (
	[MaMonHoc]		[varchar](10) NOT NULL,
	[TenMonHoc]		[nvarchar](50) NOT NULL,
	[SoTiet]		[int] NOT NULL,
	[HeSo]			[int] NOT NULL,
	[TrangThai]		[int] NOT NULL CONSTRAINT [DF_MONHOC_TrangThai] DEFAULT (1)
);
GO

--3. Create table and its columns
CREATE TABLE [dbo].[GIAOVIEN] (
	[MaGiaoVien]	[varchar](10) NOT NULL,
	[TenGiaoVien]	[nvarchar](50) NOT NULL);	
GO

--4. Create table and its columns 
CREATE TABLE [dbo].[LOP] (
	[MaLop]			[varchar](15) NOT NULL,
	[TenLop]		[nvarchar](50) NOT NULL,
	[MaKhoiLop]		[tinyint] NOT NULL,
	[MaNamHoc]		[varchar](6) NOT NULL,
	[SiSo]			[int] NOT NULL,
	[MaGiaoVien]	[varchar](10) NULL);
GO

--5. Create table and its columns
CREATE TABLE [dbo].[HOCSINH] (
	[MaHocSinh]		[varchar](10) NOT NULL,
	[TenHocSinh]	[nvarchar](50) NULL,
	[Email]			[nvarchar](50) NULL,
	[GioiTinh]		[bit] NULL,                  
	[NgaySinh]		[datetime] NULL,
	[NoiSinh]		[nvarchar](100) NULL,	
	[DiaChi]		[nvarchar](100) NULL,
	[NgayNhapHoc]	[datetime]  DEFAULT GETDATE());
GO

--6. Create table and its columns
CREATE TABLE [dbo].[PHANLOP] (
	[STT]			[int]	default 1 NOT NULL,
	[MaHocSinh]		[varchar](10) NOT NULL,
	[MaLop]			[varchar](15) NOT NULL);
GO
--7. Create table and its columns
CREATE TABLE [dbo].[BANGDIEM] (
	[MaHocSinh]		[varchar](10) NOT NULL,
	[MaMonHoc]		[varchar](10) NOT NULL,	
	[DM_1]			[real] NULL,
	[DM_2]			[real] NULL,
	[D15_1]			[real] NULL,
	[D15_2]			[real] NULL,
	[D15_3]			[real] NULL,
	[D15_4]			[real] NULL,
	[D1T_1]			[real] NULL,
	[D1T_2]			[real] NULL,
	[DThi]			[real] NULL,
	[DTB]			[real] NULL,
	[MaLop]			[varchar](15) NOT NULL,
	[MaHocKy]		[varchar](10) NOT NULL);
GO
--8. Create table and its columns
CREATE TABLE [dbo].[CHUYENLOP] (	
	[TuLop]			[varchar](15) NOT NULL,
	[DenLop]		[varchar](15) NOT NULL,
	[NgayChuyen]	[datetime] NOT NULL,
	[LyDoChuyen]	[nvarchar](250) NULL,
	[ChuyenBangDiem] [bit] NULL,
	[MaHocSinh]		[varchar](10) NOT NULL);
GO

--9. Create table and its columns
CREATE TABLE [dbo].[LOAINGUOIDUNG] (
	[MaLoaiND]		[varchar](10) NOT NULL,
	[TenLoaiND]		[nvarchar](30) NOT NULL);
GO

--10. Create table and its columns
CREATE TABLE [dbo].[NGUOIDUNG] (
	[MaND]			[varchar](10) NOT NULL,
	[MaLoaiND]		[varchar](10) NOT NULL,
	[TenDNhap]		[varchar](30) NOT NULL,
	[MatKhau]		[varchar](35) NOT NULL,
	[TrangThai]		[bit] NOT NULL CONSTRAINT [DF_NGUOIDUNG_TrangThai] DEFAULT ((1)));
GO

--11. Create table and its columns
CREATE TABLE [dbo].[QUYDINH] (
	[Khoa]			[varchar](50) NOT NULL,
	[GiaTri]		[nvarchar]	(250)     NULL);
GO

----------------------------------------------------------
--PRIMARY KEY
----------------------------------------------------------
--1. Primary key NAMHOC
ALTER TABLE [dbo].[NAMHOC] ADD CONSTRAINT [PK_NAMHOC] PRIMARY KEY ([MaNamHoc]) 
GO

--2. Primary key MONHOC
ALTER TABLE [dbo].[MONHOC] ADD CONSTRAINT [PK_MONHOC] PRIMARY KEY ([MaMonHoc]) 
GO

--3. Primary key GIAOVIEN
ALTER TABLE [dbo].[GIAOVIEN] ADD CONSTRAINT [PK_GIAOVIEN] PRIMARY KEY ([MaGiaoVien]) 
GO

--4. Primary key LOP
ALTER TABLE [dbo].[LOP] ADD CONSTRAINT [PK_LOP] PRIMARY KEY ([MaLop]) 
GO
--5. Primary key HOCSINH
ALTER TABLE [dbo].[HOCSINH] ADD CONSTRAINT [PK_HOCSINH] PRIMARY KEY ([MaHocSinh]) 
GO

--6. Primary key PHANLOP
ALTER TABLE [dbo].[PHANLOP] ADD CONSTRAINT [PK_PHAN] PRIMARY KEY ([MaHocSinh],[MaLop]) 
GO

--7. Primary key BANGDIEM
ALTER TABLE [dbo].[BANGDIEM] ADD CONSTRAINT [PK_BANGDIEM] PRIMARY KEY ([MaHocSinh],[MaHocKy],[MaMonHoc], [MaLop]) 
GO

--8. Primary key CHUYENLOP
ALTER TABLE [dbo].[CHUYENLOP] ADD CONSTRAINT [PK_CHUYENLOP] PRIMARY KEY ([TuLop],[DenLop],[NgayChuyen]) 
GO

--9. Primary key LOAINGUOIDUNG
ALTER TABLE [dbo].[LOAINGUOIDUNG] ADD CONSTRAINT [PK_LOAINGUOIDUNG] PRIMARY KEY ([MaLoaiND]) 
GO

--10. Primary key NGUOIDUNG
ALTER TABLE [dbo].[NGUOIDUNG] ADD CONSTRAINT [PK_NGUOIDUNG] PRIMARY KEY ([MaND]) 
GO

--11. Primary key QUYDINH
ALTER TABLE [dbo].[QUYDINH] ADD CONSTRAINT [PK_QUYDINH] PRIMARY KEY ([Khoa]) 
GO

----------------------------------------------------------
--FOREIGN KEY
----------------------------------------------------------
--1. 4_1-Foreign key LOP_NAMHOC
	ALTER TABLE [dbo].[LOP]  WITH CHECK ADD  CONSTRAINT [FK_LOP_NAMHOC] FOREIGN KEY([MaNamHoc])
	REFERENCES [dbo].[NAMHOC] ([MaNamHoc])
	GO

	ALTER TABLE [dbo].[LOP] CHECK CONSTRAINT [FK_LOP_NAMHOC]
	GO

--3. 4_3-Foreign key LOP_GIAOVIEN
	ALTER TABLE [dbo].[LOP]  WITH CHECK ADD  CONSTRAINT [FK_LOP_GIAOVIEN] FOREIGN KEY([MaGiaoVien])
	REFERENCES [dbo].[GIAOVIEN] ([MaGiaoVien])
	GO

	ALTER TABLE [dbo].[LOP] CHECK CONSTRAINT [FK_LOP_GIAOVIEN]
	GO

--2. 7_2-Foreign key BANGDIEM_MONHOC
	ALTER TABLE [dbo].[BANGDIEM]  WITH CHECK ADD  CONSTRAINT [FK_BANGDIEM_MONHOC] FOREIGN KEY([MaMonHoc])
	REFERENCES [dbo].[MONHOC] ([MaMonHoc])
	GO

	ALTER TABLE [dbo].[BANGDIEM] CHECK CONSTRAINT [FK_BANGDIEM_MONHOC]
	GO

--8. 7_5-Foreign key BANGDIEM_HOCSINH
	ALTER TABLE [dbo].[BANGDIEM]  WITH CHECK ADD  CONSTRAINT [FK_BANGDIEM_HOCSINH] FOREIGN KEY([MaHocSinh])
	REFERENCES [dbo].[HOCSINH] ([MaHocSinh])
	GO

	ALTER TABLE [dbo].[BANGDIEM] CHECK CONSTRAINT [FK_BANGDIEM_HOCSINH]
	GO

--8. 7_5-Foreign key BANGDIEM_LOP
	ALTER TABLE [dbo].[BANGDIEM]  WITH CHECK ADD  CONSTRAINT [FK_BANGDIEM_LOP] FOREIGN KEY([MaLop])
	REFERENCES [dbo].[LOP] ([MaLop])
	GO

	ALTER TABLE [dbo].[BANGDIEM] CHECK CONSTRAINT [FK_BANGDIEM_LOP]
	GO

--4. 6_4-Foreign key PHANLOP_LOP
	ALTER TABLE [dbo].[PHANLOP]  WITH CHECK ADD  CONSTRAINT [FK_PHANLOP_LOP] FOREIGN KEY([MaLop])
	REFERENCES [dbo].[LOP] ([MaLop])
	GO

	ALTER TABLE [dbo].[PHANLOP] CHECK CONSTRAINT [FK_PHANLOP_LOP]
	GO

--7. 6_5-Foreign key PHANLOP_HOCSINH
	ALTER TABLE [dbo].[PHANLOP]  WITH CHECK ADD  CONSTRAINT [FK_PHANLOP_HOCSINH] FOREIGN KEY([MaHocSinh])
	REFERENCES [dbo].[HOCSINH] ([MaHocSinh])
	GO

	ALTER TABLE [dbo].[PHANLOP] CHECK CONSTRAINT [FK_PHANLOP_HOCSINH]
	GO

--5. 8_4-Foreign key CHUYENLOP_LOP (TuLop)
	ALTER TABLE [dbo].[CHUYENLOP]  WITH CHECK ADD  CONSTRAINT [FK_CHUYENLOP_LOP1] FOREIGN KEY([TuLop])
	REFERENCES [dbo].[LOP] ([MaLop])
	GO

	ALTER TABLE [dbo].[CHUYENLOP] CHECK CONSTRAINT [FK_CHUYENLOP_LOP1]
	GO

--6. 8_4-Foreign key CHUYENLOP_LOP (DenLop)

	ALTER TABLE [dbo].[CHUYENLOP]  WITH CHECK ADD  CONSTRAINT [FK_CHUYENLOP_LOP2] FOREIGN KEY([DenLop])
	REFERENCES [dbo].[LOP] ([MaLop])
	GO

	ALTER TABLE [dbo].[CHUYENLOP] CHECK CONSTRAINT [FK_CHUYENLOP_LOP2]
	GO

--9. 8_5-Foreign key CHUYENLOP_HOCSINH
	ALTER TABLE [dbo].[CHUYENLOP]  WITH CHECK ADD  CONSTRAINT [FK_CHUYENLOP_HOCSINH] FOREIGN KEY([MaHocSinh])
	REFERENCES [dbo].[HOCSINH] ([MaHocSinh])
	GO

	ALTER TABLE [dbo].[CHUYENLOP] CHECK CONSTRAINT [FK_CHUYENLOP_HOCSINH]
	GO

--11. 10_3-Foreign key NGUOIDUNG_GIAOVIEN
	ALTER TABLE [dbo].[NGUOIDUNG]  WITH CHECK ADD  CONSTRAINT [FK_NGUOIDUNG_GIAOVIEN] FOREIGN KEY([MaND])
	REFERENCES [dbo].[GIAOVIEN] ([MaGiaoVien])
	GO

	ALTER TABLE [dbo].[NGUOIDUNG] CHECK CONSTRAINT [FK_NGUOIDUNG_GIAOVIEN]
	GO

--10. 10_9-Foreign key NGUOIDUNG_LOAINGUOIDUNG
	ALTER TABLE [dbo].[NGUOIDUNG]  WITH CHECK ADD  CONSTRAINT [FK_NGUOIDUNG_LOAINGUOIDUNG] FOREIGN KEY([MaLoaiND])
	REFERENCES [dbo].[LOAINGUOIDUNG] ([MaLoaiND])
	GO

	ALTER TABLE [dbo].[NGUOIDUNG] CHECK CONSTRAINT [FK_NGUOIDUNG_LOAINGUOIDUNG]
	GO

------------------------------------------------------------------------------
					/*Insert CSDL*/
------------------------------------------------------------------------------

--Table HOCSINH
set dateformat dmy
GO
INSERT INTO HOCSINH ([MaHocSinh],[TenHocSinh],[Email],[GioiTinh], [NgaySinh],[NoiSinh],	[DiaChi], [NgayNhapHoc]) 
SELECT	'HS00000001',   N'Nguyễn Ngọc Thu',		'ngocthu@gmail.com',		1,  '08-07-1995',	N'TP.HCM',		N'Q.9',			'23-5-2012' UNION 
SELECT	'HS00000002',	N'Nguyễn Thanh Trúc',	'thanhtruc@gmail.com',		1,	'01-01-1995',	N'TP.HCM',		N'Q.9',			'23-5-2012' UNION 
SELECT	'HS00000003',	N'Nguyễn Ngọc Hân',		'ngochan@gmail.com',		1,	'20-09-1995',	N'Vĩnh Long',	N'Vũng Liêm',	'23-5-2012' UNION 
SELECT	'HS00000004',	N'Nguyễn Văn Trung',	'vantrung@gmail.com',		0,	'01-01-1995',	N'Hải Dương',	N'Không Biết',	'23-5-2012' UNION 
SELECT	'HS00000005',	N'Nguyễn Văn An',		'vanan@gmail.com',			0,	'08-07-1995',	N'TP.HCM',		N'Q.9',			'23-5-2012' UNION 
SELECT	'HS00000006',	N'Nguyễn Bình Minh',	'binhminh@gmail.com',		0,	'01-01-1995',	N'TP.HCM',		N'Q.9',			'23-5-2012' UNION 
SELECT	'HS00000007',	N'Nguyễn Thị Lan Anh',	'lananh@gmail.com',			1,	'20-09-1995',	N'Vĩnh Long',	N'Vũng Liêm',	'23-5-2012' UNION 
SELECT	'HS00000008',	N'Lê Thị Thu Hà',		'thuha@gmail.com',			1,	'01-01-1995',	N'Hải Dương',	N'Không Biết',	'23-5-2012' UNION 
SELECT	'HS00000009',	N'Nguyễn Thị Thanh Trúc','thanhtruc@gmail.com',		1,	'08-07-1994',	N'TP.HCM',		N'Q.9',			'23-5-2012' UNION 
SELECT	'HS00000010',	N'Trần Duy Khoa',		'duykhoa@gmail.com',		0,	'01-01-1994',	N'TP.HCM',		N'Q.9',			'23-5-2012' UNION 
SELECT	'HS00000011',	N'Nguyễn Thị Thùy Dương','thuyduong@gmail.com',		1,	'20-09-1994',	N'Vĩnh Long',	N'Vũng Liêm',	'23-5-2012' UNION 
SELECT	'HS00000012',	N'Nguyễn Thị Bảo Ngọc', 'baongoc@gmail.com',		1,	'01-01-1994',	N'Hải Dương',	N'Không Biết',	'23-5-2012' UNION 
SELECT	'HS00000013',	N'Nguyễn Văn Tân',		'vantan@gmail.com',			0,	'08-07-1994',	N'TP.HCM',		N'Q.9',			'23-5-2012' UNION
SELECT	'HS00000014',	N'Nguyễn Bình Minh',	'binhminh@gmail.com',		0,	'01-01-1994',	N'TP.HCM',		N'Q.9',			'23-5-2012' UNION 
SELECT	'HS00000015',	N'Huỳnh Thanh Tùng',	'thanhtung@gmail.com',		0,	'20-09-1994',	N'Vĩnh Long',	N'Vũng Liêm',	'23-5-2012' UNION 
SELECT	'HS00000016',	N'Lê Thị Ngọc Thu',		'ngocthu@gmail.com',		1,	'01-01-1994',	N'Hải Dương',	N'Không Biết',	'23-5-2012' UNION
SELECT	'HS00000017',   N'Huỳnh Văn Tiến',		'vantien@gmail.com',		0,  '08-07-1993',	N'TP.HCM',		N'Q.9',			'23-5-2012' UNION 
SELECT	'HS00000018',	N'Nguyễn Thị Xuân',		'thixuan@gmail.com',		1,	'01-01-1993',	N'Tiền Giang',	N'Q.9',			'23-5-2012' UNION 
SELECT	'HS00000019',	N'Phạm Vân Trang',		'vantrang@gmail.com',		1,	'20-09-1993',	N'Long An',		N'Vũng Liêm',	'23-5-2012' UNION 
SELECT	'HS00000020',	N'Nguyễn Thanh Tùng',	'thanhtung@gmail.com',		0,	'01-01-1993',	N'Tây Ninh',	N'Không Biết',	'23-5-2012' UNION 
SELECT	'HS00000021',	N'Nguyễn Văn Sĩ',		'vansi@gmail.com',			0,	'08-07-1993',	N'TP.HCM',		N'Q.9',			'23-5-2012' UNION 
SELECT	'HS00000022',	N'Nguyễn Thị Thu',		'thithu@gmail.com',			1,	'01-01-1993',	N'TP.HCM',		N'Q.9',			'23-5-2012' UNION 
SELECT	'HS00000023',	N'Nguyễn Ngọc Lan',		'ngoclan@gmail.com',		1,	'20-09-1993',	N'Bình Thuận',	N'Vũng Liêm',	'23-5-2012' UNION 
SELECT	'HS00000024',	N'Lê Thị Quyên',		'thiquyen@gmail.com',		1,	'01-01-1993',	N'Hải Dương',	N'Không Biết',	'23-5-2012' UNION 
SELECT	'HS00000025',	N'Nguyễn Thị Thanh', 	'thithanh@gmail.com',		1,	'08-07-1996',	N'Bình Dương',	N'Q.9',			'23-5-2012' UNION 
SELECT	'HS00000026',	N'Trần Duy Tâm',		'duytam@gmail.com',			0,	'01-01-1996',	N'TP.HCM',		N'Q.9',			'23-5-2012' UNION 
SELECT	'HS00000027',	N'Nguyễn Thị Thùy', 	'thithuy@gmail.com',		1,	'20-09-1996',	N'Lâm Đồng',	N'Vũng Liêm',	'23-5-2012' UNION 
SELECT	'HS00000028',	N'Huỳnh Ngọc Bảo', 		'ngocbao@gmail.com',		1,	'01-01-1996',	N'Long An',		N'Không Biết',	'23-5-2012' UNION 
SELECT	'HS00000029',	N'Nguyễn Hoàng Oanh',	'hoangoanh@gmail.com',		1,	'08-07-1996',	N'TP.HCM',		N'Q.9',			'23-5-2012' UNION
SELECT	'HS00000030',	N'Lê Bảo Trân',			'baotran@gmail.com',		1,	'01-01-1996',	N'Hải Dương',	N'Không Biết',	'23-5-2012' UNION
SELECT	'HS00000031',	N'Nguyễn Văn Tèo',		'vanteo@gmail.com',			0,	'01-01-1996',	N'Daklak',		N'Không Biết',	'22-5-2012' UNION
SELECT	'HS00000032',	N'Nguyễn Văn Tý',		'vanty@gmail.com',			0,	'01-01-1996',	N'DakNong',		N'Không Biết',	'21-5-2012' UNION

SELECT	'HS00000033',   N'Nguyễn Ngọc Thúy',	'ngocthuy@gmail.com',		1,  '08-07-1995',	N'TP.HCM',		N'Q.9',			'23-5-2012' UNION 
SELECT	'HS00000034',	N'Nguyễn Thanh Thư',	'thanhthu@gmail.com',		1,	'01-01-1995',	N'TP.HCM',		N'Q.9',			'23-5-2012' UNION 
SELECT	'HS00000035',	N'Nguyễn Ngọc Trân',	'ngoctran@gmail.com',		1,	'20-09-1995',	N'Vĩnh Long',	N'Vũng Liêm',	'23-5-2012' UNION 
SELECT	'HS00000036',	N'Nguyễn Văn Thanh',	'vanthanh@gmail.com',		0,	'01-01-1995',	N'Hải Dương',	N'Không Biết',	'23-5-2012' UNION 
SELECT	'HS00000037',	N'Nguyễn Văn Đông',		'vandong@gmail.com',		0,	'08-07-1995',	N'TP.HCM',		N'Q.9',			'23-5-2012' UNION 
SELECT	'HS00000038',	N'Nguyễn Văn Được',		'vanduoc@gmail.com',		0,	'01-01-1995',	N'TP.HCM',		N'Q.9',			'23-5-2012' UNION 
SELECT	'HS00000039',	N'Nguyễn Thị Thái Bình','thaibinh@gmail.com',		1,	'20-09-1995',	N'Vĩnh Long',	N'Vũng Liêm',	'23-5-2012' UNION 
SELECT	'HS00000040',	N'Lê Thị Thu Trang',	'thutrang@gmail.com',		1,	'01-01-1995',	N'Hải Dương',	N'Không Biết',	'23-5-2012' UNION 
SELECT	'HS00000041',	N'Nguyễn Thị Thanh Trúc','thanhtruc@gmail.com',		1,	'08-07-1994',	N'TP.HCM',		N'Q.9',			'23-5-2012' UNION 
SELECT	'HS00000042',	N'Trần Duy Hà',			'duyha@gmail.com',			0,	'01-01-1994',	N'TP.HCM',		N'Q.9',			'23-5-2012' UNION 
SELECT	'HS00000043',	N'Nguyễn Thị Thùy Trâm','thuytram@gmail.com',		1,	'20-09-1994',	N'Vĩnh Long',	N'Vũng Liêm',	'23-5-2012' UNION 
SELECT	'HS00000044',	N'Nguyễn Thị Bảo Trân', 'baotran@gmail.com',		1,	'01-01-1994',	N'Hải Dương',	N'Không Biết',	'23-5-2012' UNION 
SELECT	'HS00000045',	N'Nguyễn Văn Tiến',		'vantien@gmail.com',		0,	'08-07-1994',	N'TP.HCM',		N'Q.9',			'23-5-2012' UNION
SELECT	'HS00000046',	N'Nguyễn Tấn Đạt',		'tandat@gmail.com',			0,	'01-01-1994',	N'TP.HCM',		N'Q.9',			'23-5-2012' UNION 
SELECT	'HS00000047',	N'Huỳnh Thanh Đức',		'thanhduc@gmail.com',		0,	'20-09-1994',	N'Vĩnh Long',	N'Vũng Liêm',	'23-5-2012' UNION 
SELECT	'HS00000048',	N'Lê Thị Ngọc Anh',		'ngocanh@gmail.com',		1,	'01-01-1994',	N'Hải Dương',	N'Không Biết',	'23-5-2012' UNION
SELECT	'HS00000049',   N'Huỳnh Văn Tấn',		'vantan@gmail.com',			0,  '08-07-1994',	N'TP.HCM',		N'Q.9',			'23-5-2012' UNION 
SELECT	'HS00000050',	N'Nguyễn Thị Sương',	'thisuong@gmail.com',		1,	'01-01-1995',	N'Tiền Giang',	N'Q.9',			'23-5-2012' UNION 
SELECT	'HS00000051',	N'Phạm Ngọc Hân',		'ngochan@gmail.com',		1,	'20-09-1996',	N'Long An',		N'Vũng Liêm',	'23-5-2012' UNION 
SELECT	'HS00000052',	N'Nguyễn Thanh Giàu',	'thanhgiau@gmail.com',		0,	'01-01-1995',	N'Tây Ninh',	N'Không Biết',	'23-5-2012' UNION 
SELECT	'HS00000053',	N'Nguyễn Văn Hải',		'vanhai@gmail.com',			0,	'08-07-1996',	N'TP.HCM',		N'Q.9',			'23-5-2012' UNION 
SELECT	'HS00000054',	N'Nguyễn Thị Hương',	'thihuong@gmail.com',		1,	'01-01-1995',	N'TP.HCM',		N'Q.9',			'23-5-2012' UNION 
SELECT	'HS00000055',	N'Nguyễn Ngọc Hằng',	'ngochang@gmail.com',		1,	'20-09-1996',	N'Bình Thuận',	N'Vũng Liêm',	'23-5-2012' UNION 
SELECT	'HS00000056',	N'Lê Thị Ngọc',			'thingoc@gmail.com',		1,	'01-01-1996',	N'Hải Dương',	N'Không Biết',	'23-5-2012' UNION 
SELECT	'HS00000057',	N'Nguyễn Thị Khánh', 	'thikhanh@gmail.com',		1,	'08-07-1995',	N'Bình Dương',	N'Q.9',			'23-5-2012' UNION 
SELECT	'HS00000058',	N'Trần Khánh Duy ',		'khanhduy@gmail.com',		0,	'01-01-1995',	N'TP.HCM',		N'Q.9',			'23-5-2012' UNION 
SELECT	'HS00000059',	N'Nguyễn Huỳnh Kim', 	'huynhkim@gmail.com',		1,	'20-09-1996',	N'Lâm Đồng',	N'Vũng Liêm',	'23-5-2012' UNION 
SELECT	'HS00000060',	N'Huỳnh Ngọc Mai',		'ngocmai@gmail.com',		1,	'01-01-1996',	N'Long An',		N'Không Biết',	'23-5-2012' UNION 
SELECT	'HS00000061',	N'Nguyễn Hoàng Lan',	'hoanglan@gmail.com',		1,	'08-07-1995',	N'TP.HCM',		N'Q.9',			'23-5-2012' UNION
SELECT	'HS00000062',	N'Lê Ngọc Linh',		'ngoclinh@gmail.com',		1,	'01-01-1996',	N'Hải Dương',	N'Không Biết',	'23-5-2012' UNION
SELECT	'HS00000063',	N'Nguyễn Văn Mạnh',		'vanmanh@gmail.com',		0,	'01-01-1995',	N'Daklak',		N'Không Biết',	'22-5-2012' UNION
SELECT	'HS00000064',	N'Nguyễn Văn Long',		'vanlong@gmail.com',		0,	'01-01-1996',	N'DakNong',		N'Không Biết',	'21-5-2012'

--Table GIAOVIEN
GO

INSERT INTO GIAOVIEN ([MaGiaoVien],[TenGiaoVien]) 
SELECT 'GV000',  N'Quản trị viên'		UNION
SELECT 'GV001',  N'Nguyễn Hồng Phú'		UNION
SELECT 'GV002',  N'Nguyễn Văn Đại'		UNION
SELECT 'GV003',  N'Nguyễn Duy Hà'		UNION
SELECT 'GV004',  N'Nguyễn Thị Mỷ Diện'	UNION 
SELECT 'GV005',  N'Nguyễn Ngọc Anh Thư' UNION
SELECT 'GV006',	 N'Phạm Đăng Khoa'		UNION
SELECT 'GV007',	 N'Trần Thanh Huy'		UNION
SELECT 'GV008',	 N'Huỳnh Yến Nhi'		UNION
SELECT 'GV009',	 N'Nguyễn Thị Hoàng Oanh' UNION
SELECT 'GV010',	 N'Huỳnh Yến Linh'		UNION
SELECT 'GV011',	 N'Nguyễn Hoàng Nam'	UNION
SELECT 'GV012',	 N'Nguyễn Hoàng Bắc'	

-- table LOAINGUOIDUN
GO
INSERT INTO LOAINGUOIDUNG(MaLoaiND,TenLoaiND)
SELECT 'giaovu',	 N'Giáo vụ'			UNION
SELECT 'quantri',	 N'Quản trị viên'	UNION
SELECT 'hieutruong', N'Hiệu trưởng'		UNION
SELECT 'giaovien',	 N'Giáo viên'


-- table NguoiDung
GO
INSERT INTO NGUOIDUNG(MaLoaiND,MaND,MatKhau,TenDNhap,TrangThai)
SELECT 'quantri',	'GV000','202cb962ac59075b964b07152d234b70',	'admin',	1 UNION
SELECT 'quantri',	'GV001','202cb962ac59075b964b07152d234b70',	'hongphu',	1 UNION
SELECT 'giaovu',	'GV002','202cb962ac59075b964b07152d234b70',	'vandai',	1 UNION
SELECT 'giaovien',	'GV003','202cb962ac59075b964b07152d234b70',	'duyha',	1 UNION
SELECT 'hieutruong','GV004','202cb962ac59075b964b07152d234b70',	'mydien',	1

--NAMHOC
GO	
INSERT INTO NAMHOC ([MaNamHoc],[TenNamHoc]) 
SELECT 'NH1011',	'2010 - 2011' UNION
SELECT 'NH1112',	'2011 - 2012'
--Table LOP
GO
INSERT INTO LOP ([MaLop],[TenLop],[MaKhoiLop],[MaNamHoc],[SiSo],[MaGiaoVien])  
SELECT '10A01NH1011',	'10A1',	10,	'NH1011', 40, 'GV001' UNION 
SELECT '10A02NH1011',	'10A2',	10,	'NH1011', 40, 'GV002' UNION 
SELECT '11A01NH1011',	'11A1',	11,	'NH1011', 40, 'GV005' UNION 
SELECT '11A02NH1011',	'11A2',	11,	'NH1011', 40, 'GV006' UNION 
SELECT '12A01NH1011',	'12A1',	12,	'NH1011', 40, 'GV009' UNION
SELECT '12A02NH1011',	'12A2',	12,	'NH1011', 40, 'GV010' UNION
SELECT '10A01NH1112',	'10A1',	10,	'NH1112', 40, 'GV001' UNION 
SELECT '10A02NH1112',	'10A2',	10,	'NH1112', 40, 'GV002' UNION 
SELECT '11A01NH1112',	'11A1',	11,	'NH1112', 40, 'GV005' UNION 
SELECT '11A02NH1112',	'11A2',	11,	'NH1112', 40, 'GV006' UNION 
SELECT '12A01NH1112',	'12A1',	12,	'NH1112', 40, 'GV009' UNION
SELECT '12A02NH1112',	'12A2',	12,	'NH1112', 40, 'GV010' 

-- Mon hoc
GO
INSERT INTO MONHOC(MaMonHoc,TenMonHoc,SoTiet,HeSo,TrangThai) 
SELECT 'toan',	N'Toán học',	90,		2,	1 UNION
SELECT 'ly',	N'Vật lý',		60,		1,	1 UNION
SELECT 'hoa',	N'Hóa học',		60,		1,	1 UNION
SELECT 'sinh',	N'Sinh học',	60,		1,	1 UNION
SELECT 'ngvan',	N'Ngữ văn',		90,		2,	1 UNION
SELECT 'su',	N'Lịch sử',		45,		1,	1 UNION
SELECT 'dia',	N'Địa lý',		45,		1,	1 UNION
SELECT 'nngu',	N'Ngoại ngữ',	45,		1,	1 UNION
SELECT 'gdcd',	N'GD Công dân',	30,		1,	1 UNION
SELECT 'tin',	N'Tin học',		30,		1,	1 UNION
SELECT 'tduc',	N'Thể dục',		30,		1,	1 UNION
SELECT 'qphong',N'Quốc phòng',	30,		1,	1 UNION
SELECT 'cnghe',	N'Công Nghệ',	30,		1,	1


-- Phan lop
GO	
INSERT INTO PHANLOP ([STT],[MaHocSinh],[MaLop]) 
--2010-2011
SELECT 1,	'HS00000001',	'10A01NH1011' UNION 
SELECT 2,	'HS00000002',	'10A01NH1011' UNION 
SELECT 3,	'HS00000003',	'10A01NH1011' UNION 
SELECT 4,	'HS00000004',	'10A01NH1011' UNION 

SELECT 1,	'HS00000005',	'10A02NH1011' UNION 
SELECT 2,	'HS00000006',	'10A02NH1011' UNION 
SELECT 3,	'HS00000007',	'10A02NH1011' UNION 
SELECT 4,	'HS00000008',	'10A02NH1011' UNION 

SELECT 1,	'HS00000009',	'11A01NH1011' UNION 
SELECT 2,	'HS00000010',	'11A01NH1011' UNION 
SELECT 3,	'HS00000011',	'11A01NH1011' UNION 
SELECT 4,	'HS00000012',	'11A01NH1011' UNION 

SELECT 1,	'HS00000013',	'11A02NH1011' UNION 
SELECT 2,	'HS00000014',	'11A02NH1011' UNION 
SELECT 3,	'HS00000015',	'11A02NH1011' UNION 
SELECT 4,	'HS00000016',	'11A02NH1011' UNION

SELECT 1,	'HS00000017',	'12A01NH1011' UNION 
SELECT 2,	'HS00000018',	'12A01NH1011' UNION 
SELECT 3,	'HS00000019',	'12A01NH1011' UNION 
SELECT 4,	'HS00000020',	'12A01NH1011' UNION

SELECT 1,	'HS00000021',	'12A02NH1011' UNION
SELECT 2,	'HS00000022',	'12A02NH1011' UNION
SELECT 3,	'HS00000023',	'12A02NH1011' UNION 
SELECT 4,	'HS00000024',	'12A02NH1011' UNION
--2011-2012
SELECT 1,	'HS00000025',	'10A01NH1112' UNION 
SELECT 2,	'HS00000026',	'10A01NH1112' UNION 
SELECT 3,	'HS00000027',	'10A01NH1112' UNION
SELECT 4,	'HS00000028',	'10A01NH1112' UNION 

SELECT 1,	'HS00000029',	'10A02NH1112' UNION 
SELECT 2,	'HS00000030',	'10A02NH1112' UNION
SELECT 3,	'HS00000031',	'10A02NH1112' UNION
SELECT 4,	'HS00000032',	'10A02NH1112' UNION 

SELECT 1,	'HS00000033',	'11A01NH1112' UNION 
SELECT 2,	'HS00000034',	'11A01NH1112' UNION
SELECT 3,	'HS00000035',	'11A01NH1112' UNION
SELECT 4,	'HS00000036',	'11A01NH1112' UNION 

SELECT 1,	'HS00000037',	'11A02NH1112' UNION 
SELECT 2,	'HS00000038',	'11A02NH1112' UNION
SELECT 3,	'HS00000039',	'11A02NH1112' UNION
SELECT 4,	'HS00000040',	'11A02NH1112' UNION 

SELECT 1,	'HS00000041',	'12A01NH1112' UNION 
SELECT 2,	'HS00000042',	'12A01NH1112' UNION
SELECT 3,	'HS00000043',	'12A01NH1112' UNION
SELECT 4,	'HS00000044',	'12A01NH1112' UNION 

SELECT 1,	'HS00000045',	'12A02NH1112' UNION 
SELECT 2,	'HS00000046',	'12A02NH1112' UNION
SELECT 3,	'HS00000047',	'12A02NH1112' UNION
SELECT 4,	'HS00000048',	'12A02NH1112'  


-- Quy Dinh
INSERT INTO QUYDINH (Khoa,GiaTri)  
SELECT 'DiaChiTruong',	'Q9 - TP.HCM'	UNION 
SELECT 'DiemChuan',		'8'				UNION 
SELECT 'SiSoCanTren',	'45'			UNION 
SELECT 'SoLuongLop',	'20'			UNION 
SELECT 'TenTruong',		N'THPT Nguyễn Huệ' UNION 
SELECT 'TuoiCanDuoi',	'15'			UNION 
SELECT 'TuoiCanTren',	'18'			UNION
SELECT 'MaNamHocHT', 'NH1011'			UNION
SELECT 'NgayApDung', '24-05-2010'

INSERT INTO BANGDIEM (MaHocSinh,MaMonHoc,DM_1,DM_2,D15_1,D15_2,D15_3,D15_4,D1T_1.D1T_2,DThi,MaLop,DTB,MaHocKy)
SELECT 'HS00000001',	'gdcd',	7,	7,	8,		8,		4,	7,	8.5,6.5,'10A01NH1011',7,	1 UNION 
SELECT 'HS00000001',	'dia',	8,	7,	6.5,	7.5,	8,	7,	8,	9,	'10A01NH1011',8.14,	1 UNION 
SELECT 'HS00000001',	'hoa',	8,	7,	6.5,	7.5,	8,	7,	8,	9,	'10A01NH1011',8.14,	1 UNION 
SELECT 'HS00000001',	'ly',	8,	7,	6.7,	7.5,	8,	7,	9,	10,	'10A01NH1011',8.14,	1 UNION 
SELECT 'HS00000001',	'sinh',	8,	7,	6.5,	7.5,	8,	7,	8,	9,	'10A01NH1011',8.14,	1 UNION 
SELECT 'HS00000001',	'su',	7,	7,	8,		8,		4,	7,	8.5,6.5,'10A01NH1011',7,	1 UNION 
SELECT 'HS00000001',	'tduc',	8,	7,	6.5,	7.5,	8,	4,	8,	9,	'10A01NH1011',8.14,	1 UNION 
SELECT 'HS00000001',	'toan',	8,	7,	6.5,	7.5,	8,	7,	8,	9,	'10A01NH1011',8.14,	1 UNION 
SELECT 'HS00000001',	'ngvan',7,	7,	8,		8,		4,	7,	8.5,6.5,'10A01NH1011',7,	1 UNION 
SELECT 'HS00000001',	'nngu',	8,	7,	6.5,	7.5,	8,	8,	8,	9,	'10A01NH1011',8.14,	1 UNION 
SELECT 'HS00000001',	'tin',	8,	7,	6.5,	7.5,	8,	4,	8,	9,	'10A01NH1011',8.14,	1 UNION 
SELECT 'HS00000001',	'qphong',8,	7,	6.5,	7.5,	8,	7,	8,	9,	'10A01NH1011',8.14,	1 UNION 
SELECT 'HS00000001',	'cnghe',7,	7,	8,		8,		4,	7,	8.5,6.5,'10A01NH1011',7,	1 UNION 

SELECT 'HS00000002',	'gdcd',	8,	7, 	9,		8,		8,	4,	8,	9,	'10A01NH1011',8.18,	1 UNION 
SELECT 'HS00000002',	'dia',	8,	7,	6.5,	7.5,	8,	7,	8,	9,	'10A01NH1011',8.14,	1 UNION 
SELECT 'HS00000002',	'hoa',	8,	7,	6.5,	7.5,	8,	7,	8,	9,	'10A01NH1011',8.14,	1 UNION 
SELECT 'HS00000002',	'ly',	7,	7,	8,		8,		4,	7,	8.5,6.5,'10A01NH1011',7,	1 UNION 
SELECT 'HS00000002',	'sinh',	8,	7,	6.5,	7.5,	8,	7,	8,	9,	'10A01NH1011',8.14,	1 UNION 
SELECT 'HS00000002',	'su',	4,	7,	6.5,	7.5,	8,	8,	8,	9,	'10A01NH1011',8.14,	1 UNION 
SELECT 'HS00000002',	'tduc',	7,	7,	8,		8,		4,	7,	8.5,6.5,'10A01NH1011',7,	1 UNION 
SELECT 'HS00000002',	'toan',	8,	7,	6.5,	7.5,	8,	7,	8,	9,	'10A01NH1011',8.14,	1 UNION 
SELECT 'HS00000002',	'ngvan',8,	7,	6.5,	7.5,	8,	7,	8,	9,	'10A01NH1011',8.14,	1 UNION 
SELECT 'HS00000002',	'nngu',	8,	7,	6.5,	7.5,	8,	8,	8,	9,	'10A01NH1011',8.14,	1 UNION 
SELECT 'HS00000002',	'tin',	8,	7,	6.5,	7.5,	8,	4,	8,	9,	'10A01NH1011',8.14,	1 UNION 
SELECT 'HS00000002',	'qphong',8,	7,	6.5,	7.5,	8,	7,	8,	9,	'10A01NH1011',8.14,	1 UNION 
SELECT 'HS00000002',	'cnghe',7,	7,	8,		8,		4,	7,	8.5,6.5,'10A01NH1011',7,	1 UNION 

SELECT 'HS00000003',	'gdcd',	8,	7,	6.5,	7.5,	8,	7,	8,	9,	'10A01NH1011',8.14,	1 UNION 
SELECT 'HS00000003',	'dia',	8,	7,	6.5,	7.5,	8,	7,	8,	9,	'10A01NH1011',8.14,	1 UNION 
SELECT 'HS00000003',	'hoa',	4,	7,	6.5,	7.5,	8,	7,	8,	9,	'10A01NH1011',8.14,	1 UNION 
SELECT 'HS00000003',	'ly',	8,	7,	7,		7.5,	8,	7,	9,	10,	'10A01NH1011',8.14,	1 UNION 
SELECT 'HS00000003',	'sinh',	8,	7,	6.5,	7.5,	8,	7,	8,	9,	'10A01NH1011',8.14,	1 UNION 
SELECT 'HS00000003',	'su',	8,	7,	6.5,	7.5,	8,	7,	8,	9,	'10A01NH1011',8.14,	1 UNION 
SELECT 'HS00000003',	'tduc',	8,	7,	6.5,	7.5,	8,	7,	8,	9,	'10A01NH1011',8.14,	1 UNION 
SELECT 'HS00000003',	'toan',	8,	7,	6.5,	7.5,	8,	7,	8,	9,	'10A01NH1011',8.14,	1 UNION 
SELECT 'HS00000003',	'ngvan',8,	7,	6.5,	7.5,	8,	7,	8,	9,	'10A01NH1011',8.14,	1 UNION 
SELECT 'HS00000003',	'nngu',	8,	7,	6.5,	7.5,	8,	8,	8,	9,	'10A01NH1011',8.14,	1 UNION 
SELECT 'HS00000003',	'tin',	8,	7,	6.5,	7.5,	8,	4,	8,	9,	'10A01NH1011',8.14,	1 UNION 
SELECT 'HS00000003',	'qphong',8,	7,	6.5,	7.5,	8,	7,	8,	9,	'10A01NH1011',8.14,	1 UNION 
SELECT 'HS00000003',	'cnghe',8,	7,	6.5,	7.5,	8,	4,	8,	9,	'10A01NH1011',8.14,	1 UNION 

SELECT 'HS00000004',	'gdcd',	8,	7,	6.5,	7.5,	8,	7,	8,	9,	'10A01NH1011',8.14,	1 UNION 
SELECT 'HS00000004',	'dia',	8,	7,	6.5,	7.5,	8,	7,	8,	9,	'10A01NH1011',8.14,	1 UNION 
SELECT 'HS00000004',	'hoa',	8,	7,	6.5,	7.5,	8,	7,	8,	9,	'10A01NH1011',8.14,	1 UNION 
SELECT 'HS00000004',	'ly',	8,	7,	6.5,	7.5,	8,	7,	8,	9,	'10A01NH1011',8.14,	1 UNION 
SELECT 'HS00000004',	'sinh',	8,	7,	6.5,	7.5,	8,	7,	8,	9,	'10A01NH1011',8.14,	1 UNION 
SELECT 'HS00000004',	'su',	8,	7,	6.5,	7.5,	8,	7,	8,	9,	'10A01NH1011',8.14,	1 UNION 
SELECT 'HS00000004',	'tduc',	9,	7,	6.5,	7.5,	8,	7,	8,	9,	'10A01NH1011',8.14,	1 UNION 
SELECT 'HS00000004',	'toan',	8,	7,	6.5,	7.5,	8,	7,	8,	9,	'10A01NH1011',8.14,	1 UNION 
SELECT 'HS00000004',	'ngvan',8,	7,	6.5,	7.5,	8,	7,	8,	9,	'10A01NH1011', 8.14,1 UNION
SELECT 'HS00000004',	'nngu',	8,	7,	6.5,	7.5,	8,	8,	8,	9,	'10A01NH1011',8.14,	1 UNION 
SELECT 'HS00000004',	'tin',	8,	7,	6.5,	7.5,	8,	4,	8,	9,	'10A01NH1011',8.14,	1 UNION 
SELECT 'HS00000004',	'qphong',8,	7,	6.5,	7.5,	8,	7,	8,	9,	'10A01NH1011',8.14,	1 UNION 
SELECT 'HS00000004',	'cnghe',8,	7,	6.5,	7.5,	8,	4,	8,	9,	'10A01NH1011',8.14,	1 UNION 

SELECT 'HS00000005',	'gdcd',	6,	7,	6.5,	7.5,	8,	7,	8,	9,	'10A02NH1011',8.14,	1 UNION 
SELECT 'HS00000005',	'dia',	8,	7,	6.5,	7.5,	8,	7,	8,	9,	'10A02NH1011',8.14,	1 UNION 
SELECT 'HS00000005',	'hoa',	8,	7,	6.5,	7.5,	8,	7,	8,	9,	'10A02NH1011',8.14,	1 UNION 
SELECT 'HS00000005',	'ly',	8,	7,	7,		7.5,	8,	7,	9,	10,	'10A02NH1011',8.14,	1 UNION 
SELECT 'HS00000005',	'sinh',	8,	7,	6.5,	7.5,	8,	7,	8,	9,	'10A02NH1011',8.14,	1 UNION 
SELECT 'HS00000005',	'su',	8,	7,	6.5,	7.5,	8,	8,	8,	9,	'10A02NH1011',8.14,	1 UNION 
SELECT 'HS00000005',	'tduc',	8,	7,	6.5,	7.5,	8,	4,	8,	9,	'10A02NH1011',8.14,	1 UNION 
SELECT 'HS00000005',	'toan',	8,	7,	6.5,	7.5,	8,	7,	8,	9,	'10A02NH1011',8.14,	1 UNION 
SELECT 'HS00000005',	'ngvan',8,	7,	6.5,	7.5,	8,	4,	8,	9,	'10A02NH1011',8.14,	1 UNION 
SELECT 'HS00000005',	'nngu',	8,	7,	6.5,	7.5,	8,	8,	8,	9,	'10A02NH1011',8.14,	1 UNION 
SELECT 'HS00000005',	'tin',	8,	7,	6.5,	7.5,	8,	4,	8,	9,	'10A02NH1011',8.14,	1 UNION 
SELECT 'HS00000005',	'qphong',8,	7,	6.5,	7.5,	8,	7,	8,	9,	'10A02NH1011',8.14,	1 UNION 
SELECT 'HS00000005',	'cnghe',8,	7,	6.5,	7.5,	8,	4,	8,	9,	'10A02NH1011',8.14,	1 UNION 

SELECT 'HS00000006',	'gdcd',	8,	7,	6.5,	7.5,	8,	7,	8,	9,	'10A02NH1011',8.14,	1 UNION 
SELECT 'HS00000006',	'dia',	8,	7,	6.5,	7.5,	8,	7,	8,	9,	'10A02NH1011',8.14,	1 UNION 
SELECT 'HS00000006',	'hoa',	8,	7,	6.5,	7.5,	8,	7,	8,	9,	'10A02NH1011',8.14,	1 UNION 
SELECT 'HS00000006',	'ly',	6,	7,	7,		7.5,	8,	7,	9,	10,	'10A02NH1011',8.14,	1 UNION 
SELECT 'HS00000006',	'sinh',	8,	7,	6.5,	7.5,	8,	7,	8,	9,	'10A02NH1011',8.14,	1 UNION 
SELECT 'HS00000006',	'su',	4,	7,	6.5,	7.5,	8,	8,	8,	9,	'10A02NH1011',8.14,	1 UNION 
SELECT 'HS00000006',	'tduc',	8,	7,	6.5,	7.5,	8,	9,	8,	9,	'10A02NH1011',8.14,	1 UNION 
SELECT 'HS00000006',	'toan',	8,	7,	6.5,	7.5,	8,	7,	8,	9,	'10A02NH1011',8.14,	1 UNION 
SELECT 'HS00000006',	'ngvan',8,	7,	6.5,	7.5,	8,	7,	8,	9,	'10A02NH1011',8.14,	1 UNION 
SELECT 'HS00000006',	'nngu',	8,	7,	6.5,	7.5,	8,	8,	8,	9,	'10A02NH1011',8.14,	1 UNION 
SELECT 'HS00000006',	'tin',	8,	7,	6.5,	7.5,	8,	4,	8,	9,	'10A02NH1011',8.14,	1 UNION 
SELECT 'HS00000006',	'qphong',8,	7,	6.5,	7.5,	8,	7,	8,	9,	'10A02NH1011',8.14,	1 UNION 
SELECT 'HS00000006',	'cnghe',8,	7,	6.5,	7.5,	8,	4,	8,	9,	'10A02NH1011',8.14,	1 UNION 

SELECT 'HS00000007',	'gdcd',	8,	7,	6.5,	7.5,	8,	7,	8,	9,	'10A02NH1011',8.14,	1 UNION 
SELECT 'HS00000007',	'dia',	8,	7,	6.5,	7.5,	8,	7,	8,	9,	'10A02NH1011',8.14,	1 UNION 
SELECT 'HS00000007',	'hoa',	4,	7,	6.5,	7.5,	8,	7,	8,	9,	'10A02NH1011',8.14,	1 UNION 
SELECT 'HS00000007',	'ly',	8,	7,	7,		7.5,	8,	7,	9,	10,	'10A02NH1011',8.14,	1 UNION 
SELECT 'HS00000007',	'sinh',	8,	7,	6.5,	7.5,	8,	7,	8,	9,	'10A02NH1011',8.14,	1 UNION 
SELECT 'HS00000007',	'su',	8,	7,	6.5,	7.5,	8,	7,	8,	9,	'10A02NH1011',8.14,	1 UNION 
SELECT 'HS00000007',	'tduc',	8,	7,	6.5,	7.5,	8,	7,	8,	9,	'10A02NH1011',8.14,	1 UNION 
SELECT 'HS00000007',	'toan',	8,	7,	6.5,	7.5,	8,	7,	8,	9,	'10A02NH1011',8.14,	1 UNION 
SELECT 'HS00000007',	'ngvan',8,	7,	6.5,	7.5,	8,	7,	8,	9,	'10A02NH1011',8.14,	1 UNION 
SELECT 'HS00000007',	'nngu',	8,	7,	6.5,	7.5,	8,	8,	8,	9,	'10A02NH1011',8.14,	1 UNION 
SELECT 'HS00000007',	'tin',	8,	7,	6.5,	7.5,	8,	4,	8,	9,	'10A02NH1011',8.14,	1 UNION 
SELECT 'HS00000007',	'qphong',8,	7,	6.5,	7.5,	8,	7,	8,	9,	'10A02NH1011',8.14,	1 UNION 
SELECT 'HS00000007',	'cnghe',8,	7,	6.5,	7.5,	8,	4,	8,	9,	'10A02NH1011',8.14,	1 UNION 

SELECT 'HS00000008',	'gdcd',	8,	7,	6.5,	7.5,	8,	7,	8,	9,	'10A02NH1011',8.14,	1 UNION 
SELECT 'HS00000008',	'dia',	8,	7,	6.5,	7.5,	8,	7,	8,	9,	'10A02NH1011',8.14,	1 UNION 
SELECT 'HS00000008',	'hoa',	8,	7,	6.5,	7.5,	8,	7,	8,	9,	'10A02NH1011',8.14,	1 UNION 
SELECT 'HS00000008',	'ly',	8,	7,	6.5,	7.5,	8,	7,	8,	9,	'10A02NH1011',8.14,	1 UNION 
SELECT 'HS00000008',	'sinh',	8,	7,	6.5,	7.5,	8,	7,	8,	9,	'10A02NH1011',8.14,	1 UNION 
SELECT 'HS00000008',	'su',	8,	7,	6.5,	7.5,	8,	7,	8,	9,	'10A02NH1011',8.14,	1 UNION 
SELECT 'HS00000008',	'tduc',	9,	7,	6.5,	7.5,	8,	7,	8,	9,	'10A02NH1011',8.14,	1 UNION 
SELECT 'HS00000008',	'toan',	8,	7,	6.5,	7.5,	8,	7,	8,	9,	'10A02NH1011',8.14,	1 UNION 
SELECT 'HS00000008',	'ngvan',8,	7,	6.5,	7.5,	8,	7,	8,	9,	'10A02NH1011',8.14,1 UNION
SELECT 'HS00000008',	'nngu',	8,	7,	6.5,	7.5,	8,	8,	8,	9,	'10A02NH1011',8.14,	1 UNION 
SELECT 'HS00000008',	'tin',	8,	7,	6.5,	7.5,	8,	4,	8,	9,	'10A02NH1011',8.14,	1 UNION 
SELECT 'HS00000008',	'qphong',8,	7,	6.5,	7.5,	8,	7,	8,	9,	'10A02NH1011',8.14,	1 UNION 
SELECT 'HS00000008',	'cnghe',8,	7,	6.5,	7.5,	8,	4,	8,	9,	'10A02NH1011',8.14,1  UNION


SELECT 'HS00000009',	'gdcd',	6,	7,	6.5,	7.5,	8,	7,	8,	9,	'11A01NH1011',8.14,	1 UNION 
SELECT 'HS00000009',	'dia',	8,	7,	6.5,	7.5,	8,	7,	8,	9,	'11A01NH1011',8.14,	1 UNION 
SELECT 'HS00000009',	'hoa',	8,	7,	6.5,	7.5,	8,	7,	8,	9,	'11A01NH1011',8.14,	1 UNION 
SELECT 'HS00000009',	'ly',	8,	7,	6.7,	7.5,	8,	7,	9,	10,	'11A01NH1011',8.14,	1 UNION 
SELECT 'HS00000009',	'sinh',	8,	7,	6.5,	7.5,	8,	7,	8,	9,	'11A01NH1011',8.14,	1 UNION 
SELECT 'HS00000009',	'su',	8,	7,	6.5,	7.5,	8,	8,	8,	9,	'11A01NH1011',8.14,	1 UNION 
SELECT 'HS00000009',	'tduc',	8,	7,	6.5,	7.5,	8,	4,	8,	9,	'11A01NH1011',8.14,	1 UNION 
SELECT 'HS00000009',	'toan',	8,	7,	6.5,	7.5,	8,	7,	8,	9,	'11A01NH1011',8.14,	1 UNION 
SELECT 'HS00000009',	'ngvan',8,	7,	6.5,	7.5,	8,	4,	8,	9,	'11A01NH1011',8.14,	1 UNION 
SELECT 'HS00000009',	'nngu',	8,	7,	6.5,	7.5,	8,	8,	8,	9,	'11A01NH1011',8.14,	1 UNION 
SELECT 'HS00000009',	'tin',	8,	7,	6.5,	7.5,	8,	4,	8,	9,	'11A01NH1011',8.14,	1 UNION 
SELECT 'HS00000009',	'qphong',8,	7,	6.5,	7.5,	8,	7,	8,	9,	'11A01NH1011',8.14,	1 UNION 
SELECT 'HS00000009',	'cnghe',8,	7,	6.5,	7.5,	8,	4,	8,	9,	'11A01NH1011',8.14,	1 UNION 

SELECT 'HS00000010',	'gdcd',	8,	7,	6.5,	7.5,	8,	7,	8,	9,	'11A01NH1011',8.14,	1 UNION 
SELECT 'HS00000010',	'dia',	8,	7,	6.5,	7.5,	8,	7,	8,	9,	'11A01NH1011',8.14,	1 UNION 
SELECT 'HS00000010',	'hoa',	8,	7,	6.5,	7.5,	8,	7,	8,	9,	'11A01NH1011',8.14,	1 UNION 
SELECT 'HS00000010',	'ly',	6,	7,	7,		7.5,	8,	7,	9,	10,	'11A01NH1011',8.14,	1 UNION 
SELECT 'HS00000010',	'sinh',	8,	7,	6.5,	7.5,	8,	7,	8,	9,	'11A01NH1011',8.14,	1 UNION 
SELECT 'HS00000010',	'su',	4,	7,	6.5,	7.5,	8,	8,	8,	9,	'11A01NH1011',8.14,	1 UNION 
SELECT 'HS00000010',	'tduc',	8,	7,	6.5,	7.5,	8,	9,	8,	9,	'11A01NH1011',8.14,	1 UNION 
SELECT 'HS00000010',	'toan',	8,	7,	6.5,	7.5,	8,	7,	8,	9,	'11A01NH1011',8.14,	1 UNION 
SELECT 'HS00000010',	'ngvan',8,	7,	6.5,	7.5,	8,	7,	8,	9,	'11A01NH1011',8.14,	1 UNION 
SELECT 'HS00000010',	'nngu',	8,	7,	6.5,	7.5,	8,	8,	8,	9,	'11A01NH1011',8.14,	1 UNION 
SELECT 'HS00000010',	'tin',	8,	7,	6.5,	7.5,	8,	4,	8,	9,	'11A01NH1011',8.14,	1 UNION 
SELECT 'HS00000010',	'qphong',8,	7,	6.5,	7.5,	8,	7,	8,	9,	'11A01NH1011',8.14,	1 UNION 
SELECT 'HS00000010',	'cnghe',8,	7,	6.5,	7.5,	8,	4,	8,	9,	'11A01NH1011',8.14,	1 UNION 

SELECT 'HS00000011',	'gdcd',	8,	7,	6.5,	7.5,	8,	7,	8,	9,	'11A01NH1011',8.14,	1 UNION 
SELECT 'HS00000011',	'dia',	8,	7,	6.5,	7.5,	8,	7,	8,	9,	'11A01NH1011',8.14,	1 UNION 
SELECT 'HS00000011',	'hoa',	4,	7,	6.5,	7.5,	8,	7,	8,	9,	'11A01NH1011',8.14,	1 UNION 
SELECT 'HS00000011',	'ly',	8,	7,	7,		7.5,	8,	7,	9,	10,	'11A01NH1011',8.14,	1 UNION 
SELECT 'HS00000011',	'sinh',	8,	7,	6.5,	7.5,	8,	7,	8,	9,	'11A01NH1011',8.14,	1 UNION 
SELECT 'HS00000011',	'su',	8,	7,	6.5,	7.5,	8,	7,	8,	9,	'11A01NH1011',8.14,	1 UNION 
SELECT 'HS00000011',	'tduc',	8,	7,	6.5,	7.5,	8,	7,	8,	9,	'11A01NH1011',8.14,	1 UNION 
SELECT 'HS00000011',	'toan',	8,	7,	6.5,	7.5,	8,	7,	8,	9,	'11A01NH1011',8.14,	1 UNION 
SELECT 'HS00000011',	'ngvan',8,	7,	6.5,	7.5,	8,	7,	8,	9,	'11A01NH1011',8.14,	1 UNION 
SELECT 'HS00000011',	'nngu',	8,	7,	6.5,	7.5,	8,	8,	8,	9,	'11A01NH1011',8.14,	1 UNION 
SELECT 'HS00000011',	'tin',	8,	7,	6.5,	7.5,	8,	4,	8,	9,	'11A01NH1011',8.14,	1 UNION 
SELECT 'HS00000011',	'qphong',8,	7,	6.5,	7.5,	8,	7,	8,	9,	'11A01NH1011',8.14,	1 UNION 
SELECT 'HS00000011',	'cnghe',8,	7,	6.5,	7.5,	8,	4,	8,	9,	'11A01NH1011',8.14,	1 UNION 

SELECT 'HS00000012',	'gdcd',	8,	7,	6.5,	7.5,	8,	7,	8,	9,	'11A01NH1011',8.14,	1 UNION 
SELECT 'HS00000012',	'dia',	8,	7,	6.5,	7.5,	8,	7,	8,	9,	'11A01NH1011',8.14,	1 UNION 
SELECT 'HS00000012',	'hoa',	8,	7,	6.5,	7.5,	8,	7,	8,	9,	'11A01NH1011',8.14,	1 UNION 
SELECT 'HS00000012',	'ly',	8,	7,	6.5,	7.5,	8,	7,	8,	9,	'11A01NH1011',8.14,	1 UNION 
SELECT 'HS00000012',	'sinh',	8,	7,	6.5,	7.5,	8,	7,	8,	9,	'11A01NH1011',8.14,	1 UNION 
SELECT 'HS00000012',	'su',	8,	7,	6.5,	7.5,	8,	7,	8,	9,	'11A01NH1011',8.14,	1 UNION 
SELECT 'HS00000012',	'tduc',	9,	7,	6.5,	7.5,	8,	7,	8,	9,	'11A01NH1011',8.14,	1 UNION 
SELECT 'HS00000012',	'toan',	8,	7,	6.5,	7.5,	8,	7,	8,	9,	'11A01NH1011',8.14,	1 UNION 
SELECT 'HS00000012',	'ngvan',8,	7,	6.5,	7.5,	8,	7,	8,	9,	'11A01NH1011',8.14, 1 UNION
SELECT 'HS00000012',	'nngu',	8,	7,	6.5,	7.5,	8,	8,	8,	9,	'11A01NH1011',8.14,	1 UNION 
SELECT 'HS00000012',	'tin',	8,	7,	6.5,	7.5,	8,	4,	8,	9,	'11A01NH1011',8.14,	1 UNION 
SELECT 'HS00000012',	'qphong',8,	7,	6.5,	7.5,	8,	7,	8,	9,	'11A01NH1011',8.14,	1 UNION 
SELECT 'HS00000012',	'cnghe',8,	7,	6.5,	7.5,	8,	4,	8,	9,	'11A01NH1011',8.14,	1 UNION 

SELECT 'HS00000013',	'gdcd',	6,	7,	6.5,	7.5,	8,	7,	8,	9,	'11A02NH1011',8.14,	1 UNION 
SELECT 'HS00000013',	'dia',	8,	7,	6.5,	7.5,	8,	7,	8,	9,	'11A02NH1011',8.14,	1 UNION 
SELECT 'HS00000013',	'hoa',	8,	7,	6.5,	7.5,	8,	7,	8,	9,	'11A02NH1011',8.14,	1 UNION 
SELECT 'HS00000013',	'ly',	8,	7,	7,		7.5,	8,	7,	9,	10,	'11A02NH1011',8.14,	1 UNION 
SELECT 'HS00000013',	'sinh',	8,	7,	6.5,	7.5,	8,	7,	8,	9,	'11A02NH1011',8.14,	1 UNION 
SELECT 'HS00000013',	'su',	8,	7,	6.5,	7.5,	8,	8,	8,	9,	'11A02NH1011',8.14,	1 UNION 
SELECT 'HS00000013',	'tduc',	8,	7,	6.5,	7.5,	8,	4,	8,	9,	'11A02NH1011',8.14,	1 UNION 
SELECT 'HS00000013',	'toan',	8,	7,	6.5,	7.5,	8,	7,	8,	9,	'11A02NH1011',8.14,	1 UNION 
SELECT 'HS00000013',	'ngvan',8,	7,	6.5,	7.5,	8,	4,	8,	9,	'11A02NH1011',8.14,	1 UNION 
SELECT 'HS00000013',	'nngu',	8,	7,	6.5,	7.5,	8,	8,	8,	9,	'11A02NH1011',8.14,	1 UNION 
SELECT 'HS00000013',	'tin',	8,	7,	6.5,	7.5,	8,	4,	8,	9,	'11A02NH1011',8.14,	1 UNION 
SELECT 'HS00000013',	'qphong',8,	7,	6.5,	7.5,	8,	7,	8,	9,	'11A02NH1011',8.14,	1 UNION 
SELECT 'HS00000013',	'cnghe',8,	7,	6.5,	7.5,	8,	4,	8,	9,	'11A02NH1011',8.14,	1 UNION 

SELECT 'HS00000014',	'gdcd',	8,	7,	6.5,	7.5,	8,	7,	8,	9,	'11A02NH1011',8.14,	1 UNION 
SELECT 'HS00000014',	'dia',	8,	7,	6.5,	7.5,	8,	7,	8,	9,	'11A02NH1011',8.14,	1 UNION 
SELECT 'HS00000014',	'hoa',	8,	7,	6.5,	7.5,	8,	7,	8,	9,	'11A02NH1011',8.14,	1 UNION 
SELECT 'HS00000014',	'ly',	6,	7,	7,		7.5,	8,	7,	9,	10,	'11A02NH1011',8.14,	1 UNION 
SELECT 'HS00000014',	'sinh',	8,	7,	6.5,	7.5,	8,	7,	8,	9,	'11A02NH1011',8.14,	1 UNION 
SELECT 'HS00000014',	'su',	4,	7,	6.5,	7.5,	8,	8,	8,	9,	'11A02NH1011',8.14,	1 UNION 
SELECT 'HS00000014',	'tduc',	8,	7,	6.5,	7.5,	8,	9,	8,	9,	'11A02NH1011',8.14,	1 UNION 
SELECT 'HS00000014',	'toan',	8,	7,	6.5,	7.5,	8,	7,	8,	9,	'11A02NH1011',8.14,	1 UNION 
SELECT 'HS00000014',	'ngvan',8,	7,	6.5,	7.5,	8,	7,	8,	9,	'11A02NH1011',8.14,	1 UNION 
SELECT 'HS00000014',	'nngu',	8,	7,	6.5,	7.5,	8,	8,	8,	9,	'11A02NH1011',8.14,	1 UNION 
SELECT 'HS00000014',	'tin',	8,	7,	6.5,	7.5,	8,	4,	8,	9,	'11A02NH1011',8.14,	1 UNION 
SELECT 'HS00000014',	'qphong',8,	7,	6.5,	7.5,	8,	7,	8,	9,	'11A02NH1011',8.14,	1 UNION 
SELECT 'HS00000014',	'cnghe',8,	7,	6.5,	7.5,	8,	4,	8,	9,	'11A02NH1011',8.14,	1 UNION 

SELECT 'HS00000015',	'gdcd',	8,	7,	6.5,	7.5,	8,	7,	8,	9,	'11A02NH1011',8.14,	1 UNION 
SELECT 'HS00000015',	'dia',	8,	7,	6.5,	7.5,	8,	7,	8,	9,	'11A02NH1011',8.14,	1 UNION 
SELECT 'HS00000015',	'hoa',	4,	7,	6.5,	7.5,	8,	7,	8,	9,	'11A02NH1011',8.14,	1 UNION 
SELECT 'HS00000015',	'ly',	8,	7,	7,		7.5,	8,	7,	9,	10,	'11A02NH1011',8.14,	1 UNION 
SELECT 'HS00000015',	'sinh',	8,	7,	6.5,	7.5,	8,	7,	8,	9,	'11A02NH1011',8.14,	1 UNION 
SELECT 'HS00000015',	'su',	8,	7,	6.5,	7.5,	8,	7,	8,	9,	'11A02NH1011',8.14,	1 UNION 
SELECT 'HS00000015',	'tduc',	8,	7,	6.5,	7.5,	8,	7,	8,	9,	'11A02NH1011',8.14,	1 UNION 
SELECT 'HS00000015',	'toan',	8,	7,	6.5,	7.5,	8,	7,	8,	9,	'11A02NH1011',8.14,	1 UNION 
SELECT 'HS00000015',	'ngvan',8,	7,	6.5,	7.5,	8,	7,	8,	9,	'11A02NH1011',8.14,	1 UNION 
SELECT 'HS00000015',	'nngu',	8,	7,	6.5,	7.5,	8,	8,	8,	9,	'11A02NH1011',8.14,	1 UNION 
SELECT 'HS00000015',	'tin',	8,	7,	6.5,	7.5,	8,	4,	8,	9,	'11A02NH1011',8.14,	1 UNION 
SELECT 'HS00000015',	'qphong',8,	7,	6.5,	7.5,	8,	7,	8,	9,	'11A02NH1011',8.14,	1 UNION 
SELECT 'HS00000015',	'cnghe',8,	7,	6.5,	7.5,	8,	4,	8,	9,	'11A02NH1011',8.14,	1 UNION 

SELECT 'HS00000016',	'gdcd',	8,	7,	6.5,	7.5,	8,	7,	8,	9,	'11A02NH1011',8.14,	1 UNION 
SELECT 'HS00000016',	'dia',	8,	7,	6.5,	7.5,	8,	7,	8,	9,	'11A02NH1011',8.14,	1 UNION 
SELECT 'HS00000016',	'hoa',	8,	7,	6.5,	7.5,	8,	7,	8,	9,	'11A02NH1011',8.14,	1 UNION 
SELECT 'HS00000016',	'ly',	8,	7,	6.5,	7.5,	8,	7,	8,	9,	'11A02NH1011',8.14,	1 UNION 
SELECT 'HS00000016',	'sinh',	8,	7,	6.5,	7.5,	8,	7,	8,	9,	'11A02NH1011',8.14,	1 UNION 
SELECT 'HS00000016',	'su',	8,	7,	6.5,	7.5,	8,	7,	8,	9,	'11A02NH1011',8.14,	1 UNION 
SELECT 'HS00000016',	'tduc',	9,	7,	6.5,	7.5,	8,	7,	8,	9,	'11A02NH1011',8.14,	1 UNION 
SELECT 'HS00000016',	'toan',	8,	7,	6.5,	7.5,	8,	7,	8,	9,	'11A02NH1011',8.14,	1 UNION 
SELECT 'HS00000016',	'ngvan',8,	7,	6.5,	7.5,	8,	7,	8,	9,	'11A02NH1011',8.14, 1 UNION
SELECT 'HS00000016',	'nngu',	8,	7,	6.5,	7.5,	8,	8,	8,	9,	'11A02NH1011',8.14,	1 UNION 
SELECT 'HS00000016',	'tin',	8,	7,	6.5,	7.5,	8,	4,	8,	9,	'11A02NH1011',8.14,	1 UNION 
SELECT 'HS00000016',	'qphong',8,	7,	6.5,	7.5,	8,	7,	8,	9,	'11A02NH1011',8.14,	1 UNION 
SELECT 'HS00000016',	'cnghe',8,	7,	6.5,	7.5,	8,	4,	8,	9,	'11A02NH1011',8.14, 1  UNION

SELECT 'HS00000017',	'gdcd',	6,	7,	6.5,	7.5,	8,	7,	8,	9,	'12A01NH1011',8.14,	1 UNION 
SELECT 'HS00000017',	'dia',	8,	7,	6.5,	7.5,	8,	7,	8,	9,	'12A01NH1011',8.14,	1 UNION 
SELECT 'HS00000017',	'hoa',	8,	7,	6.5,	7.5,	8,	7,	8,	9,	'12A01NH1011',8.14,	1 UNION 
SELECT 'HS00000017',	'ly',	8,	7,	6.7,	7.5,	8,	7,	9,	10,	'12A01NH1011',8.14,	1 UNION 
SELECT 'HS00000017',	'sinh',	8,	7,	6.5,	7.5,	8,	7,	8,	9,	'12A01NH1011',8.14,	1 UNION 
SELECT 'HS00000017',	'su',	8,	7,	6.5,	7.5,	8,	8,	8,	9,	'12A01NH1011',8.14,	1 UNION 
SELECT 'HS00000017',	'tduc',	8,	7,	6.5,	7.5,	8,	4,	8,	9,	'12A01NH1011',8.14,	1 UNION 
SELECT 'HS00000017',	'toan',	8,	7,	6.5,	7.5,	8,	7,	8,	9,	'12A01NH1011',8.14,	1 UNION 
SELECT 'HS00000017',	'ngvan',8,	7,	6.5,	7.5,	8,	4,	8,	9,	'12A01NH1011',8.14,	1 UNION 
SELECT 'HS00000017',	'nngu',	8,	7,	6.5,	7.5,	8,	8,	8,	9,	'12A01NH1011',8.14,	1 UNION 
SELECT 'HS00000017',	'tin',	8,	7,	6.5,	7.5,	8,	4,	8,	9,	'12A01NH1011',8.14,	1 UNION 
SELECT 'HS00000017',	'qphong',8,	7,	6.5,	7.5,	8,	7,	8,	9,	'12A01NH1011',8.14,	1 UNION 
SELECT 'HS00000017',	'cnghe',8,	7,	6.5,	7.5,	8,	4,	8,	9,	'12A01NH1011',8.14,	1 UNION 

SELECT 'HS00000018',	'gdcd',	8,	7,	6.5,	7.5,	8,	7,	8,	9,	'12A01NH1011',8.14,	1 UNION 
SELECT 'HS00000018',	'dia',	8,	7,	6.5,	7.5,	8,	7,	8,	9,	'12A01NH1011',8.14,	1 UNION 
SELECT 'HS00000018',	'hoa',	8,	7,	6.5,	7.5,	8,	7,	8,	9,	'12A01NH1011',8.14,	1 UNION 
SELECT 'HS00000018',	'ly',	6,	7,	7,		7.5,	8,	7,	9,	10,	'12A01NH1011',8.14,	1 UNION 
SELECT 'HS00000018',	'sinh',	8,	7,	6.5,	7.5,	8,	7,	8,	9,	'12A01NH1011',8.14,	1 UNION 
SELECT 'HS00000018',	'su',	4,	7,	6.5,	7.5,	8,	8,	8,	9,	'12A01NH1011',8.14,	1 UNION 
SELECT 'HS00000018',	'tduc',	8,	7,	6.5,	7.5,	8,	9,	8,	9,	'12A01NH1011',8.14,	1 UNION 
SELECT 'HS00000018',	'toan',	8,	7,	6.5,	7.5,	8,	7,	8,	9,	'12A01NH1011',8.14,	1 UNION 
SELECT 'HS00000018',	'ngvan',8,	7,	6.5,	7.5,	8,	7,	8,	9,	'12A01NH1011',8.14,	1 UNION 
SELECT 'HS00000018',	'nngu',	8,	7,	6.5,	7.5,	8,	8,	8,	9,	'12A01NH1011',8.14,	1 UNION 
SELECT 'HS00000018',	'tin',	8,	7,	6.5,	7.5,	8,	4,	8,	9,	'12A01NH1011',8.14,	1 UNION 
SELECT 'HS00000018',	'qphong',8,	7,	6.5,	7.5,	8,	7,	8,	9,	'12A01NH1011',8.14,	1 UNION 
SELECT 'HS00000018',	'cnghe',8,	7,	6.5,	7.5,	8,	4,	8,	9,	'12A01NH1011',8.14,	1 UNION 

SELECT 'HS00000019',	'gdcd',	8,	7,	6.5,	7.5,	8,	7,	8,	9,	'12A01NH1011',8.14,	1 UNION 
SELECT 'HS00000019',	'dia',	8,	7,	6.5,	7.5,	8,	7,	8,	9,	'12A01NH1011',8.14,	1 UNION 
SELECT 'HS00000019',	'hoa',	4,	7,	6.5,	7.5,	8,	7,	8,	9,	'12A01NH1011',8.14,	1 UNION 
SELECT 'HS00000019',	'ly',	8,	7,	7,		7.5,	8,	7,	9,	10,	'12A01NH1011',8.14,	1 UNION 
SELECT 'HS00000019',	'sinh',	8,	7,	6.5,	7.5,	8,	7,	8,	9,	'12A01NH1011',8.14,	1 UNION 
SELECT 'HS00000019',	'su',	8,	7,	6.5,	7.5,	8,	7,	8,	9,	'12A01NH1011',8.14,	1 UNION 
SELECT 'HS00000019',	'tduc',	8,	7,	6.5,	7.5,	8,	7,	8,	9,	'12A01NH1011',8.14,	1 UNION 
SELECT 'HS00000019',	'toan',	8,	7,	6.5,	7.5,	8,	7,	8,	9,	'12A01NH1011',8.14,	1 UNION 
SELECT 'HS00000019',	'ngvan',8,	7,	6.5,	7.5,	8,	7,	8,	9,	'12A01NH1011',8.14,	1 UNION 
SELECT 'HS00000019',	'nngu',	8,	7,	6.5,	7.5,	8,	8,	8,	9,	'12A01NH1011',8.14,	1 UNION 
SELECT 'HS00000019',	'tin',	8,	7,	6.5,	7.5,	8,	4,	8,	9,	'12A01NH1011',8.14,	1 UNION 
SELECT 'HS00000019',	'qphong',8,	7,	6.5,	7.5,	8,	7,	8,	9,	'12A01NH1011',8.14,	1 UNION 
SELECT 'HS00000019',	'cnghe',8,	7,	6.5,	7.5,	8,	4,	8,	9,	'12A01NH1011',8.14,	1 UNION 

SELECT 'HS00000020',	'gdcd',	8,	7,	6.5,	7.5,	8,	7,	8,	9,	'12A01NH1011',8.14,	1 UNION 
SELECT 'HS00000020',	'dia',	8,	7,	6.5,	7.5,	8,	7,	8,	9,	'12A01NH1011',8.14,	1 UNION 
SELECT 'HS00000020',	'hoa',	8,	7,	6.5,	7.5,	8,	7,	8,	9,	'12A01NH1011',8.14,	1 UNION 
SELECT 'HS00000020',	'ly',	8,	7,	6.5,	7.5,	8,	7,	8,	9,	'12A01NH1011',8.14,	1 UNION 
SELECT 'HS00000020',	'sinh',	8,	7,	6.5,	7.5,	8,	7,	8,	9,	'12A01NH1011',8.14,	1 UNION 
SELECT 'HS00000020',	'su',	8,	7,	6.5,	7.5,	8,	7,	8,	9,	'12A01NH1011',8.14,	1 UNION 
SELECT 'HS00000020',	'tduc',	9,	7,	6.5,	7.5,	8,	7,	8,	9,	'12A01NH1011',8.14,	1 UNION 
SELECT 'HS00000020',	'toan',	8,	7,	6.5,	7.5,	8,	7,	8,	9,	'12A01NH1011',8.14,	1 UNION 
SELECT 'HS00000020',	'ngvan',8,	7,	6.5,	7.5,	8,	7,	8,	9,	'12A01NH1011', 8.14,1 UNION
SELECT 'HS00000020',	'nngu',	8,	7,	6.5,	7.5,	8,	8,	8,	9,	'12A01NH1011',8.14,	1 UNION 
SELECT 'HS00000020',	'tin',	8,	7,	6.5,	7.5,	8,	4,	8,	9,	'12A01NH1011',8.14,	1 UNION 
SELECT 'HS00000020',	'qphong',8,	7,	6.5,	7.5,	8,	7,	8,	9,	'12A01NH1011',8.14,	1 UNION 
SELECT 'HS00000020',	'cnghe',8,	7,	6.5,	7.5,	8,	4,	8,	9,	'12A01NH1011',8.14,	1 UNION 

SELECT 'HS00000021',	'gdcd',	6,	7,	6.5,	7.5,	8,	7,	8,	9,	'12A02NH1011',8.14,	1 UNION 
SELECT 'HS00000021',	'dia',	8,	7,	6.5,	7.5,	8,	7,	8,	9,	'12A02NH1011',8.14,	1 UNION 
SELECT 'HS00000021',	'hoa',	8,	7,	6.5,	7.5,	8,	7,	8,	9,	'12A02NH1011',8.14,	1 UNION 
SELECT 'HS00000021',	'ly',	8,	7,	7,		7.5,	8,	7,	9,	10,	'12A02NH1011',8.14,	1 UNION 
SELECT 'HS00000021',	'sinh',	8,	7,	6.5,	7.5,	8,	7,	8,	9,	'12A02NH1011',8.14,	1 UNION 
SELECT 'HS00000021',	'su',	8,	7,	6.5,	7.5,	8,	8,	8,	9,	'12A02NH1011',8.14,	1 UNION 
SELECT 'HS00000021',	'tduc',	8,	7,	6.5,	7.5,	8,	4,	8,	9,	'12A02NH1011',8.14,	1 UNION 
SELECT 'HS00000021',	'toan',	8,	7,	6.5,	7.5,	8,	7,	8,	9,	'12A02NH1011',8.14,	1 UNION 
SELECT 'HS00000021',	'ngvan',8,	7,	6.5,	7.5,	8,	4,	8,	9,	'12A02NH1011',8.14,	1 UNION 
SELECT 'HS00000021',	'nngu',	8,	7,	6.5,	7.5,	8,	8,	8,	9,	'12A02NH1011',8.14,	1 UNION 
SELECT 'HS00000021',	'tin',	8,	7,	6.5,	7.5,	8,	4,	8,	9,	'12A02NH1011',8.14,	1 UNION 
SELECT 'HS00000021',	'qphong',8,	7,	6.5,	7.5,	8,	7,	8,	9,	'12A02NH1011',8.14,	1 UNION 
SELECT 'HS00000021',	'cnghe',8,	7,	6.5,	7.5,	8,	4,	8,	9,	'12A02NH1011',8.14,	1 UNION 

SELECT 'HS00000022',	'gdcd',	8,	7,	6.5,	7.5,	8,	7,	8,	9,	'12A02NH1011',8.14,	1 UNION 
SELECT 'HS00000022',	'dia',	8,	7,	6.5,	7.5,	8,	7,	8,	9,	'12A02NH1011',8.14,	1 UNION 
SELECT 'HS00000022',	'hoa',	8,	7,	6.5,	7.5,	8,	7,	8,	9,	'12A02NH1011',8.14,	1 UNION 
SELECT 'HS00000022',	'ly',	6,	7,	7,		7.5,	8,	7,	9,	10,	'12A02NH1011',8.14,	1 UNION 
SELECT 'HS00000022',	'sinh',	8,	7,	6.5,	7.5,	8,	7,	8,	9,	'12A02NH1011',8.14,	1 UNION 
SELECT 'HS00000022',	'su',	4,	7,	6.5,	7.5,	8,	8,	8,	9,	'12A02NH1011',8.14,	1 UNION 
SELECT 'HS00000022',	'tduc',	8,	7,	6.5,	7.5,	8,	9,	8,	9,	'12A02NH1011',8.14,	1 UNION 
SELECT 'HS00000022',	'toan',	8,	7,	6.5,	7.5,	8,	7,	8,	9,	'12A02NH1011',8.14,	1 UNION 
SELECT 'HS00000022',	'ngvan',8,	7,	6.5,	7.5,	8,	7,	8,	9,	'12A02NH1011',8.14,	1 UNION 
SELECT 'HS00000022',	'nngu',	8,	7,	6.5,	7.5,	8,	8,	8,	9,	'12A02NH1011',8.14,	1 UNION 
SELECT 'HS00000022',	'tin',	8,	7,	6.5,	7.5,	8,	4,	8,	9,	'12A02NH1011',8.14,	1 UNION 
SELECT 'HS00000022',	'qphong',8,	7,	6.5,	7.5,	8,	7,	8,	9,	'12A02NH1011',8.14,	1 UNION 
SELECT 'HS00000022',	'cnghe',8,	7,	6.5,	7.5,	8,	4,	8,	9,	'12A02NH1011',8.14,	1 UNION 

SELECT 'HS00000023',	'gdcd',	8,	7,	6.5,	7.5,	8,	7,	8,	9,	'12A02NH1011',8.14,	1 UNION 
SELECT 'HS00000023',	'dia',	8,	7,	6.5,	7.5,	8,	7,	8,	9,	'12A02NH1011',8.14,	1 UNION 
SELECT 'HS00000023',	'hoa',	4,	7,	6.5,	7.5,	8,	7,	8,	9,	'12A02NH1011',8.14,	1 UNION 
SELECT 'HS00000023',	'ly',	8,	7,	7,		7.5,	8,	7,	9,	10,	'12A02NH1011',8.14,	1 UNION 
SELECT 'HS00000023',	'sinh',	8,	7,	6.5,	7.5,	8,	7,	8,	9,	'12A02NH1011',8.14,	1 UNION 
SELECT 'HS00000023',	'su',	8,	7,	6.5,	7.5,	8,	7,	8,	9,	'12A02NH1011',8.14,	1 UNION 
SELECT 'HS00000023',	'tduc',	8,	7,	6.5,	7.5,	8,	7,	8,	9,	'12A02NH1011',8.14,	1 UNION 
SELECT 'HS00000023',	'toan',	8,	7,	6.5,	7.5,	8,	7,	8,	9,	'12A02NH1011',8.14,	1 UNION 
SELECT 'HS00000023',	'ngvan',8,	7,	6.5,	7.5,	8,	7,	8,	9,	'12A02NH1011',8.14,	1 UNION 
SELECT 'HS00000023',	'nngu',	8,	7,	6.5,	7.5,	8,	8,	8,	9,	'12A02NH1011',8.14,	1 UNION 
SELECT 'HS00000023',	'tin',	8,	7,	6.5,	7.5,	8,	4,	8,	9,	'12A02NH1011',8.14,	1 UNION 
SELECT 'HS00000023',	'qphong',8,	7,	6.5,	7.5,	8,	7,	8,	9,	'12A02NH1011',8.14,	1 UNION 
SELECT 'HS00000023',	'cnghe',8,	7,	6.5,	7.5,	8,	4,	8,	9,	'12A02NH1011',8.14,	1 UNION 

SELECT 'HS00000024',	'gdcd',	8,	7,	6.5,	7.5,	8,	7,	8,	9,	'12A02NH1011',8.14,	1 UNION 
SELECT 'HS00000024',	'dia',	8,	7,	6.5,	7.5,	8,	7,	8,	9,	'12A02NH1011',8.14,	1 UNION 
SELECT 'HS00000024',	'hoa',	8,	7,	6.5,	7.5,	8,	7,	8,	9,	'12A02NH1011',8.14,	1 UNION 
SELECT 'HS00000024',	'ly',	8,	7,	6.5,	7.5,	8,	7,	8,	9,	'12A02NH1011',8.14,	1 UNION 
SELECT 'HS00000024',	'sinh',	8,	7,	6.5,	7.5,	8,	7,	8,	9,	'12A02NH1011',8.14,	1 UNION 
SELECT 'HS00000024',	'su',	8,	7,	6.5,	7.5,	8,	7,	8,	9,	'12A02NH1011',8.14,	1 UNION 
SELECT 'HS00000024',	'tduc',	9,	7,	6.5,	7.5,	8,	7,	8,	9,	'12A02NH1011',8.14,	1 UNION 
SELECT 'HS00000024',	'toan',	8,	7,	6.5,	7.5,	8,	7,	8,	9,	'12A02NH1011',8.14,	1 UNION 
SELECT 'HS00000024',	'ngvan',8,	7,	6.5,	7.5,	8,	7,	8,	9,	'12A02NH1011',8.14, 1 UNION
SELECT 'HS00000024',	'nngu',	8,	7,	6.5,	7.5,	8,	8,	8,	9,	'12A02NH1011',8.14,	1 UNION 
SELECT 'HS00000024',	'tin',	8,	7,	6.5,	7.5,	8,	4,	8,	9,	'12A02NH1011',8.14,	1 UNION 
SELECT 'HS00000024',	'qphong',8,	7,	6.5,	7.5,	8,	7,	8,	9,	'12A02NH1011',8.14,	1 UNION 
SELECT 'HS00000024',	'cnghe',8,	7,	6.5,	7.5,	8,	4,	8,	9,	'12A02NH1011',8.14, 1  


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

