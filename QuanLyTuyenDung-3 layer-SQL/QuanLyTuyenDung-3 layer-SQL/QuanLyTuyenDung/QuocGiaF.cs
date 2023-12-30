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
    public partial class QuocGiaF : Form
    {
        public QuocGiaF()
        {
            InitializeComponent();
        }

        private void QuocGiaF_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            this.Text = String.Empty;
            dgv1.DataSource = QuocGia_BLL.DSQuocGia();
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
