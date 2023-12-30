<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ucRegistry.ascx.cs"
    Inherits="TestOnline.hy.vn.Control.ucRegistry" %>
<style type="text/css">
    .ListPage_border
    {
        width: 708px;
        border: solid 1px gray;
        border-top: none;
        border-bottom-left-radius: 8px;
        border-bottom-right-radius: 8px;
        height: 600px;
    }
    .Registry_lable
    {
        width: 710px;
        font: 500 16px Arial;
        color: #0066CC;
        padding-left: 30px;
    }
    .Registry_sublable
    {
        width: 710px;
        font: 500 14px Arial;
        color: Gray;
        padding-left: 50px;
        padding-top: 5px;
    }
    .Registry_sublable1
    {
        float: left;
        font: 500 14px Arial;
        color: Gray;
        padding-left: 50px;
        width: 130px;
    }
    .Registry_sublable_Textbox
    {
    }
</style>
<div style="width: 710px; border-top-left-radius: 8px; border-top-right-radius: 8px;
    text-align: left; margin-left: 5px; height: 25px; background-repeat: repeat-x;
    background-image: url('../Images/menu_title1.gif')">
    <div style="float: left; height: 30px; width: 30px; background-image: url('../Images/70px-Logo_book2.png'">
    </div>
    <div style="float: left; color: White; font: 500 15px Arial; padding-left: 5px; padding-top: 5px;">
        Đăng ký tài khoản
    </div>
    <br />
    <div class="ListPage_border">
        <br />
        <br />
        <div class="Registry_lable">
            Thông tin cá nhân</div>
        <div class="Registry_sublable">
            <div class="Registry_sublable1">
                Họ và tên(*):
            </div>
            <div class="Registry_sublable_Textbox">
                <asp:TextBox ID="txtFullName" Width="300px" runat="server"></asp:TextBox></div>
        </div>
        <div class="Registry_sublable">
            <div class="Registry_sublable1">
                Ngày sinh(*):
            </div>
            <div class="Registry_sublable_Textbox">
                <asp:DropDownList ID="ddlDay" Width="100px" runat="server">
                </asp:DropDownList>
                <asp:DropDownList ID="ddlMonth" Width="100px" runat="server">
                </asp:DropDownList>
                <asp:DropDownList ID="ddlYear" Width="97px" runat="server">
                </asp:DropDownList>
            </div>
        </div>
        <div class="Registry_sublable">
            <div class="Registry_sublable1">
                Mail(*):
            </div>
            <div class="Registry_sublable_Textbox">
                <asp:TextBox ID="txtMail" Width="300px" runat="server"></asp:TextBox>&nbsp
                <asp:Button runat="server" Text="Ktra" ID="btnTestEmail" 
                    onclick="btnTestEmail_Click" /></div>
        </div>
        <div class="Registry_sublable">
            <div class="Registry_sublable1">
                Tỉnh/TP(*):
            </div>
            <div class="Registry_sublable_Textbox">
                <asp:DropDownList ID="ddlCity" Width="305px" runat="server">
                </asp:DropDownList>
            </div>
        </div>
        <div class="Registry_lable">
            Thông tin tài khoản</div>
        <div class="Registry_sublable">
            <div class="Registry_sublable1">
                Tài khoản(*):
            </div>
            <div class="Registry_sublable_Textbox">
                <asp:TextBox ID="txtUsername" Width="300px" runat="server"></asp:TextBox>&nbsp
                <asp:Button runat="server" Text="Ktra" ID="btnTestMK" 
                    onclick="btnTestMK_Click" /></div>
        </div>
        <div class="Registry_sublable">
            <div class="Registry_sublable1">
                Mật khẩu(*):
            </div>
            <div class="Registry_sublable_Textbox">
                <asp:TextBox ID="txtPassword" Width="300px" runat="server"></asp:TextBox></div>
        </div>
        <div class="Registry_sublable">
            <div class="Registry_sublable1">
                Xác nhận mật khẩu(*):
            </div>
            <div class="Registry_sublable_Textbox">
                <asp:TextBox ID="txtPassword2" Width="300px" runat="server"></asp:TextBox></div>
        </div>
          <div class="Registry_sublable">
            <asp:Button  runat="server" Text="Tạo tài khoản" ID="btnAdd" 
                  onclick="btnAdd_Click"/> &nbsp <asp:Label runat="server" ID="lblThongBao" Visible="false"></asp:Label>
        </div>
    </div>
</div>
