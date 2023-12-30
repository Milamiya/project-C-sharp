<%@ Page Title="Tam anh music admin" Language="C#" MasterPageFile="~/admin/Master_Admin.master" AutoEventWireup="true" CodeFile="QL_User.aspx.cs" Inherits="admin_QL_User" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class='menu'>
<ul>
<li><a href='QL_User.aspx?Us=Xem' >Xem User</a></li>
<li><a href='QL_User.aspx?Us=Them' >Thêm User</a></li>
</ul>
</div>
<div>
    <asp:MultiView ID="MultiView1" runat="server">
        <asp:View ID="View1" runat="server">
        <div class="Xoa">
        Nhập vào số Mã User cần xóa :
            <asp:TextBox ID="txt_xoa_user" runat="server" Width="64px"></asp:TextBox>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Button 
                ID="btn_xoa_user" runat="server" Text="Xóa User" 
                onclick="btn_xoa_user_Click"  />
        </div>
            <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False" 
                BackColor="#DEBA84" BorderColor="#DEBA84" BorderStyle="None" BorderWidth="1px" 
                CellPadding="3" CellSpacing="2" 
                DataSourceID="SqlDataSource1" Width="80%">
                <Columns>
                    <asp:BoundField DataField="MaUser" HeaderText="STT" SortExpression="MaUser" />
                    <asp:BoundField DataField="TenDangNhap" HeaderText="Tài Khoản" 
                        SortExpression="TenDangNhap" />
                    <asp:BoundField DataField="MatKhau" HeaderText="Mật Khẩu" 
                        SortExpression="MatKhau" />
                    <asp:BoundField DataField="HoTen" HeaderText="Họ Tên" 
                        SortExpression="HoTen" />
                    <asp:BoundField DataField="CMT" HeaderText="Chứng Minh" 
                        SortExpression="CMT" />
                    <asp:BoundField DataField="Email" HeaderText="Email" SortExpression="Email" />
                    <asp:BoundField DataField="GioiTinh" HeaderText="Giới Tính" 
                        SortExpression="GioiTinh" />
                    <asp:BoundField DataField="NamSinh" HeaderText="Ngày Sinh" 
                        SortExpression="NamSinh" />
                </Columns>
                <FooterStyle BackColor="#F7DFB5" ForeColor="#8C4510" />
                <HeaderStyle BackColor="#A55129" Font-Bold="True" ForeColor="White" />
                <PagerStyle ForeColor="#8C4510" HorizontalAlign="Center" />
                <RowStyle BackColor="#FFF7E7" ForeColor="#8C4510" />
                <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="White" />
                <SortedAscendingCellStyle BackColor="#FFF1D4" />
                <SortedAscendingHeaderStyle BackColor="#B95C30" />
                <SortedDescendingCellStyle BackColor="#F1E5CE" />
                <SortedDescendingHeaderStyle BackColor="#93451F" />
            </asp:GridView>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
                ConnectionString="<%$ ConnectionStrings:SVR %>" 
                
                SelectCommand="SELECT [MaUser],[TenDangNhap], [MatKhau], [HoTen], [CMT], [Email], [GioiTinh], [NamSinh] FROM [UserDaTa] WHERE ([MaQuyen] &lt;= @MaQuyen)">
                <SelectParameters>
                    <asp:Parameter DefaultValue="1" Name="MaQuyen" Type="Int32" />
                </SelectParameters>
            </asp:SqlDataSource>
            <p> Admin Web</p>
            <asp:GridView ID="GridView1" runat="server" Width="50%" 
                AutoGenerateColumns="False" DataSourceID="SqlDataSource2">
                <Columns>
                    <asp:BoundField DataField="MaUser" HeaderText="STT" SortExpression="MaUser" />
                    <asp:BoundField DataField="TenDangNhap" HeaderText="Tài Khoản Admin" 
                        SortExpression="TenDangNhap" />
                    <asp:BoundField DataField="HoTen" HeaderText="Họ Tên" SortExpression="HoTen" />
                    <asp:BoundField DataField="CMT" HeaderText="Chứng Minh" SortExpression="CMT" />
                </Columns>
            </asp:GridView>
            <asp:SqlDataSource ID="SqlDataSource2" runat="server" 
                ConnectionString="<%$ ConnectionStrings:SVR %>" 
                SelectCommand="SELECT [MaUser],[TenDangNhap], [HoTen], [CMT] FROM [UserDaTa] WHERE ([MaQuyen] &gt; @MaQuyen)">
                <SelectParameters>
                    <asp:Parameter DefaultValue="1" Name="MaQuyen" Type="Int32" />
                </SelectParameters>
            </asp:SqlDataSource>
        </asp:View>
        <asp:View ID="View_AddUser" runat="server">
            <table border="0" style="width: 80%">
                    <tr>
                        <td class="__left" style="height: 26px; text-align: right;">
                            Tên Đăng Nhập :</td>
                        <td style="text-align: left; height: 26px;">
                            <asp:TextBox ID="txt_add_user" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="__left" style="text-align: right">
                            Mật Khẩu :</td>
                        <td style="text-align: left">
                            <asp:TextBox ID="txt_add_pass" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="__left" style="height: 28px; text-align: right;">
                            Họ Tên :</td>
                        <td style="text-align: left; height: 28px;">
                            <asp:TextBox ID="txt_add_ten" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="__left" style="height: 28px; text-align: right;">
                            Giới Tính :</td>
                        <td style="text-align: left; height: 28px;">
                            <asp:DropDownList ID="Drop_Gioitinh" runat="server">
                                <asp:ListItem>Nam</asp:ListItem>
                                <asp:ListItem>Nữ</asp:ListItem>
                            </asp:DropDownList>
                        </td>
                    </tr>
                    <tr>
                        <td class="__left" style="height: 28px; text-align: right;">
                            Ngày Sinh :</td>
                        <td style="text-align: left; height: 28px;">
                            <asp:DropDownList ID="Drop_ngay" runat="server">
                                <asp:ListItem>Ngày</asp:ListItem>
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
                            </asp:DropDownList>
                            &nbsp;&nbsp;
                            <asp:DropDownList ID="Drop_thang" runat="server" Height="16px">
                                <asp:ListItem>Tháng</asp:ListItem>
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
                            &nbsp;&nbsp;&nbsp;
                            <asp:TextBox ID="txt_namsinh" runat="server" autocomplete="off" 
                                CssClass="txt__txt" Font-Size="13px" ForeColor="#666666" Height="22px" 
                                Width="50px"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="__left" style="height: 28px; text-align: right;">
                            Chứng Minh :</td>
                        <td style="text-align: left; height: 28px;">
                            <asp:TextBox ID="txt_add_chungminh" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="__left" style="text-align: right">
                            Mail :</td>
                        <td style="text-align: left">
                            <asp:TextBox ID="txt_add_mail" runat="server"></asp:TextBox>
&nbsp;                      <img alt="" src="../img_button/@.jpg" 
                                style="width: 22px; height: 22px" />&nbsp;
                            <asp:DropDownList ID="Drop_mail" runat="server">
                                <asp:ListItem>Yahoo.com</asp:ListItem>
                                <asp:ListItem>Yahoo.com.vn</asp:ListItem>
                                <asp:ListItem>Gmail.com</asp:ListItem>
                                <asp:ListItem>Hotmail.com</asp:ListItem>
                            </asp:DropDownList>
                        </td>
                    </tr>
                    <tr>
                        <td class="__left" style="text-align: right">
                            Hình Ảnh :</td>
                        <td style="text-align: left">
                            <asp:FileUpload ID="FileUp_hinhuser" runat="server" />
                        </td>
                    </tr>
                    <tr>
                        <td colspan="2" style="height: 36px; text-align: center;">
                            <asp:Button ID="btn_add_user" runat="server" Text="Thêm User" onclick="btn_add_user_Click" 
                                />
                            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        </td>
                    </tr>
                </table>
        </asp:View>
    </asp:MultiView>
    </div>
</asp:Content>

