<%@ Page Title="Tam anh music admin" Language="C#" MasterPageFile="~/admin/Master_Admin.master" AutoEventWireup="true" CodeFile="QL_CaSi.aspx.cs" Inherits="admin_QL_CaSi" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<div class='menu'>
<ul>
<li><a href='QL_CaSi.aspx?Cs=Xem' >Xem Ca Sĩ</a></li>
<li><a href='QL_CaSi.aspx?Cs=Sua' >Sửa Ca Sĩ</a></li>
<li><a href='QL_CaSi.aspx?Cs=Them' >Thêm Ca Sĩ</a></li>
</ul>
</div>
<div>
    <asp:MultiView ID="MultiView1" runat="server">
        <asp:View ID="View1" runat="server"><p> Nhập vào số Mã Ca Sĩ cần xóa :
            <asp:TextBox ID="txt_xoa_casi" runat="server" Width="64px"></asp:TextBox>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Button 
                ID="btn_xoa_casi" runat="server" Text="Xóa" 
                onclick="btn_xoa_casi_Click" /></p>
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
                BackColor="#DEBA84" BorderColor="#DEBA84" BorderStyle="None" BorderWidth="1px" 
                CellPadding="3" CellSpacing="2" DataKeyNames="MaCaSi" 
                DataSourceID="SqlDataSource1" Width="85%">
                <Columns>
                    <asp:BoundField DataField="MaCaSi" HeaderText="MaCaSi" InsertVisible="False" 
                        ReadOnly="True" SortExpression="MaCaSi" />
                    <asp:BoundField DataField="TenCaSi" HeaderText="TenCaSi" 
                        SortExpression="TenCaSi" />
                    <asp:BoundField DataField="TenThat" HeaderText="TenThat" 
                        SortExpression="TenThat" />
                    <asp:BoundField DataField="NgaySinh" HeaderText="NgaySinh" 
                        SortExpression="NgaySinh" />
                    <asp:BoundField DataField="QuocTich" HeaderText="QuocTich" 
                        SortExpression="QuocTich" />
                    <asp:BoundField DataField="HinhAnh" HeaderText="HinhAnh" 
                        SortExpression="HinhAnh" />
                    <asp:BoundField DataField="GioiThieu" HeaderText="GioiThieu" 
                        SortExpression="GioiThieu" />
                    <asp:BoundField DataField="YeuThich" HeaderText="YeuThich" 
                        SortExpression="YeuThich" />
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
                
                SelectCommand="SELECT * FROM [Casi]"></asp:SqlDataSource>
        </asp:View>
        <asp:View ID="View2" runat="server">
        <p> Nhập vào số Mã Ca Sĩ cần Tìm :
            <asp:TextBox ID="txt_tim_casi" runat="server" Width="64px"></asp:TextBox>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Button 
                ID="btn_tim_casi" runat="server" Text="Tìm" onclick="btn_tim_casi_Click" /></p>
        <table border="0" style="width: 80%">
                    <tr>
                        <td class="__left" style="height: 26px; text-align: right;">
                            Tên Ca sĩ :</td>
                        <td style="text-align: left; height: 26px;">
                            <asp:TextBox ID="txt_tencasi" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="__left" style="text-align: right">
                            Tên Thật :</td>
                        <td style="text-align: left">
                            <asp:TextBox ID="txt_tenthat" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="__left" style="height: 28px; text-align: right;">
                            Ngày Sinh :</td>
                        <td style="text-align: left; height: 28px;">
                            <asp:TextBox ID="txt_ngaysinh" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="__left" style="height: 28px; text-align: right;">
                            Quốc Tịch :</td>
                        <td style="text-align: left; height: 28px;">
                            <asp:TextBox ID="txt_quoctich" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="__left" style="height: 28px; text-align: right;">
                            Hình :</td>
                        <td style="text-align: left; height: 28px;">
                           <asp:Image ID="Image11" runat="server" style='width:50px; height:50px;'/>
                            <asp:FileUpload ID="FileUp_hinh" runat="server" />
                        </td>
                    </tr>
                    <tr>
                        <td class="__left" style="height: 28px; text-align: right;">
                            Giới Thiệu :</td>
                        <td style="text-align: left; height: 28px;">
                            <asp:TextBox ID="txt_gioithieu" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td colspan="2" style="height: 36px; text-align: center;">
                            <asp:Button ID="btn_add" runat="server" Text="Cập Nhật" 
                                onclick="btn_add_Click"/>
                            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        </td>
                    </tr>
                </table>
        </asp:View>
        <asp:View ID="View3" runat="server">
        <table border="0" style="width: 80%">
                    <tr>
                        <td class="__left" style="height: 26px; text-align: right;">
                            Tên Ca Sĩ :</td>
                        <td style="text-align: left; height: 26px;">
                            <asp:TextBox ID="txt_add_tencasi" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="__left" style="text-align: right">
                            Tên Thật :</td>
                        <td style="text-align: left">
                            <asp:TextBox ID="txt_add_tenthat" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="__left" style="text-align: right">
                            Ngày Sinh :</td>
                        <td style="text-align: left">
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
                            <asp:TextBox ID="txt_namsinh" runat="server" autocomplete="off" 
                                CssClass="txt__txt" Font-Size="13px" ForeColor="#666666" Height="22px" 
                                Width="50px"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="__left" style="height: 28px; text-align: right;">
                            &nbsp;Quốc Tịch :</td>
                        <td style="text-align: left; height: 28px;">
                            <asp:TextBox ID="txt_add_quoctich" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="__left" style="height: 28px; text-align: right;">
                            Hình Ảnh:</td>
                        <td style="text-align: left; height: 28px;">
                            <asp:FileUpload ID="FileUpload_nhac0" runat="server" />
                        </td>
                    </tr>
                    <tr>
                        <td class="__left" style="height: 28px; text-align: right;">
                            Giới Thiệu :</td>
                        <td style="text-align: left; height: 28px;">
                            <asp:TextBox ID="txt_add_gioithieu" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td colspan="2" style="height: 36px; text-align: center;">
                            <asp:Button ID="btn_add_casi" runat="server" Text="Cập Nhật" 
                                onclick="btn_add_casi_Click"/>
                            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        </td>
                    </tr>
                </table>         
            <br />
        </asp:View>
    </asp:MultiView>
</div>
</asp:Content>

