using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Shop_Manager
{
    public partial class frmThemDonDatH : Form
    {
        public frmThemDonDatH()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string select="";
            try
            {
                //Exception khi không đủ dữ liệu
                if (txtMatHang.Text == "" || txtKhachHang.Text == "" || pckNgayDat.Text=="" || pckNgayNhan.Text==""||txtDienThoai.Text=="")
                    throw new NotEnoughInfoException();

                //Exception khi năm nhận nhỏ hơn năm đặt
                if (pckNgayNhan.Value.Year < pckNgayNhan.Value.Year)
                    throw new TimeLogicException();

                //Exception nếu năm nhận bằng nhau mà tháng nhận lại nhỏ hơn tháng đặt
                else
                    if ((pckNgayNhan.Value.Year == pckNgayDat.Value.Year) && (pckNgayNhan.Value.Month < pckNgayDat.Value.Month))
                        throw new TimeLogicException();

                //Exception nếu năm tháng nhận bằng nhau mà ngày nhận lại nhỏ hơn ngày đặt
                else 
                    if ((pckNgayDat.Value.Year==pckNgayNhan.Value.Year) && (pckNgayDat.Value.Month==pckNgayNhan.Value.Month)
                        &&(pckNgayDat.Value.Day>pckNgayNhan.Value.Day))
                        throw new TimeLogicException();

                //Exception khi sai định dạng
                if (float.Parse(txtSoLuong.Text) < 0 )
                    throw new FormatException();

                select = "insert into tblDatHang(MaMatH,TenKhachH,SoLuong,NgayDat,NgayNhan,DienThoai) values(N'" + txtMatHang.Text + "',N'" + txtKhachHang.Text + "'," + txtSoLuong.Text +
                    ",N'" + pckNgayDat.Text + "'" +
                    ",N'" + pckNgayNhan.Text + "'" +
                    ",N'" + txtDienThoai.Text + "')";
                DataConn.ThucHienCmd(select);
                MessageBox.Show("Đã thêm đơn đặt hàng mới!");
                
            }
            catch (FormatException)
            {
                MessageBox.Show("Bạn nhập chưa đúng định dạng của dữ liệu cần thiết! Hãy xem lại hoặc nhấn F1 để vào trợ giúp!");
            }
            catch (NotEnoughInfoException)
            {
                MessageBox.Show("Bạn hãy nhập đủ các trường có dấu (*)");
            }
            catch (TimeLogicException)
            {
                MessageBox.Show("Chưa hợp lý về mặt thời gian! Bạn hãy xem lại hoặc nhấn F1 để vào trợ giúp!");
            }
        }

        private void frmThemDonDatH_Load(object sender, EventArgs e)
        {
            string select = "select* from tblMatHang";
            DataSet ds = DataConn.GrdSource(select);
            cboMatHang.DataSource = ds.Tables[0];
            cboMatHang.DisplayMember = "TenMatH";
            cboMatHang.ValueMember = "MaMatH";
            txtMatHang.Text = "";
        }

        private void cboMatHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboMatHang.ValueMember != null)
            {
                txtMatHang.Text = cboMatHang.SelectedValue.ToString();
            }
        }
    }
}