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
    public partial class frmNhapDiem_Phong : Form
    {

        KTXCtrl ktx = new KTXCtrl();
        PhongCtrl phong = new PhongCtrl();
        DayCtrl day = new DayCtrl();
        NamHocCtrl namhhoc = new NamHocCtrl();

        NhapDiemCtrl ctrl = new NhapDiemCtrl();
        public frmNhapDiem_Phong()
        {
            InitializeComponent();
        }

       
        private void frmNhapDiem_Phong_Load(object sender, EventArgs e)
        {
            ktx.LayDSKTXLenComboBox(cmbKTX);
            day.LayDuLieuLenComboBox(cmbDay);
            namhhoc.LayDSNamHoc(cmbNamHoc);            
        }

        private void cmbKTX_SelectionChangeCommitted(object sender, EventArgs e)
        {
            day.LayDuLieuLenComboBox_DK_KTX(cmbDay,cmbKTX.SelectedValue.ToString());
        }


        private void btnNhapDiem_Click(object sender, EventArgs e)
        {
            if (cmbThang.SelectedIndex >= 0 &&cmbDay.SelectedIndex >= 0 &&cmbNamHoc.SelectedIndex >= 0)
            {
                ctrl.ThemPhieuDiem(cmbDay, cmbNamHoc, cmbThang);
                
                ctrl.LayDSPhieuDiem(dtDiem);
                if (dtDiem.Rows.Count > 0)
                {
                    dtDiem.Columns["maphg"].Visible = false;
                    dtDiem.Columns["manamhoc"].Visible = false;
                    try
                    {
                        dtDiem.Columns["maxeploai"].Visible = false;
                        dtDiem.Columns["ghichu"].Visible = false;
                    }
                    catch (Exception y)
                    { }
                }                
            }
        }

        private void dtDiem_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try{
                int i=Convert.ToInt32(dtDiem[e.ColumnIndex,e.RowIndex].Value.ToString());
                if(i<0 || i>10)
                    dtDiem[e.ColumnIndex, e.RowIndex].Value = 0;
            }
            catch(Exception r)
            {
                dtDiem[e.ColumnIndex,e.RowIndex].Value =0;
            }
        }

        private void dtDiem_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            if (e.ColumnIndex == 4)
            {
                MessageBox.Show("Điểm chỉ có thể nhập số!");                
                dtDiem[e.ColumnIndex, e.RowIndex].Value = 0;
                e.Cancel = false;
            }
            
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            ctrl.CapNhatDSPhieuDiem(dtDiem);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {            
            ctrl.CapNhatDSPhieuDiemSua(dtDiem);
            if (dtDiem.Rows.Count > 0)
            {
                dtDiem.Columns["maphg"].Visible = false;
                dtDiem.Columns["manamhoc"].Visible = false;
                try
                {
                    dtDiem.Columns["maxeploai"].Visible = false;
                    dtDiem.Columns["ghichu"].Visible = false;
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
    }
}