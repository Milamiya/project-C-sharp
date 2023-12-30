using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace QLKTX
{
    public partial class frmThemSinhVien : Form
    {
        public ArrayList dsSinhVien =new ArrayList();
        public frmThemSinhVien()
        {
            InitializeComponent();
        }

        private void textBoxX5_TextChanged(object sender, EventArgs e)
        {
            textBoxX5.Text = "";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            txtHoTen.Focus();
            SinhVienInfo sv=new SinhVienInfo();
            ThanNhanInfo[] tn = new ThanNhanInfo[dsThanhNhan.Rows.Count];

            sv.HoTen=txtHoTen.Text;
            sv.GioiTinh = chkGioiTinh.Checked;
            for(int i=0;i < dsThanhNhan.Rows.Count -1;i++){
                 tn[i]= new ThanNhanInfo();
                tn[i].HoTen = dsThanhNhan.Rows[i].Cells[0].Value.ToString();
                tn[i].QuanHe = 1;
                sv.dsThanhNhan.Add( tn[i]);
            }
            dsSinhVien.Add(sv);           
            
            dtDanhSach.Rows.Add(new Object[]{
                ((SinhVienInfo)dsSinhVien[dsSinhVien.Count-1]).MaKTX,
                ((SinhVienInfo)dsSinhVien[dsSinhVien.Count-1]).HoTen
            });
            txtHoTen.Text = txtMaKTX.Text = "";



            
        }

        private void dtDanhSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnXoa.Enabled = true;
        }

        private void dtDanhSach_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
               
                txtMaKTX.Text = ((SinhVienInfo)dsSinhVien[e.RowIndex]).MaKTX;
                txtHoTen.Text = ((SinhVienInfo)dsSinhVien[e.RowIndex]).HoTen;

                
                    SinhVienInfo sv=(SinhVienInfo)dsSinhVien[e.RowIndex];
                    dsSinhVien.RemoveAt(e.RowIndex);
                    dtDanhSach.Rows.RemoveAt(e.RowIndex);

                    dsThanhNhan.Rows.Clear();
                    
                    for(int j=0;j<sv.dsThanhNhan.Count;j++){
                        
                        ThanNhanInfo tn = (ThanNhanInfo)(sv.dsThanhNhan[j]);

                        dsThanhNhan.Rows.Add(new object[] { tn.HoTen.ToString() });

                    }
                
            }
            catch (Exception d)
            {
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            //if (dtDanhSach.Rows.Contains(dtDanhSach.SelectedRows))
            try
            {
                dtDanhSach.Rows.Remove(dtDanhSach.SelectedRows[0]);
            }
            catch (Exception d)
            {
                
            }
        }

        

        private void chkDangVien_CheckedChanged(object sender, EventArgs e)
        {
            if (chkDangVien.Checked == true)
            {
                chkDoanVien.Checked = false;
                chkCamTinhDang.Checked = false;
                chkDoanVien.Enabled = false;
                chkCamTinhDang.Enabled = false;

            }
            else
            {
                chkDoanVien.Enabled = true;
                chkCamTinhDang.Enabled = true;
            }
        }

        private void chkCamTinhDang_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCamTinhDang.Checked == true)
            {
                chkDoanVien.Checked = true;
                chkDangVien.Checked = false;
                chkDangVien.Enabled = false;
            }
            else
            {
                chkDangVien.Enabled = true;
                chkDoanVien.Enabled = true;
            }
        }

        private void chkDoanVien_CheckedChanged(object sender, EventArgs e)
        {
            if (chkDoanVien.Checked == true)
            {
                chkDangVien.Checked = false;
                chkDangVien.Enabled = false;
            }
            else
            {
                chkDangVien.Enabled = true;
                chkCamTinhDang.Checked = false;
            }
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            digHinh.ShowDialog(this);
            try
            {
                picHinh.Load(digHinh.FileName.ToString());
            }catch(Exception d ){
            }
        }

        private void dtDanhSach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        
     
    }
}