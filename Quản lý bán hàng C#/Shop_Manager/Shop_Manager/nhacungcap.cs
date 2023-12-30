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
    public partial class frmNCC : Form
    {
        public frmNCC()
        {
            InitializeComponent();
        }

        private void frmNCC_Load(object sender, EventArgs e)
        {
            string select = "select* from tblMatHang";
            DataSet ds = DataConn.GrdSource(select);

            cboMaMatH.DataSource = ds.Tables[0];
            cboMaMatH.DisplayMember = "TenMatH";
            cboMaMatH.ValueMember = "MaMatH";

            txtMaMatH.Text = "";
        }

        private void cboMaMatH_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboMaMatH.ValueMember != null)
            {
                txtMaMatH.Text = cboMaMatH.SelectedValue.ToString();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                //Exception khi không đủ dữ liệu để nhập
                if (txtMaNCC.Text == "" || txtMaMatH.Text == "" || txtTenNCC.Text == "" || txtDienThoai.Text == "")
                {
                    throw new NotEnoughInfoException();
                }
                //Exception khi trùng mã nhà cung cấp
                string select1 = "select MaNCC from tblNhaCungCap";
                SqlDataReader dr = DataConn.ThucHienReader(select1);
                if (dr != null)
                {
                    while (dr.Read())
                    {
                        if (dr.GetString(0) == txtMaNCC.Text)
                        {
                            dr.Close();
                            dr.Dispose();
                            throw new SameKeyException();
                        }
                    }
                }
                dr.Close();
                dr.Dispose();

                string select = "insert into tblNhaCungCap(MaNCC,MaMatH,TenNCC,DienThoai) values('" + txtMaNCC.Text + "','" + txtMaMatH.Text + "','" + txtTenNCC.Text + "','" + txtDienThoai.Text + "')";
                DataConn.ThucHienCmd(select);
                MessageBox.Show("Đã thêm nhà cung cấp mới!");
            }
            catch (FormatException)
            {
                MessageBox.Show("Không đúng định dạng cần thiết! Hãy xem trợ giúp");
            }
            catch (SameKeyException)
            {
                MessageBox.Show("Đã có nhà cung cấp với mã này! Hãy nhập mã khác!");
            }
            catch (NotEnoughInfoException)
            {
                MessageBox.Show("Bạn hãy nhập đủ các trường có dấu (*)");
            }
        }
    }
}