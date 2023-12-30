<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="giohang.aspx.cs" Inherits="giohang" Title="Gio hang cua ban" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
     <div>
        <center>
            <div>
                <asp:Label ID="Label2" runat="server" Font-Bold="True" Font-Size="Large" Width="450px"
                    ForeColor="Black" Text="GIỎ HÀNG CỦA BẠN"></asp:Label></div>
            <asp:Panel ID="Panel2" runat="server" Height="46px" Width="514px">
                <div>
                    <asp:Label ID="Label3" runat="server" Font-Bold="True" ForeColor="Black" Text="Hiện tại bạn chưa có sản phẩm nào trong giỏ hàng của mình!"
                        Width="78%" Height="17px"></asp:Label>
                    <br />
                </div>
                <div>
                    <asp:HyperLink ID="HyperLink17" runat="server" Font-Bold="True" Font-Underline="True"
                        ForeColor="Blue" NavigateUrl="~/index.aspx">Chọn mua hàng</asp:HyperLink></div>
            </asp:Panel>
        </center>
        <br />
    </div>
    <asp:Panel ID="Panel3" runat="server" Height="499px">
        <div align="center" style="width: 522px">
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" Width="100%"
                Style="margin-top: 0px" Height="103px" OnRowDeleting="GridView1_RowDeleting"
                AllowPaging="True" PagerStyle-HorizontalAlign="Center" PagerSettings-Mode="NumericFirstLast"
                OnPageIndexChanging="GridView1_PageIndexChanging" 
                OnRowCommand="GridView1_RowCommand" 
                onselectedindexchanged="GridView1_SelectedIndexChanged1">
                <PagerSettings Mode="NumericFirstLast" />
                <Columns>
                    <asp:TemplateField HeaderText="Hình Ảnh">
                        <ItemTemplate>
                            <asp:Image ID="Image1" runat="server" Height="66px" ImageUrl='<%# "dienthoai/"+Eval("Anh") %>'
                                Width="60px" />
                        </ItemTemplate>
                        <ControlStyle BackColor="white" />
                        <HeaderStyle BackColor="#3988C1" Font-Size="Smaller" ForeColor="Black" />
                    </asp:TemplateField>
                    <asp:BoundField DataField="tensp" HeaderText="Tên Sản Phẩm">
                        <ControlStyle Font-Size="Smaller" ForeColor="#00CC66" />
                        <HeaderStyle BackColor="#3988C1" Font-Size="Smaller" ForeColor="Black" />
                        <ItemStyle Font-Size="Smaller" />
                    </asp:BoundField>
                    <asp:TemplateField HeaderText="Số Lượng">
                        <ItemTemplate>
                            <asp:TextBox ID="txtsoluong" runat="server" Height="25px" Text='<%# Bind("soluong") %>'
                                Width="27px"></asp:TextBox>
                        </ItemTemplate>
                        <HeaderStyle BackColor="#3988C1" Font-Size="Smaller" ForeColor="Black" />
                        <ItemStyle Font-Underline="False" ForeColor="#0000CC" />
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Giá Bán">
                        <EditItemTemplate>
                            <asp:TextBox ID="TextBox2" runat="server" Text='<%# Bind("Gia") %>'></asp:TextBox>
                        </EditItemTemplate>
                        <ItemTemplate>
                            <asp:Label ID="lbdongia" runat="server" Font-Bold="True" ForeColor="black" Text='<%# Bind("Gia") %>'></asp:Label>
                            <br />
                            <asp:Label ID="Label10" runat="server" Font-Bold="True" ForeColor="black" Text="VND"></asp:Label>
                        </ItemTemplate>
                        <ControlStyle Font-Size="Smaller" />
                        <HeaderStyle BackColor="#3988C1" Font-Size="Smaller" ForeColor="Black" />
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Tổng Giá">
                        <EditItemTemplate>
                            <asp:TextBox ID="TextBox3" runat="server" Text='<%# Bind("TongGia") %>'></asp:TextBox>
                        </EditItemTemplate>
                        <ItemTemplate>
                            <asp:Label ID="lbtonggia" runat="server" Font-Bold="True" ForeColor="black" Text='<%# Bind("TongGia") %>'></asp:Label>
                            <br />
                            <asp:Label ID="Label11" runat="server" Font-Bold="True" ForeColor="black" Text="VND"></asp:Label>
                        </ItemTemplate>
                        <ControlStyle Font-Size="Smaller" />
                        <HeaderStyle BackColor="#3988C1" Font-Size="Smaller" ForeColor="Black" />
                    </asp:TemplateField>
                    <asp:ButtonField CommandName="capnhat" HeaderText="Cập Nhật" Text="CậpNhật">
                        <HeaderStyle BackColor="#3988C1" Font-Size="Smaller" ForeColor="Black" />
                        <ItemStyle Font-Size="Smaller" ForeColor="black" />
                    </asp:ButtonField>
                    <asp:CommandField HeaderText="Xóa" ShowDeleteButton="True" DeleteText="Xoá">
                        <HeaderStyle BackColor="#3988C1" Font-Size="Smaller" ForeColor="Black" />
                        <ItemStyle Font-Size="Smaller" ForeColor="black"/>
                    </asp:CommandField>
                    <asp:TemplateField HeaderText="Thông Tin">
                        <ItemTemplate>
                            <asp:HyperLink ID="hplthongtin" runat="server">Chi Tiết</asp:HyperLink>
                        </ItemTemplate>
                        <HeaderStyle BackColor="#3988C1" Font-Size="Small" ForeColor="Black" />
                        <ItemStyle Font-Size="Smaller" ForeColor="black" />
                    </asp:TemplateField>
                </Columns>
                <PagerStyle HorizontalAlign="Center" />
            </asp:GridView>
        </div>
        <br />
        <table align="center" cellpadding="0" cellspacing="0" style="width: 100%">
            <tr>
                <td colspan="2">
                    <asp:Label ID="lbtongtien" runat="server" Font-Bold="True" ForeColor="#40698F" Height="19px"></asp:Label>
                    <asp:Label ID="Label12" runat="server" Font-Bold="True" ForeColor="#40698F" Text="VND"></asp:Label>
                    <br />
                </td>
            </tr>
            <tr>
                <td style="text-align: center" colspan="2">
                    <asp:Button ID="btnsuagiohang" runat="server" Height="26px" OnClick="btnsuagiohang_Click"
                        Text="Cập Nhật" Width="100px" />
                </td>
            </tr>
            <tr>
                <td width="50%">
                    <asp:Button ID="btnmuatiep" runat="server" Height="26px" OnClick="btnmuatiep_Click"
                        Text="Tiếp tục" Width="100px" />
                </td>
                <td style="text-align: right">
                    <asp:Button ID="btnguidon" runat="server" Height="26px" Width="100px" OnClick="btnguidon_Click"
                        Text="Thanh Toán" />
                </td>
            </tr>
        </table>
    </asp:Panel>
</asp:Content>

