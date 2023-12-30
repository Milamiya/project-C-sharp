<%@ Page Language="C#" MasterPageFile="~/Manages/Account.master" AutoEventWireup="true"
    CodeFile="SuaTaiKhoan.aspx.cs" Inherits="Manages_SuaTaiKhoan" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceBody" runat="Server">
    <link href="StyleAccount/EditAccount.css" rel="stylesheet" type="text/css" />
    <div id="divcontent">
        <table width="100%">
            <tr>
                <td class="tdleft">
                    Tài khoản:
                </td>
                <td class="tdcenter">
                    <asp:Label ID="lbTaiKhoan" runat="server" Text="Label"></asp:Label>
                    <label id="lblPersonPostNewCode" runat="server">
                    </label>
                </td>
                <td class="tdright">
                    &nbsp;
                </td>
            </tr>
            <tr>
                <td class="tdleft">
                    Họ tên:
                </td>
                <td class="tdcenter">
                    <asp:TextBox ID="txtName" runat="server" Width="90%"></asp:TextBox>
                </td>
                <td class="tdright">
                    <label id="lblName">
                    </label>
                </td>
            </tr>
            <tr>
                <td class="tdleft">
                    Ngày sinh:
                </td>
                <td class="tdcenter">
                    <asp:TextBox ID="txtBirthDay" runat="server" Width="90%"></asp:TextBox>
                </td>
                <td class="tdright">
                    <label id="lblBirthDay">
                    </label>
                </td>
            </tr>
            <tr>
                <td class="tdleft">
                    Quê quán:
                </td>
                <td class="tdcenter">
                    <asp:TextBox ID="txtHomeTown" runat="server" Width="90%"></asp:TextBox>
                </td>
                <td class="tdright">
                    <label id="lblHomeTown">
                    </label>
                </td>
            </tr>
            <tr>
                <td class="tdleft">
                    Giới tính:
                </td>
                <td class="tdcenter">
                    <asp:RadioButton Width="5%" runat="server" ID="rdMale" Checked="true" GroupName="rdGender"
                        Text="Nam" />
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:RadioButton Width="5%" runat="server" ID="rdFemale" GroupName="rdGender" Text="Nữ" />
                </td>
                <td class="tdright">
                    <label id="lbGender">
                    </label>
                </td>
            </tr>
            <tr>
                <td class="tdleft">
                    Số ĐT liên lạc:
                </td>
                <td class="tdcenter">
                    <asp:TextBox ID="txtPhoneNumber" runat="server" Width="90%"></asp:TextBox>
                </td>
                <td class="tdright">
                    <label id="lblPhoneNumber">
                    </label>
                </td>
            </tr>
            <tr>
                <td class="tdleft">
                    Email :
                </td>
                <td class="tdcenter">
                    <asp:TextBox ID="txtEmail" runat="server" Width="90%"></asp:TextBox>
                </td>
                <td class="tdright">
                    <label id="lblEmail" runat="server">
                    </label>
                </td>
            </tr>
            <tr>
                <td class="tdleft">
                    &nbsp;
                </td>
                <td colspan="2">
                    <span style="color: Red;">
                        <label id="lblUpdateInformation" runat="server">
                        </label>
                    </span>
                </td>
            </tr>
            <tr>
                <td class="tdleft">
                    &nbsp;
                </td>
                <td class="tdcenter">
                    <span onclick="return UpdateInformation();">
                        <asp:Button runat="server" Text="Cập nhật" ID="btnUpdateInfomation" OnClick="btnUpdateInfomation_Click"
                            Style="height: 26px" />
                    </span>
                </td>
            </tr>
        </table>
    </div>
</asp:Content>
