<%@ Page Language="C#" MasterPageFile="~/Admin/Admin.Master" AutoEventWireup="true"
    CodeBehind="ThemTaikhoan.aspx.cs" Inherits="DoAn4.Admin.WebForm10" Title="Thêm tài khoản" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .style2
        {
            font-family: Arial;
            font-size: large;
            text-align: center;
        }
        .style3
        {
            width: 100%;
            height: 55px;
        }
        .style4
        {
            height: 32px;
            text-align: left;
            font-family: Arial;
            font-size: small;
        }
        .style5
        {
            font-family: Arial;
            font-size: small;
                width: 40%;
        }
        .style6
        {
            height: 32px;
            text-align: right;
            font-family: Arial;
            font-size: small;
            width: 40%;
        }
        .style9
        {
            color: #FF0000;
            font-weight: bold;
            font-size: medium;
        }
        .style10
        {
            color: #FF0000;
            font-size: medium;
        }
        .style11
        {
            width: 100%;
        }
        .style12
        {
            width: 315px;
            text-align: right;
            font-family: Arial, Helvetica, sans-serif;
            font-size: small;
        }
        .style13
        {
            width: 150px;
        }
        .style14
        {
            width: 315px;
            text-align: right;
            font-family: Arial, Helvetica, sans-serif;
            font-size: small;
            height: 33px;
        }
        .style15
        {
            width: 150px;
            height: 33px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="style2">
        QUẢN LÝ TÀI KHOẢN</div>
    <hr width="50%" />
    <div style="height: 243px">
    
        <table cellpadding="0" cellspacing="0" class="style3">
            <tr>
                <td class="style5" style="text-align: right">
                    Tài khoản:
                </td>
                <td>
                    &nbsp;
                    <asp:TextBox ID="txtTaikhoan" runat="server" Width="200px"></asp:TextBox>
                    <span class="style9">*</span>
                    <asp:Label ID="Label3" runat="server" 
                        style="color: #FF0000; font-family: Arial, Helvetica, sans-serif; font-size: small;"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="style6">
                    Mật khẩu:
                </td>
                <td class="style4">
                    &nbsp;
                    <asp:TextBox ID="txtPass" runat="server" Width="200px" TextMode="Password"></asp:TextBox>
                    <span class="style10">*</span>
                    </td>
            </tr>
        </table>
        <div>
        
            
        
            <table cellpadding="0" cellspacing="0" class="style11">
                <tr>
                    <td class="style14">
                        Quyền:</td>
                    <td class="style15">
                        &nbsp; &nbsp;<asp:DropDownList ID="DropDownList1" runat="server" 
                            onselectedindexchanged="DropDownList1_SelectedIndexChanged1">
                            <asp:ListItem Value="0">Nhân viên</asp:ListItem>
                            <asp:ListItem Value="1">Quản lý</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td class="style12">
                        &nbsp;</td>
                    <td class="style13">
                        <asp:CheckBoxList ID="cb1" runat="server" Width="164px">
                            <asp:ListItem>Đổi mật khẩu</asp:ListItem>
                            <asp:ListItem>Nhập hàng</asp:ListItem>
                            <asp:ListItem>Cập nhật SP</asp:ListItem>
                            <asp:ListItem>Cập nhật Loại SP</asp:ListItem>
                            <asp:ListItem>Cập nhật Phong cách</asp:ListItem>
                            <asp:ListItem>Cập nhật HSX</asp:ListItem>
                        </asp:CheckBoxList>
                    </td>
                    <td>
                        <asp:CheckBoxList ID="cb2" runat="server">
                            <asp:ListItem>Cập nhật NCC</asp:ListItem>
                            <asp:ListItem>Tìm kiếm SP</asp:ListItem>
                            <asp:ListItem>Tìm kiếm NCC</asp:ListItem>
                            <asp:ListItem>Thống kê SP
                            </asp:ListItem>
                            <asp:ListItem>Thống kê HĐN</asp:ListItem>
                            <asp:ListItem>Thống kê SP bán chạy</asp:ListItem>
                        </asp:CheckBoxList>
                    </td>
                    <td>
                        <asp:CheckBoxList ID="cb3" runat="server">
                            <asp:ListItem>Tạo tài khoản</asp:ListItem>
                            <asp:ListItem>Danh sách hoá đơn</asp:ListItem>
                            <asp:ListItem>Thống kê doanh thu</asp:ListItem>
                        </asp:CheckBoxList>
                    </td>
                </tr>
            </table>
        
            
        
        </div>
    </div>
    <br />
    <div style="text-align: center; height: 48px;">
        <asp:Button ID="btnMoi" runat="server" onclick="btnMoi_Click" Text="Mới" 
            Width="60px" />
&nbsp;&nbsp;
        <asp:Button ID="btnthem" runat="server" Text="Nhập" Width="73px" 
            onclick="btnthem_Click"/>
        &nbsp; &nbsp;&nbsp; &nbsp;
        <br />
            <asp:Label ID="Label1" runat="server" 
                style="color: #0000FF; font-size: medium" 
                Enabled="False"></asp:Label>
        </div>
    <br />
    <div>
        <center style="height: 299px">
            <asp:GridView ID="GridView1" runat="server" BackColor="White" BorderColor="#CCCCCC"
                BorderStyle="None" BorderWidth="1px" CellPadding="3"
                Width="70%" AutoGenerateColumns="False" Height="66px" 
                style="text-align: center" onrowdeleting="GridView1_RowDeleting">
                <RowStyle ForeColor="#000066" />
                <Columns>
                    <asp:TemplateField HeaderText="Tên tài khoản" SortExpression="Account">
                        <EditItemTemplate>
                            <asp:TextBox ID="TextBox1" runat="server" Text='<%# Bind("Account") %>'></asp:TextBox>
                        </EditItemTemplate>
                        <ItemTemplate>
                            <asp:Label ID="lbTK" runat="server" Text='<%# Bind("Account") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:BoundField DataField="Password" HeaderText="Mật khẩu" 
                        SortExpression="Password" />
                    <asp:BoundField DataField="Power" HeaderText="Quyền" SortExpression="Power" />
                    <asp:CommandField DeleteText="Xoá" EditText="Chọn" HeaderText="Chọn" 
                        ShowDeleteButton="True" UpdateText="Huỷ" />
                </Columns>
                <FooterStyle BackColor="White" ForeColor="#000066" />
                <PagerStyle BackColor="White" ForeColor="#000066" HorizontalAlign="Left" />
                <SelectedRowStyle BackColor="#669999" Font-Bold="True" ForeColor="White" />
                <HeaderStyle BackColor="#006699" Font-Bold="True" ForeColor="White" />
            </asp:GridView>
        </center>
    </div>
    <br />
</asp:Content>
