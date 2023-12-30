using System;
using System.Collections.Generic;
using DevExpress.XtraEditors;
using QuanLyDaoTao.Utilities;
using QuanLyDaoTao.DataAccess;
using QuanLyDaoTao.Business;

namespace QuanLyDaoTao.Presentation
{
    public partial class frmThemMonHoc : XtraForm
    {
        LogFile log;
        public frmThemMonHoc()
        {
            InitializeComponent();
            log = new LogFile();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                MonHoc mh = new MonHoc();
                if (!string.IsNullOrEmpty(txtMaMH.Text))
                    mh.MaMH = txtMaMH.Text.Trim();
                else
                {
                    MsgboxUtil.Exclamation("Mã môn học không được để trống");
                    txtMaMH.Focus();
                    return;
                }
                if (!string.IsNullOrEmpty(txtTenMH.Text))
                    mh.TenMH = txtTenMH.Text.Trim();
                else
                {
                    MsgboxUtil.Exclamation("Tên môn học không được để trống");
                    txtTenMH.Focus();
                    return;
                }
                if (numSTC.Value > 0)
                    mh.STC = (byte)numSTC.Value;
                else
                {
                    MsgboxUtil.Exclamation("Số tín chỉ không thể nhỏ hơn 0");
                    numSTC.Focus();
                    return;
                }

                if (numLyThuyet.Value > 0)
                    mh.LyThuyet = (byte)numLyThuyet.Value;
                else
                {
                    MsgboxUtil.Exclamation("Số tiết lý thuyết không thể nhỏ hơn 0");
                    numLyThuyet.Focus();
                    return;
                }

                if (numThucHanh.Value >= 0)
                    mh.ThucHanh = (byte)numThucHanh.Value;
                else
                {
                    MsgboxUtil.Exclamation("Số tiết thực hành không thể nhỏ hơn 0");
                    numThucHanh.Focus();
                    return;
                }
                MonHocBUS.Them(mh);
                StaticClass.LuuThayDoi();
                log.GhiFile("Thêm mới môn học: " + mh.MaMH);
                MsgboxUtil.Success("Thành công");
                btnHuy_Click(null, null);
            }
            catch (Exception ex)
            {
                ExceptionUtil.ThrowMsgBox(ex.Message);
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            txtMaMH.ResetText();
            txtTenMH.ResetText();
            numSTC.Value = 0;
            numLyThuyet.Value = 3;
            numThucHanh.Value = 0;
            txtMaMH.Focus();
        }
    }
}