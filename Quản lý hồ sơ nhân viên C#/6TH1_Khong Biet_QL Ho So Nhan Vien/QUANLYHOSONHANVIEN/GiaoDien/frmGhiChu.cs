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
    public partial class frmGhiChu : DevComponents .DotNetBar.Office2007Form
    {
        public frmGhiChu()
        {
            InitializeComponent();
        }
        LoaiGhiChuCtr ctr_loaighichu = new LoaiGhiChuCtr();
        GhichuData data = new GhichuData();
        string tennv;
        string manv;

        public frmGhiChu(string ten,string ma)
            : this()
        {
            tennv = ten;
            manv = ma;
        }

        private void frmGhiChu_Load(object sender, EventArgs e)
        {
            loadData();

        }

        public void loadData()
        {
            ctr_loaighichu.HienThiAutoCombobox(cmbLoaighichu);

        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            dateTimeInputGhichu.Value = DateTime.Now;
            data.ThemGhiChu(tennv, manv,dateTimeInputGhichu.Value.ToString(), cmbLoaighichu.SelectedValue.ToString(), txtTieude.Text.ToString(), txtNoidung.Text.ToString());
            MessageBox.Show("Thành Công");
        }
    }
}
