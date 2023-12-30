using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PresentationLayer;
using DTO;
using PresentationLayer;
namespace PresentationLayer
{
    public partial class ThongBaoF : Form
    {
        public ThongBaoF()
        {
            InitializeComponent();
        }

        private void ThongBaoF_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            this.Text = String.Empty;
            dgv1.DataSource = ThongBao_BLL.DSThongBao();
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
