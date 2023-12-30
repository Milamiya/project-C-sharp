using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar.Controls;
using QLKTX.Controller;
using QLKTX.BusinessObject;

namespace QLKTX
{
    public partial class frmTraCuuSinhVien : Form
    {
        private TraCuuSinhVienCtrl tracuuctrl = new TraCuuSinhVienCtrl();
        public string Masinhvien = "";
        public frmTraCuuSinhVien()
        {
            InitializeComponent();
        }
        
        private void labelX2_Click(object sender, EventArgs e)
        {

        }

        private void frmTraCuuSinhVien_Load(object sender, EventArgs e)
        {
            QuocTichCtrl QT = new QuocTichCtrl();
            TonGiaoCtrl TG = new TonGiaoCtrl();
            DanTocCtrl DT = new DanTocCtrl();

            
            QT.LayComboboxQuocTich(cmbQuocTich);
            TG.LayComboboxTonGiao(cmbTonGiao);
            DT.LayComboboxDanToc(cmbDanToc);

            cmdDKDiaChi.Items.AddRange(new string[] { "None", "And", "Or", "And Not", "Or Not" });
            cmdDKDiaChi.SelectedIndex = 0;
            cmbDKDanToc.Items.AddRange(new string[] { "None", "And", "Or", "And Not", "Or Not" });
            cmbDKDanToc.SelectedIndex = 0;
            cmbDKQuocTich.Items.AddRange(new string[] { "None", "And", "Or", "And Not", "Or Not" });
            cmbDKQuocTich.SelectedIndex = 0;
            cmbDKCMND.Items.AddRange(new string[] { "None", "And", "Or", "And Not", "Or Not" });
            cmbDKCMND.SelectedIndex = 0;
            cmdDKGioiTinh.Items.AddRange(new string[] { "None", "And", "Or", "And Not", "Or Not" });
            cmdDKGioiTinh.SelectedIndex = 0;
            cmbDKTonGiao.Items.AddRange(new string[] { "None", "And", "Or", "And Not", "Or Not" });
            cmbDKTonGiao.SelectedIndex = 0;
            cmdDKMSSV.Items.AddRange(new string[] { "None", "And", "Or", "And Not", "Or Not" });
            cmdDKMSSV.SelectedIndex = 0;


        }

        private void btnTraCuu_Click(object sender, EventArgs e)
        {
            lblLabel.Text = "Tra Cứu Sinh Viên";
            tracuuctrl.TraCuu(dataKetQua, txtHoTen, cmdDKDiaChi, txtDiaChi, cmdDKGioiTinh, chkGioiTinh,
                                cmdDKMSSV, txtMSSV, cmbDKQuocTich, cmbQuocTich, cmbDKDanToc, cmbDanToc,
                                cmbDKTonGiao, cmbTonGiao,cmbDKCMND,txtCMND);
        }

        private void cmdDKDiaChi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmdDKDiaChi.SelectedIndex >= 0)
            {
                if (cmdDKDiaChi.SelectedItem.ToString().Equals("None"))
                    txtDiaChi.Enabled = false;
                else txtDiaChi.Enabled = true;
            }
        }

        private void cmdDKGioiTinh_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmdDKGioiTinh.SelectedIndex >= 0)
            {
                if (cmdDKGioiTinh.SelectedItem.ToString().Equals("None"))
                    chkGioiTinh.Enabled = false;
                else chkGioiTinh.Enabled = true;
            }
        }

        private void cmdDKMSSV_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmdDKMSSV.SelectedIndex >= 0)
            {
                if (cmdDKMSSV.SelectedItem.ToString().Equals("None"))
                    txtMSSV.Enabled = false;
                else txtMSSV.Enabled = true;
            }
        }

        private void cmbDKQuocTich_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbDKQuocTich.SelectedIndex >= 0)
            {
                if (cmbDKQuocTich.SelectedItem.ToString().Equals("None"))
                    cmbQuocTich.Enabled = false;
                else cmbQuocTich.Enabled = true;
            }
        }

        private void cmdDKDanToc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbDKDanToc.SelectedIndex >= 0)
            {
                if (cmbDKDanToc.SelectedItem.ToString().Equals("None"))
                    cmbDanToc.Enabled = false;
                else cmbDanToc.Enabled = true;
            }
        }

        private void cmdDKTonGiao_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbDKTonGiao.SelectedIndex >= 0)
            {
                if (cmbDKTonGiao.SelectedItem.ToString().Equals("None"))
                    cmbTonGiao.Enabled = false;
                else cmbTonGiao.Enabled = true;
            }
        }

        private void cmdDKCMND_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbDKCMND.SelectedIndex >= 0)
            {
                if (cmbDKCMND.SelectedItem.ToString().Equals("None"))
                    txtCMND.Enabled = false;
                else txtCMND.Enabled = true;
            }
        }
        public void TraCuuTheoPhong(string tenphong )
        {
            lblLabel.Text = "Tra Cứu Sinh Viên Theo Phòng";
            tracuuctrl.TraCuuTheoPhong(dataKetQua, tenphong);
        }
        public void TraCuuTheoDay(string tenday)
        {
            lblLabel.Text = "Tra Cứu Sinh Viên Theo Dãy";
            tracuuctrl.TraCuuTheoDay(dataKetQua, tenday);
        }

        private void btnRight_Click(object sender, EventArgs e)
        {

        }

        private void dataKetQua_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (dataKetQua.SelectedRows.Count > 0)
            {
                DataGridViewRow row= dataKetQua.SelectedRows[0];
                Masinhvien=row.Cells["colMaKTX"].Value.ToString();

                this.DialogResult = DialogResult.OK;
            }
        }
         
    }
}