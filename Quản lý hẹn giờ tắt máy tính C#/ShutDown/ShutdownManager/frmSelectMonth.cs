using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ShutdownManager
{
    public partial class frmSelectMonth : Form
    {
        public frmSelectMonth()
        {
            InitializeComponent();
        }

        public static bool boolCheck1 = true;
        public static bool boolCheck2 = true;
        public static bool boolCheck3 = true;
        public static bool boolCheck4 = true;
        public static bool boolCheck5 = true;
        public static bool boolCheck6 = true;
        public static bool boolCheck7 = true;
        public static bool boolCheck8 = true;
        public static bool boolCheck9 = true;
        public static bool boolCheck10 = true;
        public static bool boolCheck11 = true;
        public static bool boolCheck12 = true;

        #region Event
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                boolCheck1 = true;
            }
            else
            {
                boolCheck1 = false;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                boolCheck2 = true;
            }
            else
            {
                boolCheck2 = false;
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                boolCheck3 = true;
            }
            else
            {
                boolCheck3 = false;
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked)
            {
                boolCheck4 = true;
            }
            else
            {
                boolCheck4 = false;
            }
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox5.Checked)
            {
                boolCheck5 = true;
            }
            else
            {
                boolCheck5 = false;
            }
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox6.Checked)
            {
                boolCheck6 = true;
            }
            else
            {
                boolCheck6 = false;
            }
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox7.Checked)
            {
                boolCheck7 = true;
            }
            else
            {
                boolCheck7 = false;
            }
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox8.Checked)
            {
                boolCheck8 = true;
            }
            else
            {
                boolCheck8 = false;
            }
        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox9.Checked)
            {
                boolCheck9 = true;
            }
            else
            {
                boolCheck9 = false;
            }
        }

        private void checkBox10_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox10.Checked)
            {
                boolCheck10 = true;
            }
            else
            {
                boolCheck10 = false;
            }
        }

        private void checkBox11_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox11.Checked)
            {
                boolCheck11 = true;
            }
            else
            {
                boolCheck11 = false;
            }
        }

        private void checkBox12_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox12.Checked)
            {
                boolCheck12 = true;
            }
            else
            {
                boolCheck12 = false;
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (!(boolCheck1) && !(boolCheck2) && !(boolCheck3) && !(boolCheck4) &&
                !(boolCheck5) && !(boolCheck6) && !(boolCheck7) && !(boolCheck8) &&
                !(boolCheck9) && !(boolCheck10) && !(boolCheck11) && !(boolCheck12))
            {
                MessageBox.Show("Bạn Phải Chọn Ít Nhất Là Một Tháng", "Time Manager", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                this.Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmSelectMonth_Load(object sender, EventArgs e)
        {
            checkBox1.Checked = boolCheck1;
            checkBox2.Checked = boolCheck2;
            checkBox3.Checked = boolCheck4;
            checkBox4.Checked = boolCheck4;
            checkBox5.Checked = boolCheck5;
            checkBox6.Checked = boolCheck6;
        }

        private void frmSelectMonth_Resize(object sender, EventArgs e)
        {
            this.Size = new Size(301, 345);
        }
        #endregion
    }
}