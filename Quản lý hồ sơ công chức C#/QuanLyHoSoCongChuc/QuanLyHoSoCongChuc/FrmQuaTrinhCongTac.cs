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
    public partial class FrmQuaTrinhCongTac : DockContent
    {
        public FrmQuaTrinhCongTac()
        {
            InitializeComponent();
        }
        QuaTrinhCongTacControl m_QTCTCtrl = new QuaTrinhCongTacControl();

        private void FrmQuaTrinhCongTac_Load(object sender, EventArgs e)
        {
            DataService.OpenConnection();
            m_QTCTCtrl.HienThiTreeView(treeViewNhanVien);

        }
        private void dataGridViewDSQTCT_RowsAdded(object sender, System.Windows.Forms.DataGridViewRowsAddedEventArgs e)
        {
            for (int i = 0; i < dataGridViewDSQTCT.Rows.Count; i++)
            {
                dataGridViewDSQTCT.Rows[i].Cells["STT"].Value = Convert.ToString(i + 1);
            }
        }
        private void treeViewNhanVien_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Node.Tag != null && ((string)e.Node.Tag) != "")
            {
                m_QTCTCtrl.HienDSCT(dataGridViewDSQTCT, (string)e.Node.Tag);

            }
        }

        private void Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ChucNang_Click(object sender, EventArgs e)
        {
            FrmChucNangQTCT frm = new FrmChucNangQTCT();
            frm.Show(DockPanel);
        }

    }
}