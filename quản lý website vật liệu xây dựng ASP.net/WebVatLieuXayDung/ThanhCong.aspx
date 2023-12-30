<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true"
    CodeFile="ThanhCong.aspx.cs" Inherits="ThanhCong" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div style="width: 600px; height: 200px; margin: 0 auto">
        <div style="float: left; width: 40%; height: 100%">
        <img src="Images/Design/SuccessIcon.png" />
        </div>
        <div style="float: right; width: 59%; padding-top: 10px">
            <p>
                Bạn vừa đàng ký thành công !</p>
            <p>
                Bạn hãy trở về trang <a href="DangNhap.aspx">Đăng nhập</a> để thực hiện việc mua bán</p>
        </div>
    </div>
</asp:Content>
