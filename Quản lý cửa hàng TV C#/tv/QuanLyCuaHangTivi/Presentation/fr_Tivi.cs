using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using QuanLyCuaHangTivi.Business.Component;
using QuanLyCuaHangTivi.Business.EntitiesClass;
using QuanLyCuaHangTivi.DataAccess;
using System.IO;

namespace QuanLyCuaHangTivi.Presentation
{
    public partial class fr_Tivi : Form
    {
        public fr_Tivi()
        {
            InitializeComponent();
        }
        E_tb_Tivi thucthi = new E_tb_Tivi();
        ConnectDB cn = new ConnectDB();
        EC_tb_Tivi ck = new EC_tb_Tivi();
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
            cbmahang.Text = "";
            cbmakieu.Text = "";
            cbmau.Text = "";
            cbmanhinh.Text = "";
            cbcomh.Text = "";
            cbnoisx.Text = "";
            txtdgb.Text = "0";
            txtdgn.Text = "0";
            txtgc.Text = "";
            txtsl.Text = "0";
            txtngay.Text = "";
            imghinhanh.Image = QuanLyCuaHangTivi.Properties.Resources.no;
        }
        public void locktext()
        {
            txtma.Enabled = false;
            txtten.Enabled = false;
            cbmahang.Enabled = false;
            cbmakieu.Enabled = false;
            cbmau.Enabled = false;
            cbmanhinh.Enabled = false;
            cbcomh.Enabled = false;
            cbnoisx.Enabled = false;
            txtgc.Enabled = false;
            txtngay.Enabled = false;


            btmoi.Enabled = true;
            btluu.Enabled = false;
            btsua.Enabled = true;
            btxoa.Enabled = true;
        }
        public void un_locktext()
        {
            txtma.Enabled = true;
            txtten.Enabled = true;
            cbmahang.Enabled = true;
            cbmakieu.Enabled = true;
            cbmau.Enabled = true;
            cbmanhinh.Enabled = true;
            cbcomh.Enabled = true;
            cbnoisx.Enabled = true;
            txtgc.Enabled = true;
            txtngay.Enabled = true;

            btmoi.Enabled = false;
            btluu.Enabled = true;
            btsua.Enabled = false;
            btxoa.Enabled = false;
        }
        public void khoitaoluoi()
        {
            //RepositoryItemPictureEdit image = msds.RepositoryItems.Add("PictureEdit") as RepositoryItemPictureEdit;
            msds.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            msds.Columns[0].HeaderText = "Mã Tivi";
            msds.Columns[0].Frozen = true;
            msds.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            msds.Columns[0].Width = 200;

            msds.Columns[1].HeaderText = "Tên Tivi";
            msds.Columns[1].Width = 200;

            msds.Columns[2].HeaderText = "Hãng SX";
            msds.Columns[2].Width = 200;

            msds.Columns[3].HeaderText = "Mã Kiểu";
            msds.Columns[3].Width = 200;

            msds.Columns[4].HeaderText = "Mã Màu";
            msds.Columns[4].Width = 200;

            msds.Columns[5].HeaderText = "Mã Màn Hình";
            msds.Columns[5].Width = 200;

            msds.Columns[6].HeaderText = "Mã Cỡ";
            msds.Columns[6].Width = 200;

            msds.Columns[7].HeaderText = "Nơi Sản Xuất";
            msds.Columns[7].Width = 200;

            msds.Columns[8].HeaderText = "Giá Nhập";
            msds.Columns[8].Width = 200;

            msds.Columns[9].HeaderText = "Gía Bán";
            msds.Columns[9].Width = 200;

            msds.Columns[10].HeaderText = "Ảnh";
            msds.Columns[10].Width = 100;

            msds.Columns[11].HeaderText = "Ghi Chú";
            msds.Columns[11].Width = 100;

            msds.Columns[12].HeaderText = "Số Lượng";
            msds.Columns[12].Width = 100;

            msds.Columns[13].HeaderText = "Bảo Hành";
            msds.Columns[13].Width = 100;

        }
        public void hienthi()
        {
            string sql = "SELECT     mativi, tentivi, mahangsx, makieu, mamau, mamanhinh, maco, manoisx, dongianhap, dongiaban, anh, ghichu, soluong, thoigianbaohanh FROM tb_Tivi";
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
                if (cbmahang.Text != "'")
                {
                    if (cbmakieu.Text != "")
                    {
                        if (cbmau.Text != "")
                        {
                            if (cbmanhinh.Text != "")
                            {
                                if (cbcomh.Text != "")
                                {
                                    if (cbnoisx.Text != "")
                                    {
                                        if (lbimgpath.Text == "")
                                        {
                                            Bitmap bm = new Bitmap(this.imghinhanh.Image);
                                            bm.Save(@"C:\temp.jpg", System.Drawing.Imaging.ImageFormat.Jpeg);
                                            lbimgpath.Text = "C:\\temp.jpg";
                                        }
                                        if (themmoi == true)
                                        {
                                            try
                                            {
                                                byte[] imageData = ReadFile(lbimgpath.Text);
                                                ck.MATIVI = txtma.Text;
                                                ck.TENTIVI = txtten.Text;
                                                ck.MAHANGSX = cbmahang.Text;
                                                ck.MAKIEU = cbmakieu.Text;
                                                ck.MAMAU = cbmau.Text;
                                                ck.MAMANHINH = cbmanhinh.Text;
                                                ck.MACO = cbcomh.Text;
                                                ck.MANOISX = cbnoisx.Text;
                                                ck.DONGIABAN = txtdgb.Text;
                                                ck.DONGIANHAP = txtdgn.Text;
                                                ck.GHICHU = txtgc.Text;
                                                ck.SOLUONG = txtsl.Text;
                                                ck.THOIGIANBAOHANH = txtngay.Text;
                                                ck.ANH = imageData;

                                                thucthi.themoitv(ck);
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
                                                ck.MATIVI = txtma.Text;
                                                ck.TENTIVI = txtten.Text;
                                                ck.MAHANGSX = cbmahang.Text;
                                                ck.MAKIEU = cbmakieu.Text;
                                                ck.MAMAU = cbmau.Text;
                                                ck.MAMANHINH = cbmanhinh.Text;
                                                ck.MACO = cbcomh.Text;
                                                ck.MANOISX = cbnoisx.Text;
                                                ck.DONGIABAN = txtdgb.Text;
                                                ck.DONGIANHAP = txtdgn.Text;
                                                ck.GHICHU = txtgc.Text;
                                                ck.SOLUONG = txtsl.Text;
                                                ck.THOIGIANBAOHANH = txtngay.Text;
                                                ck.ANH = imageData;

                                                thucthi.suatv(ck);
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
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Mã Không được để trống", "Chú Ý", MessageBoxButtons.OK);
                                }
                            }
                            else
                            {
                                MessageBox.Show("Mã Không được để trống", "Chú Ý", MessageBoxButtons.OK);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Mã Không được để trống", "Chú Ý", MessageBoxButtons.OK);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Mã Không được để trống", "Chú Ý", MessageBoxButtons.OK);
                    }
                }
                else
                {
                    MessageBox.Show("Mã Không được để trống", "Chú Ý", MessageBoxButtons.OK);
                    txtma.Focus();
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
                    ck.MATIVI = txtma.Text;

                    thucthi.xoatv(ck);
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
        private void fr_Tivi_Load(object sender, EventArgs e)
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
            thucthi.loadmahsx(cbmahang);
            thucthi.loadkieu(cbmakieu);
            thucthi.loadmam(cbmau);
            thucthi.loadmaMH(cbmanhinh);
            thucthi.loadcmh(cbcomh);
            thucthi.loadmasx(cbnoisx);
            locktext();
            hienthi();
            khoitaoluoi();
        }

        private void msds_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dong = e.RowIndex;
            txtma.Text = msds.Rows[dong].Cells[0].Value.ToString();
            txtten.Text = msds.Rows[dong].Cells[1].Value.ToString();
            cbmahang.Text = msds.Rows[dong].Cells[2].Value.ToString();
            cbmakieu.Text = msds.Rows[dong].Cells[3].Value.ToString();
            cbmau.Text = msds.Rows[dong].Cells[4].Value.ToString();
            cbmanhinh.Text = msds.Rows[dong].Cells[5].Value.ToString();
            cbcomh.Text = msds.Rows[dong].Cells[6].Value.ToString();
            cbnoisx.Text = msds.Rows[dong].Cells[7].Value.ToString();
            txtdgn.Text = msds.Rows[dong].Cells[8].Value.ToString();
            txtdgb.Text = msds.Rows[dong].Cells[9].Value.ToString();
            imghinhanh.Image = QuanLyCuaHangTivi.Properties.Resources.no;
            txtgc.Text = msds.Rows[dong].Cells[11].Value.ToString();
            txtsl.Text = msds.Rows[dong].Cells[12].Value.ToString();
            txtngay.Text = msds.Rows[dong].Cells[13].Value.ToString();
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

        private void button2_Click(object sender, EventArgs e)
        {
            imghinhanh.Image = QuanLyCuaHangTivi.Properties.Resources.no;
        }

        private void cbmahang_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbhang.Text = thucthi.loadtenhsx(lbhang.Text, cbmahang.Text);
        }

        private void cbmakieu_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbkieu.Text = thucthi.loadtenk(lbkieu.Text, cbmakieu.Text);
        }

        private void cbmau_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbmau.Text = thucthi.loadtenm(lbmau.Text, cbmau.Text);
        }

        private void cbmanhinh_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbmanhinh.Text = thucthi.loadtenMH(lbmanhinh.Text, cbmanhinh.Text);
        }

        private void cbcomh_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void cbnoisx_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbnoisx.Text = thucthi.loadtensx(lbnoisx.Text, cbnoisx.Text);
        }
    }
}
