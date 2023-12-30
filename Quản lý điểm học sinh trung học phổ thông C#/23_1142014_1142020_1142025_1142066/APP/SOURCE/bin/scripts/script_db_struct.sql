use  QLHS_HCMUS
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
INSERT INTO GIAOVIEN ([MaGiaoVien],[TenGiaoVien]) SELECT 'GV000',  N'Quản trị viên'
INSERT INTO LOAINGUOIDUNG(MaLoaiND,TenLoaiND)SELECT 'giaovu',	 N'Giáo vụ'			UNIONSELECT 'quantri',	 N'Quản trị viên'	UNIONSELECT 'hieutruong', N'Hiệu trưởng'		UNIONSELECT 'giaovien',	 N'Giáo viên'-- table NguoiDungINSERT INTO NGUOIDUNG(MaLoaiND,MaND,MatKhau,TenDNhap,TrangThai)SELECT 'quantri',	'GV000','202cb962ac59075b964b07152d234b70',	'admin',	1INSERT INTO NAMHOC(MaNamHoc,TenNamHoc)
SELECT 'NH1011', '2010-2011'
-- table MONHOCINSERT INTO MONHOC(MaMonHoc,TenMonHoc,SoTiet,HeSo,TrangThai) SELECT 'toan',	N'Toán học',	90,		2,	1 UNIONSELECT 'ly',	N'Vật lý',		60,		1,	1 UNIONSELECT 'hoa',	N'Hóa học',		60,		1,	1 UNIONSELECT 'sinh',	N'Sinh học',	60,		1,	1 UNIONSELECT 'ngvan',	N'Ngữ văn',		90,		2,	1 UNIONSELECT 'su',	N'Lịch sử',		45,		1,	1 UNIONSELECT 'dia',	N'Địa lý',		45,		1,	1 UNIONSELECT 'nngu',	N'Nại ngữ',	45,		1,	1 UNIONSELECT 'gdcd',	N'GD Công dân',	30,		1,	1 UNIONSELECT 'tin',	N'Tin học',		30,		1,	1 UNIONSELECT 'tduc',	N'Thể dục',		30,		1,	1 UNIONSELECT 'qphong',N'Quốc phòng',	30,		1,	1 UNIONSELECT 'cnghe',	N'Công Nghệ',	30,		1,	1-- Quy DinhINSERT INTO QUYDINH (Khoa,GiaTri)  SELECT 'DiaChiTruong',	''	UNION SELECT 'DiemChuan',		'8'				UNION SELECT 'SiSoCanTren',	'45'			UNION SELECT 'SoLuongLop',	'20'			UNION SELECT 'TenTruong',		N'' UNION SELECT 'TuoiCanDuoi',	'15'			UNION SELECT 'TuoiCanTren',	'18'			UNIONSELECT 'MaNamHocHT', 'NH1011'			UNIONSELECT 'NgayApDung', '24-05-2010' 