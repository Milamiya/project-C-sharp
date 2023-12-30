using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using General;
using System.Net;
using System.Net.Sockets;
using System.IO;
using System.Threading;

namespace Client
{
    struct vitri//luu lai vi tri nao la quan nao
    {
        public int luot;
    }
    public partial class FormChat : Form
    {
        IRemote obj;
        String Username;
        
        WrapperTransporterClass wtc1;
        //cac bien cua caro
        string[] usernames;// mảng lưu tên User
        int count;//đẽm số User
        vitri[,] hai = new vitri[21, 21];// luu 
        private Bitmap bmpbanco = new Bitmap("..//..//caro.jpg");
        public Bitmap bmpx = new Bitmap("..//..//x.jpg");
        public Bitmap bmpo = new Bitmap("..//..//o.jpg");
        public Bitmap bmpxvang = new Bitmap("..//..//xvang.jpg");
        public Bitmap bmpovang = new Bitmap("..//..//ovang.jpg");
        int[,] mag = new int[19, 19];// luu trang vi tri quan co
        int h, c;//toa do quan vua duco dánh
        int h1, c1;//Luu vi trí quan doi thu vua di
        int flags; // sẻ ve quân nào lên bàn cờ 1=x,2=0
        int winm;// mình các thắng không 1=thắng ,0=không dùng để gởi cho đối thủ
        int winho; // đối thủ có thắng không 1=thắng , 0=không đối thủ gởi cho mình
        Boolean luot = false;// lượt ai đi False= đối thủ, true= mình
        string Doithuhientai;// tên đối thủ hiện tại
        int tralaiTextdoithu;//biến dùng quản lý CaroText 1=mở; 0=khóa
        int dachapnhan;// biến kiểm tra đỗi thủ có chấp nhận đánh caro với mình không 0=0 1=có
        int xhayo;// quan mình đanh đi la J 1=X;0=0
        int diemm; // so trân thắng của mình
        int diemdt;// so tran thắng của dối thủ
        int k;//kiem tra lan danh dau tien; 0 = lan dau tien
        int TG1 = 120;// THời gian bát đầu lhượt đán
        public FormChat(IRemote obj, String Username)
        {
            InitializeComponent();
            AcceptButton = btnSend;
            this.obj = obj;

            this.Username = Username;
            this.Text = Username;

            wtc1 = new WrapperTransporterClass();
            RegisterMethodToWrapperTransporterClass();


            obj.RegisterWrapperTransporterClass(Username, wtc1);
            //caro1

            for (int i = 0; i < 19; i++)
                for (int j = 0; j < 19; j++)
                    mag[i, j] = 0;
            for (int i = 0; i <= 20; i++)
                for (int j = 0; j <= 20; j++)
                    hai[i, j].luot = 2;
            flags = 2;//di quan O dau tien
            winm = 0;
            winho = 0;
            Doithuhientai = "";
            tralaiTextdoithu = 0;
            dachapnhan = 0;
            label3.Text = this.Username;
            label6.Text = diemm.ToString();
            xhayo = 0;// danh quan 0
            diemm = 0;
            diemdt = 0;
            usernames = new string[100];
            usernames[0] = "hai";
            count = 0;
            k = 0;
            TG.Visible = false;

            
        }// khoi tao ban cờ

        private void DoNothingInCallBack(IAsyncResult Res) { }

