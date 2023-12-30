using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _20_BanHangSieuThi
{
    public partial class DMHangHoa : Form
    {
        DataTable tblHang;
        public DMHangHoa()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void DMHangHoa_Load(object sender, EventArgs e)
        {
            txtMavach.Enabled = false;
            btnLuu.Enabled = false;
            btnboqua.Enabled = false;
            Load_DataGridView();
            Data.FillCombo("SELECT Manhom,Tennhom FROM tblNhomHang", cboManhom, "Manhom", "Tennhom");
            cboManhom.SelectedIndex = -1;
            Data.FillCombo("SELECT Maloai,Tenloai FROM tblTheLoai", cboMaloai, "Maloai", "Tenloai");
            cboMaloai.SelectedIndex = -1;
            Data.FillCombo("SELECT Manoisx,TenNoiSX FROM tblNoiSanXuat", cboNhapkhau, "Manoisx", "TenNoiSX");
            cboNhapkhau.SelectedIndex = -1;
            Data.FillCombo("SELECT Manoisx,TenNoiSX FROM tblNoiSanXuat", cboNoisanxuat, "TenNoiSX", "Manoisx");
            cboNoisanxuat.SelectedIndex = -1;
            Data.FillCombo("SELECT Madonvi,TenDonVi FROM tblDonViTinh", cboMadonvi, "Madonvi", "TenDonVi");
            cboMadonvi.SelectedIndex = -1;
            Data.FillCombo("SELECT Machatlieu,TenChatLieu FROM tblChatLieu", cboMachatlieu, "Machatlieu", "TenChatLieu");
            cboMachatlieu.SelectedIndex = -1;
            Data.FillCombo("SELECT Macongdung,TenCongDung FROM tblCongDung", cboMacongdung, "Macongdung", "TenCongDung");
            cboMacongdung.SelectedIndex = -1;
            ResetValues();
        }

        private void ResetValues()
        {
            txtMavach.Text = "";
            txtTenhanghoa.Text = "";
            cboMacongdung.Text = "";
            cboMachatlieu.Text = "";
            cboMadonvi.Text = "";
            cboMaloai.Text = "";
            cboManhom.Text = "";
            cboNoisanxuat.Text = "";
            cboNhapkhau.Text = "";
            cboSoluong.Text = "0";
            cboDongianhap.Text = "0";
            cboDongiaban.Text = "0";
            txtAnh.Text = "";
            picAnh.Image = null;
            cboSoluong.Enabled = false;
            cboDongianhap.Enabled = false;
            cboDongiaban.Enabled = false;
            txtGhiChu.Text = "";
        }

        private void Load_DataGridView()
        {
            string sql = "SELECT Mavach,Tenhanghoa,Manhom,Maloai,Nhapkhau,Madonvi,Machatlieu,Macongdung,Manoisx,Soluong,Dongianhap,Dongiaxuat FROM tblDMHangHoa";
            tblHang = Data.GetDataToTable(sql);
            dgvHang.DataSource = tblHang;
            dgvHang.Columns[0].HeaderText = "Mã vạch";
            dgvHang.Columns[1].HeaderText = "Tên hàng hóa";
            dgvHang.Columns[2].HeaderText = "Nhóm hàng";
            dgvHang.Columns[3].HeaderText = "Loại hàng";
            dgvHang.Columns[4].HeaderText = "Nhập khẩu";
            dgvHang.Columns[5].HeaderText = "Đơn vị";
            dgvHang.Columns[6].HeaderText = "Chất liệu";
            dgvHang.Columns[7].HeaderText = "Công dụng";
            dgvHang.Columns[8].HeaderText = "Nơi sản xuất";
            dgvHang.Columns[9].HeaderText = "Số lượng";
            dgvHang.Columns[10].HeaderText = "Đơn giá nhập";
            dgvHang.Columns[11].HeaderText = "Đơn giá xuất";
            dgvHang.Columns[0].Width = 80;
            dgvHang.Columns[1].Width = 100;
            dgvHang.Columns[2].Width = 100;
            dgvHang.Columns[3].Width = 80;
            dgvHang.Columns[4].Width = 80;
            dgvHang.Columns[5].Width = 80;
            dgvHang.Columns[6].Width = 80;
            dgvHang.Columns[7].Width = 80;
            dgvHang.Columns[8].Width = 80;
            dgvHang.Columns[9].Width = 80;
            dgvHang.Columns[10].Width = 80;
            dgvHang.Columns[11].Width = 80;
            dgvHang.AllowUserToAddRows = false;
            dgvHang.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void dgvHang_Click(object sender, EventArgs e)
        {
            string Manhom, Maloai, Nhapkhau, noisx, donvi, chatlieu, congdung;
            if (btnThem.Enabled == false)
            {
                MessageBox.Show("Đang chờ thêm mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMavach.Focus();
                return;
            }

            if (tblHang.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            txtMavach.Text = dgvHang.CurrentRow.Cells["Mavach"].Value.ToString();
            txtTenhanghoa.Text = dgvHang.CurrentRow.Cells["Tenhanghoa"].Value.ToString();
            Manhom = dgvHang.CurrentRow.Cells["Manhom"].Value.ToString();
            cboManhom.Text = Data.GetFieldValues("SELECT Tennhom FROM tblNhomHang WHERE Manhom=N'" + Manhom + "'");
            Maloai = dgvHang.CurrentRow.Cells["Maloai"].Value.ToString();
            cboMaloai.Text = Data.GetFieldValues("SELECT Tenloai FROM tblTheLoai WHERE Maloai=N'" + Maloai + "'");
            Nhapkhau = dgvHang.CurrentRow.Cells["Nhapkhau"].Value.ToString();
            cboNhapkhau.Text = Data.GetFieldValues("SELECT TennoiSX FROM tblNoiSanXuat WHERE Manoisx =N'" + Nhapkhau + "'");
            noisx = dgvHang.CurrentRow.Cells["Manoisx"].Value.ToString();
            cboNoisanxuat.Text = Data.GetFieldValues("SELECT Manoisx FROM tblNoiSanXuat");
            donvi = dgvHang.CurrentRow.Cells["Madonvi"].Value.ToString();
            cboMadonvi.Text = Data.GetFieldValues("SELECT Tendonvi FROM tblDonViTinh WHRERE Madonvi =N'" + donvi + "'");
            chatlieu = dgvHang.CurrentRow.Cells["Machatlieu"].Value.ToString();
            cboMachatlieu.Text = Data.GetFieldValues("SELECT Tenchatlieu FROM ChatLieu WHERE Machatlieu=N'" + chatlieu + "'");
            congdung = dgvHang.CurrentRow.Cells["Macongdung"].Value.ToString();
            cboMacongdung.Text = Data.GetFieldValues("SELECT Tencongdung FROM CongDung WHERE Macongdung=N'" + congdung + "'");
            cboSoluong.Text = dgvHang.CurrentRow.Cells["Soluong"].Value.ToString();
            cboDongianhap.Text = dgvHang.CurrentRow.Cells["Dongianhap"].Value.ToString();
            cboDongiaban.Text = dgvHang.CurrentRow.Cells["Dongiaxuat"].Value.ToString();
            txtAnh.Text = Data.GetFieldValues("SELECT Anh FROM tblDMHangHoa WHERE Mavach=N'" + txtMavach.Text + "'");
            picAnh.Image = Image.FromFile(txtAnh.Text);
            txtGhiChu.Text = Data.GetFieldValues("SELECT Ghichu FROM tblDMHangHoa WHERE Mavach=N'" + txtMavach.Text + "'");
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnboqua.Enabled = true;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnThem.Enabled = false;
            btnboqua.Enabled = true;
            btnLuu.Enabled = true;
            ResetValues();
            txtMavach.Enabled = true;
            txtMavach.Focus();
            cboSoluong.Enabled = false;
            cboDongiaban.Enabled = false;
            cboDongianhap.Enabled = false;
            return;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (tblHang.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMavach.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (txtTenhanghoa.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên hàng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTenhanghoa.Focus();
                return;
            }
            if (cboManhom.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã nhóm hàng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cboManhom.Focus();
                return;
            }
            string sql = "UPDATE tblDMHangHoa SET Tenhanghoa=N'" + txtTenhanghoa.Text.Trim().ToString() + "',Manhom=N'" + cboManhom.SelectedValue.ToString() + "',Maloai=N'" + cboMaloai.SelectedValue.ToString() + "',NoiSanXuat=N'" + cboNoisanxuat.SelectedValue.ToString() + "',DonVi=N'" + cboMadonvi.SelectedValue.ToString() + "',ChatLieu=N'" + cboMachatlieu.SelectedValue.ToString() + "',CongDung=N'" + cboMacongdung.SelectedValue.ToString() + "',Anh='" + txtAnh.Text + "',GhiChu=N'" + txtGhiChu.Text + "'WHERE Mavach=N'" + txtMavach.Text + "'";
            Data.RunSql(sql);
            Load_DataGridView();
            ResetValues();
            btnboqua.Enabled = false;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtMavach.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã hàng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMavach.Focus();
                return;
            }

            if (txtTenhanghoa.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên hàng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTenhanghoa.Focus();
                return;
            }

            if (cboManhom.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã nhóm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cboManhom.Focus();
                return;
            }

            if (cboMaloai.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã loại hàng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cboMaloai.Focus();
                return;
            }

            if (cboMacongdung.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã công dụng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cboMacongdung.Focus();
                return;
            }

            if (cboMachatlieu.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã chất liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cboMachatlieu.Focus();
                return;
            }

            if (cboMadonvi.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã đơn vị!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cboMadonvi.Focus();
                return;
            }

            if (cboNoisanxuat.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã nơi sản xuất!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cboNoisanxuat.Focus();
                return;
            }

            if (cboNhapkhau.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập nơi nhập khẩu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cboNhapkhau.Focus();
                return;
            }

            if (txtAnh.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải chọn hình ảnh minh họa cho hàng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtAnh.Focus();
                return;
            }

            string sql= "SELECT Mavach FROM tblDMHangHoa WHERE Mavach=N'"+txtMavach.Text.Trim()+"'";
            if (Data.Checkey(sql))
            {
                MessageBox.Show("Mã hàng hóa này đã có,bạn phải nhập mã khác!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMavach.Focus();
                txtMavach.Text = "";
                return;
            }

            sql = "INSERT INTO tblDMHangHoa(Mavach,Tenhanghoa,Manhom,Maloai,Nhapkhau,Madonvi,Machatlieu,Macongdung,Manoisx,Soluong,Dongianhap,Dongiaxuat,Anh,Ghichu)VALUES (N'" + txtMavach.Text.Trim() + "',N'" + txtTenhanghoa.Text.Trim() + "',N'" + cboManhom.SelectedValue.ToString() + "',N'" + cboMaloai.SelectedValue.ToString() + "',N'" + cboNhapkhau.SelectedValue.ToString() + "',N'" + cboNoisanxuat.SelectedValue.ToString() + "',N'" + cboMadonvi.SelectedValue.ToString() + "',N'" + cboMachatlieu.SelectedValue.ToString() + "',N'" + cboMacongdung.SelectedValue.ToString() + "',N'" + cboSoluong.Text.Trim() + "," + cboDongianhap.Text + "," + cboDongiaban.Text + ",N'"+txtAnh.Text+"',N'"+txtGhiChu.Text.Trim()+"')";
            Data.RunSql(sql);
            Load_DataGridView();
            ResetValues();
            btnThem.Enabled = true;
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
            btnboqua.Enabled = false;
            btnLuu.Enabled = false;
            txtMavach.Enabled = false;

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblHang.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (txtMavach.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if(MessageBox.Show("Bạn có muốn xóa không?","Thông báo",MessageBoxButtons.OKCancel,MessageBoxIcon.Question)==DialogResult.OK)
            {
                sql="DELETE tblDMHangHoa WHERE MaHang=N'"+txtMavach.Text+"'";
                Data.RunSqlDel(sql);
                Load_DataGridView();
                ResetValues();
        }
       
    }

        private void btnboqua_Click(object sender, EventArgs e)
        {
            ResetValues();
            btnboqua.Enabled = false;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnLuu.Enabled = false;
            txtMavach.Enabled = false;
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlgOpen = new OpenFileDialog();
            dlgOpen.Filter = "All files(*.*)|*.*";
            dlgOpen.InitialDirectory = "D:\\Bài thi\\Bài thi C#";
            dlgOpen.FilterIndex = 2;
            dlgOpen.Title = "Chọn hình ảnh của mặt hàng!";
            if (dlgOpen.ShowDialog() == DialogResult.OK)
            {
                picAnh.Image = Image.FromFile(dlgOpen.FileName);
                txtAnh.Text = dlgOpen.FileName;
            }

        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            if ((txtMavach.Text == "") && (txtTenhanghoa.Text == "") && (cboMachatlieu.Text == "") && (cboMacongdung.Text == "") && (cboMadonvi.Text == "") && (cboMaloai.Text == "") && (cboManhom.Text == "") && (cboNoisanxuat.Text == "") && (cboNhapkhau.Text == ""))
            {
                MessageBox.Show("Hãy nhập một điều kiện tìm kiếm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            string sql = "SELECT * FROM HangHoa WHERE 1=1";
            if (txtMavach.Text != "")
                sql = sql + "AND Mavach like N'%" + txtMavach.Text + "%'";
            if (txtTenhanghoa.Text != "")
                sql = sql + "AND Tenhanghoa Like N'%" + txtTenhanghoa.Text + "%'";
            if (cboMacongdung.Text != "")
                sql = sql + "AND Macongdung Like N'%" + cboMacongdung.SelectedValue + "%'";
            if (cboMachatlieu.Text != "")
                sql = sql + "AND Machatlieu Like N'%" + cboMachatlieu.SelectedValue + "%'";
            if (cboMadonvi.Text != "")
                sql = sql + "AND Madonvi Like N'%" + cboMadonvi.SelectedValue + "%'";
            if (cboMaloai.Text != "")
                sql = sql + "AND Maloai Like N'%" + cboMaloai.SelectedValue + "%'";
            if (cboManhom.Text != "")
                sql = sql + "AND Manhom Like N'%" + cboManhom.SelectedValue + "%'";
            if (cboNoisanxuat.Text != "")
                sql = sql + "AND Manoisx Like N'%" + cboNoisanxuat.SelectedValue + "%'";
            if (cboNhapkhau.Text != "")
                sql = sql + "AND TenNoiSX Like N'%" + cboNoisanxuat.SelectedValue + "%'";
            tblHang = Data.GetDataToTable(sql);
            if (tblHang.Rows.Count == 0)
                MessageBox.Show("Không có bản ghi thỏa mãn điều kiện!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Có " + tblHang.Rows.Count + " bản ghi thỏa mãn điều kiện!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dgvHang.DataSource = tblHang;
            ResetValues();

        }

        private void btnHienthi_Click(object sender, EventArgs e)
        {
            string sql = "SELECT Mavach,Tenhanghoa,Manhom,Maloai,Nhapkhau,Manoisx,Madonvi,Machatlieu,Macongdung,Soluong,Dongianhap,Dongiaxuat,Anh,Ghichu FROM tblDMHangHoa";
            tblHang = Data.GetDataToTable(sql);
            dgvHang.DataSource = tblHang;
        }
    }
}
