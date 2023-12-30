using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Doan
{
    public partial class frmKetQua : Form
    {
        int socausai;
        SqlConnection ObjCon;
        string strngay; 
        public frmKetQua(string strten, string strma, string strdiem, string strsocaudung)
        {
            string strCon = "server=.\\SQLEXPRESS;database=QL_Thitracnghiem;integrated security=true";
            ObjCon = new SqlConnection(strCon);
            ObjCon.Open();
            InitializeComponent();
            
       
            getvalueformdienten = strten;//ten
            getvalueformdienma = strma;//ma thi sinh
            getvaluediem = strdiem;//diem
            getvaluesocaudung = strsocaudung;//so cau dung
            socausai = 50 - int.Parse(strsocaudung);//so cau sai
            lbsocausai.Text = socausai.ToString(); 
        }
       
        public string getvalueformdienten
        {
            set
            {
                this.lbhoten.Text = value;
            }

        }
        public string getvalueformdienma
        {
            set
            {
                this.lbmathisinh.Text = value;
            }
        }
        public string getvaluediem
        {
            set
            {
                this.lbdiem.Text = value;
            }
        }
        public string getvaluesocaudung
        {
            set
            {
                this.lbsocaudung.Text = value;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }
       
        private void frmKetQua_Load(object sender, EventArgs e)
        {
            string strma,strsocaudung,strdiem;
            strma = lbmathisinh.Text;
            strsocaudung =lbsocaudung.Text;
            strdiem= lbdiem.Text;
            strngay = DateTime.Now.ToShortDateString();
            lbngay.Text = DateTime.Now.Day.ToString() + "/" + DateTime.Now.Month.ToString() + "/" + DateTime.Now.Year.ToString();
            string strSQL = "insert KETQUA values('" + strma + "','" + strngay + "','" + strsocaudung + "','" + socausai + "','" + strdiem + "')";
            SqlCommand ObjCmd = new SqlCommand(strSQL, ObjCon);
            ObjCmd.ExecuteNonQuery();
        }
    }
}
