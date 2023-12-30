<%@ Page Language="C#" Title="Tam anh music" MasterPageFile="~/Master_Log.master" AutoEventWireup="true" CodeFile="Regirter.aspx.cs" Inherits="Rerister" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="login">
        <div class="_tieude"><strong>
            Thông Tin Tài Khoản</strong></div>
        <div class="_noidung">
            <div>
                <span style="color: #FFFFFF"><strong>UserName </strong></span>
                <br />
                <center>
                    <asp:TextBox ID="txt_user" runat="server" autocomplete="off" 
                        CssClass="txt__txt" Font-Size="13px" ForeColor="#666666" Height="22" 
                         Width="250"></asp:TextBox>
                </center>
                <p>
                    <strong><asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                        ErrorMessage="Bạn chưa nhập tài khoản" ControlToValidate="txt_user" 
                        ForeColor="White"></asp:RequiredFieldValidator></strong>
                </p>
            </div>
            <div>
                
                <span style="color: #FFFFFF"><strong>PassWord </strong></span>
                <br />
                <center>
                    <asp:TextBox ID="txt_pass" TextMode="Password" runat="server" CssClass="txt__txt" Font-Size="13px" 
                        ForeColor="#666666" Height="22" type="password" Width="250"></asp:TextBox>
                </center>
                <p><strong>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                      ForeColor="White"  ControlToValidate="txt_pass" ErrorMessage="Bạn chưa nhập PassWord"></asp:RequiredFieldValidator>
               </strong> </p>
            </div>
            <div>
                
                <span style="color: #FFFFFF"><strong>Re-PassWord </strong></span>
                <br />
                <center>
                    <asp:TextBox ID="txt_repass" TextMode="Password" runat="server" CssClass="txt__txt" Font-Size="13px" 
                        ForeColor="#666666" Height="22" type="password" Width="250"></asp:TextBox>
                </center>
                <p><strong>
                   <asp:CompareValidator ID="CompareValidator1" runat="server" 
                       ControlToCompare="txt_pass" ControlToValidate="txt_repass" 
                    ForeColor="White"   ErrorMessage="Xác nhận mật khẩu không trùng"></asp:CompareValidator>
                </strong></p>
            </div>
            <p class="gachchan"><a style="color: #FFFFFF"><strong><center>Thông Tin Cá Nhân</center></strong></a></p>
            <div>
                <span style="color: #FFFFFF"><strong>Họ Và Tên</strong></span>
                <br />
                <center>
                    <asp:TextBox ID="txt_hoten" runat="server" autocomplete="off" 
                        CssClass="txt__txt" Font-Size="13px" ForeColor="#666666" Height="22" 
                         Width="250"></asp:TextBox>
                </center>
                <p><strong>
                   <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
                     ForeColor="White"  ControlToValidate="txt_hoten" ErrorMessage="Tên của bạn là gì ?"></asp:RequiredFieldValidator>
                </strong></p>
            </div>
            <div>
                <span style="color: #FFFFFF"><strong>Giới Tính</strong></span>
                <br />
                <center>
                    <asp:DropDownList ID="Drop_Gioitinh" runat="server">
                    <asp:ListItem>Nam</asp:ListItem>
                    <asp:ListItem>Nữ</asp:ListItem>
                </asp:DropDownList>
                </center>
                </div>
            <div>
                <span style="color: #FFFFFF"><strong>Ngày Sinh </strong></span>
                <br />
                <center>
                <asp:DropDownList ID="Drop_ngay" runat="server">
                    <asp:ListItem>Ng&#224;y</asp:ListItem>
                    <asp:ListItem>1</asp:ListItem>
                    <asp:ListItem>2</asp:ListItem>
                    <asp:ListItem>3</asp:ListItem>
                    <asp:ListItem>4</asp:ListItem>
                    <asp:ListItem>5</asp:ListItem>
                    <asp:ListItem>6</asp:ListItem>
                    <asp:ListItem>7</asp:ListItem>
                    <asp:ListItem>8</asp:ListItem>
                    <asp:ListItem>9</asp:ListItem>
                    <asp:ListItem>10</asp:ListItem>
                    <asp:ListItem>11</asp:ListItem>
                    <asp:ListItem>12</asp:ListItem>
                    <asp:ListItem>13</asp:ListItem>
                    <asp:ListItem>14</asp:ListItem>
                    <asp:ListItem>15</asp:ListItem>
                    <asp:ListItem>16</asp:ListItem>
                    <asp:ListItem>17</asp:ListItem>
                    <asp:ListItem>18</asp:ListItem>
                    <asp:ListItem>19</asp:ListItem>
                    <asp:ListItem>20</asp:ListItem>
                    <asp:ListItem>21</asp:ListItem>
                    <asp:ListItem>22</asp:ListItem>
                    <asp:ListItem>23</asp:ListItem>
                    <asp:ListItem>24</asp:ListItem>
                    <asp:ListItem>25</asp:ListItem>
                    <asp:ListItem>26</asp:ListItem>
                    <asp:ListItem>27</asp:ListItem>
                    <asp:ListItem>28</asp:ListItem>
                    <asp:ListItem>29</asp:ListItem>
                    <asp:ListItem>30</asp:ListItem>
                    <asp:ListItem>31</asp:ListItem>
                </asp:DropDownList>  &nbsp;&nbsp; &nbsp;
                <asp:DropDownList ID="Drop_thang" runat="server" >
                    <asp:ListItem>Th&#225;ng</asp:ListItem>
                    <asp:ListItem>1</asp:ListItem>
                    <asp:ListItem>2</asp:ListItem>
                    <asp:ListItem>3</asp:ListItem>
                    <asp:ListItem>4</asp:ListItem>
                    <asp:ListItem>5</asp:ListItem>
                    <asp:ListItem>6</asp:ListItem>
                    <asp:ListItem>7</asp:ListItem>
                    <asp:ListItem>8</asp:ListItem>
                    <asp:ListItem>9</asp:ListItem>
                    <asp:ListItem>10</asp:ListItem>
                    <asp:ListItem>11</asp:ListItem>
                    <asp:ListItem>12</asp:ListItem>
                </asp:DropDownList>
                    <asp:TextBox ID="txt_namsinh" runat="server" autocomplete="off" 
                        CssClass="txt__txt" Font-Size="13px" ForeColor="#666666" Height="22px" 
                         Width="50px"></asp:TextBox>
                </center><p>
                   
                </p>
            </div>
            <div>
                <span style="color: #FFFFFF"><strong>Hộ Chiếu</strong></span>
                <br />
                <center>
                    <asp:TextBox ID="txt_hochieu" runat="server" autocomplete="off" 
                        CssClass="txt__txt" Font-Size="13px" ForeColor="#666666" Height="22" 
                         Width="250"></asp:TextBox>
                </center><p><strong>
                   <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" 
                     ForeColor="White"  ControlToValidate="txt_hochieu" ErrorMessage="Bạn Chưa Nhập Hô Chiếu"></asp:RequiredFieldValidator>
              </strong>  </p>
            </div>
            <div>
                <span style="color: #FFFFFF"><strong>Email</strong></span>
                <br />
                <center>
                    <asp:TextBox ID="txt_email" runat="server" autocomplete="off" 
                        CssClass="txt__txt" Font-Size="13px" ForeColor="#666666" Height="22px" 
                         Width="127px"></asp:TextBox> @
                         <asp:DropDownList ID="Drop_mail" runat="server">
                    <asp:ListItem>Yahoo.com</asp:ListItem>
                    <asp:ListItem>Yahoo.com.vn</asp:ListItem>
                    <asp:ListItem>Gmail.com</asp:ListItem>
                    <asp:ListItem>Hotmail.com</asp:ListItem>
                </asp:DropDownList>
                </center><p><strong>
                   <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" 
                    ForeColor="White"   ControlToValidate="txt_email" ErrorMessage="Bạn Chưa Nhập Email "></asp:RequiredFieldValidator>
               </strong> </p>
            </div>
            <div>
                <span style="color: #FFFFFF"><strong>Hình Đại Diện</strong></span>
                <br />
                <center>
                    
                            <asp:FileUpload ID="FileUp_hinhuser" runat="server" />
                    
                </center>
            </div>
            <p></p>
            <div style="text-align: center">
                <asp:ImageButton ID="ImageButton1" runat="server" 
                    ImageUrl="~/img_button/dangky.jpg" onclick="ImageButton1_Click" />
                    <a href="Login.sapx"> <img src="img_button/dangnhap.jpg" width="45%" height="32px" /></a>
            </div>          
        </div>
    </div>
</asp:Content>

