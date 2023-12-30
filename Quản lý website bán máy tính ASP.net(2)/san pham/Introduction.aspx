<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Introduction.aspx.cs" Inherits="_Default" %>

<%@ Register Assembly="obout_Show_Net" Namespace="OboutInc.Show" TagPrefix="obshow" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
<style type="text/css">
    .panelTable
	    {
		    background-color:white;		    
		    width:500px;		    
		    border-collapse: separate;
		    border-spacing: expression(cellSpacing=0);
		    border-spacing: 0px;		
	    }
</style>
    
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <embed width="279" height="238" type="application/x-shockwave-flash" src="/DesktopModules/AIMedia/Player/flvplayer.swf" id="playerID" name="movie_player" bgcolor="#000000" quality="high" allowfullscreen="true" wmode="transparent" allowscriptaccess="always" flashvars="file=//Portals/0/Video/video.flv&amp;image=/Portals/0/car-girls-14.jpg.thumb210x0.ns.jpg&amp;autostart=false">

    <asp:Table ID="Table1" runat="server" Width="740px">
            
            <asp:TableRow ID="TableRow1" runat="server">
                <asp:TableCell Text="Bộ Giáo Dục & Đào Tạo" HorizontalAlign="Center"  Font-Size="14pt">                    
                </asp:TableCell>
                <asp:TableCell Text="Cộng Hòa Xã Hội Chủ Nghĩa Việt Nam" HorizontalAlign="Center" Font-Size="14pt">                                    
                </asp:TableCell>
                
            </asp:TableRow>
            <asp:TableRow ID="TableRow2" runat="server">
                <asp:TableCell Text="Trường ĐH Y Hà Nội" HorizontalAlign="Center">                     
                </asp:TableCell>
                <asp:TableCell Text="Độc lập - Tự do - Hạnh Phúc" Font-Underline="true"  HorizontalAlign="Center">                    
                </asp:TableCell>                
            </asp:TableRow>
             <asp:TableRow ID="TableRow3" runat="server">
                <asp:TableCell ColumnSpan="2" Text="">                    
                </asp:TableCell>
                
            </asp:TableRow>
            
            <asp:TableRow ID="TableRow4" runat="server">
               <asp:TableCell ColumnSpan="2" Text="">                    
                </asp:TableCell>            
            </asp:TableRow>
            <asp:TableRow ID="TableRow5" runat="server" >
                <asp:TableCell ColumnSpan="2" Text="Đề Thi Tuyển Sinh" Font-Size="18pt" Font-Bold="true" HorizontalAlign="Center">                    
                </asp:TableCell>                
            </asp:TableRow>
            
            <asp:TableRow ID="TableRow6" runat="server" >
                <asp:TableCell ColumnSpan="2" Text="Cao Học" Font-Size="14pt" Font-Bold="true" HorizontalAlign="Center">                    
                </asp:TableCell>                
            </asp:TableRow>
            
            <asp:TableRow ID="TableRow7" runat="server">
                <asp:TableCell>                    
                </asp:TableCell>
                <asp:TableCell>                    
                </asp:TableCell>
            </asp:TableRow>
            
            <asp:TableRow ID="TableRow8" runat="server">
               <asp:TableCell ColumnSpan="2"> 
                    <table style="width:100%">                    
                    <tr>
                        <td align="right">Môn thi:</td>
                        <td align="left">
                            <asp:Label ID="lblMonThi" runat="server" Text="Toán"></asp:Label>
                        </td>
                        <td align="right">Thời gian:</td>
                        <td align="left">
                        <asp:Label ID="lblThoiGian" runat="server" Text="130"></asp:Label>
                        Phút
                        </td>
                        <td align="right">Ngày thi:</td>
                        <td align="left">
                        <asp:Label ID="lblNgayThi" runat="server" Text="12/05/2011"></asp:Label>
                        </td>
                    </tr>
                    </table>                   
                </asp:TableCell>    
            </asp:TableRow>
            
            <asp:TableRow ID="TableRow9" runat="server">
               <asp:TableCell ColumnSpan="2">                    
                </asp:TableCell>    
            </asp:TableRow>
            <asp:TableRow ID="TableRow10" runat="server">
               <asp:TableCell ColumnSpan="2" Text="Đề bài" Font-Bold="true" Font-Size="14pt" Font-Underline="true" Font-Italic="true">                    
                </asp:TableCell>    
            </asp:TableRow>     
            <asp:TableRow ID="TableRow11" runat="server">
               <asp:TableCell ColumnSpan="2">                    
                </asp:TableCell>    
            </asp:TableRow>
            
            
            <%--câu 1--%>
         <asp:TableRow ID="TableRow12" runat="server">
               <asp:TableCell ColumnSpan="2" Text="Câu 1:" Font-Bold="true">                    
                </asp:TableCell>    
            </asp:TableRow>
            
           <asp:TableRow ID="TableRow13" runat="server">
               <asp:TableCell ColumnSpan="2">                    
                </asp:TableCell>    
            </asp:TableRow>
            
           <asp:TableRow ID="TableRow14" runat="server">
               <asp:TableCell ColumnSpan="2">                    
                </asp:TableCell>    
            </asp:TableRow> 
             <asp:TableRow ID="TableRow15" runat="server">
               <asp:TableCell ColumnSpan="2">                                   
                </asp:TableCell>    
            </asp:TableRow> 
            
            
            <%--câu 2--%>
         <asp:TableRow ID="TableRow16" runat="server">
               <asp:TableCell ColumnSpan="2" Text="Câu 2:" Font-Bold="true">                    
                </asp:TableCell>    
            </asp:TableRow>
            
           <asp:TableRow ID="TableRow17" runat="server">
               <asp:TableCell ColumnSpan="2">                    
                </asp:TableCell>    
            </asp:TableRow>
            
           <asp:TableRow ID="TableRow18" runat="server">
               <asp:TableCell ColumnSpan="2">                    
                </asp:TableCell>    
            </asp:TableRow> 
             <asp:TableRow ID="TableRow19" runat="server">
               <asp:TableCell ColumnSpan="2">                                   
                </asp:TableCell>    
            </asp:TableRow> 
            
            
            
            <%--câu 3--%>
         <asp:TableRow ID="TableRow20" runat="server">
               <asp:TableCell ColumnSpan="2" Text="Câu 3:" Font-Bold="true">                    
                </asp:TableCell>    
            </asp:TableRow>
            
           <asp:TableRow ID="TableRow21" runat="server">
               <asp:TableCell ColumnSpan="2">                    
                </asp:TableCell>    
            </asp:TableRow>
            
           <asp:TableRow ID="TableRow22" runat="server">
               <asp:TableCell ColumnSpan="2">                    
                </asp:TableCell>    
            </asp:TableRow> 
             <asp:TableRow ID="TableRow23" runat="server">
               <asp:TableCell ColumnSpan="2">                                   
                </asp:TableCell>    
            </asp:TableRow> 
            
            
            
            <%--câu 4--%>
         <asp:TableRow ID="TableRow24" runat="server">
               <asp:TableCell ColumnSpan="2" Text="Câu 4:" Font-Bold="true">                    
                </asp:TableCell>    
            </asp:TableRow>
            
           <asp:TableRow ID="TableRow25" runat="server">
               <asp:TableCell ColumnSpan="2">                    
                </asp:TableCell>    
            </asp:TableRow>
            
           <asp:TableRow ID="TableRow26" runat="server">
               <asp:TableCell ColumnSpan="2">                    
                </asp:TableCell>    
            </asp:TableRow> 
             <asp:TableRow ID="TableRow27" runat="server">
               <asp:TableCell ColumnSpan="2">                                   
                </asp:TableCell>    
            </asp:TableRow> 
            
            
            
            <%--câu 5--%>
         <asp:TableRow ID="TableRow28" runat="server">
               <asp:TableCell ColumnSpan="2" Text="Câu 5:" Font-Bold="true">                    
                </asp:TableCell>    
            </asp:TableRow>
            
           <asp:TableRow ID="TableRow29" runat="server">
               <asp:TableCell ColumnSpan="2">                    
                </asp:TableCell>    
            </asp:TableRow>
            
           <asp:TableRow ID="TableRow30" runat="server">
               <asp:TableCell ColumnSpan="2">                    
                </asp:TableCell>    
            </asp:TableRow> 
             <asp:TableRow ID="TableRow31" runat="server">
               <asp:TableCell ColumnSpan="2">                                   
                </asp:TableCell>    
            </asp:TableRow> 
            
            
            
            <%--câu 6--%>
         <asp:TableRow ID="TableRow32" runat="server">
               <asp:TableCell ColumnSpan="2" Text="Câu 6:" Font-Bold="true">                    
                </asp:TableCell>    
            </asp:TableRow>
            
           <asp:TableRow ID="TableRow33" runat="server">
               <asp:TableCell ColumnSpan="2">                    
                </asp:TableCell>    
            </asp:TableRow>
            
           <asp:TableRow ID="TableRow34" runat="server">
               <asp:TableCell ColumnSpan="2">                    
                </asp:TableCell>    
            </asp:TableRow> 
             <asp:TableRow ID="TableRow35" runat="server">
               <asp:TableCell ColumnSpan="2">                                   
                </asp:TableCell>    
            </asp:TableRow> 
            
            
        </asp:Table>                
        <asp:Button ID="btnXuat" runat="server" Text="Xuất Word" 
            onclick="btnXuat_Click" CssClass="button" />
    <div style="width:201px; height:198px; margin-top:1px; border:1px solid gray;">
        <obshow:Show ID="Show1" runat="server"
         Height="190px"
         Width="100%"
         ShowType="Show"
         SelectedPanel="1"
         TransitionType="Fading"
         ScrollDirection="Top" >
<Changer Type="Arrow" ArrowType="Side1" Position="Bottom" VerticalAlign="Middle" HorizontalAlign="Center"></Changer>
        </obshow:Show>        
    </div>
</asp:Content>

