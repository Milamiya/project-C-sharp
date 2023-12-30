<%@ Page Language="C#" MasterPageFile="~/Admin/Admin.Master" AutoEventWireup="true"
    CodeBehind="CapnhatPC.aspx.cs" Inherits="DoAn4.Admin.WebForm7" Title="Cập nhật phong cách" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .khungPC
        {
            width: 795px;
            height: 668px;
            margin-right: 0px;
        }
        .daukhungPC
        {
            color: Black;
            font-weight: bold;
            text-align: center;
            margin-top: auto;
            height: 25px;
            width: 797px;
            font-family: Arial;
            font-size: medium;
        }
        .style4
        {
            font-family: Arial;
            font-size: small;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="khungPC">
        <div class="daukhungPC">
            CẬP NHẬT PHONG CÁCH</div>
        <hr width="60%" />
        <div>
            <table style="width: 791px">
             <tr>
                    <td align="right" width="45%" class="style4">
                        Mã phong cách:
                    </td>
                    <td align="left" style="margin-left: 5px">
                        <asp:TextBox ID="txtMa" runat="server" Width="123px" Enabled="False"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td align="right" width="45%" class="style4">
                        Tên phong cách:
                    </td>
                    <td align="left" style="margin-left: 5px">
                        <asp:TextBox ID="txtTenPC" runat="server" Width="240px"></asp:TextBox>
                    </td>
                </tr>
            </table>
            <br />
            <div align="center">
                <asp:Button ID="btnNhap" runat="server" OnClick="btnNhap_Click" Text="Nhập" Width="60px" />
                &nbsp;&nbsp;
                <asp:Button ID="btnSua" runat="server" OnClick="btnSua_Click" Text="Sửa" Width="60px" />
                &nbsp;&nbsp;
                <asp:Button ID="btnXoa" runat="server" OnClick="btnXoa_Click" Text="Xóa" Width="60px" />
                <br />
                <br />
                <asp:Label ID="Label1" runat="server" style="color: #0066FF"></asp:Label>
            </div>
            <br />
        </div>
        <div>
            <center>
                <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" BackColor="White"
                    BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="3" Width="62%"
                    Style="text-align: center" onrowediting="GridView1_RowEditing" 
                    onrowupdating="GridView1_RowUpdating">
                    <FooterStyle BackColor="White" ForeColor="#000066" />
                    <RowStyle ForeColor="#000066" />
                    <Columns>
                        <asp:TemplateField HeaderText="Mã phong cách" SortExpression="Style_ID">
                            <ItemTemplate>
                                <asp:Label ID="lbMa" runat="server" Text='<%# Bind("Style_ID") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Tên phong cách" SortExpression="Style_Name">
                            <ItemTemplate>
                                <asp:Label ID="Label2" runat="server" Text='<%# Bind("Style_Name") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:CommandField EditText="Chọn" HeaderText="Chọn" ShowCancelButton="False" 
                            ShowEditButton="True" UpdateText="Hủy" />
                    </Columns>
                    <PagerStyle BackColor="White" ForeColor="#000066" HorizontalAlign="Left" />
                    <SelectedRowStyle BackColor="#669999" Font-Bold="True" ForeColor="White" />
                    <HeaderStyle BackColor="#006699" Font-Bold="True" ForeColor="White" />
                </asp:GridView>
            </center>
        </div>
    </div>
</asp:Content>
