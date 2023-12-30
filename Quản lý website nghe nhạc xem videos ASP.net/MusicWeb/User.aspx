<%@ Page Title="Tam anh music" Language="C#" MasterPageFile="~/Master_Home.master" AutoEventWireup="true" CodeFile="User.aspx.cs" Inherits="User" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<div class="user_left_top">
    <asp:Image ID="Image11" runat="server" style='width:100%; height:150px;'/>
</div>
<div id="Sua_img" runat="server" style="text-align: center">
<a href='User.aspx?cmd=img'>Thay Ảnh</a>
</div>
<div class="user_noidung" style="border-style: outset; border-color: #FFFFFF">
<div class="user_noidung_left">
<div class="d_left">Tài Khoản :</div>
<div class="d_mid">&nbsp;&nbsp;<asp:Label ID="Lab_taikhoan" runat="server" Text="Label"></asp:Label></div></div>
<div class="d_right"></div>
</div>
<div class="user_noidung" style="border-style: outset; border-color: #FFFFFF">
<div class="user_noidung_left">
<div class="d_left">Mật Khẩu :</div>
<div class="d_mid">&nbsp;&nbsp;<asp:Label ID="Lab_pass"  runat="server" Text="Label"></asp:Label></div></div>
<div class="d_right"><a href="User.aspx?cmd=Pass"> Đổi Mật Khẩu</a></div>
</div>
<div class="user_noidung_li" <% if(act=="Pass")  Response.Write("id='active'"); %>>
<div class="user_noidung_left">
<div class="d_left">Mật Khẩu Mới :</div>
<div class="d_mid">&nbsp;&nbsp;&nbsp;<asp:TextBox ID="txt_pass" TextMode="Password" Width="180px" runat="server"></asp:TextBox></div></div>
<div class="d_right">
   <asp:Button ID="btn_pass" runat="server" Text="Cập Nhật" 
        onclick="btn_pass_Click"  />
</div></div>
<div class="user_noidung_li" <% if(act=="Pass")  Response.Write("id='active-pass'"); %>>
<div class="user_noidung_left">
<div class="d_left">Xác Nhận MK :</div>
<div class="d_mid">&nbsp;&nbsp;&nbsp;<asp:TextBox ID="txt_repass" TextMode="Password" Width="180px" runat="server"></asp:TextBox></div></div>
<div class="d_right">
    <asp:CompareValidator ID="CompareValidator1" runat="server" 
        ErrorMessage="Không Trùng MK" ControlToCompare="txt_pass" 
        ControlToValidate="txt_repass" ForeColor="#FF3300"></asp:CompareValidator>
</div>
</div>
<div class="user_noidung" style="border-style: outset; border-color: #FFFFFF">
<div class="user_noidung_left">
<div class="d_left">Tên :</div>
<div class="d_mid">&nbsp;&nbsp;<asp:Label ID="Lab_ten" runat="server" Text="Label"></asp:Label></div></div>
<div class="d_right"><a href="User.aspx?cmd=Ten"> Đổi Tên</a></div>
</div>
<div class="user_noidung_li" <% if(act=="Ten")  Response.Write("id='active'"); %>>
<div class="user_noidung_left">
<div class="d_left">Tên Mới :</div>
<div class="d_mid">&nbsp;&nbsp;&nbsp;<asp:TextBox ID="txt_tenmoi" Width="180px" runat="server"></asp:TextBox></div></div>
<div class="d_right">
    <asp:Button ID="btn_tenmoi" runat="server" Text="Cập Nhật" 
        onclick="btn_tenmoi_Click" /></div>
</div>

<div class="user_noidung" style="border-style: outset; border-color: #FFFFFF">
<div class="user_noidung_left">
<div class="d_left">Ngay Sinh :</div>
<div class="d_mid">&nbsp;&nbsp;<asp:Label ID="Lab_ngaysinh" runat="server" Text="Label"></asp:Label></div></div>
<div class="d_right"><a href="User.aspx?cmd=NgaySinh"> Đổi Ngày Sinh</a></div>
</div>
<div class="user_noidung_li" <% if(act=="NgaySinh")  Response.Write("id='active'"); %>>
<div class="user_noidung_left">
<div class="d_left">Ngày Sinh Mới :</div>
<div class="d_mid">&nbsp;&nbsp;       
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
                </asp:DropDownList>  &nbsp;&nbsp;
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
    <%--Download source code tai Sharecode.vn--%>
