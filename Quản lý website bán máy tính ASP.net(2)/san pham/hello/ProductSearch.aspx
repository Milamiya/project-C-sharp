<%@ Page Language="C#" MasterPageFile="~/hello/Admin.master" AutoEventWireup="true" CodeFile="ProductSearch.aspx.cs" Inherits="hello_Default2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style>
        .thongsosp
        {
        	width:794px;
        	height:auto;
        	border-top:1px solid #e99765;                    	
        	border-right:1px solid #e99765;                    	
        	border-left:1px solid #e99765; 
        	border-bottom:1px solid #e99765;                    	
        	float:left;        	
        	background-color:White;
        	}                 
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:ScriptManager ID="ScriptManager1" runat="server">
    </asp:ScriptManager>    
    <div style="margin-bottom:20px;margin-top:5px;">
        <br />
        <asp:Label ID="Label1" runat="server" Text=">>Tìm kiếm thông tin" 
        Font-Bold="True" Font-Size="Large" ForeColor="#CC0000"></asp:Label>
    </div>
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <Triggers>
            <asp:AsyncPostBackTrigger ControlID="lkbPreview" EventName="Click" />
            <asp:AsyncPostBackTrigger ControlID="lkbNext" EventName="Click" />
        </Triggers>
        <ContentTemplate>
    <table class="thongsosp">   
        <tr>
            <td style="height:6px;"></td>
        </tr>     
        <tr>
            <td>&nbsp;&nbsp; Hãng sản xuất:</td>
            <td>
                <asp:DropDownList ID="ddlNSX" runat="server" Width="100px" Height="25px"
                    DataSourceID="SqlDataSource1" DataTextField="Manufacturer" 
                    DataValueField="Manufacturer" 
                    >
                </asp:DropDownList>
                <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
                    ConnectionString="<%$ ConnectionStrings:ConnectionString %>" 
                    SelectCommand="SELECT DISTINCT Manufacturer FROM tbProduct">
                </asp:SqlDataSource>
            </td>
        </tr>
        <tr>
            <td style="height:6px;"></td>
        </tr>    
        <tr>
            <td>&nbsp;&nbsp; Trường cần tìm:</td>
            <td>
                <asp:DropDownList ID="ddlTruong" runat="server" Width="180px" Height="25px">
                    <asp:ListItem>--------Chọn-------</asp:ListItem>
                    <asp:ListItem Value="Microprocessor">Bộ vi sử lý</asp:ListItem>
                    <asp:ListItem Value="Memory">Ram</asp:ListItem>
                    <asp:ListItem Value="HardDrive">Ổ cứng</asp:ListItem>
                    <asp:ListItem Value="Price">Giá</asp:ListItem>
                    <asp:ListItem Value="Display">Màn hình</asp:ListItem>
                    <asp:ListItem Value="OS">Hệ điều hành</asp:ListItem>
                    <asp:ListItem Value="GraphicsCard">Card đồ họa</asp:ListItem>
                    <asp:ListItem>Camera</asp:ListItem>
                    <asp:ListItem>Pin</asp:ListItem>
                    <asp:ListItem Value="Volume">Khối lượng</asp:ListItem>
                    <asp:ListItem Value="Warranty">Bảo hành</asp:ListItem>
                    <asp:ListItem Value="Origin">Xuất sứ</asp:ListItem>
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td style="height:6px;"></td>
        </tr>    
        <tr>
            <td>&nbsp;&nbsp; Thông số:</td>
            <td>
                <asp:TextBox ID="txtThongSo" runat="server" Width="300px" Height="25px"></asp:TextBox>&nbsp;&nbsp;&nbsp;&nbsp;<asp:Button ID="btTimKiem" runat="server" Text="Tìm" Width="54px" 
                    onclick="btTimKiem_Click" />
            </td>
        </tr>
        <tr>
            <td style="height:5px;"></td>
        </tr>
        <tr>
            <td colspan="2">
                &nbsp;&nbsp;&nbsp;
                <asp:Label ID="lbThongBao" runat="server" Text="Không tìm thấy kết quả nào!" 
                    ForeColor="#CC0000"></asp:Label>
            </td>
        </tr>
        <tr>
            <td colspan="2" style="padding-left:3px;">                                                                                
                <asp:DataList ID="ddlThongSoSP" runat="server" DataKeyField="ProductID" 
                     RepeatColumns="2">
                    <ItemTemplate> 
                        <div style="text-align:left;">
                        <asp:Label ID="Label2" runat="server" Font-Bold="True" Font-Size="Medium" 
                            ForeColor="#003399" Text='<%# Eval("ProductName") %>'></asp:Label>
                        </div>                                           
                        <div>
                        <asp:Image ID="Image1" runat="server" Height="100px" 
                            ImageUrl='<%# "~/" + Eval("ImageURL") %>' Width="127px" />
                        </div>
                        <div>
                        <asp:Label ID="PromotionLabel" runat="server" Text='<%# Eval("Promotion") %>' />
                        </div>                        
                        <div>
                        Giá:
                        <asp:Label ID="PriceLabel" runat="server" Text='<%# Eval("Price") %>' />
                        </div>
                        Số lượng:
                        <asp:Label ID="NumberLabel" runat="server" Text='<%# Eval("Number") %>' />
                        <br />
                        Hãng sản xuất:
                        <asp:Label ID="ManufacturerLabel" runat="server" 
                            Text='<%# Eval("Manufacturer") %>' />
                        <br />
                        Bộ vi sử lý:
                        <asp:Label ID="MicroprocessorLabel" runat="server" 
                            Text='<%# Eval("Microprocessor") %>' />
                        <br />
                        Ram:
                        <asp:Label ID="MemoryLabel" runat="server" Text='<%# Eval("Memory") %>' />
                        <br />
                        Ổ cứng:
                        <asp:Label ID="HardDriveLabel" runat="server" Text='<%# Eval("HardDrive") %>' />
                        <br />
                        Hệ điều hành:
                        <asp:Label ID="OSLabel" runat="server" Text='<%# Eval("OS") %>' />
                        <br />
                        Màn hình:
                        <asp:Label ID="DisplayLabel" runat="server" Text='<%# Eval("Display") %>' />
                        <br />
                        Camera:
                        <asp:Label ID="CameraLabel" runat="server" Text='<%# Eval("Camera") %>' />
                        <br />
                        Card đồ họa:
                        <asp:Label ID="GraphicsCardLabel" runat="server" 
                            Text='<%# Eval("GraphicsCard") %>' />
                        <br />
                        Pin:
                        <asp:Label ID="PinLabel" runat="server" Text='<%# Eval("Pin") %>' />
                        &nbsp;Cell<br />
                        Khối lượng:
                        <asp:Label ID="VolumeLabel" runat="server" Text='<%# Eval("Volume") %>' />
                        &nbsp;Kg<br />
                        Xuất sứ:
                        <asp:Label ID="OriginLabel" runat="server" Text='<%# Eval("Origin") %>' />
                        <br />
                        Bảo hành:
                        <asp:Label ID="WarrantyLabel" runat="server" Text='<%# Eval("Warranty") %>' />
                        &nbsp;tháng<br />
                        <br />                                                                 
                    </ItemTemplate>
                </asp:DataList>
                <asp:SqlDataSource ID="SqlDataSource2" runat="server" 
                    ConnectionString="<%$ ConnectionStrings:ConnectionString %>" 
                    SelectCommand="SELECT * FROM [tbProduct]"></asp:SqlDataSource>                                                                                
            </td>
        </tr>         
    </table>    
    <div style="height:25px ; width:736px; padding-left:10px; margin-bottom:10px; padding-top:7px; border:solid 1px Gray;  background-image:none;">
        Đây là trang thứ: 
        <asp:Label ID="lbBanTin" runat="server" Text="1" ForeColor="#CC0000"></asp:Label>
        &nbsp;trên tổng số 
        <asp:Label ID="lbSobantintrongtrang" runat="server"
            ForeColor="#CC0000"></asp:Label>&nbsp;trang&nbsp;&nbsp;&nbsp;&nbsp; Tổng số bản tin 
        là: <asp:Label ID="lbTongsobantin" runat="server" Text="lbTongsobantin" 
            ForeColor="#CC0000"></asp:Label>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:LinkButton ID="lkbPreview" runat="server" Font-Underline="False" 
            onclick="lkbPreview_Click">&lt;&lt;Trước</asp:LinkButton>
        &nbsp;&nbsp;<asp:LinkButton ID="lkbNext" runat="server" Font-Underline="False" 
            onclick="lkbNext_Click">Sau&gt;&gt;</asp:LinkButton>
    </div>
    </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>

