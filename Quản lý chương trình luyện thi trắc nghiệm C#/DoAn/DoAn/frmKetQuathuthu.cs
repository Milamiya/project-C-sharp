using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Doan
{
    public partial class frmKetQuathuthu : Form
    {
        public frmThi frmformthi1;
       public  string strcauhoikq, strten,strcapdokq,diem;
      
        private void getdata()
        {
            strten = frmformthi1.ten;
           strcapdokq = frmformthi1.strcapdo1;
           strcauhoikq = frmformthi1.strsoluongcauhoi1;
           diem = frmformthi1.diemkq;
           lbdiem.Text = diem.ToString()+ " / " + strcauhoikq.ToString();
           lbdung.Text = diem.ToString();
           lbsai.Text = (int.Parse(strcauhoikq) - int.Parse(diem)).ToString();
           lbhoten.Text = strten;
            lbcapdo.Text = strcapdokq.ToString();
            lbsl.Text = strcauhoikq.ToString();
            
        }
        public frmKetQuathuthu()
        {
            
            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void frmKetQua_Load(object sender, EventArgs e)
        {
            getdata();
        }

      
    }
}
