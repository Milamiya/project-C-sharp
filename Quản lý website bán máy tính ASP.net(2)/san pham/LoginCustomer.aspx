<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="LoginCustomer.aspx.cs" Inherits="Default2"%>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style>
    .table
    {
    	-moz-border-radius-topleft:10px;
    	-moz-border-radius-topright:10px;
    	-moz-border-radius-bottomleft:10px;
    	-moz-border-radius-bottomright:10px;
    	border: 1px solid gray;   
    	width:290px;
    	height:190px; 	
    	background-color:#ebf4fb;    	
    	}                
        .style1
        {
            height: 20px;
        }
        .a:hover
        {
        	color:Red;
        	}
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div><asp:Image ID="Image2" runat="server" ImageUrl="~/images/login_title.gif" 
            Height="40px" Width="194px" />
    </div>         
    <%--<div>--%>
    <table class="table" style="float:left;">        
        <tr>
            <td style="font-weight:bold;"
                colspan="2">&nbsp; &nbsp; <a style="text-decoration:underline">Khách hàng hiện tại</a></td>
        </tr>
        <tr>
            <td style="height:20px;"></td>
        </tr>
        <tr>
            <td style="height:10px;">Email:</td>
            <td style="height:10px;">
                <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
                                        </td>
        </tr>   
        
        <tr>
            <td style="height:10px;">Password:</td>
            <td style="height:10px;">
                <asp:TextBox ID="txtPass" runat="server" TextMode="Password"></asp:TextBox>
                                        </td>
        </tr> 
        <tr>
            <td style="height:10px;"></td>
        </tr>
        <tr>
            <td style="padding-left:90px" colspan="2">
                <asp:ImageButton ID="imbLogin" runat="server" 
                    ImageUrl="~/images/login_bt.gif" onclick="imbLogin_Click" />
            </td>
        </tr>
        <tr>
            <td style="text-align:center" colspan="2">
                <asp:Label ID="lbThongBao" runat="server" ForeColor="#CC0000"></asp:Label>
            </td>
        </tr>        
    </table>    
    <table class="table" style="width:450px; float:right;">
        <tr>
            <td>&nbsp &nbsp<b style="text-decoration:underline">CHƯA CÓ TÀI KHOẢN?</b></td>
        </tr>
        <tr>
            <td style="height:10px;"></td>
        </tr>
        <tr>
            <td>&nbsp;&nbsp;&nbsp;<a>Với 1 tài khoản tại website, quý khách có thể:</a><br />
                &nbsp;&nbsp;
                Lưu giữ thông tin thanh toán và đặt hàng<br />
                &nbsp;&nbsp;
                Kiểm tra tình trạng đơn hàng<br />
                &nbsp;&nbsp;
                Xem đơn hàng đã mua<br />
                &nbsp;&nbsp;
                Nhận những khuyến mãi đặc biệt dành cho khách hàng thân thiết<br />
                <br />
                &nbsp;
                <asp:LinkButton ID="LinkButton3" runat="server" Font-Bold="True" 
                    PostBackUrl="~/Registration.aspx" CssClass="a"
                    >&gt;&gt;Đăng ký thành 
                viên</asp:LinkButton>
            </td>
        </tr>
    </table>
    <div>
        <br />
        <%--<asp:GridView ID="GridView1" runat="server" CellPadding="4" ForeColor="#333333" 
            GridLines="None" Width="745px">
            <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
            <Columns>
                <asp:BoundField HeaderText="Mã sản phẩm" />
                <asp:BoundField HeaderText="Tên sản phẩm" />
                <asp:BoundField HeaderText="Số lượng" />
                <asp:BoundField HeaderText="Giá tiền" />
            </Columns>
            <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
            <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
            <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <EditRowStyle BackColor="#999999" />
            <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
        </asp:GridView>--%>
    </div>
</asp:Content>

