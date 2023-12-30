<%@ Page Title="" Language="C#" MasterPageFile="~/Master_Home.master" AutoEventWireup="true" CodeFile="Chat.aspx.cs" Inherits="Chat" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="chatleft">
<br />
<div class="NoidungBinhLuan" style="height:650px; overflow:scroll;">
    <asp:DataList ID="DataList_binhluan" Width="100%" runat="server" 
        BorderColor="Black" BorderStyle="Double">
        <ItemTemplate>
            <table class="Top_Banner" 
                style=" border-color: #00FF00; height:60px; border-bottom-style: outset;">
                <tr>
                    <td style="width:50px">
                        <asp:Image ID="Image6" Width="90%" runat="server" BorderStyle="Inset" 
                            ImageUrl='<%# "~/img_user/"+Eval("Hinh") %>' />
                    </td>
                    <td style="width:10px">
                        <img alt="" src="img_button/neen.gif" 
                style="width: 10px; height:100%" />
                    </td>
                    <td style="width: 660px">
                        <asp:Label ID="Label5" runat="server" Text='<%# Eval("HoTen") %>'></asp:Label> :<asp:Label ID="Label4" runat="server" Text='<%# Eval("LoiBinh") %>'></asp:Label>
                    </td>
                    <td>
                        <asp:Label ID="Label6" runat="server" Text='<%# Eval("NgayDang") %>'></asp:Label>
                    </td>
                </tr>
            </table>
        </ItemTemplate>
    </asp:DataList>
</div>
        <%--Download source code tai Sharecode.vn--%>
<p><div class="TieuDe__" >&nbsp;&nbsp;&nbsp; Chat</div></p>
<table class="Top_Banner" style="border-style: solid">
                <tr>
                    <td style="width:60px">
                        <asp:Image ID="Image_user" Width="90%" runat="server" BorderStyle="Inset" 
                            ImageUrl="~/img_button/3anh.png"/>
                    </td>
                    <td style="width:10px">
                        <img alt="" src="img_button/neen.gif" 
                style="width: 10px; height:100%" />
                    </td>
                    <td>
                        
                        <asp:Label ID="lab_tenuser" runat="server" Text="Bình Luận"></asp:Label>
&nbsp;:<asp:TextBox ID="txt_binhluan" Width="70%" runat="server"></asp:TextBox>
                        
                    &nbsp;&nbsp;
                        <asp:Button ID="btn_gui" runat="server" Text="OK" onclick="btn_gui_Click" />
                        
                    </td>
                </tr>
            </table>
            </div>
</asp:Content>