        private void RegisterMethodToWrapperTransporterClass()
        {
            wtc1.SendvaluePrivateTransporterDelegate += CaroValueReceivedHandler;
        }
        delegate void DelegateSendMessageToServer(String Sender, String MsgCont);// gỏi Mesage đến Server
        delegate void DelegateSendValuePrivate(String Sender, String Receiver, int type, int x, int y, int who, String Msg);// gỏi data đến Server- Sever gởi lại cho Peceiver
        //Type kiem tra loai tin goi di
        //0= chat
        //1=caro
        //2=tra loi ko tim ra nguoi chat
        //3 goi yeu cau danh caro
        //4 tra loi~ ko tin ra nguoi danh caro
        //5 thong tin goi ve nguoi khac khong chap nhan danh 
        //6 nhận thông tin Usename từ sever
        //7 thong tin sever goi di toan các Client
        //8 thnog tin doi thu thau do het h
        //9 tra lai thong tin la da nhan duoc thong tin type==8
        private void CaroValueReceivedHandler(String Sender, int type, int x, int y, int who, String Msg)
        {
            if (type == 1 && Doithuhientai.Equals(Sender))
            {
                draw2(x, y);
                winho = who;
                luot = true;
               
                TG1 = 120;//det Tg =120s;
            }
            if (type == 0)
            {
                AddTextToChatDisplay(Sender + " :" + Msg);
                btnSend.BackColor = System.Drawing.Color.Yellow;// gán BtSend thành màu vàng khi có ngưoi goi tin chát
            }
            if (type == 2)
            {
                MessageBox.Show("Erro!không thể chát với :" + Msg);
            }
            if (type == 3)
            {
                if (MessageBox.Show(Sender + " Muốn chơi Game với bạn ", "Ok", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    //chap nhan danh'
                    Doithuhientai = Sender;
                    luot = true;
                    dachapnhan = 1;
                    xhayo = 1;//danh quan x
                    diemm = 0; diemdt = 0;
                   
                    TG1 = 120;//set Tg =120s;
                }
                else
                { //tu choi dánh
                    DelegateSendValuePrivate dsmts = new DelegateSendValuePrivate(obj.SendValuePrivate);
                    dsmts.BeginInvoke(Username, Sender, 4, 0, 0, winm, null, new AsyncCallback(DoNothingInCallBack), null);
                }
            }
            if (type == 4)
            {
                MessageBox.Show(Sender + " không chấp nhận chơi !");
                tralaiTextdoithu = 1;
            }
            if (type == 5)
            {
                MessageBox.Show("không thể kết nối với : " + Msg);
                tralaiTextdoithu = 1;
            }
            if (type == 6)
            {
               
                if (!Msg.Equals(Sender))
                {
                    for (int j = 0; j <= count; j++)
                    {
                        if (Msg.Equals(usernames[j]))
                        {
                            break;
                        }
                        if (j == count)
                        {

                            usernames[count] = Msg;
                            count++;
                            break;
                        }
                    }
                }
            }
            if (type == 7)
            {
                AddTextToChatDisplay(Sender + "Đã đánh bại " + Msg);
                
            }
            if (type == 8)
            {
                MessageBox.Show("Đã thắng do đối thủ hết h. Click để đánh ván khác");
                winho = who;
                luot = true;
               
            }
            if (type == 9)
            {
                MessageBox.Show("Cố lên !");
                k = 0;// tra ve luto danh dau tien
                luot =true;
                TG1 = 120;//tra thoi gain ve 120s
            }
        }//nhận data từ sever
        /// <summary>
        /// quan ly cac button va label
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSend_Click(object sender, EventArgs e)
        {
            if (txtChatInput.Text != null && txtChatInput.Text.Length > 0)
            {
                AddTextToChatDisplay(Username + ": " + txtChatInput.Text);

                if (txtChatWith.Text.Equals("_SERVER", StringComparison.CurrentCultureIgnoreCase))
                {
                    //obj.SendMessageToServer(Username, txtChatInput.Text);
                    
                }
                else
                {

                    DelegateSendValuePrivate dsmts = new DelegateSendValuePrivate(obj.SendValuePrivate);
                    dsmts.BeginInvoke(Username, txtChatWith.Text, 0, 0, 0, winm, txtChatInput.Text, new AsyncCallback(DoNothingInCallBack), null);

                }
                txtChatInput.Clear();
            }
        }
        private void OK_Click(object sender, EventArgs e)// su kien kick nut Ok
        {
            try
            {
                Doithuhientai = comboBox1.SelectedItem.ToString();
            }
            catch (Exception e1)
            { }

            TG.Visible = true;
            OK.Visible = false;
            label4.Text = Doithuhientai;
            label5.Text = diemdt.ToString();
            xhayo = 0;// danh quan 0
            reset();
            luot = false;
            DelegateSendValuePrivate dsmts = new DelegateSendValuePrivate(obj.SendValuePrivate);
            dsmts.BeginInvoke(Username, Doithuhientai, 3, 0, 0, winm, null, new AsyncCallback(DoNothingInCallBack), null);

        }
        private void txtChatInput_TextChanged(object sender, EventArgs e)
        {
            this.btnSend.BackColor = System.Drawing.Color.Ivory;
            //tra btSend ve mau trang 
        }
        delegate void AddTextToDisplayDelegate(String Cont);
        private void AddTextToChatDisplay(String Cont)
        {
            if (this.InvokeRequired)
            {
                AddTextToDisplayDelegate d = new AddTextToDisplayDelegate(AddTextToChatDisplay);
                this.Invoke(d, Cont);
            }
            else
            {
                txtChatDisplay.AppendText(Cont + Environment.NewLine);
            }
        }

        private void FormChat_Load(object sender, EventArgs e)
        {

            banco.Image = bmpbanco;
           

        }

        private void banco_OnMouseClick(object sender, MouseEventArgs e)
        {
            if (tralaiTextdoithu == 1)
            {
                TG.Visible = false;
                OK.Visible = true;
                tralaiTextdoithu = 0;
            }
            if (dachapnhan == 1)
            {
                OK.Visible = false;
                label4.Text = Doithuhientai;
                label5.Text = diemdt.ToString();
                dachapnhan = 0;
                reset();
            }
            if (luot)
            {
                
                if (winho == 0)
                {
                   
                    draw(e.X, e.Y);
                    TG1 = 120;//tra thoi gian va 120s
                    DelegateSendValuePrivate dsmts = new DelegateSendValuePrivate(obj.SendValuePrivate);
                    dsmts.BeginInvoke(Username, Doithuhientai, 1, (e.X), (e.Y), winm, null, new AsyncCallback(DoNothingInCallBack), null);
                    if (winm == 1)
                    {
                        winm = 0;
                    }
                }
                else
                {
                    if (winho == 2)
                    {
                        DelegateSendValuePrivate dsmts = new DelegateSendValuePrivate(obj.SendValuePrivate);//tra thông tin về cho đối thủ 
                        dsmts.BeginInvoke(Username, Doithuhientai, 9, 0, 0, winm, null, new AsyncCallback(DoNothingInCallBack), null);

                        xhayo = 0;
                        reset();
                        luot = false;
                        diemm++;
                        label6.Text = diemm.ToString();
                        label5.Text = diemdt.ToString();
                    }
                    else
                    {
                        MessageBox.Show("U Lose Play again OK!");

                        diemdt++;
                        label6.Text = diemm.ToString();
                        label5.Text = diemdt.ToString();
                        reset();
                        luot = true;
                        xhayo = 1;
                        k = 0;
                    }
                }
            }
        }

        private void comboBox1_oneClick(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            DelegateSendValuePrivate dsmts = new DelegateSendValuePrivate(obj.SendValuePrivate);
            dsmts.BeginInvoke(Username, null, 6, 0, 0, winm, null, new AsyncCallback(DoNothingInCallBack), null);
            
            for (int j = 0; j < count; j++)
                comboBox1.Items.Add(usernames[j]);

        }
        private void banco1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        // ket thuc quan ly các button label
        ///Bat dau quan lý Cờ caro
        public void draw2(int x, int y)
        {
            const int kickco = 32;
            Graphics g = banco.CreateGraphics();
            int i = 0, j = 0;
            h = 0; c = 0;
            h1 = 0; c1 = 0;
            while (i < x)
            {
                h++;
                i += kickco;
            }
            while (j < y)
            {
                c++;
                j += kickco;
            }
            if (mag[h, c] == 0)
            {

                if (flags == 1)
                {
                    g.DrawImage(bmpxvang, new Point((h - 1) * kickco, (c - 1) * kickco));
                    flags = 2;
                    mag[h, c] = 1;
                    hai[(h + 1), (c + 1)].luot = 1;

                }
                else
                {
                    g.DrawImage(bmpovang, new Point((h - 1) * kickco, (c - 1) * kickco));
                    flags = 1;
                    mag[h, c] = 2;
                    hai[(h + 1), (c + 1)].luot = 0;

                }
                h1 = h + 1;
                c1 = c + 1;
                k = 1;
              



            }
        }// ve khi nhan duoc vi tri quan co doi thu bo qua kiem tra
        public void draw(int x, int y)
        {
            const int kickco = 32;

            Graphics g = banco.CreateGraphics();
            int i = 0, j = 0;
            h = 0; c = 0;
            while (i < x)
            {
                h++;
                i += kickco;
            }
            while (j < y)
            {
                c++;
                j += kickco;
            }
            if (mag[h, c] == 0)
            {
                luot = false;
                if (flags == 1)
                {
                    g.DrawImage(bmpx, new Point((h - 1) * kickco, (c - 1) * kickco));
                    flags = 2;
                    mag[h, c] = 1;
                    hai[(h + 1), (c + 1)].luot = 1;
                    check((h + 1), (c + 1));
                }
                else
                {
                    g.DrawImage(bmpo, new Point((h - 1) * kickco, (c - 1) * kickco));
                    flags = 1;
                    mag[h, c] = 1;
                    hai[(h + 1), (c + 1)].luot = 0;
                    check((h + 1), (c + 1));
                }
                if (k != 0)
                {
                    if (hai[h1, c1].luot == 0)
                    {
                        g.DrawImage(bmpo, new Point((h1 - 2) * kickco, (c1 - 2) * kickco));
                    }
                    else
                    {
                        g.DrawImage(bmpx, new Point((h1 - 2) * kickco, (c1 - 2) * kickco));
                    }
                }
                else
                {
                    k = 1;
                    TG1 = 120;
                    TG.Visible = true;
                }

            }
        }//ve khi minh đánh..... có kiem tra thang thua
        void check(int check1, int check2)//kiem tra nut nhap vao co hoan thanh chuoi 5 lien tiep
        {
            int checktoi = 0, checklui = 0, checklen = 0, checkxuong = 0,
                checkcheolp = 0, checkcheoxp = 0, checkcheolt = 0, checkcheoxt = 0;//bien kiem tra chuoi cac nut nhap vao`
            int checkluot = hai[check1, check2].luot;//kieem tra nut vua nhap la x hay o
            //kiem tra theo hang ngan lui
            for (int i = 1; i < 19; i++)
            {
                if (check1 - i >= 0)
                {
                    if (hai[check1 - i, check2].luot == checkluot)
                    {
                        checklui++;
                    }
                    else { break; }//huy lenh for vi chuoi bi ngat'
                }
                else { break; }//huy lenh for vi het o
            }


            //kiem tra theo hang ngan toi
            for (int i = 1; i < 18; i++)
            {
                if (check1 + i < 19)
                {
                    if (hai[check1 + i, check2].luot == checkluot)
                    {
                        checktoi++;
                    }
                    else { break; }//huy lenh for vi chuoi bi ngat'
                }
                else { break; }//huy lenh for vi het o
            }

            //kiem tra neu nut la o giua~
            if (checktoi + checklui == 4 && (hai[check1 + checktoi + 1, check2].luot == 2 || hai[check1 - checklui - 1, check2].luot == 2))
            {
                if (checkluot == xhayo)
                {
                    MessageBox.Show(Username + " thang");
                    DelegateSendMessageToServer dsmts = new DelegateSendMessageToServer(obj.SendMessageToServer);
                    dsmts.BeginInvoke(Username,Doithuhientai, new AsyncCallback(DoNothingInCallBack), null);
                    diemm++;
                    xhayo = 0;
                    reset();
                    winm = 1;
                    k = 0;
                    return;
                }
                else
                {
                    MessageBox.Show(Doithuhientai + " thang");
                    diemdt = 2;
                    xhayo = 1;
                    reset();
                    winm = 1;
                    k = 0;
                    return;
                }
            }
            //kiemtra theo chieu thang dung len
            for (int i = 1; i < 19; i++)
            {
                if (check2 - i >= 0)
                {
                    if (hai[check1, check2 - i].luot == checkluot)
                    {
                        checklen++;
                    }
                    else { break; }//huy lenh for vi chuoi bi ngat'
                }
                else { break; }//huy lenh for vi het o
            }


            //kiem tra theo doc xunog
            for (int i = 1; i < 18; i++)
            {
                if (check2 + i < 19)
                {
                    if (hai[check1, check2 + i].luot == checkluot)
                    {
                        checkxuong++;
                    }
                    else { break; }//huy lenh for vi chuoi bi ngat'
                }
                else { break; }//huy lenh for vi het o
            }

            //kiem tra neu nut la o giua~
            if (checklen + checkxuong == 4 && (hai[check1, check2 + checkxuong + 1].luot == 2 || hai[check1, check2 - checklen - 1].luot == 2))
            {
                if (checkluot == xhayo)
                {
                    MessageBox.Show(Username + " thang");
                    DelegateSendMessageToServer dsmts = new DelegateSendMessageToServer(obj.SendMessageToServer);
                    dsmts.BeginInvoke(Username, Doithuhientai, new AsyncCallback(DoNothingInCallBack), null);
                    diemm++;
                    xhayo = 0;
                    reset();
                    winm = 1;
                    k = 0;
                    return;
                }
                else
                {
                    MessageBox.Show(Doithuhientai + " thang");
                    diemdt = 2;
                    xhayo = 1;
                    reset();
                    winm = 1;
                    
                    return;
                }
            }
            // check cheo' doc huong xuong sang trai

            for (int i = 1; i < 19; i++)
            {
                if (check1 - i < 0)//dung khi het hang
                {
                    break;
                }
                if (check2 + i > 19)//dung khi het hang 
                {
                    break;
                }

                if (hai[check1 - i, check2 + i].luot == checkluot)
                {
                    checkcheoxp++;
                }
                else
                { break; }//dung khi dut chuoi~
            }

            // MessageBox.Show("cheo xuong"+checkcheoxp.ToString());
            //check cheo huong len sang phai
            for (int i = 1; i < 19; i++)
            {
                if (check1 + i > 19)//dung khi het hang
                {
                    break;
                }
                if (check2 - i < 0)//dung khi het hang 
                {
                    break;
                }

                if (hai[check1 + i, check2 - i].luot == checkluot)
                {
                    checkcheolp++;
                    // MessageBox.Show("Cheo l "+ checkcheolp.ToString());
                }
                else
                { break; }//dung khi dut chuoi~
            }

            if (checkcheolp + checkcheoxp == 4 && (hai[check1 + checkcheolp + 1, check2 - checkcheolp - 1].luot == 2 || hai[check1 - checkcheoxp - 1, check2 + checkcheoxp + 1].luot == 2))//kiem tra 2 o dau va cuoi co la o trong' khong
            {

                if (checkluot == xhayo)
                {
                    MessageBox.Show(Username + " thang");
                    DelegateSendMessageToServer dsmts = new DelegateSendMessageToServer(obj.SendMessageToServer);
                    dsmts.BeginInvoke(Username, Doithuhientai, new AsyncCallback(DoNothingInCallBack), null);
                    diemm++;
                    xhayo = 0;
                    reset();
                    winm = 1;
                    k = 0;
                    return;
                }
                else
                {
                    MessageBox.Show(Doithuhientai + " thang");
                    diemdt = 2;
                    xhayo = 1;
                    reset();
                    winm = 1;
                    return;
                }
            }
            //kiem tra cheo len huong sang trai
            for (int i = 1; i < 19; i++)
            {
                if (check1 - i < 0)//dung khi het hang
                {
                    break;
                }
                if (check2 - i < 0)//dung khi het hang 
                {
                    break;
                }

                if (hai[check1 - i, check2 - i].luot == checkluot)
                {
                    checkcheolt++;
                }
                else
                { break; }//dung khi dut chuoi~
            }

            // MessageBox.Show("cheo xuong"+checkcheoxp.ToString());
            //check cheo huong len sang phai
            for (int i = 1; i < 19; i++)
            {
                if (check1 + i > 19)//dung khi het hang
                {
                    break;
                }
                if (check2 + i > 19)//dung khi het hang 
                {
                    break;
                }

                if (hai[check1 + i, check2 + i].luot == checkluot)
                {
                    checkcheoxt++;
                    // MessageBox.Show("Cheo l "+ checkcheolp.ToString());
                }
                else
                { break; }//dung khi dut chuoi~
            }

            if (checkcheolt + checkcheoxt == 4 && (hai[check1 - checkcheolt - 1, check2 - checkcheolt - 1].luot == 2 || hai[check1 + checkcheoxt + 1, check2 + checkcheoxt + 1].luot == 2))//kiem tra 2 o dau va cuoi co la o trong' khong
            {


                if (checkluot == xhayo)
                {
                    MessageBox.Show(Username + " thang");
                    DelegateSendMessageToServer dsmts = new DelegateSendMessageToServer(obj.SendMessageToServer);
                    dsmts.BeginInvoke(Username, Doithuhientai, new AsyncCallback(DoNothingInCallBack), null);
                    diemm++;
                    xhayo = 0;
                    reset();
                    winm = 1;
                    k = 0;
                    return;
                }
                else
                {
                    MessageBox.Show(Doithuhientai + " thang");
                    diemdt = 2;
                    xhayo = 1;
                    reset();
                    winm = 1;
                    return;
                }
            }
        }
        void reset()//bat dau vong choi #
        {
            for (int i = 0; i <= 20; i++)
                for (int j = 0; j <= 20; j++)
                    hai[i, j].luot = 2;
            for (int i = 0; i < 19; i++)
                for (int j = 0; j < 19; j++)
                    mag[i, j] = 0;
            flags = 1;
            winho = 0;

            label6.Text = diemm.ToString();
            label5.Text = diemdt.ToString();
            TG1 = 120;//set thoi gian =120;
            banco.Refresh();


        }
       
       

      
     
        //Dong ho dem h
        private void timer1_Tick_1(object sender, EventArgs e)
        {
            TG1--;
            TG.Text = TG1.ToString();
            if (TG1 == 119)
            {
                TG.ForeColor = System.Drawing.Color.Green;

            }
            if (TG1 < 90)
            {
                TG.ForeColor = System.Drawing.Color.Yellow;
            }
            if (TG1 < 30)
            {
                TG.ForeColor = System.Drawing.Color.Yellow;
            }
            if (TG1 == 0&&k!=0)
            {
                if (luot)
                {
                    DelegateSendValuePrivate dsmts = new DelegateSendValuePrivate(obj.SendValuePrivate);
                    dsmts.BeginInvoke(Username, Doithuhientai, 8, 0, 0, 2, null, new AsyncCallback(DoNothingInCallBack), null);
                    MessageBox.Show("Hết H thua rồi");
                    diemdt++;
                    xhayo = 1;
                    reset();
                    luot = false;
                }
                

            }
        }

       
        //dong ho dem h
        
           
        




        /// Kết thúc quan lý cờ ca rô






    }
}
