using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraEditors.DXErrorProvider;
using DevExpress.XtraEditors.Controls;
using BaoCaoThongKe.DataLayer;
using BaoCaoThongKe.Controller;

namespace BaoCaoThongKe.Desktop
{
    public partial class QL_DuAn : Office2007Form
    {
        DuAn_Ctrl CTRL = new DuAn_Ctrl();
        QL_DoanhNghiep_Data DN = new QL_DoanhNghiep_Data();
        LoaiDuAn_Data LDA = new LoaiDuAn_Data();
        public QL_DuAn()
        {
            InitializeComponent();
        }

        private void QL_DuAn_Load(object sender, EventArgs e)
        {
            CTRL.DanhsachDuAn(gridControl1, bindingNavigator1);

            gridView1.OptionsBehavior.Editable = false;

            this.repositoryItemLookUpEdit1.DataSource = LDA.Show_DS_LoaiDuAn();
            this.repositoryItemLookUpEdit1.DisplayMember = "TenLoaiDuAn";
            this.repositoryItemLookUpEdit1.ValueMember = "MaLoaiDuAn";

            this.repositoryItemLookUpEdit2.DataSource = DN.Show_DoanhNghiep();
            this.repositoryItemLookUpEdit2.DisplayMember = "TenDoanhNghiep";
            this.repositoryItemLookUpEdit2.ValueMember = "MaDoanhNghiep";

            //to vang cot ma
            GridColumn unbColumn = gridView1.Columns["MaDuAn"];
            // Disable editing.
            unbColumn.OptionsColumn.AllowEdit = false;
            unbColumn.AppearanceCell.BackColor = Color.LemonChiffon;
        }

        

        private void BT_Add_Click(object sender, EventArgs e)
        {
            //enable luoi len
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
            row["MaDuAn"] = ma;
        }

        private void BT_Del_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn xóa không?", "Du an", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                bindingNavigator1.BindingSource.RemoveCurrent();
                CTRL.Update();
            }
        }

        private void BT_Edit_Click(object sender, EventArgs e)
        {
            //enable luoi len
            gridView1.OptionsBehavior.Editable = true;
            //
        }

        private void BT_save_Click(object sender, EventArgs e)
        {
            bindingNavigatorPositionItem.Focus();
            bindingNavigator1.BindingSource.MoveNext();
            CTRL.Update();
            BT_Add.Enabled = true;
        }

        private void BT_XemLai_Click(object sender, EventArgs e)
        {
            CTRL.DanhsachDuAn(gridControl1, bindingNavigator1);
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
                if (MessageBox.Show("Delete row?", "Du an", MessageBoxButtons.YesNo) !=
                  DialogResult.Yes)
                    return;
                GridView view = sender as GridView;
                view.DeleteRow(view.FocusedRowHandle);
                CTRL.Update();
            }
            if (e.KeyCode == Keys.N && e.Modifiers == Keys.Control)
            {
                gridView1.OptionsBehavior.Editable = true;
                TangMaTuDong();
                BT_Add.Enabled = false;
            }
            if (e.KeyCode == Keys.S && e.Modifiers == Keys.Control)
            {
                bindingNavigatorPositionItem.Focus();
                CTRL.Update();
                BT_Add.Enabled = true;
            }
            if (e.KeyCode == Keys.E && e.Modifiers == Keys.Control)
            {
                gridView1.OptionsBehavior.Editable = true;
            }
            if (e.KeyCode == Keys.F5)
            {
                BT_XemLai_Click(sender, e);
                BT_Add.Enabled = true;
            }
        }
    }
}