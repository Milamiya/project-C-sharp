using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using QUANLYHOSONHANVIEN.Controller;
using QUANLYHOSONHANVIEN.DataLayer;
using QUANLYHOSONHANVIEN.GiaoDien;

namespace QUANLYHOSONHANVIEN.GiaoDien
{
    public partial class frmThongTinNhanSu : DevComponents .DotNetBar.Office2007Form
    {
        public frmThongTinNhanSu()
        {
            InitializeComponent();
        }        

        ThongTinNhanSuCtr ctr = new ThongTinNhanSuCtr();
        ThongTinNhanSuData data = new ThongTinNhanSuData();
        GhiChucCtr ctr_ghichu = new GhiChucCtr();
        GhichuData data_ghichu = new GhichuData();

        PhongBanCtr ctr_phongban = new PhongBanCtr();
        ChucVuCtr ctr_chucvu = new ChucVuCtr();
        TrinhDoTinHocCtr ctr_trinhdotinhoc = new TrinhDoTinHocCtr();
        QuaTrinhCongTacNNData data_quatrinhcongtacnn = new QuaTrinhCongTacNNData();
        QuaTrinhCongTacNNCtr ctr_quatrinhcongtacnn = new QuaTrinhCongTacNNCtr();

        QuaTrinhCongTacCtr ctr_quatrinhct = new QuaTrinhCongTacCtr();
        QuaTrinhCongTacData data_quatrinhct = new QuaTrinhCongTacData();

        QuaTrinhDaoTaoCtr ctr_quatrinhdaotao=new QuaTrinhDaoTaoCtr() ;
        QuaTrinhDaoTaoData data_quatrinhdaotao = new QuaTrinhDaoTaoData();
        NganhHocCtr ctr_nganhhoc = new NganhHocCtr();
        ChuyenNganhCtr ctr_chuyennganh = new ChuyenNganhCtr();

        QuaTrinhKhenThuongCtr ctr_quatrinhkhenthuong = new QuaTrinhKhenThuongCtr();
        QuaTrinhKhenThuongData data_quatrinhkhenthuong = new QuaTrinhKhenThuongData();

        QuaTrinhKyLuatCtr ctr_quatrinhkyluat = new QuaTrinhKyLuatCtr();
        QuaTrinhKyLuatData data_quatrinhkyluat = new QuaTrinhKyLuatData();
        HinhThucKyLuatCtr ctr_hinhthuckyluat = new HinhThucKyLuatCtr();

        QuaTrinhBoiDuongCtr ctr_quatrinhboiduong = new QuaTrinhBoiDuongCtr();
        QuaTrinhBoiDuongData data_quatrinhboiduong = new QuaTrinhBoiDuongData();

        ChuyenMonCtr ctr_chuyenmon = new ChuyenMonCtr();
        ChuyenMonData data_chuyenmon = new ChuyenMonData();

        ThamGiaDaoTaoCtr ctr_thamgiadaotao = new ThamGiaDaoTaoCtr();
        ThamGiaDaoTaoData data_thamgiadaotao = new ThamGiaDaoTaoData();
        DotDaoTaoCtr ctr_dotdaotao = new DotDaoTaoCtr();

        QuanHeGiaDinhCtr ctr_quanhegiadinh = new QuanHeGiaDinhCtr();
        QuanHeGiaDinhData data_quanhegiadinh = new QuanHeGiaDinhData();

        ThanNhanNuocNgoaiCtr ctr_thannhannuocngoai = new ThanNhanNuocNgoaiCtr();
        ThanNhanNuocNgoaiData data_thanhnhannuocngoai = new ThanNhanNuocNgoaiData();

        DanhSachNgheNghiepCtr ctr_dsnghenghiep = new DanhSachNgheNghiepCtr();
        DanhSachNgheNghiepData data_dsnghenghiep = new DanhSachNgheNghiepData();
        NgheNghiepCtr ctr_nghenghiep = new NgheNghiepCtr();

        DanhSachNgoaiNguCtr ctr_dsngoaingu = new DanhSachNgoaiNguCtr();
        DanhSachNgoaiNguData data_dsngoaingu = new DanhSachNgoaiNguData();
        NgoaiNguCtr ctr_ngoaingu = new NgoaiNguCtr();

        QuaTrinhHopDongCtr ctr_qthopdong = new QuaTrinhHopDongCtr();
        QuaTrinhHopDongData data_qthopdong = new QuaTrinhHopDongData();

        DanhGiaCtr ctr_danhgia = new DanhGiaCtr();
        DanhGiaData data_danhgia = new DanhGiaData();
        DotDanhGiaCtr ctr_dotdanhgia = new DotDanhGiaCtr();

        PhongBanDaLamViecCtr ctr_pbdlv = new PhongBanDaLamViecCtr();
        PhongBanDaLamViecData data_pbdlv = new PhongBanDaLamViecData();

        QuaTrinhCongViecCtr ctr_qtcongviec = new QuaTrinhCongViecCtr();
        QuaTrinhCongViecData data_qtcongviec = new QuaTrinhCongViecData();
        CongViecCtr ctr_congviec = new CongViecCtr();

        private void frmThongTinNhanSu_Load(object sender, EventArgs e)
        {
            DataService.OpenConnection();

            loadData();            
            comboBoxExFirst.SelectedIndexChanged += new EventHandler(comboBoxExFirst_SelectedIndexChanged);
            comboBoxExPhongBan.SelectedIndexChanged += new EventHandler(comboBoxExPhongBan_SelectedIndexChanged);
        }

