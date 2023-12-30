using System;
using System.Data;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
using QLHocSinhTHPT.Controller;
using QLHocSinhTHPT.Component;
using DevComponents.DotNetBar;

namespace QLHocSinhTHPT
{
    public partial class frmHocLuc : Office2007Form
    {
        #region Fields
        HocLucCtrl  m_HocLucCtrl    = new HocLucCtrl();
        QuyDinh     quyDinh         = new QuyDinh();
        #endregion

        #region Costructor
        public frmHocLuc()
        {
            InitializeComponent();
            DataService.OpenConnection();
        }
        #endregion

        #region Load
        private void frmHocLuc_Load(object sender, EventArgs e)
        {
            m_HocLucCtrl.HienThi(dGVHocLuc, bindingNavigatorHocLuc);
        }
        #endregion

        #region BindingNavigatorItems
        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            if (dGVHocLuc.RowCount == 0)
                bindingNavigatorDeleteItem.Enabled = false;

            else if (MessageBoxEx.Show("Bạn có chắc chắn xóa dòng này không?", "DELETE", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                bindingNavigatorHocLuc.BindingSource.RemoveCurrent();
            }
        }

        private void bindingNavigatorExitItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            if (dGVHocLuc.RowCount == 0)
                bindingNavigatorDeleteItem.Enabled = true;

            DataRow m_Row           = m_HocLucCtrl.ThemDongMoi();
            m_Row["MaHocLuc"]       = "HL" + quyDinh.LaySTT(dGVHocLuc.Rows.Count + 1);
            m_Row["TenHocLuc"]      = "";
            m_Row["DiemCanTren"]    = 0;
            m_Row["DiemCanDuoi"]    = 0;
            m_Row["DiemKhongChe"]   = 0;
            m_HocLucCtrl.ThemHocLuc(m_Row);
            bindingNavigatorHocLuc.BindingSource.MoveLast();
        }

        public Boolean KiemTraTruocKhiLuu(String cellString)
        {
            foreach (DataGridViewRow row in dGVHocLuc.Rows)
            {
                if (row.Cells[cellString].Value != null)
                {
                    String str = row.Cells[cellString].Value.ToString();
                    if (str == "")
                    {
                        MessageBoxEx.Show("Giá trị của ô không được rỗng!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }
            }
            return true;
        }

        public Boolean KiemTraDiemTruocKhiLuu(String loaiDiem)
        {
            foreach (DataGridViewRow row in dGVHocLuc.Rows)
            {
                if (row.Cells[loaiDiem].Value != null)
                {
                    String diem = row.Cells[loaiDiem].Value.ToString();
                    if (diem == "" || quyDinh.KiemTraDiem(diem) == false)
                    {
                        MessageBoxEx.Show("Giá trị điểm không hợp lệ!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }
            }
            return true;
        }

        private void bindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            if (KiemTraTruocKhiLuu("colMaHocLuc")           == true &&
                KiemTraTruocKhiLuu("colTenHocLuc")          == true &&
                KiemTraDiemTruocKhiLuu("colDiemCanTren")    == true &&
                KiemTraDiemTruocKhiLuu("colDiemCanDuoi")    == true &&
                KiemTraDiemTruocKhiLuu("colDiemKhongChe")   == true)
            {
                bindingNavigatorPositionItem.Focus();
                m_HocLucCtrl.LuuHocLuc();
            }
        }
        #endregion

        #region DataError event
        private void dGVHocLuc_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }
        #endregion
    }
}