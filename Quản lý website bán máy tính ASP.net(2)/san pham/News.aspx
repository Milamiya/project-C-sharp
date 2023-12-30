<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="News.aspx.cs" Inherits="Default3" %>

<%@ Register Assembly="obout_Show_Net" Namespace="OboutInc.Show" TagPrefix="obshow" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    
    <style type="text/css">
        .style1
        {
            width: 100%;
            border:1px solid gray;
        }   
        .menu
        {
        	color:#004175;
        	font-weight:bold;
        	text-decoration:none;
        	}
        .menu:hover
        {
        	color:#4f82ac;
        	}   
        .panelTable
	    {
		    background-color:white;		    
		    width:747px;
		    border-collapse: separate;
		    border-spacing: expression(cellSpacing=0);
		    border-spacing: 0px;		
	    }
        </style>
    
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div style="width:733px; height:auto;margin-right:1px;">
    <table>
        <tr>
            <td class="style1" style="width:400px; height:250px;">
                <asp:DataList ID="DataList3" runat="server" DataKeyField="NewsID" 
                    DataSourceID="SqlDataSource1">
                    <ItemTemplate>                                           
                        <asp:Image ID="Image1" runat="server" Height="252px"
                        ImageUrl='<%# Eval("ImageURL") %>' Width="401px" BorderColor="#999999" 
                            BorderStyle="Solid" BorderWidth="3px" />                                                
                        <br />                        
                        <asp:LinkButton ID="LinkButton5" runat="server" CssClass="menu" PostBackUrl='<%# "NewsDetails.aspx?NewsID="+ Eval("NewsID") %>' 
                        Font-Size="16pt" Font-Underline="False" Text='<%# Eval("Title") %>'></asp:LinkButton>                                            
                        <br />
                        <asp:Label ID="DescriptionLabel" runat="server" 
                        Text='<%# Eval("Description") %>' Width="400px" />                                            
                        &gt;&gt;<asp:LinkButton ID="LinkButton1" runat="server" Text='<%# Eval("Title") %>' CssClass="menu"></asp:LinkButton>
                        <div style="height:40px;"></div>                                    
                    </ItemTemplate>
                </asp:DataList>  
             <%--<div style="width:100%;height:281px; margin-top:1px; border:1px solid gray;">
                <obshow:Show ID="Show1" runat="server"
                 Height="400px"
                 Width="100%"
                 ShowType="Show"
                 SelectedPanel="1"
                 TransitionType="Fading"
                 ScrollDirection="Top" >
                </obshow:Show>        
            </div>--%>              
            </td>
            <td class="style1" style="width:325px;float:right;padding-left:5px; height:482px;">
                <img src="Image/tintuc-sukien.png"/><br />
                &nbsp;<asp:DataList ID="DataList1" runat="server" DataSourceID="SqlDataSource2" 
                    DataKeyField="NewsID">
                    <ItemTemplate>
                    <div style="margin-bottom:4px;">                        
                        <asp:Image ID="Image3" runat="server" ImageUrl="~/Image/item2.png" />
                        <asp:LinkButton ID="LinkButton4" runat="server" Font-Bold="false" 
                            Text='<%# Eval("Title") %>' CssClass="menu"></asp:LinkButton>
                    </div>
                    </ItemTemplate>
                </asp:DataList>
                
                <asp:SqlDataSource ID="SqlDataSource2" runat="server" 
                    ConnectionString="<%$ ConnectionStrings:ConnectionString %>" 
                    SelectCommand="SELECT * FROM [tbNews] ORDER BY [Created] DESC">
                </asp:SqlDataSource>
                <%--<asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>--%>
            </td>         
        </tr>                                                                  
    </table>        
</div>
<div style="width:748px;height:auto;margin-top:1px; border:1px solid gray;">
   
    <asp:DataList ID="DataList4" runat="server" DataSourceID="SqlDataSource3" 
        RepeatColumns="3">
        <ItemTemplate>        
        <div style="height:auto; width:auto;">
            <div style="float:left; margin:2px">
                <asp:Image ID="Image2" runat="server" Height="95px" Width="122px"
                ImageUrl='<%# Eval("ImageURL") %>' BorderColor="#999999" BorderStyle="Solid" BorderWidth="2px" />
            </div>
            <div style="float:right;margin-left:2px;">
                <asp:LinkButton ID="LinkButton3" runat="server" Font-Bold="True" Width="114px"
                     Text='<%# Eval("Title") %>' CssClass="menu"></asp:LinkButton>                                     
            </div>            
        </div>
        </ItemTemplate>
    </asp:DataList>
    <asp:SqlDataSource ID="SqlDataSource3" runat="server" 
        ConnectionString="<%$ ConnectionStrings:ConnectionString %>" 
        SelectCommand="SELECT top(3)* FROM [tbNews] ORDER BY [Created] DESC">
    </asp:SqlDataSource>      
</div>
<asp:SqlDataSource ID="SqlDataSource1" runat="server" 
    ConnectionString="<%$ ConnectionStrings:ConnectionString %>" 
    SelectCommand="SELECT top(1)* FROM [tbNews] ORDER BY [Created] DESC">
</asp:SqlDataSource>    
<div style="margin-top:50px;">    
    <asp:Label ID="Label1" runat="server" Font-Bold="True" Text="Các bài mới" 
        Font-Names="Tahoma" Font-Size="Medium"></asp:Label>
</div>
<hr style="color:#e4e4e4; float:left; width:450px;" />
    <br />
    <div>
        <asp:Label ID="lbCacbaimoi" Font-Bold="false" CssClass="menu" runat="server"></asp:Label>
    </div>
<div>
    <br />
    <asp:Label ID="Label2" runat="server" ForeColor="#004175" Font-Bold="True" 
        Text="Các bài đã đăng" Font-Names="Tahoma" Font-Size="12pt"></asp:Label>
</div>
<hr style="color:#99cc00;float:left; width:450px;" />
    <div>
        <br />
        <asp:Label ID="lbCacbaidadang" Font-Bold="false" CssClass="menu" runat="server"></asp:Label>
    </div>
</asp:Content>