        void comboBoxExFirst_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxExFirst.SelectedValue != null)
            {
                if (comboBoxExFirst.SelectedValue.ToString() != "NVLV")
                {
                    //MessageBox.Show(comboBoxExFirst.SelectedValue.ToString());
                    ctr.HienthiDataGridviewNhanVienTheoPhong(dataGridViewX1, "%", "false");
                }
                else
                {
                    //MessageBox.Show(comboBoxExFirst.SelectedValue.ToString());
                    ctr.HienthiDataGridviewNhanVienTheoPhong(dataGridViewX1, "%", "true");
                }
            }
        }
        void comboBoxExPhongBan_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxExPhongBan.SelectedValue != null)
            {
                if (comboBoxExFirst.SelectedValue.ToString() != "NVLV")
                {
                    ctr.HienthiDataGridviewNhanVienTheoPhong(dataGridViewX1, comboBoxExPhongBan.SelectedValue.ToString(), "FALSE");
                }
                else
                {
                    ctr.HienthiDataGridviewNhanVienTheoPhong(dataGridViewX1, comboBoxExPhongBan.SelectedValue.ToString(), "true");
                }
            }
        }
        NguoiDungData data_nguoidung = new NguoiDungData();
        private void loadData()
        {
            btnThemMoi.Enabled = false;
            ctr.HienThiPhongBanComBoBox(comboBoxExPhongBan);
            data_nguoidung.HienThiX(comboBoxExFirst);            

            ctr_phongban.HienThiAutoCombobox(cmbPhongBan);
            ctr_chucvu.HienThiAutoCombobox(cmbChucVu);
            ctr_trinhdotinhoc.HienthinvCombobox(cmbNvphutrach);
            ctr_trinhdotinhoc.HienThiAutoCombobox(cmbTrinhdotinhoc);


            comboBoxExFirst.SelectedValue = "NVLV";
            comboBoxExPhongBan.SelectedValue = "%";
            //MessageBox.Show(comboBoxExPhongBan.SelectedValue.ToString ());
            ctr.HienthiDataGridviewNhanVienTheoPhong(dataGridViewX1, comboBoxExPhongBan.SelectedValue.ToString(),"TRUE");
            
            //ghi chu
            loadGhiChu();
            
            //qua trinh cong tac nuoc ngoai
            loadQuatrinhCongTacNuocNgoai();
            
            //QUÁ TRINH CONG TAC
            loadQuatrinhCongTac();

            //QUÁ TRÌNH ĐÀO TẠO
            loadQuaTrinhDaoTao();

            //QUÁ TRÌNH KHEN THƯỞNG
            loadQuaTrinhKhenThuong();

            ////QUÁ TRÌNH KỶ LUẬT
            loadQuaTrinhKyLuat();

            //QUA TRINH BOI DUONG
            loadQuaTrinhBoiDuong();

            //CHUYEN MÔN
            loadChuyenMon();

            //THAM GIA ĐÀO TẠO
            loadThamGiaDaoTao();

            //QUAN HE GIA DINH
            loadQuanHeGiaDinh();

            //THAN NHAN NUOC NGOAI
            loadThanNhanNuocNgoai();

            //DANH SACH NGHE nghiep
            loadDanhSachNgheNghiep();

            //DANH SACH NGOAI NGU
            loadDanhSachNgoaiNgu();

            //QUA TRINH HOP DONG
            loadQuaTrinhHopDong();

            //DANH SACH DANH GIA
            loadDanhSachDanhGia();

            //DANH SACH PHONG BAN DA LAM VIEC
            loadPhongBanDaLamViec();

            //DANH SACH CONG VIEC
            loadQuaTrinhCongViec();
            
        }

        private void loadQuaTrinhCongViec()
        {
            ctr_congviec.HienThiAutoCombobox(cmbTencongviecQTCV);
            ctr_congviec.HienThiDataGridViewCombobox(colTencongviecqtcv);            

            ctr_qtcongviec.HienthiQuaTrinhCONGVIECGridview(dataGridViewQTCongViec, txtManv.Text);
            btnThemmoiQTCV.Enabled = false;
            if (dataGridViewQTCongViec.Rows.Count == 0)
            {
                btnCapnhatQTCV.Enabled = false;
                btnXoaQTCV.Enabled = false;
            }
            else
            {
                btnCapnhatQTCV.Enabled = true;
                btnXoaQTCV.Enabled = true;
            }
        }

        private void loadPhongBanDaLamViec()
        {
            ctr_pbdlv.HienThiAutoCombobox1(cmbPhongbanDalamviec);
            ctr_pbdlv.HienthiDataGridViewComboBoxColumn1(colphongbanPBDLV);
            ctr_pbdlv.HienThiAutoCombobox2(cmbChucdanhPBDLV);
            ctr_pbdlv.HienthiDataGridViewComboBoxColumn2(colChucdanhPBDLV);

            ctr_pbdlv.HienthiPHONGBANDALAMVIECDataGridview(dataGridViewPBDLV, txtManv.Text);
            btnThemmoiPBDLV.Enabled = false;
            if (dataGridViewPBDLV.Rows.Count == 0)
            {
                btnCapnhatPBDLV.Enabled = false;
                btnXoaPBDLV.Enabled = false;
            }
            else
            {
                btnCapnhatPBDLV.Enabled = true;
                btnXoaPBDLV.Enabled = true;
            }
        }

        private void loadDanhSachDanhGia()
        {
            ctr_dotdanhgia.HienThiAutoCombobox(cmbDotdanhgiadg);
            ctr_dotdanhgia.HienthiDataGridViewComboBoxColumn(colDotdgdg);

            ctr_danhgia.HienthiDANHGIADataGridview(dataGridViewDanhGia, txtManv.Text);
            btnThemmoidg.Enabled = false;
            if (dataGridViewDanhGia.Rows.Count == 0)
            {
                btnCapnhatdg.Enabled = false;
                btnXoadg.Enabled = false;
            }
            else
            {
                btnCapnhatdg.Enabled = true;
                btnXoadg.Enabled = true;
            }
        }

        private void loadQuaTrinhHopDong()
        {
            ctr_qthopdong.HienThiAutoCombobox(cmbChucvuqthd);
            ctr_qthopdong.HienThiDataGridViewCombobox(colchucvuqthd);
            ctr_qthopdong.HienthinvCombobox(cmbNguoikyqthd);
            ctr_qthopdong.HienthiQuaTrinhHOPDONGGridview(dataGridViewXQuaTrinhHopDong, txtManv.Text);
            btnThemmoiqthd.Enabled = false;
            if (dataGridViewXQuaTrinhHopDong.Rows.Count == 0)
            {
                btnCapnhatqthd.Enabled = false;
                btnXoaqthd.Enabled = false;
            }
            else
            {
                btnCapnhatqthd.Enabled = true;
                btnXoaqthd.Enabled = true;
            }
        }

        private void loadDanhSachNgoaiNgu()
        {
            ctr_ngoaingu.HienThiAutoCombobox(cmbNgoainguNgoaiNgu);
            ctr_ngoaingu.HienThiDataGridViewCombobox(coltenngoaingungoaingu);
            ctr_dsngoaingu.HienthiDanhSachNgoainguDataGridview(dataGridViewDanhsachNgoaingu, txtManv.Text);
            btnThemMoiNgoaingu.Enabled = false;
            if (dataGridViewDanhsachNgoaingu.Rows.Count == 0)
            {
                btnCapnhatNgoaingu.Enabled = false;
                btnXoaNgoaingu.Enabled = false;
            }
            else
            {
                btnCapnhatNgoaingu.Enabled = true;
                btnXoaNgoaingu.Enabled = true;
            }
        }

        private void loadDanhSachNgheNghiep()
        {
            ctr_nghenghiep.HienThiAutoCombobox(cmbNghenghiepNgheNghiep);
            ctr_nghenghiep.HienThiDataGridViewCombobox(coltennghenghiepnn);
            ctr_dsnghenghiep.HienthiDanhSachNgheNghiepDataGridview(dataGridViewDanhsachNghenghiep, txtManv.Text);
            btnThemmoiNghenghiep.Enabled = false;
            if (dataGridViewDanhsachNghenghiep.Rows.Count == 0)
            {
                btncapnhatNghenghiep.Enabled = false;
                btnXoann.Enabled = false;
            }
            else
            {
                btncapnhatNghenghiep.Enabled = true;
                btnXoann.Enabled = true;
            }
        }

        private void loadThanNhanNuocNgoai()
        {
            ctr_thannhannuocngoai.HienthiTHANNHANNUOCNGOAIDataGridview(dataGridViewThanNhanNuocNgoai, txtManv.Text);
            btnThemmoiTNNN.Enabled = false;
            if (dataGridViewThanNhanNuocNgoai.Rows.Count == 0)
            {
                btnCapnhatTNNN.Enabled = false;
                btnXoaTNNN.Enabled = false;
            }
            else
            {
                btnCapnhatTNNN.Enabled = true;
                btnXoaTNNN.Enabled = true;
            }
        }

        private void loadQuanHeGiaDinh()
        {
            ctr_quanhegiadinh.HienthiQuanHeGiaDinhDataGridview(dataGridViewQuanHeGiaDinh, txtManv.Text);
            btnThemmoiQHGD.Enabled = false;
            if (dataGridViewQuanHeGiaDinh.Rows.Count == 0)
            {
                btnCapnhatQHGD.Enabled = false;
                btnXoaQHGD.Enabled = false;
            }
            else
            {
                btnCapnhatQHGD.Enabled = true;
                btnXoaQHGD.Enabled = true;
            }
        }

        private void loadThamGiaDaoTao()
        {
            ctr_dotdaotao.HienthiDataGridViewComboBoxColumn(colDotdaotaoTGDT);
            ctr_dotdaotao.HienThiAutoCombobox(cmbDotdaotaoTGDT);
            ctr_thamgiadaotao.HienthiTHAMGIADAOTAODataGridview(dataGridViewThamgiaDotDaoTao, txtManv.Text);
            btnThemmoiTGDT.Enabled = false;
            if (dataGridViewThamgiaDotDaoTao.Rows.Count == 0)
            {
                btnCapnhatTGDT.Enabled = false;
                btnXoaTGDT.Enabled = false;
            }
            else
            {
                btnCapnhatTGDT.Enabled = true;
                btnXoaTGDT.Enabled = true;
            }
        }

        private void loadChuyenMon()
        {
            ctr_chuyenmon.HienThiAutoCombobox(cmbChuyenmonCM);
            ctr_chuyenmon.HienthiDataGridViewComboBoxColumn(colchuyenmonCM);
            ctr_chuyenmon.HienthiCHUYENMONDataGridview(dataGridViewCHUYENMON, txtManv.Text);
            btnThemmoiCM.Enabled = false;
            if (dataGridViewCHUYENMON.Rows.Count == 0)
            {
                btnCapnhatCM.Enabled = false;
                btnXoaCM.Enabled = false;
            }
            else
            {
                btnCapnhatCM.Enabled = true;
                btnXoaCM.Enabled = true;
            }
        }
        String tenLogo = "";
        int capNhatHinh = -1;
        private void dataGridViewX1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridViewX1.Rows[e.RowIndex];
            //MessageBox.Show(e.RowIndex.ToString());

            //Thong tin nhan vien
            lbTennv.Text = row.Cells["colhoten"].Value.ToString();
            txtHoten.Text = row.Cells["colhoten"].Value.ToString();
            txtManv.Text = row.Cells["colmanv"].Value.ToString();
            txtBidanh.Text = row.Cells["colBidanh"].Value.ToString();
            txtCMND.Text = row.Cells["colCmnd"].Value.ToString();
            dtiNgaycap.Value = Convert.ToDateTime(row.Cells["colngaycap"].Value.ToString());
            txtNoicap.Text = row.Cells["colnoicap"].Value.ToString();
            txtDiachi.Text = row.Cells["coldiachi"].Value.ToString();
            txtDienthoaiLH.Text = row.Cells["coldienthoailh"].Value.ToString();
            txtDienthoaiCT.Text = row.Cells["coldienthoaict"].Value.ToString();
            txtDienthoaiNha.Text = row.Cells["coldienthoainha"].Value.ToString();
            txtEmail.Text = row.Cells["colEmail"].Value.ToString();
            txtFax.Text = row.Cells["colfax"].Value.ToString();
            dtiNgaySinh.Value = Convert.ToDateTime(row.Cells["colNgaySinh"].Value.ToString());
            txtTinh.Text = row.Cells["colTinh"].Value.ToString();
            txtQuanHuyen.Text = row.Cells["colQuanhuyen"].Value.ToString();
            cmbTinhTrangHonnhan.Text = row.Cells["colTinhtranghonnhan"].Value.ToString();
            txtThanhPhanGD.Text = row.Cells["colthanhphangd"].Value.ToString();
            cmbNvphutrach.SelectedValue = row.Cells["colnvphutrach"].Value.ToString();
            cmbPhongBan.SelectedValue = row.Cells["colphongban"].Value.ToString();
            cmbChucVu.SelectedValue = row.Cells["colchucvu"].Value.ToString();
            ckbGioitinh.Checked = Convert.ToBoolean(row.Cells["colgioitinh"].Value.ToString());
            //
            picbox.SizeMode = PictureBoxSizeMode.Zoom;
            //if (picbox.Image == null)
            //    picbox.Image = Image.FromFile(Application.StartupPath + "/HinhNV/NoPhoto.jpg");
            if (row.Cells["colhinhanh"].Value.ToString() == "")
                picbox.Image = Image.FromFile(Application.StartupPath + "/HinhNV/NoPhoto.jpg");
            else
            {
                picbox.Image = Image.FromFile(Application.StartupPath + "/HinhNV/" + row.Cells["colhinhanh"].Value.ToString() + ".jpg");
                tenLogo = row.Cells["colhinhanh"].Value.ToString();
            }
            //Thông tin thêm
            cmbCalamviec.Text = row.Cells["colCalamviec"].Value.ToString();
            txtSohopdong.Text = row.Cells["colSohopdong"].Value.ToString();
            dtiBatdauhopdong.Value = Convert.ToDateTime(row.Cells["colBatdauhd"].Value.ToString());
            dtiHethanhopdong.Value = Convert.ToDateTime(row.Cells["colHethanhd"].Value.ToString());
            txtHinhthuctuyendung.Text = row.Cells["colHinhthuctuyendung"].Value.ToString();
            cmbTrinhdotinhoc.SelectedValue = row.Cells["coltrinhdotinhoc"].Value.ToString();
            txtHocham.Text = row.Cells["colhocham"].Value.ToString();
            txtHocvi.Text = row.Cells["colhocvi"].Value.ToString();

            txtSobhxh.Text = row.Cells["colsobhxh"].Value.ToString();
            txtSobhyt.Text = row.Cells["colsobhyt"].Value.ToString();
            txtCannang.Text = row.Cells["colcannang"].Value.ToString();
            txtCao.Text = row.Cells["colcao"].Value.ToString();
            txtNhommau.Text = row.Cells["colnhommau"].Value.ToString();
            txtSuckhoe.Text = row.Cells["colsuckhoe"].Value.ToString();
            txtTaokhoannganhang.Text = row.Cells["coltaikhoannh"].Value.ToString();
            txtTennganhang.Text = row.Cells["coltennh"].Value.ToString();
            txtDiachinganhang.Text = row.Cells["coldiachinh"].Value.ToString();

            txtThuongphatthang.Text = row.Cells["colthuongphatthang"].Value.ToString();
            txtTongphat.Text = row.Cells["coltongphat"].Value.ToString();
            txtTongthuong.Text = row.Cells["coltongthuong"].Value.ToString();
            txtLuong.Text = row.Cells["colluong"].Value.ToString();
            txtPhucaptn.Text = row.Cells["colphucaptn"].Value.ToString();
            txtphucapdh.Text = row.Cells["colphucapdh"].Value.ToString();
            txtPhucapkv.Text = row.Cells["colphucapkv"].Value.ToString();
            txtPhucapkhac.Text = row.Cells["colphucapkhac"].Value.ToString();
            //Ghi chu
            //ctr_ghichu.HienthiGhiChuDataGridview(dataGridViewGhiChu, txtManv.Text);
            loadGhiChu();
            //Qúa trình cong tác NN
            //ctr_quatrinhcongtacnn.HienthiQuaTrinhCTNNGridview(dataGridViewXQuatrinhcongtacNN, txtManv.Text);
            loadQuatrinhCongTacNuocNgoai();
            // QUÁ TRÌNH CONG TÁC
            //ctr_quatrinhct.HienthiQuaTrinhCTNNGridview(dataGridViewXQuaTrinhCongTac, txtManv.Text);
            loadQuatrinhCongTac();
            //quá trình đào tạo
            loadQuaTrinhDaoTao();
            //quá trình khen thưởng
            loadQuaTrinhKhenThuong();
            ////quá trình kỷ luật
            loadQuaTrinhKyLuat();
            //quá trình bồi dưỡng
            loadQuaTrinhBoiDuong();
            //chuyen mon
            loadChuyenMon();
            //tham gia dao tao
            loadThamGiaDaoTao();
            //QUAN HE GIA DINH
            loadQuanHeGiaDinh();
            //THAN NHAN NUOC NGOAI
            loadThanNhanNuocNgoai();
            //danh sach nghe nghiep
            loadDanhSachNgheNghiep();
            //danh sach ngoai ngu
            loadDanhSachNgoaiNgu();
            //danh sach hop dong
            loadQuaTrinhHopDong();
            //DANH SACH DANH GIA
            loadDanhSachDanhGia();
            //DANH SACH PHONG BAN DA LAM VIEC
            loadPhongBanDaLamViec();
            //DANH SACH CONG VIEC
            loadQuaTrinhCongViec();

        }

        private void loadQuaTrinhBoiDuong()
        {            
            ctr_quatrinhboiduong.HienthiQuaTrinhBoiDuongGridview(dataGridViewQUATRINHBOIDUONG, txtManv.Text.ToString());
            btnThemmoiQTBD.Enabled = false;
            if (dataGridViewQUATRINHBOIDUONG.Rows.Count == 0)
            {
                btnCapnhatQTBD.Enabled = false;
                btnXoaQTBD.Enabled = false;
            }
            else
            {
                btnCapnhatQTBD.Enabled = true;
                btnXoaQTBD.Enabled = true;
            }
        }
        private void loadQuaTrinhKyLuat()
        {
            btnThemmoiQTKL.Enabled = false;
            ctr_quatrinhkyluat.HienthinvCombobox(cmbNguoikyQTKL);
            ctr_hinhthuckyluat.HienThiAutoCombobox(cmbHinhthuckyluatQTKL);
            ctr_quatrinhkyluat.HienthiDataGridViewComboBoxColumn(colNguoikyQTKL);

            ctr_quatrinhkyluat.HienthiQuaTrinhKYLUATGGridview(dataGridViewXQuaTrinhKyLuat, txtManv.Text.ToString());
            if (dataGridViewXQuaTrinhKyLuat.Rows.Count == 0)
            {
                btnCapnhatQTKL.Enabled = false;
                btnXoaQTKL.Enabled = false;
            }
            else
            {
                btnCapnhatQTKL.Enabled = true;
                btnXoaQTKL.Enabled = true;
            }
        }

        private void loadQuaTrinhKhenThuong()
        {
            ctr_quatrinhkhenthuong.HienthinvCombobox(cmbNguoikyQTKT);
            btnThemmoiQTKT.Enabled = false;
            ctr_quatrinhkhenthuong.HienthiQuaTrinhKHENTHUONGGridview(dataGridViewXQuaTrinhKhenThuong, txtManv.Text.ToString());
            if (dataGridViewXQuaTrinhKhenThuong.Rows.Count == 0)
            {
                btnCapnhatQTKT.Enabled = false;
                btnXoaQTKT.Enabled = false;
            }
            else
            {
                btnCapnhatQTKT.Enabled = true;
                btnXoaQTKT.Enabled = true;
            }
        }

        private void loadQuaTrinhDaoTao()
        {
            btnThemmoiQTDT.Enabled = false;
            ctr_nganhhoc.HienThiAutoCombobox(cmbNganhdaotaoQTDT);
            ctr_chuyennganh.HienThiAutoCombobox(cmbChuyennganhQTDT);
            ctr_chuyennganh.HienthiDataGridViewComboBoxColumn(colChuyennganhQTDT);

            ctr_quatrinhdaotao.HienthiQuaTrinhDaoTaoGridview(dataGridViewXQuaTrinhDaoTao, txtManv.Text.ToString());
            if (dataGridViewXQuaTrinhDaoTao.Rows.Count == 0)
            {
                btnCapnhatQTDT.Enabled = false;
                btnXoaQTDT.Enabled = false;
            }
            else
            {
                btnCapnhatQTDT.Enabled = true;
                btnXoaQTDT.Enabled = true;
            }
        }

        private void loadQuatrinhCongTac()
        {
            btnThemmoiQTCT.Enabled = false;
            ctr_quatrinhct.HienthiQuaTrinhCTGridview(dataGridViewXQuaTrinhCongTac, txtManv.Text);
            ctr_chucvu.HienThiAutoCombobox2(CmbChucvucaonhatQTCT);
            ctr_quatrinhct.HienthiDataGridViewComboBoxColumn(colChucvucaonhatQTCT);
            if (dataGridViewXQuaTrinhCongTac.Rows.Count == 0)
            {
                btnCapnhatQTCT.Enabled = false;
                btnXoaQTCT.Enabled = false;
            }
            else
            {
                btnCapnhatQTCT.Enabled = true;
                btnXoaQTCT.Enabled = true;
            }
        }

        private void loadGhiChu()
        {
            ctr_ghichu.HienthiGhiChuDataGridview(dataGridViewGhiChu, txtManv.Text);
            if (dataGridViewGhiChu.Rows.Count == 0)
            {
                btnSuaGhichu.Enabled = false;
                btnXoaGhichu.Enabled = false;
            }
            else
            {
                btnSuaGhichu.Enabled = true;
                btnXoaGhichu.Enabled = true;
            }
        }

        private void loadQuatrinhCongTacNuocNgoai()
        {
            btnThemmoiQTCTNN.Enabled = false;
            ctr_quatrinhcongtacnn.HienthiQuaTrinhCTNNGridview(dataGridViewXQuatrinhcongtacNN, txtManv.Text);
            if (dataGridViewXQuatrinhcongtacNN.Rows.Count == 0)
            {
                btnCapnhatQTCTNN.Enabled = false;
                btnXoaQTCTNN.Enabled = false;
            }
            else
            {
                btnCapnhatQTCTNN.Enabled = true;
                btnXoaQTCTNN.Enabled = true;
            }
        }

        /// <summary>
        /// //////////
        /// </summary>                          nhan vien
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnHinhmoi_Click(object sender, EventArgs e)
        {
            //txtTenHinh.Text = null;
            //OpenFileDialog open = new OpenFileDialog();
            //open.ShowDialog();
            //if (open.FileName.Length != 0)
            //{
            //    picbox.Image = null;
            //    picbox.BackgroundImage = null;
            //    picbox.SizeMode = PictureBoxSizeMode.Zoom;
            //    picbox.Image = Image.FromFile(open.FileName);
            //    txtTenHinh.Text = txtManv.Text;
            //}
            picbox.SizeMode = PictureBoxSizeMode.Zoom;
            OpenFileDialog openDlg = new OpenFileDialog();
            openDlg.Title = "Chọn Hình cho nhân viên :";
            openDlg.RestoreDirectory = true;
            openDlg.Filter = "All images (*.bmp;*.jpg;*.gif;*.png)|*.bmp;*.jpg;*.gif;*.png";
            openDlg.Multiselect = false;
            if (openDlg.ShowDialog() == DialogResult.OK)
            {
                picbox.Image = Image.FromFile(openDlg.FileName);
                capNhatHinh = 1;
            }
        }

        public bool KiemTraThongTinChinh()
        {
            if (txtHoten.Text.Trim() == "")
            {
                txtHoten.BackColor = Color.Yellow;
                txtHoten.Focus();
                return false;
            }
            if (cmbNvphutrach.Text.ToString() == "")
            {
                MessageBox.Show("Chưa chọn Nhân Viên Phụ Trách ");
                cmbNvphutrach.Focus();
                return false;
            }
            if (cmbChucVu.Text.ToString() == "")
            {
                MessageBox.Show("Chưa chọn Chức Vụ ");
                cmbChucVu.Focus();
                return false;
            }
            if (cmbPhongBan.Text.ToString() == "")
            {
                MessageBox.Show("Chưa chọn Phòng Ban ");
                cmbPhongBan.Focus();
                return false;
            }
            //if (txtBidanh.Text == "")
            //    txtBidanh.Text = "Không Có";
            //if (txtCMND.Text == "")
            //    txtCMND.Text = "Chưa Có";
            //if (txtNoicap.Text == "")
            //    txtNoicap.Text = "Chưa Có";
            //if (txtDiachi.Text == "")
            //    txtDiachi.Text = "Chưa Có";
            //if (txtDienthoaiLH.Text == "")
            //    txtDienthoaiLH.Text = "Chưa Có";
            //if (txtDienthoaiCT.Text == "")
            //    txtDienthoaiCT.Text = "Chưa Có";
            //if (txtDienthoaiNha.Text == "")
            //    txtDienthoaiNha.Text = "Chưa Có";
            //if (txtEmail.Text == "")
            //    txtEmail.Text = "Chưa Có";
            //if (txtFax.Text == "")
            //    txtFax.Text = "Chưa Có";
            //if (txtTinh.Text.ToString() == "")
            //    txtTinh.Text = "Chưa Có";
            //if (txtQuanHuyen.Text == "")
            //    txtQuanHuyen.Text = "Chưa Có";
            //if (cmbTinhTrangHonnhan.Text.ToString() == "")
            //    txtDienthoaiCT.Text = "Chưa Chọn";
            //if (txtThanhPhanGD.Text == "")
            //    txtThanhPhanGD.Text = "Chưa Có";
            //if (cmbCalamviec.Text == "")
            //    cmbCalamviec.Text = "Chưa chọn";
            //if (txtSohopdong .Text == "")
            //    txtSohopdong.Text = "Chưa có";
            //if (txtHinhthuctuyendung.Text == "")
            //    txtHinhthuctuyendung.Text = "Chưa có";
            if (cmbTrinhdotinhoc.SelectedValue == null)
            {
                //MessageBox.Show("Chưa chọn Phòng Ban ");
                //cmbTrinhdotinhoc.Focus();
                //return false;
                cmbTrinhdotinhoc.SelectedValue = "TDTH1";
            }
            //if (txtHocham.Text.ToString() == "")
            //    txtHocham.Text = "Chưa có";
            //if (txtHocvi.Text.ToString() == "")
            //    txtHocvi.Text = "Chưa có";
            //if (txtSobhxh.Text.ToString() == "")
            //    txtSobhxh.Text = "Chưa có";
            //if (txtSobhyt.Text.ToString() == "")
            //    txtSobhyt.Text = "Chưa có";
            //if (txtCannang.Text.ToString() == "")
            //    txtCannang.Text = "Chưa có";
            //if (txtCao.Text == "")
            //    txtCao.Text = "Chưa có";
            //if (txtNhommau.Text == "")
            //    txtNhommau.Text = "Chưa có";



            return true ;
        }

        int tmp = 0;
        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(cmbCalamviec.Text.ToString());
            if (KiemTraThongTinChinh())
            {
                if (capNhatHinh == 1)
                {
                    try
                    {
                        int tmp = Convert.ToInt32(tenLogo.Substring(4));
                        tmp++;
                        tenLogo = tenLogo.Substring(0, 4) + tmp.ToString();
                    }
                    catch
                    {
                        tenLogo = "Hinh1";
                    }
                    //MessageBox.Show(tenLogo);                    
                    picbox.Image.Save(Application.StartupPath + "/HinhNV/" + tenLogo + ".jpg");
                    capNhatHinh = -1;
                }
                data.ThemNhanVien(txtManv.Text.ToString(), "true", ckbGioitinh.Checked.ToString(), txtHoten.Text.ToString(), txtBidanh.Text, txtCMND.Text, dtiNgaycap.Value.ToString(), txtNoicap.Text, txtDiachi.Text, txtDienthoaiLH.Text, txtDienthoaiCT.Text, txtDienthoaiNha.Text, txtEmail.Text, txtFax.Text, dtiNgaySinh.Value.ToString(), txtTinh.Text, txtQuanHuyen.Text,
                             cmbTinhTrangHonnhan.Text, txtThanhPhanGD.Text, cmbNvphutrach.SelectedValue.ToString(),
                             cmbPhongBan.SelectedValue.ToString(), cmbChucVu.SelectedValue.ToString(),
                             cmbCalamviec.Text, txtSohopdong.Text, dtiBatdauhopdong.Value.ToString(), dtiHethanhopdong.Value.ToString(),
                             ckbThuviec.Checked.ToString(), ckbNhanvienphucvu.Checked.ToString(), txtHinhthuctuyendung.Text, cmbTrinhdotinhoc.SelectedValue.ToString(), txtHocham.Text, txtHocvi.Text,
              txtSobhxh.Text.ToString(),
                         txtSobhyt.Text.ToString(),
                         txtCannang.Text.ToString(),
                         txtCao.Text.ToString(),
                         txtNhommau.Text.ToString(),
                         txtSuckhoe.Text.ToString(),
                         txtTaokhoannganhang.Text.ToString(),
                         txtTennganhang.Text.ToString(),
                         txtDiachinganhang.Text.ToString(), txtThuongphatthang.Text, txtTongphat.Text, txtTongthuong.Text, txtLuong.Text, txtPhucaptn.Text, txtphucapdh.Text, txtPhucapkv.Text, txtPhucapkhac.Text
                         ,tenLogo    );
                loadData();
                btnThemMoi.Enabled = false;
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            btnThemMoi.Enabled = true;
            long maso = ThamSo.TaoMaNhanVien;
            ThamSo.TaoMaNhanVien = maso + 1;
            txtManv.Text = "NV" + maso.ToString();

            lbTennv.Text = "";
            txtHoten.Text = "";
            txtBidanh.Text = "";
            txtCMND.Text = "";
            dtiNgaycap.Value = DateTime.Now;
            txtNoicap.Text = "";
            txtDiachi.Text = "";
            txtDienthoaiLH.Text = "";
            txtDienthoaiCT.Text = "";
            txtDienthoaiNha.Text = "";
            txtEmail.Text = "";
            txtFax.Text = "";
            dtiNgaySinh.Value = DateTime.Now;
            txtTinh.Text = "";
            txtQuanHuyen.Text = "";
            cmbTinhTrangHonnhan.Text = "";
            txtThanhPhanGD.Text = "";
            cmbNvphutrach.SelectedValue = "";
            cmbPhongBan.SelectedValue = "";
            cmbChucVu.SelectedValue = "";
            ckbGioitinh.Checked = false;    

            //Thong tin them

            cmbCalamviec.Text = "";
            txtSohopdong.Text = "";
            dtiBatdauhopdong.Value = DateTime.Now;
            dtiHethanhopdong.Value = DateTime.Now;
            txtHinhthuctuyendung.Text = "";
            cmbTrinhdotinhoc.Text = "";
            txtHocham.Text = "";
            txtHocvi.Text = "";

            txtSobhxh.Text = "";
            txtSobhyt.Text = "";
            txtCannang.Text = "";
            txtCao.Text = "";
            txtNhommau.Text = "";
            txtSuckhoe.Text = "";
            txtTaokhoannganhang.Text = "";
            txtTennganhang.Text = "";
            txtDiachinganhang.Text = "";
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (KiemTraThongTinChinh())
            {
                if (capNhatHinh == 1)
                {
                    try
                    {
                        int tmp = Convert.ToInt32(tenLogo.Substring(4));
                        tmp++;
                        tenLogo = tenLogo.Substring(0, 4) + tmp.ToString();
                    }
                    catch
                    {
                        tenLogo = "Hinh1";
                    }
                    //MessageBox.Show(tenLogo);                    
                    picbox.Image.Save(Application.StartupPath + "/HinhNV/" + tenLogo + ".jpg");
                    capNhatHinh = -1;
                    MessageBox.Show(tenLogo);
                }    

                DataGridViewRow row = dataGridViewX1.CurrentRow;
                string manvchinhs = row.Cells["colmanv"].Value.ToString();
                data.CapNhatNhanVien(ckbGioitinh.Checked.ToString(), txtHoten.Text.ToString(), txtBidanh.Text, txtCMND.Text, dtiNgaycap.Value.ToString(), txtNoicap.Text, txtDiachi.Text, txtDienthoaiLH.Text, txtDienthoaiCT.Text, txtDienthoaiNha.Text, txtEmail.Text, txtFax.Text, dtiNgaySinh.Value.ToString(), txtTinh.Text, txtQuanHuyen.Text,
                    cmbTinhTrangHonnhan.Text, txtThanhPhanGD.Text, cmbNvphutrach.SelectedValue.ToString(),
                    cmbPhongBan.SelectedValue.ToString(), cmbChucVu.SelectedValue.ToString(),
                    cmbCalamviec.Text, txtSohopdong.Text, dtiBatdauhopdong.Value.ToString(), dtiHethanhopdong.Value.ToString(),
                    ckbThuviec.Checked.ToString(), ckbNhanvienphucvu.Checked.ToString(), txtHinhthuctuyendung.Text, cmbTrinhdotinhoc.SelectedValue.ToString(), txtHocham.Text, txtHocvi.Text,
     txtSobhxh.Text.ToString(),
                txtSobhyt.Text.ToString(),
                txtCannang.Text.ToString(),
                txtCao.Text.ToString(),
                txtNhommau.Text.ToString(),
                txtSuckhoe.Text.ToString(),
                txtTaokhoannganhang.Text.ToString(),
                txtTennganhang.Text.ToString(),
                txtDiachinganhang.Text.ToString(), txtThuongphatthang.Text, txtTongphat.Text, txtTongthuong.Text, txtLuong.Text, txtPhucaptn.Text, txtphucapdh.Text, txtPhucapkv.Text, txtPhucapkhac.Text,
                    tenLogo, manvchinhs);

                loadData();//ctr_quatrinhcongtacnn.HienthiQuaTrinhCTNNGridview(dataGridViewXQuatrinhcongtacNN, txtManv.Text);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn cho nhân viên này nghỉ việc ?", "Thông Báo !", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
            data.ThoiViecNV(txtManv.Text.ToString());
            loadData();
            }
        }
        /// <summary>
        /// /////////                                       Ghi chú    
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 

        private void btnThemGhichu_Click(object sender, EventArgs e)
        {
            frmGhiChu fghichu = new frmGhiChu(txtHoten.Text.ToString(), txtManv.Text.ToString());
            fghichu.ShowDialog();
            loadGhiChu();
        }

        private void btnSuaGhichu_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridViewGhiChu.CurrentRow;
            string maghichu = row.Cells["colghichuDGghichu"].Value.ToString();

            frmThemGhiChu fghichu = new frmThemGhiChu(maghichu);
            fghichu.ShowDialog();
            loadGhiChu();
        }

        private void btnXoaGhichu_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridViewGhiChu.CurrentRow;
            string maghichu = row.Cells["colghichuDGghichu"].Value.ToString();
            if (MessageBox.Show("Bạn muốn xoá ghi chú này ?", "Thông Báo !", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                data_ghichu.DeleteGhichu(maghichu);
                loadGhiChu();
            }
        }


        private void txtHoten_TextChanged(object sender, EventArgs e)
        {
            txtHoten.BackColor = Color.White;
        }

        /// <summary>
        /// //////////                                          quá trình công tác nước ngoài
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void btnLammoiQTCTNN_Click(object sender, EventArgs e)
        {
            btnThemmoiQTCTNN.Enabled = true;
            txtSoquyetdinh.Text = "";
            txtTencoquan.Text = "";
            txtNuoccongtac.Text = "";
            txtMucdich.Text = "";
            dtiNgaybatdau.Value = DateTime.Now;
            dtiNgayketthuc.Value = DateTime.Now;
        }
        public bool  KiemTraQUATRINHCONGTACNN()
        {
            if (txtSoquyetdinh .Text =="")
            {
                txtSoquyetdinh.BackColor = Color.Yellow;
                txtSoquyetdinh.Focus();
                return false;
            }
            if (txtNuoccongtac.Text == "")
            {
                txtNuoccongtac.BackColor = Color.Yellow;
                txtNuoccongtac.Focus();
                return false;
            }
            if (txtTencoquan.Text == "")
            {
                txtTencoquan.BackColor = Color.Yellow;
                txtTencoquan.Focus();
                return false;
            }
            if (txtMucdich.Text == "")
            {
                txtMucdich.Text = "Chưa có ";
            }
            return true;
        }

        private void btnThemmoiQTCTNN_Click(object sender, EventArgs e)
        {
            if (KiemTraQUATRINHCONGTACNN())
            {
                data_quatrinhcongtacnn.ThemQUATRINHCONGTACNN(txtSoquyetdinh.Text.ToString(), txtNuoccongtac.Text.ToString(), txtTencoquan.Text.ToString(), txtMucdich.Text.ToString(), dtiNgaybatdau.Value.ToString(), dtiNgayketthuc.Value.ToString(), txtManv.Text.ToString());

                ctr_quatrinhcongtacnn.HienthiQuaTrinhCTNNGridview(dataGridViewXQuatrinhcongtacNN, txtManv.Text);
                btnThemmoiQTCTNN.Enabled = false;
                loadQuatrinhCongTacNuocNgoai();
            }
        }

        private void btnXoaQTCTNN_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridViewXQuatrinhcongtacNN.CurrentRow;
            string maQTCTNN = row.Cells["MAQTCTNN"].Value.ToString();
            if (MessageBox.Show("Bạn muốn xoá ghi chú này ?", "Thông Báo !", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                data_quatrinhcongtacnn.DeleteQTCTNN(maQTCTNN);

                //ctr_quatrinhcongtacnn.HienthiQuaTrinhCTNNGridview(dataGridViewXQuatrinhcongtacNN, txtManv.Text);
                loadQuatrinhCongTacNuocNgoai();
            }
        }

        private void txtSoquyetdinh_TextChanged(object sender, EventArgs e)
        {
            txtSoquyetdinh.BackColor = Color.White;
            txtNuoccongtac.BackColor = Color.White;
            txtTencoquan.BackColor = Color.White;
        }

        private void dataGridViewXQuatrinhcongtacNN_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridViewXQuatrinhcongtacNN.Rows[e.RowIndex];
            //Thong tin chính
            txtSoquyetdinh.Text = row.Cells["colsoquyetdinhQTCTNN"].Value.ToString();
            txtNuoccongtac.Text = row.Cells["colnuoccongtacQTCTNN"].Value.ToString();
            txtTencoquan.Text = row.Cells["coltencoquanQTCTNN"].Value.ToString();
            txtMucdich.Text = row.Cells["colmucdichQTCTNN"].Value.ToString();
            dtiNgaybatdau.Value = Convert.ToDateTime(row.Cells["colngaybatdauQTCTNN"].Value.ToString());
            dtiNgayketthuc.Value = Convert.ToDateTime(row.Cells["colngayketthucQTCTNN"].Value.ToString());
        }

        private void btnCapnhatQTCTNN_Click(object sender, EventArgs e)
        {
            if (KiemTraQUATRINHCONGTACNN())
            {
                DataGridViewRow row = dataGridViewXQuatrinhcongtacNN.CurrentRow;
                string maQTCTNN = row.Cells["MAQTCTNN"].Value.ToString();
                data_quatrinhcongtacnn.CapNhatQUATRINHCONGTACNN(txtSoquyetdinh.Text.ToString(), txtNuoccongtac.Text.ToString(), txtTencoquan.Text.ToString(), txtMucdich.Text.ToString(), dtiNgaybatdau.Value.ToString(), dtiNgayketthuc.Value.ToString(), maQTCTNN);

                loadQuatrinhCongTacNuocNgoai();//ctr_quatrinhcongtacnn.HienthiQuaTrinhCTNNGridview(dataGridViewXQuatrinhcongtacNN, txtManv.Text);
            }
        }
        /// <summary>
        /// //////////////
        /// </summary>                                              QUÁ TRÌNH CONG TÁC
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        private void btnLammoiQTCT_Click(object sender, EventArgs e)
        {
            btnThemmoiQTCT.Enabled = true;
            txtCongvieccutheQTCT.Text = "";
            txtGhichuQTCT.Text = "";
            txtNoiCongtacQTCT.Text = "";
            CmbChucvucaonhatQTCT.Text = "";
            dtiNgaybatdauQTCT.Value = DateTime.Now;
            dtiNgayketthucQTCT.Value = DateTime.Now;
        }

        private void btnThemmoiQTCT_Click(object sender, EventArgs e)
        {
            if (KiemTraQUATRINHCONGTAC())
            {
                data_quatrinhct.ThemQUATRINHCONGTAC(dtiNgaybatdauQTCT.Value.ToString(), dtiNgayketthucQTCT.Value.ToString(), txtCongvieccutheQTCT.Text.ToString(), txtGhichuQTCT.Text.ToString(), txtNoiCongtacQTCT.Text.ToString(), CmbChucvucaonhatQTCT.SelectedValue.ToString(), txtManv.Text.ToString());

                ctr_quatrinhct.HienthiQuaTrinhCTGridview(dataGridViewXQuaTrinhCongTac, txtManv.Text);
                btnThemmoiQTCT.Enabled = false;
                loadQuatrinhCongTac();
            }
        }
        public bool KiemTraQUATRINHCONGTAC()
        {
            if (txtCongvieccutheQTCT.Text == "")
            {
                txtCongvieccutheQTCT.BackColor = Color.Yellow;
                txtCongvieccutheQTCT.Focus();
                return false;
            }
            if (txtNoiCongtacQTCT.Text == "")
            {
                txtNoiCongtacQTCT.BackColor = Color.Yellow;
                txtNoiCongtacQTCT.Focus();
                return false;
            }
            if (CmbChucvucaonhatQTCT.SelectedValue == null )
            {
                CmbChucvucaonhatQTCT.SelectedValue = "CV0";
            }
            if (txtGhichuQTCT.Text == "")
            {
                txtGhichuQTCT.Text = "Chưa có ";
            }
            return true;
        }

        private void btnCapnhatQTCT_Click(object sender, EventArgs e)
        {
            if (KiemTraQUATRINHCONGTAC())
            {
                DataGridViewRow row = dataGridViewXQuaTrinhCongTac.CurrentRow;
                string maQTCT = row.Cells["MAQTCT"].Value.ToString();
                data_quatrinhct.CapNhatQUATRINHCONGTAC(dtiNgaybatdauQTCT.Value.ToString(), dtiNgayketthucQTCT.Value.ToString(), txtCongvieccutheQTCT.Text.ToString(), txtGhichuQTCT.Text.ToString(), txtNoiCongtacQTCT.Text.ToString(), CmbChucvucaonhatQTCT.SelectedValue.ToString(), maQTCT.ToString());
                loadQuatrinhCongTac();//ctr_quatrinhct.HienthiQuaTrinhCTNNGridview(dataGridViewXQuaTrinhCongTac, txtManv.Text);
            }
        }

        private void btnXoaQTCT_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridViewXQuaTrinhCongTac.CurrentRow;
            string maQTCT = row.Cells["MAQTCT"].Value.ToString();
            //MessageBox.Show(row.Cells["MAQTCT"].Value.ToString());
            if (MessageBox.Show("Bạn muốn xoá Qúa trình công tác này ?", "Thông Báo !", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                data_quatrinhct.DeleteQTCT(maQTCT);
                loadQuatrinhCongTac(); //ctr_quatrinhcongtacnn.HienthiQuaTrinhCTNNGridview(dataGridViewXQuaTrinhCongTac, txtManv.Text);
            }
        }

        private void txtCongvieccutheQTCT_TextChanged(object sender, EventArgs e)
        {
            txtGhichuQTCT.BackColor = Color.White;
            txtCongvieccutheQTCT.BackColor = Color.White;
            txtNoiCongtacQTCT.BackColor = Color.White;
        }

        private void dataGridViewXQuaTrinhCongTac_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridViewXQuaTrinhCongTac.Rows[e.RowIndex];
            //Thong tin chính
            txtGhichuQTCT.Text = row.Cells["colghichuqtct"].Value.ToString();
            txtCongvieccutheQTCT.Text = row.Cells["colcongvieccutheqtct"].Value.ToString();
            txtNoiCongtacQTCT.Text = row.Cells["colnoicongtacqtct"].Value.ToString();
            CmbChucvucaonhatQTCT.SelectedValue = row.Cells["colChucvucaonhatQTCT"].Value.ToString();
            dtiNgaybatdauQTCT.Value = Convert.ToDateTime(row.Cells["colngaybatdauQTCT"].Value.ToString());
            dtiNgayketthucQTCT.Value = Convert.ToDateTime(row.Cells["colngayketthucQTCT"].Value.ToString());
        }

        private void dataGridViewXQuaTrinhCongTac_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }

        /// <summary>
        /// ////////                    QUÁ TRÌNH ĐÀO TẠO
        /// </summary>
        /// <returns></returns>
        public bool KiemTraQUATRINHDAOTAO()
        {
            if (txtNamnhaphocQTDT.Value < 1000)
            {
                txtNamnhaphocQTDT.BackColor = Color.Yellow;
                txtNamnhaphocQTDT.Focus();
                return false;
            }
            if (txtNamketthucQTDT.Value < 1000)
            {
                txtNamketthucQTDT.BackColor = Color.Yellow;
                txtNamketthucQTDT.Focus();
                return false;
            }
            if (txtBangcapQTDT.Text == "")
            {
                txtBangcapQTDT.BackColor = Color.Yellow;
                txtBangcapQTDT.Focus();
                return false;
            }
            
            if (txtNoidaotaoQTDT.Text == "")
            {
                txtNoidaotaoQTDT.BackColor = Color.Yellow;
                txtNoidaotaoQTDT.Focus();
                return false;
            }

            if (cmbNganhdaotaoQTDT.SelectedValue == null)
            {
                cmbNganhdaotaoQTDT.BackColor = Color.Yellow;
                cmbNganhdaotaoQTDT.Focus();
                return false;
                //cmbNganhdaotaoQTDT.SelectedValue = "NDT1";
            }
            if (cmbChuyennganhQTDT.SelectedValue == null)
            {
                cmbChuyennganhQTDT.SelectedValue = "CN1";
            }
            if (txtHinhthucQTDT.Text == "")
            {
                txtHinhthucQTDT.BackColor = Color.Yellow;
                txtHinhthucQTDT.Focus();
                return false;
            }
            if (txtGhichuQTDT.Text == "")
            {
                txtGhichuQTDT.Text = "Chưa có";
                //txtBangcapQTDT.BackColor = Color.Yellow;
                //txtBangcapQTDT.Focus();
                //return false;
            }
            return true;
        }

        private void txtNamnhaphocQTDT_ValueChanged(object sender, EventArgs e)
        {
            txtNamnhaphocQTDT.BackColor = Color.White;
            txtNamketthucQTDT.BackColor = Color.White;
        }

        private void txtBangcapQTDT_TextChanged(object sender, EventArgs e)
        {
            txtHinhthucQTDT.BackColor = Color.White;
            txtBangcapQTDT.BackColor = Color.White;
            txtNoidaotaoQTDT.BackColor = Color.White;
        }

        private void btnLammoiQTDT_Click(object sender, EventArgs e)
        {
            btnThemmoiQTDT.Enabled = true;
            txtNamnhaphocQTDT.Value = 0;
            txtNamketthucQTDT.Value = 0;
            txtBangcapQTDT.Text = "";
            txtGhichuQTDT.Text="";
            txtNoidaotaoQTDT.Text = "";
            cmbNganhdaotaoQTDT.Text="";
            cmbChuyennganhQTDT.Text = "";
            txtHinhthucQTDT.Text = "";

        }

        private void btnThemmoiQTDT_Click(object sender, EventArgs e)
        {
            if (KiemTraQUATRINHDAOTAO())
            {
                data_quatrinhdaotao.ThemQUATRINHDAOTAO(txtNamnhaphocQTDT.Value.ToString(), txtNamketthucQTDT.Value.ToString(), txtBangcapQTDT.Text.ToString(), txtGhichuQTDT.Text.ToString(), txtNoidaotaoQTDT.Text.ToString(), cmbNganhdaotaoQTDT.SelectedValue.ToString(), cmbChuyennganhQTDT.SelectedValue.ToString(), txtHinhthucQTDT.Text.ToString(), txtManv.Text.ToString());
                ctr_quatrinhdaotao.HienthiQuaTrinhDaoTaoGridview(dataGridViewXQuaTrinhDaoTao, txtManv.Text);
                btnThemmoiQTDT.Enabled = false;
                loadQuaTrinhDaoTao();
            }
        }

        private void btnCapnhatQTDT_Click(object sender, EventArgs e)
        {
            if (KiemTraQUATRINHDAOTAO())
            {
                DataGridViewRow row = dataGridViewXQuaTrinhDaoTao.CurrentRow;
                string maQTDT = row.Cells["maqtdt"].Value.ToString();
                data_quatrinhdaotao.CapNhatQUATRINHDAOTAO(txtNamnhaphocQTDT.Value.ToString(), txtNamketthucQTDT.Value.ToString(), txtBangcapQTDT.Text.ToString(), txtGhichuQTDT.Text.ToString(), txtNoidaotaoQTDT.Text.ToString(), cmbNganhdaotaoQTDT.SelectedValue.ToString(), cmbChuyennganhQTDT.SelectedValue.ToString(), txtHinhthucQTDT.Text.ToString(), maQTDT.ToString());
                loadQuaTrinhDaoTao();//ctr_quatrinhct.HienthiQuaTrinhCTNNGridview(dataGridViewXQuaTrinhCongTac, txtManv.Text);
            }
        }

        private void btnXoaQTDT_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridViewXQuaTrinhDaoTao.CurrentRow;
            string maQTDT = row.Cells["MAQTDT"].Value.ToString();
            if (MessageBox.Show("Bạn muốn xoá Qúa trình đào tạo này ?", "Thông Báo !", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                data_quatrinhdaotao.DeleteQUATRINHDAOTAO(maQTDT);
                loadQuaTrinhDaoTao();
            }
        }

        private void dataGridViewXQuaTrinhDaoTao_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridViewXQuaTrinhDaoTao.Rows[e.RowIndex];

            txtNamnhaphocQTDT.Value = Convert.ToDecimal(row.Cells["colnamnhaphocqtdt"].Value.ToString());
            txtNamketthucQTDT.Value = Convert.ToDecimal(row.Cells["colnamketthucqtdt"].Value.ToString());
            txtBangcapQTDT.Text = row.Cells["colbangcapqtdt"].Value.ToString();
            txtGhichuQTDT.Text = row.Cells["colghichuqtdt"].Value.ToString();
            txtHinhthucQTDT.Text = row.Cells["colhinhthucqtdt"].Value.ToString();
            txtNoidaotaoQTDT.Text = row.Cells["colnoidaotaoqtdt"].Value.ToString();
            cmbNganhdaotaoQTDT.SelectedValue = row.Cells["colnganhdaotaoqtdt"].Value.ToString();
            cmbChuyennganhQTDT.SelectedValue = row.Cells["colchuyennganhqtdt"].Value.ToString();

        }
        private void buttonX2_Click(object sender, EventArgs e)
        {
            frmThemChuyenNganh fthemcn = new frmThemChuyenNganh();
            fthemcn.ShowDialog();
            loadChuyenMon();
        }
        private void dataGridViewXQuaTrinhDaoTao_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }

        /// <summary>
        /// /////////                           QUA TRINH KHEN THUONG
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 

        private void btnLammoiQTKT_Click(object sender, EventArgs e)
        {
            btnThemmoiQTKT.Enabled = true;
            txtSoquyetdinhQTKT.Text = "";
            dtiNgayquyetdinhQTKT.Value = DateTime.Now;
            txtLydoQTKT.Text = "";
            txtGhichuQTCT.Text = "";
            txtHinhthucQTKT.Text = "";
            txtCoquankhenthuongQTKT.Text = "";
            cmbNguoikyQTKT.Text = "";
        }

        private void btnThemmoiQTKT_Click(object sender, EventArgs e)
        {
            if (KiemTraQUATRINHKHENTHUONG())
            {
                data_quatrinhkhenthuong.ThemKHENTHUONG(txtSoquyetdinhQTKT.Text.ToString(), dtiNgayquyetdinhQTKT.Value.ToString(), txtHinhthucQTKT.Text.ToString(), txtLydoQTKT.Text.ToString(), txtGhichuQTKT.Text.ToString(), txtCoquankhenthuongQTKT.Text.ToString(), cmbNguoikyQTKT.SelectedValue.ToString(), txtManv.Text.ToString());
                ctr_quatrinhkhenthuong.HienthiQuaTrinhKHENTHUONGGridview(dataGridViewXQuaTrinhKhenThuong, txtManv.Text);
                btnThemmoiQTKT.Enabled = false;
                loadQuaTrinhKhenThuong();
            }
        }

        private bool KiemTraQUATRINHKHENTHUONG()
        {
            if (txtSoquyetdinhQTKT.Text == "")
            {
                txtSoquyetdinhQTKT.BackColor = Color.Yellow;
                txtSoquyetdinhQTKT.Focus();
                return false;
            }
            if (txtLydoQTKT.Text == "")
            {
                txtLydoQTKT.BackColor = Color.Yellow;
                txtLydoQTKT.Focus();
                return false;
            }
            if (txtHinhthucQTKT.Text == "")
            {
                txtHinhthucQTKT.BackColor = Color.Yellow;
                txtHinhthucQTKT.Focus();
                return false;
            }
            if (txtCoquankhenthuongQTKT.Text == "")
            {
                txtCoquankhenthuongQTKT.BackColor = Color.Yellow;
                txtCoquankhenthuongQTKT.Focus();
                return false;
            }
            if (cmbNguoikyQTKT.SelectedValue == null)
            {
                cmbNguoikyQTKT.BackColor = Color.Yellow;
                cmbNguoikyQTKT.Focus();
                return false;
            }
            if (txtGhichuQTKT.Text == "")
            {
                txtGhichuQTKT.Text = "Chưa có";
            }
            return true;
        }

        private void txtSoquyetdinhQTKT_TextChanged(object sender, EventArgs e)
        {
            txtSoquyetdinhQTKT.BackColor = Color.White;
            txtLydoQTKT.BackColor = Color.White;
            txtHinhthucQTKT.BackColor = Color.White;
            txtCoquankhenthuongQTKT.BackColor = Color.White;
        }

        private void cmbNguoikyQTKT_TextChanged(object sender, EventArgs e)
        {
            cmbNguoikyQTKT.BackColor = Color.White;
        }

        private void btnCapnhatQTKT_Click(object sender, EventArgs e)
        {
            if (KiemTraQUATRINHDAOTAO())
            {
                DataGridViewRow row = dataGridViewXQuaTrinhKhenThuong.CurrentRow;
                string maQTKT = row.Cells["colmaqtkt"].Value.ToString();
                data_quatrinhkhenthuong.UpdateKHENTHUONG(txtSoquyetdinhQTKT.Text.ToString(), dtiNgayquyetdinhQTKT.Value.ToString(), txtHinhthucQTKT.Text.ToString(), txtLydoQTKT.Text.ToString(), txtGhichuQTKT.Text.ToString(), txtCoquankhenthuongQTKT.Text.ToString(), cmbNguoikyQTKT.SelectedValue.ToString(), maQTKT.ToString());
                loadQuaTrinhKhenThuong();
            }
        }

        private void btnXoaQTKT_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridViewXQuaTrinhKhenThuong.CurrentRow;
            string maQTKT = row.Cells["colmaqtkt"].Value.ToString();
            if (MessageBox.Show("Bạn muốn xoá Qúa trình khen thưởng này ?", "Thông Báo !", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                data_quatrinhkhenthuong.DeleteKHENTHUONG(maQTKT);
                loadQuaTrinhKhenThuong();
            }
        }

        private void dataGridViewXQuaTrinhKhenThuong_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridViewXQuaTrinhKhenThuong.Rows[e.RowIndex];

            txtSoquyetdinhQTKT.Text = row.Cells["colsoquyetdinhQTKt"].Value.ToString();
            dtiNgayquyetdinhQTKT.Value = Convert.ToDateTime(row.Cells["colNgayquyetdinhQTKT"].Value.ToString());
            txtLydoQTKT.Text = row.Cells["collydoqtkt"].Value.ToString();
            txtGhichuQTKT.Text = row.Cells["colGhichuQTKT"].Value.ToString();
            txtHinhthucQTKT.Text = row.Cells["colhinhthucqtkt"].Value.ToString();
            txtCoquankhenthuongQTKT.Text = row.Cells["colcoquankhenthuongqtkt"].Value.ToString();
            cmbNguoikyQTKT.SelectedValue = row.Cells["colnguoikyqtkt"].Value.ToString();

        }

        /// <summary>
        /// //////////                          ThONG TIN KY LUAT
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLammoiQTKL_Click(object sender, EventArgs e)
        {
            btnThemmoiQTKL.Enabled = true;
            txtSoquyetdinhQTKL.Text = "";
            dtiNgaykyluatQTKL.Value = DateTime.Now;
            txtLydokyluatQTKL.Text = "";
            txtGhichuQTKL.Text = "";
            txtCoquankyluatQTKL.Text = "";
            txtHinhthucQTKL.Text = "";

            cmbNguoikyQTKL.Text = "";
        }

        private bool KiemTraQUATRINHKYLUAT()
        {
            if (txtSoquyetdinhQTKL.Text == "")
            {
                txtSoquyetdinhQTKL.BackColor = Color.Yellow;
                txtSoquyetdinhQTKL.Focus();
                return false;
            }
            if (txtHinhthucQTKL.Text == "")
            {
                txtHinhthucQTKL.BackColor = Color.Yellow;
                txtHinhthucQTKL.Focus();
                return false;
            }
            if (txtLydokyluatQTKL.Text == "")
            {
                txtLydokyluatQTKL.BackColor = Color.Yellow;
                txtLydokyluatQTKL.Focus();
                return false;
            }
            if (txtCoquankyluatQTKL.Text == "")
            {
                txtCoquankyluatQTKL.BackColor = Color.Yellow;
                txtCoquankyluatQTKL.Focus();
                return false;
            }
            if (txtGhichuQTKL.Text == "")
            {
                txtGhichuQTKT.Text = "Chưa có";
            }
            if (cmbHinhthuckyluatQTKL.SelectedValue == null)
            {
                cmbHinhthuckyluatQTKL.Focus();
                return false;
            }
            if (cmbNguoikyQTKL.SelectedValue == null)
            {
                cmbNguoikyQTKL.Focus();
                return false;
            }
            return true;
        }

        private void btnThemmoiQTKL_Click(object sender, EventArgs e)
        {
            if (KiemTraQUATRINHKYLUAT())
            {
                data_quatrinhkyluat.ThemKYLUAT(txtSoquyetdinhQTKL.Text.ToString(), dtiNgaykyluatQTKL.Value.ToString(), txtHinhthucQTKL.Text.ToString(), txtLydokyluatQTKL.Text.ToString(), txtGhichuQTKL.Text.ToString(), txtCoquankyluatQTKL.Text.ToString(), cmbHinhthuckyluatQTKL.SelectedValue.ToString(), cmbNguoikyQTKL.SelectedValue.ToString(), txtManv.Text.ToString());
                ctr_quatrinhkyluat.HienthiQuaTrinhKYLUATGGridview(dataGridViewXQuaTrinhKyLuat, txtManv.Text);
                btnThemmoiQTKL.Enabled = false;
                loadQuaTrinhKyLuat();
            }

        }

        private void txtSoquyetdinhQTKL_TextChanged(object sender, EventArgs e)
        {
            txtSoquyetdinhQTKL.BackColor = Color.White;
            txtHinhthucQTKL.BackColor = Color.White;
            txtLydokyluatQTKL.BackColor = Color.White;
            txtCoquankyluatQTKL.BackColor = Color.White;
        }

        private void btnCapnhatQTKL_Click(object sender, EventArgs e)
        {
            if (KiemTraQUATRINHKYLUAT())
            {
                DataGridViewRow row = dataGridViewXQuaTrinhKyLuat.CurrentRow;
                string maQTKL = row.Cells["colmaqtkl"].Value.ToString();
                data_quatrinhkyluat.UpdateKYLUAT(txtSoquyetdinhQTKL.Text.ToString(), dtiNgaykyluatQTKL.Value.ToString(), txtHinhthucQTKL.Text.ToString(), txtLydokyluatQTKL.Text.ToString(), txtGhichuQTKL.Text.ToString(), txtCoquankyluatQTKL.Text.ToString(), cmbHinhthuckyluatQTKL.SelectedValue.ToString(), cmbNguoikyQTKL.SelectedValue.ToString(), maQTKL.ToString());
                loadQuaTrinhKyLuat();
            }
        }

        private void btnXoaQTKL_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridViewXQuaTrinhKyLuat.CurrentRow;
            string maQTKL = row.Cells["colmaqtkL"].Value.ToString();
            if (MessageBox.Show("Bạn muốn xoá Qúa trình kỷ luật này ?", "Thông Báo !", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                data_quatrinhkyluat.DeleteKYLUAT(maQTKL);
                loadQuaTrinhKyLuat();
            }
        }

        private void dataGridViewXQuaTrinhKyLuat_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridViewXQuaTrinhKyLuat.Rows[e.RowIndex];

            txtSoquyetdinhQTKL.Text = row.Cells["colsoquyetdinhQTKl"].Value.ToString();
            dtiNgaykyluatQTKL.Value = Convert.ToDateTime(row.Cells["colngaykyluatqtkl"].Value.ToString());
            txtLydokyluatQTKL.Text = row.Cells["collydokyluatqtky"].Value.ToString();
            txtGhichuQTKL.Text = row.Cells["colGhichuQTKl"].Value.ToString();
            txtHinhthucQTKL.Text = row.Cells["colhinhthucqtkl"].Value.ToString();
            txtCoquankyluatQTKL.Text = row.Cells["colcoquankyluatqtkl"].Value.ToString();
            cmbNguoikyQTKL.SelectedValue = row.Cells["colnguoikyqtkl"].Value.ToString();
            cmbHinhthuckyluatQTKL.SelectedValue = row.Cells["colhinhthuckyluatqtkl"].Value.ToString();
        }

        private void buttonX8_Click(object sender, EventArgs e)
        {
            frmThemHinhThucKyLuat fthemhtkl = new frmThemHinhThucKyLuat();
            fthemhtkl.ShowDialog();
            ctr_hinhthuckyluat.HienThiAutoCombobox(cmbHinhthuckyluatQTKL);
        }
        /// <summary>
        /// /////////
        /// </summary>                                QUA TRINH BOI DUONG  
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLammoiQTBD_Click(object sender, EventArgs e)
        {
            btnThemmoiQTBD.Enabled = true;
            dtiNgaybatdauNDBD.Value = DateTime.Now;
            dtiNgayketthucNDBD.Value = DateTime.Now;
            txtHinhthucNDBD.Text = "";
            txtNoiboidungNDBD.Text = "";
            txtNoidungboidungNDBD.Text = "";
            txtGhichuNDBD.Text = "";
        }

        private void btnThemmoiQTBD_Click(object sender, EventArgs e)
        {
            if (KiemTraQUATRINHBOIDUONG())
            {
                data_quatrinhboiduong.ThemQUATRINHBOIDUONG(dtiNgaybatdauNDBD.Value.ToString(), dtiNgayketthucNDBD.Value.ToString(), txtHinhthucNDBD.Text.ToString(), txtNoiboidungNDBD.Text.ToString(), txtNoidungboidungNDBD.Text.ToString(), txtGhichuNDBD.Text.ToString(), txtManv.Text.ToString());
                ctr_quatrinhboiduong.HienthiQuaTrinhBoiDuongGridview(dataGridViewQUATRINHBOIDUONG, txtManv.Text);
                btnThemmoiQTBD.Enabled = false;
                loadQuaTrinhBoiDuong();
            }
        }

        private bool KiemTraQUATRINHBOIDUONG()
        {
            if (txtHinhthucNDBD.Text == "")
            {
                txtHinhthucNDBD.BackColor = Color.Yellow;
                txtHinhthucNDBD.Focus();
                return false;
            }
            
            if (txtNoidungboidungNDBD.Text == "")
            {
                txtNoidungboidungNDBD.BackColor = Color.Yellow;
                txtNoidungboidungNDBD.Focus();
                return false;
            }
            if (txtNoiboidungNDBD.Text == "")
            {
                txtNoiboidungNDBD.BackColor = Color.Yellow;
                txtNoiboidungNDBD.Focus();
                return false;
            }
            if (txtGhichuNDBD.Text == "")
            {
                //txtGhichuNDBD.BackColor = Color.Yellow;
                //txtGhichuNDBD.Focus();
                //return false;
            }
            return true;
        }

        private void txtHinhthucNDBD_TextChanged(object sender, EventArgs e)
        {
            txtHinhthucNDBD.BackColor = Color.White;
            txtNoiboidungNDBD.BackColor = Color.White;
            txtNoidungboidungNDBD.BackColor = Color.White;
            txtGhichuNDBD.BackColor = Color.White;
        }

        private void btnCapnhatQTBD_Click(object sender, EventArgs e)
        {
            if (KiemTraQUATRINHKYLUAT())
            {
                DataGridViewRow row = dataGridViewQUATRINHBOIDUONG.CurrentRow;
                string maQTBD = row.Cells["colmaqtbd"].Value.ToString();
                data_quatrinhboiduong.CapNhatQUATRINHBOIDUONG( dtiNgaybatdauNDBD.Value.ToString(),dtiNgayketthucNDBD.Value.ToString(), txtHinhthucNDBD.Text.ToString(), txtNoiboidungNDBD.Text.ToString(), txtNoidungboidungNDBD.Text.ToString(), txtGhichuNDBD.Text.ToString(), maQTBD.ToString());
                loadQuaTrinhBoiDuong();
            }
        }

        private void btnXoaQTBD_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridViewQUATRINHBOIDUONG.CurrentRow;
            string maQTBD = row.Cells["colmaqtbd"].Value.ToString();
            if (MessageBox.Show("Bạn muốn xoá Qúa trình bồi dưỡng này ?", "Thông Báo !", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                data_quatrinhboiduong.DeleteQUATRINHBOIDUONG(maQTBD);
                loadQuaTrinhBoiDuong();
            }
        }

        private void dataGridViewQUATRINHBOIDUONG_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridViewQUATRINHBOIDUONG.Rows[e.RowIndex];

            dtiNgaybatdauNDBD.Value = Convert .ToDateTime(row.Cells["colngaybatdauqtbd"].Value.ToString());
            dtiNgayketthucNDBD.Value = Convert.ToDateTime(row.Cells["colngayketthucqtbd"].Value.ToString());
            txtHinhthucNDBD.Text = row.Cells["colhinhthucqtbd"].Value.ToString();
            txtNoiboidungNDBD.Text = row.Cells["colnoiboiduongqtbd"].Value.ToString();
            txtNoidungboidungNDBD.Text = row.Cells["colNoidungboiduongqtbd"].Value.ToString();
            txtGhichuNDBD.Text = row.Cells["colghichuqtbd"].Value.ToString();
        }
        /// <summary>
        /// ////                                                                
        /// </summary>                                              CHUYÊN MÔN
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 
        private void btnLammoiCM_Click(object sender, EventArgs e)
        {
            btnThemmoiCM.Enabled = true;
            cmbChuyenmonCM.Text = "";
            txtBangcapCM.Text = "";
            dtiNgaybatdauCM.Value = DateTime.Now;
            dtiNgayketthucCM.Value = DateTime.Now;
        }

        private void btnThemmoiCM_Click(object sender, EventArgs e)
        {string str=""+dtiNgaybatdauCM.Value.ToString()+ dtiNgayketthucCM.Value.ToString()+ cmbChuyenmonCM.SelectedValue.ToString()+ txtBangcapCM.Text.ToString()+ txtManv.Text.ToString();
        //MessageBox.Show(str);
            if (KiemTraCHUYENMON())
            {
                data_chuyenmon.ThemCHUYENMON(dtiNgaybatdauCM.Value.ToString(), dtiNgayketthucCM.Value.ToString(), cmbChuyenmonCM.SelectedValue.ToString(), txtBangcapCM.Text.ToString(), txtManv.Text.ToString());
                ctr_chuyenmon.HienthiCHUYENMONDataGridview(dataGridViewCHUYENMON, txtManv.Text);
                btnThemmoiCM.Enabled = false;
                loadChuyenMon();
            }
        }

        private bool KiemTraCHUYENMON()
        {
            if (cmbChuyenmonCM.SelectedValue == null)
            {
                cmbChuyenmonCM.Focus();
                return false;
            }
            if (txtBangcapCM.Text == "")
            {
                txtBangcapCM.BackColor = Color.Yellow;
                txtBangcapCM.Focus();
                return false;
            }
            return true;
        }

        private void btnCapnhatCM_Click(object sender, EventArgs e)
        {
            if (KiemTraQUATRINHKYLUAT())
            {
                DataGridViewRow row = dataGridViewCHUYENMON.CurrentRow;
                string maCM = row.Cells["colmachuyenmon"].Value.ToString();
                data_chuyenmon.CapNhatCHUYENMON(dtiNgaybatdauCM.Value.ToString(), dtiNgayketthucCM.Value.ToString(), cmbChuyenmonCM.SelectedValue.ToString(), txtBangcapCM.Text.ToString(), maCM.ToString());
                loadChuyenMon();
            }
        }

        private void btnXoaCM_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridViewCHUYENMON.CurrentRow;
            string maCM = row.Cells["colmachuyenmon"].Value.ToString();
            if (MessageBox.Show("Bạn muốn xoá chuyên môn này ?", "Thông Báo !", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                data_chuyenmon.DeleteCHUYENMON(maCM);
                loadChuyenMon();
            }
        }

        private void txtBangcapCM_TextChanged(object sender, EventArgs e)
        {
            txtBangcapCM.BackColor = Color.White;
        }

        private void dataGridViewCHUYENMON_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridViewCHUYENMON.Rows[e.RowIndex];

            dtiNgaybatdauCM.Value = Convert.ToDateTime(row.Cells["colngaybatdaucm"].Value.ToString());
            dtiNgayketthucCM.Value = Convert.ToDateTime(row.Cells["colngayketthuccm"].Value.ToString());
            cmbChuyenmonCM.SelectedValue = row.Cells["colchuyenmoncm"].Value.ToString();
            txtBangcapCM.Text = row.Cells["colbangcapcm"].Value.ToString();
        }

        private void btnThemCN_CM_Click(object sender, EventArgs e)
        {
            frmThemChuyenNganh fthemcn = new frmThemChuyenNganh();
            fthemcn.ShowDialog();
            loadChuyenMon();
        }
        /// <summary>
        /// /////////
        /// </summary>                          THAM GIA DAO TAO
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void btnThemTGDT_Click(object sender, EventArgs e)
        {
            frmThemDotDaoTao fthemddt = new frmThemDotDaoTao();
            fthemddt.ShowDialog();

        }

        private void btnLammoiTGDT_Click(object sender, EventArgs e)
        {
            btnThemmoiTGDT.Enabled = true;
            cmbDotdaotaoTGDT.Text = "";
        }

        private void btnThemmoiTGDT_Click(object sender, EventArgs e)
        {
            if (kiemtraTHAMGIADAOTAO())
            {
                data_thamgiadaotao.ThemTHAMGIADAOTAO(cmbDotdaotaoTGDT.SelectedValue.ToString(), txtManv.Text.ToString());
                loadThamGiaDaoTao();
            }

        }

        private bool kiemtraTHAMGIADAOTAO()
        {
            if (cmbDotdaotaoTGDT.SelectedValue == null)
            {
                cmbDotdaotaoTGDT.Focus();
                return false;
            }
            return true;

        }

        private void btnCapnhatTGDT_Click(object sender, EventArgs e)
        {
            if (kiemtraTHAMGIADAOTAO())
            {
                DataGridViewRow row = dataGridViewThamgiaDotDaoTao.CurrentRow;
                string maTGDT = row.Cells["colmatgdt"].Value.ToString();
                data_thamgiadaotao.UpdateTHAMGIADAOTAO(cmbDotdaotaoTGDT.SelectedValue.ToString(),maTGDT);
                loadThamGiaDaoTao();                
            }
        }

        private void btnXoaTGDT_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridViewThamgiaDotDaoTao.CurrentRow;
            string maTGDT = row.Cells["colmatgdt"].Value.ToString();
            if (MessageBox.Show("Bạn muốn xoá tham gia đào tạo này ?", "Thông Báo !", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                data_thamgiadaotao.DeleteTHAMGIADAOTAO(maTGDT);
                loadThamGiaDaoTao();
            }
        }

        private void dataGridViewThamgiaDotDaoTao_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridViewThamgiaDotDaoTao.Rows[e.RowIndex];

            cmbDotdaotaoTGDT.SelectedValue = row.Cells["colDotdaotaoTGDT"].Value.ToString();
        }

        private void btnThemDaoDao_Click(object sender, EventArgs e)
        {
            frmThemNganhHoc fnganhhoc = new frmThemNganhHoc();
            fnganhhoc.ShowDialog();
            loadQuaTrinhDaoTao();
        }
        /// <summary>
        /// ////////
        /// </summary>                          QUAN HE GIA DINH
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLammoiQHGD_Click(object sender, EventArgs e)
        {
            btnThemmoiQHGD.Enabled = true;
            txtQuanheQHGD.Text = "";
            txtHotenQHGD.Text = "";
            txtDiachiQHGD.Text = "";
            txtGhichuQHGD.Text = "";
            txtDiachiQHGD.Text = "";
            dtiNgaysinhQHGD.Value = DateTime.Now;
        }

        private void btnThemmoiQHGD_Click(object sender, EventArgs e)
        {
            if (kiemtraQHGD())
            {
                data_quanhegiadinh.ThemQUANHEGIADINH(dtiNgaysinhQHGD.Value.ToString(),txtQuanheQHGD .Text .ToString (),txtHotenQHGD .Text .ToString (),txtGhichuQHGD.Text .ToString (),txtNghenghiepQHGD .Text .ToString (),txtDiachiQHGD.Text .ToString () ,txtManv.Text.ToString());
                loadQuanHeGiaDinh();
            }
        }

        private bool kiemtraQHGD()
        {
            if (txtQuanheQHGD.Text == "")
            {
                txtQuanheQHGD.BackColor = Color.Yellow;
                txtQuanheQHGD.Focus();
                return false;
            }
            if (txtHotenQHGD.Text == "")
            {
                txtHotenQHGD.BackColor = Color.Yellow;
                txtHotenQHGD.Focus();
                return false;
            }

            if (txtNghenghiepQHGD.Text == "")
            {
                txtNghenghiepQHGD.BackColor = Color.Yellow;
                txtNghenghiepQHGD.Focus();
                return false;
            }
            if (txtDiachiQHGD.Text == "")
            {
                txtDiachiQHGD.BackColor = Color.Yellow;
                txtDiachiQHGD.Focus();
                return false;
            }
            if (txtGhichuQHGD.Text == "")
            {
                txtGhichuQHGD.Text = "Chưa có";
            }
            return true;
        }

        private void txtQuanheQHGD_TextChanged(object sender, EventArgs e)
        {
            txtQuanheQHGD.BackColor = Color.White;
            txtHotenQHGD.BackColor = Color.White;
            txtGhichuQHGD.BackColor = Color.White;
            txtDiachiQHGD.BackColor = Color.White;
            txtNghenghiepQHGD.BackColor = Color.White;
        }

        private void btnCapnhatQHGD_Click(object sender, EventArgs e)
        {
            if (kiemtraQHGD())
            {
                DataGridViewRow row = dataGridViewQuanHeGiaDinh.CurrentRow;
                string maQHGD = row.Cells["colmaQHGD"].Value.ToString();
                data_quanhegiadinh.CapNhatQUANHEGIADINH(dtiNgaysinhQHGD.Value.ToString(), txtQuanheQHGD.Text.ToString(), txtHotenQHGD.Text.ToString(), txtGhichuQHGD.Text.ToString(), txtNghenghiepQHGD.Text.ToString(), txtDiachiQHGD.Text.ToString(), maQHGD);
                loadQuanHeGiaDinh();
            }
        }

        private void btnXoaQHGD_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridViewQuanHeGiaDinh.CurrentRow;
            string maQHGD = row.Cells["colmaQHGD"].Value.ToString();
            if (MessageBox.Show("Bạn muốn xoá quan hệ gia đình này ?", "Thông Báo !", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                data_quanhegiadinh.DeleteQUANHEGIADINH(maQHGD);
                loadQuanHeGiaDinh();
            }
        }

        private void dataGridViewQuanHeGiaDinh_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridViewQuanHeGiaDinh.Rows[e.RowIndex];

            txtQuanheQHGD.Text = row.Cells["colquanheqhgd"].Value.ToString();
            txtHotenQHGD.Text = row.Cells["colhotenqhgd"].Value.ToString();
            txtGhichuQHGD.Text = row.Cells["colghichuqhgd"].Value.ToString();
            txtNghenghiepQHGD.Text = row.Cells["colnghenghiepqhgd"].Value.ToString();
            dtiNgaysinhQHGD.Value = Convert.ToDateTime(row.Cells["colngaysinhqhgd"].Value.ToString());
        }
        /// <summary>
        /// //////////
        /// </summary>                      THAN NHAN NUOC NGOAI
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLammoiTNNN_Click(object sender, EventArgs e)
        {
            btnThemmoiTNNN.Enabled = true;
            txtHotenTNNN.Text = "";
            txtQuanheTNNN.Text = "";
            txtNamdinhcuTNNN.Text = "";
            txtNuocdinhcuTNNN.Text = "";
            cmbQuoctichTNNN.Text = "";
            dtiNgaysinhTNNN.Value = DateTime.Now;
        }

        private void btnThemmoiTNNN_Click(object sender, EventArgs e)
        {
            if (kiemtraTNNN())
            {
                //if (namdinhcu())
                //{
                    data_thanhnhannuocngoai.ThemTHANNHANNUOCNGOAI(txtHotenTNNN.Text.ToString(), dtiNgaysinhTNNN.Value.ToString(), txtQuanheTNNN.Text.ToString(), txtNamdinhcuTNNN.Text.ToString(), txtNuocdinhcuTNNN.Text.ToString(), cmbQuoctichTNNN.Text.ToString(), txtManv.Text.ToString());
                    loadThanNhanNuocNgoai();
                //}
            }
        }

        private bool namdinhcu()
        {
            int i = Convert.ToInt32(txtNamdinhcuTNNN.Text);
            //MessageBox.Show(i.ToString());
            if (i < 1900 || i > 2020)
            {
                txtNamdinhcuTNNN.Focus();
                return false;
            }
            return true;
        }

        private bool kiemtraTNNN()
        {
            if (txtHotenTNNN .Text =="")
            {
                txtHotenTNNN.BackColor = Color.Yellow;
                txtHotenTNNN.Focus();
                return false;
            }
            if (txtQuanheTNNN.Text == "")
            {
                txtQuanheTNNN.BackColor = Color.Yellow;
                txtQuanheTNNN.Focus();
                return false;
            }
            if (txtNamdinhcuTNNN .Text =="")
            {
                txtNamdinhcuTNNN.BackColor = Color.Yellow;
                txtNamdinhcuTNNN.Focus();
                return false;
            }
            if (txtNuocdinhcuTNNN.Text == "")
            {
                txtNuocdinhcuTNNN.BackColor = Color.Yellow;
                txtNuocdinhcuTNNN.Focus();
                return false;
            }
            if (cmbQuoctichTNNN.Text == "")
            {
                cmbQuoctichTNNN.BackColor = Color.Yellow;
                cmbQuoctichTNNN.Focus();
                return false;
            }
            namdinhcu();
            return true;
        }

        private void btnCapnhatTNNN_Click(object sender, EventArgs e)
        {
            if (kiemtraTNNN())
            {
                if (namdinhcu ())
                {
                DataGridViewRow row = dataGridViewThanNhanNuocNgoai.CurrentRow;
                string maTNNN = row.Cells["colmaTNNN"].Value.ToString();
                data_thanhnhannuocngoai.UpdateTHANNHANNUOCNGOAI(txtHotenTNNN.Text.ToString(), dtiNgaysinhTNNN.Value.ToString(), txtQuanheTNNN.Text.ToString(), txtNamdinhcuTNNN.Text.ToString(), txtNuocdinhcuTNNN.Text.ToString(), cmbQuoctichTNNN.Text.ToString(), maTNNN);
                loadThanNhanNuocNgoai();
                }
            }
        }

        private void btnXoaTNNN_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridViewThanNhanNuocNgoai.CurrentRow;
            string matnnn = row.Cells["colmatnnn"].Value.ToString();
            if (MessageBox.Show("Bạn muốn xoá quan hệ thân nhân nước ngoài này ?", "Thông Báo !", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                data_thanhnhannuocngoai.DeleteTHANNHANNUOCNGOAI(matnnn);
                loadThanNhanNuocNgoai();
            }
        }

        private void txtNamdinhcuTNNN_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar < '0' || e.KeyChar > '9')
            {
                //MessageBox.Show("Dien Thoai nha chi duoc nhap so tu 6 so tro len", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
            }
        }

        private void txtNamdinhcuTNNN_TextChanged(object sender, EventArgs e)
        {
            txtHotenTNNN.BackColor = Color.White;
            txtQuanheTNNN.BackColor = Color.White;
            txtNamdinhcuTNNN.BackColor = Color.White;
            txtNuocdinhcuTNNN.BackColor = Color.White;
        }

        private void cmbQuoctichTNNN_TextChanged(object sender, EventArgs e)
        {
            cmbQuoctichTNNN.BackColor = Color.White;
        }

        private void dataGridViewThanNhanNuocNgoai_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridViewThanNhanNuocNgoai.Rows[e.RowIndex];

            txtHotenTNNN.Text = row.Cells["colhotentnnn"].Value.ToString();
            txtQuanheTNNN.Text = row.Cells["colquanhetnnn"].Value.ToString();
            txtNamdinhcuTNNN.Text = row.Cells["colnamdinhcutnnn"].Value.ToString();
            txtNuocdinhcuTNNN.Text = row.Cells["colnuocdinhcutnnn"].Value.ToString();
            dtiNgaysinhTNNN.Value = Convert.ToDateTime(row.Cells["colngaysinhtnnn"].Value.ToString());
            cmbQuoctichTNNN.Text = row.Cells["colquoctichtnnn"].Value.ToString();
        }
        /// <summary>
        /// ////
        /// </summary>                          DANH SACH NGHE NGHIEP
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridViewDanhsachNghenghiep_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridViewDanhsachNghenghiep.Rows[e.RowIndex];

            cmbNghenghiepNgheNghiep.SelectedValue  = row.Cells["coltennghenghiepnn"].Value.ToString();
            
        }

        private void btnXoann_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridViewDanhsachNghenghiep.CurrentRow;
            string madsnn = row.Cells["colMaNNDsnn"].Value.ToString();
            if (MessageBox.Show("Bạn muốn xoá danh sách nghề nghiệp này ?", "Thông Báo !", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                data_dsnghenghiep.DeleteDANHSACHNGHENGHIEP(madsnn);
                loadDanhSachNgheNghiep();
            }
        }

        private void btnLammoiNgheNghiep_Click(object sender, EventArgs e)
        {
            cmbNghenghiepNgheNghiep.Text = "";
            btnThemmoiNghenghiep.Enabled = true;
        }

        private void btnThemmoiNghenghiep_Click(object sender, EventArgs e)
        {
            if (kiemtranghenghiep())
            {


                data_dsnghenghiep.ThemDANHSACHNGHENGHIEP(txtManv.Text.ToString(), cmbNghenghiepNgheNghiep.SelectedValue.ToString());
                loadDanhSachNgheNghiep();
            }
        }

        private bool kiemtranghenghiep()
        {
            if (cmbNghenghiepNgheNghiep.SelectedValue == null)
            {
                cmbNghenghiepNgheNghiep.Focus();
                return false;
            }
            return true;
        }

        private void btncapnhatNghenghiep_Click(object sender, EventArgs e)
        {
            if (kiemtranghenghiep())
            {
                DataGridViewRow row = dataGridViewDanhsachNghenghiep.CurrentRow;
                string madsnn = row.Cells["colMaNNDsnn"].Value.ToString();
                data_dsnghenghiep.CapNhatDANHSACHNGHENGHIEP(cmbNghenghiepNgheNghiep.SelectedValue.ToString(),madsnn);
                loadDanhSachNgheNghiep();
            }
        }

        private void buttonX10_Click(object sender, EventArgs e)
        {
            frmThemNgheghiep fthemnn = new frmThemNgheghiep();
            fthemnn.ShowDialog();
            loadDanhSachNgheNghiep();
        }
        /// <summary>
        /// ////
        /// </summary>                                          DANH SACH NGOAI NGU    
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonX6_Click(object sender, EventArgs e)
        {
            frmThemNgoaiNgu fthemnngu = new frmThemNgoaiNgu();
            fthemnngu.ShowDialog();
            loadDanhSachNgoaiNgu();
        }

        private void dataGridViewDanhsachNgoaingu_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridViewDanhsachNgoaingu.Rows[e.RowIndex];
            //Thong tin chính
            cmbNgoainguNgoaiNgu.SelectedValue = row.Cells["coltenngoaingungoaingu"].Value.ToString();
            txtTrinhDoNgoaiNgu.Text = row.Cells["coltrinhdongoaingu"].Value.ToString();            
        }

        private void btnLamMoiNgoaingu_Click(object sender, EventArgs e)
        {
            cmbNgoainguNgoaiNgu.Text = "";
            btnThemMoiNgoaingu.Enabled = true;
        }

        private void btnThemMoiNgoaingu_Click(object sender, EventArgs e)
        {
            if (kiemtrangoaingu())
            {
                data_dsngoaingu.ThemDANHSACHNGOAINGU(txtManv.Text.ToString(), cmbNgoainguNgoaiNgu.SelectedValue.ToString(), txtTrinhDoNgoaiNgu.Text.ToString());
                loadDanhSachNgoaiNgu();
            }
        }

        private bool kiemtrangoaingu()
        {
            if (cmbNgoainguNgoaiNgu.SelectedValue == null )
            {
                cmbNgoainguNgoaiNgu.Focus();
                return false;
            }
            if (txtTrinhDoNgoaiNgu.Text == "")
            {
                txtTrinhDoNgoaiNgu.Focus();
                return false;
            }
            return true;
        }

        private void btnCapnhatNgoaingu_Click(object sender, EventArgs e)
        {
            if (kiemtrangoaingu())
            {
                DataGridViewRow row = dataGridViewDanhsachNgoaingu.CurrentRow;
                string madsnnGU = row.Cells["colmadsnnngoaingu"].Value.ToString();
                data_dsngoaingu.CapNhatDANHSACHNGOAINGU(cmbNgoainguNgoaiNgu.SelectedValue.ToString(), txtTrinhDoNgoaiNgu.Text, madsnnGU);
                loadDanhSachNgoaiNgu ();
            }
        }

        private void btnXoaNgoaingu_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridViewDanhsachNgoaingu.CurrentRow;
            string madsnnGU = row.Cells["colmadsnnngoaingu"].Value.ToString();
            if (MessageBox.Show("Bạn muốn xoá danh sách ngoại ngữ này ?", "Thông Báo !", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                data_dsngoaingu.DeleteDANHSACHNGOAINGU(madsnnGU);
                loadDanhSachNgoaiNgu();
            }
        }
        /// <summary>
        /// /////////
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtTongphat_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar < '0' || e.KeyChar > '9')
            {
                MessageBox.Show("Bạn phải nhập số ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
            }
        }

        private void btnThemTDTH_Click(object sender, EventArgs e)
        {
            frmThemTrinhDoTinHoc fthemtdth = new frmThemTrinhDoTinHoc();
            fthemtdth.ShowDialog();
            ctr_trinhdotinhoc.HienThiAutoCombobox(cmbTrinhdotinhoc);
        }

        private void btnThemPhongBan_Click(object sender, EventArgs e)
        {
            frmThemPhongBan fthempb = new frmThemPhongBan();
            fthempb.ShowDialog();
            ctr_phongban.HienThiAutoCombobox(cmbPhongBan);
        }

        private void btnThemChucvu_Click(object sender, EventArgs e)
        {
            frmThemChucVu fthemcv = new frmThemChucVu();
            fthemcv.ShowDialog();
            ctr_chucvu.HienThiAutoCombobox(cmbChucVu);
        }

        private void btnChucVuCaonhat_Click(object sender, EventArgs e)
        {
            frmThemChucVu fthemcv = new frmThemChucVu();
            fthemcv.ShowDialog();
            ctr_chucvu.HienThiAutoCombobox2(CmbChucvucaonhatQTCT);
        }
        /// <summary>
        /// /////
        /// </summary>                      QUA TRINH HOP DONG
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 
        private void btnLammoiqthd_Click(object sender, EventArgs e)
        {
            btnThemmoiqthd.Enabled = true;
            dtiNgaybatdauqthd.Value = DateTime.Now;
            dtiNgayketthucqthd.Value = DateTime.Now;
            dtiNgaykyqthd.Value = DateTime.Now;

            long ma = ThamSo.TaoMaQTHD;
            ThamSo.TaoMaQTHD = ma + 1;
            string maso = "HD" + ma.ToString();

            txtMahdqthd.Text = maso;
            numLankyqthd.Value = 0;
            txtHinhthucqthd.Text = "";
            txtNoidungqthd.Text = "";
            txtGhichuqthd.Text = "";
            txtvitriqthd.Text = "";
            cmbChucvuqthd.Text = "";
            cmbNguoikyqthd.Text = "";
            txtMucluongqthd.Text = "0";

            
        }

        private void btnThemmoiqthd_Click(object sender, EventArgs e)
        {
            if (kiemtraQUATRINHHOPDONG())
            {
                data_qthopdong.ThemQUATRINHHOPDONG(txtManv.Text.ToString(), txtMahdqthd.Text, dtiNgaybatdauqthd.Value.ToString(), dtiNgayketthucqthd.Value.ToString(), dtiNgaykyqthd.Value.ToString(), numLankyqthd.Value.ToString(), txtHinhthucqthd.Text, txtNoidungqthd.Text, txtGhichuqthd.Text, txtvitriqthd.Text, cmbChucVu.SelectedValue.ToString(), txtMucluongqthd.Text, cmbNguoikyqthd.SelectedValue.ToString());
                loadQuaTrinhHopDong();
            }
        }

        private bool kiemtraQUATRINHHOPDONG()
        {
            if (dtiNgaybatdauqthd.Value == null)
            {
                dtiNgaybatdauqthd.Focus();
                return false;
            }
            if (numLankyqthd.Value == null)
            {
                numLankyqthd.Value = 0;
                
            }
            if (txtHinhthucqthd.Text == "")
            {
                txtHinhthucqthd.BackColor = Color.Yellow;
                txtHinhthucqthd.Focus();
                return false;
            }
            if (txtvitriqthd.Text == "")
            {
                txtvitriqthd.BackColor = Color.Yellow;
                txtvitriqthd.Focus();
                return false;
            }

            if (cmbChucvuqthd.SelectedValue == null)
            {
                cmbChucvuqthd.BackColor = Color.Yellow;
                cmbChucvuqthd.Focus();
                return false;
            }
            if (txtMucluongqthd.Text == "")
            {
                txtMucluongqthd.BackColor = Color.Yellow;
                txtMucluongqthd.Focus();
                return false;
            }
            if (cmbNguoikyqthd.SelectedValue == null)
            {
                cmbNguoikyqthd.BackColor = Color.Yellow;
                cmbNguoikyqthd.Focus();
                return false;
            }
            return true;
        }

        private void dataGridViewXQuaTrinhHopDong_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridViewXQuaTrinhHopDong.Rows[e.RowIndex];
            //Thong tin chính

            dtiNgaybatdauqthd.Value = Convert.ToDateTime(row.Cells["colngaybatdauqthd"].Value.ToString());
            dtiNgayketthucqthd.Value = Convert.ToDateTime(row.Cells["colngayketthucqthd"].Value.ToString());
            dtiNgaykyqthd.Value = Convert.ToDateTime(row.Cells["colngaykyqthd"].Value.ToString());

            txtMahdqthd.Text = row.Cells["colmahdqthd"].Value.ToString();
            numLankyqthd.Value = Convert.ToDecimal(row.Cells["collankyqthd"].Value.ToString());
            txtHinhthucqthd.Text = row.Cells["colhinhthucqthd"].Value.ToString();
            txtNoidungqthd.Text = row.Cells["colnoidungqthd"].Value.ToString();
            txtGhichuqthd.Text = row.Cells["colghichuqthd"].Value.ToString();
            txtvitriqthd.Text = row.Cells["colvitriqthd"].Value.ToString();
            cmbChucvuqthd.SelectedValue = row.Cells["colchucvuqthd"].Value.ToString();
            cmbNguoikyqthd.SelectedValue = row.Cells["colnguoikyqthd"].Value.ToString();
            txtMucluongqthd.Text = row.Cells["colmucluongqthd"].Value.ToString();
        }

        private void btnCapnhatqthd_Click(object sender, EventArgs e)
        {
            if (kiemtraQUATRINHHOPDONG())
            {
                DataGridViewRow row = dataGridViewXQuaTrinhHopDong.CurrentRow;
                string mahd = row.Cells["colmahdqthd"].Value.ToString();
                data_qthopdong.CapNhatQUATRINHHOPDONG( dtiNgaybatdauqthd.Value.ToString(), dtiNgayketthucqthd.Value.ToString(), dtiNgaykyqthd.Value.ToString(), numLankyqthd.Value.ToString(), txtHinhthucqthd.Text, txtNoidungqthd.Text, txtGhichuqthd.Text, txtvitriqthd.Text, cmbChucVu.SelectedValue.ToString(), txtMucluongqthd.Text, cmbNguoikyqthd.SelectedValue.ToString(),mahd);
                loadQuaTrinhHopDong();
            }
        }

        private void txtMucluongqthd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar < '0' || e.KeyChar > '9')
            {
                MessageBox.Show("Bạn phải nhập số ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
            }
        }

        private void btnXoaqthd_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridViewXQuaTrinhHopDong.CurrentRow;
            string mahd = row.Cells["colmahdqthd"].Value.ToString();
            if (MessageBox.Show("Bạn muốn xoá Qúa trình hợp đồng này ?", "Thông Báo !", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                data_qthopdong.DeleteQUATRINHHOPDONG(mahd);
                loadQuaTrinhHopDong();
            }
        }

        private void txtHinhthucqthd_TextChanged(object sender, EventArgs e)
        {
            txtHinhthucqthd.BackColor = Color.White;
            txtvitriqthd.BackColor = Color.White;
            txtMucluongqthd.BackColor = Color.White;
        }

        private void numLankyqthd_ValueChanged(object sender, EventArgs e)
        {
            numLankyqthd.BackColor = Color.White;
        }
        /// <summary>
        /// /////////
        /// </summary>                                  DANH SACH DANH GIA
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnThemDDG_Click(object sender, EventArgs e)
        {
            frmThemDotDanhGia fthemddg = new frmThemDotDanhGia();
            fthemddg.ShowDialog();
            ctr_dotdanhgia.HienThiAutoCombobox(cmbDotdanhgiadg);
        }

        private void btnLammoidg_Click(object sender, EventArgs e)
        {
            btnThemmoidg.Enabled = true;
            cmbDotdanhgiadg.Text = "";
            dtiNgaydanhgiadg.Value = DateTime.Now;
            txtXeploaidg.Text = "";
            txtNhanxetdg.Text = "";
        }

        private void btnThemmoidg_Click(object sender, EventArgs e)
        {
            if (KiemtraDanhGIA())
            {
                data_danhgia.ThemDANHGIA(cmbDotdanhgiadg.SelectedValue.ToString(), dtiNgaydanhgiadg.Value.ToString(), txtXeploaidg.Text, txtNhanxetdg.Text, txtManv.Text);
                loadDanhSachDanhGia();
            }
        }

        private bool KiemtraDanhGIA()
        {
            if (cmbDotdanhgiadg.SelectedValue == null)
            {
                cmbDotdanhgiadg.Focus();
                return false;
            }
            if (txtXeploaidg.Text == "")
            {
                txtXeploaidg.BackColor = Color.Yellow;
                txtXeploaidg.Focus();
                return false;
            }
            return true;
        }

        private void btnCapnhatdg_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridViewDanhGia.CurrentRow;
            string madsdg = row.Cells["colMadgdg"].Value.ToString();
            data_danhgia.CapNhatDANHGIA(cmbDotdanhgiadg.SelectedValue.ToString(), dtiNgaydanhgiadg.Value.ToString(), txtXeploaidg.Text, txtNhanxetdg.Text, madsdg);
            loadDanhSachDanhGia();
        }

        private void btnXoadg_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridViewDanhGia.CurrentRow;
            string madsdg = row.Cells["colMadgdg"].Value.ToString();
            if (MessageBox.Show("Bạn muốn xoá Danh sách đánh giá này ?", "Thông Báo !", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                data_danhgia.DeleteDANHGIA(madsdg);
                loadDanhSachDanhGia();
            }
        }

        private void dataGridViewDanhGia_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridViewDanhGia.Rows[e.RowIndex];
            //Thong tin chính

            dtiNgaydanhgiadg.Value = Convert.ToDateTime(row.Cells["colngaydgdg"].Value.ToString());
            cmbDotdanhgiadg.SelectedValue = row.Cells["coldotdgdg"].Value.ToString();
            txtXeploaidg.Text = row.Cells["colxeploaidg"].Value.ToString();

            txtNhanxetdg.Text = row.Cells["colnhanxetdg"].Value.ToString();
        }

        private void txtXeploaidg_TextChanged(object sender, EventArgs e)
        {
            txtXeploaidg.BackColor = Color.White;
        }

        private void dataGridViewDanhGia_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }
        /// <summary>
        /// /////
        /// </summary>                          DANH SACH PHONG BAN DA LAM VIEC
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLammoiPBDLV_Click(object sender, EventArgs e)
        {
            btnThemmoiPBDLV.Enabled = true;
            cmbChucdanhPBDLV.Text = "";
            cmbPhongbanDalamviec.Text = "";
            dtiTungayPBDLV.Value = DateTime.Now;
            dtiDenngayPBDLV.Value = DateTime.Now;
            txtGhichuPBDLV.Text = "";
        }

        private void btnThemmoiPBDLV_Click(object sender, EventArgs e)
        {
            if (kiemtraPBDLV())
            {
                data_pbdlv.ThemDANHSACHPHONGBANDALAMVIEC(txtManv.Text, cmbPhongbanDalamviec.SelectedValue.ToString(), cmbChucdanhPBDLV.SelectedValue.ToString(), dtiTungayPBDLV.Value.ToString(), dtiDenngayPBDLV.Value.ToString(), txtGhichuPBDLV.Text);
                loadPhongBanDaLamViec();
            }
        }

        private bool kiemtraPBDLV()
        {
            if (cmbPhongbanDalamviec.Text == "")
            {
                cmbPhongbanDalamviec.Focus();
                return false;
            }
            if (cmbChucdanhPBDLV.Text == "")
            {
                cmbChucdanhPBDLV.Focus();
                return false;
            }
            return true;
        }

        private void btnCapnhatPBDLV_Click(object sender, EventArgs e)
        {
            if (kiemtraPBDLV())
            {
                DataGridViewRow row = dataGridViewPBDLV.CurrentRow;
                string mapbdlv = row.Cells["colmapbdlv"].Value.ToString();
                data_pbdlv.CapNhatDANHSACHPHONGBANDALAMVIEC(cmbPhongbanDalamviec.SelectedValue.ToString(), cmbChucdanhPBDLV.SelectedValue.ToString(), dtiTungayPBDLV.Value.ToString(), dtiDenngayPBDLV.Value.ToString(), txtGhichuPBDLV.Text,mapbdlv);
                loadPhongBanDaLamViec();
            }
        }

        private void btnXoaPBDLV_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridViewPBDLV.CurrentRow;
            string mapbdlv = row.Cells["colmapbdlv"].Value.ToString();
            if (MessageBox.Show("Bạn muốn xoá Danh sách Phòng ban đã làm việc này ?", "Thông Báo !", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                data_pbdlv.DeleteDANHSACHPHONGBANDALAMVIEC(mapbdlv);
                loadPhongBanDaLamViec();
            }
        }

        private void dataGridViewPBDLV_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridViewPBDLV.Rows[e.RowIndex];
            //Thong tin chính

            dtiTungayPBDLV.Value = Convert.ToDateTime(row.Cells["coltungaypbdlv"].Value.ToString());
            dtiDenngayPBDLV.Value = Convert.ToDateTime(row.Cells["coldenngaypbdlv"].Value.ToString());
            cmbPhongbanDalamviec.SelectedValue = row.Cells["colphongbanpbdlv"].Value.ToString();
            cmbChucdanhPBDLV.SelectedValue = row.Cells["colchucdanhpbdlv"].Value.ToString();
            txtGhichuPBDLV.Text = row.Cells["colghichupbdlv"].Value.ToString();
        }

        private void dataGridViewPBDLV_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }
        /// <summary>
        /// /
        /// </summary>                              QUA TRINH CONG VIEC
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLammoiQTCV_Click(object sender, EventArgs e)
        {
            btnThemmoiQTCV.Enabled = true;
            cmbTencongviecQTCV.Text = "";
            txtDonviQTCV.Text = "";
            dtiNgayhieulucQTCV.Value = DateTime.Now;
        }

        private void btnThemmoiQTCV_Click(object sender, EventArgs e)
        {
            if (KIEMTRAQTCV())
            {
                data_qtcongviec.ThemQUATRINHCONGVIEC(cmbTencongviecQTCV.SelectedValue.ToString(), txtDonviQTCV.Text, dtiNgayhieulucQTCV.Value.ToString(),txtManv.Text );
                loadQuaTrinhCongViec();
            }
        }

        private bool KIEMTRAQTCV()
        {
            if (cmbTencongviecQTCV.Text == "")
            {
                cmbTencongviecQTCV.Focus();
                return false;
            }
            if (txtDonviQTCV.Text == "")
            {
                txtDonviQTCV.BackColor = Color.Yellow;
                txtDonviQTCV.Focus();
                return false;
            }
            return true;
        }

        private void btnCapnhatQTCV_Click(object sender, EventArgs e)
        {
            if (KIEMTRAQTCV())
            {
                DataGridViewRow row = dataGridViewQTCongViec.CurrentRow;
                string maqtcv = row.Cells["colmaqtcv"].Value.ToString();
                data_qtcongviec.CapNhatQUATRINHCONGVIEC(cmbTencongviecQTCV.SelectedValue.ToString(), txtDonviQTCV.Text, dtiNgayhieulucQTCV.Value.ToString(), maqtcv);
                loadQuaTrinhCongViec();
            }
        }

        private void btnXoaQTCV_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridViewQTCongViec.CurrentRow;
            string maqtcv = row.Cells["colmaqtcv"].Value.ToString();
            if (MessageBox.Show("Bạn muốn xoá Danh sách Công việc này ?", "Thông Báo !", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                data_qtcongviec.DeleteQUATRINHCONGVIEC(maqtcv);
                loadQuaTrinhCongViec();
            }
        }

        private void dataGridViewQTCongViec_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridViewQTCongViec.Rows[e.RowIndex];
            //Thong tin chính

            dtiNgayhieulucQTCV.Value = Convert.ToDateTime(row.Cells["colngayhieulucqtcv"].Value.ToString());            
            cmbTencongviecQTCV.SelectedValue = row.Cells["coltencongviecqtcv"].Value.ToString();            
            txtDonviQTCV.Text = row.Cells["coldonviqtcv"].Value.ToString();
        }

        private void buttonX4_Click(object sender, EventArgs e)
        {
            frmThemCongViec fthemcv = new frmThemCongViec();
            fthemcv.ShowDialog();
            ctr_congviec.HienThiAutoCombobox(cmbTencongviecQTCV);
        }

        private void txtDonviQTCV_TextChanged(object sender, EventArgs e)
        {
            txtDonviQTCV.BackColor = Color.White;
        }

    }
}
