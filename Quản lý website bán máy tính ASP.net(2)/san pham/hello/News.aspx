<%@ Page Language="C#" MasterPageFile="~/hello/Admin.master" AutoEventWireup="true" CodeFile="News.aspx.cs" Inherits="hello_Default2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .thongsosp
        {
        	width:792px;        	
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
     <div style="margin-bottom:20px;margin-top:5px;">
         <br />
         <asp:Label ID="Label1" runat="server" Text=">>Danh mục tin" 
        Font-Bold="True" Font-Size="Large" ForeColor="#CC0000"></asp:Label>
    </div>
    <div class="thongsosp">   
        <asp:DataList ID="DataList1" runat="server" DataKeyField="NewsID" 
             RepeatColumns="1" BackColor="#DEBA84" BorderColor="#DEBA84" 
            BorderStyle="None" BorderWidth="1px" CellPadding="3" CellSpacing="2" 
            GridLines="Both" ondeletecommand="DataList1_DeleteCommand" 
            onitemdatabound="DataList1_ItemDataBound" 
            onitemcommand="DataList1_ItemCommand" >
            <FooterStyle BackColor="#F7DFB5" ForeColor="#8C4510" />
            <ItemTemplate>
                &nbsp;
                <asp:Label ID="Label2" runat="server" Text="Mã tin: " ForeColor="#CC0000" Font-Bold="true"></asp:Label>
                <asp:Label ID="NewsIDLabel" runat="server" Text='<%# Eval("NewsID") %>' />
                <br />
                &nbsp;
                <asp:Label ID="Label3" runat="server" Text="Tiêu đề: " ForeColor="#CC0000" Font-Bold="true"></asp:Label>
                <asp:Label ID="TitleLabel" runat="server" Text='<%# Eval("Title") %>' />
                <br />
                &nbsp;
                <asp:Label ID="Label4" runat="server" Text="Link ảnh: " ForeColor="#CC0000" Font-Bold="true"></asp:Label>
                <asp:Label ID="ImageURLLabel" runat="server" Text='<%# Eval("ImageURL") %>' />
                <br />
                &nbsp;
                <asp:Label ID="Label5" runat="server" Text="Mô tả: " ForeColor="#CC0000" Font-Bold="true"></asp:Label>
                <asp:Label ID="DescriptionLabel" runat="server" 
                    Text='<%# Eval("Description") %>' />
                <br />
                &nbsp;
                <asp:Label ID="Label6" runat="server" Text="Nội dung: " ForeColor="#CC0000" Font-Bold="true"></asp:Label>
                <asp:Label ID="ContentsLabel" runat="server" Text='<%# Eval("Contents") %>' />
                <br />                
                <asp:Label ID="Label7" runat="server" Text="Ngày tạo: " ForeColor="#CC0000" Font-Bold="true"></asp:Label>
                <asp:Label ID="CreatedLabel" runat="server" Text='<%# Eval("Created") %>' />
                <br />
                
                <asp:Label ID="Label8" runat="server" Text="Người tạo: " ForeColor="#CC0000" Font-Bold="true"></asp:Label>
                <asp:Label ID="PosterLabel" runat="server" Text='<%# Eval("Poster") %>' />
                <br />
                <div style="text-align:center;">
                <asp:LinkButton ID="lbtSua" runat="server" 
                    Font-Bold="True" Font-Size="Large" CommandName="Sua" onclick="lbtSua_Click">Sửa</asp:LinkButton>
                    &nbsp;&nbsp;&nbsp;
                <asp:LinkButton ID="lbtXoa" runat="server" 
                     Font-Bold="True" Font-Size="Large" 
                        OnClientClick="return confirm('Bạn có chắc muốn xóa bản ghi này không?')" 
                        CommandName="Xoa">Xóa</asp:LinkButton>                                       
                </div>
                 <br />
            </ItemTemplate>
            <ItemStyle BackColor="#FFF7E7" ForeColor="#8C4510" />
            <SelectedItemStyle BackColor="#738A9C" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#A55129" Font-Bold="True" ForeColor="White" />
        </asp:DataList>    
    </div>
    <div style="height:25px; width:782px; padding-left:10px; margin-bottom:10px; padding-top:7px; background-image:none;">
        Đây là trang thứ: 
        <asp:Label ID="lbBanTin" runat="server" Text="1" ForeColor="#CC0000"></asp:Label>
        &nbsp;trên tổng số 
        <asp:Label ID="lbSobantintrongtrang" runat="server"
            ForeColor="#CC0000"></asp:Label>&nbsp;trang&nbsp;&nbsp;&nbsp;&nbsp; Tổng số bản tin 
        là: <asp:Label ID="lbTongsobantin" runat="server" Text="lbTongsobantin" 
            ForeColor="#CC0000"></asp:Label> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:LinkButton ID="lkbPreview" runat="server" Font-Underline="False" 
            onclick="lkbPreview_Click">&lt;&lt;Trước</asp:LinkButton>
        &nbsp;&nbsp;<asp:LinkButton ID="lkbNext" runat="server" Font-Underline="False" 
            onclick="lkbNext_Click">Sau&gt;&gt;</asp:LinkButton>
        </div>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
        ConnectionString="<%$ ConnectionStrings:ConnectionString %>" 
        SelectCommand="SELECT * FROM [tbNews] ORDER BY [Created] DESC" 
         DeleteCommand="Delete from tbNews where NewsID=@NewsID">
        <DeleteParameters>
            <asp:Parameter Name="NewsID" />
        </DeleteParameters>
     </asp:SqlDataSource>
</asp:Content>

