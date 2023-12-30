using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using QLKTX.Controller;
namespace QLKTX.Phong
{
    public partial class frmNhapKWDien_Phong : Form
    {

        KTXCtrl ktx = new KTXCtrl();
        PhongCtrl phong = new PhongCtrl();
        DayCtrl day = new DayCtrl();
        NamHocCtrl namhhoc = new NamHocCtrl();

        NhapKWDienCtrl ctrl = new NhapKWDienCtrl();
        public frmNhapKWDien_Phong()
        {
            InitializeComponent();
        }

       
        private void frmNhapKQDien_Phong_Load(object sender, EventArgs e)
        {
          /*  ktx.LayDSKTXLenComboBox(cmbKTX);
            day.LayDuLieuLenComboBox(cmbDay);
            namhhoc.LayDSNamHoc(cmbNamHoc);  */          
        }

        private void cmbKTX_SelectionChangeCommitted(object sender, EventArgs e)
        {
            day.LayDuLieuLenComboBox_DK_KTX(cmbDay,cmbKTX.SelectedValue.ToString());
        }


        private void btnNhapKWDien_Click(object sender, EventArgs e)
        {
            /*if (cmbThang.SelectedIndex >= 0 &&cmbDay.SelectedIndex >= 0 &&cmbNamHoc.SelectedIndex >= 0)
            {
                ctrl.ThemPhieuKWDien(cmbDay, cmbNamHoc, cmbThang);
                
                ctrl.LayDSPhieuKWDien(dtKWDien);
                if (dtKWDien.Rows.Count > 0)
                {
                    dtKWDien.Columns["maphg"].Visible = false;
                    dtKWDien.Columns["manamhoc"].Visible = false;
                    try
                    {
                        dtKWDien.Columns["maxeploai"].Visible = false;
                        dtKWDien.Columns["ghichu"].Visible = false;
                    }
                    catch (Exception y)
                    { }
                }                
            }*/
        }

        private void dtKWDien_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try{
                int i=Convert.ToInt32(dtKWDien[e.ColumnIndex,e.RowIndex].Value.ToString());
                if(i<0 || i>10)
                    dtKWDien[e.ColumnIndex, e.RowIndex].Value = 0;
            }
            catch(Exception r)
            {
                dtKWDien[e.ColumnIndex,e.RowIndex].Value =0;
            }
        }

        private void dtKWDien_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            if (e.ColumnIndex == 4)
            {
                MessageBox.Show("Điểm chỉ có thể nhập số!");                
                dtKWDien[e.ColumnIndex, e.RowIndex].Value = 0;
                e.Cancel = false;
            }
            
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            ctrl.CapNhatDSPhieuKWDien(dtKWDien);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {            
            ctrl.CapNhatDSPhieuKWDienSua(dtKWDien);
            if (dtKWDien.Rows.Count > 0)
            {
                dtKWDien.Columns["maphg"].Visible = false;
                dtKWDien.Columns["manamhoc"].Visible = false;
                try
                {
                    dtKWDien.Columns["maxeploai"].Visible = false;
                    dtKWDien.Columns["ghichu"].Visible = false;
                }
                catch (Exception y)
                { }
            }


        }

        private void groupPanel2_Click(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmNhapKWDien_Phong_Load(object sender, EventArgs e)
        {

        }

        private void frmNhapKWDien_Phong_Load_1(object sender, EventArgs e)
        {

        }

        private void frmNhapKWDien_Phong_Load_2(object sender, EventArgs e)
        {

        }
    }
}