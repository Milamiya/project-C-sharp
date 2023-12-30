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
using BUS;
namespace PresentationLayer
{
    public partial class HuyenF : Form
    {
        public HuyenF()
        {
            InitializeComponent();
        }

        private void HuyenF_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            this.Text = String.Empty;
            dgv1.DataSource = Huyen_BLL.DSHuyen();
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
