using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Shop_Manager
{
    public partial class frmNhanVienMoi : Form
    {
        public frmNhanVienMoi()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string select = "";
            try
            {
                if (txtMaNV.Text == "" || txtTenNV.Text == "" || txtDiaChi.Text == "")
                    throw new NotEnoughInfoException();

                string select1 = "select MaNhanVien from tblNhanVien";
                SqlDataReader dr = DataConn.ThucHienReader(select1);
                if (dr != null)
                {
                    while (dr.Read())
                    {
                        if (dr.GetString(0) == txtMaNV.Text)
                        {
                            dr.Close();
                            dr.Dispose();
                            throw new SameKeyException();
                        }
                    }
                }
                dr.Close();
                dr.Dispose();

                select = "insert into tblNhanVien values(N'"+txtMaNV.Text+"',N'"+txtTenNV.Text+"',N'"+txtDiaChi.Text+"',N'"+txtDienThoai.Text+"')";
                DataConn.ThucHienCmd(select);
                MessageBox.Show("Đã thêm nhân viên "+txtTenNV.Text+" vào danh sách nhân viên!");
            }
            catch (FormatException)
            {
                MessageBox.Show("Không đúng định dạng dữ liệu cần thiết! Bạn hãy xem lại hoặc nhấn F1 để vào trợ giúp!");
            }
            catch (NotEnoughInfoException)
            {
                MessageBox.Show("Bạn hãy nhập đủ các trường có dấu (*)");
            }
            catch (SameKeyException)
            {
                MessageBox.Show("Đã có mã nhân viên này! Bạn hãy chọn một mã khác!");
            }
        }
    }
}