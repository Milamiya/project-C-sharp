-----------------------------------------------------------------------------
--------------->TAO DATABASE QLDUOCTINDUC
-----------------------------------------------------------------------------
CREATE DATABASE QLDUOCTINDUC ON 
(Name = QLDUOCTINDUC, 
FILENAME = 'E:\PROJECT\HK7\LTQL&CCPTPM\DO AN\DataBase\QLDUOCTINDUC.mdf',
SIZE = 10,
MAXSIZE = 50,
FILEGROWTH = 5)
LOG ON
(NAME = 'QLDUOCTINDUC_Log',
FILENAME = 'E:\PROJECT\HK7\LTQL&CCPTPM\DO AN\DataBase\QLDUOCTINDUC.ldf',
SIZE = 5MB,
MAXSIZE = 25MB,
FILEGROWTH = 5MB)
GO
-----------------------------------------------------------------------------
--------------->TAO TABLE LOAITHUOC
-----------------------------------------------------------------------------
USE QLDUOCTINDUC
CREATE TABLE LOAITHUOC(
	[MALOAITHUOC] [CHAR] (6) NOT NULL,
	[TENLOAI] [CHAR] (6) NOT NULL,
	[HESOLUONG] [INT] NOT NULL,
	CONSTRAINT P_LOAITHUOC PRIMARY KEY (MALOAITHUOC)
)
GO
-----------------------------------------------------------------------------
--------------->TAO TABLE KHO
-----------------------------------------------------------------------------
USE QLDUOCTINDUC
CREATE TABLE KHO(
	[MAKHO] [CHAR] (6) NOT NULL,
	[TENKHO] [CHAR] (100) NOT NULL,
	[DIADIEM] [CHAR] (200) NOT NULL,
	CONSTRAINT P_KHO PRIMARY KEY (MAKHO)
)
GO
-----------------------------------------------------------------------------
--------------->TAO TABLE NHANVIEN
-----------------------------------------------------------------------------
USE QLDUOCTINDUC
CREATE TABLE NHANVIEN(
	[MANV] [CHAR] (6) NOT NULL,
	[HOTENNV] [CHAR] (20) NOT NULL,
	[GIOITINH] [CHAR] (3) NOT NULL,
	[NGAYSINH] [DATETIME] NOT NULL,
	[DIACHI] [CHAR] (200) NOT NULL,
	[DIENTHOAI] [CHAR] (20) NOT NULL,
	[TENLOAINV] [CHAR] (100) NOT NULL,
	[TENDN] [NVARCHAR] (30) NOT NULL,
	[MATKHAU] [VARCHAR] (20) NOT NULL,
	CONSTRAINT P_NHANVIEN PRIMARY KEY (MANV)
)
GO
-----------------------------------------------------------------------------
--------------->TAO TABLE HT_THANHTOAN 
-----------------------------------------------------------------------------
USE QLDUOCTINDUC
CREATE TABLE HT_THANHTOAN(
	[MAHT] [CHAR] (6) NOT NULL,
	[TENHT] [CHAR] (100) NOT NULL,
	CONSTRAINT P_HT_THANHTOAN PRIMARY KEY (MAHT)
)
GO
-----------------------------------------------------------------------------
--------------->TAO TABLE NHACC 
-----------------------------------------------------------------------------
USE QLDUOCTINDUC
CREATE TABLE NHACC(
	[MANCC] [CHAR] (6) NOT NULL,
	[TENNCC] [CHAR] (300) NOT NULL,
	[DIACHINCC] [CHAR] (200) NOT NULL,
	[DIENTHOAINCC] [CHAR] (20) NOT NULL,
	CONSTRAINT P_NHACC PRIMARY KEY (MANCC)
)
GO
-----------------------------------------------------------------------------
--------------->TAO TABLE LOAIKH
-----------------------------------------------------------------------------
USE QLDUOCTINDUC
CREATE TABLE LOAIKH(
	[MALOAIKH] [CHAR] (6) NOT NULL,
	[TENLOAIKH] [CHAR] (100) NOT NULL,
	CONSTRAINT P_LOAIKH PRIMARY KEY (MALOAIKH)
)
GO
-----------------------------------------------------------------------------
--------------->TAO TABLE TINHLUONG
-----------------------------------------------------------------------------
USE QLDUOCTINDUC
CREATE TABLE TINHLUONG(
	[MALUONG] [CHAR] (6) NOT NULL,
	[MANV] [CHAR] (6) NOT NULL,
	[TONGLUONG] [INT] NOT NULL,
	CONSTRAINT P_TINHLUONG PRIMARY KEY (MALUONG)
)
GO
-----------------------------------------------------------------------------
--------------->TAO TABLE DIABANHD 
-----------------------------------------------------------------------------
USE QLDUOCTINDUC
CREATE TABLE DIABANHD(
	[MADB] [CHAR] (6) NOT NULL,
	[DIACHIDB] [CHAR] (200) NOT NULL,
	[GHICHU] [CHAR] (600) NOT NULL,
	CONSTRAINT P_DIABANHD PRIMARY KEY (MADB)
)
GO
-----------------------------------------------------------------------------
--------------->TAO TABLE DVTINH
-----------------------------------------------------------------------------
USE QLDUOCTINDUC
CREATE TABLE DVTINH(
	[MADVT] [CHAR] (6) NOT NULL,
	[TENDVT] [CHAR] (100) NOT NULL,
	CONSTRAINT P_DVTINH PRIMARY KEY (MADVT)
)
GO
-----------------------------------------------------------------------------
--------------->TAO TABLE THUOC 
-----------------------------------------------------------------------------
USE QLDUOCTINDUC
CREATE TABLE THUOC(
	[MATHUOC] [CHAR] (6) NOT NULL,
	[TENTHUOC] [CHAR] (100) NOT NULL,
	[MADVT] [CHAR] (6) NOT NULL,
	[SOLUONG] [INT] NOT NULL,
	[DONGIAMUA] [INT] NOT NULL,
	[DONGIABAN] [INT] NOT NULL,
	[MALOAITHUOC] [CHAR] (6) NOT NULL,
	CONSTRAINT P_THUOC PRIMARY KEY (MATHUOC),
	CONSTRAINT F_THUOC_MADVT FOREIGN KEY (MADVT) REFERENCES DVTINH(MADVT), 
	CONSTRAINT F_THUOC_MALOAITHUOC FOREIGN KEY (MALOAITHUOC) REFERENCES LOAITHUOC(MALOAITHUOC)
)
GO
-----------------------------------------------------------------------------
--------------->TAO TABLE TDVIEN
-----------------------------------------------------------------------------
USE QLDUOCTINDUC
CREATE TABLE TDVIEN(
	[MATDV] [CHAR] (6) NOT NULL,
	[HOTENTDV] [CHAR] (20) NOT NULL,
	[GIOITINH] [CHAR] (3) NOT NULL,
	[DIACHI] [CHAR] (200) NOT NULL,
	[DIENTHOAI] [CHAR] (20) NOT NULL,
	[LUONGCANBAN] [INT] NOT NULL,
	CONSTRAINT P_TDVIEN PRIMARY KEY (MATDV)
)
GO
-----------------------------------------------------------------------------
--------------->TAO TABLE PHANCONG_DBHD
-----------------------------------------------------------------------------
USE QLDUOCTINDUC
CREATE TABLE PHANCONG_DBHD(
	[MATDV] [CHAR] (6) NOT NULL,
	[MADB] [CHAR] (6) NOT NULL,
	[MATHUOC] [CHAR] (6) NOT NULL,
	CONSTRAINT P_PHANCONG_DBHD PRIMARY KEY (MATDV, MADB, MATHUOC),
	CONSTRAINT F_PHANCONG_DBHD_MATDV FOREIGN KEY (MATDV) REFERENCES TDVIEN(MATDV),
	CONSTRAINT F_PHANCONG_DBHD_MADB FOREIGN KEY (MADB) REFERENCES DIABANHD(MADB),
	CONSTRAINT F_PHANCONG_DBHD_MATHUOC FOREIGN KEY (MATHUOC) REFERENCES THUOC(MATHUOC)
 
	
)
GO
-----------------------------------------------------------------------------
--------------->TAO TABLE LOTHUOC
-----------------------------------------------------------------------------
USE QLDUOCTINDUC
CREATE TABLE LOTHUOC(
	[MALO] [CHAR] (6) NOT NULL,
	[TENLO] [CHAR] (100) NOT NULL,
	[NGAYSX] [DATETIME] NOT NULL,
	[NGAYHH] [DATETIME] NOT NULL,
	[SOLUONG] [INT] NOT NULL,
	[MATHUOC] [CHAR] (6) NOT NULL,
	[THANHTIEN] [INT] NOT NULL,
	CONSTRAINT P_LOTHUOC PRIMARY KEY (MALO),
	CONSTRAINT F_LOTHUOC_MATHUOC FOREIGN KEY (MATHUOC) REFERENCES THUOC(MATHUOC)
)
GO
-----------------------------------------------------------------------------
--------------->TAO TABLE PHIEUTHANHLI
-----------------------------------------------------------------------------
USE QLDUOCTINDUC
CREATE TABLE PHIEUTHANHLI(
	[MAPHIEUTL] [CHAR] (6) NOT NULL,
	[MAKHO] [CHAR] (6) NOT NULL,
	[NGAYTHANH] [DATETIME] NOT NULL,
	[MANV] [CHAR] (6) NOT NULL,
	CONSTRAINT P_PHIEUTHANHLI PRIMARY KEY (MAPHIEUTL),
	CONSTRAINT F_PHIEUTHANHLI_MAKHO FOREIGN KEY (MAKHO) REFERENCES KHO(MAKHO),
	CONSTRAINT F_PHIEUTHANHLI_MANV FOREIGN KEY (MANV) REFERENCES NHANVIEN(MANV)
)
GO
-----------------------------------------------------------------------------
--------------->TAO TABLE CT_PHIEUTHANHLI
-----------------------------------------------------------------------------
USE QLDUOCTINDUC
CREATE TABLE CT_PHIEUTHANHLI(
	[MAPHIEUTL] [CHAR] (6) NOT NULL,
	[MATHUOC] [CHAR] (6) NOT NULL,	
	CONSTRAINT P_CT_PHIEUTHANHLI PRIMARY KEY (MAPHIEUTL, MATHUOC),
	CONSTRAINT F_CT_PHIEUTHANHLI_MAPHIEUTL FOREIGN KEY (MAPHIEUTL) REFERENCES PHIEUTHANHLI(MAPHIEUTL),
	CONSTRAINT F_CT_PHIEUTHANHLI_MATHUOC FOREIGN KEY (MATHUOC) REFERENCES THUOC(MATHUOC)
)
GO
-----------------------------------------------------------------------------
--------------->TAO TABLE KHACHHANG 
-----------------------------------------------------------------------------
USE QLDUOCTINDUC
CREATE TABLE KHACHHANG(
	[MAKH] [CHAR] (6) NOT NULL,
	[HOTENKH] [CHAR] (20) NOT NULL,
	[DIACHIKH] [CHAR] (200) NOT NULL,
	[DIENTHOAI] [CHAR] (20) NOT NULL,
  	[MALOAIKH] [CHAR] (6) NOT NULL,
	CONSTRAINT P_KHACHHANG PRIMARY KEY (MAKH),
	CONSTRAINT F_KHACHHANG_MALOAIKH FOREIGN KEY (MALOAIKH) REFERENCES LOAIKH(MALOAIKH)
)
GO
-----------------------------------------------------------------------------
--------------->TAO TABLE PHIEUXUATKHO
-----------------------------------------------------------------------------
USE QLDUOCTINDUC
CREATE TABLE PHIEUXUATKHO(
	[MAPHIEUXK] [CHAR] (6) NOT NULL,
	[MAKH] [CHAR] (6) NOT NULL,
	[MAKHO] [CHAR] (6) NOT NULL,
	[NGAYXUAT] [DATETIME] NOT NULL,
	[MANV] [CHAR] (6) NOT NULL,
	CONSTRAINT P_PHIEUXUATKHO PRIMARY KEY (MAPHIEUXK),
	CONSTRAINT F_PHIEUXUATKHO_MAKH FOREIGN KEY (MAKH) REFERENCES KHACHHANG(MAKH),
	CONSTRAINT F_PHIEUXUATKHO_MAKHO FOREIGN KEY (MAKHO) REFERENCES KHO(MAKHO),
	CONSTRAINT F_PHIEUXUATKHO_MANV FOREIGN KEY (MANV) REFERENCES NHANVIEN(MANV)
)
GO
-----------------------------------------------------------------------------
--------------->TAO TABLE  CT_PHIEUXUATKHO
-----------------------------------------------------------------------------
USE QLDUOCTINDUC
CREATE TABLE CT_PHIEUXUATKHO(
	[MAPHIEUXK] [CHAR] (6) NOT NULL,
	[MATHUOC] [CHAR] (6) NOT NULL,
	[SOLUONG] [INT] NOT NULL,	
	CONSTRAINT P_CT_PHIEUXUATKHO PRIMARY KEY (MAPHIEUXK, MATHUOC),
	CONSTRAINT F_CT_PHIEUXUATKHO_MAPHIEUXK FOREIGN KEY (MAPHIEUXK) REFERENCES PHIEUXUATKHO(MAPHIEUXK),
	CONSTRAINT F_CT_PHIEUXUATKHO_MATHUOC FOREIGN KEY (MATHUOC) REFERENCES THUOC(MATHUOC)
)
GO
-----------------------------------------------------------------------------
--------------->TAO TABLE PHIEUDATHANG
-----------------------------------------------------------------------------
USE QLDUOCTINDUC
CREATE TABLE PHIEUDATHANG(
	[MAPHIEUDH] [CHAR] (6) NOT NULL,
	[MAKH] [CHAR] (6) NOT NULL,
	[MAHT] [CHAR] (6) NOT NULL,
	[NGAYGIAO] [DATETIME] NOT NULL,
	[NOIGIAO] [CHAR] (200) NOT NULL,
	[NGAYLAP] [DATETIME] NOT NULL,
	[TONGTIEN] [INT] NULL,
	[MANV] [CHAR] (6) NOT NULL,
	CONSTRAINT P_PHIEUDATHANG PRIMARY KEY (MAPHIEUDH),
	CONSTRAINT F_PHIEUDATHANG_MAKH FOREIGN KEY (MAKH) REFERENCES KHACHHANG(MAKH),
	CONSTRAINT F_PHIEUDATHANG_MAHT FOREIGN KEY (MAHT) REFERENCES HT_THANHTOAN(MAHT),
	CONSTRAINT F_PHIEUDATHANG_MANV FOREIGN KEY (MANV) REFERENCES NHANVIEN(MANV)
)
GO
-----------------------------------------------------------------------------
--------------->TAO TABLE CT_PHIEUDATHANG
-----------------------------------------------------------------------------
USE QLDUOCTINDUC
CREATE TABLE CT_PHIEUDATHANG(
	[MAPHIEUDH] [CHAR] (6) NOT NULL,
	[MATHUOC] [CHAR] (6) NOT NULL,
	[SOLUONG] [INT] NOT NULL,	
	CONSTRAINT P_CT_PHIEUDATHANG PRIMARY KEY (MAPHIEUDH, MATHUOC),
	CONSTRAINT F_CT_PHIEUDATHANG_MATHUOC FOREIGN KEY (MATHUOC) REFERENCES THUOC(MATHUOC)
)
GO
-----------------------------------------------------------------------------
--------------->TAO TABLE PHIEUNHAPKHO 
-----------------------------------------------------------------------------
USE QLDUOCTINDUC
CREATE TABLE PHIEUNHAPKHO(
	[MAPHIEUNK] [CHAR] (6) NOT NULL,
	[NGAYNK] [DATETIME] NOT NULL,
	[MANV] [CHAR] (6) NOT NULL,
	[MAKHO] [CHAR] (6) NOT NULL,
	CONSTRAINT P_PHIEUNHAPKHO PRIMARY KEY (MAPHIEUNK),
	CONSTRAINT F_PHIEUNHAPKHO_MANV FOREIGN KEY (MANV) REFERENCES NHANVIEN(MANV),
	CONSTRAINT F_PHIEUNHAPKHO_MAKHO FOREIGN KEY (MAKHO) REFERENCES KHO(MAKHO)
)
GO
-----------------------------------------------------------------------------
--------------->TAO TABLE CT_PHIEUNHAPKHO
-----------------------------------------------------------------------------
USE QLDUOCTINDUC
CREATE TABLE CT_PHIEUNHAPKHO(
	[MAPHIEUNK] [CHAR] (6) NOT NULL,
	[MATHUOC] [CHAR] (6) NOT NULL,	
	CONSTRAINT P_CT_PHIEUNHAPKHO PRIMARY KEY (MAPHIEUNK, MATHUOC),
	CONSTRAINT F_CT_PHIEUNHAPKHO_MAPHIEUNK FOREIGN KEY (MAPHIEUNK) REFERENCES PHIEUNHAPKHO(MAPHIEUNK),
	CONSTRAINT F_CT_PHIEUNHAPKHO_MATHUOC FOREIGN KEY (MATHUOC) REFERENCES THUOC(MATHUOC)
)
GO
-----------------------------------------------------------------------------
--------------->TAO TABLE HD_MUATHUOC
-----------------------------------------------------------------------------
USE QLDUOCTINDUC
CREATE TABLE HD_MUATHUOC(
	[MAHD] [CHAR] (6) NOT NULL,
	[NGAYLAP] [DATETIME] NOT NULL,
	[NGAYNHAN] [DATETIME] NOT NULL, 
	[NOINHAN] [CHAR] (200) NOT NULL,
	[TONGTIEN] [INT] NULL,
	[SLGIAO] [INT] NOT NULL,
	[MANCC] [CHAR] (6) NOT NULL,
	[MANV] [CHAR] (6) NOT NULL,
	CONSTRAINT P_HD_MUATHUOC PRIMARY KEY (MAHD),
	CONSTRAINT F_HD_MUATHUOC_MANCC FOREIGN KEY (MANCC) REFERENCES NHACC(MANCC),
	CONSTRAINT F_HD_MUATHUOC_MANV FOREIGN KEY (MANV) REFERENCES NHANVIEN(MANV)
)
GO
-----------------------------------------------------------------------------
--------------->TAO TABLE CT_HD_MUATHUOC
-----------------------------------------------------------------------------
USE QLDUOCTINDUC
CREATE TABLE CT_HD_MUATHUOC(
	[MAHD] [CHAR] (6) NOT NULL,
	[MATHUOC] [CHAR] (6) NOT NULL,
	[SOLUONG] [INT] NOT NULL,
	[DONGIA] [INT] NOT NULL,
	[THANHTIEN] [INT] NULL,
	CONSTRAINT P_CTHDMT PRIMARY KEY (MAHD,MATHUOC),
	CONSTRAINT F_CTHDMT_MAHD FOREIGN KEY (MAHD) REFERENCES HD_MUATHUOC(MAHD),
	CONSTRAINT F_CTHDMT_MATHUOC FOREIGN KEY (MATHUOC) REFERENCES THUOC(MATHUOC)
)
GO
-----------------------------------------------------------------------------
--------------->TAO TABLE PHIEUNHANHANG
-----------------------------------------------------------------------------
USE QLDUOCTINDUC
CREATE TABLE PHIEUNHANHANG(
	[MAPHIEUNH] [CHAR] (6) NOT NULL,
	[MAHD] [CHAR] (6) NOT NULL,
	[NGAYGIAO] [DATETIME] NOT NULL,
	[TONGTIEN] [INT] NULL,
	[MANV] [CHAR] (6) NOT NULL,
	CONSTRAINT P_PHIEUNHANHANG PRIMARY KEY (MAPHIEUNH),
	CONSTRAINT F_PHIEUNHANHANG_MAHD FOREIGN KEY (MAHD) REFERENCES HD_MUATHUOC(MAHD),
	CONSTRAINT F_PHIEUNHANHANG_MANV FOREIGN KEY (MANV) REFERENCES NHANVIEN(MANV)
)
GO
-----------------------------------------------------------------------------
--------------->TAO TABLE CT_PHIEUNHANHANG
-----------------------------------------------------------------------------
USE QLDUOCTINDUC
CREATE TABLE CT_PHIEUNHANHANG(
	[MAPHIEUNH] [CHAR] (6) NOT NULL,
	[MATHUOC] [CHAR] (6) NOT NULL,	
	[SOLUONG] [INT] NOT NULL,
	[DONGIA] [INT] NOT NULL,
	[THANHTIEN] [INT] NOT NULL,
	CONSTRAINT P_CT_PHIEUNHANHANG PRIMARY KEY (MAPHIEUNH, MATHUOC),
	CONSTRAINT F_CT_PHIEUNHANHANG_MAPHIEUNH FOREIGN KEY (MAPHIEUNH) REFERENCES PHIEUNHANHANG(MAPHIEUNH),
	CONSTRAINT F_CT_PHIEUNHANHANG_MATHUOC FOREIGN KEY (MATHUOC) REFERENCES THUOC(MATHUOC)
)
GO
--------------->>NHAP DATABASE----------------
-----------------------------------------------------------------------------
--------------->NHAP TABLE LOAITHUOC
-----------------------------------------------------------------------------
USE QLDUOCTINDUC
INSERT INTO LOAITHUOC(MALOAITHUOC,TENLOAI,HESOLUONG)
	VALUES ('MLT01','LIST 1',1)
