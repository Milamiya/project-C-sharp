using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BUS_Tier;

namespace detai_HoangQuan
{
    public partial class frmHome : Form
    {
        public frmHome()
        {
            InitializeComponent();
        }
        // khai bao 
        private DataTable dtBaiHat_BaiHat;
        private DataTable dtBaiHat;
        private DataTable dtAlbum;
        private DataTable dtTheLoai;
        private DataTable dtCasi;
        private DataTable dtTacGia;
        private DataTable dtNhaSanXuat;
        private DataTable dtBaiHat_home;
        private DataTable dtCasi_Baihat;

        private DataView dvBaiHatHome;

        bool danapxong_lstBox = false;
        private void frmHome_Load(object sender, EventArgs e)
        {
            load_BaiHat_home();
            load_Album(); 
            load_TheLoai();
            load_Casi();
            load_TacGia();
            load_NhaSanXuat();

            load_combobox_baihat();
            load_Baihat();

            
            danapxong_lstBox = true;
        }
        #region Các hàm load dử liệu

        private void load_Baihat()
        {
            dtBaiHat_BaiHat = new BaiHat_BUS().getBaiHat();
            
            //dtBaiHat_BaiHat = new BaiHat_BUS().getBaiHat_cbo("theloainhac_cachmang", "damtrongtim", "damvinhhung", "nguyenvanchung", "rangdong");
            //dtBaiHat_BaiHat = new BaiHat_BUS().getBaiHat_cbo(cboTheLoai.SelectedValue.ToString(), cboAlbum.SelectedValue.ToString(), cboCasi.SelectedValue.ToString(), cbotacGia.SelectedValue.ToString(), cboHangsanxuat.SelectedValue.ToString());
            foreach (DataRow dr in dtBaiHat_BaiHat.Rows)
            {
                ListViewItem li = lvwBaiHat.Items.Add("");
                li.SubItems.Add(dr["tenbaihat"].ToString());
                li.SubItems.Add(dr["loibaihat"].ToString());
                li.Tag = dr["mabaihat"];
            }
            stt(lvwBaiHat);
        }
        
        private void load_combobox_baihat()
        {

            cboTheLoai.DataSource = dtTheLoai;
            cboTheLoai.DisplayMember = "tentheloai";
            cboTheLoai.ValueMember = "matheloai";

            cboAlbum.DataSource = dtAlbum;
            cboAlbum.DisplayMember = "tenalbum";
            cboAlbum.ValueMember = "maalbum";

            cboCasi.DataSource = dtCasi;
            cboCasi.DisplayMember = "tencasi";
            cboCasi.ValueMember = "macasi";

            cbotacGia.DataSource = dtTacGia;
            cbotacGia.DisplayMember = "tentacgia";
            cbotacGia.ValueMember = "matacgia";

            cboHangsanxuat.DataSource = dtNhaSanXuat;
            cboHangsanxuat.DisplayMember = "tenhangsanxuat";
            cboHangsanxuat.ValueMember = "mahangsanxuat";
            
        }
        
        private void load_BaiHat_home()
        {
            dtBaiHat_home = new BaiHat_BUS().getBaiHat_home();
            foreach (DataRow dr in dtBaiHat_home.Rows)
            {
                ListViewItem li = lvwBaiHat_Home.Items.Add("");
                li.SubItems.Add(dr["tenbaihat"].ToString());
                li.SubItems.Add(dr["tenalbum"].ToString());
                DataTable dt = new Casi_Baihat_BUS().getCasi_BaiHat_by_mabaihat(dr["mabaihat"].ToString());
                string cac_casi = "";
                foreach (DataRow r in dt.Rows)
                {
                    DataTable dtcasi = new CaSi_BUS().getCasi_by_macasi(r["macasi"].ToString());
                    foreach (DataRow r1 in dtcasi.Rows)
                    {
                        cac_casi += r1["tencasi"].ToString() + ", ";
                    }
                }
                li.SubItems.Add(cac_casi + "...");
                li.SubItems.Add(dr["tentheloai"].ToString());
                li.SubItems.Add(dr["loibaihat"].ToString());
                li.Tag = dr["mabaihat"];
            }
            stt(lvwBaiHat_Home);
        }

        private void load_NhaSanXuat()
        {
            dtNhaSanXuat = new NhaSanXuat_BUS().getNhaSanXuat();
            lstNhaSanXuat.DataSource = dtNhaSanXuat;
            lstNhaSanXuat.DisplayMember = "tenhangsanxuat";
            lstNhaSanXuat.ValueMember = "mahangsanxuat";
        }

        private void load_TacGia()
        {
            dtTacGia = new TacGia_BUS().getTacGia();
            lstDanhSachNhacSi.DataSource = dtTacGia;
            lstDanhSachNhacSi.DisplayMember = "tentacgia";
            lstDanhSachNhacSi.ValueMember = "matacgia";
        }

        private void load_Casi()
        {
            dtCasi = new CaSi_BUS().getCaSi();
            lstDanhSachCaSi.DataSource = dtCasi;
            lstDanhSachCaSi.DisplayMember = "tencasi";
            lstDanhSachCaSi.ValueMember = "macasi";
            
        }

        private void load_TheLoai()
        {
            dtTheLoai = new TheLoai_BUS().getTheLoai();
            foreach (DataRow dr in dtTheLoai.Rows)
            {
                ListViewItem li = lvwTheLoai.Items.Add("");
                li.SubItems.Add(dr["tentheloai"].ToString());
                
                li.Tag = dr["matheloai"];
            }
            stt(lvwTheLoai);
        }

