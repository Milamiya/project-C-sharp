<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="guihangthanhcong.aspx.cs" Inherits="_Default" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:HyperLink ID="HyperLink15" runat="server" NavigateUrl="~/Default.aspx" ForeColor="Blue">&gt;&gt;Trang 
    chủ</asp:HyperLink>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <br />
    <asp:HyperLink ID="HyperLink16" runat="server" NavigateUrl="~/giohang.aspx" ForeColor="Blue">&gt;&gt;Giỏ 
    hàng</asp:HyperLink>
    <br />
    <br />
    <table style="width: 100%">
        <tr>
            <td align="center">
                <asp:Label ID="Label5" runat="server" Font-Bold="True" Font-Size="Large" 
                    ForeColor="black" 
                    Text="Quý khách đã chọn mua sản phẩm của công ty thành công!&lt;br&gt; Chúng tôi sẽ gửi hàng theo yêu cầu của quý khách trong thời gian sớm nhất !"></asp:Label>
            </td>
        </tr>
    </table>
    <br />
</asp:Content>

