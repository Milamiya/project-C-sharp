using System;
using System.Collections.Generic;
using DevExpress.XtraEditors;
using QuanLyDaoTao.DataAccess;
using QuanLyDaoTao.Utilities;
using QuanLyDaoTao.Business;

namespace QuanLyDaoTao.Presentation
{
    public partial class frmThemNganhHoc : XtraForm
    {
        LogFile log;
        public frmThemNganhHoc()
        {
            InitializeComponent();
            log = new LogFile();
        }

        private bool TaoMoi(NganhHoc nh)
        {
            try
            {
                if (!string.IsNullOrEmpty(txtMaNganh.Text))
                    nh.MaNganh = txtMaNganh.Text;
                else
                {
                    MsgboxUtil.Exclamation("Mã ngành học không được để trống");
                    txtMaNganh.Focus();
                    return false;
                }

                if (!string.IsNullOrEmpty(txtTenNganh.Text))
                    nh.TenNganh = txtTenNganh.Text;
                else
                {
                    MsgboxUtil.Exclamation("Tên ngành học không được để trống");
                    txtTenNganh.Focus();
                    return false;
                }

                if (!string.IsNullOrEmpty(txtKhoa.Text))
                    nh.Khoa = txtKhoa.Text;

                return true;
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
                NganhHoc nh = new NganhHoc();
                if (TaoMoi(nh))
                {
                    NganhHocBUS.Them(nh);
                    StaticClass.LuuThayDoi();
                    log.GhiFile("Thêm mới ngành học: " + nh.MaNganh);
                    MsgboxUtil.Success("Thành công");
                    ClearText();
                }
            }
            catch (Exception ex)
            {
                ExceptionUtil.ThrowMsgBox(ex.Message);
            }
        }

        private void ClearText()
        {
            txtMaNganh.ResetText();
            txtTenNganh.ResetText();
            txtKhoa.ResetText();
            txtMaNganh.Focus();
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

        private void frmThemNganhHoc_Load(object sender, EventArgs e)
        {
            txtMaNganh.Focus();
        }

    }


}