</div></div>
<div class="d_right">
    <asp:Button ID="btn_ngaysinh" runat="server" Text="Cập Nhật" 
        onclick="btn_ngaysinh_Click" /></div>
     </div>   
<div class="user_noidung" style="border-style: outset; border-color: #FFFFFF">
<div class="user_noidung_left">
<div class="d_left">Giới Tính :</div>
<div class="d_mid">&nbsp;&nbsp;<asp:Label ID="Lab_gioitinh" runat="server" Text="Label"></asp:Label></div></div>
<div class="d_right"><a href="User.aspx?cmd=GioiTinh"> Đổi Giới Tính</a></div>
</div>
<div class="user_noidung_li" <% if(act=="GioiTinh")  Response.Write("id='active'"); %>>
<div class="user_noidung_left">
<div class="d_left">Giới Tính Mới :</div>
<div class="d_mid">&nbsp;&nbsp;&nbsp;    
<asp:DropDownList ID="Drop_Gioitinh" runat="server">
                    <asp:ListItem>Nam</asp:ListItem>
                    <asp:ListItem>Nữ</asp:ListItem>
                </asp:DropDownList>
</div></div>
<div class="d_right">
    <asp:Button ID="btn_gioitinh" runat="server" Text="Cập Nhật" onclick="btn_gioitinh_Click" 
         /></div>
</div>

<div class="user_noidung" style="border-style: outset; border-color: #FFFFFF">
<div class="user_noidung_left">
<div class="d_left">Chứng Minh :</div>
<div class="d_mid">&nbsp;&nbsp;<asp:Label ID="Lab_chungminh" runat="server" Text="Label"></asp:Label></div></div>
<div class="d_right"><a href="User.aspx?cmd=Chungminh"> Đổi Chứng Minh</a></div>
</div>
<div class="user_noidung_li" <% if(act=="Chungminh")  Response.Write("id='active'"); %>>
<div class="user_noidung_left">
<div class="d_left">Chứng Minh Mới :</div>
<div class="d_mid">&nbsp;&nbsp;&nbsp;<asp:TextBox ID="txt_chungminh" TextMode="Password" Width="180px" runat="server"></asp:TextBox>    
</div></div>
<div class="d_right">
    <asp:Button ID="btn_chungminh" runat="server" Text="Cập Nhật" onclick="btn_chungminh_Click" 
         /></div>
</div>

<div class="user_noidung" style="border-style: outset; border-color: #FFFFFF">
<div class="user_noidung_left">
<div class="d_left">Mail :</div>
<div class="d_mid">&nbsp;&nbsp;<asp:Label ID="Lab_mail" runat="server" Text="Label"></asp:Label></div></div>
<div class="d_right"><a href="User.aspx?cmd=mail"> Đổi Mail</a></div>
</div>
<div class="user_noidung_li" <% if(act=="mail")  Response.Write("id='active'"); %>>
<div class="user_noidung_left">
<div class="d_left">Mail Mới :</div>
<div class="d_mid">&nbsp;&nbsp;&nbsp;<asp:TextBox ID="txt_mail"  Width="70px" runat="server"></asp:TextBox> 
@
                         <asp:DropDownList ID="Drop_mail" runat="server">
                    <asp:ListItem>Yahoo.com</asp:ListItem>
                    <asp:ListItem>Yahoo.com.vn</asp:ListItem>
                    <asp:ListItem>Gmail.com</asp:ListItem>
                    <asp:ListItem>Hotmail.com</asp:ListItem>
                </asp:DropDownList>   
</div></div>
<div class="d_right">
    <asp:Button ID="Button1" runat="server" Text="Cập Nhật" onclick="btn_mail_Click" 
         /></div>
</div>
    <%--Download source code tai Sharecode.vn--%>

</asp:Content>

