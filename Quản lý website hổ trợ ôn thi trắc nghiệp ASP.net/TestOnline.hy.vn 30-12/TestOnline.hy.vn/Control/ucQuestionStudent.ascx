<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ucQuestionStudent.ascx.cs"
    Inherits="TestOnline.hy.vn.Control.ucQuestionStudent" %>
<style type="text/css">
    .div_Font
    {
        float: left;
        width: 100px;
        padding-left: 10px;
    }
    .div_text
    {
        width: 200px;
        float: left;
    }
    .Title
    {
        color: Black;
        font: 700 14px/23px "Times New Roman";
    }
    .Title .Title1
    {
        padding-left: 10px;
        color: #0066CC;
        font: 500 14px/23px "Times New Roman";
    }
    .CreateDate
    {
        color: #666666;
        font: 500 10px Arial;
    }
</style>
<div style="width: 730px; border-top-left-radius: 8px; border-top-right-radius: 8px;
    margin-top: 7px; margin-left: 5px; height: 25px; background-image: url('../Images/nav_bg.gif');
    background-repeat: repeat-x">
    <div style="float: left; height: 30px; width: 30px; background-image: url('../Images/62px-Writing_star.svg.png')">
    </div>
    <div style="float: left; color: White; font: 500 15px Arial; padding-left: 5px; padding-top: 5px;">
        Câu hỏi thí sinh</div>
</div>
<div style="width: 728px; margin-left: 5px; border: solid 1px gray; color: Black;
    border-bottom-left-radius: 8px; border-bottom-right-radius: 8px; height: 200px">
    <div style="width: 600px; padding-top: 10px; font: 500 15px Arial" id="Div1">
        <div style="width: 600px; padding-bottom: 10px">
            <div class="div_Font">
                Nội dung (*):
            </div>
            <div class="div_text">
                <asp:TextBox ID="txtContent" Width="400px" runat="server" Height="155px" 
                    TextMode="MultiLine"></asp:TextBox><br />
                <div style="padding-top: 5px; width: 400px;">
                    <asp:Button ID="btnSend" runat="server" Text="Gửi câu hỏi" OnClick="btnSend_Click1" />&nbsp<asp:Button
                        ID="btnRefresh" runat="server" Text="Làm lại" OnClick="btnRefresh_Click" />&nbsp<asp:Label
                            ID="lblThongBao" runat="server" Visible="false"></asp:Label><br />
                    <br />
                </div>
            </div>
            <br />
        </div>
        <br />
    </div>
</div>
<br />
<div style="width: 730px; border-top-left-radius: 8px; border-top-right-radius: 8px;
    margin-left: 5px; height: 25px; background-image: url('../Images/nav_bg.gif');
    background-repeat: repeat-x">
    <div style="float: left; height: 30px; width: 30px; background-image: url('../Images/62px-Writing_star.svg.png')">
    </div>
    <div style="float: left; color: White; font: 500 15px Arial; padding-left: 5px; padding-top: 5px;">
        Phản hồi ý kiến</div>
</div>
<div style="width: 728px; margin-left: 5px; border: solid 1px gray; color: Black;
    border-bottom-left-radius: 8px; border-bottom-right-radius: 8px">
    <div style="padding-left: 5px; padding-top: 4px;" id="news">
        <asp:Repeater runat="server" ID="rptTile1" OnItemDataBound="rptTile1_ItemDataBound">
            <ItemTemplate>
                <div class="Title">
                    <img src="../Images/arow2.gif" style="float: left; padding-top: 10px; padding-right: 5px" />
                    <div>
                        <%# Eval("StudentName")%><a class="CreateDate">&nbsp(<%# Eval("CreateDate")%>)</a></div>
                    <div class="Title1" style="color:Blue">
                        <%# Eval("CommandName")%></div>
                </div>
                <asp:HiddenField runat="server" ID="hdfid" Value='<%#Eval("CommandID") %>' />
                <asp:Repeater runat="server" ID="rptRespon">
                    <ItemTemplate>
                        <div class="Title">
                            <div>
                                Trả lời:
                                <%# Eval("ResponInformation")%></div>
                        </div>
                    </ItemTemplate>
                </asp:Repeater>
                <hr />
                <br />
            </ItemTemplate>
        </asp:Repeater>
    </div>
</div>
