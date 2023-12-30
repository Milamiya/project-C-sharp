<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/SubMasterPage.Master" CodeBehind="ThreadUniversity.aspx.cs" Inherits="TestOnline.hy.vn.ThreadUniversity" %>
<asp:Content runat="server" ContentPlaceHolderID="content">
<div style="text-align:center; color:Black">

 Môn thi: &nbsp<asp:DropDownList DataTextField="SubjectName" DataValueField="SubjectID" Width="150px" runat="server" ID="ddlSubject" 
        AutoPostBack="True" onselectedindexchanged="ddlSubject_SelectedIndexChanged"></asp:DropDownList>
 &nbsp Đề thi: <asp:DropDownList DataTextField="TheadName" DataValueField="ThreadsID" Width="300px" runat="server" ID="ddlThread"></asp:DropDownList>
 &nbsp<asp:Button runat="server" ID="btnStart" Text="Bắt đầu thi ->" 
        onclick="btnStart_Click" />
</div>
<div style="text-align:center; color:Blue"><asp:Label runat="server" Text="Chọn đề thi để tiến hành tiến" ID="lblThongBao"></asp:Label></div>
</asp:Content>