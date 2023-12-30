<%@ Control Language="C#" AutoEventWireup="true" CodeFile="ucThongKe.ascx.cs" Inherits="ucThongKe" %>

<style type="text/css">
    .style1
    {
        width: 100%;
    }
</style>

<%--<asp:Panel ID="Panel1" runat="server" Width="180px" GroupingText="Thống kê truy cập">
    <table cellpadding="0" cellspacing="0" class="style1" width="250px">
        <tr>
            <td style="width:50%; padding-left:10px">
                <img alt="" src="images/Import.jpg" /> Đang online </td>
            <td style="width:20%"><% =Application["Online"].ToString()%>
            </td>
        </tr>
        <tr>
            <td style="width:50%; padding-left:10px">
                <img alt="" src="images/25.png" />
                Hôm nay</td>
            <td style="width:20%">
                <% =Application["HomNay"].ToString()%></td>
        </tr>
        <tr>
            <td  style="width:50%; padding-left:10px">
                <img alt="" src="images/02.jpg" /> Hôm qua</td>
            <td style="width:20%">
                <% =Application["HomQua"].ToString()%></td>
        </tr>
        <tr>
            <td  style="width:50%; padding-left:10px">
                 <img alt="" src="images/User.png" /> Tuần này </td>
            <td style="width:20%">
                <% =Application["TuanNay"].ToString()%></td>
        </tr>
        <tr>
            <td style="width:50%; padding-left:10px">
                <img alt="" src="images/AddUser.jpg" /> Tuần trước</td>
            <td style="width:20%">
                <% =Application["TuanTruoc"].ToString()%></td>
        </tr>
        <tr>
            <td style="width:50%; padding-left:10px">
                <img alt="" src="images/02.jpg" /> Tháng này</td>
            <td style="width:20%">
                 <% =Application["ThangNay"].ToString()%></td>
        </tr>
        <tr>
            <td style="width:50%; padding-left:10px">
                <img alt="" src="images/02.jpg" /> Tháng trước</td>
            <td style="width:20%">
                 <% =Application["ThangTruoc"].ToString()%></td>
        </tr>
        <tr>
            <td style="width:50%; padding-left:10px" >
                <img alt="" src="images/counters.gif" /> Tất cả</td>
            <td style="width:20%">
                <% =Application["TatCa"].ToString()%></td>
        </tr>
    </table>


</asp:Panel>--%>

    <table cellpadding="0" cellspacing="0" Width="250px" >
        
        <tr>
            <td style="width:50%; padding-left:10px">
               <img src="images/Import.jpg" /> Đang online:</td>
            <td style="width:20%">
                <% =Application["Online"].ToString()%></td>
        </tr>
        
        <tr>
            <td style="width:50%; padding-left:10px">
                <img src="images/25.png" /> Hôm nay:</td>
            <td style="width:20%">
                 <% =Application["HomNay"].ToString()  %></td>
        </tr>
        <tr>
            <td style="width:50%; padding-left:10px">
                <img src="images/02.jpg" /> Hôm qua:</td>
            <td style="width:20%">
                 <% =Application["HomQua"].ToString()  %></td>
        </tr>
        
         
        <tr>
            <td style="width:50%; padding-left:10px">
                <img src="images/User.png" /> Tuần này:</td>
            <td style="width:20%">
                 <% =Application["TuanNay"].ToString()  %></td>
        </tr>
        <tr>
            <td style="width:50%; padding-left:10px">
                <img src="images/AddUser.jpg" /> Tuần trước:</td>
            <td style="width:20%">
                 <% =Application["TuanTruoc"].ToString()  %></td>
        </tr>
        <tr>
            <td style="width:50%; padding-left:10px">
                <img src="images/02.jpg" /> Tháng này:</td>
            <td style="width:20%">
                 <% =Application["ThangNay"].ToString()  %></td>
        </tr>
        
         
        <tr>
            <td style="width:50%; padding-left:10px">
                <img src="images/User.png" /> Tháng trước:</td>
            <td style="width:20%">
                 <% =Application["ThangTruoc"].ToString()  %></td>
        </tr>
        <tr>
            <td style="width:50%; padding-left:10px">
                <img src="images/counters.gif" /> Tất cả:</td>
            <td style="width:20%">
                 <% =Application["TatCa"].ToString()%></td>
        </tr>
    </table>
