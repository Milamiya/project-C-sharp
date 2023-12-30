<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="ProductDetails.aspx.cs" Inherits="Default2"%>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">  
    <link href="Css/StyleSheet.css" rel="stylesheet" type="text/css" />   
    <style>
        .thongsosp
        {
        	width:750px;
        	height:450px;
        	border:1px solid gray;            
        	-moz-border-radius-topright:10px;
        	-moz-border-radius-bottomleft:10px;
        	-moz-border-radius-bottomright:10px;
        	float:left;
        	background-color:#eef3ef;
        	}
        .thongsosp td
        {
        	background-color:#FFFFFF;
        	padding-left:30px;        	
        	}                      
        
    </style> 
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">      
    <asp:ScriptManager ID="ScriptManager1" runat="server">
    </asp:ScriptManager>     
    <asp:DataList ID="DataList1" runat="server" DataKeyField="ProductID" 
        DataSourceID="SqlDataSource1" onitemcommand="DataList1_ItemCommand">
        <ItemTemplate>
        <table style="width:750px;">
            <tr>
                <td rowspan="5" width="300px">
                    <asp:Image ID="Image1" runat="server" ImageUrl='<%# Eval("ImageURL") %>' 
                        Width="100%" Height="100%" />
                </td>                        
                <td>
                    <asp:Label ID="lbtProductName" runat="server" 
                    Text='<%# Eval("ProductName") %>' ForeColor="#0033CC" Font-Bold="True" 
                    Font-Size="Large" Font-Underline="false" />                    
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lbGia" runat="server" Text="Giá:" Font-Bold="True"></asp:Label><asp:Label ID="lbPrice" runat="server" Text='<%# Eval("Price") %>' 
                        ForeColor="Red" />
                    VNĐ</td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label8" runat="server" Font-Bold="True" Text="Bảo hành:"></asp:Label> <asp:Label ID="WarrantyLabel" runat="server" 
                    Text='<%# Eval("Warranty") %>' />
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label9" runat="server" Font-Bold="True" Text="Trong kho:"></asp:Label> 
                    <asp:Label ID="lblKhoHang" runat="server" Text='<%# (Eval("Number").ToString()=="0")? "Hết hàng" : "Còn hàng" %>'  ></asp:Label>
                    </td>                                     
            </tr>
            <tr>
                 <td>
                    <asp:ImageButton ID="ImageButton1" runat="server" 
                    ImageUrl="~/Image/iconMuaHang.gif" ToolTip="Thêm vào giỏ hàng của bạn" CommandName="GioHang" />                     
                 </td>
            </tr>
        </table>
        <table style="width:200px;">
            <tr>
                <td class="rightspaceTitle" style="float:left; height:28px; text-align:center; padding-top:5px; color:White;">
                <b>THÔNG SỐ SẢN PHẨM</b></td>
            </tr>
        </table>
        <table class="thongsosp" style="margin-left:2px;margin-top:-2px;">                              
            
            <tr>
                <td style="color:#000066;">Bộ vi xử lý</td>
                <td style="padding-left:40px;">
                    <asp:Label ID="MicroprocessorLabel" runat="server" 
                    Text='<%# Eval("Microprocessor") %>' />    
                </td>
            </tr>
            <tr>
                <td style="color:#000066;">RAM</td>
                <td style="padding-left:40px;">
                    <asp:Label ID="MemoryLabel" runat="server" Text='<%# Eval("Memory") %>' />    
                </td>
            </tr>
            <tr>
                <td style="color:#000066;">Ổ cứng</td>
                <td style="padding-left:40px;">                    
                    <asp:Label ID="HardDriveLabel" runat="server" Text='<%# Eval("HardDrive") %>' />    
                </td>
            </tr>
            <tr>
                <td style="color:#000066;">Màn hình</td>
                <td style="padding-left:40px;">                    
                    <asp:Label ID="DisplayLabel" runat="server" Text='<%# Eval("Display") %>' />    
                </td>
            </tr>
            <tr>
                <td style="color:#000066;">Camera</td>
                <td style="padding-left:40px;">
                    <asp:Label ID="CameraLabel" runat="server" Text='<%# Eval("Camera") %>' />    
                </td>
            </tr>
            <tr>
                <td style="color:#000066;">Card đồ họa</td>
                <td style="padding-left:40px;">                    
                    <asp:Label ID="GraphicsCardLabel" runat="server" 
                    Text='<%# Eval("GraphicsCard") %>' />        
                </td>
            </tr>
            <tr>
                <td style="color:#000066;">Hệ điều hành</td>
                <td style="padding-left:40px;">
                    <asp:Label ID="ManufacturerLabel" runat="server" 
                    Text='<%# Eval("Manufacturer") %>' />
                </td>
            </tr>   
            <tr>
                <td style="color:#000066;">Pin</td>
                <td style="padding-left:40px;">
                    <asp:Label ID="Label2" runat="server" 
                    Text='<%# Eval("Pin") %>' />
                    &nbsp;Cell</td>
            </tr>    
            <tr>
                <td style="color:#000066;">Khối lượng</td>
                <td style="padding-left:40px;">
                    <asp:Label ID="Label3" runat="server" 
                    Text='<%# Eval("Volume") %>' />
                    &nbsp;Kg</td>
            </tr> 
            <tr>
                <td style="color:#000066;">Thương hiệu</td>
                <td style="padding-left:40px;">
                    <asp:Label ID="Label1" runat="server" 
                    Text='<%# Eval("Manufacturer") %>' />
                </td>
            </tr>    
            <tr>
                <td style="color:#000066;">Xuất sứ</td>
                <td style="padding-left:40px;">
                    <asp:Label ID="Label4" runat="server" 
                    Text='<%# Eval("Origin") %>' />
                </td>
            </tr>  
             <tr>
                <td style="color:#000066;">Bảo hành</td>
                <td style="padding-left:40px;">
                    <asp:Label ID="Label5" runat="server" 
                    Text='<%# Eval("Warranty") %>' />
                </td>
            </tr>  
            
        </table>
        </ItemTemplate>
    </asp:DataList>           
    <div style="height:10px;"></div> 
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
         <Triggers>
            <asp:AsyncPostBackTrigger ControlID="ddlTuKhoa" EventName="SelectedIndexChanged" />
         </Triggers>
    <ContentTemplate>
    <table style="width:auto;">                    
            <tr>
                <td style="float:left;height:10px;text-align:center;padding-top:5px;">
                <b>SẢN PHẨM CÙNG LOẠI </b>                                 
                &nbsp;</td> 
                <td style="padding-left:5px;">
                Tìm theo:<asp:DropDownList ID="ddlTuKhoa" runat="server" Width="100px" 
                        AutoPostBack="True" onselectedindexchanged="DDL1_SelectedIndexChanged">
                        <asp:ListItem Value="Microprocessor">Chip</asp:ListItem>
                        <asp:ListItem Value="Memory">Ram</asp:ListItem>
                        <asp:ListItem Value="HardDrive">Ổ cứng</asp:ListItem>
                        <asp:ListItem Value="Display">Màn hình</asp:ListItem>
                        <asp:ListItem Value="Pin">Pin</asp:ListItem>
                </asp:DropDownList>                
                </td>                               
            </tr>
    </table>
    <div style="height:10px;"></div>    
    <div>           
        <asp:DataList ID="dlSPLienQuan" runat="server"
             RepeatColumns="3">
            <ItemTemplate>
                <div class="border">
            <div style="padding:10px;width:90%">
           <%--Header--%>
                <div style="width:100%;height:40px; ">                    
                    <asp:LinkButton ID="lbtProductName" runat="server" Text='<%# Eval("ProductName") %>'
                        PostBackUrl='<%# "ProductDetails.aspx?ProductID="+ Eval("ProductID") %>' 
                        Font-Bold="True" Font-Size="Medium" 
                        Font-Underline="True" ForeColor="#0066FF"></asp:LinkButton>
                </div>
                <div style="width:100%; height:190px;">                                        
                    <img src='<%# Eval("ImageURL") %>' width="200px" />
                </div>
                <div>
                    <table style="table-layout:fixed">
                        <colgroup>
                            <col style="width: 130px; text-align: right;" />
                            <tr>
                                <td rowspan="2">
                                    <asp:Label ID="lbPrice" runat="server" ForeColor="Black" 
                                        Text='<%# Eval("Price") %>' />
                                    VNĐ</td>
                                <td>                                                                                                          
                                    <asp:LinkButton ID="LinkButton1" runat="server" CssClass="a"
                                        PostBackUrl='<%# "ProductDetails.aspx?ProductID=" + Eval("ProductID") %>'>Chi 
                                    tiết &gt;&gt;</asp:LinkButton>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:ImageButton ID="ImageButton2" runat="server" 
                                        ImageUrl="~/Image/iconMuaHang.gif" 
                                        ToolTip="Thêm vào giỏ hàng của bạn" CommandName="GioHang" />
                                </td>
                            </tr>
                        </colgroup>
                    </table>
                </div>            
            </div>
        </div>
            </ItemTemplate>
        </asp:DataList>          
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
        ConnectionString="<%$ ConnectionStrings:ConnectionString %>" 
        SelectCommand="SELECT * FROM [tbProduct] WHERE ([ProductID] = @ProductID)">
        <SelectParameters>
            <asp:QueryStringParameter Name="ProductID" QueryStringField="ProductID" 
                Type="String" />
        </SelectParameters>
    </asp:SqlDataSource>
    </div>  
    <div style="height:25px ; width:736px; padding-left:10px; margin-bottom:10px; padding-top:7px; border:solid 1px Gray;  background-image:none;">
        Đây là trang thứ: 
        <asp:Label ID="lbBanTin" runat="server" Text="1" ForeColor="#CC0000"></asp:Label>
        &nbsp;trên tổng số 
        <asp:Label ID="lbSobantintrongtrang" runat="server"
            ForeColor="#CC0000"></asp:Label>&nbsp;trang&nbsp;&nbsp;&nbsp;&nbsp; Tổng số bản tin 
        là: <asp:Label ID="lbTongsobantin" runat="server" Text="lbTongsobantin" 
            ForeColor="#CC0000"></asp:Label>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:LinkButton ID="lkbPreview" runat="server" Font-Underline="False" 
            onclick="lkbPreview_Click">&lt;&lt;Trước</asp:LinkButton>
        &nbsp;&nbsp;<asp:LinkButton ID="lkbNext" runat="server" Font-Underline="False" 
            onclick="lkbNext_Click">Sau&gt;&gt;</asp:LinkButton>
    </div>
    </ContentTemplate> 
    </asp:UpdatePanel>  
</asp:Content>