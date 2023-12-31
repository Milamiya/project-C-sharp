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
using BaoCaoThongKe.DataLayer;
using BaoCaoThongKe.Controller;

namespace BaoCaoThongKe.Desktop
{
    public partial class QL_DoanhNghiep : Office2007Form
    {
        QL_DoanhNghiep_Ctrl CTRL = new QL_DoanhNghiep_Ctrl();
        Xa_Phuong_Data x = new Xa_Phuong_Data();
        Huyen_Thi_Data huyen = new Huyen_Thi_Data();
        public QL_DoanhNghiep()
        {
            InitializeComponent();
        }

        private void QL_DoanhNghiep_Load(object sender, EventArgs e)
        {
            CTRL.DanhsachDoanhNghiep(gridControl1, bindingNavigator1, txtMaDoanhNghiep, txtTenDoanhNghiep, cmbHuyen, cmbXa, txtDiachi, txtDienThoai, txtFax, txtEmail, txtTrangWeb);

            gridView1.OptionsBehavior.Editable = false;

            Huyen_Thi_Ctrl ctrl_huyen = new Huyen_Thi_Ctrl();
            ctrl_huyen.ComboBoxHuyen(cmbHuyen);

            Xa_Phuong_CTrl ctrl_xa = new Xa_Phuong_CTrl();
            ctrl_xa.ComboBoxXa(cmbXa);

            
            this.repositoryItemLookUpEdit1.DataSource = huyen.HienThiDanhSachHuyen();
            this.repositoryItemLookUpEdit1.DisplayMember = "TenHuyen";
            this.repositoryItemLookUpEdit1.ValueMember = "MaHuyen";

            this.repositoryItemLookUpEdit2.DataSource = x.DanhSach_Xa_Phuong();
            this.repositoryItemLookUpEdit2.DisplayMember = "TenXa";
            this.repositoryItemLookUpEdit2.ValueMember = "MaXa";

            //to vang cot ma
            GridColumn unbColumn = gridView1.Columns["MaDoanhNghiep"];
            // Disable editing.
            unbColumn.OptionsColumn.AllowEdit = false;
            unbColumn.AppearanceCell.BackColor = Color.LemonChiffon;
        }

        private void BT_Them_Click(object sender, EventArgs e)
        {
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
            row["MaDoanhNghiep"] = ma;
            txtTenDoanhNghiep.Focus();
        }

        private void BT_Xoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn xóa không?", "Doanh nghiep", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                bindingNavigator1.BindingSource.RemoveCurrent();
                CTRL.Update();
            }
        }

        private void BT_Sua_Click(object sender, EventArgs e)
        {
            txtTenDoanhNghiep.Focus();
            txtDiachi.Focus();
            txtDienThoai.Focus();
            txtEmail.Focus();
        }

        private void BT_Luu_Click(object sender, EventArgs e)
        {
            if (CTRL.Kiemtra(txtTenDoanhNghiep, txtDiachi, txtDienThoai, txtFax, txtEmail, txtTrangWeb, cmbHuyen, cmbXa))
            {
                bindingNavigatorPositionItem.Focus();
                bindingNavigator1.BindingSource.MoveNext();
                CTRL.Update();
                BT_Them.Enabled = true;
                BT_Xoa.Enabled = true;
                BT_Sua.Enabled = true;
                //view.UpdateCurrentRow();
                //
                //int dong = gridView1.RowCount;

                //gridView1.Columns["colMaHuyen"].ToString();
            }
        }

        private void BT_Xemlai_Click(object sender, EventArgs e)
        {
            CTRL.DanhsachDoanhNghiep(gridControl1, bindingNavigator1, txtMaDoanhNghiep, txtTenDoanhNghiep, cmbHuyen, cmbXa, txtDiachi, txtDienThoai, txtFax, txtEmail, txtTrangWeb);
            gridControl1.RefreshDataSource();
            BT_Them.Enabled = true;
            BT_Sua.Enabled = true;
        }

        private void BT_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_themHuyen_Click(object sender, EventArgs e)
        {
            QL_Huyen_Thi h = new QL_Huyen_Thi();
            h.ShowDialog();
            Huyen_Thi_Ctrl pro = new Huyen_Thi_Ctrl();
            pro.ComboBoxHuyen(cmbHuyen);
        }

        private void btn_themXa_Click(object sender, EventArgs e)
        {
            QL_Xa_Phuong_ xa = new QL_Xa_Phuong_();
            xa.ShowDialog();
            Xa_Phuong_CTrl pro = new Xa_Phuong_CTrl();
            pro.ComboBoxXa(cmbXa);
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

        
    }
}