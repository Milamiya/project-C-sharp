using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace LichCongTac
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        Modules.ConnectionString connec = new LichCongTac.Modules.ConnectionString();
        Modules.Global global = new LichCongTac.Modules.Global();

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show(comboBox1.SelectedItem.ToString());
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            MessageBox.Show(dateTimePicker1.Text);
        }


        private void Form2_Resize(object sender, EventArgs e)
        {
            Form2.ActiveForm.WindowState = FormWindowState.Maximized;
        }
    }
}