using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Business_Tier;

namespace prPhamMemHoTroTimViecLam
{
    public partial class TimKiem : Form
    {
        public TimKiem()
        {
            InitializeComponent();
            tbDoanhNghiepAll = objDN.getAllDoanhNghiep();
        }
        DataTable tbNganhNghe, tbDoanhNghiepAll,tbmaNN,tbDN_TheoMa,tbDN_TheoDiaDiem;
        B_NganhNghe ObjNN = new B_NganhNghe();
        B_DoanhNghiep objDN = new B_DoanhNghiep();
        B_TimKiem objTim = new B_TimKiem();
        bool danap = false;
        DataView dvDoanhNghiep;
        private void button4_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Ban có thật sự muốn thoát ?", "Warning !", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                this.Close();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {

            if (radNganhNghe.Checked ==true)
            {
                lsvDN.Items.Clear();
                string ma;
                tbmaNN = ObjNN.LayMaNN_TheoTen(cboNganhNghe.Text);
                DataRow dr1 = tbmaNN.Rows[0];
                ma = dr1["ma"].ToString();
                tbDN_TheoMa = objDN.gettbdoanhnghieptheomanganhnghe(ma);
                foreach(DataRow dr in tbDN_TheoMa.Rows)
                {
                    ListViewItem li = lsvDN.Items.Add(dr["ma"].ToString());
                    li.SubItems.Add(dr["ten"].ToString());
                    li.SubItems.Add(dr["diachi"].ToString());
                    li.SubItems.Add(dr["sdt"].ToString());
                    li.SubItems.Add(dr["email"].ToString());
                    li.SubItems.Add(dr["chudn"].ToString());
                    li.SubItems.Add(dr["manganhnghe"].ToString());
                    li.Tag = dr["ma"].ToString();
                }
            }
            else if(radDiaDiem.Checked==true)
            {
                lsvDN.Items.Clear();
                tbDN_TheoDiaDiem = objDN.getDoanhNghiep_TheoDiaDiem(cboDiaDiem.Text);
                foreach (DataRow dr in tbDN_TheoDiaDiem.Rows)
                {
                    ListViewItem li = lsvDN.Items.Add(dr["ma"].ToString());
                    li.SubItems.Add(dr["ten"].ToString());
                    li.SubItems.Add(dr["diachi"].ToString());
                    li.SubItems.Add(dr["sdt"].ToString());
                    li.SubItems.Add(dr["email"].ToString());
                    li.SubItems.Add(dr["chudn"].ToString());
                    li.SubItems.Add(dr["manganhnghe"].ToString());
                    li.Tag = dr["ma"].ToString();
                }

            }
        }

        private void radNganhNghe_CheckedChanged(object sender, EventArgs e)
        {
            cboNganhNghe.Visible = true;
            cboDiaDiem.Visible = false;
            lblChon.Text = "Chọn ngành nghề ";
            tbNganhNghe = ObjNN.gettbnganhnghe();
            cboNganhNghe.DataSource = tbNganhNghe;
            cboNganhNghe.DisplayMember = "Ten";
            cboNganhNghe.ValueMember = "Ma";

        }

        private void radDiaDiem_CheckedChanged(object sender, EventArgs e)
        {
            cboDiaDiem.Visible = true;
            cboNganhNghe.Visible = false;
            lblChon.Text = "Chon địa điểm";
            cboDiaDiem.Items.Clear();
            cboDiaDiem.Items.Add("Quận 1");
            cboDiaDiem.Text = cboDiaDiem.Items[0].ToString();
            cboDiaDiem.Items.Add("Quận 2");
            cboDiaDiem.Items.Add("Quận 3");
            cboDiaDiem.Items.Add("Quận 4");
            cboDiaDiem.Items.Add("Quận 5");
            cboDiaDiem.Items.Add("Quận 6");
            cboDiaDiem.Items.Add("Quận 7");
            cboDiaDiem.Items.Add("Quận 8");
            cboDiaDiem.Items.Add("Quận 9");
            cboDiaDiem.Items.Add("Quận 10");
            cboDiaDiem.Items.Add("Quận 11");
            cboDiaDiem.Items.Add("Quận 12");
            cboDiaDiem.Items.Add("Tân Phú");
            cboDiaDiem.Items.Add("Bình Thạnh");
            cboDiaDiem.Items.Add("Tân Bình");
            cboDiaDiem.Items.Add("Hóc Môn");
            cboDiaDiem.Items.Add("Gò Vấp");
            cboDiaDiem.Items.Add("Bình Tân");
            cboDiaDiem.Items.Add("Thủ Đức");
            cboDiaDiem.Items.Add("Phú Nhuận");

        }

        private void TimKiem_Load(object sender, EventArgs e)
        {
            NapdulieuListview();
        }
        private void NapdulieuListview()
        {
            lsvDN.Items.Clear();
            tbDoanhNghiepAll = objDN.getAllDoanhNghiep();
            foreach (DataRow dr in tbDoanhNghiepAll.Rows)
            {
                ListViewItem li = lsvDN.Items.Add(dr["ma"].ToString());
                li.SubItems.Add(dr["ten"].ToString());
                li.SubItems.Add(dr["diachi"].ToString());
                li.SubItems.Add(dr["sdt"].ToString());
                li.SubItems.Add(dr["email"].ToString());
                li.SubItems.Add(dr["chudn"].ToString());
                li.SubItems.Add(dr["manganhnghe"].ToString());
                li.Tag = dr["ma"].ToString();

            }
            //dvDoanhNghiep = new DataView(tbDoanhNghiepAll);
            
        }
        private void lsvNN_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsvDN.SelectedItems.Count > 0)
            {
                string strma = lsvDN.SelectedItems[0].Tag.ToString();
                DataTable dttb = objDN.gettbdoanhnghieptheomadoanhnghiep(strma);
                DataRow dr = dttb.Rows[0];
                txtMa.Text = dr["Ma"].ToString();
                txtTen.Text = dr["Ten"].ToString();
                txtDiaChi.Text = dr["DiaChi"].ToString();
                txtSDT.Text = dr["SDT"].ToString();
                txtEmail.Text = dr["Email"].ToString();
                txtChuDN.Text = dr["ChuDN"].ToString();
                txtNganhNghe.Text = dr["MaNganhNghe"].ToString();
            }
        }

        private void btnGuiYeuCau_Click(object sender, EventArgs e)
        {
                LyLichCaNhan frm = new LyLichCaNhan();
                frm.ShowDialog();

        }
    }
}
