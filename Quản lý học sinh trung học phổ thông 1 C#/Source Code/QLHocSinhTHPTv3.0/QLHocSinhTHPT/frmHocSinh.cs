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
    public partial class frmHocSinh : Office2007Form
    {
        #region Fields
        HocSinhCtrl     m_HocSinhCtrl       = new HocSinhCtrl();
        DanTocCtrl      m_DanTocCtrl        = new DanTocCtrl();
        TonGiaoCtrl     m_TonGiaoCtrl       = new TonGiaoCtrl();
        NgheNghiepCtrl  m_NgheNghiepChaCtrl = new NgheNghiepCtrl();
        NgheNghiepCtrl  m_NgheNghiepMeCtrl  = new NgheNghiepCtrl();
        QuyDinh         quyDinh             = new QuyDinh();
        #endregion

        #region Constructor
        public frmHocSinh()
        {
            InitializeComponent();
            DataService.OpenConnection();
        }
        #endregion

        #region Load
        private void frmHocSinh_Load(object sender, EventArgs e)
        {
            m_DanTocCtrl.HienThiComboBox(cmbDanToc);
            m_TonGiaoCtrl.HienThiComboBox(cmbTonGiao);
            m_NgheNghiepChaCtrl.HienThiComboBox(cmbNgheNghiepCha);
            m_NgheNghiepMeCtrl.HienThiComboBox(cmbNgheNghiepMe);

            m_DanTocCtrl.HienThiDataGridViewComboBoxColumn(colMaDanToc);
            m_TonGiaoCtrl.HienThiDataGridViewComboBoxColumn(colMaTonGiao);
            m_NgheNghiepChaCtrl.HienThiDataGridViewComboBoxColumnNNCha(colMaNNghiepCha);
            m_NgheNghiepMeCtrl.HienThiDataGridViewComboBoxColumnNNMe(colMaNNghiepMe);

            m_HocSinhCtrl.HienThi(dGVHocSinh, bindingNavigatorHocSinh, txtMaHocSinh, txtTenHocSinh, txtGioiTinh, ckbGTinhNam, ckbGTinhNu, dtpNgaySinh, txtNoiSinh, cmbDanToc, cmbTonGiao, txtHoTenCha, cmbNgheNghiepCha, txtHoTenMe, cmbNgheNghiepMe);
        }
        #endregion

        #region BindingNavigatorItems
        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            if (dGVHocSinh.RowCount == 0)
                bindingNavigatorDeleteItem.Enabled = false;

            else if (MessageBoxEx.Show("Bạn có chắc chắn xóa dòng này không?", "DELETE", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                bindingNavigatorHocSinh.BindingSource.RemoveCurrent();
            }
        }

        private void bindingNavigatorExitItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            if (dGVHocSinh.RowCount == 0)
                bindingNavigatorDeleteItem.Enabled = true;

            DataRow m_Row           = m_HocSinhCtrl.ThemDongMoi();
            m_Row["MaHocSinh"]      = "HS" + quyDinh.LaySTT(dGVHocSinh.Rows.Count + 1);
            m_Row["HoTen"]          = "";
            m_Row["GioiTinh"]       = false;
            m_Row["NgaySinh"]       = DateTime.Today;
            m_Row["NoiSinh"]        = "";
            m_Row["MaDanToc"]       = "";
            m_Row["MaTonGiao"]      = "";
            m_Row["HoTenCha"]       = "";
            m_Row["MaNNghiepCha"]   = "";
            m_Row["HoTenMe"]        = "";
            m_Row["MaNNghiepMe"]    = "";
            m_HocSinhCtrl.ThemHocSinh(m_Row);
            bindingNavigatorHocSinh.BindingSource.MoveLast();
        }

        private void bindingNavigatorRefreshItem_Click(object sender, EventArgs e)
        {
            m_HocSinhCtrl.HienThi(dGVHocSinh, bindingNavigatorHocSinh, txtMaHocSinh, txtTenHocSinh, txtGioiTinh, ckbGTinhNam, ckbGTinhNu, dtpNgaySinh, txtNoiSinh, cmbDanToc, cmbTonGiao, txtHoTenCha, cmbNgheNghiepCha, txtHoTenMe, cmbNgheNghiepMe);
        }

        public Boolean KiemTraTruocKhiLuu(String cellString)
        {
            foreach (DataGridViewRow row in dGVHocSinh.Rows)
            {
                if (row.Cells[cellString].Value != null)
                {
                    String str = row.Cells[cellString].Value.ToString();
                    if (str == "")
                    {
                        MessageBoxEx.Show("Thông tin học sinh " + row.Cells["colHoTen"].Value.ToString() + " không hợp lệ!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }
            }
            return true;
        }

        public Boolean KiemTraDoTuoiTruocKhiLuu(String doTuoiColumn)
        {
            foreach (DataGridViewRow row in dGVHocSinh.Rows)
            {
                if (row.Cells[doTuoiColumn].Value != null)
                {
                    DateTime ngaySinh = Convert.ToDateTime(row.Cells[doTuoiColumn].Value.ToString());
                    
                    if (quyDinh.KiemTraDoTuoi(ngaySinh) == false)
                    {
                        MessageBoxEx.Show("Tuổi học sinh " + row.Cells["colHoTen"].Value.ToString() + " không đúng quy định!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }
            }
            return true;
        }

        private void bindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            if (KiemTraTruocKhiLuu("colMaHocSinh") == true &&
                KiemTraTruocKhiLuu("colHoTen") == true &&
                KiemTraTruocKhiLuu("colNoiSinh") == true &&
                KiemTraTruocKhiLuu("colMaDanToc") == true &&
                KiemTraTruocKhiLuu("colMaTonGiao") == true &&
                KiemTraTruocKhiLuu("colHoTenCha") == true &&
                KiemTraTruocKhiLuu("colMaNNghiepCha") == true &&
                KiemTraTruocKhiLuu("colHoTenMe") == true &&
                KiemTraTruocKhiLuu("colMaNNghiepMe") == true)
            {
                if (KiemTraDoTuoiTruocKhiLuu("colNgaySinh") == true)
                {
                    bindingNavigatorPositionItem.Focus();
                    m_HocSinhCtrl.LuuHocSinh();
                }
            }
        }
        #endregion

        #region DataError event
        private void dGVHocSinh_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }
        #endregion

        #region Tìm kiếm học sinh
        private void txtTimKiem_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                TimKiemHocSinh();
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            TimKiemHocSinh();
        }

        void TimKiemHocSinh()
        {
            if (chkTimTheoMa.Checked == true)
            {
                m_HocSinhCtrl.TimTheoMa(txtTimKiem.Text);
            }
            else
            {
                m_HocSinhCtrl.TimTheoTen(txtTimKiem.Text);
            }
        }
        #endregion

        #region Click event
        private void dGVHocSinh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (txtGioiTinh.Text == "True")
                ckbGTinhNu.Checked = true;
            else
                ckbGTinhNam.Checked = true;
        }

        private void btnThemDanToc_Click(object sender, EventArgs e)
        {
            ThamSo.ShowFormDanToc();
            m_DanTocCtrl.HienThiDataGridViewComboBoxColumn(colMaDanToc);
        }

        private void btnThemTonGiao_Click(object sender, EventArgs e)
        {
            ThamSo.ShowFormTonGiao();
            m_TonGiaoCtrl.HienThiDataGridViewComboBoxColumn(colMaTonGiao);
        }

        private void btnThemNNCha_Click(object sender, EventArgs e)
        {
            ThamSo.ShowFormNgheNghiep();
            m_NgheNghiepChaCtrl.HienThiDataGridViewComboBoxColumnNNCha(colMaNNghiepCha);
        }

        private void btnThemNNMe_Click(object sender, EventArgs e)
        {
            ThamSo.ShowFormNgheNghiep();
            m_NgheNghiepMeCtrl.HienThiDataGridViewComboBoxColumnNNMe(colMaNNghiepMe);
        }

        private void btnLuuVaoDS_Click(object sender, EventArgs e)
        {
            bool gioiTinh = false;
            if (ckbGTinhNu.Checked == true)
                gioiTinh = true;

            if (txtMaHocSinh.Text               != "" &&
                txtTenHocSinh.Text              != "" &&
                txtNoiSinh.Text                 != "" &&
                txtHoTenCha.Text                != "" &&
                txtHoTenMe.Text                 != "" &&
                dtpNgaySinh.Value               != null &&
                cmbDanToc.SelectedValue         != null &&
                cmbTonGiao.SelectedValue        != null &&
                cmbNgheNghiepCha.SelectedValue  != null &&
                cmbNgheNghiepMe.SelectedValue   != null)
            {
                if (quyDinh.KiemTraDoTuoi(dtpNgaySinh.Value) == true)
                {
                    m_HocSinhCtrl.LuuHocSinh(txtMaHocSinh.Text, txtTenHocSinh.Text, gioiTinh, dtpNgaySinh.Value, txtNoiSinh.Text, cmbDanToc.SelectedValue.ToString(), cmbTonGiao.SelectedValue.ToString(), txtHoTenCha.Text, cmbNgheNghiepCha.SelectedValue.ToString(), txtHoTenMe.Text, cmbNgheNghiepMe.SelectedValue.ToString());
                    m_HocSinhCtrl.HienThi(dGVHocSinh, bindingNavigatorHocSinh, txtMaHocSinh, txtTenHocSinh, txtGioiTinh, ckbGTinhNam, ckbGTinhNu, dtpNgaySinh, txtNoiSinh, cmbDanToc, cmbTonGiao, txtHoTenCha, cmbNgheNghiepCha, txtHoTenMe, cmbNgheNghiepMe);

                    bindingNavigatorHocSinh.BindingSource.MoveLast();
                }
                else
                    MessageBoxEx.Show("Tuổi của học sinh " + txtTenHocSinh.Text + " không hợp lệ!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBoxEx.Show("Giá trị của các ô không được rỗng!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        #endregion
    }
}