<%@ Page Language="C#" MasterPageFile="~/Admin/Admin.Master" AutoEventWireup="true"
    CodeBehind="CapnhatHSX.aspx.cs" Inherits="DoAn4.Admin.WebForm11" Title="Cập nhật hãng sản xuất" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .style4
        {
            font-family: Arial;
            font-size: medium;
            font-weight: bold;
            text-align: center;
        }
        .style5
        {
            width: 70%;
            height: 37px;
        }
        .style7
        {
            text-align: right;
            font-family: Arial;
            font-size: small;
        }
        </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="style4">
        &nbsp;CẬP NHẬT HÃNG SẢN XUẤT</div>
    <hr width="60%" />
    <br />
    <div>
        <table cellpadding="0" cellspacing="0" class="style5" align="center">
        <tr>
                <td class="style7" width="40%">
                    Mã hãng sản xuất:
                </td>
                <td align="left">
                    &nbsp;
                    <asp:TextBox ID="txtMa" runat="server" Width="115px" Enabled="False"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style7" width="40%">
                    Tên hãng sản xuất:
                </td>
                <td align="left">
                    &nbsp;
                    <asp:TextBox ID="txtTen" runat="server" Width="204px"></asp:TextBox>
                </td>
            </tr>
        </table>
    </div>
    <br />
    <div>
        <center>
            &nbsp;<asp:Button ID="btnNhap" runat="server" Text="Nhập" Width="60px" 
                onclick="btnNhap_Click" />&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnSua" runat="server" Text="Sửa" Width="60px" 
                onclick="btnSua_Click" />
            &nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnXoa" runat="server" Text="Xóa" Width="60px" 
                onclick="btnXoa_Click" />
            <br />
            <br />
            <asp:Label ID="Label2" runat="server" style="color: #0066FF"></asp:Label>
        </center>
    </div>
    <br />
    <div>
        <center style="height: 342px">
            <asp:GridView ID="GridView1" runat="server" BackColor="White" BorderColor="#CCCCCC"
                BorderStyle="None" BorderWidth="1px" CellPadding="3" Width="70%" 
                AllowPaging="True" AutoGenerateColumns="False" style="text-align: center" 
                onrowediting="GridView1_RowEditing" onrowupdating="GridView1_RowUpdating">
                <FooterStyle BackColor="White" ForeColor="#000066" />
                <RowStyle ForeColor="#000066" />
                <Columns>
                    <asp:TemplateField HeaderText="Mã hãng sản xuất" SortExpression="Producer_ID">
                        <ItemTemplate>
                            <asp:Label ID="lbMa" runat="server" Text='<%# Bind("Producer_ID") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Tên hãng sản xuất" 
                        SortExpression="Producer_Name">
                        <ItemTemplate>
                            <asp:Label ID="Label4" runat="server" Text='<%# Bind("Producer_Name") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:CommandField EditText="Chọn" HeaderText="Chọn" ShowEditButton="True" 
                        UpdateText="Huỷ" ShowCancelButton="False" />
                </Columns>
                <PagerStyle BackColor="White" ForeColor="#000066" HorizontalAlign="Left" />
                <SelectedRowStyle BackColor="#669999" Font-Bold="True" ForeColor="White" />
                <HeaderStyle BackColor="#006699" Font-Bold="True" ForeColor="White" />
            </asp:GridView>
        </center>
    </div>
</asp:Content>
