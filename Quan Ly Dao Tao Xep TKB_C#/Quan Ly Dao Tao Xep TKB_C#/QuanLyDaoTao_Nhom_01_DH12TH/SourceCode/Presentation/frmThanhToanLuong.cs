using System;
using System.Collections.Generic;
using DevExpress.XtraEditors;
using QuanLyDaoTao.Utilities;
using QuanLyDaoTao.Business;
using QuanLyDaoTao.DataAccess;
using System.Data.Linq;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraGrid.Views.Grid;
using QuanLyDaoTao.DTO;

namespace QuanLyDaoTao.Presentation
{
    public partial class frmThanhToanLuong : XtraForm
    {
        private ISingleResult<sp_ThongTinGiangVienResult> giangVien;
        public frmThanhToanLuong()
        {
            try
            {
                InitializeComponent();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        /// <summary>
        /// Thiết lập các giá trị cho date edit bắt đầu và kết thúc
        /// </summary>
        private void SetDateEdit()
        {
            try
            {
                dateNgayBD.DateTime = DateTime.Parse("1/" + DateTime.Today.ToString("MM/yyyy"));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void LoadSourceGiangVien()
        {
            try
            {
                giangVien = GiangVienBUS.DanhSachGiangVien();
                gridControlGV.DataSource = giangVien;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void frmThanhToanLuong_Load(object sender, EventArgs e)
        {
            try
            {
                //load source cho grid giang vien
                LoadSourceGiangVien();
                //set cac gia tri cho date edit
                SetDateEdit();
                //grid control thoi khoa bieu
                XuLyRowClick();
            }
            catch (Exception ex)
            {
                ExceptionUtil.ThrowMsgBox(ex.Message);
            }
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            try
            {
                txtTimKiem.ResetText();
                gridControlGV.DataSource = giangVien;
            }
            catch (Exception ex)
            {
                ExceptionUtil.ThrowMsgBox(ex.Message);
            }
        }

        private void txtTimKiem_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    if (bool.Parse(radioGroup1.EditValue.ToString()))//tim theo ten
                        gridControlGV.DataSource = GiangVienBUS.DanhSachGiangVien().Where(gv => gv.HoTen.ToLower().Contains(txtTimKiem.Text.Trim().ToLower()));
                    else if (txtTimKiem.Text.Trim().Length == 6)//tim theo ma
                        gridControlGV.DataSource = GiangVienBUS.DanhSachGiangVien().Where(gv => gv.MaGV.ToLower() == txtTimKiem.Text.Trim().ToLower());
                    else
                        MsgboxUtil.Exclamation("Mã giảng viên không đúng định dạng");
                }
            }
            catch (Exception ex)
            {
                ExceptionUtil.ThrowMsgBox(ex.Message);
            }
        }

        private void radioGroup1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                txtTimKiem.Focus();
                txtTimKiem.SelectAll();
            }
            catch (Exception ex)
            {
                ExceptionUtil.ThrowMsgBox(ex.Message);
            }
        }

        private void dateNgayBD_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (dateNgayBD.DateTime > dateNgayKT.DateTime)
                    dateNgayKT.DateTime = dateNgayBD.DateTime.AddDays(1);
                XuLyRowClick();

            }
            catch (Exception ex)
            {
                ExceptionUtil.ThrowMsgBox(ex.Message);
            }
        }