INSERT INTO LOAITHUOC(MALOAITHUOC,TENLOAI,HESOLUONG)
	VALUES ('MLT02','LIST 2',2)
-----------------------------------------------------------------------------
--------------->NHAP TABLE TDVIEN
-----------------------------------------------------------------------------
INSERT INTO TDVIEN(MATDV,HOTENTDV,GIOITINH,DIACHI,DIENTHOAI,LUONGCANBAN)
	VALUES ('MTDV01','TRAN VAN AN',1,'TPHCM','0989999999',1500000)
INSERT INTO TDVIEN(MATDV,HOTENTDV,GIOITINH,DIACHI,DIENTHOAI,LUONGCANBAN)
	VALUES ('MTDV02','BUI THI MEN',0,'TPLX','0989090909',1000000)
 
-----------------------------------------------------------------------------
--------------->NHAP TABLE NHACC
-----------------------------------------------------------------------------
USE QLDUOCTINDUC
INSERT INTO NHACC(MANCC,TENNCC,DIACHINCC,DIENTHOAINCC)
	VALUES ('NCC01','ANGIMEX','TPCT','076985623')
-----------------------------------------------------------------------------
--------------->NHAP TABLE NHANVIEN
-----------------------------------------------------------------------------
USE QLDUOCTINDUC
INSERT INTO NHANVIEN(MANV,HOTENNV,GIOITINH,NGAYSINH,DIACHI,DIENTHOAI,TENLOAINV,TENDN,MATKHAU)
	VALUES('MNV01','TRAN VAN BINH','NAM','12/3/1982','MY BINH','0919654123','TRUONG PHONG','admin','admin')
