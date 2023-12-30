using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using QUANLYHOSONHANVIEN.Controller;
using QUANLYHOSONHANVIEN.DataLayer;

namespace QUANLYHOSONHANVIEN.GiaoDien
{
    public partial class frmThemGhiChu : DevComponents .DotNetBar.Office2007Form
    {
        public frmThemGhiChu()
        {
            InitializeComponent();
        }
        GhichuData data = new GhichuData();
        LoaiGhiChuCtr ctr_loaighichu = new LoaiGhiChuCtr();
        string maghichu;

        public frmThemGhiChu(string magc)
            : this()
        {
            maghichu = magc;
        }

        private void frmThemGhiChu_Load(object sender, EventArgs e)
        {
            Loaddata();
        }

        private void Loaddata()
        {
            ctr_loaighichu.HienThiAutoCombobox(cmbLoaighichu);
            DataTable tbl = data.DanhsachGhiChuTheoMAGC(maghichu);
            foreach (DataRow row in tbl.Rows)
            {
                cmbLoaighichu.SelectedValue = row["MALOAIGC"].ToString();
                txtTieude.Text = row["TIEUDE"].ToString();
                txtNoidung.Text = row["NOIDUNG"].ToString();

            }

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            data.UpdateGhichu(maghichu, cmbLoaighichu.SelectedValue.ToString(), txtTieude.Text.ToString(), txtNoidung.Text.ToString());
            MessageBox.Show("Thành Công");
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
