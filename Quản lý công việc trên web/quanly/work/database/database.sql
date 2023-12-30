/* Database Size: 1500 Bytes */
CREATE DATABASE /*!IF NOT EXISTS*/ CongViec;

/* Databaase Used: CongViec */
USE CongViec;

/* Table Name: NhanVien */
/* Field No: 9 */
/* MaNQL Field: Ma Nguoi Quan Ly */
/* Total Size: 138 Bytes */
	/* No. 1 */
CREATE TABLE NhanVien(
	MaNV 		CHAR(9) NOT NULL,
	MaGroup	INT/*!(4)*/ NOT NULL REFERENCES Groups,
	TenNV 	VARCHAR(30) NOT NULL,
	NgaySinh 	DATE NOT NULL,
	DiaChi	VARCHAR(50) NOT NULL,
	Phai		TINYINT/*!(1)*/ NOT NULL,
	Phone		VARCHAR(9) NULL,
	UserName	CHAR(16) NOT NULL,
	Password	VARCHAR(16) /*NOT*/ NULL,
	UNIQUE uniqueUserName (UserName),
	PRIMARY KEY (MaNV)
);

/* Table Name: GopY */
/* Field No: 5 */
/* GY_TM Field: Gop Y or Thac Mac */
/* Total Size: 191 Bytes */
	/* No. 2 */
CREATE TABLE GopY(
	MaGY		CHAR(5) 	 NOT NULL /*AUTO_INCREMENT*/,
	MaNV 		CHAR(9) 	 NOT NULL REFERENCES NhanVien,
	NoiDung	VARCHAR(100) NOT NULL,
	Ngay		DATE 		 NOT NULL,
	/* TraLoi	VARCHAR(50)  NULL, */
	/* TenFile	VARCHAR(20)  NULL, */
	PRIMARY KEY (MaGY)
);

/* Table Name: Groups */
/* Field No: 4 */
/* TrgGroup Field: Truong Group */
/* NgayNC Field: Ngay Nhan Chuc */
/* Total Size: 44 Bytes */
	/* No. 3 */
CREATE TABLE Groups(
	MaGroup	INT/*!(4)*/ NOT NULL /*!AUTO_INCREMENT*/,
	TenGroup	VARCHAR(30) NOT NULL,
	TrgGroup	CHAR(9) 	NOT NULL REFERENCES NhanVien,
	NgayNC	DATE 		NOT NULL,
	PRIMARY KEY (MaGroup)
);

/* Table Name: Permissions */
/* Field No: 4 */
/* Total Size: 104 Bytes */
	/* No. 4 */
CREATE TABLE Permissions(
	MaPer		INT/*!(4)*/ NOT NULL /*!AUTO_INCREMENT*/,
	TenPer	VARCHAR(50) NOT NULL,
	GhiChu	VARCHAR(80) NULL,
	PRIMARY KEY (MaPer)
);

/* Table Name: Groups_Per */
/* Field No: 2 */
/* Total Size: 8 Bytes */
	/* No. 5 */
CREATE TABLE Groups_Per(
	MaGroup	INT/*!(4)*/ NULL REFERENCES Groups,
	MaPer		INT/*!(4)*/ NULL REFERENCES Permissions
);

/* Create UNIQUE to replace for Primary Key*/
ALTER TABLE Groups_Per ADD UNIQUE uniqueGroups_Per (MaGroup, MaPer);

/* Table Name: DeAn */
/* Field No: 3 */
/* Total Size: 94 Bytes */
	/* No. 6 */
CREATE TABLE DeAn(
	MaDA		INT/*!(4)*/ NOT NULL /*!AUTO_INCREMENT*/,
	TenDA		VARCHAR(50) NOT NULL,
	DiaDiem	VARCHAR(40) NOT NULL,
	Ngay		DATE		NOT NULL,
	PRIMARY KEY (MaDA)
);

/* Table Name: XepLoai */
/* Field No: 6 */
/* Total Size: 86 Bytes */
	/* No. 7 */