-----------------------------------------------------------------------------
--------------->NHAP TABLE KHACHHANG
-----------------------------------------------------------------------------
USE QLDUOCTINDUC
INSERT INTO KHACHHANG(MAKH,HOTENKH,DIACHIKH,DIENTHOAI,MALOAIKH)
	VALUES('MKH01','NGUYE VAN GIAU','HA NOI','099999999','LKH01')
-----------------------------------------------------------------------------
--------------->NHAP TABLE PHANCONG_DBHD
-----------------------------------------------------------------------------
USE QLDUOCTINDUC
INSERT INTO PHANCONG_DBHD(MATDV,MADB,MATHUOC)
	VALUES ('MTDV01','MDB01','MTH01')
-----------------------------------------------------------------------------
--------------->NHAP TABLE THUOC
-----------------------------------------------------------------------------
INSERT INTO THUOC(MATHUOC,TENTHUOC,MADVT,SOLUONG,DONGIAMUA,DONGIABAN,MALOAITHUOC)
	VALUES ('MTH01','PARA','DVT03',5,20,25,'MLT03')
-----------------------------------------------------------------------------
--------------->NHAP TABLE KHO
-----------------------------------------------------------------------------
INSERT INTO KHO(MAKHO,TENKHO,DIADIEM)
	VALUES ('MKH01','KHO 1','DAY1')
