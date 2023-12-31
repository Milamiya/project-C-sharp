using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using DevExpress.XtraGrid;
using DevComponents.DotNetBar.Controls;
using DevComponents.DotNetBar;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraEditors.DXErrorProvider;
using DevExpress.XtraEditors.Controls;
using BaoCaoThongKe.BusinessObject;
using BaoCaoThongKe.DataLayer;
namespace BaoCaoThongKe.Controller
{
    public class NhomThueBao_Ctrl
    {
        NhomThueBao_Data DATA = new NhomThueBao_Data();
        public void HienThi_NhomThueBao(BindingNavigator bdn, GridControl dgv)
        {
            DataTable DTT = DATA.Show_NhomThueBao();
            BindingSource BD_S = new BindingSource();
            BD_S.DataSource = DTT;

            bdn.BindingSource = BD_S;
            dgv.DataSource = BD_S;
        }
        public void Update()
        {
            DATA.Update();
        }
        //bao cao

        public int LayMaMax()
        {
            DataTable table = DATA.LayMaMax();
            try
            {
                int i = Convert.ToInt32(table.Rows[0][0].ToString());
                return ++i;
            }
            catch (Exception e)
            {
                e.ToString();
                return 1;
            }
        }

        public void Them(NhomThueBao_InFo thuebao)
        {
            DATA.Them(thuebao);
        }

        public void Xoa(NhomThueBao_InFo thuebao)
        {
            DATA.Xoa(thuebao);
        }

        public void Sua(NhomThueBao_InFo thuebao)
        {
            DATA.Sua(thuebao);
        }

        public bool CheckInput(TextBoxX ten)
        {
            if (ten.Text == "")
            {
                MessageBox.Show("Chưa nhập thuê bao !", "Chú ý", MessageBoxButtons.OK);
                ten.Focus();
                return false;
            }
            else
            {
                if (ten.Text.Length > 50)
                {
                    MessageBox.Show("Thuê bao không quá 50 kí tự !", "Chú ý", MessageBoxButtons.OK);
                    ten.Focus();
                    return false;
                }
            }
            return true;
        }

        public void ComboBoxThueBao(ComboBoxEx cmbThuebao)
        {
            cmbThuebao.DataSource = DATA.Show_NhomThueBao();
            cmbThuebao.DisplayMember = "TenThueBao";
            cmbThuebao.ValueMember = "MaThueBao";
        }
        //
        public int GetLastID()
        {
            if (this.DATA == null)
            {
                this.DATA = new NhomThueBao_Data();
            }
            return Convert.ToInt32(this.DATA.GetLastID());
        }
    }
}
