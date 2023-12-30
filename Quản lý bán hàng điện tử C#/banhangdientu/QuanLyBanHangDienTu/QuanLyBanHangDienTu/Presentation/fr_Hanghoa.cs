using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using QuanLyBanHangDienTu.Business.Component;
using QuanLyBanHangDienTu.Business.EntitiesClass;
using QuanLyBanHangDienTu.DataAccess;
using System.IO;

namespace QuanLyBanHangDienTu.Presentation
{
    public partial class fr_Hanghoa : Form
    {
        public fr_Hanghoa()
        {
            InitializeComponent();
        }
        E_tb_Hanghoa thucthi = new E_tb_Hanghoa();
        ConnectDB cn = new ConnectDB();
        EC_tb_Hanghoa ck = new EC_tb_Hanghoa();
        bool themmoi;
        int dong = 0;

        private byte[] hinhanh;
        public byte[] HINHANH
        {
            get
            {
                return hinhanh;
            }
            set
            {
                hinhanh = value;
            }
        }


        public void setnull()
        {
            txtma.Text = "";
            txtten.Text = "";
            txtdgb.Text = "0";
            txtdgn.Text = "0";
            txtsl.Text = "0";
            txtghichu.Text = "";

            cbdvt.Text = "";
            cbl.Text = "";
            cbn.Text = "";
            cbsx.Text = "";
            cbn.Text = "";
            //imghinhanh.Image = QuanLyCuaHangTivi.Properties.Resources.no;
        }
        public void locktext()
        {
            txtma.Enabled = false;
            txtten.Enabled = false;
            txtghichu.Enabled = false;
            cbdvt.Enabled = false;
            cbl.Enabled = false;
            cbn.Enabled = false;
            cbsx.Enabled = false;
            cbn.Enabled = false;
            cbcl.Enabled = false;

            btmoi.Enabled = true;
            btluu.Enabled = false;
            btsua.Enabled = true;
            btxoa.Enabled = true;
        }
        public void un_locktext()
        {
            txtma.Enabled = true;
            txtten.Enabled = true;
            txtghichu.Enabled = true;
            cbdvt.Enabled = true;
            cbl.Enabled = true;
            cbn.Enabled = true;
            cbsx.Enabled = true;
            cbn.Enabled = true;
            cbcl.Enabled = true;

            btmoi.Enabled = false;
            btluu.Enabled = true;
            btsua.Enabled = false;
            btxoa.Enabled = false;
        }
        public void khoitaoluoi()
        {
            //RepositoryItemPictureEdit image = msds.RepositoryItems.Add("PictureEdit") as RepositoryItemPictureEdit;
            msds.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            msds.Columns[0].HeaderText = "Mã Hàng";
            msds.Columns[0].Frozen = true;
            msds.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            msds.Columns[0].Width = 200;

            msds.Columns[1].HeaderText = "Tên Hàng";
            msds.Columns[1].Width = 200;

            msds.Columns[2].HeaderText = "Mã Nhóm";
            msds.Columns[2].Width = 200;

            msds.Columns[3].HeaderText = "Mã Loại";
            msds.Columns[3].Width = 200;

            msds.Columns[4].HeaderText = "Mã Đơn Vị";
            msds.Columns[4].Width = 200;

            msds.Columns[5].HeaderText = "Mã Chất Liệu";
            msds.Columns[5].Width = 200;

            msds.Columns[6].HeaderText = "Mã Nước";
            msds.Columns[6].Width = 200;

            msds.Columns[7].HeaderText = "Số Lượng";
            msds.Columns[7].Width = 200;

            msds.Columns[8].HeaderText = "Đơn Giá Nhập";
            msds.Columns[8].Width = 200;

            msds.Columns[9].HeaderText = "Đơn Giá Bán";
            msds.Columns[9].Width = 200;

            msds.Columns[10].HeaderText = "Thời Gian Bảo Hành";
            msds.Columns[10].Width = 100;

            msds.Columns[11].HeaderText = "Hình Ảnh";
            msds.Columns[11].Width = 100;
           
            msds.Columns[12].HeaderText = "Ghi Chú";
            msds.Columns[12].Width = 100;

        }
        public void hienthi()
        {
            string sql = "SELECT mahang, tenhang, manhom, maloai, madonvi, machatlieu, manuoc, soluong, dongianhap, dongiaban, thoigianbh, hinhanh, ghichu FROM tb_Hanghoa";
            msds.DataSource = cn.taobang(sql);
            SqlConnection con = cn.getcon();
            con.Open();
            try
            {
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                con.Close();
            }
        }
        private void btmoi_Click(object sender, EventArgs e)
        {
            themmoi = true;
            un_locktext();
            setnull();
            txtma.Enabled = true;
            txtma.Focus();
        }
        private void btluu_Click(object sender, EventArgs e)
        {
            if (txtma.Text != "")
            {
                if (cbn.Text != "")
                {
                    if (cbl.Text != "")
                    {
                        if (cbdvt.Text != "")
                        {
                            if (themmoi == true)
                            {
                                try
                                {
                                    byte[] imageData = ReadFile(lbimgpath.Text);
                                    ck.MAHANG = txtma.Text;
                                    ck.TENHANG = txtten.Text;
                                    ck.MANHOM = cbn.Text;
                                    ck.MALOAI = cbl.Text;
                                    ck.MADONVI = cbdvt.Text;
                                    ck.MACHATLIEU = cbcl.Text;
                                    ck.MANUOC = cbsx.Text;
                                    ck.SOLUONG = txtsl.Text;
                                    ck.DONGIANHAP = txtdgn.Text;
                                    ck.DONGIABAN = txtdgb.Text;
                                    ck.THOAIGIANBH = txtngay.Text;
                                    ck.HINHANH = imageData;
                                    ck.GHICHU = txtghichu.Text;

                                    thucthi.themoisp(ck);
                                    locktext();
                                    hienthi();
                                    MessageBox.Show("Đã Lưu Thành Công", "Chú Ý", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show(ex.ToString(), "Chú Ý", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                            }
                            else
                                try
                                {
                                    byte[] imageData = ReadFile(lbimgpath.Text);
                                    ck.MAHANG = txtma.Text;
                                    ck.TENHANG = txtten.Text;
                                    ck.MANHOM = cbn.Text;
                                    ck.MALOAI = cbl.Text;
                                    ck.MADONVI = cbdvt.Text;
                                    ck.MACHATLIEU = cbcl.Text;
                                    ck.MANUOC = cbsx.Text;
                                    ck.SOLUONG = txtsl.Text;
                                    ck.DONGIANHAP = txtdgn.Text;
                                    ck.DONGIABAN = txtdgb.Text;
                                    ck.THOAIGIANBH = txtngay.Text;
                                    ck.HINHANH = imageData;
                                    ck.GHICHU = txtghichu.Text;

                                    thucthi.suasp(ck);
                                    MessageBox.Show("Đã Sửa Thành Công Thành Công", "Chú Ý", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show(ex.ToString(), "Chú Ý", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                            txtma.Enabled = true;
                            locktext();
                            hienthi();
                        }
                        else
                        {
                            MessageBox.Show("Mã Không được để trống", "Chú Ý", MessageBoxButtons.OK);
                            cbdvt.Focus();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Mã Không được để trống", "Chú Ý", MessageBoxButtons.OK);
                        cbl.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Mã Không được để trống", "Chú Ý", MessageBoxButtons.OK);
                    cbn.Focus();
                }
            }
            else
            {
                MessageBox.Show("Mã Không được để trống", "Chú Ý", MessageBoxButtons.OK);
                txtma.Focus();
            }
        }

        private void btsua_Click(object sender, EventArgs e)
        {
            themmoi = false;
            un_locktext();
            txtma.Enabled = false;
            txtten.Focus();
        }

        private void btxoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xóa dữ liệu này?", "Chú Ý", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    ck.MAHANG = txtma.Text;

                    thucthi.xoasp(ck);
                    MessageBox.Show("Đã Xóa Thành Công", "Chú Ý", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    hienthi();
                    setnull();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Lỗi");
                }
            }
        }
        private void msds_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dong = e.RowIndex;
            txtma.Text = msds.Rows[dong].Cells[0].Value.ToString();
            txtten.Text = msds.Rows[dong].Cells[1].Value.ToString();
            cbn.Text = msds.Rows[dong].Cells[2].Value.ToString();
            cbl.Text = msds.Rows[dong].Cells[3].Value.ToString();
            cbdvt.Text = msds.Rows[dong].Cells[4].Value.ToString();
            cbcl.Text = msds.Rows[dong].Cells[5].Value.ToString();
            cbsx.Text = msds.Rows[dong].Cells[6].Value.ToString();
            txtsl.Text = msds.Rows[dong].Cells[7].Value.ToString();
            txtdgn.Text = msds.Rows[dong].Cells[8].Value.ToString();
            txtdgb.Text = msds.Rows[dong].Cells[9].Value.ToString();
            txtngay.Text = msds.Rows[dong].Cells[10].Value.ToString();
            txtghichu.Text = msds.Rows[dong].Cells[12].Value.ToString();
            locktext();
        }
        byte[] ReadFile(string sPath)
        {

            byte[] data = null;

            //sử dụng FileInfo để lấy kích thước file.
            FileInfo fInfo = new FileInfo(sPath);
            long numBytes = fInfo.Length;

            //Đọc file
            FileStream fStream = new FileStream(sPath, FileMode.Open, FileAccess.Read);

            //Sử dụng BinaryReader để đọc file vào mảng byte.
            BinaryReader br = new BinaryReader(fStream);
            data = br.ReadBytes((int)numBytes);
            return data;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dlg = new OpenFileDialog();

                dlg.Filter = "Image File (*.jpg;*.jpeg;*.bmp;*.gif;*.png)|*.jpg;*.jpeg;*.bmp;*.gif;*.png";
                dlg.Title = "Chọn Hình";

                DialogResult dlgRes = dlg.ShowDialog();
                if (dlgRes != DialogResult.Cancel)
                {
                    //Gán hình vào Picture box
                    imghinhanh.ImageLocation = dlg.FileName;
                    imghinhanh.SizeMode = PictureBoxSizeMode.StretchImage;
                    //Gán đường dẫn ảnh vào lbimgpath
                    lbimgpath.Text = dlg.FileName;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void fr_Hanghoa_Load(object sender, EventArgs e)
        {
            imghinhanh.SizeMode = PictureBoxSizeMode.StretchImage;
            try
            {
                //Get image data from gridview column.
                byte[] imageData = hinhanh;

                //Initialize image variable
                Image newImage;
                //Read image data into a memory stream
                using (MemoryStream ms = new MemoryStream(imageData, 0, imageData.Length))
                {
                    ms.Write(imageData, 0, imageData.Length);

                    //Set image variable value using memory stream.
                    newImage = Image.FromStream(ms, true);
                }

                //set picture
                imghinhanh.Image = newImage;
            }
            catch
            {

            }
            thucthi.loadmacl(cbcl);
            thucthi.loadmadv(cbdvt);
            thucthi.loadmal(cbl);
            thucthi.loadmanh(cbn);
            thucthi.loadmasx(cbsx);
            locktext();
            hienthi();
            khoitaoluoi();
        }

        private void cbn_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbn.Text = thucthi.loadtennh(lbn.Text, cbn.Text);
        }

        private void cbl_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbl.Text = thucthi.loadtenl(lbl.Text, cbl.Text);
        }

        private void cbdvt_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbdvt.Text = thucthi.loadtendv(lbdvt.Text, cbdvt.Text);
        }

        private void cbcl_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbcl.Text = thucthi.loadtencl(lbcl.Text, cbcl.Text);
        }

        private void cbsx_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbsx.Text = thucthi.loadtensx(lbsx.Text, cbsx.Text);
        }
    }
}
