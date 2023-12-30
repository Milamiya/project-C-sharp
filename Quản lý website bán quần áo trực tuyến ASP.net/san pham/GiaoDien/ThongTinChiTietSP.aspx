<%@ Page Language="C#" MasterPageFile="~/UserControl/NguoiDung.master" AutoEventWireup="true" CodeFile="ThongTinChiTietSP.aspx.cs" Inherits="GiaoDien_ThongTinChiTietSP" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<div class="title-giua">
Thông tin chi tiết sản phẩm
</div>
<br />
<br />
<asp:DataList ID="dlCTSP" runat="server" RepeatColumns="1" 
        onitemcommand="dlCTSP_ItemCommand">
    <ItemTemplate>
    <table width="100%" border="0" cellspacing="0" cellpadding="0" style="font-size:0.8em">
      <tr class="dong">
        <td id="cot1" width="150px" rowspan="5" align="left" valign="top" style="border:1px solid #000">
            <%--<asp:Image ID="imgProduct" runat="server" Height="150px" Width="150px" ImageUrl='<%#"~/Image/DoNu/"+Eval("Images") %>'/>--%>
            <img id="Img1" runat="server" src='<%#"~/Image/DoNu/"+Eval("Images") %>' />
        </td>
        <td align="left" valign="top" style="border-bottom:1px dotted #f2f3f4;padding-left:10px">Mã sản phẩm:
            <asp:Label ID="lblMaSp" runat="server" Font-Bold="True" ForeColor="#0066FF" 
                Text='<%#Eval("ProductID")%>'> </asp:Label>
          </td>
      </tr>
      <tr class="dong">
      <td align="left" valign="top" style="padding-left:10px" >Tên sản phẩm:
            <asp:Label ID="lblTenSP" runat="server" Font-Bold="True" ForeColor="#0066FF" 
                Text='<%#Eval("ProductName")%>'> </asp:Label>
          </td>
      </tr>
      <tr class="dong">
        <td align="left" valign="top" style="padding-left:10px">Giá:
            <asp:Label ID="lblGia" runat="server" Font-Bold="True" ForeColor="Red" 
                Text='<%#Eval("Price") %>'></asp:Label>
&nbsp;VNĐ</td>
      </tr>
      <tr class="dong">
        <td align="left" valign="top" style="padding-left:10px">Trạng thái:
            <asp:Label ID="lbLoaiSP" runat="server"></asp:Label>
                                                                                </td>
      </tr>
     <%-- <tr class="dong">
        <td align="left" valign="top">Nhà sản xuất:
            <asp:Label runat="server" ID="lblNSX"></asp:Label>
                                                                                </td>
      </tr>--%>
      <tr class="dong">
        <td align="left" valign="top"style="padding-left:10px">Đưa vào giỏ hàng, số lượng &nbsp;
           
       </td>
       <td> <asp:TextBox ID="txtSL" runat="server" Width="40px" Text='1'></asp:TextBox>
            <asp:ImageButton ID="btnThemSP" runat="server" CommandName="Them" 
                ImageUrl="~/Image/Icon/btn_addcart.gif" />
       </td>
      </tr>
      <tr class="dong" style="height:50px">
        <td>
            Mô tả sản phẩm: <asp:Label runat="server" ID="lbMoTa" Text='<%#Eval("Descriptions") %>'></asp:Label>
        </td>
      </tr>
    </table>
    </ItemTemplate>
    </asp:DataList>
    <br />
    <br />
    <br />
    <br />
    <div class="title-giua"> Sản phẩm cùng loại</div>
     <asp:DataList ID="dlSPCL" runat="server" RepeatColumns="4" 
                RepeatDirection="Horizontal" Width="551px" onitemcommand="dlSPCL_ItemCommand" 
                
                >
                <ItemTemplate>
                    <table>
                                <tr style="text-align: center; color: #1500FF; font-weight: bold; font-size: 15px">
                                    <td style="height: 35px">
                                        <asp:Label runat="server" ID="lbTenSP" Text='<%#Eval("ProductName") %>'></asp:Label>
                                    </td>
                                </tr>
                                <tr style="text-align: center">
                                    <td>
                                        <a href="#">
                                            <asp:HyperLink ID="hp1" runat="server" ImageUrl='<%#"~/Image/DoNu/"+Eval("Images") %>'
                                                Width="120px" Height="120px"
                                                NavigateUrl='<%# "ThongTinChitietSP.aspx?ProductID="+Eval("ProductID") %>'>Hình ảnh</asp:HyperLink>
                                    </td>
                                   
                                </tr>
                                <tr style="text-align: center; color: black; font-weight: bold; font-size: 13px;
                                    height: 20px">
                                    <td>
                                        <asp:Label ID="lbMaSP" runat="server" Text='<%#Eval("ProductID")%>'></asp:Label>
                                    </td>
                                </tr>
                                <tr style="text-align: center; color: black; font-weight: bold; font-size: 13px;
                                    height: 20px">
                                    <td>
                                        <asp:Label ID="lbGia" runat="server" Text='<%#Eval("Price") %>'></asp:Label>
                                    </td>
                                </tr>
                                <tr style="text-align: center">
                                    <td>
                                    <%--<asp:Button runat="server" ID ="bnthemvaogio" CommandName="Them" Text ="Them" />--%>
                                        <asp:ImageButton  ID="imbAddCart" runat="server" ImageUrl="~/Image/Icon/button_red_add_to_cart.jpeg"
                                            CommandName="Them" />
                                    </td>
                                </tr>
                            </table>
                </ItemTemplate>
            </asp:DataList>
</asp:Content>

