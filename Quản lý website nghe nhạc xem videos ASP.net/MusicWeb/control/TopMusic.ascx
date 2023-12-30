<%@ Control Language="C#" AutoEventWireup="true" CodeFile="TopMusic.ascx.cs" Inherits="control_TopMusic" %>
<link href="../css/StyleContent.css" rel="stylesheet" type="text/css" />
<style type="text/css">
    .style1
    {
        width: 25px;
        height: 10px;
    }
</style>
<div class="TopMusic">
<div class="tieude"><h2 class="aa">&nbsp; Top 10 Music&nbsp;
    <img alt="" class="style1" src="img_button/hot.gif" /></h2></div>
<div class="noidung">
<asp:DataList ID="TopMusic__" runat="server" Width="100%">
                <ItemTemplate>
                    <div class="menu1">
                     <img src="img_button/music.gif" />
                        <asp:HyperLink ID="HyperNhac" Text='<%#Eval("TenBaiHat") %>' 
                                NavigateUrl='<%#Eval("MaBaiHat","~/Play.aspx?M={0}") %>' 
                                runat="server">
                        </asp:HyperLink>
                    </div>
                </ItemTemplate>
            
            </asp:DataList>
</div>
</div>