using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using DevComponents.DotNetBar.Controls;
using DevComponents.DotNetBar;
using BaoCaoThongKe.DataLayer;
using BaoCaoThongKe.Controller;
using BaoCaoThongKe.BusinessObject;

namespace BaoCaoThongKe.Desktop
{
    public partial class QL_NhomThueBao : Office2007Form
    {
        NhomThueBao_Ctrl CTRL = new NhomThueBao_Ctrl();
        public QL_NhomThueBao()
        {
            InitializeComponent();
        }

        private void QL_NhomThueBao_Load(object sender, EventArgs e)
        {
            CTRL.HienThi_NhomThueBao(bindingNavigator1,gridControl1);

            //
            gridView1.OptionsBehavior.Editable = false;
            //
            GridColumn gc = gridView1.Columns["MaThueBao"];
            gc.OptionsColumn.AllowEdit = false;
            gc.AppearanceCell.BackColor = Color.LemonChiffon;
        }

        private void BT_Add_Click(object sender, EventArgs e)
        {
            //enable luoi
            gridView1.OptionsBehavior.Editable = true;
            TangMaTuDong();
            BT_Add.Enabled = false;
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
            row["MaThueBao"] = ma;
        }

        private void BT_Del_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn Có Chắc Là Muốn Xóa Không?", "Quan ly Nhom thue bao", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                bindingNavigator1.BindingSource.RemoveCurrent();
                CTRL.Update();
            }
        }

        private void BT_Edit_Click(object sender, EventArgs e)
        {
            gridView1.OptionsBehavior.Editable = true;
            gridView1.Focus();
            GridColumn gc = gridView1.Columns["TenThueBao"];
            gc.OptionsColumn.AllowEdit = true;
        }

        private void BT_Save_Click(object sender, EventArgs e)
        {
            bindingNavigatorPositionItem.Focus();
            bindingNavigator1.BindingSource.MoveNext();
            CTRL.Update();
            BT_Add.Enabled = true;
        }

        private void BT_Refresh_Click(object sender, EventArgs e)
        {
            CTRL.HienThi_NhomThueBao(bindingNavigator1, gridControl1);
            BT_Add.Enabled = true;
        }

        private void BT_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                if (MessageBox.Show("Delete Row?", "Quan ly Nhom thue bao", MessageBoxButtons.YesNo) != DialogResult.Yes)
                    return;
                GridView view = sender as GridView;
                view.DeleteRow(view.FocusedRowHandle);
                CTRL.Update();
            }
            if (e.KeyCode == Keys.N && e.Modifiers == Keys.Control)
            {
                gridView1.OptionsBehavior.Editable = true;
                BT_Save.Enabled = true;
                TangMaTuDong();
                BT_Add.Enabled = false;
            }
            if (e.KeyCode == Keys.S && e.Modifiers == Keys.Control)
            {
                bindingNavigatorPositionItem.Focus();
                CTRL.Update();
                BT_Add.Enabled = true;
            }
            if (e.KeyCode==Keys.F5) 
            {
                BT_Refresh_Click(sender, e);
            }
        }

        private void gridView1_KeyPress(object sender, KeyPressEventArgs e)
        {
            bindingNavigatorPositionItem.Focus();
            bindingNavigator1.BindingSource.MoveNext();
            CTRL.Update();
            gridView1.OptionsBehavior.Editable = true;
            BT_Save.Enabled = true;
            TangMaTuDong();
        }
    }
}