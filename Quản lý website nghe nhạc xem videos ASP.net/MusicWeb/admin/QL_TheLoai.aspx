<%@ Page Title="Tam anh music admin" Language="C#" MasterPageFile="~/admin/Master_Admin.master" AutoEventWireup="true" CodeFile="QL_TheLoai.aspx.cs" Inherits="admin_QL_TheLoai" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<div class='menu'>
<ul>
<li><a href='QL_TheLoai.aspx?Tl=Xem' >Xem Thể Loại</a></li>
<li><a href='QL_TheLoai.aspx?Tl=Sua' >Sửa Thể Loại</a></li>
<li><a href='QL_TheLoai.aspx?Tl=Them' >Thêm Thể Loại</a></li>
</ul>
</div>
<div>
    <asp:MultiView ID="MultiView1" runat="server">
        <asp:View ID="View1" runat="server"><p> Nhập vào số Mã Thể Loại cần xóa :
            <asp:TextBox ID="txt_xoa_theloai" runat="server" Width="64px"></asp:TextBox>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Button 
                ID="btn_xoa_theloai" runat="server" Text="Xóa" 
                onclick="btn_xoa_theloai_Click"  /></p>
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
                BackColor="#DEBA84" BorderColor="#DEBA84" BorderStyle="None" BorderWidth="1px" 
                CellPadding="3" CellSpacing="2" DataKeyNames="MaTheLoai" 
                DataSourceID="SqlDataSource1" Width="85%">
                <Columns>
                    <asp:BoundField DataField="MaTheLoai" HeaderText="MaTheLoai" InsertVisible="False" 
                        ReadOnly="True" SortExpression="MaTheLoai" />
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
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
                ConnectionString="<%$ ConnectionStrings:SVR %>" 
                
                SelectCommand="SELECT * FROM [TheLoai]"></asp:SqlDataSource>
        </asp:View>
        <asp:View ID="View2" runat="server">
        <p> Nhập vào số Mã Thể Loại cần Tìm :
            <asp:TextBox ID="txt_tim_theloai" runat="server" Width="64px"></asp:TextBox>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Button 
                ID="btn_tim_theloai" runat="server" Text="Tìm" style="width: 35px" 
                onclick="btn_tim_theloai_Click"/></p>
        <table border="0" style="width: 80%">
                    <tr>
                        <td class="__left" style="height: 26px; text-align: right;">
                            Tên Thể Loại :</td>
                        <td style="text-align: left; height: 26px;">
                            <asp:TextBox ID="txt_tentheloai" runat="server"></asp:TextBox>
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
                            TênThể Loại :</td>
                        <td style="text-align: left; height: 26px;">
                            <asp:TextBox ID="txt_add_tentheloai" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td colspan="2" style="height: 36px; text-align: center;">
                            <asp:Button ID="btn_add_theloai" runat="server" Text="Cập Nhật" 
                                onclick="btn_add_theloai_Click" />
                            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        </td>
                    </tr>
                </table>         
            <br />
        </asp:View>
    </asp:MultiView>
</div>
</asp:Content>