        private void load_Album()
        {
            dtAlbum = new Album_BUS().getAlbum();
            foreach (DataRow dr in dtAlbum.Rows)
            {
                ListViewItem li = lvwAlbum.Items.Add("");
                li.SubItems.Add(dr["tenalbum"].ToString());
                li.SubItems.Add(dr["namphathanh"].ToString());
                li.Tag = dr["maalbum"];
            }
            stt(lvwAlbum);
        }
        #endregion

        #region các hàm xử lý
        private static string[] VietNamChar = new string[]
        {
           "aAeEoOuUiIdDyY",
           "áàạảãâấầậẩẫăắằặẳẵ",
           "ÁÀẠẢÃÂẤẦẬẨẪĂẮẰẶẲẴ",
           "éèẹẻẽêếềệểễ",
           "ÉÈẸẺẼÊẾỀỆỂỄ",
           "óòọỏõôốồộổỗơớờợởỡ",
           "ÓÒỌỎÕÔỐỒỘỔỖƠỚỜỢỞỠ",
           "úùụủũưứừựửữ",
           "ÚÙỤỦŨƯỨỪỰỬỮ",
           "íìịỉĩ",
           "ÍÌỊỈĨ",
           "đ",
           "Đ",
           "ýỳỵỷỹ",
           "ÝỲỴỶỸ"
        };
        // ham thay the tieng viet co dau sang k dau
        public static string ThayThe_Unicode(string strInput)
        {
            for (int i = 1; i < VietNamChar.Length; i++)
            {
                for (int j = 0; j < VietNamChar[i].Length; j++)
                {
                    strInput = strInput.Replace(VietNamChar[i][j], VietNamChar[0][i - 1]);
                }
            }
            return strInput;
        }
        private void hienbaihat(DataView dv, ListView lvw)
        {
            lvw.Items.Clear();
            foreach (DataRowView dr in dv)
            {
                ListViewItem li = lvw.Items.Add("");
                li.SubItems.Add(dr["tenbaihat"].ToString());
            }
            stt(lvw);
        }

        private void sapxep_home(string kieusapxep)
        {
            dtBaiHat_home = new BaiHat_BUS().getBaiHat_home();
            dvBaiHatHome = new DataView(dtBaiHat_home);
            dvBaiHatHome.Sort = "tenbaihat "+kieusapxep+"";
            dtBaiHat_home = new BaiHat_BUS().getBaiHat_home();
            foreach (DataRowView dr in dvBaiHatHome)
            {
                ListViewItem li = lvwBaiHat_Home.Items.Add("");
                li.SubItems.Add(dr["tenbaihat"].ToString());
                li.SubItems.Add(dr["tenalbum"].ToString());
                li.SubItems.Add("");
                li.SubItems.Add(dr["tentheloai"].ToString());
                li.SubItems.Add(dr["loibaihat"].ToString());
                li.Tag = dr["mabaihat"];
            }
            stt(lvwBaiHat_Home);
        }
        private void hienbaihat_cbo(DataView dv)
        {
            foreach (DataRowView dr in dv)
            {
                ListViewItem li = lvwBaiHat.Items.Add("");
                li.SubItems.Add(dr["tenbaihat"].ToString());
                li.SubItems.Add(dr["loibaihat"].ToString());
                li.Tag = dr["mabaihat"];
            }
            stt(lvwBaiHat);
        }
        private void loadlai_listview()
        {
            lvwAlbum.Items.Clear();
            lvwBaiHat_Album.Items.Clear();
            lvwBaiHat_Home.Items.Clear();
            lvwBaiHat_TheLoai.Items.Clear();
            lvwBaiHat_NhaSanXuat.Items.Clear();
            lvwBaiHat_NhacSi.Items.Clear();
            lvwBaiHat_CaSi.Items.Clear();
            lvwTheLoai.Items.Clear();
            lvwBaiHat.Items.Clear();

            load_BaiHat_home();
            load_Album();
            load_TheLoai();
            load_Baihat();
        }
        private void stt(ListView lvw)
        {
            for (int i = 1; i <= lvw.Items.Count; i++)
            {
                lvw.Items[i - 1].Text = i.ToString();
                lvw.Items[i - 1].ImageIndex = 0;
                if (i % 2 != 0)
                    lvw.Items[i - 1].BackColor = Color.LightBlue;
            }
        }
        #endregion

        #region các xử lý button listbox và listview
        private void lstDanhSachCaSi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(danapxong_lstBox)
            {
                if (lstDanhSachCaSi.SelectedItems.Count == 0)
                    return;
                //lvwBaiHat_CaSi.Items.Clear();
                DataView dv = new DataView(dtCasi);
                dv.RowFilter = "macasi = '" + lstDanhSachCaSi.SelectedValue + "'";
                string tencasi = "";
                foreach (DataRowView dr in dv)
                {
                    tencasi = lblTenCaSi.Text = dr["tencasi"].ToString();
                    txtThongTinCaSi.Text = dr["thongtincasi"].ToString();
                }
                if (txtThongTinCaSi.Text.Trim().Equals(""))
                    txtThongTinCaSi.Text = "Chưa có thông tin cho ca sĩ: [" + tencasi + "]";

                dtCasi_Baihat = new Casi_Baihat_BUS().getCasi_BaiHat_by_macasi(lstDanhSachCaSi.SelectedValue.ToString());
                lvwBaiHat_CaSi.Items.Clear();
                foreach (DataRow dr in dtCasi_Baihat.Rows)
                {
                    DataTable dt = new BaiHat_BUS().getBaiHat_by_mabaihat(dr["mabaihat"].ToString());
                    
                    ListViewItem li = lvwBaiHat_CaSi.Items.Add("");
                    li.SubItems.Add(dt.Rows[0]["tenbaihat"].ToString());
                }
                stt(lvwBaiHat_CaSi);
                
            }
        }
        
