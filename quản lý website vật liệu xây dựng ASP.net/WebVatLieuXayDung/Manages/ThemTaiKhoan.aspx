<%@ Page Language="C#" MasterPageFile="~/Manages/Account.master" AutoEventWireup="true"
    CodeFile="ThemTaiKhoan.aspx.cs" Inherits="Manages_ThemTaiKhoan" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceBody" runat="Server">
    <link href="StyleAccount/AddAccount.css" rel="stylesheet" type="text/css" />
    <div id="divAccountInfo">
        <h3>
            ĐĂNG KÝ VÀO QUẢN TRỊ BÀI VIẾT</h3>
        <p>
            Ðể thêm mới tài khoản, bạn phải Đăng ký trước. Hãy điền đầy đủ những thông tin
            cần thiết ở dưới để hoàn tất việc Đăng ký. Tên đăng nhập chỉ bao gồm Ký tự thường
            A-Z và chữ số 0-9. Không bao gồm các ký tự lạ, dấu và khoảng cách.</p>
        <fieldset style="padding: 10px;">
            <legend>Thông tin tài khoản</legend>
            <p style="font-weight: bolder;">
                Tên Đăng nhập: không được chứa dấu cách và đặc biệt là không được sử dụng
                các ký tự [/,:,\,*,+,?,=,"",<>,|,',{,},;,~,!,#,$,@,%,^,&,*,(),.]
            </p>
            <asp:TextBox runat="server" ID="txtPersonPostNewCode"></asp:TextBox>&nbsp;
            <label id="lblPersonPostNewCode" runat="server">
            </label>
        </fieldset>
        <fieldset style="padding: 10px;">
            <legend>Mật khẩu</legend>
            <p style="font-weight: bolder;">
                Xin chọn Mật khẩu cho Tài khoản của bạn. Chú ý: Mật khẩu không được chứa ký tự
                ' và ; đặc biệt là được phân biệt bởi chữ 'thường' và 'HOA'.
            </p>
            <table width="100%">
                <tr>
                    <td colspan="2">
                        Mật khẩu
                    </td>
                    <td colspan="2">
                        Xác nhận mật khẩu
                    </td>
                </tr>
                <tr>
                    <td class="tdleft">
                        <asp:TextBox runat="server" ID="txtPassWord" TextMode="Password" />
                    </td>
                    <td class="tdcenter1">
                        <label id="lblPassWord">
                        </label>
                    </td>
                    <td class="tdcenter2">
                        <input type="password" id="txtRePassWord" />
                    </td>
                    <td class="tdright">
                        <label id="lblRePassWord" />
                    </td>
                </tr>
            </table>
        </fieldset>
        <fieldset style="padding: 10px;">
            <legend>Địa chỉ email</legend>
            <p style="font-weight: bolder;">
                Nhập địa chỉ email hiện đang sử dụng!</p>
            <table width="100%">
                <tr>
                    <td colspan="2">
                        Email
                    </td>
                    <td colspan="2">
                        Xác nhận Email
                    </td>
                </tr>
                <tr>
                    <td class="tdleft">
                        <asp:TextBox runat="server" ID="txtEmail" />
                    </td>
                    <td class="tdcenter1">
                        <label id="lblEmail" runat="server">
                        </label>
                    </td>
                    <td class="tdcenter2">
                        <input type="text" id="txtReEmail" />
                    </td>
                    <td class="tdright">
                        <label id="lblReEmail">
                        </label>
                    </td>
                </tr>
            </table>
        </fieldset>
       
    </div>
    <!--end divAccountInfo-->
    <!--Vùng thông tin cá nhân-->
    <div id="divPersonalInfo">
        <h3>
            THÔNG TIN CÁ NHÂN</h3>
        <fieldset style="padding: 10px; width: 98%;">
            <legend>Thông tin cá nhân</legend>
            <table width="100%">
                <tr style="width: 100%">
                    <td class="tdleftforPersonalInfo">
                        Họ tên:
                    </td>
                    <td class="tdcenter1">
                        <asp:TextBox ID="txtName" runat="server" Width="100%" />
                    </td>
                    <td>
                        <label id="lblName">
                        </label>
                    </td>
                </tr>
                <tr>
                    <td class="tdleftforPersonalInfo" style="height: 34px">
                        Ngày sinh:
                    </td>
                    <td class="tdcenter1" style="height: 34px">
                        <asp:TextBox ID="txtBirthDay" runat="server" Width="100%" />
                    </td>
                    <td style="height: 34px">
                        <label id="lblBirthDay">
                        </label>
                    </td>
                </tr>
                <tr>
                    <td class="tdleftforPersonalInfo" style="height: 34px">
                        Giới tính:
                    </td>
                    <td class="tdcenter1" style="height: 34px">
                        <asp:RadioButton GroupName="rdGender" Width="10%" ID="rdMale" runat="server" Checked="true" />Nam
                        &nbsp;
                        <asp:RadioButton GroupName="rdGender" Width="10%" ID="rdFemale" runat="server" />Nữ
                    </td>
                    <td style="height: 34px">
                    </td>
                </tr>
                <tr>
                    <td class="tdleftforPersonalInfo" style="height: 34px">
                        Số ĐT:
                    </td>
                    <td class="tdcenter1" style="height: 34px">
                        <asp:TextBox ID="txtPhoneNumber" runat="server" Width="100%" />
                    </td>
                    <td style="height: 34px">
                        <label id="lblPhoneNumber">
                        </label>
                    </td>
                </tr>
                <tr>
                    <td class="tdleftforPersonalInfo">
                        Địa chỉ liên lạc:
                    </td>
                    <td colspan="2">
                        <asp:TextBox ID="txtHomeTown" runat="server" Width="50%" />
                    </td>
                </tr>
                <tr>
                    <td class="tdleftforPersonalInfo">
                        &nbsp;
                    </td>
                    <td colspan="2">
                        <label id="lblHomeTown">
                        </label>
                    </td>
                </tr>
            </table>
        </fieldset>
    </div>
    <div id="contentbutton">
        <span onclick="return Register();">
            <asp:Button runat="server" Text="Đăng ký" ID="btnRegister" OnClick="btnRegister_Click" />
        </span>&nbsp;
        <input type="button" value="Nhập lại" onclick="Reset();" />
    </div>
</asp:Content>
