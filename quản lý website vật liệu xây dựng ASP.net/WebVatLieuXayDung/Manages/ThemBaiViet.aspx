<%@ Page Language="C#" MasterPageFile="~/Manages/MasterPageM.master" AutoEventWireup="true"
    CodeFile="ThemBaiViet.aspx.cs" Inherits="Manages_ThemBaiViet" Title="Untitled Page" %>

<%@ Register Assembly="FredCK.FCKeditorV2" Namespace="FredCK.FCKeditorV2" TagPrefix="FCKeditorV2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <style>
        .style1
        {
            text-align: right;
            margin-right: 5px;
        }
        .style2
        {
            padding: 3px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphMasterPageManages" runat="Server">
    <div>
        <div>
            <fieldset>
                <legend>Thông tin nhập</legend>
                <div style="float: left; width: 100%">
                    <table style="float: left">
                        <tr>
                            <td class="style1">
                                <b>Nhập tiêu đề của tin</b>
                            </td>
                            <td class="style2">
                                <asp:TextBox ID="txtTieuDe" runat="server" Width="278px"></asp:TextBox>
                                <%--<asp:RequiredFieldValidator ID="RequiredFieldValidator2" ControlToValidate="txtTieuDe"
                                    runat="server" ErrorMessage="Bạn chưa nhập tiêu đề tin"></asp:RequiredFieldValidator>--%>
                            </td>
                        </tr>
                        <tr>
                            <td class="style1">
                                <b>Mô tả ngắn gọn</b>
                            </td>
                            <td class="style2">
                                <asp:TextBox ID="txtMoTa" runat="server" Width="278px" Height="132px" Style="text-align: left;
                                    vertical-align: text-top; font-weight: 700;" TextMode="MultiLine"></asp:TextBox>
                                <%--  <asp:RequiredFieldValidator ID="RequiredFieldValidator3" ControlToValidate="txtMoTa"
                                    runat="server" ErrorMessage="Bạn chưa nhập mô tả tin"></asp:RequiredFieldValidator>--%>
                            </td>
                        </tr>
                        <tr>
                            <td class="style1">
                                <b>Người đăng: </b>
                            </td>
                            <td class="style2">
                                <asp:Label ID="lbNguoiDang" runat="server" Text="Label"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td class="style1">
                                <b>Từ khóa</b>
                            </td>
                            <td class="style2">
                                <asp:TextBox ID="txtTuKhoa" runat="server" Width="278px"></asp:TextBox>
                                <%--  <asp:RequiredFieldValidator ID="RequiredFieldValidator4" ControlToValidate="txtNguon"
                                    runat="server" ErrorMessage="Bạn chưa nhập nguồn tin"></asp:RequiredFieldValidator>--%>
                            </td>
                        </tr>
                        <tr>
                            <td class="style1">
                                <b>Tác giả / Nguồn</b>
                            </td>
                            <td class="style2">
                                <asp:TextBox ID="txtNguon" runat="server" Width="278px"></asp:TextBox>
                                <%--  <asp:RequiredFieldValidator ID="RequiredFieldValidator4" ControlToValidate="txtNguon"
                                    runat="server" ErrorMessage="Bạn chưa nhập nguồn tin"></asp:RequiredFieldValidator>--%>
                            </td>
                        </tr>
                        <tr>
                            <td class="style1">
                                <b>Hình ảnh</b>
                            </td>
                            <td class="style2">
                                <%-- <asp:ScriptManager ID="ScriptManager1" runat="server">
                                </asp:ScriptManager>
                                <asp:UpdatePanel ID="UpdatePanel1" runat="server">--%>
                                <%--<ContentTemplate>--%>
                                <asp:FileUpload ID="fuAnh" runat="server" />
                                <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="fuAnh"
                                    ErrorMessage="Không phải file ảnh" ValidationExpression="^([0-9a-zA-Z_\-~ :\\])+(.jpg|.JPG|.jpeg|.JPEG|.bmp|.BMP|.gif|.GIF|.png|.PNG)$"> 
                                </asp:RegularExpressionValidator>
                                &nbsp;&nbsp;&nbsp;
                                <asp:Button ID="btnUpLoad" runat="server" OnClick="btnUpLoad_Click" Text="Upload ảnh"
                                    Width="102px" />
                                <%-- </ContentTemplate>
                                </asp:UpdatePanel>--%>
                            </td>
                        </tr>
                        <tr>
                            <td>
                            </td>
                            <td>
                                &nbsp;</td>
                        </tr>
                    </table>
                    <div style="float: right; width: 230px; margin-top: 20px; margin-right: 100px; height: 180px">
                        <asp:Image ID="imAnh" Width="100%" Height="100%" runat="server" />
                    </div>
                </div>
            </fieldset>
        </div>
        &nbsp;</div>
    <div>
        <fieldset>
            <legend>Nội dung</legend>
            <div>
                <FCKeditorV2:FCKeditor ID="fckNoiDung" runat="server" BasePath="~/Manages/fckeditor/"
                    Width="100%">
                </FCKeditorV2:FCKeditor>
            </div>
        </fieldset>
    </div>
    <div style="text-align: center">
        <asp:Button ID="btnThem" runat="server" Text="Thêm Bài viết" OnClick="btnThem_Click"
            Height="40px" Width="129px" />
        &nbsp;&nbsp;
        <asp:Button ID="Thoát" runat="server" Text="Thoát" Width="111px" Height="40px" OnClick="Thoát_Click" />
    </div>
    </div>
</asp:Content>