        private void lstDanhSachNhacSi_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (danapxong_lstBox)
            {
                if(lstDanhSachNhacSi.SelectedItems.Count==0)
                    return;
                //lvwBaiHat_NhacSi.Items.Clear();
                DataView dv = new DataView(dtTacGia);
                dv.RowFilter = "matacgia = '" + lstDanhSachNhacSi.SelectedValue + "'";
                foreach (DataRowView dr in dv)
                {
                    lblTenNhacSi.Text = dr["tentacgia"].ToString();
                    txtThongTinNhacSi.Text = dr["thongtintacgia"].ToString();
                }
                if (txtThongTinNhacSi.Text.Trim().Equals(""))
                    txtThongTinNhacSi.Text = "Chưa có thông tin tác giả (nhạc sĩ) [" + lblTenNhacSi.Text + "]";
                dtBaiHat = new BaiHat_BUS().getBaiHat();
                DataView dvBaiHat = new DataView(dtBaiHat);
                dvBaiHat.RowFilter = "matacgia = '" + lstDanhSachNhacSi.SelectedValue + "'";
                hienbaihat(dvBaiHat, lvwBaiHat_NhacSi);
            }
        }

        private void lstNhaSanXuat_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (danapxong_lstBox)
            {
                if (lstNhaSanXuat.SelectedItems.Count == 0)
                    return;
                //lvwBaiHat_NhaSanXuat.Items.Clear();
                DataView dv = new DataView(dtNhaSanXuat);
                dv.RowFilter = "mahangsanxuat = '" + lstNhaSanXuat.SelectedValue + "'";
                foreach (DataRowView dr in dv)
                {
                    lblTenNhaSanXuat.Text = dr["tenhangsanxuat"].ToString();
                    txtThongTinNhaSanXuat.Text = dr["thongtinnhasanxuat"].ToString();
                }
                if (txtThongTinNhaSanXuat.Text.Trim().Equals(""))
                    txtThongTinNhaSanXuat.Text = "Chưa có thông tin nhà sản xuất [" + lblTenNhaSanXuat.Text + "]";
                dtBaiHat = new BaiHat_BUS().getBaiHat();
                DataView dvBaiHat = new DataView(dtBaiHat);
                dvBaiHat.RowFilter = "mahangsanxuat = '" + lstNhaSanXuat.SelectedValue + "'";
                hienbaihat(dvBaiHat, lvwBaiHat_NhaSanXuat);
            }
        }
        

        private void lvwBaiHat_Home_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            lvwBaiHat_Home.Items.Clear();
            ColumnHeader col = lvwBaiHat_Home.Columns[e.Column];
            string strKieuSapXep = col.Tag.ToString();
            sapxep_home(strKieuSapXep);
            if (col.Tag.ToString() == "asc")
                col.Tag = "desc";
            else
                col.Tag = "asc";
        }
        
        private void lvwAlbum_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvwAlbum.SelectedItems.Count == 0)
                return;
            lvwBaiHat_Album.Items.Clear();
            DataTable dt = null;
            try
            {
                dt = new BaiHat_BUS().getBaiHat_by_album(lvwAlbum.SelectedItems[0].Tag.ToString());
            
                foreach (DataRow dr in dt.Rows)
                {
                    ListViewItem li = lvwBaiHat_Album.Items.Add("");
                    li.SubItems.Add(dr["tenbaihat"].ToString());
                    DataTable dt1 = new Casi_Baihat_BUS().getCasi_BaiHat_by_mabaihat(dr["mabaihat"].ToString());
                    string cac_casi = "";
                    foreach (DataRow r in dt1.Rows)
                    {
                        DataTable dtcasi = new CaSi_BUS().getCasi_by_macasi(r["macasi"].ToString());
                        foreach (DataRow r1 in dtcasi.Rows)
                        {
                            cac_casi += r1["tencasi"].ToString() + ", ";
                        }
                    }
                    li.SubItems.Add(cac_casi + "...");
                    DataTable dtA = new TheLoai_BUS().getTheLoai_by_ma(dr["matheloai"].ToString());
                    DataRow rr = dtA.Rows[0];
                    li.SubItems.Add(rr["tentheloai"].ToString());
                    li.SubItems.Add(dr["loibaihat"].ToString());
                    li.Tag = dr["mabaihat"];

                }
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi không xác định");
                return;
            }
                stt(lvwBaiHat_Album);
                lblBaiHatTrongAlbum.Text = "Danh sách các bài hát có trong Album: [" + lvwAlbum.SelectedItems[0].SubItems[1].Text + "]";
        }

        private void lvwTheLoai_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvwTheLoai.SelectedItems.Count == 0)
                return;
            lvwBaiHat_TheLoai.Items.Clear();
            try
            {
                DataTable dt = new BaiHat_BUS().getBaiHat_by_TheLoai(lvwTheLoai.SelectedItems[0].Tag.ToString());

                foreach (DataRow dr in dt.Rows)
                {
                    ListViewItem li = lvwBaiHat_TheLoai.Items.Add("");
                    li.SubItems.Add(dr["tenbaihat"].ToString());

                    DataTable dtA = new Album_BUS().getAlbum_by_ma(dr["maalbum"].ToString());
                    DataRow r = dtA.Rows[0];
                    li.SubItems.Add(r["tenalbum"].ToString());

                    DataTable dtt = new Casi_Baihat_BUS().getCasi_BaiHat_by_mabaihat(dr["mabaihat"].ToString());
                    string cac_casi = "";
                    foreach (DataRow rt in dtt.Rows)
                    {
                        DataTable dtcasi = new CaSi_BUS().getCasi_by_macasi(rt["macasi"].ToString());
                        foreach (DataRow r1 in dtcasi.Rows)
                        {
                            cac_casi += r1["tencasi"].ToString() + ", ";
                        }
                    }
                    li.SubItems.Add(cac_casi + "...");

                    li.SubItems.Add(dr["loibaihat"].ToString());

                }
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi không xác định ");
                return;
            }
            stt(lvwBaiHat_TheLoai);
            lblBaiHatTrongTheLoai.Text = "Danh sách các bài hát có trong Thể loại: [" + lvwTheLoai.SelectedItems[0].SubItems[1].Text + "]";
            
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            lvwAlbum_TKiem.Items.Clear(); lvwBaiHat_TKiem.Items.Clear(); lvwCaSi_TKiem.Items.Clear(); lvwHangSanXuat.Items.Clear(); lvwLoiBaiHat.Items.Clear();

            if (txtTimKiem.Text.Trim().Equals("") || txtTimKiem.ForeColor != Color.Black)
            {
                MessageBox.Show("Bạn hãy nhập nội dung cần tìm!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTimKiem_Click(null, null);
                txtTimKiem.Focus();
                return;
            }
            //MessageBox.Show("Viết code đi may` ");
            // lam` tiep o day
            try
            {
                #region Xu Ly Tim Kiem (dai`)
                DataTable dtBaiHat_TimKiem = new BaiHat_BUS().getBaiHat();
                foreach (DataRow dr in dtBaiHat_TimKiem.Rows)
                {
                    if (ThayThe_Unicode(dr["tenbaihat"].ToString()).Trim().ToLower().Contains(ThayThe_Unicode(txtTimKiem.Text).Trim().ToLower()))
                    {
                        ListViewItem li = lvwBaiHat_TKiem.Items.Add("");
                        li.SubItems.Add(dr["mabaihat"].ToString());
                        li.SubItems.Add(dr["tenbaihat"].ToString());
                        li.Tag = dr["mabaihat"];
                        //-----------------------------------------------
                        
                    }
                }
                if (lvwBaiHat_TKiem.Items.Count == 0)
                {
                    ListViewItem i = lvwBaiHat_TKiem.Items.Add("null");
                    i.SubItems.Add("(Không tìm thấy !!!)"); i.SubItems.Add("(Không tìm thấy !!!)");
                    
                }
                stt(lvwBaiHat_TKiem); stt(lvwLoiBaiHat);

                //------------------------------------------------------------------------------------------
                DataTable dtAlbum_timkiem = new Album_BUS().getAlbum();
                foreach (DataRow dr in dtAlbum_timkiem.Rows)
                {
                    if (ThayThe_Unicode(dr["tenalbum"].ToString()).Trim().ToLower().Contains(ThayThe_Unicode(txtTimKiem.Text).Trim().ToLower()) || dr["namphathanh"].ToString().Trim().ToLower().Contains(txtTimKiem.Text.Trim().ToLower()))
                    {
                        ListViewItem li = lvwAlbum_TKiem.Items.Add("");
                        li.SubItems.Add(dr["maalbum"].ToString());
                        li.SubItems.Add(dr["tenalbum"].ToString());
                        li.SubItems.Add(dr["namphathanh"].ToString());
                        li.Tag = dr["maalbum"];
                    }
                }
                if (lvwAlbum_TKiem.Items.Count == 0)
                {
                    ListViewItem i = lvwAlbum_TKiem.Items.Add("null");
                    i.SubItems.Add("(Không tìm thấy !!!)"); i.SubItems.Add("(Không tìm thấy !!!)");
                }
                stt(lvwAlbum_TKiem);

                //-------------------------------------------------------------------------------------------------
                DataTable dtCasi_timkiem = new CaSi_BUS().getCaSi();
                foreach (DataRow dr in dtCasi_timkiem.Rows)
                {
                    if (ThayThe_Unicode(dr["tencasi"].ToString()).Trim().ToLower().Contains(ThayThe_Unicode(txtTimKiem.Text).Trim().ToLower()))
                    {
                        ListViewItem li = lvwCaSi_TKiem.Items.Add("");
                        li.SubItems.Add(dr["macasi"].ToString());
                        li.SubItems.Add(dr["tencasi"].ToString());
                        //li.SubItems.Add(dr["namphathanh"].ToString());
                        li.Tag = dr["macasi"];
                    }
                }
                if (lvwCaSi_TKiem.Items.Count == 0)
                {
                    ListViewItem i = lvwCaSi_TKiem.Items.Add("null");
                    i.SubItems.Add("(Không tìm thấy !!!)"); i.SubItems.Add("(Không tìm thấy !!!)");
                }
                stt(lvwCaSi_TKiem);

                //-------------------------------------------------------------------------------------------------
                DataTable dtHangsanxuat_tk = new NhaSanXuat_BUS().getNhaSanXuat();
                foreach (DataRow dr in dtHangsanxuat_tk.Rows)
                {
                    if (ThayThe_Unicode(dr["tenhangsanxuat"].ToString()).Trim().ToLower().Contains(ThayThe_Unicode(txtTimKiem.Text).Trim().ToLower()))
                    {
                        ListViewItem li = lvwHangSanXuat.Items.Add("");
                        li.SubItems.Add(dr["mahangsanxuat"].ToString());
                        li.SubItems.Add(dr["tenhangsanxuat"].ToString());
                        li.SubItems.Add(dr["thongtinnhasanxuat"].ToString());
                        li.Tag = dr["mahangsanxuat"];
                    }
                }
                if (lvwHangSanXuat.Items.Count == 0)
                {
                    ListViewItem i = lvwHangSanXuat.Items.Add("null");
                    i.SubItems.Add("(Không tìm thấy !!!)"); i.SubItems.Add("(Không tìm thấy !!!)");
                }
                stt(lvwHangSanXuat);

                //-------------------------------------------------------------------------------------------------
                DataTable dtLoiBH = new BaiHat_BUS().getBaiHat();
                foreach (DataRow dr in dtLoiBH.Rows)
                {
                    if (ThayThe_Unicode(dr["loibaihat"].ToString()).Trim().ToLower().Contains(ThayThe_Unicode(txtTimKiem.Text).Trim().ToLower()))
                    {
                        ListViewItem i = lvwLoiBaiHat.Items.Add("");
                        i.SubItems.Add(dr["tenbaihat"].ToString());
                        i.SubItems.Add(dr["mabaihat"].ToString());
                        i.SubItems.Add(dr["loibaihat"].ToString());
                        i.Tag = dr["mabaihat"];
                    }
                }
                if (lvwLoiBaiHat.Items.Count == 0)
                {
                    ListViewItem i = lvwLoiBaiHat.Items.Add("null");
                    i.SubItems.Add("(Không tìm thấy !!!)"); i.SubItems.Add("(Không tìm thấy !!!)");
                }
                stt(lvwLoiBaiHat);

                #endregion
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi ---> " + ex.Message.ToString());
            }
            txtTimKiem.AutoCompleteCustomSource.Add(txtTimKiem.Text);
        }

        private void txtTimKiem_Click(object sender, EventArgs e)
        {
            if (txtTimKiem.ForeColor == Color.Black)
                return;
            txtTimKiem.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular);
            txtTimKiem.ForeColor = Color.Black;
            txtTimKiem.Clear();
        }

        private void txtTimKiem_Leave(object sender, EventArgs e)
        {
            if (!txtTimKiem.Text.Trim().Equals(""))
                return;
            txtTimKiem.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Italic);
            txtTimKiem.ForeColor = SystemColors.InactiveCaption;
            txtTimKiem.Text = "(Gõ nội dung cần tìm ...)";
        }

        private void txtTimKiem_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                btnTim_Click(null, null);
        }

        private void btnThemAlbum_Click(object sender, EventArgs e)
        {
            lvwAlbum.Items.Clear();
            this.Visible = false;
            frmThem_Album f = new frmThem_Album();
            f.ShowDialog();
            this.Visible = true;
            load_Album();
        }

        private void btnXoaAlbum_Click(object sender, EventArgs e)
        {
            if (lvwAlbum.SelectedItems.Count == 0)
                return;
            DialogResult drl = MessageBox.Show("Bạn thực sự muốn xóa Album [" + lvwAlbum.SelectedItems[0].SubItems[1].Text + "] và tất cả bài trong album này không ?", "xóa album", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (drl == DialogResult.Cancel)
                return;
            
            string maalbumđangcchon=lvwAlbum.SelectedItems[0].Tag.ToString();
            Album_BUS a = new Album_BUS(maalbumđangcchon);
            int loi = a.xoaAlbum();
            if (loi == 0)
                MessageBox.Show("Đã xóa thành công mã album [" + maalbumđangcchon + "] ", "thành công hehe", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
                MessageBox.Show("xóa thất bại mã album [" + maalbumđangcchon + "] ", "thất bại huhu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            loadlai_listview();
            //frmHome_Load(null, null);
        }

        /// <summary>
        /// xóa các items trong cái lvw vào load lại
        /// </summary>
       

        private void lvwAlbum_DoubleClick(object sender, EventArgs e)
        {
            if (lvwAlbum.SelectedItems.Count == 0)
                return;
            this.Visible = false;
            frmCapNhat_Album f = new frmCapNhat_Album();
            // gán 
            f.ma = lvwAlbum.SelectedItems[0].Tag.ToString();
            f.ten = lvwAlbum.SelectedItems[0].SubItems[1].Text;
            f.namphathanh = lvwAlbum.SelectedItems[0].SubItems[2].Text;
            f.ShowDialog();
            if(f.DialogResult==DialogResult.OK)
                loadlai_listview();
            this.Visible = true;
            
            
        }
        #region menu Album
        private void cậpNhậtAlbumToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lvwAlbum_DoubleClick(sender, e);
        }

        private void xóaAlbumToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnXoaAlbum_Click(sender, e);
        }

        private void thêmAlbumMớiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnThemAlbum_Click(sender, e);
        }
        #endregion
        private void btnXoaBaiHatKhoiAlbum_Click(object sender, EventArgs e)
        {
            
            if (lvwBaiHat_Album.SelectedItems.Count == 0 && lvwAlbum.SelectedItems.Count == 0)
                return;
            DialogResult drl=MessageBox.Show("Bạn thực sự muốn xóa bài hát ["+lvwBaiHat_Album.SelectedItems[0].SubItems[1].Text+"] ra khỏi album ["+ lvwAlbum.SelectedItems[0].SubItems[1].Text + "]","Xóa bài hát",MessageBoxButtons.OKCancel,MessageBoxIcon.Question);
            if (drl == DialogResult.Cancel)
                return;
            //MessageBox.Show(lvwAlbum.SelectedItems[0].Tag.ToString());// xem ma album dc chon
            Album_BUS al = new Album_BUS(lvwAlbum.SelectedItems[0].Tag.ToString());
            int loi = al.xoaBaiHat_by_Album();
            if (loi == 0)
                MessageBox.Show("Xóa thành công bài bát [" + lvwBaiHat_Album.SelectedItems[0].SubItems[1].Text + "] ra khỏi album [" + lvwAlbum.SelectedItems[0].SubItems[1].Text + "]");
            else
                MessageBox.Show("lỗi, không xóa đc");
            frmHome_Load(null, null);

        }

        private void btnThemTheLoai_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            lvwTheLoai.Items.Clear();
            frmThem_TheLoai f = new frmThem_TheLoai();
            f.ShowDialog();
            if (f.DialogResult == DialogResult.OK)
                load_TheLoai();
            this.Visible = true;
            
        }

        private void btnXoaTheLoai_Click(object sender, EventArgs e)
        {
            if (lvwTheLoai.SelectedItems.Count == 0)
                return;
            DialogResult drl = MessageBox.Show("Bạn thực sự muốn xóa Thể loại [" + lvwTheLoai.SelectedItems[0].SubItems[1].Text + "] và tất cả bài trong thể loại này không ?", "xóa album", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (drl == DialogResult.Cancel)
                return;

            string matheloaiđangcchon = lvwTheLoai.SelectedItems[0].Tag.ToString();
            TheLoai_BUS a = new TheLoai_BUS(matheloaiđangcchon);
            int loi = a.xoaTheLoai();
            if (loi == 0)
                MessageBox.Show("Đã xóa thành công mã thể loại [" + matheloaiđangcchon + "] ", "thành công hehe", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
                MessageBox.Show("xóa thất bại mã thể loại [" + matheloaiđangcchon + "] ", "thất bại huhu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            loadlai_listview();
        }

        private void lvwTheLoai_DoubleClick(object sender, EventArgs e)
        {
            if (lvwTheLoai.SelectedItems.Count == 0)
                return;
            this.Visible = false;
            frmCapNhatTheLoai f = new frmCapNhatTheLoai();
            f.matheloai = lvwTheLoai.SelectedItems[0].Tag.ToString();
            f.tentheloai = lvwTheLoai.SelectedItems[0].SubItems[1].Text;
            
            f.ShowDialog();
            if(f.DialogResult==DialogResult.OK)
                loadlai_listview();
            this.Visible = true;
            
        }
        #region menu Thể Loại
        private void cậpNhậtThểLoạiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lvwTheLoai_DoubleClick(sender, e);
        }

        private void xóaThểLoạiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnXoaTheLoai_Click(sender, e);
        }

        private void thếmThểLoạiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnThemTheLoai_Click(sender, e);
        }
        #endregion
        private void quảnLýALBUMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem tsmi = (ToolStripMenuItem)sender;
            if (tsmi.Equals(quảnLýALBUMToolStripMenuItem))
                tabControl1.SelectedIndex = 1;
            else if (tsmi.Equals(quảnLýTHỂLOẠIToolStripMenuItem))
                tabControl1.SelectedIndex = 2;
            else if (tsmi.Equals(quảnLýCASĨToolStripMenuItem))
                tabControl1.SelectedIndex = 3;
            else if (tsmi.Equals(quảnLýTÁCGIẢToolStripMenuItem))
                tabControl1.SelectedIndex = 4;
            else if (tsmi.Equals(quảnLýHÃNGSẢNXUẤTToolStripMenuItem))
                tabControl1.SelectedIndex = 5;
            else
                tabControl1.SelectedIndex = 6;
        }

        private void btnDongChungTrinh_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("BẠN CHẮC CHẮN MUỐN ĐÓNG ỨNG DỤNG ?", "THOÁT CHƯƠNG TRÌNH", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                this.Close();
        }

        private void btnThemCaSi_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            frmThem_Casi f = new frmThem_Casi();
            f.ShowDialog();
            if(f.DialogResult==DialogResult.OK)
                load_Casi();
            this.Visible = true;
            
        }

        private void btnSuaThongTin_CaSi_Click(object sender, EventArgs e)
        {
            if (lstDanhSachCaSi.SelectedItems.Count == 0)
                return;
            
            this.Visible = false;
            frmCapnhat_Casi f = new frmCapnhat_Casi();
            f.ma = lstDanhSachCaSi.SelectedValue.ToString();
            f.ten = lblTenCaSi.Text;
            if (txtThongTinCaSi.Text.Contains("Chưa có thông tin cho ca sĩ"))
                f.thongtin = "";
            else
                f.thongtin = txtThongTinCaSi.Text;
            f.ShowDialog();
            if (f.DialogResult == DialogResult.OK)
            {
                lstDanhSachCaSi.DataSource = null;
                load_Casi();
            }
            this.Visible = true;
            
            
            //lstDanhSachCaSi_SelectedIndexChanged(sender, e);
        }

        private void btnXoaCaSi_Click(object sender, EventArgs e)
        {
            if (lstDanhSachCaSi.SelectedItems.Count == 0)
                return;
            DialogResult drl = MessageBox.Show("Bạn thực sự muốn xóa Ca sĩ [" + lblTenCaSi.Text + "] và tất cả bài hát do ca sĩ này trình bày không ?", "xóa ca sĩ", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (drl == DialogResult.Cancel)
                return;

            string macasidangchon = lstDanhSachCaSi.SelectedValue.ToString();
            CaSi_BUS a = new CaSi_BUS(macasidangchon);
            int loi = a.xoaCasi();
            if (loi == 0)
                MessageBox.Show("Đã xóa thành công mã ca sĩ [" + macasidangchon + "] ", "thành công hehe", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
                MessageBox.Show("xóa thất bại mã ca sĩ [" + macasidangchon + "] ", "thất bại huhu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            load_Casi();
            loadlai_listview();
        }

        private void đóngỨngDụngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnDongChungTrinh_Click(sender, e);
        }

        private void btnThem_NhacSi_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            frmThem_TacGia f = new frmThem_TacGia();
            f.ShowDialog();
            this.Visible = true;
            load_TacGia();
        }

        private void btnXoa_NhacSi_Click(object sender, EventArgs e)
        {
            if (lstDanhSachNhacSi.SelectedItems.Count == 0)
                return;
            DialogResult drl = MessageBox.Show("Bạn thực sự muốn xóa nhạc sĩ [" + lblTenNhacSi.Text + "] và tất cả bài hát do nhạc sĩ này viết không ?", "xóa tác giả", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (drl == DialogResult.Cancel)
                return;

            string manhacsidcchon = lstDanhSachNhacSi.SelectedValue.ToString();
            TacGia_BUS a = new TacGia_BUS(manhacsidcchon);
            int loi = a.xoaTacGia();
            if (loi == 0)
                MessageBox.Show("Đã xóa thành công mã nhạc sĩ [" + manhacsidcchon + "] ", "thành công hehe", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
                MessageBox.Show("xóa thất bại mã nhạc sĩ [" + manhacsidcchon + "] ", "thất bại huhu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            load_TacGia();
            loadlai_listview();
        }

        private void btnChinhThongTin_NhacSi_Click(object sender, EventArgs e)
        {
            if (lstDanhSachNhacSi.SelectedItems.Count == 0)
                return;

            this.Visible = false;
            frmCapNhat_TacGia f = new frmCapNhat_TacGia();
            f.ma = lstDanhSachNhacSi.SelectedValue.ToString();
            f.ten = lblTenNhacSi.Text;
            if (txtThongTinNhacSi.Text.Contains("Chưa có thông tin tác giả "))
                f.thongtin = "";
            else
                f.thongtin = txtThongTinNhacSi.Text;
            f.ShowDialog();
            if (f.DialogResult == DialogResult.OK)
            {
                lstDanhSachCaSi.DataSource = null;
                load_TacGia();
            }
            this.Visible = true;
            
            
        }

        private void btnThemNhaSanXuat_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            frmThem_NhaSanXuat f = new frmThem_NhaSanXuat();
            f.ShowDialog();
            this.Visible = true;
            load_NhaSanXuat();
        }

        private void btnXoaNhaSanXuat_Click(object sender, EventArgs e)
        {
            if (lstNhaSanXuat.SelectedItems.Count == 0)
                return;
            DialogResult drl = MessageBox.Show("Bạn thực sự muốn xóa Hãng sản xuất [" + lblTenNhaSanXuat.Text + "] và tất cả bài hát của hãng sane xuất này ?", "xóa hãng sản xuất", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (drl == DialogResult.Cancel)
                return;

            string manhasx = lstNhaSanXuat.SelectedValue.ToString();
            NhaSanXuat_BUS a = new NhaSanXuat_BUS(manhasx);
            int loi = a.xoaNhaSX();
            if (loi == 0)
                MessageBox.Show("Đã xóa thành công mã hãng sản xuất [" + manhasx + "] ", "thành công hehe", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
                MessageBox.Show("xóa thất bại mã hãng sản xuất [" + manhasx + "] ", "thất bại huhu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            load_NhaSanXuat();
            loadlai_listview();
        }

        private void btnChinhThongTin_NhaSanXuat_Click(object sender, EventArgs e)
        {
            if (lstNhaSanXuat.SelectedItems.Count == 0)
                return;

            this.Visible = false;
            frmCapNhat_HangSX f = new frmCapNhat_HangSX();
            f.ma = lstNhaSanXuat.SelectedValue.ToString();
            f.ten = lblTenNhaSanXuat.Text;
            if (txtThongTinNhacSi.Text.Contains("Chưa có thông tin nhà sản xuất "))
                f.thongtin = "";
            else
                f.thongtin = txtThongTinNhaSanXuat.Text;
            f.ShowDialog();
            if (f.DialogResult == DialogResult.OK)
            {
                lstNhaSanXuat.DataSource = null;
                load_NhaSanXuat();
            }
            this.Visible = true;
            
        }
        private DataView dvBaiHat;
        
        private void cboTheLoai_SelectedIndexChanged(object sender, EventArgs e)
        {

            //lvwBaiHat.Items.Clear();
            //dvBaiHat = new DataView(dtBaiHat_BaiHat);
            //dvBaiHat.RowFilter = "matheloai = '" + cboTheLoai.SelectedValue.ToString() + "'";
            //hienbaihat_cbo(dvBaiHat);
        }
        
        private void cboAlbum_SelectedIndexChanged(object sender, EventArgs e)
        {
            //lvwBaiHat.Items.Clear();
            //dvBaiHat = new DataView(dtBaiHat_BaiHat);
            //dvBaiHat.RowFilter = "maalbum = '" + cboAlbum.SelectedValue.ToString() + "'";
            //hienbaihat_cbo(dvBaiHat);
        }

        private void cboCasi_SelectedIndexChanged(object sender, EventArgs e)
        {
            //lvwBaiHat.Items.Clear();
            //dvBaiHat = new DataView(dtBaiHat_BaiHat);
            //dvBaiHat.RowFilter = "macasi = '" + cboCasi.SelectedValue.ToString() + "'";
            //hienbaihat_cbo(dvBaiHat);
        }

        private void cbotacGia_SelectedIndexChanged(object sender, EventArgs e)
        {
            //lvwBaiHat.Items.Clear();
            //dvBaiHat = new DataView(dtBaiHat_BaiHat);
            //dvBaiHat.RowFilter = "matacgia = '" + cbotacGia.SelectedValue.ToString() + "'";
            //hienbaihat_cbo(dvBaiHat);
        }

        private void cboHangsanxuat_SelectedIndexChanged(object sender, EventArgs e)
        {
            //lvwBaiHat.Items.Clear();
            //dvBaiHat = new DataView(dtBaiHat_BaiHat);
            //dvBaiHat.RowFilter = "mahangsanxuat = '" + cboHangsanxuat.SelectedValue.ToString() + "'";
            //hienbaihat_cbo(dvBaiHat);
        }
        #region hiệu ứng button
        private void btnThemBaiHatVaoAlbum_MouseHover(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.BackColor = Color.Red;
        }

        private void btnThemBaiHatVaoAlbum_MouseLeave(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.BackColor = Color.SkyBlue;
        }


        #endregion

        private void btnThemBaiHat_Click(object sender, EventArgs e)
        {
            this.Visible=false;
            frmThem_BaiHat f = new frmThem_BaiHat();
            f.ShowDialog();
            if (f.DialogResult == DialogResult.OK)
                loadlai_listview();
            this.Visible = true;
            
        }

        private void btnXoaBaiHat_Click(object sender, EventArgs e)
        {
            if(lvwBaiHat.SelectedItems.Count==0)
                return;
            DialogResult drl = MessageBox.Show("Bạn thực sự muốn xóa bài hát [" + lvwBaiHat.SelectedItems[0].SubItems[1].Text + "]  không ?", "xóa bài hát", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (drl == DialogResult.Cancel)
                return;

            string mabaihatdcchon = lvwBaiHat.SelectedItems[0].Tag.ToString();
            BaiHat_BUS a = new BaiHat_BUS(mabaihatdcchon);
            int loi = a.xoaBaiHat();
            if (loi == 0)
                MessageBox.Show("Đã xóa thành công mã bài hát [" + mabaihatdcchon + "] ", "thành công hehe", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
                MessageBox.Show("xóa thất bại mã bài hát [" + mabaihatdcchon + "] ", "thất bại huhu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            load_Baihat();
            loadlai_listview();
        }

        private void btnSuaBaiHat_Click(object sender, EventArgs e)
        {
            if(lvwBaiHat.SelectedItems.Count==0)
                return;
            this.Visible=false;
            frmCapNhat_BaiHat f = new frmCapNhat_BaiHat();
            f.ma = lvwBaiHat.SelectedItems[0].Tag.ToString();
            f.ten = lvwBaiHat.SelectedItems[0].SubItems[1].Text;
            f.loibaihat = lvwBaiHat.SelectedItems[0].SubItems[2].Text;
            f.matheloai = cboTheLoai.SelectedValue.ToString();
            f.maalbum = cboAlbum.SelectedValue.ToString();
            f.macasi = cboCasi.SelectedValue.ToString();
            f.matacgia = cbotacGia.SelectedValue.ToString();
            f.mahangsanxuat = cboHangsanxuat.SelectedValue.ToString();

            f.ShowDialog();
            if (f.DialogResult == DialogResult.OK)
                loadlai_listview();
            this.Visible = true;
        }

        private void lvwBaiHat_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvwBaiHat.SelectedItems.Count == 0)
                return;
            DataTable dtBH = new BaiHat_BUS().getBaiHat_by_mabaihat(lvwBaiHat.SelectedItems[0].Tag.ToString());
            DataView dv = new DataView(dtBH);
            foreach (DataRow dr in dtBH.Rows)
            {
                cboTheLoai.SelectedValue = dr["matheloai"].ToString();
                
                cboAlbum.SelectedValue = dr["maalbum"].ToString();
                cboCasi.SelectedValue = dr["macasi"].ToString();
                cbotacGia.SelectedValue = dr["matacgia"].ToString();
                cboHangsanxuat.SelectedValue = dr["mahangsanxuat"].ToString();
            }
        }

        private void btnHienTatCaBaiHat_Click(object sender, EventArgs e)
        {
            lvwBaiHat.Items.Clear();
            load_Baihat();
        }

        private void lvwBaiHat_DoubleClick(object sender, EventArgs e)
        {
            btnSuaBaiHat_Click(sender, e);
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 7;
        }

        private void giớiThiệuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("tên sinh viên: LÊ HỮU HOÀNG QUÂN \nmã số sv:  10258441\nlớp:  NCTH4A");
        }
#endregion
    }
}
