using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BUS;
namespace QLTuyenDungPresentation
{
    public partial class TimUngVien : Form
    {
        public TimUngVien()
        {
            InitializeComponent();
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            Close();

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                cbotintuyendung.Enabled = false;
                txttentt.Enabled = true;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                txttentt.Enabled = false;
                cbotintuyendung.Enabled = true;
            }
        }
        public static DataTable dtin;
        private void btntim_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                dgv1.DataSource = HoSo_BLL.DSHoSoTheoTen(txttentt.Text);
                dtin = HoSo_BLL.DSHoSoTheoTen(txttentt.Text);
            }
            else
            {
                dgv1.DataSource = HoSo_BLL.DSHoSoTheoTinTuyenDung(cbotintuyendung.SelectedValue.ToString());
                dtin = HoSo_BLL.DSHoSoTheoTinTuyenDung(cbotintuyendung.SelectedValue.ToString());
            }
        }

        private void TimUngVien_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            this.Text = String.Empty;
            cbotintuyendung.ValueMember = "MaTT";
            cbotintuyendung.DisplayMember = "TenTT";
            cbotintuyendung.DataSource = ThongTinTuyenDung_BLL.DSTiNTuyenDung();
        }

        private void btnin_Click(object sender, EventArgs e)
        {
            InHoSo ihs = new InHoSo();
            ihs.Show();
        }
    }
}
