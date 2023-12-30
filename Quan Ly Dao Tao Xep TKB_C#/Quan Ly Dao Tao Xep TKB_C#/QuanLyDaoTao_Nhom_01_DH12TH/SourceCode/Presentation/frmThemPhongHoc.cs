using System;
using System.Collections.Generic;
using DevExpress.XtraEditors;
using QuanLyDaoTao.Utilities;
using QuanLyDaoTao.DataAccess;
using QuanLyDaoTao.Business;

namespace QuanLyDaoTao.Presentation
{
    public partial class frmThemPhongHoc : XtraForm
    {
        public frmThemPhongHoc()
        {
            InitializeComponent();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                PhongHoc p = new PhongHoc();
                if (!string.IsNullOrEmpty(txtMaPhong.Text))
                    p.MaPhong = txtMaPhong.Text;
                else
                {
                    MsgboxUtil.Exclamation("Mã phòng không được rỗng");
                    return;
                }
                if (!string.IsNullOrEmpty(txtChucNang.Text))
                    p.ChucNang = txtChucNang.Text;
                if (!string.IsNullOrEmpty(txtDiaChi.Text))
                    p.DiaChi = txtDiaChi.Text;
                p.SucChua = (int)numSucChua.Value;
                PhongHocBUS.Them(p);
                StaticClass.LuuThayDoi();
                StaticClass.Log.GhiFile("Thêm mới phòng học: " + p.MaPhong);
                MsgboxUtil.Success("Thành công!");
                ClearText();
            }
            catch (Exception ex)
            {
                ExceptionUtil.ThrowMsgBox(ex.Message);
            }
        }

        private void ClearText()
        {
            try
            {
                txtMaPhong.ResetText();
                numSucChua.Value = 1;
                txtChucNang.ResetText();
                txtDiaChi.ResetText();
                txtMaPhong.Focus();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            try
            {
                ClearText();
            }
            catch (Exception ex)
            {
                ExceptionUtil.ThrowMsgBox(ex.Message);
            }
        }
    }
}