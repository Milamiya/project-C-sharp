<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="thanhtoan.aspx.cs" Inherits="_Default" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <p style="text-align: center">
        &nbsp;&nbsp; &nbsp;<span style="font-size: large; color: black; font-size: xx-large"><b>THANH TOÁN 
        HÀNG</b></span></p>
    <asp:Panel ID="Panel2" runat="server">
        <div style="border: 1px solid #009999">
            <asp:Label ID="Label20" runat="server" Font-Bold="True" ForeColor="black" 
                Text="Đối với khách hàng đã đăng ký, yêu cầu đăng nhập"></asp:Label>
            <br />
            Phải đăng nhập trước khi đặt hàng<br />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:ImageButton 
                ID="imdangnhap" runat="server" ImageUrl="~/Images/Design/dangnhap.gif" 
                onclick="imdangnhap_Click" />
            <br />
            <br />
        </div>
        <div>
            <hr />
            <br />
        </div>
    </asp:Panel>
    <div>
        <asp:Panel ID="Panel1" runat="server" ForeColor="black" Visible="False">
            <div style="font-weight: bold; text-align: center">
                <h2><b>GIỎ HÀNG CỦA BẠN</b></h2><asp:GridView ID="GridView1" runat="server" 
                    AutoGenerateColumns="False" BorderColor="#FFCCFF" BorderStyle="Solid" 
                    BorderWidth="1px" Height="222px" Width="100%">
                    <RowStyle BackColor="#F1F1F1" ForeColor="black" />
                    <Columns>
                        <asp:TemplateField HeaderText="Sản phẩm" HeaderStyle-ForeColor="Black">
                            <ItemTemplate>
                                <asp:Label ID="Label19" runat="server" style="margin-bottom: 0px" 
                                    Text='<%# Eval("TenSP") %>' Width="99%"></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Số lượng" HeaderStyle-ForeColor="Black">
                            <ItemTemplate>
                                <asp:Label ID="Label29" runat="server" Text='<%# Eval("SoLuong") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Đơn giá" HeaderStyle-ForeColor="Black">
                            <ItemTemplate>
                                <asp:Label ID="Label21" runat="server" Font-Bold="True" Font-Size="11pt" 
                                    ForeColor="black" Text='<%# Eval("Gia") %>'></asp:Label>
                                <br />
                                VNĐ
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Tổng giá" HeaderStyle-ForeColor="Black">
                            <ItemTemplate>
                                <asp:Label ID="Label22" runat="server" Font-Bold="True" Font-Size="11pt" 
                                    ForeColor="black" Text='<%# Eval("TongGia") %>'></asp:Label>
                                <br />
                                VNĐ
                            </ItemTemplate>
                        </asp:TemplateField>
                    </Columns>
                    <HeaderStyle BackColor="#ECE9D8" BorderColor="Yellow" BorderStyle="Solid" 
                        BorderWidth="2px" Font-Bold="True" Font-Size="13pt" ForeColor="black" 
                        Height="30px" />
                </asp:GridView>
                <asp:Label ID="lbtien" runat="server" Font-Bold="True" Font-Size="14pt" 
                    ForeColor="black" Text="Label"></asp:Label>
                <br />
                &nbsp;&nbsp;&nbsp;&nbsp;<asp:DetailsView ID="DetailsView1" runat="server" 
                    AllowPaging="True" AutoGenerateRows="False" BackColor="White" 
                    BorderColor="#CC9966" BorderStyle="None" BorderWidth="1px" CellPadding="4" 
                    DataKeyNames="Email" DataSourceID="AccessDataSource2" Height="50px" 
                    style="text-align: center" Width="391px">
                    <FooterStyle BackColor="#FFFFCC" ForeColor="#330099" />
                    <EditRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="#663399" />
                    <RowStyle BackColor="White" ForeColor="#330099" />
                    <PagerStyle BackColor="#FFFFCC" ForeColor="#330099" HorizontalAlign="Center" />
                    <Fields>
                        <asp:TemplateField HeaderText="Họ tên" SortExpression="HoTen" HeaderStyle-ForeColor="Black">
                            <EditItemTemplate>
                                <asp:TextBox ID="TextBox1" runat="server" Text='<%# Bind("HoTen") %>'></asp:TextBox>
                            </EditItemTemplate>
                            <InsertItemTemplate>
                                <asp:TextBox ID="TextBox7" runat="server" Text='<%# Bind("HoTen") %>'></asp:TextBox>
                            </InsertItemTemplate>
                            <ItemTemplate>
                                <asp:Label ID="Label1" runat="server" Text='<%# Bind("hoten") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Địa chỉ" SortExpression="DiaChi" HeaderStyle-ForeColor="Black">
                            <EditItemTemplate>
                                <asp:TextBox ID="TextBox2" runat="server" Text='<%# Bind("DiaChi") %>'></asp:TextBox>
                            </EditItemTemplate>
                            <InsertItemTemplate>
                                <asp:TextBox ID="TextBox8" runat="server" Text='<%# Bind("DiaChi") %>'></asp:TextBox>
                            </InsertItemTemplate>
                            <ItemTemplate>
                                <asp:Label ID="Label2" runat="server" Text='<%# Bind("diachi") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Điện thoại" SortExpression="DienThoai" HeaderStyle-ForeColor="Black">
                            <EditItemTemplate>
                                <asp:TextBox ID="TextBox5" runat="server" Text='<%# Bind("DienThoai") %>'></asp:TextBox>
                            </EditItemTemplate>
                            <InsertItemTemplate>
                                <asp:TextBox ID="TextBox11" runat="server" Text='<%# Bind("DienThoai") %>'></asp:TextBox>
                            </InsertItemTemplate>
                            <ItemTemplate>
                                <asp:Label ID="Label5" runat="server" Text='<%# Bind("sodt") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                    </Fields>
                    <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="#FFFFCC" />
                </asp:DetailsView>
