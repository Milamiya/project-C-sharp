using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraGrid;
using DevComponents.DotNetBar.Controls;
using DevComponents.DotNetBar;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraEditors.DXErrorProvider;
using DevExpress.XtraEditors.Controls;

using BaoCaoThongKe.BusinessObject;
using BaoCaoThongKe.DataLayer;
using BaoCaoThongKe.Controller;

namespace BaoCaoThongKe.Desktop
{
    public partial class QL_DonViTinh : Office2007Form
    {
        DonViTinh_Ctrl CTRL = new DonViTinh_Ctrl();
        public QL_DonViTinh()
        {
            InitializeComponent();
        }
        int maso;
        private void QL_DonViTinh_Load(object sender, EventArgs e)
        {
            CTRL.DanhsachDonViTinh(gridControl1, bindingNavigator1);

            gridView1.OptionsBehavior.Editable = false;
 
            //to vang cot ma
            GridColumn unbColumn = gridView1.Columns["MaDonViTinh"];
            // Disable editing.
            unbColumn.OptionsColumn.AllowEdit = false;
            unbColumn.AppearanceCell.BackColor = Color.LemonChiffon;

        }

        private void BT_XemLai_Click(object sender, EventArgs e)
        {
            CTRL.DanhsachDonViTinh(gridControl1, bindingNavigator1);
            BT_Add.Enabled = true;
        }

        private void BT_Add_Click(object sender, EventArgs e)
        {
            DonViTinh_Ctrl dvCTRL = new DonViTinh_Ctrl();
            gridView1.OptionsBehavior.Editable = true;
            //tang ma
            maso = dvCTRL.GetLastID() + 1;
            DataRowView row = (DataRowView)bindingNavigator1.BindingSource.AddNew();
            row["MaDonViTinh"] = maso;
            BT_Add.Enabled = false;
        }
        

        private void BT_save_Click(object sender, EventArgs e)
        {
            bindingNavigatorPositionItem.Focus();
            bindingNavigator1.BindingSource.MoveNext();
            CTRL.Update();
            BT_Add.Enabled = true;
        }

        private void BT_Edit_Click(object sender, EventArgs e)
        {
            gridView1.OptionsBehavior.Editable = true;
            gridView1.Focus();
            GridColumn gc = gridView1.Columns["TenDonViTinh"];
            gc.OptionsColumn.AllowEdit = true;
        }

        private void BT_Del_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn xóa không?", "Don vi tinh", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                bindingNavigator1.BindingSource.RemoveCurrent();
                CTRL.Update();
            }
        }

        private void BT_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                if (MessageBox.Show("Bạn có chắc chắn xóa không?", "Quan ly Tieu Don vi tinh", MessageBoxButtons.YesNo) != DialogResult.Yes)
                    return;
                GridView view = sender as GridView;
                view.DeleteRow(view.FocusedRowHandle);
                CTRL.Update();
            }
            if (e.KeyCode == Keys.N && e.Modifiers == Keys.Control)
            {
                gridView1.OptionsBehavior.Editable = true;
                BT_save.Enabled = true;
                //tang ma
                maso = CTRL.GetLastID() + 1;
                DataRowView row = (DataRowView)bindingNavigator1.BindingSource.AddNew();
                row["MaDonViTinh"] = maso;
                BT_Add.Enabled = false;
                
            }
            if (e.KeyCode == Keys.S && e.Modifiers == Keys.Control)
            {
                bindingNavigatorPositionItem.Focus();
                CTRL.Update();
                BT_Add.Enabled = true;
            }
            if (e.KeyCode == Keys.F5)
            {
                BT_XemLai_Click(sender, e);
            }
        }

        //private void gridView1_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    bindingNavigatorPositionItem.Focus();
        //    bindingNavigator1.BindingSource.MoveNext();
        //    CTRL.Update();
        //    gridView1.OptionsBehavior.Editable = true;
        //    BT_save.Enabled = true;
        //    //tang ma
        //    maso = CTRL.GetLastID() + 1;
        //    DataRowView row = (DataRowView)bindingNavigator1.BindingSource.AddNew();
        //    row["MaDonViTinh"] = maso;
        //    //BT_Add.Enabled = false;
        //}

    }
}