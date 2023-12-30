<%@ Page Language="C#" MasterPageFile="~/admin/AdminMaster.master" AutoEventWireup="true" CodeFile="QuanTriChuyenMuc.aspx.cs" Inherits="admin_QuanTriChuyenMuc" Title="Untitled Page" %>


<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
 <style type="text/css">
        .style6
        {
            width: 330px;
            background-color: #FFF;
        }
        .style7
        {
            height: 28px;
        }
        .style100
        {
        	background-color: #FFFFFF;
        	}
        .style101
        {
            width: 325px;
            background-color: #FFF;
        }
    </style>
    <table cellpadding="2" cellspacing="1" border="0" align="center" 
        style="background-color: #93DCFF" width="100%">
        <tr>
            <td colspan="2" class="style100">
                <asp:HiddenField ID="hidAction" runat="server" />
                <asp:HiddenField ID="hidUser" runat="server" />
                <asp:HiddenField ID="hidCateID" runat="server" />
                <asp:HiddenField ID="hidSearch" runat="server" />
                &nbsp;
            </td>
        </tr>
        <tr>
            <td colspan="2" align="center" bgcolor="#0099CC" style="color: #FFFFFF; font-weight: bold"
                class="style7">
                Quản Trị Hệ Thống: Quản Lý Chuyên Mục
            </td>
        </tr>
        <tr>
            <td colspan="2" class="style6">
                &nbsp;
            </td>
        </tr>
        <tr>
            <td class="style101" align="right"  >
                Chuyên mục cha:
            </td>
            <td class="style100">
                <asp:DropDownList ID="drChuyenMucChaEdit" runat="server" Width="205px" 
                    AppendDataBoundItems="True">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td class="style101" align="right">
                Tên chuyên mục:
            </td>
            <td class="style100">
                <asp:TextBox ID="txtTenChuyenMuc" runat="server" Width="200px" 
                    style="margin-left: 0px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style101" align="right" id="tx">
                Link:
            </td>
            <td class="style100">
                <asp:TextBox ID="txtLink" runat="server" Width="200px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td align="center" style="border: 1px solid #DEDEDE" colspan="2" class="style100">
                <asp:LinkButton ID="lbtThoat" runat="server" PostBackUrl="~/Admin/Default.aspx" 
                    onclick="lbtThoat_Click">
                <img src="Images/signout.jpg" border="0"/><b>Thoát</b>
                </asp:LinkButton>
                &nbsp;|
                <asp:LinkButton ID="lbtTruyVan" runat="server" OnClick="lbtTruyVan_Click">
                <img src="Images/Find.gif" border="0" /><b>Truy Vấn</b>
                </asp:LinkButton>
                &nbsp;|
                <asp:LinkButton ID="lbtThem" runat="server" OnClick="lbtThem_Click">
                <img src="Images/User.png" border="0"/><b>Thêm Mới</b>
                </asp:LinkButton>
                &nbsp;|
                <asp:LinkButton ID="lbtSua" runat="server" OnClick="lbtSua_Click">
                <img src="Images/Edit2.gif" border="0"/><b>Sửa</b>
                </asp:LinkButton>
                &nbsp;|
                <asp:LinkButton ID="lbtXoa" runat="server" onclick="lbtXoa_Click">
                <img src="Images/Xoa.jpg" border="0" /><b>Xóa</b>
                </asp:LinkButton>
                &nbsp;|&nbsp;<asp:LinkButton ID="lbtLuu" runat="server" onclick="lbtLuu_Click"> <img src="Images/DiaMem.png" border="0" /><b>Lưu</b></asp:LinkButton>
                &nbsp;<div style="border-bottom: 1px solid #DEDEDE; height: 2px">
                </div>
                Chọn chuyên mục cha:&nbsp;
                <asp:DropDownList ID="drChuyenMuc" runat="server" Width="200px" AppendDataBoundItems="True">
                </asp:DropDownList>
                &nbsp; Từ khóa:
                <asp:TextBox ID="txtSearch" runat="server" Width="200px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td align="center" style="border: 1px solid #DEDEDE" colspan="2" id="TableGrid" class="style100">
                <asp:Panel ID="pnDanhSachCM" runat="server">
                    <asp:GridView ID="grvDanhSachCM" runat="server" AutoGenerateColumns="False" Width="100%">
                        <Columns>
                            <asp:TemplateField>
                                <ItemTemplate>
                                    <asp:CheckBox ID="checked" runat="server" />
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="CateID" SortExpression="CateID" Visible="false">
                                <ItemTemplate>
                                    <asp:Label ID="lbCateID" runat="server" Text='<%# Bind("CateID") %>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:BoundField DataField="CateID" HeaderText="Mã chuyên mục" SortExpression="CateID" />
                            <asp:BoundField DataField="TenChuyenMuc" HeaderText="Tên chuyên mục" 
                                SortExpression="TenChuyenMuc" />
                            <asp:BoundField DataField="MenuLevel" HeaderText="Chuyên mục Cha/Con - 0/1" 
                                SortExpression="MenuLevel" />
                        </Columns>
                    </asp:GridView>
                </asp:Panel>
            </td>
        </tr>
    </table>
</asp:Content>

