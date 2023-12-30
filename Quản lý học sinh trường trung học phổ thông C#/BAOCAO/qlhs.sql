# Host: localhost    Database: qlhs
# ------------------------------------------------------
# Server version 5.0
DROP DATABASE IF EXISTS `qlhs`;
CREATE DATABASE `qlhs` /*!40100 DEFAULT CHARACTER SET utf8 */;
USE `qlhs`;

CREATE TABLE `phan_quyen` (
  `ma_phan_quyen` char(6) NOT NULL default '' COMMENT 'Mã phân quyền',
  `ten_phan_quyen` varchar(100) NOT NULL default '' COMMENT 'Tên phân quyền',
  PRIMARY KEY  (`ma_phan_quyen`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COMMENT='Phân quyền';

CREATE TABLE `chi_tiet_phan_quyen` (
  `Id` int(11) NOT NULL auto_increment COMMENT 'Id chi tiết phân quyền',
  `ma_phan_quyen` char(6) NOT NULL default '' COMMENT 'Mã phân quyền',
  `quyen_them` bit(1) default '\0' COMMENT 'Quyền thêm mới',
  `quyen_xoa` bit(1) default '\0' COMMENT 'Quyền xóa',
  `quyen_sua` bit(1) default '\0' COMMENT 'Quyền sửa',
  PRIMARY KEY  (`Id`),
  KEY `fk_phan_quyen` (`ma_phan_quyen`),
  CONSTRAINT `fk_phan_quyen` FOREIGN KEY (`ma_phan_quyen`) REFERENCES `phan_quyen` (`ma_phan_quyen`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COMMENT='Chi tiết phân quyền';

CREATE TABLE `chuc_vu` (
  `id_chuc_vu` int(11) NOT NULL auto_increment COMMENT 'Id chức vụ',
  `ten_chuc_vu` varchar(100) NOT NULL default '' COMMENT 'Tên chức vụ',
  PRIMARY KEY  (`id_chuc_vu`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COMMENT='Chức vụ';

CREATE TABLE `nguoi_dung` (
  `ma_nguoi_dung` char(9) NOT NULL default '' COMMENT 'Mã người dùng',
  `ma_phan_quyen` char(6) NOT NULL default '' COMMENT 'Mã phân quyền',
  `ten_nguoi_dung` varchar(50) NOT NULL default '' COMMENT 'Tên người dùng',
  `ten_dang_nhap` varchar(50) NOT NULL default '' COMMENT 'Tên đăng nhập',
  `mat_khau` varchar(255) NOT NULL default '' COMMENT 'Mật khẩu',
  PRIMARY KEY  (`ma_nguoi_dung`),
  UNIQUE KEY `ten_dang_nhap` (`ten_dang_nhap`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COMMENT='Người dùng';

CREATE TABLE `dan_toc` (
  `ma_dan_toc` char(6) NOT NULL default '' COMMENT 'Mã dân tộc',
  `ten_dan_toc` varchar(100) NOT NULL default '' COMMENT 'Tên dân tộc',
  PRIMARY KEY  (`ma_dan_toc`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COMMENT='Dân tộc';

CREATE TABLE `ton_giao` (
  `ma_ton_giao` char(6) NOT NULL default '' COMMENT 'Mã tôn giáo',
  `ten_ton_giao` varchar(100) NOT NULL default '' COMMENT 'Tên tôn giáo',
  PRIMARY KEY  (`ma_ton_giao`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COMMENT='Tôn giáo';

CREATE TABLE `suc_khoe` (
  `Id` int(11) NOT NULL auto_increment COMMENT 'Id tình trạng sức khỏe',
  `tinh_trang_sk` varchar(255) NOT NULL default '' COMMENT 'Tên tình trạng sức khỏe',
  PRIMARY KEY  (`Id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COMMENT='Sức khỏe';

CREATE TABLE `tinh_thanh` (
  `ma_tinh_thanh` int(6) NOT NULL auto_increment COMMENT 'Mã tỉnh thành',
  `ten_tinh_thanh` varchar(100) NOT NULL default '' COMMENT 'Tên tỉnh thành',
  PRIMARY KEY  (`ma_tinh_thanh`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COMMENT='Tỉnh thành phố';

CREATE TABLE `quan_huyen` (
  `ma_quan_huyen` int(6) NOT NULL auto_increment COMMENT 'Mã quận huyện',
  `ten_quan_huyen` varchar(255) NOT NULL default '' COMMENT 'Tên quận huyện',
  `ma_tinh_thanh` int(6) NOT NULL default '0' COMMENT 'Mã tỉnh thành',
  PRIMARY KEY  (`ma_quan_huyen`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COMMENT='Quận huyện';

CREATE TABLE `xa_phuong` (
  `ma_xa_phuong` int(11) NOT NULL auto_increment COMMENT 'Mã xã phường',
  `ten_xa_phuong` varchar(255) NOT NULL default '' COMMENT 'Tên xã phường',
  `ma_quan_huyen` int(6) NOT NULL default '0' COMMENT 'Mã quận huyện',
  PRIMARY KEY  (`ma_xa_phuong`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COMMENT='Xã phường';

CREATE TABLE `thong_tin_truong_hoc` (
  `ten_so_gddt` varchar(255) default '' COMMENT 'Tên Sở GDĐT',
  `ten_phong_gddt` varchar(255) default NULL COMMENT 'Tên Phòng GDĐT',
  `ten_truong` text NOT NULL COMMENT 'Tên trường',
  `thuoc_he` varchar(255) NOT NULL default '' COMMENT 'Thuộc Hệ',
  `dia_chi` text COMMENT 'Địa chỉ',
  `ma_xa_phuong` int(11) default NULL COMMENT 'Mã xã phường',
  `so_dien_thoai` varchar(20) default NULL COMMENT 'Số điện thoại',
  `fax` varchar(255) default NULL COMMENT 'Fax',
  `website` varchar(255) default NULL COMMENT 'Website',
  `email` varchar(255) default NULL COMMENT 'Email',
  `hieu_truong` varchar(255) default NULL COMMENT 'Hiệu trưởng'
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COMMENT='Thông tin trường học';


CREATE TABLE `khoi_lop` (
  `ma_khoi_lop` int(11) NOT NULL auto_increment COMMENT 'Mã khối lớp',
  `ten_khoi_lop` varchar(50) NOT NULL default '' COMMENT 'Tên khối lớp',
  `mo_ta` varchar(255) default NULL COMMENT 'Mô tả',
  PRIMARY KEY  (`ma_khoi_lop`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COMMENT='Khối lớp';

CREATE TABLE `kieu_lop` (
  `ma_kieu_lop` int(11) NOT NULL auto_increment COMMENT 'Mã kiểu lớp',
  `ten_kieu_lop` varchar(50) NOT NULL default '' COMMENT 'Tên kiểu lớp',
  PRIMARY KEY  (`ma_kieu_lop`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COMMENT='Kiểu lớp';

CREATE TABLE `phong_hoc` (
  `ma_phong_hoc` int(11) NOT NULL auto_increment COMMENT 'Mã phòng học',
  `ten_phong_hoc` varchar(50) NOT NULL default '' COMMENT 'Tên phòng học',
  `vi_tri` varchar(255) default NULL COMMENT 'Vị trí phòng học',
  PRIMARY KEY  (`ma_phong_hoc`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COMMENT='Phòng học';

CREATE TABLE `ca_hoc` (
  `ma_ca_hoc` tinyint(3) NOT NULL auto_increment COMMENT 'Ca học',
  `ten_ca_hoc` varchar(50) NOT NULL default '' COMMENT 'Tên ca học',
  `mo_ta` text COMMENT 'Mô tả',
  PRIMARY KEY  (`ma_ca_hoc`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COMMENT='Ca học';


CREATE TABLE `he_dao_tao` (
  `ma_he_dao_tao` char(6) NOT NULL default '' COMMENT 'Mã hệ đào tạo',
  `ten_he_dao_tao` varchar(255) NOT NULL default '' COMMENT 'Tên hệ đào tạo',
  PRIMARY KEY  (`ma_he_dao_tao`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COMMENT='Hệ đào tạo';

CREATE TABLE `lop` (
  `ma_lop` char(9) NOT NULL default '' COMMENT 'Mã lớp học',
  `ten_lop` varchar(50) NOT NULL default '' COMMENT 'Tên lớp',
  `ma_giao_vien_cn` char(9) NOT NULL default '' COMMENT 'Mã giáo viên chủ nhiệm',
  `ma_khoi_lop` int(11) NOT NULL default '0' COMMENT 'Mã khối lớp',
  `ma_kieu_lop` int(11) NOT NULL default '0' COMMENT 'Mã kiểu lớp',
  `ma_phong_hoc` int(11) NOT NULL default '0' COMMENT 'Mã phòng học',
  `ma_ca_hoc` tinyint(3) NOT NULL default '0' COMMENT 'Mã ca học',
  `ma_he_dao_tao` char(6) NOT NULL default '' COMMENT 'Mã hệ đào tạo',
  `ma_tcplhl` char(6) NOT NULL default '' COMMENT 'Mã tiêu chuẩn phân loại học lực',
  `ma_tcdhtd` char(6) NOT NULL default '' COMMENT 'Mã tiêu chuẩn danh hiệu thi đua',
  PRIMARY KEY  (`ma_lop`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COMMENT='Lớp học';


CREATE TABLE `mon_hoc` (
  `ma_mon_hoc` varchar(9) NOT NULL default '' COMMENT 'Mã môn học',
  `ten_mon_hoc` varchar(50) NOT NULL default '' COMMENT 'Tên môn học',
  `kieu_danh_gia` varchar(50) NOT NULL default '' COMMENT 'Kiểu đánh giá',
  `mo_ta` text COMMENT 'Mô tả',
  PRIMARY KEY  (`ma_mon_hoc`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COMMENT='Môn học';

CREATE TABLE `nien_hoc` (
  `ma_nien_hoc` char(6) NOT NULL default '' COMMENT 'Mã niên học',
  `ten_nien_hoc` varchar(20) NOT NULL default '' COMMENT 'Tên niên học',
  `tg_bat_dau` date default NULL COMMENT 'Thời gian bắt đầu niên học',
  `tg_ket_thuc` date default NULL COMMENT 'Thời gian kết thúc niên học',
  PRIMARY KEY  (`ma_nien_hoc`),
  UNIQUE KEY `ten_nien_hoc` (`ten_nien_hoc`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COMMENT='Niên học';

CREATE TABLE `hoc_ky` (
  `ma_hoc_ky` tinyint(3) NOT NULL auto_increment COMMENT 'Mã học kỳ',
  `ten_hoc_ky` varchar(50) NOT NULL default '' COMMENT 'Tên học kỳ',
  `tg_bat_dau` date default NULL COMMENT 'Thời gian bắt đầu học kỳ',
  `tg_ket_thuc` date default NULL COMMENT 'Thời gian kết thúc học kỳ',
  `ma_nien_hoc` char(6) NOT NULL default '' COMMENT 'Mã niên học',
  PRIMARY KEY  (`ma_hoc_ky`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COMMENT='Học kỳ';

CREATE TABLE `quan_he` (
  `ma_quan_he` tinyint(3) NOT NULL auto_increment COMMENT 'Mã quan hệ thân nhân',
  `ten_quan_he` varchar(255) NOT NULL default '' COMMENT 'Tên quan hệ thân nhân',
  PRIMARY KEY  (`ma_quan_he`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COMMENT='Quan hệ thân nhân';

CREATE TABLE `nghe_nghiep` (
  `ma_nghe_nghiep` tinyint(3) NOT NULL auto_increment COMMENT 'Mã nghề nghiệp',
  `ten_nghe_nghiep` varchar(255) NOT NULL default '' COMMENT 'Tên nghề nghiệp',
  PRIMARY KEY  (`ma_nghe_nghiep`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COMMENT='Nghề nghiệp';

CREATE TABLE `than_nhan` (
  `ma_than_nhan` char(9) NOT NULL default '' COMMENT 'Mã thân nhân',
  `ten_than_nhan` varchar(50) NOT NULL default '' COMMENT 'Tên thân nhân',
  `nam_sinh` date default NULL COMMENT 'Năm sinh',
  `dia_chi` text COMMENT 'Địa chỉ',
  `dien_thoai` varchar(20) default NULL COMMENT 'Điện thoại',
  `ma_nghe_nghiep` tinyint(3) default NULL COMMENT 'Mã nghề nghiệp',
  `ma_quan_he` tinyint(3) NOT NULL default '0' COMMENT 'Mã quan hệ',
  PRIMARY KEY  (`ma_than_nhan`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COMMENT='Thân nhân';

CREATE TABLE `trang_thai_hoc_sinh` (
  `id_trang_thai` tinyint(3) NOT NULL auto_increment COMMENT 'Id trạng thái học sinh',
  `ten_trang_thai` varchar(100) NOT NULL default '' COMMENT 'Tên trạng thái <Đang học/Thôi học/Lưu ban>',
  PRIMARY KEY  (`id_trang_thai`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COMMENT='Trạng thái học sinh';

CREATE TABLE `hinh_anh` (
  `id_hinh_anh` int(11) unsigned NOT NULL auto_increment COMMENT 'Id hình ảnh',
  `ten_hinh_anh` varchar(255) NOT NULL default '' COMMENT 'Tên hình ảnh',
  `kich_thuoc_hinh_anh` int(11) unsigned NOT NULL default '0' COMMENT 'Kích thước hình ảnh',
  `du_lieu_hinh_anh` mediumblob NOT NULL COMMENT 'Dữ liệu hình ảnh',
  PRIMARY KEY  (`id_hinh_anh`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COMMENT='Hình ảnh';


	/* Table Hoc sinh */

CREATE TABLE `hoc_sinh` (
  `ma_hoc_sinh` char(12) NOT NULL default '' COMMENT 'Mã học sinh',
  `ho_lot` varchar(50) NOT NULL default '' COMMENT 'Họ và tên lót',
  `ten` varchar(21) NOT NULL default '' COMMENT 'Tên học sinh',
  `anh_hoc_sinh` int(11) unsigned default '0' COMMENT 'Id Ảnh học sinh',
  `nam_sinh` date NOT NULL default '1990-01-01' COMMENT 'Ngày tháng năm sinh',
  `ten_thuong_goi` varchar(100) default NULL COMMENT 'Tên thường gọi',
  `noi_sinh` text NOT NULL COMMENT 'Nơi sinh',
  `ma_dan_toc` char(6) NOT NULL default '' COMMENT 'Mã dân tộc',
  `ma_ton_giao` char(6) NOT NULL default '' COMMENT 'Mã tôn giáo',
  `ma_tinh_trang_suc_khoe` int(11) NOT NULL default '0' COMMENT 'Mã tình trạng sức khỏe',
  `gioi_tinh` bit(1) NOT NULL default '\0' COMMENT 'Giới tính',
  `dia_chi_thuong_tru` text NOT NULL COMMENT 'Địa chỉ thường trú',
  `dia_chi_tam_tru` text COMMENT 'Địa chỉ tạm trú',
  `dien_uu_tien` varchar(255) default NULL COMMENT 'Diện ưu tiên',
  `ma_trang_thai_hoc_sinh` tinyint(3) NOT NULL default '0' COMMENT 'Mã trạng thái học sinh',
  `email` varchar(50) default NULL COMMENT 'Email',
  `dien_thoai` varchar(20) default NULL COMMENT 'Điện thoại',
  `thong_tin_cha` char(9) NOT NULL default '' COMMENT 'Thông tin về Cha của học sinh <Mã thân nhân>',
  `thong_tin_me` char(9) NOT NULL default '' COMMENT 'Thông tin về Mẹ của học sinh <Mã thân nhân>',
  `ngay_vao_truong` date default NULL COMMENT 'Ngày vào trường',
  `ngay_ra_truong` date default NULL COMMENT 'Ngày ra trường',
  `doi_vien` bit(1) default NULL COMMENT 'Đội viên',
  `doan_vien` bit(1) default NULL COMMENT 'Đoàn viên',
  `dang_vien` bit(1) default NULL COMMENT 'Đảng viên',
  `cam_tinh_dang` bit(1) default NULL COMMENT 'Đối tượng cảm tình Đảng',
  PRIMARY KEY  (`ma_hoc_sinh`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COMMENT='Học sinh';

CREATE TABLE `trinh_do_giao_vien` (
  `ma_trinh_do` tinyint(3) NOT NULL auto_increment COMMENT 'Mã trình độ',
  `ten_trinh_do` varchar(255) NOT NULL default '' COMMENT 'Tên trình độ',
  PRIMARY KEY  (`ma_trinh_do`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COMMENT='Trình độ giáo viên';

CREATE TABLE `chuyen_mon_giao_vien` (
  `ma_chuyen_mon` tinyint(3) NOT NULL auto_increment COMMENT 'Mã chuyên môn',
  `ten_chuyen_mon` varchar(255) NOT NULL default '' COMMENT 'Tên chuyên môn',
  PRIMARY KEY  (`ma_chuyen_mon`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COMMENT='Chuyên môn giáo viên';

CREATE TABLE `trang_thai_cong_tac` (
  `ma_trang_thai_cong_tac` tinyint(3) NOT NULL auto_increment COMMENT 'Mã trạng thái công tác',
  `ten_trang_thai_cong_tac` varchar(255) NOT NULL default '' COMMENT 'Tên trạng thái công tác',
  PRIMARY KEY  (`ma_trang_thai_cong_tac`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COMMENT='Trạng thái công tác của giáo viên';

	/* Table giao vien */
CREATE TABLE `giao_vien` (
  `ma_giao_vien` char(9) NOT NULL default '' COMMENT 'Mã giáo viên',
  `ho_ten_giao_vien` varchar(100) NOT NULL default '' COMMENT 'Họ và tên giáo viên',
  `bi_danh` varchar(100) default NULL COMMENT 'Bí danh',
  `ten_thuong_goi` varchar(100) default NULL COMMENT 'Tên thường gọi',
  `anh_giao_vien` mediumblob COMMENT 'Ảnh giáo viên',
  `nam_sinh` date NOT NULL default '1989-01-01' COMMENT 'Năm sinh',
  `ma_dan_toc` char(6) NOT NULL default '' COMMENT 'Mã dân tộc',
  `ma_ton_giao` char(6) NOT NULL default '' COMMENT 'Mã tôn giáo',
  `gioi_tinh` bit(1) NOT NULL default '\0',
  `so_cmnd` char(9) NOT NULL default '' COMMENT 'Số CMND',
  `ngay_cap_cmnd` date default NULL COMMENT 'Ngày cấp giấy CMND',
  `noi_cap_cmnd` varchar(255) default NULL COMMENT 'Nơi cấp giấy CMND',
  `ngoai_ngu` varchar(255) default NULL COMMENT 'Ngoại ngữ',
  `ma_chuc_vu` int(11) NOT NULL default '0' COMMENT 'Mã chức vụ',
  `ma_trinh_do` tinyint(3) NOT NULL default '0' COMMENT 'Mã trình độ',
  `he_dao_tao` varchar(255) default NULL COMMENT 'Hệ đào tạo <Đại học/Cao đẳng>',
  `ngay_vao_doan` date default NULL COMMENT 'Ngày vào Đoàn',
  `noi_ket_nap_doan` varchar(255) default NULL COMMENT 'Nơi kết nạp Đoàn',
  `ngay_vao_dang` date default NULL COMMENT 'Ngày vào Đảng',
  `noi_ket_nap_dang` varchar(255) default NULL COMMENT 'Nơi kết nạp Đảng',
  `dia_chi` text NOT NULL COMMENT 'Địa chỉ',
  `dien_thoai` varchar(50) default NULL COMMENT 'Điện thoại',
  `email` varchar(50) default NULL COMMENT 'Email',
  `ma_chuyen_mon` tinyint(3) NOT NULL default '0' COMMENT 'Mã chuyên môn',
  `trang_thai_cong_tac` tinyint(3) NOT NULL default '0' COMMENT 'Trạng thái công tác <hợp đồng/biên chế>',
  `ho_ten_cha` varchar(50) NOT NULL default '' COMMENT 'Họ tên Cha của giáo viên',
  `ho_ten_me` varchar(50) NOT NULL default '' COMMENT 'Họ tên mẹ của giáo viên',
  PRIMARY KEY  (`ma_giao_vien`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COMMENT='Giáo viên';


CREATE TABLE `to_chuyen_mon` (
  `ma_to_chuyen_mon` char(6) NOT NULL default '' COMMENT 'Mã tổ chuyên môn',
  `ten_to_chuyen_mon` varchar(100) NOT NULL default '' COMMENT 'Tên tổ chuyên môn',
  `mo_ta` text COMMENT 'Mô tả',
  PRIMARY KEY  (`ma_to_chuyen_mon`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COMMENT='Tổ chuyên môn';

CREATE TABLE `vung_diem` (
  `id` tinyint(3) NOT NULL auto_increment COMMENT 'Id vùng điểm',
  `ten_vung_diem` varchar(100) NOT NULL default '' COMMENT 'Tên vùng điểm',
  `diem_can_tren` decimal(2,1) unsigned NOT NULL default '0.0' COMMENT 'Điểm cận trên',
  `diem_can_duoi` decimal(2,1) unsigned NOT NULL default '0.0' COMMENT 'Điểm cận dưới',
  PRIMARY KEY  (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COMMENT='Vùng điểm';

CREATE TABLE `loai_diem` (
  `ma_loai_diem` char(6) NOT NULL default '' COMMENT 'Mã loại điểm',
  `ten_loai_diem` varchar(50) NOT NULL default '' COMMENT 'Tên loại điểm',
  `gia_tri_min` int(11) unsigned NOT NULL default '0' COMMENT 'Giá trị điểm nhỏ nhất',
  `gia_tri_max` int(11) unsigned NOT NULL default '10' COMMENT 'Giá trị điểm lớn nhất',
  `so_luong_diem_min` int(11) unsigned NOT NULL default '0' COMMENT 'Số lượng điểm tối thiểu',
  `so_luong_diem_max` int(11) unsigned NOT NULL default '0' COMMENT 'Số lượng điểm tối đa',
  `he_so_tbkt` int(11) unsigned NOT NULL default '0' COMMENT 'Hệ số tham gia tính điểm TBKT',
  `kieu_diem` varchar(21) NOT NULL default '' COMMENT 'Kiểu điểm <nguyên/thập phân>',
  `so_chu_so_thap_phan` int(11) unsigned default NULL COMMENT 'Số chữ số thập phân cho giá trị điểm thập phân',
  PRIMARY KEY  (`ma_loai_diem`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COMMENT='Loại điểm';

CREATE TABLE `tieu_chuan_dhtd` (
  `ma_tcdhtd` char(6) NOT NULL default '' COMMENT 'Mã Tiêu chuẩn DHTD',
  `ten_tcdhtd` varchar(50) NOT NULL default '' COMMENT 'Tên Tiêu chuẩn Danh hiệu thi đua',
  PRIMARY KEY  (`ma_tcdhtd`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COMMENT='Tiêu chuẩn Danh hiệu thi đua';

CREATE TABLE `danh_hieu_thi_dua` (
  `ma_dhtd` char(6) NOT NULL default '' COMMENT 'Mã DHTĐ',
  `ten_dhtd` varchar(50) NOT NULL default '' COMMENT 'Tên DHTĐ',
  `ma_tcdhtd` char(6) NOT NULL default '' COMMENT 'Mã Tiêu chuẩn DHTĐ',
  `hoc_luc` varchar(50) NOT NULL default '' COMMENT 'Điều kiện học lực',
  `hanh_kiem` varchar(50) NOT NULL default '' COMMENT 'Điều kiện hạnh kiểm',
  PRIMARY KEY  (`ma_dhtd`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COMMENT='Danh hiệu thi đua';

CREATE TABLE `nhan_xet_hanh_kiem` (
  `Id` int(11) unsigned NOT NULL auto_increment COMMENT 'Id Tiêu chí',
  `ten_tieu_chi` varchar(50) NOT NULL default '' COMMENT 'Tên tiêu chí',
  `yeu_cau` text NOT NULL COMMENT 'Yêu cầu',
  `bieu_hien` text COMMENT 'Biểu hiện',
  PRIMARY KEY  (`Id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COMMENT='Tiêu chí nhận xét hạnh kiểm (đv HS Tiểu học)';

CREATE TABLE `tieu_chuan_plhl` (
  `ma_tcplhl` char(6) NOT NULL default '' COMMENT 'Mã tiêu chuẩn PLHL',
  `ten_tcplhl` varchar(255) NOT NULL default '' COMMENT 'Tên tiêu chuẩn PLHL',
  `ma_he_dao_tao` char(6) NOT NULL default '' COMMENT 'Mã hệ đào tạo',
  PRIMARY KEY  (`ma_tcplhl`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COMMENT='Tiêu chuẩn Phân loại học lực';

CREATE TABLE `phan_loai_hoc_luc` (
  `ma_hoc_luc` char(6) NOT NULL default '' COMMENT 'Mã học lực',
  `ten_hoc_luc` varchar(50) NOT NULL default '' COMMENT 'Tên học lực',
  `ma_tcplhl` char(6) NOT NULL default '' COMMENT 'Mã Tc PLHL',
  `dtb_cac_mon` int(10) unsigned NOT NULL default '0' COMMENT 'Giá trị tối thiểu Điểm TB các môn',
  `diem_khong` int(11) unsigned NOT NULL default '0' COMMENT 'Điểm khống',
  `diem_mon_chuyen` int(11) unsigned NOT NULL default '0' COMMENT 'Giá trị điểm tối thiểu của môn chuyên',
  `tuy_chon` bit(1) NOT NULL default '\0' COMMENT 'Đồng thời/Một trong số các môn chuyên thỏa',
  PRIMARY KEY  (`ma_hoc_luc`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COMMENT='Phân loại học lực';

CREATE TABLE `phan_cong_giang_day_theo_giao_vien` (
  `ma_pcgd_gv` char(9) NOT NULL default '' COMMENT 'Mã phân công giảng dạy',
  `ma_nien_hoc` char(6) NOT NULL default '' COMMENT 'Mã niên học',
  `ma_giao_vien` char(9) NOT NULL default '' COMMENT 'Mã giáo viên',
  PRIMARY KEY  (`ma_pcgd_gv`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COMMENT='Phân công giảng dạy theo Giáo viên';

CREATE TABLE `chi_tiet_pcgd_gv` (
  `id` int(11) unsigned NOT NULL auto_increment COMMENT 'Id chi tiết phân công giảng dạy',
  `ma_pcgd_gv` char(9) NOT NULL default '' COMMENT 'Mã phân công giảng dạy theo giáo viên',
  `ma_mon_hoc` char(9) NOT NULL default '' COMMENT 'Mã môn học',
  `danh_sach_ma_lop` text COMMENT 'Danh sách các lớp mà giáo viên giảng dạy',
  PRIMARY KEY  (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COMMENT='Chi tiết phân công giảng dạy theo Giáo viên';

CREATE TABLE `phan_cong_giang_day_theo_lop` (
  `ma_pcgd_lop` char(9) NOT NULL default '' COMMENT 'Mã phân công giảng dạy theo Lớp',
  `ma_nien_hoc` char(6) NOT NULL default '' COMMENT 'Mã niên học',
  `ma_lop` char(9) NOT NULL default '' COMMENT 'Mã lớp học',
  PRIMARY KEY  (`ma_pcgd_lop`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COMMENT='Phân công giảng dạy theo lớp';

CREATE TABLE `chi_tiet_pcgd_lop` (
  `id` int(11) unsigned NOT NULL auto_increment COMMENT 'Id chi tiết phân công giảng dạy',
  `ma_pcgd_lop` char(9) NOT NULL default '' COMMENT 'Mã phân công giảng dạy theo lớp',
  `ma_mon_hoc` char(9) NOT NULL default '' COMMENT 'Mã môn học',
  `ma_giao_vien` char(9) NOT NULL default '' COMMENT 'Mã giáo viên',
  PRIMARY KEY  (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COMMENT='Chi tiết phân công giảng dạy theo lớp';

	/* Cong viec quan trong */
	
CREATE TABLE `thoi_gian_hoc` (
  `Id` tinyint(1) unsigned NOT NULL auto_increment,
  `ten_thoi_gian_hoc` varchar(255) NOT NULL default '' COMMENT 'Tên thời gian học một môn ở 1 lớp',
  PRIMARY KEY  (`Id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COMMENT='Thời gian học đv môn-lớp';

CREATE TABLE `phan_cong_mon_lop` (
  `ma_phan_cong_mon_lop` char(6) NOT NULL default '' COMMENT 'Mã phân công môn lớp',
  `ma_nien_hoc` char(6) NOT NULL default '' COMMENT 'Mã niên học',
  `ma_lop` char(9) NOT NULL default '' COMMENT 'Mã lớp học',
  PRIMARY KEY  (`ma_phan_cong_mon_lop`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COMMENT='Phân công môn-lớp';

CREATE TABLE `chi_tiet_phan_cong_mon_lop` (
  `id` int(11) unsigned NOT NULL auto_increment COMMENT 'Id chi tiết phân công môn-lớp',
  `ma_phan_cong_mon_lop` char(6) NOT NULL default '' COMMENT 'Mã phân công môn-lớp',
  `ma_mon_hoc` char(9) NOT NULL default '' COMMENT 'Mã lớp học',
  `mon_chuyen` bit(1) NOT NULL default '\0' COMMENT 'Có phải Môn chuyên hay không',
  `he_so_tb_mon` tinyint(3) unsigned NOT NULL default '0' COMMENT 'Dùng để tính TB các môn',
  `thoi_gian_hoc` tinyint(1) unsigned NOT NULL default '0' COMMENT 'Mã thời gian học <1 học kỳ/cả năm>',
  `he_so_tb_hk1` tinyint(3) unsigned NOT NULL default '1' COMMENT 'Dùng để tính TB môn cả năm',
  `he_so_tb_hk2` tinyint(3) unsigned NOT NULL default '0' COMMENT 'Dùng để tính TB môn cả năm',
  PRIMARY KEY  (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COMMENT='Chi tiết phân công môn-lớp';


