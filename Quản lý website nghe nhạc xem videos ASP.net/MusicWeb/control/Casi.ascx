<%@ Control Language="C#" AutoEventWireup="true" CodeFile="Casi.ascx.cs" Inherits="control_Casi" %>
<link href="../css/StyleContent.css" rel="stylesheet" type="text/css" />
<div class="Casi">
<div class="tieude"><h2 class="aa">&nbsp; Ca Sĩ</h2></div>
<div class="noidung" style="height:400px; overflow:scroll;">
<asp:DataList ID="CaSi__" runat="server" Width="100%">
                <ItemTemplate>
                    <div class="menu1">
                        <asp:HyperLink ID="HyperNhac" Text='<%#Eval("TenCaSi") %>' 
                                NavigateUrl='<%#Eval("MaCaSi","~/CaSi.aspx?L={0}") %>' 
                                runat="server">
                        </asp:HyperLink>
                    </div>
                </ItemTemplate>
            
            </asp:DataList>
</div>
</div>