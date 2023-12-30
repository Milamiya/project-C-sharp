<%@ Page Language="C#" MasterPageFile="~/Admin/Admin.Master" AutoEventWireup="true"
    CodeBehind="CapnhatNCC.aspx.cs" Inherits="DoAn4.Admin.WebForm1" Title="Cập nhật nhà cung cấp" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .khungNCC
        {
            width: 795px;
            height: 630px;
            margin-left: 0px;
            margin-right: 0px;
        }
        .daukhungNCC
        {
            color: Black;
            font-weight: bold;
            text-align: center;
            margin-top: auto;
            height: 19px;
        }
        .style8
        {
            width: 518px;
            text-align: right;
            font-family: Arial;
            font-size: small;
        }
        .style9
        {
            width: 518px;
            text-align: right;
            color: #FFFFFF;
            font-family: Arial;
            font-size: small;
        }
        .style10
        {
            color: #000000;
            font-weight: normal;
            text-align: center;
            margin-top: auto;
            height: 19px;
        }
        .style11
        {
            background-color: #FFFFFF;
            font-family: Arial;
            font-size: large;
        }
        .style12
        {
            width: 595px;
            text-align: left;
            color: #FFFFFF;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="khungNCC">
        <div class="style10">
            <span class="style11">CẬP NHẬT NHÀ CUNG CẤP</span></div>
        <hr style="font-weight: 700" width="60%" />
        <table style="height: 117px; margin-top: 0px; width: 797px;">
        <tr>
                <td class="style8" align="right">
                    Mã nhà cung cấp:
                </td>
                <td class="style12">
                    <asp:TextBox ID="txtMa" runat="server" Width="148px" Enabled="False"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style8" align="right">
                    Tên nhà cung cấp:
                </td>
                <td class="style12">
                    <asp:TextBox ID="txtTenNCC" runat="server" Width="310px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style8" align="right">
                    Địa chỉ:
                </td>
                <td class="style12">
                    <asp:TextBox ID="txtDiachi" runat="server" Width="310px"></asp:TextBox>
                </td>
            </tr>
            <tr style="text-align: right">
                <td class="style9" style="color: #000000" align="right">
                    Số điện thoại:
                </td>
                <td class="style12">
                    <asp:TextBox ID="txtPhone" runat="server" Width="150px"></asp:TextBox>
                    <%-- <cc1:CalendarExtender ID="txtPhone_CalendarExtender" runat="server" 
                        Enabled="True" TargetControlID="txtPhone">
                    </cc1:CalendarExtender>--%>
                </td>
            </tr>
            <tr>
                <td class="style8" align="right">
                    Email:
                </td>
                <td class="style12">
                    <asp:TextBox ID="txtEmail" runat="server" Width="250px"></asp:TextBox>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="Email không đúng định dạng"
                        ControlToValidate="txtEmail" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
                </td>
            </tr>
        </table>
        <br />
        <div style="text-align: center; height: 40px;">
            <asp:Button ID="Button1" runat="server" Text="Thêm" Width="60px" 
                OnClick="Button1_Click" />&nbsp;
            &nbsp;
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Sửa" Width="60px" />
            &nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Xóa" Width="60px" />
        &nbsp;&nbsp;&nbsp;
            <br />
            <asp:Label ID="Label2" runat="server" style="color: #0066FF"></asp:Label>
        </div>
        <br />
        <center>
            <div style="height: 362px; width: 783px;">
               <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AutoGenerateColumns="False"
                    BorderStyle="None" BorderWidth="1px" CellPadding="3" Width="100%" OnPageIndexChanging="GridView1_PageIndexChanging"
                    BackColor="White" BorderColor="#CCCCCC" style="text-align: center" 
                    onrowediting="GridView1_RowEditing" onrowupdating="GridView1_RowUpdating1">
                    <FooterStyle BackColor="White" ForeColor="#000066" />
                    <RowStyle ForeColor="#000066" />
                    <Columns>
                        <asp:TemplateField HeaderText="Mã NCC" SortExpression="Supplier_ID">
                            <EditItemTemplate>
                                <asp:Label ID="Label1" runat="server" Text='<%# Eval("Supplier_ID") %>'></asp:Label>
                            </EditItemTemplate>
                            <ItemTemplate>
                                <asp:Label ID="lbMa" runat="server" Text='<%# Bind("Supplier_ID") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Tên NCC" SortExpression="Supplier_Name">
                            <ItemTemplate>
                                <asp:Label ID="Label3" runat="server" Text='<%# Bind("Supplier_Name") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Địa chỉ" SortExpression="Address">
                            <ItemTemplate>
                                <asp:Label ID="Label4" runat="server" Text='<%# Bind("Address") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Số điện thoại" SortExpression="Phone">
                            <ItemTemplate>
                                <asp:Label ID="Label5" runat="server" Text='<%# Bind("Phone") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Email" SortExpression="Email">
                            <ItemTemplate>
                                <asp:Label ID="Label6" runat="server" Text='<%# Bind("Email") %>'></asp:Label>
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
