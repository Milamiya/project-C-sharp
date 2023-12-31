using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using BaoCaoThongKe.Controller;
using BaoCaoThongKe.DataLayer;
using DevComponents.DotNetBar;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Columns;


namespace BaoCaoThongKe.Desktop
{
    public partial class QL_Xa_Phuong_ : Office2007Form
    {
        public QL_Xa_Phuong_()
        {
            InitializeComponent();
        }

        Xa_Phuong_CTrl CTRL = new Xa_Phuong_CTrl();
        Huyen_Thi_Data huyen = new Huyen_Thi_Data();
        private void QL_Xa_Phuong__Load(object sender, EventArgs e)
        {
            CTRL.Show_DS_Xa_Phuong(bindingNavigator1,gridControl1);

            //enable luoi
            gridView1.OptionsBehavior.Editable = false;
            //comboxluoi huyen
            this.repositoryItemLookUpEdit1.DataSource = huyen.HienThiDanhSachHuyen();
            this.repositoryItemLookUpEdit1.DisplayMember = "TenHuyen";
            this.repositoryItemLookUpEdit1.ValueMember = "MaHuyen";

            //to vang cot ma
            GridColumn unbColumn = gridView1.Columns["MaXa"];
            // Disable editing.
            unbColumn.OptionsColumn.AllowEdit = false;
            unbColumn.AppearanceCell.BackColor = Color.LemonChiffon;

        }

        private void BT_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BT_Them_Click(object sender, EventArgs e)
        {
            //enable luoi
            gridView1.OptionsBehavior.Editable = true;
            TangMaTuDong();
            BT_Them.Enabled = false;
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
            row["MaXa"] = ma;
        }

        private void BT_Xoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn xóa không?", "Xa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                bindingNavigator1.BindingSource.RemoveCurrent();
                CTRL.Update();
            }
        }

        private void BT_Sua_Click(object sender, EventArgs e)
        {
            //
            gridView1.OptionsBehavior.Editable = true;
            //
            gridView1.Focus();
            GridColumn gc = gridView1.Columns["TenXa"];
            gc.OptionsColumn.AllowEdit = true;
        }

        private void BT_Save_Click(object sender, EventArgs e)
        {
            bindingNavigatorPositionItem.Focus();
            bindingNavigator1.BindingSource.MoveNext();
            CTRL.Update();
            BT_Them.Enabled = true;
        }

        private void BT_Xemlai_Click(object sender, EventArgs e)
        {
            CTRL.Show_DS_Xa_Phuong(bindingNavigator1, gridControl1);
            BT_Them.Enabled = true;
        }

        private void gridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                if (MessageBox.Show("Bạn có chắc chắn xóa không?", "Quan ly Xa phuong!", MessageBoxButtons.YesNo) != DialogResult.Yes)
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
                BT_Xemlai_Click(sender, e);
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