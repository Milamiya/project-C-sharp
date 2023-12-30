<%@ Page Language="C#" MasterPageFile="~/Admin/Admin.Master" AutoEventWireup="true"
    CodeBehind="CapnhatHTVC.aspx.cs" Inherits="DoAn4.Admin.WebForm5" Title="Hình thức vận chuyển" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .khungVC
        {
            width: 796px;
            height: 634px;
            margin-right: 0px;
        }
        .daukhungVC
        {
            color: Black;
            font-weight: bold;
            text-align: center;
            margin-top: auto;
            height: 25px;
            width: 796px;
            font-family: Arial;
            font-size: medium;
        }
        .style4
        {
            width: 100%;
            font-family: Arial;
            font-size: small;
            height: 35px;
        }
        </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="khungVC">
        <div class="daukhungVC">
            CẬP NHẬT HÌNH THỨC VẬN CHUYỂN
        </div>
        <hr width="60%" />
        <div>
            <table cellpadding="0" cellspacing="0" class="style4">
             <tr>
                    <td align="right" width="45%">
                        Mã hình thức vận chuyển:
                    </td>
                    <td align="left" style="margin-left: 5px">
                        &nbsp;<asp:TextBox ID="txtMa" runat="server" Width="130px" Enabled="False"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td align="right" width="45%">
                        Tên hình thức vận chuyển:
                    </td>
                    <td align="left" style="margin-left: 5px">
                        &nbsp;<asp:TextBox ID="txtTenVC" runat="server" Width="240px"></asp:TextBox>
                    </td>
                </tr>
            </table>
            <br />
            <div align="center">
                <asp:Button ID="btnNhap" runat="server" Text="Nhập" Width="60px" OnClick="btnNhap_Click" />&nbsp;&nbsp;
                <asp:Button ID="btnSua" runat="server" Text="Sửa " Width="60px" OnClick="btnSua_Click" />&nbsp;&nbsp;
                <asp:Button ID="btnXoa" runat="server" Text="Xóa" Width="60px" OnClick="btnXoa_Click" />
                <br />
                <br />
                <asp:Label ID="Label1" runat="server" style="color: #0066FF"></asp:Label>
            </div>
            <br />
            <div>
                <center>
                    <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AutoGenerateColumns="False"
                        BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px"
                        CellPadding="3" Width="60%" Style="text-align: center" 
                        onrowediting="GridView1_RowEditing" onrowupdating="GridView1_RowUpdating">
                        <FooterStyle BackColor="White" ForeColor="#000066" />
                        <RowStyle ForeColor="#000066" />
                        <Columns>
                            <asp:TemplateField HeaderText="Mã HT vận chuyển" SortExpression="Transport_ID">
                                <ItemTemplate>
                                    <asp:Label ID="lbMa" runat="server" Text='<%# Bind("Transport_ID") %>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Tên HT vận chuyển" 
                                SortExpression="Transport_Name">
                                <ItemTemplate>
                                    <asp:Label ID="Label3" runat="server" Text='<%# Bind("Transport_Name") %>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:CommandField EditText="Chọn" HeaderText="Chọn" ShowCancelButton="False" 
                                ShowEditButton="True" UpdateText="Huỷ" />
                        </Columns>
                        <PagerStyle BackColor="White" ForeColor="#000066" HorizontalAlign="Left" />
                        <SelectedRowStyle BackColor="#669999" Font-Bold="True" ForeColor="White" />
                        <HeaderStyle BackColor="#006699" Font-Bold="True" ForeColor="White" />
                    </asp:GridView>
                </center>
            </div>
        </div>
    </div>
</asp:Content>
