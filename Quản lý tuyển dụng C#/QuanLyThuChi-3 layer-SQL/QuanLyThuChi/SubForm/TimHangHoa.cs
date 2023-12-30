using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;

namespace QuanLyThuChi.SubForm
{
    public partial class TimHangHoa : Form
    {
        public TimHangHoa()
        {
            InitializeComponent();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            dgv1.DataSource = HANGHOA_BUS.TimHangHoaTheoTen(txt1.Text);
        }

        private void TimHangHoa_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            this.Text = String.Empty;
        }
    }
}
