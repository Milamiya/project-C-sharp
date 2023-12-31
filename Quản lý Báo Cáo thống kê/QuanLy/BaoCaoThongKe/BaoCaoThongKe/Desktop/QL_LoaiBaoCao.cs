using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BaoCaoThongKe.BusinessObject;
using BaoCaoThongKe.DataLayer;
using BaoCaoThongKe.Controller;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using DevComponents.DotNetBar;

namespace BaoCaoThongKe.Desktop
{
    public partial class QL_LoaiBaoCao : Office2007Form
    {
        LoaiBaoCao_Ctrl CTRL = new LoaiBaoCao_Ctrl();

        public QL_LoaiBaoCao()
        {
            InitializeComponent();
        }

        private void QL_LoaiBaoCao_Load(object sender, EventArgs e)
        {
            CTRL.Show_LoaiBaoCao(bindingNavigator1,gridControl1);
            //
            gridView1.OptionsBehavior.Editable = false;
            //
            GridColumn gc = gridView1.Columns["MaLoaiBaoCao"];
            gc.OptionsColumn.AllowEdit = false;
            gc.AppearanceCell.BackColor = Color.LightSteelBlue;
        }

        private void BT_Them_Click(object sender, EventArgs e)
        {
            gridView1.OptionsBehavior.Editable = true;
            TangMaTuDong();
            BT_Them.Enabled = false;
        }

        private void BT_Xoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn Có Chắc Là Muốn Xóa Không?", "QL_LoaiBaoCao", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                bindingNavigator1.BindingSource.RemoveCurrent();
                CTRL.Update();
            }
        }

        private void BT_Sua_Click(object sender, EventArgs e)
        {
            gridView1.OptionsBehavior.Editable = true;
            gridView1.Focus();
            GridColumn gc = gridView1.Columns["TenLoaiBaoCao"];
            gc.OptionsColumn.AllowEdit = true;
        }

        private void BT_Luu_Click(object sender, EventArgs e)
        {
            bindingNavigatorPositionItem.Focus();
            bindingNavigator1.BindingSource.MoveNext();
            CTRL.Update();
            BT_Them.Enabled = true;
        }

        private void BT_XemLai_Click(object sender, EventArgs e)
        {
            CTRL.Show_LoaiBaoCao(bindingNavigator1, gridControl1);
        }

        private void BT_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void TangMaTuDong()
        {
            //tang ma
            int ma;

            int phantu = 0;
            int dong = gridView1.RowCount;

            for (int i = 1; i <= dong; i++)
            {
                phantu = i;
            }

            if (phantu != 0)
            {
                //ma = (phantu + 1);
                ma = CTRL.GetLastID() + 1;
            }
            else
            {
                ma = 1;
            }
            //
            DataRowView row = (DataRowView)bindingNavigator1.BindingSource.AddNew();
            row["MaLoaiBaoCao"] = ma;
        }

        private void gridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                if (MessageBox.Show("Delete Row?", "QL_LoaiBaoCao", MessageBoxButtons.YesNo) != DialogResult.Yes)
                    return;
                GridView view = sender as GridView;
                view.DeleteRow(view.FocusedRowHandle);
                CTRL.Update();
            }
            if (e.KeyCode == Keys.N && e.Modifiers == Keys.Control)
            {
                gridView1.OptionsBehavior.Editable = true;
                BT_Luu.Enabled = true;
                TangMaTuDong();
                BT_Them.Enabled = false;
            }
            if (e.KeyCode == Keys.S && e.Modifiers == Keys.Control)
            {
                bindingNavigatorPositionItem.Focus();
                CTRL.Update();
                BT_Them.Enabled = true;
            }
            if (e.KeyCode == Keys.F5)
            {
                BT_XemLai_Click(sender, e);
            }
        }

        private void gridView1_KeyPress(object sender, KeyPressEventArgs e)
        {
            bindingNavigatorPositionItem.Focus();
            bindingNavigator1.BindingSource.MoveNext();
            CTRL.Update();
            gridView1.OptionsBehavior.Editable = true;
            BT_Luu.Enabled = true;
            TangMaTuDong();
        }
    }
}