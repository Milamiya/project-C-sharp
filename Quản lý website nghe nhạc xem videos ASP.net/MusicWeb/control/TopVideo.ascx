<%@ Control Language="C#" AutoEventWireup="true" CodeFile="TopVideo.ascx.cs" Inherits="control_TopVideo" %>
<link href="../css/StyleContent.css" rel="stylesheet" type="text/css" />

<style type="text/css">
    .style1
    {
        width: 25px;
        height: 10px;
    }
</style>

<div class="TopVideo">
<div class="tieude"><h2 class="aa">&nbsp; Top 10 Video&nbsp;
    <img alt="" class="style1" src="img_button/hot.gif" /></h2></div>
<div class="noidung">
<asp:DataList ID="TopVideo__" runat="server" Width="100%">
                <ItemTemplate>
                    <div class="menu1">
                       <asp:ImageButton ID="ImageButton1" runat="server" Height="70px" 
                        ImageUrl='<%# "~/img_video/"+Eval("Hinh") %>' 
                        PostBackUrl='<%#Eval("MaVideo","~/Play_Video.aspx?V={0}") %>' 
                        Width="160px"/>
                        <br />
                        <asp:HyperLink ID="HyperNhac" Text='<%#Eval("TenVideo") %>' 
                                NavigateUrl='<%#Eval("MaVideo","~/Play_Video.aspx?V={0}") %>' 
                                runat="server">
                        </asp:HyperLink>
                    </div>
                </ItemTemplate>
            
            </asp:DataList>
</div>
</div>