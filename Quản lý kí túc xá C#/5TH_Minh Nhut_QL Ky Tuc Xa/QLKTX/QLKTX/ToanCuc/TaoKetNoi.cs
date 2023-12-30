using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32;

namespace QLKTX.ToanCuc
{
    public partial class TaoKetNoi : Form
    {
        public TaoKetNoi()
        {
            InitializeComponent();
        }

        private void TaoKetNoi_Load(object sender, EventArgs e)
        {
        }

        private void checkBoxX1_CheckedChanged(object sender, EventArgs e)
        {   
                txtPass.Enabled = !checkBoxX1.Checked;
                txtUser.Enabled = !checkBoxX1.Checked;
            
        }

        private void btnKetNoi_Click(object sender, EventArgs e)
        {
            if (LayGiaTri("QLKTX") != "")//da duoc cai dat truoc, co quyen su dung
            {
                if (checkBoxX1.Checked)
                {
                    try
                    {
                        SqlConnection con = new SqlConnection("Data Source=localhost;Integrated Security=true");
                        SqlCommand com = new SqlCommand();
                        com.Connection = con;
                        con.Open();
                        Tao("KetNoi", "Data Source=localhost;Initial Catalog=QLKTX;Integrated Security=true");
                        TaoCSDL("Data Source=localhost;Integrated Security=true");
                        MessageBox.Show("Thành công!");
                        MessageBox.Show("Tài khoảng dăng nhập:\nUser: Admin\nPass: Admin","Dang nhap",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                        this.Dispose();
                    }
                    catch (Exception t)
                    {
                        MessageBox.Show("Không kết nối được");
                    }
                }
                else
                {



                    try
                    {
                        SqlConnection con = new SqlConnection("Data Source=localhost;User Id=" + txtUser.Text + ";Password=" + txtPass.Text + ";");
                        SqlCommand com = new SqlCommand();
                        com.Connection = con;
                        con.Open();
                        Tao("KetNoi", "Data Source=localhost;Initial Catalog=QLKTXI;User Id=" + txtUser.Text + ";Password=" + txtPass.Text + ";");
                        TaoCSDL("Data Source=localhost;User Id=" + txtUser.Text + ";Password=" + txtPass.Text + ";");
                        MessageBox.Show("Thành công!");
                        this.Dispose();
                    }
                    catch (Exception t)
                    {
                        MessageBox.Show("Không kết nối được");
                    }

                }
            }//Het if dau
            else
            {
                MessageBox.Show("Chương trình sử dụng không hợp lệ! Ban hãy cài lại để sử dụng tốt hơn");

            }
        }
        
        /// <summary>
        /// Lay chuoi ket noi tu registry
        /// </summary>
        /// <returns></returns>
        public string LayGiaTri(string s)
        {
            RegistryKey key = Registry.CurrentUser;
            RegistryKey softKey = key.OpenSubKey("Software", true);
            RegistryKey QLKTXKey = softKey.OpenSubKey("QLKTX", true);
            try
            {
                return QLKTXKey.GetValue(s).ToString();
            }
            catch (Exception e)
            {
                return "";
            }
        }
        public void Tao(string s,string giatri)
        {
            RegistryKey key = Registry.CurrentUser;
            RegistryKey softKey = key.OpenSubKey("Software", true);
            RegistryKey QLKTXKey = softKey.OpenSubKey("QLKTX", true);
            QLKTXKey.SetValue(s, giatri);
        }
        public void TaoCSDL(string ketnoi)
        {
            SqlCommand com = new SqlCommand();
            SqlConnection con = new SqlConnection(ketnoi);
            SqlDataAdapter app = new SqlDataAdapter();
            con.Open();
            com.Connection = con;
            //Kiem tra CSDL co tồn tại không
            com.CommandText="use master";
            com.ExecuteNonQuery();
            com.CommandText = "select name from sysdatabases";
            DataTable table = new DataTable();
            app = new SqlDataAdapter(com);
            app.Fill(table);
            int j = table.Rows.Count;
            bool co=false;// true --> database da ton tai
            for (int i = 0; i < j; i++)
            {
                if (table.Rows[i][0].ToString() == "QLKTX")
                    co = true;
            }
            if (!co)
            {
                com.CommandText = "CREATE DATABASE QLKTX";
                com.ExecuteNonQuery();

                com.CommandText = "use QLKTX";
                com.ExecuteNonQuery();

                com.CommandText = "CREATE TABLE TONGIAO(MATONGIAO	INT		NOT NULL PRIMARY KEY,TENTONGIAO	NVARCHAR(30)	NOT NULL)";
                com.ExecuteNonQuery();

                com.CommandText = "CREATE TABLE DANTOC(MADANTOC 	INT NOT NULL PRIMARY KEY,TENDANTOC	NVARCHAR(30) NOT NULL)";
                com.ExecuteNonQuery();

                com.CommandText = "CREATE TABLE QUOCTICH(MAQUOCTICH	INT NOT NULL  PRIMARY KEY,TENQUOCTICH	NVARCHAR(30))";
                com.ExecuteNonQuery();

                com.CommandText = "CREATE TABLE SINHVIEN(MAKTX 		VARCHAR(7) NOT NULL PRIMARY KEY,NAMSINH		DATETIME,HOTEN		NVARCHAR(30) NOT NULL,CMND		VARCHAR(9),DIENTHOAI	VARCHAR(10),MSSV		VARCHAR(9),GIOITINH	BIT,DIACHI		NVARCHAR(100),MAQT		INT,MADT		INT,MATG		INT,DOANVIEN	BIT,DANGVIEN	BIT,CAMTINHDANG	BIT,NGAYVAOKTX	DATETIME,NGAYRAKTX	DATETIME,HINH		NTEXT,CONSTRAINT FK_SINHVIEN_QT	FOREIGN KEY(MAQT)	REFERENCES QUOCTICH(MAQUOCTICH),CONSTRAINT FK_SINHVIEN_TG	FOREIGN KEY(MATG)	REFERENCES TONGIAO(MATONGIAO),CONSTRAINT FK_SINHVIEN_DT	FOREIGN KEY(MADT)	REFERENCES DANTOC(MADANTOC))";
                com.ExecuteNonQuery();

                com.CommandText = "CREATE TABLE CANBO(MACBQL		INT NOT NULL  PRIMARY KEY,TENCBQL 	NVARCHAR(30) NOT NULL,DIACHI		NVARCHAR(100))";
                com.ExecuteNonQuery();

                com.CommandText = "CREATE TABLE CAP(MACAP 		INT NOT NULL  PRIMARY KEY,	TENCAP 		NVARCHAR(30) NOT NULL)";
                com.ExecuteNonQuery();

                com.CommandText = "CREATE TABLE KTX(KTX		VARCHAR(4) NOT NULL PRIMARY KEY,TENKTX		NVARCHAR(30),SOLUONGDAY	INT)";
                com.ExecuteNonQuery();

                com.CommandText = "CREATE TABLE NAMHOC(MANAMHOC	VARCHAR(5) NOT NULL PRIMARY KEY,TENNAMHOC	NVARCHAR(20) NOT NULL,NGAYBATDAU	DATETIME,NGAYKETTHUC	DATETIME)";
                com.ExecuteNonQuery();

                com.CommandText = "CREATE TABLE HOCKI(MAHOCKI		INT	NOT NULL PRIMARY KEY,	TENHOCKI	NVARCHAR(30) NOT NULL,	MANAM		VARCHAR(5) NOT NULL,	CONSTRAINT FK_HOCKI  	   	FOREIGN KEY(MANAM)	REFERENCES NAMHOC(MANAMHOC))";
                com.ExecuteNonQuery();

                com.CommandText = "CREATE TABLE CBQL_KTX(KTX		VARCHAR(4) NOT NULL,MACBQL 		INT NOT NULL,MANAMHOC	VARCHAR(5) NOT NULL,NGAYBATDAU	DATETIME,NGAYKETTHUC	DATETIME,CONSTRAINT  pkCBQL_KTX PRIMARY KEY(KTX, MACBQL,MANAMHOC),CONSTRAINT FK_CBQL_CB FOREIGN KEY(MACBQL) REFERENCES CANBO(MACBQL),CONSTRAINT FK_CBQL_KTX FOREIGN KEY(KTX)	REFERENCES KTX(KTX),CONSTRAINT FK_CBQL_NAMHOC FOREIGN KEY(MANAMHOC) REFERENCES NAMHOC(MANAMHOC))";
                com.ExecuteNonQuery();

                com.CommandText = "CREATE TABLE DANHGIA(MADANHGIA	INT NOT NULL PRIMARY KEY,TENDANHGIA	NVARCHAR(30) NOT NULL)";
                com.ExecuteNonQuery();

                com.CommandText = "CREATE TABLE TRANGTHAIPHONG(MATRANGTHAI		INT	NOT NULL PRIMARY KEY,TENTRANGTHAI		NVARCHAR(30)	NOT NULL)";
                com.ExecuteNonQuery();

                //com.CommandText = "CREATE TABLE [DAY](MADAY VARCHAR(4) NOT NULL PRIMARY KEY, TENDAY		NVARCHAR(30) NOT NULL,SOLUONGPHG	INT,KTX		VARCHAR(4),MACODO		VARCHAR(7),CONSTRAINT FK_DAY1	FOREIGN KEY(KTX)	REFERENCES KTX(KTX),CONSTRAINT FK_DAY2 FOREIGN KEY(MACODO) REFERENCES SINHVIEN(MAKTX))";
                com.CommandText = "CREATE TABLE [DAY](MADAY VARCHAR(4) NOT NULL PRIMARY KEY, TENDAY		NVARCHAR(30) NOT NULL,SOLUONGPHG	INT,KTX		VARCHAR(4),MACODO		VARCHAR(7),CONSTRAINT FK_DAY1	FOREIGN KEY(KTX)	REFERENCES KTX(KTX))";
                com.ExecuteNonQuery();

                com.CommandText = "CREATE TABLE PHONG(MAPHG		VARCHAR(4)	NOT NULL PRIMARY KEY,TENPHG		NVARCHAR(30)	NOT NULL,MADAY		VARCHAR(4)	NOT NULL,SOLUONG		INT,SOLUONGTOIDA	INT,TRANGTHAI	INT,PHONGNAM	BIT,CONSTRAINT FK_PHONG	FOREIGN KEY(MADAY) REFERENCES [DAY](MADAY),CONSTRAINT FK_PHONG_TRANGTHAI FOREIGN KEY(TRANGTHAI) REFERENCES TRANGTHAIPHONG(MATRANGTHAI))";
                com.ExecuteNonQuery();

                com.CommandText = "CREATE TABLE DIEMDANH(MAKTX		VARCHAR(7) NOT NULL,MAPHG		VARCHAR(4) NOT NULL,NGAYVANG	SMALLDATETIME,COPHEP		BIT,CONSTRAINT  pkDANHGIAPHONG PRIMARY KEY(MAKTX, MAPHG, NGAYVANG),CONSTRAINT FK_DANHGIAPHONG_1 FOREIGN KEY(MAKTX) REFERENCES SINHVIEN(MAKTX),CONSTRAINT FK_DANHGIAPHONG_2 FOREIGN KEY(MAPHG) REFERENCES PHONG(MAPHG))";
                com.ExecuteNonQuery();

                com.CommandText = "CREATE TABLE DANHGIAPHONG(MAPHG		VARCHAR(4) NOT NULL,THANG		NVARCHAR(8) NOT NULL,MANAMHOC	VARCHAR(5) NOT NULL,MAXEPLOAI 	INT,DIEM		INT,GHICHU		NTEXT,CONSTRAINT  pkDANHGIAPHONG_1 PRIMARY KEY(MAPHG, THANG, MANAMHOC),CONSTRAINT FK_DANHGIAPHONG_PHONG FOREIGN KEY(MAPHG) REFERENCES PHONG(MAPHG),CONSTRAINT FK_DANHGIAPHONG_NAMHOC FOREIGN KEY(MANAMHOC)	REFERENCES NAMHOC(MANAMHOC))";
                com.ExecuteNonQuery();

                com.CommandText = "CREATE TABLE DANHGIASV(MAKTX		VARCHAR(7) NOT NULL,MAHOCKI		INT NOT NULL,MADANHGIA	INT,TICHCUC		NTEXT,TIEUCUC		NTEXT,GHICHU		NTEXT,CONSTRAINT  pkDANHGIASV PRIMARY KEY(MAKTX, MAHOCKI,MADANHGIA),CONSTRAINT FK_DANHGIASV_SINHVIEN FOREIGN KEY(MAKTX) REFERENCES SINHVIEN(MAKTX),CONSTRAINT FK_DANHGIASV_HOCKI FOREIGN KEY(MAHOCKI) REFERENCES HOCKI(MAHOCKI), CONSTRAINT FK_DANHGIASV_DANHGIA FOREIGN KEY(MADANHGIA) REFERENCES DANHGIA(MADANHGIA))";
                com.ExecuteNonQuery();

                com.CommandText = "CREATE TABLE DSSINHVIEN_PHONG(	MAKTX		VARCHAR(7) NOT NULL,	MAPHG		VARCHAR(4) NOT NULL,	NGAYVAO		DATETIME,	NGAYRA		DATETIME,	GHICHU		NTEXT,	CONSTRAINT  pkDSSINHVIEN_PHONG PRIMARY KEY(MAKTX, MAPHG, NGAYVAO),	CONSTRAINT FK_DSSINHVIEN_PHONG_KTX   	   	FOREIGN KEY(MAKTX)    			REFERENCES SINHVIEN(MAKTX),	CONSTRAINT FK_DSSINHVIEN_PHONG_PHONG   	   	FOREIGN KEY(MAPHG)    			REFERENCES PHONG(MAPHG))";
                com.ExecuteNonQuery();

                com.CommandText = "CREATE TABLE HOATDONG(	MAHOATDONG	INT NOT NULL PRIMARY KEY,	TENHOATDONG	NVARCHAR(30) NOT NULL)";
                com.ExecuteNonQuery();

                com.CommandText = "CREATE TABLE HOATDONGSV(	MAHOATDONG	INT NOT NULL,	MAKTX		VARCHAR(7) NOT NULL,	NGAY		DATETIME,	GHICHU		NVARCHAR(100),	CONSTRAINT  pkHOATDONG_SV PRIMARY KEY (MAHOATDONG, MAKTX),	CONSTRAINT FK_HOATDONG_SV_SV  	   	FOREIGN KEY(MAKTX)    			REFERENCES SINHVIEN(MAKTX),	CONSTRAINT FK_HOATDONG_SV_HD   	   	FOREIGN KEY(MAHOATDONG)    			REFERENCES HOATDONG(MAHOATDONG)	)";
                com.ExecuteNonQuery();

                com.CommandText = "CREATE TABLE KHENTHUONG(	MAKHENTHUONG	INT NOT NULL PRIMARY KEY,	TENKHENTHUONG	NVARCHAR(30) NOT NULL)";
                com.ExecuteNonQuery();

                com.CommandText = "CREATE TABLE KHENTHUONGSV(	MAKTX		VARCHAR(7) NOT NULL,	MAKHENTHUONG	INT NOT NULL,	LYDO		NTEXT,	MACAP		INT NOT NULL,	MACBQL		INT NOT NULL,	NGAY		DATETIME,	QDSO		VARCHAR(20),	GHICHU		NTEXT,	CONSTRAINT  pkKHENTHUONG_SV PRIMARY KEY (MAKTX,MAKHENTHUONG,NGAY),	CONSTRAINT FK_KHENTHUONG_SV_SV   	   	FOREIGN KEY(MAKTX)    			REFERENCES SINHVIEN(MAKTX),	CONSTRAINT FK_KHENTHUONG_SV_KT   	   	FOREIGN KEY(MAKHENTHUONG )    			REFERENCES KHENTHUONG(MAKHENTHUONG))";
                com.ExecuteNonQuery();

                com.CommandText = "CREATE TABLE KYLUAT(	MAKYLUAT	INT NOT NULL PRIMARY KEY,	TENKYLUAT	NVARCHAR(30) NOT NULL)";
                com.ExecuteNonQuery();

                com.CommandText = "CREATE TABLE KYLUATSV(	MAKTX		VARCHAR(7) NOT NULL,	MAKYLUAT	INT NOT NULL,	LYDO		NVARCHAR(100),	MACAP		INT NOT NULL,	MACBQL		INT NOT NULL,	NGAY		DATETIME  NOT NULL,	QDSO		VARCHAR(20),	CONSTRAINT  pk_KYLUATSV PRIMARY KEY(MAKTX,MAKYLUAT,NGAY),	CONSTRAINT FK_KYLUAT_SV_SV   	   	FOREIGN KEY(MAKTX)    			REFERENCES SINHVIEN(MAKTX),	CONSTRAINT FK_KHENTHUONG_SV_KL   	   	FOREIGN KEY(MAKYLUAT ) 	REFERENCES KYLUAT(MAKYLUAT), CONSTRAINT FK_KYLUAT_SV_CAP  	FOREIGN KEY(MACAP) 	REFERENCES CAP(MACAP), CONSTRAINT FK_KHENTHUONG_SV_CBQL FOREIGN KEY(MACBQL)	REFERENCES CANBO(MACBQL))";
                com.ExecuteNonQuery();

                com.CommandText = "CREATE TABLE NGUOIDUNG(	MA	INT	NOT NULL primary key,	HOTEN	NVARCHAR(30) 	NOT NULL,	[USER]	VARCHAR(32) 	NOT NULL,	[PASS]	VARCHAR(32) 	NOT NULL,	QUYEN 	CHAR(1)		NOT NULL)";
                com.ExecuteNonQuery();

                com.CommandText = "CREATE TABLE QUANHE(	MAQUANHE	INT NOT NULL PRIMARY KEY,	TENQUANHE	NVARCHAR(30))";
                com.ExecuteNonQuery();

                com.CommandText = "CREATE TABLE NGHENGHIEP(	MANGHENGHIEP	INT NOT NULL PRIMARY KEY,	TENNGHENGHIEP	NVARCHAR(30))";
                com.ExecuteNonQuery();

                com.CommandText = "CREATE TABLE THANNHAN(	MATHANNHAN	INT NOT NULL,	MAKTX		VARCHAR(7)	NOT NULL,	HOTEN		NVARCHAR(30)	NOT NULL,	NGHENGHIEP	INT,	QUANHE		INT,	CONSTRAINT  pkTHANNHAN PRIMARY KEY(MAKTX, MATHANNHAN),CONSTRAINT FK_THANHNHA_SV FOREIGN KEY(MAKTX) REFERENCES SINHVIEN(MAKTX), CONSTRAINT FK_THANHNHA_NGHENGHIEP FOREIGN KEY(NGHENGHIEP) REFERENCES NGHENGHIEP(MANGHENGHIEP), CONSTRAINT FK_THANHNHA_QUANHE FOREIGN KEY(QUANHE)REFERENCES QUANHE(MAQUANHE))";
                com.ExecuteNonQuery();

                com.CommandText = "CREATE TABLE TIENDIEN(	MAPHG		VARCHAR(4)	NOT NULL,	THANG		SMALLDATETIME	NOT NULL,	SOKW		NVARCHAR(30),	THANHTIEN	INT,	NGAYTHU 	DATETIME,	NGUOITHU	INT,	GHICHU		NTEXT,	DONGIA		INT NOT NULL,	CONSTRAINT  pkTIENDIEN PRIMARY KEY(MAPHG, THANG),CONSTRAINT FK_TIENDIEN_1 FOREIGN KEY(MAPHG) REFERENCES PHONG(MAPHG),CONSTRAINT FK_TIENDIEN_2 FOREIGN KEY(NGUOITHU) REFERENCES CANBO(MACBQL))";
                com.ExecuteNonQuery();

                com.CommandText = "CREATE TABLE TIENPHONG(	MAPHG		VARCHAR(4)	NOT NULL,	THANG		SMALLDATETIME	NOT NULL,	SOTHANHTIEN	INT,	NGAYTHU 	DATETIME,	NGUOITHU	INT,	GHICHU		NTEXT,	CONSTRAINT  pkTIENPHONG PRIMARY KEY(MAPHG, THANG),CONSTRAINT FK_TIENPHONG_1 FOREIGN KEY(MAPHG) REFERENCES PHONG(MAPHG),CONSTRAINT FK_TIENPHONG_2 FOREIGN KEY(NGUOITHU) REFERENCES CANBO(MACBQL))";
                com.ExecuteNonQuery();

                com.CommandText = "CREATE TABLE XEPLOAI(	MAXEPLOAI	INT		NOT NULL,	TENXEPLOAI	NVARCHAR(30)	NOT NULL,	DIEMCANTREN	DECIMAL(4,2),	DIEMCANDUOI	DECIMAL(4,2),check (DIEMCANTREN<=10),check (DIEMCANDUOI<=10))";
                com.ExecuteNonQuery();

                com.CommandText = "insert into nguoidung values(1,'Admin','Admin','E3AFED047B08059D0FADA10F40C1E5','A')";
                com.ExecuteNonQuery();

                
                com.CommandText = "Insert Into KTX(KTX,TENKTX,SOLUONGDAY) values('TB',N'Tịnh Biên',2)";
                com.ExecuteNonQuery();
                com.CommandText = "Insert Into KTX(KTX,TENKTX,SOLUONGDAY) values('TT',N'Tri Tôn',2)";
                com.ExecuteNonQuery();


                com.CommandText = "Insert into TrangThaiPhong(MATRANGTHAI,TENTRANGTHAI) values(1,N'Đang Hoạt Động')";
                com.ExecuteNonQuery();

                com.CommandText = "Insert into [Day](MADAY,TENDAY,SOLUONGPHG,MACODO,KTX) values ('TB1',N'Dãy 1 - KTX Tịnh Biên',8,'','TB')";
                com.ExecuteNonQuery();
                com.CommandText = "Insert into [Day](MADAY,TENDAY,SOLUONGPHG,MACODO,KTX) values ('TB2',N'Dãy 2 - KTX Tịnh Biên',8,'','TB')";
                com.ExecuteNonQuery();
                com.CommandText = "Insert into [Day](MADAY,TENDAY,SOLUONGPHG,MACODO,KTX) values ('TT1',N'Dãy 1 - KTX Tri Tôn',8,'','TT')";
                com.ExecuteNonQuery();
                com.CommandText = "Insert into [Day](MADAY,TENDAY,SOLUONGPHG,MACODO,KTX) values ('TT2',N'Dãy 2 - KTX Tri Tôn',8,'','TT')";
                com.ExecuteNonQuery();

                com.CommandText = "insert into Phong(MAPHG,TENPHG,MADAY,SOLUONGTOIDA,TRANGTHAI,PHONGNAM)"
                                            +"values('p1','Phòng 1 -D1-TB','TB1',8,1,1)";
                com.ExecuteNonQuery();
                com.CommandText = "insert into Phong(MAPHG,TENPHG,MADAY,SOLUONGTOIDA,TRANGTHAI,PHONGNAM)"
                                            + "values('p2','Phòng 2 -D1-TB','TB1',8,1,1)";
                com.ExecuteNonQuery();
                com.CommandText = "insert into Phong(MAPHG,TENPHG,MADAY,SOLUONGTOIDA,TRANGTHAI,PHONGNAM)"
                                            + "values('p3','Phòng 3 -D1-TB','TB1',8,1,1)";
                com.ExecuteNonQuery();
                
                com.CommandText = "insert into Phong(MAPHG,TENPHG,MADAY,SOLUONGTOIDA,TRANGTHAI,PHONGNAM)"
                                            + "values('p4','Phòng 1 -D2-TB','TB2',8,1,1)";
                com.ExecuteNonQuery();
                com.CommandText = "insert into Phong(MAPHG,TENPHG,MADAY,SOLUONGTOIDA,TRANGTHAI,PHONGNAM)"
                                            + "values('p5','Phòng 2 -D2-TB','TB2',8,1,1)";
                com.ExecuteNonQuery();
                com.CommandText = "insert into Phong(MAPHG,TENPHG,MADAY,SOLUONGTOIDA,TRANGTHAI,PHONGNAM)"
                                            + "values('p6','Phòng 3 -D2-TB','TB2',8,1,1)";
                com.ExecuteNonQuery();

                com.CommandText = "insert into Phong(MAPHG,TENPHG,MADAY,SOLUONGTOIDA,TRANGTHAI,PHONGNAM)"
                                            + "values('p7','Phòng 1 -D1-TT','TT1',8,1,1)";
                com.ExecuteNonQuery();
                com.CommandText = "insert into Phong(MAPHG,TENPHG,MADAY,SOLUONGTOIDA,TRANGTHAI,PHONGNAM)"
                                            + "values('p8','Phòng 2 -D1-TT','TT1',8,1,1)";
                com.ExecuteNonQuery();
                com.CommandText = "insert into Phong(MAPHG,TENPHG,MADAY,SOLUONGTOIDA,TRANGTHAI,PHONGNAM)"
                                            + "values('p9','Phòng 3 -D1-TT','TT1',8,1,1)";
                com.ExecuteNonQuery();

                com.CommandText = "insert into Phong(MAPHG,TENPHG,MADAY,SOLUONGTOIDA,TRANGTHAI,PHONGNAM)"
                                            + "values('p10','Phòng 1 -D2-TT','TT2',8,1,1)";
                com.ExecuteNonQuery();
                com.CommandText = "insert into Phong(MAPHG,TENPHG,MADAY,SOLUONGTOIDA,TRANGTHAI,PHONGNAM)"
                                            + "values('p11','Phòng 2 -D2-TT','TT2',8,1,1)";
                com.ExecuteNonQuery();
                com.CommandText = "insert into Phong(MAPHG,TENPHG,MADAY,SOLUONGTOIDA,TRANGTHAI,PHONGNAM)"
                                            + "values('p12','Phòng 3 -D2-TT','TT2',8,1,1)";
                com.ExecuteNonQuery();
                com.CommandText = "INSERT INTO QUOCTICH(MAQUOCTICH,TENQUOCTICH) VALUES(1,N'Việt Nam')";
                com.ExecuteNonQuery();
                com.CommandText = "INSERT INTO TONGIAO(MATONGIAO,TENTONGIAO) VALUES(1,N'Không')";
                com.ExecuteNonQuery();
                com.CommandText = "INSERT INTO DANTOC(MADANTOC,TENDANTOC) VALUES(1,'Kinh')";
                com.ExecuteNonQuery();

                string  [] ten ={"Anh","Ngọc","Tứ","La","Tam","Ngu","Anh","Hoa","Chiến","Tùng"};
                string[] lot ={ "Văn", "Thị", "Văn", "Thị", "Văn", "Thị", "Văn", "Thị", "Văn", "Thị" };
                string [] gioitinh={"1","0","1","0","1","0","1","0","1","0"};
                for (int i = 1; i <= 9; i++)
                {
                    com.CommandText = "insert into SINHVIEN(MAKTX,NAMSINH,HOTEN,CMND,DIENTHOAI,MSSV," +
                                                "GIOITINH,DIACHI,MAQT,MADT,MATG,DOANVIEN,DANGVIEN," +
                                                "CAMTINHDANG,NGAYVAOKTX,HINH) values(" +
                                                "'08-000"+(i).ToString()+"','1986-11-11 12:00:00 AM',N'Nguyễn "+ten[i]+" "+lot[i]+"','312000154','067537201','DTH014521'," +
                                                gioitinh[i]+",N'Đồng Tháp',1,1,1,1,0," +
                                                "0,'2008-09-11 12:12:12 AM','')";                    
                    com.ExecuteNonQuery();
                    com.CommandText = "insert into DSSinhVien_Phong(MAKTX,MAPHG,NGAYVAO) values('08-000" + (i).ToString() + "','p" + (i).ToString() + "','2008-11-1"+i+" 12:00:00 AM')";
                    com.ExecuteNonQuery();
                }
               
            }

            

        }

       
    }
}