using System;
using System.Data;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
using QLHocSinhTHPT.Controller;
using QLHocSinhTHPT.Component;
using DevComponents.DotNetBar;
using System.Collections;

namespace QLHocSinhTHPT
{
    public partial class frmPhanLop : Office2007Form
    {
        #region Fields
        NamHocCtrl      m_NamHocCuCtrl      = new NamHocCtrl();
        NamHocCtrl      m_NamHocMoiCtrl     = new NamHocCtrl();
        KhoiLopCtrl     m_KhoiLopCuCtrl     = new KhoiLopCtrl();
        KhoiLopCtrl     m_KhoiLopMoiCtrl    = new KhoiLopCtrl();
        LopCtrl         m_LopCuCtrl         = new LopCtrl();
        LopCtrl         m_LopMoiCtrl        = new LopCtrl();
        HocSinhCtrl     m_HocSinhCtrl       = new HocSinhCtrl();
        #endregion

        #region Constructor
        public frmPhanLop()
        {
            InitializeComponent();
            DataService.OpenConnection();
        }
        #endregion

        #region Load
        private void frmPhanLop_Load(object sender, EventArgs e)
        {
            m_NamHocCuCtrl.HienThiComboBox(cmbNamHocCu);
            m_NamHocMoiCtrl.HienThiComboBox(cmbNamHocMoi);
            m_KhoiLopCuCtrl.HienThiComboBox(cmbKhoiLopCu);
        }
        #endregion

        #region Click event
        #region Chuyển lớp
        private void btnChuyen_Click(object sender, EventArgs e)
        {
            IEnumerator ie = lVLopCu.SelectedItems.GetEnumerator();
            while (ie.MoveNext())
            {
                ListViewItem olditem = (ListViewItem)ie.Current;
                ListViewItem newitem = new ListViewItem();
                
                //Trạng thái học sinh đã được chuyển lớp hay chưa?
                bool state = false; 
                
                foreach (ListViewItem item in lVLopMoi.Items)
                {
                    if (item.SubItems[0].Text == olditem.SubItems[0].Text)
                    {
                        MessageBoxEx.Show("Học sinh " + item.SubItems[1].Text + " hiện đang học trong lớp " + cmbLopMoi.Text, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        state = true;
                        goto Cont;
                    }
                }

                DataTable dT = new DataTable();
                if (cmbNamHocMoi.SelectedValue != null)
                {
                    dT = m_HocSinhCtrl.HienThiDsHocSinhTheoNamHoc(cmbNamHocMoi.SelectedValue.ToString());
                }

                foreach (DataRow row in dT.Rows)
                {
                    if (olditem.SubItems[0].Text.ToString() == row["MaHocSinh"].ToString())
                    {
                        MessageBoxEx.Show("Học sinh " + row["HoTen"].ToString() + " hiện đang học trong lớp " + row["TenLop"].ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        state = true;
                        goto Cont;
                    }
                }

                newitem.SubItems.Add(olditem.SubItems[1].Text);
                newitem.Tag = olditem.Tag;
                
                lVLopMoi.Items.Add(newitem);
                lVLopMoi.Items[lVLopMoi.Items.IndexOf(newitem)].Text = olditem.SubItems[0].Text;
                lVLopCu.Items.Remove(olditem);
                
                Cont:
                if (state == true)
                    break;
            }
        }
        #endregion

        #region Xóa học sinh khỏi lớp mới
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBoxEx.Show("Bạn có muốn xóa học sinh này khỏi lớp mới không?", "DELETE", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                IEnumerator ie = lVLopMoi.SelectedItems.GetEnumerator();
                while (ie.MoveNext())
                {
                    ListViewItem item = (ListViewItem)ie.Current;
                    lVLopMoi.Items.Remove(item);
                }
            }
        }
        #endregion

        #region Lưu vào bảng PHANLOP
        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (cmbNamHocCu.SelectedValue   != null &&
                cmbKhoiLopCu.SelectedValue  != null &&
                cmbLopCu.SelectedValue      != null &&
                cmbNamHocMoi.SelectedValue  != null &&
                cmbKhoiLopMoi.SelectedValue != null &&
                cmbLopMoi.SelectedValue     != null)
            {
                m_HocSinhCtrl.XoaHSKhoiBangPhanLop(cmbNamHocCu.SelectedValue.ToString(),
                                                   cmbKhoiLopCu.SelectedValue.ToString(),
                                                   cmbLopCu.SelectedValue.ToString(),
                                                   lVLopMoi);
                m_HocSinhCtrl.LuuHSVaoBangPhanLop(cmbNamHocMoi.SelectedValue.ToString(),
                                                  cmbKhoiLopMoi.SelectedValue.ToString(),
                                                  cmbLopMoi.SelectedValue.ToString(),
                                                  lVLopMoi);

                MessageBoxEx.Show("Đã lưu vào bảng phân lớp!", "COMPLETED", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBoxEx.Show("Giá trị của các ô không được rỗng!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        #endregion

        #region Đóng form phân lớp
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
        #endregion

        #region SelectedIndexChanged event
        private void cmbNamHocCu_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbKhoiLopCu.DataBindings.Clear();
            cmbLopCu.DataBindings.Clear();
        }

        private void cmbNamHocMoi_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbKhoiLopMoi.DataBindings.Clear();
            cmbLopMoi.DataBindings.Clear();
        }

        private void cmbKhoiLopCu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbNamHocCu.SelectedValue != null && cmbKhoiLopCu.SelectedValue != null)
            {
                m_LopCuCtrl.HienThiComboBox(cmbKhoiLopCu.SelectedValue.ToString(), cmbNamHocCu.SelectedValue.ToString(), cmbLopCu);
                m_KhoiLopMoiCtrl.HienThiComboBox(cmbKhoiLopCu.SelectedValue.ToString(), cmbKhoiLopMoi);
                
                cmbLopCu.DataBindings.Clear();
                lVLopCu.Items.Clear();
            }
        }

        private void cmbKhoiLopMoi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbNamHocMoi.SelectedValue != null && cmbKhoiLopMoi.SelectedValue != null)
            {
                m_LopMoiCtrl.HienThiComboBox(cmbKhoiLopMoi.SelectedValue.ToString(), cmbNamHocMoi.SelectedValue.ToString(), cmbLopMoi);
                
                cmbLopMoi.DataBindings.Clear();
                lVLopMoi.Items.Clear();
            }
        }

        private void cmbLopCu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbLopCu.SelectedValue != null && cmbNamHocCu.SelectedValue != null && cmbKhoiLopCu.SelectedValue != null)
                m_HocSinhCtrl.HienThiDsHocSinhTheoLop(cmbNamHocCu.SelectedValue.ToString(), cmbKhoiLopCu.SelectedValue.ToString(), cmbLopCu.SelectedValue.ToString(), lVLopCu);
        }

        private void cmbLopMoi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbLopMoi.SelectedValue != null && cmbNamHocMoi.SelectedValue != null && cmbKhoiLopMoi.SelectedValue != null)
                m_HocSinhCtrl.HienThiDsHocSinhTheoLop(cmbNamHocMoi.SelectedValue.ToString(), cmbKhoiLopMoi.SelectedValue.ToString(), cmbLopMoi.SelectedValue.ToString(), lVLopMoi);
        }
        #endregion
    }
}