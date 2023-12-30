using System;
using System.Collections.Generic;
using DevExpress.XtraEditors;
using QuanLyDaoTao.Utilities;
using QuanLyDaoTao.Business;
using QuanLyDaoTao.DataAccess;
using System.Data.Linq;
using System.Windows.Forms;

namespace QuanLyDaoTao.Presentation
{
    public partial class frmCapNhatSinhVien : XtraForm
    {
        public frmCapNhatSinhVien()
        {
            InitializeComponent();
        }

        private Table<SinhVien> nguon;

        private void frmCapNhatSinhVien_Load(object sender, EventArgs e)
        {
            try
            {
                //grid control
                nguon = SinhVienBUS.DanhSachSV();
                gridControl1.DataSource = nguon;
                gridView1.ExpandAllGroups();
                //cmbLop
                LayNguonChoLop();
                //Bingding data
                txtMSSV.DataBindings.Clear();
                txtMSSV.DataBindings.Add("Text", nguon, "MSSV");
                txtHoTen.DataBindings.Clear();
                txtHoTen.DataBindings.Add("Text", nguon, "HoTen");
                dateNgaySinh.DataBindings.Clear();
                dateNgaySinh.DataBindings.Add("DateTime", nguon, "NgaySinh");
                cmbLop.DataBindings.Clear();
                cmbLop.DataBindings.Add("EditValue", nguon, "MaLop");
                txtDiaChi.DataBindings.Clear();
                txtDiaChi.DataBindings.Add("Text", nguon, "DiaChi");
            }
            catch (Exception ex)
            {
                ExceptionUtil.ThrowMsgBox(ex.Message);
            }
        }

        private void LayNguonChoLop()
        {
            try
            {
                cmbLop.Properties.DataSource = LopBUS.DanhSachTuyChinh();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                StaticClass.LuuThayDoi();
                StaticClass.Log.GhiFile("Cập nhật thông tin một hoặc nhiều sinh viên");
                MsgboxUtil.Success("Đã cập nhật thay đổi vào CSDL");
            }
            catch (Exception ex)
            {
                ExceptionUtil.ThrowMsgBox(ex.Message);
            }
        }

        private void toolStripMenuXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (MsgboxUtil.YesNo("Bạn muốn xóa sinh viên " + txtMSSV.Text + "?") == DialogResult.Yes)
                {
                    int[] i = gridView1.GetSelectedRows();
                    if (i.Length > 0)
                    {
                        string mssv = gridView1.GetRowCellDisplayText(i[0], "MSSV");
                        gridView1.DeleteRow(i[0]);
                        SinhVienBUS.Xoa(mssv);
                        StaticClass.LuuThayDoi();
                        StaticClass.Log.GhiFile("Xóa sinh viên " + txtMSSV.Text);
                    }
                }
            }
            catch (Exception ex)
            {
                ExceptionUtil.ThrowMsgBox(ex.Message);
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            try
            {
                toolStripMenuXoa_Click(null, null);
            }
            catch (Exception ex)
            {
                ExceptionUtil.ThrowMsgBox(ex.Message);
            }
        }
    }
}