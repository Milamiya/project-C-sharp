using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace QuanLyXeVaXe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            {

                Sub_QuanLyKhachhang f = new Sub_QuanLyKhachhang();
                f.TopLevel = false;
                f.Show();
                panel3.Controls.Clear();
                panel3.Controls.Add(f);

            }

        }
    }
}