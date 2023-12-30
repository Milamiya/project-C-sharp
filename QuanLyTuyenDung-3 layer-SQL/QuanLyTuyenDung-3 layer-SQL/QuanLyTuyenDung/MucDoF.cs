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
    public partial class MucDoF : Form
    {
        public MucDoF()
        {
            InitializeComponent();
        }

        private void MucDoF_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            this.Text = String.Empty;
            dgv1.DataSource = MucDo_BLL.DSMucDo();
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
