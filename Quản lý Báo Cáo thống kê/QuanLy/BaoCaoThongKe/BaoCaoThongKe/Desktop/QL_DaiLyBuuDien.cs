using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraEditors.DXErrorProvider;
using DevExpress.XtraEditors.Controls;
using DevComponents.DotNetBar;

using BaoCaoThongKe.Controller;
using BaoCaoThongKe.DataLayer;

namespace BaoCaoThongKe.Desktop
{
    public partial class QL_DaiLyBuuDien : Office2007Form
    {
        DaiLyBuuDien_Ctrl CTRL = new DaiLyBuuDien_Ctrl();
        Xa_Phuong_Data xa = new Xa_Phuong_Data();
        Huyen_Thi_Data huyen = new Huyen_Thi_Data();
        QL_DoanhNghiep_Data dn = new QL_DoanhNghiep_Data();

        public QL_DaiLyBuuDien()
        {
            InitializeComponent();
        }

        private void QL_DaiLyBuuDien_Load(object sender, EventArgs e)
        {
            CTRL.DanhsachDaiLyBuuDien(gridControl1, bindingNavigator1, txtMaDaiLyBuuDien, txtTenDLBD, cmbHuyen, cmbXa, comDoanhNghiep, txtDiachi);

            gridView1.OptionsBehavior.Editable = false;

            Huyen_Thi_Ctrl ctrl_huyen = new Huyen_Thi_Ctrl();
            ctrl_huyen.ComboBoxHuyen(cmbHuyen);

            Xa_Phuong_CTrl ctrl_xa = new Xa_Phuong_CTrl();
            ctrl_xa.ComboBoxXa(cmbXa);

            QL_DoanhNghiep_Ctrl ctrl_dn = new QL_DoanhNghiep_Ctrl();
            ctrl_dn.ComboBoxDN(comDoanhNghiep);

            this.repositoryItemLookUpEdit1.DataSource = huyen.HienThiDanhSachHuyen();
            this.repositoryItemLookUpEdit1.DisplayMember = "TenHuyen";
            this.repositoryItemLookUpEdit1.ValueMember = "MaHuyen";

            this.repositoryItemLookUpEdit2.DataSource = xa.DanhSach_Xa_Phuong();
            this.repositoryItemLookUpEdit2.DisplayMember = "TenXa";
            this.repositoryItemLookUpEdit2.ValueMember = "MaXa";

            this.repositoryItemLookUpEdit3.DataSource = dn.Show_DoanhNghiep();
            this.repositoryItemLookUpEdit3.DisplayMember = "TenDoanhNghiep";
            this.repositoryItemLookUpEdit3.ValueMember = "MaDoanhNghiep";

            //to vang cot ma
            GridColumn unbColumn = gridView1.Columns["MaDaiLyBuuDien"];
            // Disable editing.
            unbColumn.OptionsColumn.AllowEdit = false;
            unbColumn.AppearanceCell.BackColor = Color.LemonChiffon;
        }

        private void BT_Them_Click(object sender, EventArgs e)
        {
            TangMaTuDong();
            BT_Them.Enabled = true;
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
            row["MaDaiLyBuuDien"] = ma;
            txtTenDLBD.Focus();
        }

        private void BT_Xoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn xóa không?", "Dai ly Buu dien", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                bindingNavigator1.BindingSource.RemoveCurrent();
                CTRL.Update();
            }
        }

        private void BT_Sua_Click(object sender, EventArgs e)
        {
            txtTenDLBD.Focus();
        }

        private void BT_Luu_Click(object sender, EventArgs e)
        {
            if (CTRL.Kiemtra(txtTenDLBD, cmbHuyen, cmbXa, txtDiachi, comDoanhNghiep))
            {
                bindingNavigatorPositionItem.Focus();
                bindingNavigator1.BindingSource.MoveNext();
                CTRL.Update();
                BT_Them.Enabled = true;
            }
        }

        private void BT_Reset_Click(object sender, EventArgs e)
        {
            CTRL.DanhsachDaiLyBuuDien(gridControl1, bindingNavigator1, txtMaDaiLyBuuDien, txtTenDLBD, cmbHuyen, cmbXa, comDoanhNghiep, txtDiachi);
            gridControl1.RefreshDataSource();
            BT_Them.Enabled = true;
        }

        private void BT_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_themHuyen_Click(object sender, EventArgs e)
        {
            QL_Huyen_Thi Huyen = null;
            if (Huyen == null || Huyen.IsDisposed)
            {
                Huyen = new QL_Huyen_Thi();
                Huyen.Show();
                Huyen.Focus();
            }
        }

        private void btnThemDn_Click(object sender, EventArgs e)
        {
            QL_DoanhNghiep DN = null;
            if (DN == null || DN.IsDisposed)
            {
                DN = new QL_DoanhNghiep();
                DN.Show();
                DN.Focus();
            }
        }

        private void btnThemXa_Click(object sender, EventArgs e)
        {
            QL_Xa_Phuong_ Xa = null;
            if (Xa == null || Xa.IsDisposed)
            {
                Xa = new QL_Xa_Phuong_();
                Xa.Show();
                Xa.Focus();
            }
        }

        private void cmbHuyen_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Xa_Phuong_CTrl ctrl_xa = new Xa_Phuong_CTrl();
            ctrl_xa.ListXa(cmbXa, Convert.ToInt32(cmbHuyen.SelectedValue));
        }

        private void cmbXa_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Xa_Phuong_CTrl ctrl = new Xa_Phuong_CTrl();
                cmbHuyen.SelectedValue = ctrl.LayMaHuyen(cmbXa.SelectedValue.ToString());
            }
            catch
            {
            } 
        }

        //

    }
}