-----------------------------------------------------------------------------
--------------->NHAP TABLE LOTHUOC
-----------------------------------------------------------------------------
INSERT INTO LOTHUOC(MALO,TENLO,NGAYSX,NGAYHH,SOLUONG,MATHUOC,THANHTIEN)
	VALUES ('ML01','LO 1',20/12/2006,20/12/2008,200,'MTH01',200000)
-----------------------------------------------------------------------------
--------------->NHAP TABLE DVTINH
-----------------------------------------------------------------------------
INSERT INTO DVTINH(MADVT,TENDVT)
	VALUES('MDV01','CHAI')
INSERT INTO DVTINH(MADVT,TENDVT)
	VALUES('MDV02','BAO')
-----------------------------------------------------------------------------
--------------->NHAP TABLE HT_THANHTOAN
-----------------------------------------------------------------------------
INSERT INTO HT_THANHTOAN(MAHT,TENHT)
	VALUES ('MHT01','CHUYEN KHOAN')
-----------------------------------------------------------------------------
--------------->NHAP TABLE LOAIKH
-----------------------------------------------------------------------------
INSERT INTO LOAIKH(MALOAIKH,TENLOAIKH)
	VALUES ('MLH01','THAN THUOC')
-----------------------------------------------------------------------------
--------------->NHAP TABLE
-----------------------------------------------------------------------------

