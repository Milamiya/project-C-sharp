using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using WeifenLuo.WinFormsUI.Docking;
using QuanLyHoSoCongChuc.BusinessObject;
using QuanLyHoSoCongChuc.Controller;
using QuanLyHoSoCongChuc.DataLayer;

namespace QuanLyHoSoCongChuc
{
    public partial class FrmKyLuat : DockContent
    {
        public FrmKyLuat()
        {
            InitializeComponent();
        }
        KyLuatControl m_KyLuatControl = new KyLuatControl();
        NhanVienControl m_NhanVienControl = new NhanVienControl();

        private void FrmKyLuat_Load(object sender, EventArgs e)
        {
            DataService.OpenConnection();
            m_KyLuatControl.HienThiTreeView(treeViewNhanVien);
        }
        private void dataGridViewDSKyLuat_RowsAdded(object sender, System.Windows.Forms.DataGridViewRowsAddedEventArgs e)
        {
            for (int i = 0; i < dataGridViewDSKyLuat.Rows.Count; i++)
            {
                dataGridViewDSKyLuat.Rows[i].Cells["STT"].Value = Convert.ToString(i + 1);
            }
        }
        private void treeViewNhanVien_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Node.Tag != null && ((string)e.Node.Tag) != "")
            {
                m_KyLuatControl.HienDSDT(dataGridViewDSKyLuat, (string)e.Node.Tag);

            }
        }

        private void ChucNang_Click(object sender, EventArgs e)
        {
            FrmChucNangKyLuat frm = new FrmChucNangKyLuat();
            frm.Show(DockPanel);

        }

        private void Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}