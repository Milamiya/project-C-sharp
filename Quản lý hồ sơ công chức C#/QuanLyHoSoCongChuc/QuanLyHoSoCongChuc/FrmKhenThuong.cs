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
    public partial class FrmKhenThuong: DockContent
    {
        public FrmKhenThuong()
        {
            InitializeComponent();
        }
        KhenThuongControl m_KhenThuongControl = new KhenThuongControl();
        NhanVienControl m_NhanVienControl = new NhanVienControl();

        private void FrmKhenThuong_Load(object sender, EventArgs e)
        {
            DataService.OpenConnection();
            m_KhenThuongControl.HienThiTreeView(treeViewNhanVien);
        }
        private void dataGridViewDSKhenThuong_RowsAdded(object sender, System.Windows.Forms.DataGridViewRowsAddedEventArgs e)
        {
            for (int i = 0; i < dataGridViewDSKhenThuong.Rows.Count; i++)
            {
                dataGridViewDSKhenThuong.Rows[i].Cells["STT"].Value = Convert.ToString(i + 1);
            }
        }
        private void treeViewNhanVien_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Node.Tag != null && ((string)e.Node.Tag) != "")
            {
                m_KhenThuongControl.HienDSDT(dataGridViewDSKhenThuong, (string)e.Node.Tag);

            }
        }

        private void ChucNang_Click(object sender, EventArgs e)
        {
            FrmChucNangKhenThuong frm = new FrmChucNangKhenThuong();
            frm.Show(DockPanel);

        }

        private void Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}