-----------------------------------------------------------------------------
--------------->NHAP TABLE
-----------------------------------------------------------------------------

-----------------------------------------------------------------------------
--------------->NHAP TABLE
-----------------------------------------------------------------------------

-----------------------------------------------------------------------------
--------------->NHAP TABLE
-----------------------------------------------------------------------------

-----------------------------------------------------------------------------
--------------->NHAP TABLE
-----------------------------------------------------------------------------

-----------------------------------------------------------------------------
--------------->NHAP TABLE
-----------------------------------------------------------------------------

-----------------------------------------------------------------------------
--------------->NHAP TABLE
-----------------------------------------------------------------------------

-----------------------------------------------------------------------------
--------------->NHAP TABLE
-----------------------------------------------------------------------------

-----------------------------------------------------------------------------
--------------->NHAP TABLE
-----------------------------------------------------------------------------

-----------------------------------------------------------------------------
--------------->NHAP TABLE
-----------------------------------------------------------------------------

-----------------------------------------------------------------------------
--------------->NHAP TABLE
-----------------------------------------------------------------------------

-----------------------------------------------------------------------------
--------------->NHAP TABLE
-----------------------------------------------------------------------------

-----------------------------------------------------------------------------
--------------->NHAP TABLE
-----------------------------------------------------------------------------