CREATE TABLE XepLoai(
	MaXL		INT/*!(4)*/ NOT NULL /*!AUTO_INCREMENT*/,
	XepLoai	CHAR(2) 	NOT NULL,
	GhiChu	VARCHAR(80) NULL,
	PRIMARY KEY (MaXL)
);

/* Table Name: DanhGia */
/* Field No: 6 */
/* Total Size: 136 Bytes */
	/* No. 8 */
CREATE TABLE DanhGia(
	MaDG		INT/*!(4)*/ NOT NULL /*!AUTO_INCREMENT*/,
	MaXL		INT/*!(4)*/ NOT NULL REFERENCES XepLoai,
	PhanHoi	VARCHAR(50) NULL,
	ChuThich	VARCHAR(80) NULL,
	Ngay		DATE		NOT NULL,
	PRIMARY KEY (MaDG)
);

/* Table Name: Works */
/* Field No: 5 */
/* Total Size: 143 Bytes */
	/* No. 9 */
CREATE TABLE Works(
	MaCV		INT/*!(4)*/  NOT NULL /*!AUTO_INCREMENT*/,
	MaDA		INT/*!(4)*/  NOT NULL REFERENCES DeAn,
	MaDG		INT/*!(4)*/  NULL REFERENCES DanhGia,
	TenCV		VARCHAR(30)  NOT NULL,
	NoiDung	VARCHAR(100) NOT NULL,
	DaXong	TINYINT/*!(1)*/ NOT NULL DEFAULT 0,
	Ngay		DATE		NOT NULL,
	PRIMARY KEY (MaCV)
);

/* Table Name: PhanCong */
/* Field No: 3 */
/* Total Size: 19 Bytes */
	/* No. 10 */
CREATE TABLE PhanCong(
	MaCV		INT/*!(4)*/ NOT NULL REFERENCES CongViec,
	MaNV 		CHAR(9) 	NOT NULL REFERENCES NhanVien,
	NgayBD	Date 		NOT NULL,
	NgayKT	Date 		NULL,
	ThietLap	TINYINT/*!(1)*/ NOT NULL DEFAULT 0 /* If ThietLap equals 1 then NgayBD is replaced NgayTL, NgayKT equals null*/
);

/* Create UNIQUE to replace for Primary Key*/
ALTER TABLE PhanCong ADD UNIQUE uniquePhanCong (MaCV, MaNV);

/* Table Name: BaoCaoNgay */
/* Field No: 5 */
/* Total Size: 149 Bytes */
	/* No. 12 */
CREATE TABLE BaoCaoNgay(
	MaBCN		CHAR(5)	NOT NULL /*AUTO_INCREMENT*/,
	MaCV		INT/*!(4)*/ NOT NULL REFERENCES CongViec,
	TienDo	FLOAT 	NOT NULL,
	Ngay		DATE 		NOT NULL,
	DeXuat	VARCHAR(50) NULL,
	GhiChu	VARCHAR(80) NULL,
	PRIMARY KEY (MaBCN)
);

/* Table Name: BaoCaoTongHop */
/* Field No: 5 */
/* Total Size: 184 Bytes */
	/* No. 13 */
CREATE TABLE BaoCaoTongHop(
	MaBCTH	CHAR(5) 	NOT NULL /*AUTO_INCREMENT*/,
	MaCV		INT/*!(4)*/ NOT NULL REFERENCES CongViec,
	TonDong	FLOAT 	NOT NULL,
	Ngay		DATE 		NOT NULL,
	CVTuongLai	VARCHAR(80) NULL,
	DeXuat	VARCHAR(80) NULL,
	PRIMARY KEY (MaBCTH)
);

/* Table Name: Files */
/* Field No: 5 */
/* Total Size: 116 Bytes */
	/* No. 14 */
CREATE TABLE Files(
	MaFile	CHAR(12) 	NOT NULL, /* La ten file duoc ghi vao hard disk cua server */
	MaBC		CHAR(8)  	NOT NULL,
	TenFile	VARCHAR(40) NOT NULL,
	FileSize	INT/*!(4)*/ NOT NULL,
	ContentType	VARCHAR(30) NOT NULL,
	Ngay		DATE		NOT NULL,
	PRIMARY KEY (MaFile)
);