&nbsp;<br />
                &nbsp;&nbsp;&nbsp;&nbsp; Bạn hãy chọn hình thức thanh toán:<br />
            </div>
            <div align="center">
                <table cellpadding="0" cellspacing="0">
                    <tr>
                        <td>
                            <asp:Label ID="Label28" runat="server" Text="Hình thức thanh toán:"></asp:Label>
                        </td>
                        <td>
                            <asp:DropDownList ID="DropDownList1" runat="server" 
                                ForeColor="black" Font-Italic="true" onselectedindexchanged="DropDownList1_SelectedIndexChanged" 
                                Width="220px">
                                <asp:ListItem>Chuyển khoản qua ngân hàng</asp:ListItem>
                                <asp:ListItem>Thanh toán qua bưu điện</asp:ListItem>
                                <asp:ListItem>Thanh toán tại văn phòng công ty</asp:ListItem>
                                <asp:ListItem>Thanh toán tại nhà</asp:ListItem>
                            </asp:DropDownList>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <br />
                            <asp:Label ID="Label30" runat="server" Text="Hình thức giao hàng"></asp:Label>
                        </td>
                        <td>
                            <br />
                            <asp:TextBox ID="txtgiaohang" runat="server" Height="25px" Width="213px"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <br />
                            Ngày Giao Hàng</td>
                        <td>
                            <br />
                            <asp:TextBox ID="txtngaygiao" runat="server" Height="20px" 
                                style="margin-left: 0px" Width="217px"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <br />
                            Địa chỉ giao hàng:</td>
                        <td>
                            <br />
                            <asp:TextBox ID="txtdcgiaohang" runat="server" Width="218px"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            &nbsp;</td>
                        <td height="55">
                            <asp:ImageButton ID="ImageButton3" runat="server" 
                                ImageUrl="~/Images/Design/dongy.gif" onclick="ImageButton3_Click" />
                        </td>
                    </tr>
                </table>
            </div>
        </asp:Panel>
    </div>
    <asp:Panel ID="Panel3" runat="server" Visible="False">
        <p align="center">
            <font color="black" face="Verdana" size="2"><b>Cảm ơn bạn đã sử dụng dịch vụ của chúng tôi!</b></font></p>
        <p align="center">
            <font color="black" face="Verdana" size="2"><b>Chúng tôi sẽ xử lý đơn hàng và liên hệ lại với bạn 
    trong thời gian sớm nhất</b></font>.
        </p>
        <p align="center" style="color: black; font-style:italic">
            *Bạn vui lòng kiểm tra email để nhận đơn hàng. Trong trường hợp không tìm thấy 
    email trong Inbox, vui lòng kiểm tra trong Bulk mail</p>
</asp:Panel>
<p>
</p>
<p>
        <asp:AccessDataSource ID="AccessDataSource2" runat="server" 
            DataFile="~/App_Data/dienthoaididong.mdb" 
            SelectCommand="SELECT email, hoten, diachi, sodt FROM [tbluser] WHERE ([email] = ?)">
            <SelectParameters>
                <asp:SessionParameter Name="email" SessionField="email" />
            </SelectParameters>
        </asp:AccessDataSource>
</p>
</asp:Content>

