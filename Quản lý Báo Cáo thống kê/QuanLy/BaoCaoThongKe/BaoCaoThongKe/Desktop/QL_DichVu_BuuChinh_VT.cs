using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar.Controls;
using DevComponents.DotNetBar;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraEditors.DXErrorProvider;
using DevExpress.XtraEditors.Controls;
using BaoCaoThongKe.Controller;
using BaoCaoThongKe.DataLayer;

namespace BaoCaoThongKe.Desktop
{
    public partial class QL_DichVu_BuuChinh_VT : Office2007Form
    {
        DichVuBuuChinhVT_Ctrl CTRL = new DichVuBuuChinhVT_Ctrl();
        QL_DoanhNghiep_Data DNdata = new QL_DoanhNghiep_Data();
        public QL_DichVu_BuuChinh_VT()
        {
            InitializeComponent();
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
            row["MaDichVuBuuChinhVT"] = ma;
        }

        private void QL_DichVu_BuuChinh_VT_Load(object sender, EventArgs e)
        {
            CTRL.DanhsachDichVuBuuChinhVT(gridControl1, bindingNavigator1);

            gridView1.OptionsBehavior.Editable = false;

            this.repositoryItemLookUpEdit1.DataSource = DNdata.Show_DoanhNghiep();
            this.repositoryItemLookUpEdit1.DisplayMember = "TenDoanhNghiep";
            this.repositoryItemLookUpEdit1.ValueMember = "MaDoanhNghiep";

            //to vang cot ma
            GridColumn unbColumn = gridView1.Columns["MaDichVuBuuChinhVT"];
            // Disable editing.
            unbColumn.OptionsColumn.AllowEdit = false;
            unbColumn.AppearanceCell.BackColor = Color.LemonChiffon;
        }

        private void BT_Del_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn xóa không?", "Dich vu buu chinh Vien thong!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                bindingNavigator1.BindingSource.RemoveCurrent();
                CTRL.Update();
            }
        }

        private void BT_Edit_Click(object sender, EventArgs e)
        {
            //
            gridView1.OptionsBehavior.Editable = true;
            //
            gridView1.Focus();
            GridColumn gc = gridView1.Columns["TenDichVuBuuChinhVT"];
            gc.OptionsColumn.AllowEdit = true;
        }

        private void BT_Save_Click(object sender, EventArgs e)
        {
            bindingNavigatorPositionItem.Focus();
            bindingNavigator1.BindingSource.MoveNext();

            BT_Add.Enabled = true;


        }

        private void BT_Refresh_Click(object sender, EventArgs e)
        {
            CTRL.DanhsachDichVuBuuChinhVT(gridControl1, bindingNavigator1);
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
                if (MessageBox.Show("Bạn có chắc chắn xóa không?", "Quan ly Dich vu buu chinh vien thong!", MessageBoxButtons.YesNo) != DialogResult.Yes)
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
                BT_Save_Click(sender, e);
                BT_Add.Enabled = true;
            }
            if (e.KeyCode == Keys.F5)
            {
                BT_Refresh_Click(sender, e);
            }
        }

        private void gridView1_KeyPress(object sender, KeyPressEventArgs e)
        {
            //bindingNavigatorPositionItem.Focus();
            //bindingNavigator1.BindingSource.MoveNext();
            ////CTRL.Update();
            //gridView1.OptionsBehavior.Editable = true;
            //BT_Save.Enabled = true;
            //TangMaTuDong();
        }
    }
}