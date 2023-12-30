<%@ Page Language="C#" MasterPageFile="~/Admin/Admin.Master" AutoEventWireup="true"
    CodeBehind="CapnhatHTTT.aspx.cs" Inherits="DoAn4.Admin.WebForm6" Title="Hình thức thanh toán" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .khungVC
        {
            width: 793px;
            height: 632px;
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
            height: 35px;
        }
        .style6
        {
            font-family: Arial;
            font-size: small;
        }
        </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="khungVC">
        <div class="daukhungVC">
            CẬP NHẬT HÌNH THỨC THANH TOÁN</div>
        <hr width="60%" />
        <div>
            <table cellpadding="0" cellspacing="0" class="style4" width="100%">
            <tr>
                    <td align="right" width="45%" class="style6">
                        Mã hình thức thanh toán:
                    </td>
                    <td align="left" style="margin-left: 5px">
                        &nbsp;
                        <asp:TextBox ID="txtMa" runat="server" Width="118px" Enabled="False"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td align="right" width="45%" class="style6">
                        Tên hình thức thanh toán:
                    </td>
                    <td align="left" style="margin-left: 5px">
                        &nbsp;
                        <asp:TextBox ID="txtTenTT" runat="server" Width="240px"></asp:TextBox>
                    </td>
                </tr>
            </table>
            <br />
            <div>
                <center>
                    <asp:Button ID="btnNhap" runat="server" Text="Nhập" Width="60px" 
                        onclick="btnNhap_Click" />&nbsp;&nbsp;
                    <asp:Button ID="btnSua" runat="server" Text="Sửa" Width="60px" 
                        onclick="btnSua_Click" />&nbsp;&nbsp;
                    <asp:Button ID="btnXoa" runat="server" Text="Xóa" Width="60px" 
                        onclick="btnXoa_Click" />
                    <br />
                    <br />
                    <asp:Label ID="Label3" runat="server" style="color: #0066FF"></asp:Label>
                </center>
            </div>
            <br />
            <div>
            <center>
                <asp:GridView ID="GridView1" runat="server" AllowPaging="True" 
                    AutoGenerateColumns="False" BackColor="White" BorderColor="#CCCCCC" 
                    BorderStyle="None" BorderWidth="1px" CellPadding="3" Width="60%" 
                    style="text-align: center" onrowediting="GridView1_RowEditing" 
                    onrowupdating="GridView1_RowUpdating">
                    <FooterStyle BackColor="White" ForeColor="#000066" />
                    <RowStyle ForeColor="#000066" />
                    <Columns>
                        <asp:TemplateField HeaderText="Mã HT thanh toán" SortExpression="Pay_ID">
                            <ItemTemplate>
                                <asp:Label ID="lbMa" runat="server" Text='<%# Bind("Pay_ID") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Tên HT thanh toán" SortExpression="Pay_Name">
                            <ItemTemplate>
                                <asp:Label ID="Label5" runat="server" Text='<%# Bind("Pay_Name") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:CommandField EditText="Chọn" HeaderText="Chọn" ShowCancelButton="False" 
                            ShowEditButton="True" UpdateText="Huỷ" />
                    </Columns>
                    <PagerStyle BackColor="White" ForeColor="#000066" HorizontalAlign="Left" />
                    <EmptyDataTemplate>
                        <asp:HyperLink ID="HyperLink1" runat="server" 
                            NavigateUrl='<%# "CapnhatHTTT.aspx?Pay_ID="+Eval("Pay_ID") %>' 
                            Text='<%# Bind("Pay_Name") %>'></asp:HyperLink>
                        <br />
                        <asp:HiddenField ID="HD" runat="server" Value='<%# Eval("Pay_ID") %>' />
                    </EmptyDataTemplate>
                    <SelectedRowStyle BackColor="#669999" Font-Bold="True" ForeColor="White" />
                    <HeaderStyle BackColor="#006699" Font-Bold="True" ForeColor="White" />
                </asp:GridView>
            </center>
            </div>
        </div>
    </div>
</asp:Content>
