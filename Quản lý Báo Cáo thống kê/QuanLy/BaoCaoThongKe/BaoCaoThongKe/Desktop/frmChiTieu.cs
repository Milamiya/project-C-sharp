using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BaoCaoThongKe.DataLayer;
using BaoCaoThongKe.Controller;
using DevExpress.XtraGrid;

namespace BaoCaoThongKe
{
    public partial class frmChiTieu : Form
    {
        //
        ChiTieuController ctrl = new ChiTieuController();
        DonViTinhData dvdata = new DonViTinhData();


        //
        public frmChiTieu()
        {
            InitializeComponent();
        }
        //
        private void frmHoatDongCungCap_Load(object sender, EventArgs e)
        {
            ctrl.HienThiTreeList(treeList1, bindingNavigatorHDCungCap);
            repositoryItemLookUpEdit1.DataSource = dvdata.LayDSDonViTinh();
            repositoryItemLookUpEdit1.DisplayMember = "TenDonViTinh";
            repositoryItemLookUpEdit1.ValueMember = "MaDonViTinh";
        }
        //
        private void AddNutGoc_Click_1(object sender, EventArgs e)
        {
            treeList1.FocusedNode = treeList1.AppendNode(null, null);
        }
        //
        private void AddNewItem_Click_1(object sender, EventArgs e)
        {
            if (treeList1.FocusedNode != null)
            {
                treeList1.FocusedNode = treeList1.AppendNode(null, treeList1.FocusedNode);

            }
        }
        //
        private void toolStripButton1_Click_1(object sender, EventArgs e)
        {

        }
        //
        private void bindingNavigatorDeleteItem_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa không", "Note !", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                //bindingNavigatorHDCungCap.BindingSource.RemoveCurrent();
                if (treeList1.FocusedNode != null)
                    treeList1.DeleteNode(treeList1.FocusedNode);
            }
        }
        //
        private void toolStripButtonLuu_Click_1(object sender, EventArgs e)
        {
            bool g = false;
            //
            for (int i = 0; i < treeList1.Nodes.Count; i++)
            {
                if (treeList1.Nodes[i].GetValue("MaChiTieu").ToString() != "")
                {
                    //
                    for (int s = 0; s < treeList1.Nodes[i].Nodes.Count; s++)
                    {
                        if (treeList1.Nodes[i].Nodes[s].GetValue("MaChiTieu").ToString() != "")
                        {
                            //
                            for (int f = 0; f < treeList1.Nodes[i].Nodes[s].Nodes.Count; f++)
                            {
                                if (treeList1.Nodes[i].Nodes[s].Nodes[f].GetValue("MaChiTieu").ToString() != "")
                                {
                                    //
                                    for (int d = 0; d < treeList1.Nodes[i].Nodes[s].Nodes[f].Nodes.Count; d++)
                                    {
                                        if (treeList1.Nodes[i].Nodes[s].Nodes[f].Nodes[d].GetValue("MaChiTieu").ToString() != "")
                                        {
                                        }
                                        else
                                            g = true;
                                    }
                                }
                                else
                                    g = true;
                            }
                        }
                        else
                            g = true;
                    }
                }
                else
                    g = true;

            }
            if (g)
            {
                MessageBox.Show("Bạn phải nhập vào STT là ít nhất !");
            }
            else
            {
                bindingNavigatorPositionItem.Focus();
                //ctrl.Update();
                bindingNavigatorHDCungCap.BindingSource.MoveNext();
                ctrl.Update();
            }
            
        }
        //
        private void Thoat_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}