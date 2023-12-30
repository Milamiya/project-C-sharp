<%@ Page Language="C#" MasterPageFile="~/Admin/Admin.Master" AutoEventWireup="true"
    CodeBehind="CapnhatMaloai.aspx.cs" Inherits="DoAn4.Admin.WebForm2" Title="Cập nhật mã loại" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .khungNCC
        {
            width: 796px;
            height: 635px;
        }
        .daukhungNCC
        {
            color: Black;
            font-weight: bold;
            text-align: center;
            margin-top: auto;
            height: 25px;
        }
        .style6
        {
            text-align: left;
            color: #FFFFFF;
            height: 28px;
            width: 435px;
        }
        .style9
        {
            height: 32px;
            width: 792px;
        }
        .style11
        {
            color: Black;
            text-align: center;
            margin-top: auto;
            height: 25px;
            font-size: large;
            font-family: Arial;
            width: 796px;
        }
    .style12
    {
        width: 43%;
    }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="khungNCC">
        <div class="style11">
            CẬP NHẬT LOẠI SẢN PHẨM</div>
        <div>
            <hr width="60%" />
        </div>
        <table style="margin-top: 0px; color: #000000;" class="style9">
        <tr>
                <td align="right" style="font-family: Arial, Helvetica, sans-serif; font-size: small;
                    color: #000000" class="style12">
                    Mã chủng loại:
                </td>
                <td class="style6">
                    &nbsp;
                    <asp:TextBox ID="txtMa" runat="server" Width="129px" Enabled="False"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td align="right" style="font-family: Arial, Helvetica, sans-serif; font-size: small;
                    color: #000000" class="style12">
                    Tên chủng loại:
                </td>
                <td class="style6">
                    &nbsp;
                    <asp:TextBox ID="txttenML" runat="server" Width="279px"></asp:TextBox>
                </td>
            </tr>
        </table>
        <br />
        <div align="center">
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnNhap" runat="server" OnClick="Button1_Click" Text="Nhập" Width="60px" />
            &nbsp;&nbsp;
            <asp:Button ID="btnSua" runat="server" OnClick="Button2_Click" Text="Sửa" Width="60px" />
            &nbsp;&nbsp;
            <asp:Button ID="btnXoa" runat="server" OnClick="Button3_Click" Text="Xóa" Width="60px" />
            <br />
            <br />
            <asp:Label ID="Label1" runat="server" style="color: #0066FF"></asp:Label>
        </div>
        <br />
        <center>
            <div style="height: 373px; width: 794px;">
                <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AutoGenerateColumns="False"
                    BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px"
                    CellPadding="3" Width="60%" OnPageIndexChanging="GridView1_PageIndexChanging"
                    Style="text-align: center" onrowediting="GridView1_RowEditing" 
                    onrowupdating="GridView1_RowUpdating">
                    <FooterStyle BackColor="White" ForeColor="#000066" />
                    <RowStyle ForeColor="#000066" />
                    <Columns>
                        <asp:TemplateField HeaderText="Mã chủng loại" SortExpression="Type_ID">
                            <ItemTemplate>
                                <asp:Label ID="lbMa" runat="server" Text='<%# Bind("Type_ID") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Tên chủng loại" SortExpression="Type_Name">
                            <ItemTemplate>
                                <asp:Label ID="Label3" runat="server" Text='<%# Bind("Type_Name") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:CommandField EditText="Chọn" HeaderText="Chọn" ShowCancelButton="False" 
                            ShowEditButton="True" UpdateText="Huỷ" />
                    </Columns>
                    <PagerStyle BackColor="White" ForeColor="#000066" HorizontalAlign="Left" />
                    <SelectedRowStyle BackColor="#669999" Font-Bold="True" ForeColor="White" />
                    <HeaderStyle BackColor="#006699" Font-Bold="True" ForeColor="White" />
                </asp:GridView>
            </div>
        </center>
    </div>
</asp:Content>
