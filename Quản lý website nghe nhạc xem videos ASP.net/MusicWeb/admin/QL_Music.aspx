<%@ Page Title="Tam anh music admin" Language="C#" MasterPageFile="~/admin/Master_Admin.master" AutoEventWireup="true" CodeFile="QL_Music.aspx.cs" Inherits="admin_QL_Music" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<div class='menu'>
<ul>
<li><a href='QL_Music.aspx?MS=Xem' >Xem Music</a></li>
<li><a href='QL_Music.aspx?MS=Sua' >Sửa Music</a></li>
<li><a href='QL_Music.aspx?MS=Them' >Thêm Music</a></li>
</ul>
</div>
<div>
    <asp:MultiView ID="MultiView1" runat="server">
        <asp:View ID="View1" runat="server"><p> Nhập vào số Mã Music cần xóa :
            <asp:TextBox ID="txt_xoa" runat="server" Width="64px"></asp:TextBox>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Button 
                ID="btn_xoa" runat="server" Text="Xóa User" 
                onclick="btn_xoa_Click" /></p>
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
                BackColor="#DEBA84" BorderColor="#DEBA84" BorderStyle="None" BorderWidth="1px" 
                CellPadding="3" CellSpacing="2" DataKeyNames="MaBaiHat" 
                DataSourceID="SqlDataSource1" Width="85%">
                <Columns>
                    <asp:BoundField DataField="MaBaiHat" HeaderText="MaBaiHat" InsertVisible="False" 
                        ReadOnly="True" SortExpression="MaBaiHat" />
                    <asp:BoundField DataField="MaTheLoai" HeaderText="MaTheLoai" 
                        SortExpression="MaTheLoai" />
                    <asp:BoundField DataField="MaNhacSi" HeaderText="MaNhacSi" 
                        SortExpression="MaNhacSi" />
                    <asp:BoundField DataField="MaCaSi" HeaderText="MaCaSi" 
                        SortExpression="MaCaSi" />
                    <asp:BoundField DataField="MaAlbum" HeaderText="MaAlbum" 
                        SortExpression="MaAlbum" />
                    <asp:BoundField DataField="TenBaiHat" HeaderText="TenBaiHat" 
                        SortExpression="TenBaiHat" />
                    <asp:BoundField DataField="NoiDung" HeaderText="NoiDung" 
                        SortExpression="NoiDung" />
                    <asp:BoundField DataField="TenKhongDau" HeaderText="TenKhongDau" 
                        SortExpression="TenKhongDau" />
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
                
                SelectCommand="SELECT [MaBaiHat], [MaTheLoai], [MaNhacSi], [MaCaSi], [MaAlbum], [TenBaiHat], [NoiDung], [TenKhongDau] FROM [Music]"></asp:SqlDataSource>
        </asp:View>
        <asp:View ID="View2" runat="server">
        <p> Nhập vào số Mã Music cần Tìm :
            <asp:TextBox ID="txt_" runat="server" Width="64px"></asp:TextBox>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Button 
                ID="btn_" runat="server" Text="Tìm" onclick="btn__Click" /></p>
        <table border="0" style="width: 80%">
                    <tr>
                        <td class="__left" style="height: 26px; text-align: right;">
                            Tên Bài Hát :</td>
                        <td style="text-align: left; height: 26px;">
                            <asp:TextBox ID="txt_tenbaihat" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="__left" style="text-align: right">
                            Mã Thể Loại :</td>
                        <td style="text-align: left">
                            <asp:TextBox ID="txt_matheloai" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="__left" style="height: 28px; text-align: right;">
                            &nbsp;Mã Nhạc Sĩ :</td>
                        <td style="text-align: left; height: 28px;">
                            <asp:TextBox ID="txt_manhacsi" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="__left" style="height: 28px; text-align: right;">
                            Mã Ca Sĩ :</td>
                        <td style="text-align: left; height: 28px;">
                            <asp:TextBox ID="txt_macasi" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="__left" style="height: 28px; text-align: right;">
                            Mã Album :</td>
                        <td style="text-align: left; height: 28px;">
                            <asp:TextBox ID="txt_maalbum" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="__left" style="height: 28px; text-align: right;">
                            Nội Dung :</td>
                        <td style="text-align: left; height: 28px;">
                            <asp:TextBox ID="txt_noidung" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="__left" style="text-align: right">
                            Tên Không Dấu :</td>
                        <td style="text-align: left">
                            <asp:TextBox ID="txt_tenkhongdau" runat="server"></asp:TextBox>
                            &nbsp; &nbsp;
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
                            Tên Bài Hát :</td>
                        <td style="text-align: left; height: 26px;">
                            <asp:TextBox ID="txt_add_tenbaihat" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="__left" style="text-align: right">
                            File Nhạc :</td>
                        <td style="text-align: left">
                            <asp:FileUpload ID="FileUpload_nhac" runat="server" />
                        </td>
                    </tr>
                    <tr>
                        <td class="__left" style="text-align: right">
                            Mã Thể Loại :</td>
                        <td style="text-align: left">
                            <asp:TextBox ID="txt_add_matheloai" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="__left" style="height: 28px; text-align: right;">
                            &nbsp;Mã Nhạc Sĩ :</td>
                        <td style="text-align: left; height: 28px;">
                            <asp:TextBox ID="txt_add_manhacsi" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="__left" style="height: 28px; text-align: right;">
                            Mã Ca Sĩ :</td>
                        <td style="text-align: left; height: 28px;">
                            <asp:TextBox ID="txt_add_macasi" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="__left" style="height: 28px; text-align: right;">
                            Mã Album :</td>
                        <td style="text-align: left; height: 28px;">
                            <asp:TextBox ID="txt_add_maalbum" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="__left" style="height: 28px; text-align: right;">
                            Nội Dung :</td>
                        <td style="text-align: left; height: 28px;">
                            <asp:TextBox ID="txt_add_noidung" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="__left" style="text-align: right">
                            Tên Không Dấu :</td>
                        <td style="text-align: left">
                            <asp:TextBox ID="txt_add_tenkhongdau" runat="server"></asp:TextBox>
                            &nbsp; &nbsp;
                        </td>
                    </tr>
                    <tr>
                        <td colspan="2" style="height: 36px; text-align: center;">
                            <asp:Button ID="btn_add_music" runat="server" Text="Cập Nhật" 
                                onclick="btn_add_music_Click"/>
                            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        </td>
                    </tr>
                </table>         
            <br />
            <table style="padding: 0px; width: 90%">
                <tr>
                    <td style="width: 25%">
                        <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False" 
                DataKeyNames="MaAlbum" DataSourceID="SqlDataSource2" BackColor="#DEBA84" 
                            BorderColor="#DEBA84" BorderStyle="None" BorderWidth="1px" CellPadding="3" 
                            CellSpacing="2">
                <Columns>
                    <asp:BoundField DataField="MaAlbum" HeaderText="MaAlbum" InsertVisible="False" 
                        ReadOnly="True" SortExpression="MaAlbum" />
                    <asp:BoundField DataField="TenAlbum" HeaderText="TenAlbum" 
                        SortExpression="TenAlbum" />
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
            <asp:SqlDataSource ID="SqlDataSource2" runat="server" 
                ConnectionString="<%$ ConnectionStrings:SVR %>" 
                SelectCommand="SELECT [MaAlbum], [TenAlbum] FROM [Album]">
            </asp:SqlDataSource></td>
                    <td style="width: 25%">
                         <asp:GridView ID="GridView4" runat="server" AutoGenerateColumns="False" 
                DataKeyNames="MaCaSi" DataSourceID="SqlDataSource3" BackColor="#DEBA84" 
                             BorderColor="#DEBA84" BorderStyle="None" BorderWidth="1px" CellPadding="3" 
                             CellSpacing="2" >
                <Columns>
                    <asp:BoundField DataField="MaCaSi" HeaderText="MaCaSi" InsertVisible="False" 
                        ReadOnly="True" SortExpression="MaCaSi" />
                    <asp:BoundField DataField="TenCaSi" HeaderText="TenCaSi" 
                        SortExpression="TenCaSi" />
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
            <asp:SqlDataSource ID="SqlDataSource3" runat="server" 
                ConnectionString="<%$ ConnectionStrings:SVR %>" 
                SelectCommand="SELECT [MaCaSi], [TenCaSi] FROM [Casi]"></asp:SqlDataSource></td>
                    <td style="width: 25%">
                        <asp:GridView ID="GridView3" runat="server" AutoGenerateColumns="False" 
                DataKeyNames="MaTheLoai" DataSourceID="SqlDataSource4" BackColor="#DEBA84" 
                            BorderColor="#DEBA84" BorderStyle="None" BorderWidth="1px" CellPadding="3" 
                            CellSpacing="2" >
                <Columns>
                    <asp:BoundField DataField="MaTheLoai" HeaderText="MaTheLoai" 
                        InsertVisible="False" ReadOnly="True" SortExpression="MaTheLoai" />
                    <asp:BoundField DataField="TenTheLoai" HeaderText="TenTheLoai" 
                        SortExpression="TenTheLoai" />
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
            <asp:SqlDataSource ID="SqlDataSource4" runat="server" 
                ConnectionString="<%$ ConnectionStrings:SVR %>" 
                SelectCommand="SELECT * FROM [TheLoai]"></asp:SqlDataSource></td>
                    <td style="width: 25%">
                        <asp:GridView ID="GridView5" runat="server" AutoGenerateColumns="False" 
                            DataKeyNames="MaNhacSi" DataSourceID="SqlDataSource5" BackColor="#DEBA84" 
                            BorderColor="#DEBA84" BorderStyle="None" BorderWidth="1px" CellPadding="3" 
                            CellSpacing="2">
                            <Columns>
                                <asp:BoundField DataField="MaNhacSi" HeaderText="MaNhacSi" 
                                    InsertVisible="False" ReadOnly="True" SortExpression="MaNhacSi" />
                                <asp:BoundField DataField="TenNhacSi" HeaderText="TenNhacSi" 
                                    SortExpression="TenNhacSi" />
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
                        <asp:SqlDataSource ID="SqlDataSource5" runat="server" 
                            ConnectionString="<%$ ConnectionStrings:SVR %>" 
                            SelectCommand="SELECT [MaNhacSi], [TenNhacSi] FROM [Nhacsi]">
                        </asp:SqlDataSource>
                    </td>
                </tr>
            </table>
        </asp:View>
    </asp:MultiView>
</div>
</asp:Content>

