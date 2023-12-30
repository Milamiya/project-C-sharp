<%@ Page Language="C#" MasterPageFile="~/Admin/Admin.Master" AutoEventWireup="true"
    CodeBehind="TimkiemNCC.aspx.cs" Inherits="DoAn4.Admin.WebForm9" Title="Tìm kiếm nhà cung cấp" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .style4
        {
            text-align: center;
            font-family: Arial;
            font-weight: bold;
            font-size: medium;
        }
        .style5
        {
            width: 133px;
            font-size: small;
            font-family: Arial;
        }
        .style6
        {
            width: 100%;
            height: 115px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="style4">
        TÌM KIẾM NHÀ CUNG CẤP</div>
    <hr width="70%" />
    <div>
        <table style="width: 350px; height: 101px;" align="center">
            <tr>
                <td class="style5" style="text-align: right">
                    <asp:RadioButtonList ID="RadioButtonList1" runat="server" 
                        Style="text-align: justify" Height="114px">
                        <asp:ListItem>Mã nhà cung cấp</asp:ListItem>
                        <asp:ListItem>Tên nhà cung cấp</asp:ListItem>
                        <asp:ListItem>Địa chỉ</asp:ListItem>
                        <asp:ListItem>Số điện thoại</asp:ListItem>
                    </asp:RadioButtonList>
                    <br />
                </td>
                <td align="left">
                    <table cellpadding="0" cellspacing="0" class="style6">
                        <tr>
                            <td>
                                <asp:TextBox ID="txtMaNCC" runat="server"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:TextBox ID="txtTenNCC" runat="server"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:TextBox ID="txtDiachi" runat="server"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:TextBox ID="txtSDT" runat="server"></asp:TextBox>
                            </td>
                        </tr>
                    </table>
                </td>
            </tr>
        </table>
    </div>
    <div>
        <center style="height: 49px">
            <asp:Button ID="Button1" runat="server" Text="Mới" OnClick="Button1_Click" Width="70px" />
            &nbsp;&nbsp;
            <asp:Button ID="btnTimkiem" runat="server" Text="Tìm kiếm" OnClick="btnTimkiem_Click"
                Width="70px" />
            <br />
            <asp:Label ID="lb1" runat="server" EnableViewState="False" Style="color: #3333FF"></asp:Label>
        </center>
    </div>
    <br />
    <div>
        <center>
            <asp:GridView ID="GridView1" runat="server" BackColor="White" BorderColor="#CCCCCC"
                BorderStyle="None" BorderWidth="1px" CellPadding="3" Width="95%" AllowPaging="True"
                AutoGenerateColumns="False" OnPageIndexChanging="GridView1_PageIndexChanging1"
                Style="text-align: center">
                <RowStyle ForeColor="#000066" />
                <Columns>
                    <asp:BoundField DataField="Supplier_ID" HeaderText="Mã nhà cung cấp" SortExpression="Supplier_ID" />
                    <asp:BoundField DataField="Supplier_Name" HeaderText="Tên nhà cung cấp" SortExpression="Supplier_Name" />
                    <asp:BoundField DataField="Address" HeaderText="Địa chỉ" SortExpression="Address" />
                    <asp:BoundField DataField="Phone" HeaderText="Số ĐT" SortExpression="Phone" />
                    <asp:BoundField DataField="Email" HeaderText="Email" SortExpression="Email" />
                </Columns>
                <FooterStyle BackColor="White" ForeColor="#000066" />
                <PagerStyle BackColor="White" ForeColor="#000066" HorizontalAlign="Left" />
                <SelectedRowStyle BackColor="#669999" Font-Bold="True" ForeColor="White" />
                <HeaderStyle BackColor="#006699" Font-Bold="True" ForeColor="White" />
            </asp:GridView>
            <br />
            <br />
        </center>
    </div>
</asp:Content>
