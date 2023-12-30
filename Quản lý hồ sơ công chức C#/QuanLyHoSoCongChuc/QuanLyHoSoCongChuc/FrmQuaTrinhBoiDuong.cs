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
    public partial class FrmQuaTrinhBoiDuong : DockContent
    {
        public FrmQuaTrinhBoiDuong()
        {
            InitializeComponent();
        }
        QuaTrinhBoiDuongControl m_QTBDControl = new QuaTrinhBoiDuongControl();
        NhanVienControl m_NhanVienControl = new NhanVienControl();
        private void FrmQuaTrinhDaoTao_Load(object sender, EventArgs e)
        {
            DataService.OpenConnection();
            m_QTBDControl.HienThiTreeView(treeViewNhanVien);


        }
        private void dataGridViewDSQTBD_RowsAdded(object sender, System.Windows.Forms.DataGridViewRowsAddedEventArgs e)
        {
            for (int i = 0; i < dataGridViewDSQTBD.Rows.Count; i++)
            {
                dataGridViewDSQTBD.Rows[i].Cells["STT"].Value = Convert.ToString(i + 1);
            }
        }
        private void treeViewNhanVien_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Node.Tag != null && ((string)e.Node.Tag) != "")
            {
                m_QTBDControl.HienDSDT(dataGridViewDSQTBD, (string)e.Node.Tag);

            }
        }

        private void ChucNang_Click(object sender, EventArgs e)
        {
            FrmChucNangQTBD frm = new FrmChucNangQTBD();
            frm.Show(DockPanel);

        }

        private void Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}