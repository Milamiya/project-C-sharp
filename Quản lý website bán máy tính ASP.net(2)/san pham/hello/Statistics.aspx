<%@ Page Language="C#" MasterPageFile="~/hello/Admin.master" AutoEventWireup="true" CodeFile="Statistics.aspx.cs" Inherits="hello_Default3" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">  
    <style>
        .thongsosp
        {
        	width:792px;
        	height:auto;
        	border-top:1px solid #e99765;                    	
        	border-right:1px solid #e99765;                    	
        	border-left:1px solid #e99765; 
        	border-bottom:1px solid #e99765;                    	
        	float:left;        	
        	background-color:White;
        	}              
        .textbox
        {
        	width:180px;
        	height:25px;
        	}      
    </style>    
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">  
    <asp:ScriptManager ID="ScriptManager1" runat="server">
    </asp:ScriptManager>
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <Triggers>
            <asp:AsyncPostBackTrigger ControlID="DropDownList1" EventName="SelectedIndexChanged" />
        </Triggers>
    <ContentTemplate>
    <div style="margin-bottom:20px;margin-top:5px;">
        <br />
        <asp:Label ID="Label1" runat="server" Text=">>Sản phẩm bán chạy" 
        Font-Bold="True" Font-Size="Large" ForeColor="#CC0000"></asp:Label>
    </div>   
    <div class="thongsosp">
    <div style="height:5px;"></div>
    <div style="padding-left:10px;">        
        <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" 
            DataSourceID="SqlDataSource2" DataTextField="Manufacturer" 
            DataValueField="Manufacturer" Height="25px" Width="130px" 
            onselectedindexchanged="DropDownList1_SelectedIndexChanged">
        </asp:DropDownList>
        <asp:SqlDataSource ID="SqlDataSource2" runat="server" 
            ConnectionString="<%$ ConnectionStrings:ConnectionString %>" 
            SelectCommand="select distinct Manufacturer from tbProduct">
        </asp:SqlDataSource>
    </div>
    <div style="height:5px;"></div>
    <div style="padding-left:10px;">
        <asp:DataList ID="DataList1" runat="server" DataKeyField="ProductID" >
            <ItemTemplate>
                <asp:Label ID="Label4" runat="server" Text='<%# Eval("ProductName") %>' 
                    Font-Bold="True" Font-Size="Large" ForeColor="#003399"></asp:Label>
                <br />
                <asp:Image ID="Image1" runat="server" Height="93px" 
                    ImageUrl='<%# "~/"+ Eval("ImageURL") %>' Width="117px" />
                <br />
                <asp:Label ID="PromotionLabel" runat="server" Text='<%# Eval("Promotion") %>' />
                <br />
                Price:
                <asp:Label ID="PriceLabel" runat="server" Text='<%# Eval("Price") %>' />
                &nbsp;VNĐ<br />                
                Manufacturer:
                <asp:Label ID="ManufacturerLabel" runat="server" 
                    Text='<%# Eval("Manufacturer") %>' />
                <br />
                Origin:
                <asp:Label ID="OriginLabel" runat="server" Text='<%# Eval("Origin") %>' />
                <br />
                Warranty:
                <asp:Label ID="WarrantyLabel" runat="server" Text='<%# Eval("Warranty") %>' />
                <br />
                <br />
            </ItemTemplate>
        </asp:DataList>     
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
            ConnectionString="<%$ ConnectionStrings:ConnectionString %>" 
            SelectCommand="SELECT * FROM [tbProduct]"></asp:SqlDataSource>  
    </div>          
    <div>
        &nbsp;&nbsp; 
        <asp:Label ID="Label2" runat="server" Text="Số lượng đã bán:"></asp:Label>
        <asp:Label ID="lblSoLuong" runat="server" ></asp:Label>
    </div>    
    <div style="padding-left:10px;">
        <asp:GridView ID="GridView1" runat="server" Width="449px" CellPadding="4" 
            ForeColor="#333333" GridLines="None">
            <RowStyle BackColor="#FFFBD6" ForeColor="#333333" />
            <FooterStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#FFCC66" ForeColor="#333333" 
                HorizontalAlign="Center" />
            <SelectedRowStyle BackColor="#FFCC66" ForeColor="Navy" Font-Bold="True" />
            <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
            <AlternatingRowStyle BackColor="White" />
        </asp:GridView>
    </div> 
    <div style="height:20px;"></div>
    </div>  
    </ContentTemplate>
    </asp:UpdatePanel>  
</asp:Content>

