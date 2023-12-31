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
    public partial class QL_DaiLyBuuDienVHX : Office2007Form
    {
        DaiLyBuuDienVHX_Ctrl CTRL = new DaiLyBuuDienVHX_Ctrl();
        Huyen_Thi_Data hd = new Huyen_Thi_Data();
        QL_DoanhNghiep_Data Dn = new QL_DoanhNghiep_Data();
        Xa_Phuong_Data X = new Xa_Phuong_Data();
        public QL_DaiLyBuuDienVHX()
        {
            InitializeComponent();
        }

        private void QL_DaiLyBuuDienVHX_Load(object sender, EventArgs e)
        {
            CTRL.DanhsachVanHoaXa(gridControl1 ,bindingNavigator1,txtMaBDVHX,txtTenBDVHX,cmbHuyen,cmbXa,txtDiaChi,cmDoanhNghiep);

            gridView1.OptionsBehavior.Editable = false;

            Huyen_Thi_Ctrl ctrl_huyen = new Huyen_Thi_Ctrl();
            ctrl_huyen.ComboBoxHuyen(cmbHuyen);

            Xa_Phuong_CTrl ctrl_xa = new Xa_Phuong_CTrl();
            ctrl_xa.ComboBoxXa(cmbXa);

            QL_DoanhNghiep_Ctrl ctrl_dn = new QL_DoanhNghiep_Ctrl();
            ctrl_dn.ComboBoxDN(cmDoanhNghiep);

            //
            this.repositoryItemLookUpEdit1.DataSource = hd.HienThiDanhSachHuyen();
            this.repositoryItemLookUpEdit1.DisplayMember = "TenHuyen";
            this.repositoryItemLookUpEdit1.ValueMember = "MaHuyen";

            //
            this.repositoryItemLookUpEdit2.DataSource = Dn.Show_DoanhNghiep();
            this.repositoryItemLookUpEdit2.DisplayMember = "TenDoanhNghiep";
            this.repositoryItemLookUpEdit2.ValueMember = "MaDoanhNghiep";

            //
            this.repositoryItemLookUpEdit3.DataSource = X.DanhSach_Xa_Phuong();
            this.repositoryItemLookUpEdit3.DisplayMember = "TenXa";
            this.repositoryItemLookUpEdit3.ValueMember = "MaXa";

            //to vang cot ma
            GridColumn unbColumn = gridView1.Columns["MaDaiLyBuuDienVHX"];
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
            row["MaDaiLyBuuDienVHX"] = ma;
            txtTenBDVHX.Focus();
        }

        private void BT_Xoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn xóa không?", "Dai ly Buu dien Van Hoa Xa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                bindingNavigator1.BindingSource.RemoveCurrent();
                CTRL.Update();
            }
        }

        private void BT_Sua_Click(object sender, EventArgs e)
        {
            txtTenBDVHX.Focus();
        }

        private void BT_Luu_Click(object sender, EventArgs e)
        {
            if (CTRL.Kiemtra(txtTenBDVHX, cmbHuyen, cmbXa, txtDiaChi, cmDoanhNghiep))
            {
                bindingNavigatorPositionItem.Focus();
                bindingNavigator1.BindingSource.MoveNext();
                CTRL.Update();
                BT_Them.Enabled = true;
            }
        }

        private void BT_Reset_Click(object sender, EventArgs e)
        {
            CTRL.DanhsachVanHoaXa(gridControl1, bindingNavigator1, txtMaBDVHX, txtTenBDVHX, cmbHuyen, cmbXa, txtDiaChi, cmDoanhNghiep);
            gridView1.RefreshData();
            BT_Them.Enabled = true;
        }

        private void BT_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThemDN_Click(object sender, EventArgs e)
        {
            QL_DoanhNghiep DN = null;
            if (DN == null || DN.IsDisposed)
            {
                DN = new QL_DoanhNghiep();
                DN.Show();
                DN.Focus();
            }
        }

        private void btnThemHuyen_Click(object sender, EventArgs e)
        {
            QL_Huyen_Thi Huyen = null;
            if (Huyen == null || Huyen.IsDisposed)
            {
                Huyen = new QL_Huyen_Thi();
                Huyen.Show();
                Huyen.Focus();
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

    }
}