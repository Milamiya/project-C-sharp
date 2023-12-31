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
using DevComponents.DotNetBar;
using BaoCaoThongKe.Controller;
using BaoCaoThongKe.DataLayer;
namespace BaoCaoThongKe.Desktop
{
    public partial class QL_CongTrinhVienThong : Office2007Form
    {
        CongTrinhVienThong_Ctrl CTRL = new CongTrinhVienThong_Ctrl();
        LoaiCongTrinh_Data ctrinh = new LoaiCongTrinh_Data();
        QL_DoanhNghiep_Data dn = new QL_DoanhNghiep_Data();
        public QL_CongTrinhVienThong()
        {
            InitializeComponent();
        }

        private void QL_CongTrinhVienThong_Load(object sender, EventArgs e)
        {
            CTRL.DanhsachCongTrinhVienThong(gridControl1, bindingNavigator1);

            this.repositoryItemLookUpEdit1.DataSource = ctrinh.Show_LoaiCongTrinh();
            this.repositoryItemLookUpEdit1.DisplayMember = "TenLoaiCongTrinh";
            this.repositoryItemLookUpEdit1.ValueMember = "MaLoaiCongTrinh";

            this.repositoryItemLookUpEdit2.DataSource = dn.Show_DoanhNghiep();
            this.repositoryItemLookUpEdit2.DisplayMember = "TenDoanhNghiep";
            this.repositoryItemLookUpEdit2.ValueMember = "MaDoanhNghiep";
            //khoa luoi
            gridView1.OptionsBehavior.Editable = false;


            //to vang cot ma
            GridColumn unbColumn = gridView1.Columns["MaCongTrinh"];
            // Disable editing.
            unbColumn.OptionsColumn.AllowEdit = false;
            unbColumn.AppearanceCell.BackColor = Color.LemonChiffon;
        }

        private void BT_Them_Click(object sender, EventArgs e)
        {
            gridView1.OptionsBehavior.Editable = true;
            //"
            //tang ma
            int maso = CTRL.GetLastID() + 1;
            DataRowView row = (DataRowView)bindingNavigator1.BindingSource.AddNew();
            row["MaCongTrinh"] = maso;
            BT_Them.Enabled = false;
        }
        

        private void BT_Xoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn xóa không?", "Cong trinh vien thong", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
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
            GridColumn gc = gridView1.Columns["TenCongTrinh"];
            gc.OptionsColumn.AllowEdit = true;
            
        }

        private void BT_Luu_Click(object sender, EventArgs e)
        {
            //if (gridView1.Columns["MaLoaiCongTrinh"].AppearanceCell == true)
            //{

                bindingNavigatorPositionItem.Focus();
                bindingNavigator1.BindingSource.MoveNext();
                CTRL.Update();
                BT_Them.Enabled = true;
                //gridView1.Columns["MaLoaiCongTrinh"].ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowForFocusedCell;
        }

        private void BT_Reset_Click(object sender, EventArgs e)
        {
            CTRL.DanhsachCongTrinhVienThong(gridControl1, bindingNavigator1);
            BT_Them.Enabled = true;
        }

        private void BT_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                if (MessageBox.Show("Bạn có chắc chắn xóa không?", "Cong trinh vien thong", MessageBoxButtons.YesNo) != DialogResult.Yes)
                    return;
                GridView view = sender as GridView;
                view.DeleteRow(view.FocusedRowHandle);
                CTRL.Update();
            }
            if (e.KeyCode == Keys.N && e.Modifiers == Keys.Control)
            {
                gridView1.OptionsBehavior.Editable = true;
                BT_Luu.Enabled = true;
                //tang ma
                int maso = CTRL.GetLastID() + 1;
                DataRowView row = (DataRowView)bindingNavigator1.BindingSource.AddNew();
                row["MaCongTrinh"] = maso;
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
                BT_Reset_Click(sender, e);
            }
        }

        private void gridView1_KeyPress(object sender, KeyPressEventArgs e)
        {
            bindingNavigatorPositionItem.Focus();
            bindingNavigator1.BindingSource.MoveNext();
            CTRL.Update();
            gridView1.OptionsBehavior.Editable = true;
            BT_Luu.Enabled = true;
            //tang ma
            int maso = CTRL.GetLastID() + 1;
            DataRowView row = (DataRowView)bindingNavigator1.BindingSource.AddNew();
            row["MaCongTrinh"] = maso;
            BT_Them.Enabled = false;
        }

    }
}