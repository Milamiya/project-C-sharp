<%@ Page Language="C#" MasterPageFile="~/Manages/Account.master" AutoEventWireup="true"
    CodeFile="DangNhap.aspx.cs" Inherits="Manages_DangNhap" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceBody" runat="Server">
    <link href="StyleAccount/Login.css" rel="stylesheet" type="text/css" />

    <script type="text/javascript">
       function KT()
       {
             var US = $("#<%=txtTaiKhoan.ClientID%>");
              var m = $("#<%=txtMatKhau.ClientID%>");
                 var kt=true;
                if(US.val() =="" || m.val()=="")
                {
                    alert("Bạn chưa nhập tài khoản hoặc mật khẩu");
                    kt=false;
                }
                return kt;
            
       }
    </script>

    <div class="khunglogin">
        <div class="anh">
        </div>
        <div class="login">
            <div class="dau">
            </div>
            <div style="height: 18px; width: 230px">
                Tài khoản(<do>*</do>):</div>
            <div style="height: 22px; width: 230px">
                <asp:TextBox ID="txtTaiKhoan" runat="server" Width="218px"></asp:TextBox>
            </div>
            <div style="height: 18px; width: 230px; margin-top: 8px;">
                Mật khẩu(<do>*</do>):</div>
            <div style="height: 22px; width: 230px">
                <asp:TextBox ID="txtMatKhau" runat="server" Width="218px" TextMode="Password"></asp:TextBox>
            </div>
            <div style="height: 18px; width: 230px; margin-top: 8px;">
                <asp:CheckBox ID="checkNhoMatKhau" runat="server" Text="Ghi nhớ mật khẩu" /></div>
            <div style="height: 22px; width: 230px; margin-top: 8px;">
                <%--<span onclick="return KT();">--%>
                <asp:Button ID="btnDangNhap" OnClientClick="return KT();" runat="server" Text="Đăng nhập"
                    OnClick="btnDangNhap_Click" />
                <%--</span>--%>
            </div>
            <div style="margin-top: 30px">
                <label runat="server" id="lbthongbao" style="color: #FF0000">
                </label>
            </div>
        </div>
    </div>
</asp:Content>
