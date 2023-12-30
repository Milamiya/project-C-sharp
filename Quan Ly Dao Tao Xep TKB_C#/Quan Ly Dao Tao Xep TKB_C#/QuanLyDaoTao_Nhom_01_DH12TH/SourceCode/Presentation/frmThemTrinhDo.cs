using System;
using System.Collections.Generic;
using DevExpress.XtraEditors;
using QuanLyDaoTao.Utilities;
using QuanLyDaoTao.DataAccess;
using QuanLyDaoTao.Business;

namespace QuanLyDaoTao.Presentation
{
    public partial class frmThemTrinhDo : XtraForm
    {
        LogFile log;
        public frmThemTrinhDo()
        {
            InitializeComponent();
            log = new LogFile();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                TrinhDo td = new TrinhDo();
                if (!string.IsNullOrEmpty(txtMaTrinhDo.Text))
                    td.MaTrinhDo = txtMaTrinhDo.Text.Trim();
                else
                {
                    MsgboxUtil.Exclamation("Mã trình độ không được để trống");
                    txtMaTrinhDo.Focus();
                    return;
                }
                if (!string.IsNullOrEmpty(txtTenTrinhDo.Text))
                    td.TenTrinhDo = txtTenTrinhDo.Text.Trim();
                else
                {
                    MsgboxUtil.Exclamation("Tên trình độ không được để trống");
                    txtTenTrinhDo.Focus();
                    return;
                }
                if (numLuong.Value > 0)
                    td.HeSoLuong = (int)numLuong.Value;
                else
                {
                    MsgboxUtil.Exclamation("Tên trình độ không được để trống");
                    txtTenTrinhDo.Focus();
                    return;
                }
                TrinhDoBUS.Them(td);
                StaticClass.LuuThayDoi();
                log.GhiFile("Thêm mới trình độ: " + td.MaTrinhDo);
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
            txtMaTrinhDo.ResetText();
            txtTenTrinhDo.ResetText();
            numLuong.Value = 50000;
        }
    }
}