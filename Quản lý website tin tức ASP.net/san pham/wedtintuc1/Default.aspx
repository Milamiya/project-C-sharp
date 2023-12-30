<%@ Page Language="C#" MasterPageFile="~/TrangChu.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="Default" Title="Untitled Page" %>
<%@ Register src="SlideNews.ascx" tagname="SlideNews" tagprefix="uc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <link href="Css/Default.css" rel="stylesheet" type="text/css" />
    <script src="Css/jquery.min.js" type="text/javascript"></script>
    <script src="Css/System_Tooltip.js" type="text/javascript"></script>
    </asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" runat="Server">
    <div>
        <uc1:SlideNews ID="SlideNews1" runat="server" />
    </div>
    
     <table cellspacing="0" cellpadding="0" bgcolor="#ffffff"  style="border: ">
        <tbody>
            <tr>
                <td background="images/bg_titte.gif" align="center" width="36">
                    <img height="30" width="24" src="images/icon.png" />
                </td>
                <td background="images/bg_titte2.jpg" width="260" class="newhome_abc_title2">
                    <asp:Literal ID="cateChaTTCN" runat="server"></asp:Literal>
                </td>
                <td width="1">
                </td>
                <td background="images/bg_titte.gif" align="center" width="36">
                    <img height="30" width="24" src="images/icon.png"/>
                </td>
                <td background="images/bg_titte2.jpg" width="260" class="newhome_abc_title2">
                   <asp:Literal ID="cateChaMMT" runat="server"></asp:Literal>
                </td>
            </tr>
           <%-- <tr>
                <td colspan="5">
                </td>
            </tr>--%>
            <tr>
                <td width="296" valign="top" colspan="2" class="boxtext">
                  <asp:Literal ID="ltrTinCN" runat="server"></asp:Literal>
                </td>
                <td rowspan="2">
                    &nbsp;
                </td>
                <td width="296" valign="top" colspan="2" class="boxtext">
                    <asp:Literal ID="ltrMangMT" runat="server"></asp:Literal>
                </td>
            </tr>
            <tr>
                <td  background="images/newhome_tinmoi_bg.gif" align="center" colspan="2">
                <td  background="images/newhome_tinmoi_bg.gif" align="center" colspan="2">
                    </td>
                </td>
            </tr>
            <tr>
                <td valign="top" colspan="2" class="boxtext">
                    <asp:Literal ID="ltr3CN" runat="server"></asp:Literal>
                </td>
                <td>
                    &nbsp;
                </td>
                <td valign="top" colspan="2" class="boxtext">
                    <asp:Literal ID="ltr3MangMT" runat="server"></asp:Literal>
                </td>
            </tr>
            <tr>
                <td height="5">
                </td>
            </tr>
            <tr>
                <td background="images/bg_titte.gif" align="center" width="36">
                    <img height="30" width="24" src="images/icon.png">
                </td>
                <td background="images/bg_titte2.jpg" width="260" class="newhome_abc_title2">
                     <asp:Literal ID="cateChaCNPM" runat="server"></asp:Literal>
                </td>
                <td>
                    &nbsp;
                </td>
                <td background="images/bg_titte.gif" align="center"  width="36">
                    <img height="30" width="24" src="images/icon.png">
                </td>
                <td background="images/bg_titte2.jpg" width="260" class="newhome_abc_title2">
                    <asp:Literal ID="cateChaKHMT" runat="server"></asp:Literal>
                </td>
            </tr>
            <tr>
                <td valign="top" colspan="2" class="boxtext">
                    <asp:Literal ID="ltrTinCNPM" runat="server"></asp:Literal>
                </td>
                <td rowspan="2">
                    &nbsp;
                </td>
                <td valign="top" colspan="2" class="boxtext">
                     <asp:Literal ID="ltrKHMT" runat="server"></asp:Literal>
                </td>
            </tr>
            <tr>
                <td height="1" background="images/newhome_tinmoi_bg.gif" align="center" colspan="2">
                </td>
                <td height="1" background="images/newhome_tinmoi_bg.gif" align="center" colspan="2">
                </td>
            </tr>
            <tr>
                <td valign="top" colspan="2" class="boxtext">
                     <asp:Literal ID="ltr3CNPM" runat="server"></asp:Literal>
                </td>
                <td>
                    &nbsp;
                </td>
                <td valign="top" colspan="2" class="boxtext">
                    <asp:Literal ID="ltr3TinKHMT" runat="server"></asp:Literal>
                </td>
            </tr>
            <tr>
                <td colspan="5">
                </td>
                
            </tr>
        </tbody>
    </table>
    
    
    <table cellspacing="0" cellpadding="0" bgcolor="#ffffff" width="593" style="border: ">
        <tbody>
            <tr>
                <td background="images/bg_titte.gif" align="center" width="36">
                    <img height="30" width="24" src="images/icon.png" />
                </td>
                <td background="images/bg_titte2.jpg" width="260" classicon.pngnewhome_abc_title2">
                    <asp:Literal ID="cateChaHanhTrang" runat="server"></asp:Literal>
                </td>
                <td width="1">
                </td>
                <td background="images/bg_titte.gif" align="center" width="36">
                    <img height="30" width="24" src="images/icon.png"/>
                </td>
                <td background="images/bg_titte2.jpg" width="260" class="newhome_abc_title2">
                   <asp:Literal ID="cateTuyenDung" runat="server"></asp:Literal>
                </td>
            </tr>
           <%-- <tr>
                <td colspan="5">
                </td>
            </tr>--%>
            <tr>
                <td width="296" valign="top" colspan="2" class="boxtext">
                  <asp:Literal ID="ltrTinHanhTrang" runat="server"></asp:Literal>
                </td>
                <td rowspan="2">
                    &nbsp;
                </td>
                <td width="296" valign="top" colspan="2" class="boxtext">
                    <asp:Literal ID="ltrTinTuyenDung" runat="server"></asp:Literal>
                </td>
            </tr>
            <tr>
                <td  background="images/newhome_tinmoi_bg.gif" align="center" colspan="2">
                <td  background="images/newhome_tinmoi_bg.gif" align="center" colspan="2">
                    </td>
                </td>
            </tr>
            <tr>
                <td valign="top" colspan="2" class="boxtext">
                    <asp:Literal ID="ltr3HT" runat="server"></asp:Literal>
                </td>
                <td>
                    &nbsp;
                </td>
                <td valign="top" colspan="2" class="boxtext">
                    <asp:Literal ID="ltr3TuyenDung" runat="server"></asp:Literal>
                </td>
            </tr>
            <tr>
                <td height="5">
                </td>
            </tr>
            <tr>
                <td background="images/bg_titte.gif" align="center" width="36">
                    <img height="30" width="24" src="images/icon.png">
                </td>
                <td background="images/bg_titte2.jpg" width="260" class="newhome_abc_title2">
                     <asp:Literal ID="cateChaCS" runat="server"></asp:Literal>
                </td>
                <td>
                    &nbsp;
                </td>
                <td background="images/bg_titte.gif" align="center"  width="36">
                    <img height="30" width="24" src="images/icon.png">
                </td>
                <td background="images/bg_titte2.jpg" width="260" class="newhome_abc_title2">
                    <asp:Literal ID="cateConDuong" runat="server"></asp:Literal>
                </td>
            </tr>
            <tr>
                <td valign="top" colspan="2" class="boxtext">
                    <asp:Literal ID="ltrTinCS" runat="server"></asp:Literal>
                </td>
                <td rowspan="2">
                    &nbsp;
                </td>
                <td valign="top" colspan="2" class="boxtext">
                     <asp:Literal ID="ltrTinCD" runat="server"></asp:Literal>
                </td>
            </tr>
            <tr>
                <td height="1" background="images/newhome_tinmoi_bg.gif" align="center" colspan="2">
                </td>
                <td height="1" background="images/newhome_tinmoi_bg.gif" align="center" colspan="2">
                </td>
            </tr>
            <tr>
                <td valign="top" colspan="2" class="boxtext">
                     <asp:Literal ID="ltr3CS" runat="server"></asp:Literal>
                </td>
                <td>
                    &nbsp;
                </td>
                <td valign="top" colspan="2" class="boxtext">
                    <asp:Literal ID="ltr3CD" runat="server"></asp:Literal>
                </td>
            </tr>
            <tr>
                <td colspan="5">
                </td>
                
            </tr>
        </tbody>
    </table>
</asp:Content>

