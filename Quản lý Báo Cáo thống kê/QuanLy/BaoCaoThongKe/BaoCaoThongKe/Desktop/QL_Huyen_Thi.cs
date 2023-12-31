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
using BaoCaoThongKe.Controller;
using BaoCaoThongKe.DataLayer;

namespace BaoCaoThongKe.Desktop
{
    public partial class QL_Huyen_Thi : Office2007Form
    {
        Huyen_Thi_Data DATA = new Huyen_Thi_Data();
        Huyen_Thi_Ctrl CTRL = new Huyen_Thi_Ctrl();
        public QL_Huyen_Thi()
        {
            InitializeComponent();
        }
        

        private void QL_Huyen_Thi_Load(object sender, EventArgs e)
        {
            CTRL.HienThiDanhSach_Huyen_Thi(bindingNavigator1,gridControl1);

            gridView1.OptionsBehavior.Editable = false;

            GridColumn gc = gridView1.Columns["MaHuyen"];
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
            row["MaHuyen"] = ma;
        }

        private void BT_Save_Click(object sender, EventArgs e)
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
            GridColumn gc = gridView1.Columns["TenHuyen"];
            gc.OptionsColumn.AllowEdit = true;
        }

        private void BT_Del_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn Có Chắc Là Muốn Xóa Không?", "QL_Huyện_Thị", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                bindingNavigator1.BindingSource.RemoveCurrent();
                CTRL.Update();
            }
        }

        private void BT_XemLai_Click(object sender, EventArgs e)
        {
            CTRL.HienThiDanhSach_Huyen_Thi(bindingNavigator1,gridControl1);
            BT_Add.Enabled = true;
            BT_Del.Enabled = true;
            BT_Edit.Enabled = true;
        }

        private void gridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                if (MessageBox.Show("Delete Row?", "QL_Huyen_Thi", MessageBoxButtons.YesNo) != DialogResult.Yes)
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
            BT_Save.Enabled = true;
            TangMaTuDong();
        }

        private void BT_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}