using System;
using System.Collections.Generic;
using DevExpress.XtraEditors;
using QuanLyDaoTao.Utilities;
using QuanLyDaoTao.Business;
using QuanLyDaoTao.DataAccess;

namespace QuanLyDaoTao.Presentation
{
    public partial class frmThemLopHoc : XtraForm
    {
        LogFile log;
        public frmThemLopHoc()
        {
            InitializeComponent();
            log = new LogFile();
        }

        private void frmThemLopHoc_Load(object sender, EventArgs e)
        {
            try
            {   
                cmbNganh.Properties.DataSource = NganhHocBUS.DanhSachNganhHoc();
                cmbNganh.EditValue = cmbNganh.Properties.GetDataSourceValue("MaNganh", 0);
                dateBatDau.DateTime = DateTime.Now;
                TaoMaLop();
            }
            catch (Exception ex)
            {
                ExceptionUtil.ThrowMsgBox(ex.Message);
            }
        }

        private void dateBatDau_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (rdgBacHoc.SelectedIndex == 0)
                    dateKetThuc.DateTime = dateBatDau.DateTime.AddYears(4);
                else
                    dateKetThuc.DateTime = dateBatDau.DateTime.AddYears(3);
                TaoMaLop();
            }
            catch (Exception ex)
            {
                ExceptionUtil.ThrowMsgBox(ex.Message);
            }
        }

        private void rdgBacHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                dateBatDau_EditValueChanged(null, null);
                TaoMaLop();
            }
            catch (Exception ex)
            {
                ExceptionUtil.ThrowMsgBox(ex.Message);
            }
        }

        private void cmbNganh_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                TaoMaLop();
            }
            catch (Exception ex)
            {
                ExceptionUtil.ThrowMsgBox(ex.Message);
            }
        }

        private void TaoMaLop()
        {
            try
            {
                if (rdgBacHoc.SelectedIndex == 0)
                    txtMaLop.Text = "DH" + (dateBatDau.DateTime.Year + 1).ToString().Substring(2) + cmbNganh.EditValue.ToString();
                else
                    txtMaLop.Text = "CD" + (dateBatDau.DateTime.Year + 25).ToString().Substring(2) + cmbNganh.EditValue.ToString();
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
                Lop lop = new Lop() { MaLop = txtMaLop.Text, MaNganh = cmbNganh.EditValue.ToString() };
                LopBUS.Them(lop);
                StaticClass.LuuThayDoi();
                log.GhiFile("Thêm mới lớp học: " + lop.MaLop);
                MsgboxUtil.Success("Thành công");
            }
            catch (Exception ex)
            {
                ExceptionUtil.ThrowMsgBox(ex.Message);
            }
        }
    }
}