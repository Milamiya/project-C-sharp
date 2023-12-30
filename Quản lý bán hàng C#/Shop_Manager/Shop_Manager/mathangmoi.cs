using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Shop_Manager
{
    public partial class frmNewMatH : Form
    {
        public frmNewMatH()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                //Exception khi không đủ dữ liệu
                if (txtMaMatH.Text == "" || txtTenMatH.Text == "" || txtSoLuong.Text == "" || txtDonGia.Text == "")
                {
                    throw new NotEnoughInfoException();
                }
                
                //Exception khi trùng Mã mặt hàng (trùng khóa chính)
                string select1 = "select MaMatH from tblMatHang";
                SqlDataReader dr = DataConn.ThucHienReader(select1);
                if (dr != null)
                {
                    while (dr.Read())
                    {
                        if (dr.GetString(0) == txtMaMatH.Text)
                        {
                            dr.Close();
                            dr.Dispose();
                            throw new SameKeyException();
                        }
                    }
                }
                dr.Close();
                dr.Dispose();

                string select = "insert into tblMatHang values(N'" + txtMaMatH.Text + "',N'" + txtTenMatH.Text + "'," + txtSoLuong.Text + "," + txtDonGia.Text +","+ (float.Parse(txtDonGia.Text)+20000) + ")";
                DataConn.ThucHienCmd(select);
                MessageBox.Show("Đã nhập thêm mặt hàng mới!");
            }
            catch (FormatException)
            {
                MessageBox.Show("Không đúng định dạng cần thiết! Hãy xem trợ giúp!");
            }
            catch (SameKeyException)
            {
                MessageBox.Show("Đã có mặt hàng với mã này! Hãy đổi mã mặt hàng khác!");
            }
            catch (NotEnoughInfoException)
            {
                MessageBox.Show("Bạn hãy nhập đủ các trường có dấu (*)");
            }
        }
    }
}