        private void gridViewGV_RowClick(object sender, RowClickEventArgs e)
        {
            try
            {
                rowHandle = e.RowHandle;
                XuLyRowClick();
            }
            catch (Exception ex)
            {
                ExceptionUtil.ThrowMsgBox(ex.Message);
            }
        }
        int rowHandle = 0;
        private void XuLyRowClick()
        {
            try
            {
                string maGV = gridViewGV.GetRowCellValue(rowHandle, "MaGV").ToString();
                gridControlTKB.DataSource = ThoiKhoaBieuBUS.ThongTinThanhToan(maGV, dateNgayBD.DateTime, dateNgayKT.DateTime);
                txtGiangVien.EditValue = gridViewGV.GetRowCellValue(rowHandle, "HoTen");
                txtDonGia.EditValue = gridViewGV.GetRowCellValue(rowHandle, "LuongTiet");
                //tính tổng tiết và số tiết thực dạy
                int tongTiet = 0;
                int thucDay = 0;
                foreach (var i in ThoiKhoaBieuBUS.ThongTinThanhToan(maGV, dateNgayBD.DateTime, dateNgayKT.DateTime))
                {
                    tongTiet += (int)i.SoTiet;
                    if (i.CoDay && i.DaThanhToan == false)
                        thucDay += (int)i.SoTiet;
                }
                txtTongTiet.EditValue = tongTiet;
                txtThucDay.EditValue = thucDay;
                txtThanhTien.EditValue = thucDay * int.Parse(txtDonGia.EditValue.ToString());
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            try
            {
                string maGV = gridViewGV.GetRowCellValue(rowHandle, "MaGV").ToString();
                foreach (var i in ThoiKhoaBieuBUS.ThongTinThanhToan(maGV, dateNgayBD.DateTime, dateNgayKT.DateTime))
                {
                    ThoiKhoaBieuBUS.ThanhToan(i.MaPC, i.BuoiHoc);
                }
                StaticClass.LuuThayDoi();
                XuLyRowClick();
                StaticClass.Log.GhiFile("Thanh toán tiền lương cho giảng viên " + maGV + " từ " + dateNgayBD.DateTime.ToString("dd/MM/yyyy") + " đến " + dateNgayKT.DateTime.ToString("dd/MM/yyyy"));
                MsgboxUtil.Success("Đã thanh toán!");
            }
            catch (Exception ex)
            {
                ExceptionUtil.ThrowMsgBox(ex.Message);
            }
        }

        private void dateNgayKT_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (dateNgayKT.DateTime < dateNgayBD.DateTime)
                    dateNgayKT.DateTime = dateNgayBD.DateTime.AddDays(1);
                XuLyRowClick();
            }
            catch (Exception ex)
            {
                ExceptionUtil.ThrowMsgBox(ex.Message);
            }
        }

        public delegate void TruyenForm(XtraForm frm);
        public TruyenForm truyen;

        private void btnXem_Click(object sender, EventArgs e)
        {
            try
            {
                rptThanhToanGioDayDTO rptDTO = new rptThanhToanGioDayDTO();
                rptDTO.MaGV = gridViewGV.GetRowCellValue(rowHandle, "MaGV").ToString();
                rptDTO.NgayBD = dateNgayBD.DateTime;
                rptDTO.NgayKT = dateNgayKT.DateTime;
                rptDTO.TenGV = txtGiangVien.Text;
                rptDTO.ThucDay = int.Parse(txtThucDay.EditValue.ToString());
                rptDTO.ThuLao = int.Parse(txtDonGia.EditValue.ToString());
                rptDTO.TrinhDo = gridViewGV.GetRowCellDisplayText(rowHandle, "TenTrinhDo");
                rptDTO.NguonDuLieu = ThoiKhoaBieuBUS.ThongTinThanhToan(rptDTO.MaGV, rptDTO.NgayBD, rptDTO.NgayKT).Where(i => i.CoDay && i.DaThanhToan == false);
                frmInBangLuong frm = new frmInBangLuong(rptDTO);
                StaticClass.Log.GhiFile("In bảng thanh toán tiền lương cho giảng viên " + rptDTO.MaGV + " từ " + dateNgayBD.DateTime.ToString("dd/MM/yyyy") + " đến " + dateNgayKT.DateTime.ToString("dd/MM/yyyy"));
                if (truyen != null)
                    truyen(frm);
            }
            catch (Exception ex)
            {
                ExceptionUtil.ThrowMsgBox(ex.Message);
            }
        }
    }
}