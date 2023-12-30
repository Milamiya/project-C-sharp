<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Payment.aspx.cs" Inherits="Default2" %>

<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="asp" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style>
        .textbox
        {
        	width:220px;
        	height:22px;
        	border:1px solid #aacfe4;
        	}
        .thongsosp
        {
        	-moz-border-radius-topleft:10px;
    	    -moz-border-radius-topright:10px;
    	    -moz-border-radius-bottomleft:10px;
    	    -moz-border-radius-bottomright:10px;
        	width:100%;
        	height:500px;
        	border:1px solid gray;                 	
        	background-color:#ebf4fb; 
        	} 
        .thongsohoadon
        {
        	-moz-border-radius-topleft:10px;
    	    -moz-border-radius-topright:10px;
    	    -moz-border-radius-bottomleft:10px;
    	    -moz-border-radius-bottomright:10px;
        	width:100%;
        	height:770px;
        	border:1px solid gray;                 	
        	background-color:#ebf4fb;
        }
        .label
        {
        	font-weight:bold;    
        	}   
        .td
        {
        	padding-left:10px;
        	} 
        .style2
        {
            height: 57px;
        }
        .style3
        {
            height: 28px;
        }
        .style4
        {
            padding-left: 10px;
            height: 90px;
        }
        .style5
        {
            width: 408px;
        }
        .style6
        {
            font-style: normal;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">       
    <div style="padding-top:10px;">
    <asp:Label ID="Label6" runat="server" Text="THANH TOÁN" Font-Bold="True" 
            ForeColor="#993366"></asp:Label>
        <br />
    </div>
    <asp:Panel ID="Panel1" runat="server">
        <table class="thongsosp">
        <tr>
            <td colspan="4" class="style4">
                <asp:Label ID="Label4" runat="server" Font-Bold="True" 
                    Text="Địa chỉ người mua" Font-Size="Large"></asp:Label>
                <br />
                <asp:Label ID="Label5" runat="server" Font-Size="Small" ForeColor="Gray" 
                    Text="Vui lòng nhập đủ thông tin sau:"></asp:Label>
                <br />                
                <div style="background-color:#aacfe4;margin-top:3px; background-repeat:repeat-x; width:95%; height: 1px;">
                
                </div>            
            </td>
        </tr>
        <tr>
            <td style="padding-left:20px;">                
                <asp:Label ID="Label8" runat="server" Text="Tên KH:" CssClass="label"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtTenKH" runat="server" CssClass="textbox"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                    ErrorMessage="RequiredFieldValidator" ControlToValidate="txtTenKH">(*)</asp:RequiredFieldValidator>
            </td>
            <td style="padding-left:20px;">
                <asp:Label ID="Label1" runat="server" Text="Email:" CssClass="label"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtEmail" runat="server" CssClass="textbox"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                    ErrorMessage="RequiredFieldValidator" ControlToValidate="txtEmail">(*)</asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td style="padding-left:20px;">
                <asp:Label ID="Label9" runat="server" Text="Địa chỉ:" CssClass="label"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtDiaChi" runat="server" CssClass="textbox"></asp:TextBox>
            </td>
            <td style="padding-left:20px;">
                <asp:Label ID="Label2" runat="server" Text="SĐT:" CssClass="label"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtSDT" runat="server" CssClass="textbox"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="padding-left:20px;" class="style2">
                <asp:Label ID="Label10" runat="server" Text="Di động:" CssClass="label"></asp:Label>
            </td>
            <td class="style2">
                <asp:TextBox ID="txtDĐ" runat="server" CssClass="textbox"></asp:TextBox>
            </td>
            <td style="padding-left:20px;" class="style2">
                <asp:Label ID="Label3" runat="server" Text="Ngày giao:" CssClass="label" 
                    Font-Size="Medium"></asp:Label>
            </td>
            <td class="style2">
                <asp:DropDownList ID="ddlNgay" runat="server" Height="22px" Width="70px" 
                    AutoPostBack="True">
                    <asp:ListItem>MM</asp:ListItem>
                    <asp:ListItem>1</asp:ListItem>
                    <asp:ListItem>2</asp:ListItem>
                    <asp:ListItem>3</asp:ListItem>
                </asp:DropDownList>
                &nbsp;<asp:DropDownList ID="ddlThang" runat="server" Height="22px" Width="60px">
                                </asp:DropDownList>
                &nbsp;<asp:DropDownList ID="ddlNam" runat="server" Height="22px" Width="70px">
                </asp:DropDownList>
            </td>
        </tr> 
        <tr>
            <td style="padding-left:20px;">
                <asp:Label ID="Label7" runat="server" Text="Tên sản phẩm:" CssClass="label"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="TextBox1" runat="server" CssClass="textbox"></asp:TextBox>
            </td>
            <td style="padding-left:20px;">
                <asp:Label ID="Label12" runat="server" Text="Giá:" CssClass="label"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="TextBox2" runat="server" CssClass="textbox"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="padding-left:20px;">
                <asp:Label ID="Label13" runat="server" Text="Số lượng:" CssClass="label"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="TextBox5" runat="server" CssClass="textbox"></asp:TextBox>
            </td>
            <td style="padding-left:20px;">
                <asp:Label ID="Label14" runat="server" Text="Tổng tiền:" CssClass="label"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="TextBox6" runat="server" CssClass="textbox"></asp:TextBox>
            </td>
        </tr>                     
        <tr>
            <td colspan="4" class="td">
                <asp:Label ID="Label11" runat="server" Font-Bold="True" 
                    Text="Hình thức thanh toán" Font-Size="Large"></asp:Label>                
                <br />                
                <div style="background-color:#aacfe4;margin-top:3px; background-repeat:repeat-x; width:95%; height: 1px;">
                
                </div>            
            </td>
        </tr>
        <tr>
            <td colspan="4"> 
            <div style="padding-left:10px;">
               <asp:Image ID="Image1" runat="server" ImageUrl="~/images/nganluong.gif" />                                               
            </div>               
            </td>
        </tr>
    </table>
    <div style="height:20px;"></div>
    <table style="float:right; padding-right:30px;">
        <tr>
            <td>
                <asp:Button ID="Button1" runat="server" Text="Quay lại" />
            </td>
            <td>
                <asp:Button ID="btTiepTuc" runat="server" Text="Tiếp tục" 
                    onclick="btTiepTuc_Click" />
            </td>
        </tr>
    </table>    
    </asp:Panel>
    <asp:Panel ID="Panel2" runat="server" Width="100%">
        <b>Xem những thông tin bên dưới, đồng ý hãy nhấn "Đặt mua hàng"</b>
        <div class="thongsohoadon" style="background-color:White; padding-top:20px;">                          
            <table>
                <tr>
                    <td style="padding-left:55px;">
                        <asp:Image ID="Image3" runat="server" ImageUrl="~/Image/logo3.jpg" />
                    </td>
                    <td><b>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; CÔNG TY TRÁCH NHIỆM HỮU HẠN 3T-COMPUTER</b>
                    <br />
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Địa chỉ: Hà Trì- Hà Cầu- Hà Nội<br />
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Điện thoại: 04 33553355 - Fax: 04 33554862<br />
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Email: truongnt90@gmail.com<br />
                    </td>
                </tr>
            </table>   
            <div style="text-align:center;padding-top:30px; margin-bottom:20px; ">
                <asp:Label ID="Label27" runat="server" Text="CHI TIẾT ĐƠN HÀNG" 
                            Font-Bold="True" Font-Size="Large" ForeColor="#000099"></asp:Label>
            </div>               
            <table style="width:640px; height:200px;margin-left:auto; margin-right:auto;">
                
                <tr>
                    <td style="width:400px;">
                        <asp:Label ID="Label20" runat="server" Text="Họ tên khách hàng:" 
                            Font-Bold="True" Font-Italic="False"></asp:Label></td>
                    <td style="width:240px;">
                        <asp:Label ID="lbTenKH" runat="server"></asp:Label></td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label21" runat="server" Text="Địa chỉ" Font-Bold="True"></asp:Label></td>
                    <td>
                        <asp:Label ID="lbDiaChi" runat="server"></asp:Label></td>
                </tr>
                <tr>
                    <td class="style3">
                        <asp:Label ID="Label22" runat="server" Text="Email:" Font-Bold="True"></asp:Label></td>
                    <td class="style3">
                        <asp:Label ID="lbEmail" runat="server" ></asp:Label></td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label23" runat="server" Text="Số điện thoại:" Font-Bold="True"></asp:Label></td>
                    <td>
                        <asp:Label ID="lbSDT" runat="server"></asp:Label></td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label24" runat="server" Text="Di động:" Font-Bold="True"></asp:Label></td>
                    <td>
                        <asp:Label ID="lbDĐ" runat="server"></asp:Label></td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label25" runat="server" Font-Bold="true" Text="Ngày giao hàng:"></asp:Label></td>
                    <td>
                        <asp:Label ID="lbNgaygiao" runat="server"></asp:Label></td>
                </tr>
            </table>            
            <div style="padding-left:60px;">
                <asp:Label ID="Label26" runat="server" Font-Bold="true" ForeColor="Blue" Text="Sản phẩm đặt mua"></asp:Label>
            </div>
            <div style="padding-left:58px;margin-left:auto; margin-right:auto;">
            <asp:GridView 
            ID="gvThanhToan" runat="server" AutoGenerateColumns="False" 
            DataKeyNames="ProductID"  Width="640px" CellPadding="4" 
            ForeColor="#333333" 
            >
            <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
            <Columns>
                <asp:BoundField DataField="ProductID" HeaderText="Mã sản phẩm" />
                <asp:BoundField DataField="ProductName" HeaderText="Tên sản phẩm" />
                <asp:BoundField DataField="Price" HeaderText="Giá tiền" />                 
                <asp:TemplateField HeaderText="Số lượng">
                    <ItemTemplate>
                        <asp:Label ID="Label28" runat="server" Text='<%# Bind("Number") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:BoundField DataField="Total" HeaderText="Tổng tiền" />                
            </Columns>            
        </asp:GridView>            
            </div>            
            <div style="padding-left:58px;margin-top:6px;margin-left:auto; margin-right:auto;">
                <asp:Label ID="Label15" runat="server" Font-Italic="true" Text="Tổng tiền:  ................................................................."></asp:Label>
            </div> 
            <div style="padding-left:58px;margin-top:3px;margin-left:auto; margin-right:auto;">
                <asp:Label ID="Label17" runat="server" Font-Italic="true" Text="Thuế VAT(10%): ...................................................."></asp:Label>
            </div>
            <div style="padding-left:58px;margin-top:6px;margin-left:auto; margin-right:auto;">
                <asp:Label ID="Label18" runat="server" Font-Italic="true" Text="Tổng tiền thanh toán:  .............................................................................................."></asp:Label>
            </div>
            <div style="padding-left:58px;margin-top:3px;margin-left:auto; margin-right:auto;">
                <asp:Label ID="Label16" runat="server" Font-Italic="true" Text="Số tiền viết bằng chữ:  .............................................................................................."></asp:Label>
            </div> 
            
            <table style="width:640px;margin-top:30px; margin-left:auto;margin-right:auto;padding-left:58px;">
                <tr>
                    <td class="style5" style="font-style: italic"><span class="style6"><b>&nbsp;Người mua 
                        hàng</b></span><br />
                        (Ký, ghi rõ họ tên)</td>
                    <td style="font-style: italic"><span class="style6"><b>&nbsp;Người bán hàng</b></span><br />
                        (Ký, ghi rõ họ tên)</td>                    
                </tr>
            </table>
        </div>
        <div>
        <div style="float:right;margin-top:20px; padding-right:30px;">
            <asp:Button ID="btInHoaDon" runat="server" Text="In hóa đơn" 
                onclick="btInHoaDon_Click" />
            <asp:Button ID="btDatMuaHang" runat="server" Text="Đặt mua hàng"
                onclick="btDatMuaHang_Click" />
        </div>
        
        </div>        
    </asp:Panel> 
    <%--<asp:Panel ID="Panel4" runat="server">    
    <asp:Table ID="Table1" runat="server" Width="100%" >    
        <asp:TableRow ID="Tabelrow1" runat="server"> 
            <asp:TableCell Text="3T-Computer">
            </asp:TableCell>
            <asp:TableCell Text="CÔNG TY TRÁCH NHIỆM HỮU HẠN 3T-COMPUTER" Font-Bold="true" Font-Size="Medium" >            
            </asp:TableCell>                                               
        </asp:TableRow>
        
        <asp:TableRow ID="Tablerow2" runat="server"> 
            <asp:TableCell Text="Địa chỉ: Hà Trì- Hà Cầu- Hà Nội" >
            </asp:TableCell> 
        </asp:TableRow>
        
        <asp:TableRow ID="Tablerow3" runat="server">
            <asp:TableCell Text="Điện thoại: 04 33553355 - Fax: 04 33554862" >
            </asp:TableCell>
        </asp:TableRow>
        
        <asp:TableRow ID="Tablerow4" runat="server">
            <asp:TableCell Text="Email: truongnt90@gmail.com">            
            </asp:TableCell>
        </asp:TableRow>
    </asp:Table>
    </asp:Panel>--%>
    <asp:Panel ID="Panel3" runat="server">
        <div style="text-align:center;border:1px solid gray;background-color:#ebf4fb; height: 72px;">
            <b>Đặt mua thành công</b>!<br />
            <i>Cảm ơn khách hàng đã mua hàng tại 3T-Computer </i>
            <br />
            <i>Chúng tôi sẽ gửi thông 
            tin chi tiết qua mail của quý khách </i></div>       
    </asp:Panel>   
</asp:Content>

