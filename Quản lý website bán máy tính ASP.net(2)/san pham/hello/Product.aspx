<%@ Page Language="C#" MasterPageFile="~/hello/Admin.master" AutoEventWireup="true" CodeFile="Product.aspx.cs" Inherits="hello_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .thongsosp
        {
        	width:794px;        	
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
    <%--<div>      
        <div style="margin-bottom:20px;margin-top:5px;">
            <br />
            <asp:Label ID="Label1" runat="server" Text=">>Thông tin sản phẩm" 
            Font-Bold="True" Font-Size="Large" ForeColor="#CC0000"></asp:Label>
        </div>  
        <table class="thongsosp">
            <tr>
                <td>
                     <asp:DataList ID="DataList1" runat="server" DataKeyField="ProductID" 
                 onitemcommand="DataList1_ItemCommand" 
                 RepeatColumns="2">    
        <ItemTemplate>          
            <asp:Label ID="ProductNameLabel" runat="server" 
                Text='<%# Eval("ProductName") %>' Font-Bold="True" Font-Size="Medium" 
                ForeColor="#003399"></asp:Label>
            <br />
            <asp:Image ID="Image1" runat="server" Height="111px" 
                ImageUrl='<%#"~/"+ Eval("ImageURL") %>' Width="149px" />
            <br />
        <asp:Label ID="Label1" runat="server" Text='<%# Eval("Promotion") %>'></asp:Label>
            <br />
        Giá:
        <asp:Label ID="PriceLabel" runat="server" Text='<%# Eval("Price") %>' />
        
            &nbsp;VNĐ<br />
            Số lượng:
            <asp:Label ID="Label2" runat="server" Text='<%# Eval("Number") %>'></asp:Label>
            <br />
        
        Thương hiệu:
        <asp:Label ID="ManufacturerLabel" runat="server" 
            Text='<%# Eval("Manufacturer") %>' />
            <br />
            Bộ vi sử lý:
            <asp:Label ID="Label3" runat="server" Text='<%# Eval("Microprocessor") %>'></asp:Label>
            <br />
            RAM:
            <asp:Label ID="Label4" runat="server" Text='<%# Eval("Memory") %>'></asp:Label>
            <br />
            Ổ cứng:
            <asp:Label ID="Label5" runat="server" Text='<%# Eval("HardDrive") %>'></asp:Label>
            <br />
            Hệ điều hành:
            <asp:Label ID="Label6" runat="server" Text='<%# Eval("OS") %>'></asp:Label>
            <br />
            Màn hình:
            <asp:Label ID="Label7" runat="server" Text='<%# Eval("Display") %>'></asp:Label>
            <br />
            Camera:
            <asp:Label ID="Label8" runat="server" Text='<%# Eval("Camera") %>'></asp:Label>
            <br />
            Card đồ họa:
            <asp:Label ID="Label9" runat="server" Text='<%# Eval("GraphicsCard") %>'></asp:Label>
            <br />
            Pin:&nbsp;<asp:Label ID="Label10" runat="server" Text='<%# Eval("Pin") %>'></asp:Label>
            &nbsp;Cell<br />
            Khối lượng:
            <asp:Label ID="Label11" runat="server" Text='<%# Eval("Volume") %>'></asp:Label>
            &nbsp;Kg<br />
            Xuất sứ:
            <asp:Label ID="Label12" runat="server" Text='<%# Eval("Origin") %>'></asp:Label>
        <br />
        Bảo hành:
        <asp:Label ID="WarrantyLabel" runat="server" Text='<%# Eval("Warranty") %>' />
            <br />
        <asp:LinkButton ID="LinkButton1" runat="server" CommandName="Sua">Sửa</asp:LinkButton>
            &nbsp;
        <asp:LinkButton ID="LinkButton2" runat="server" CommandName="Xoa">Xóa</asp:LinkButton>
        <br />
    
        </ItemTemplate>        
        <EditItemTemplate>        
             Mã sp:
            <asp:Label ID="ProductIDLabel" runat="server" Text='<%# Eval("ProductID") %>'></asp:Label>
            <br />
            Tên sp:
            <asp:TextBox ID="txtProductName" runat="server" 
                 Text='<%# Eval("ProductName") %>' Width="200px"></asp:TextBox>
            <br />
            ImageURL:<asp:FileUpload ID="FileUpload1" runat="server" 
                  />
            <br />
            Khuyến mãi:
            <asp:TextBox ID="txtPromotion" runat="server" Text='<%# Eval("Promotion") %>'></asp:TextBox>
            <br />
            Giá:
            <asp:TextBox ID="txtPrice" runat="server" Text='<%# Eval("Price") %>'></asp:TextBox>
        
            <br />
            Số lượng:
            <asp:TextBox ID="txtNumber" runat="server" Text='<%# Eval("Number") %>'></asp:TextBox>
            <br />
        
            Thương hiệu:
            <asp:TextBox ID="txtManufacturer" runat="server" Height="20px" 
                Text='<%# Eval("Manufacturer") %>'></asp:TextBox>
            <br />
            Bộ vi sử lý:
            <asp:TextBox ID="txtMicroprosesor" runat="server" 
                Text='<%# Eval("Microprocessor") %>'></asp:TextBox>
            <br />
            RAM:
            <asp:TextBox ID="txtRAM" runat="server" Text='<%# Eval("Memory") %>'></asp:TextBox>
            <br />
            Ổ cứng:
            <asp:TextBox ID="txtHardDrive" runat="server" Text='<%# Eval("HardDrive") %>'></asp:TextBox>
            <br />
            Hệ điều hành:
            <asp:TextBox ID="txtOS" runat="server" Text='<%# Eval("OS") %>'></asp:TextBox>
            <br />
            Màn hình:
            <asp:TextBox ID="txtDisplay" runat="server" Text='<%# Eval("Display") %>'></asp:TextBox>
            <br />
            Camera:
            <asp:TextBox ID="txtCamera" runat="server" Text='<%# Eval("Camera") %>'></asp:TextBox>
            <br />
            Card đồ họa:
            <asp:TextBox ID="txtGraphicDrive" runat="server" 
                Text='<%# Eval("GraphicsCard") %>'></asp:TextBox>
            <br />
            Pin:&nbsp;<asp:TextBox ID="txtPin" runat="server" Text='<%# Eval("Pin") %>'></asp:TextBox>
            <br />
            Khối lượng:
            <asp:TextBox ID="txtVolume" runat="server" Text='<%# Eval("Volume") %>'></asp:TextBox>
            <br />
            Xuất sứ:
            <asp:TextBox ID="txtOrigin" runat="server" Text='<%# Eval("Origin") %>'></asp:TextBox>
            <br />
            Bảo hành:
                <asp:TextBox ID="txtWarranty" runat="server" Text='<%# Eval("Warranty") %>'></asp:TextBox>
            <br />
            <asp:LinkButton ID="LinkButton3" runat="server" CommandName="Luu">Lưu</asp:LinkButton>
                &nbsp;
            <asp:LinkButton ID="LinkButton4" runat="server" CommandName="Huy">Hủy</asp:LinkButton>
            <br />
            </EditItemTemplate>         
            </asp:DataList>   
                </td>
            </tr>
        </table>
      <div style="height:25px; width:782px; padding-left:10px; margin-bottom:10px; padding-top:7px; border:solid 1px Gray;  background-image:none;">
        Đây là trang thứ: 
        <asp:Label ID="lbBanTin" runat="server" Text="1" ForeColor="#CC0000"></asp:Label>
        &nbsp;trên tổng số 
        <asp:Label ID="lbSobantintrongtrang" runat="server"
            ForeColor="#CC0000"></asp:Label>&nbsp;trang&nbsp;&nbsp;&nbsp;&nbsp; Tổng số bản tin 
        là: <asp:Label ID="lbTongsobantin" runat="server" Text="lbTongsobantin" 
            ForeColor="#CC0000"></asp:Label> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:LinkButton ID="lkbPreview" runat="server" Font-Underline="False" 
            onclick="lkbPreview_Click">&lt;&lt;Trước</asp:LinkButton>
        &nbsp;&nbsp;<asp:LinkButton ID="lkbNext" runat="server" Font-Underline="False" 
            onclick="lkbNext_Click">Sau&gt;&gt;</asp:LinkButton>
     </div>
    </div>        
    
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
    ConnectionString="<%$ ConnectionStrings:ConnectionString %>" 
    SelectCommand="SELECT * FROM [tbProduct] ORDER BY Price" 
        UpdateCommand="Update tbProduct set ProductName=@ProductName,ImageURL=@ImageURL,Promotion=@Promotion,Price=@Price,Number=@Number,Manufacturer=@Manufacturer,Microprocessor=@Microprocessor,Memory=@Memory,HardDrive=@HardDrive,OS=@OS, Display=@Display,Camera=@Camera,GraphicsCard=@GraphicsCard,Pin=@Pin,Volume=@Volume,Origin=@Origin, Warranty=@Warranty where ProductID=@ProductID"      
        DeleteCommand="DELETE FROM tbProduct WHERE ProductID=@ProductID">        
    <DeleteParameters>
        <asp:Parameter Name="ProductID" />
    </DeleteParameters>
    <UpdateParameters>
        <asp:Parameter Name="ProductName" />
        <asp:Parameter Name="ImageURL" />
        <asp:Parameter Name="Promotion" />
        <asp:Parameter Name="Price" />
        <asp:Parameter Name="Number" />        
        <asp:Parameter Name="Manufacturer" />
        <asp:Parameter Name="Microprocessor" />
        <asp:Parameter Name="Memory" />
        <asp:Parameter Name="HardDrive" />
        <asp:Parameter Name="OS" />
        <asp:Parameter Name="Display" />
        <asp:Parameter Name="Camera" />
        <asp:Parameter Name="GraphicsCard" />
        <asp:Parameter Name="Pin" />
        <asp:Parameter Name="Volume" />
        <asp:Parameter Name="Origin" />
        <asp:Parameter Name="Warranty" />
        <asp:Parameter Name="ProductID" />
    </UpdateParameters>
</asp:SqlDataSource>--%>
<br />
    <asp:GridView ID="GridView1" runat="server" AllowPaging="True" Width="100%"
        AllowSorting="True" AutoGenerateColumns="False" DataKeyNames="ProductID" 
        DataSourceID="SqlDataSource1" Height="351px">      
        <Columns>               
            <asp:TemplateField>
            <HeaderTemplate>
                <asp:CheckBox ID="cbTatCa" OnCheckedChanged="Chon"  AutoPostBack="true" runat="server" />
            </HeaderTemplate>
            <ItemTemplate>
                <asp:CheckBox ID="cbThanhPhan" runat="server">
                </asp:CheckBox>
            </ItemTemplate>
            </asp:TemplateField>
            <asp:BoundField DataField="ProductID" HeaderText="ProductID" 
                InsertVisible="False" ReadOnly="True" SortExpression="ProductID" />
            <asp:BoundField DataField="ProductName" HeaderText="ProductName" 
                SortExpression="ProductName" />
            <asp:BoundField DataField="Price" HeaderText="Price" SortExpression="Price" />
            <asp:BoundField DataField="ImportDate" HeaderText="ImportDate" 
                SortExpression="ImportDate" DataFormatString="{0:dd/MM/yyyy}" />
            <asp:HyperLinkField DataNavigateUrlFields="ProductID" 
                DataNavigateUrlFormatString="ProductEdit.aspx?ProductID={0}" Text="Sửa" />
        </Columns>
    </asp:GridView>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
        ConnectionString="<%$ ConnectionStrings:ConnectionString %>"         
        SelectCommand="SELECT [ProductID], [ProductName], [Price], [ImportDate] FROM [tbProduct]" 
        DeleteCommand="DELETE FROM tbProduct WHERE (ProductID = @ProductID)">         
        <DeleteParameters>
            <asp:Parameter Name="ProductID" />
        </DeleteParameters>
    </asp:SqlDataSource>
    <div>
        <%--<asp:Button ID="btSua" runat="server" Text="Sửa" OnClick="btSua_Click" />--%>
        <asp:Button ID="btXoa" runat="server" Text="Xóa" OnClientClick="if(!confirm('Bạn có chắc chắn muốn xóa không?')) return false;" onclick="btXoa_Click" />
    </div>
</asp:Content>

