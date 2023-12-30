<%@ Page Language="C#" MasterPageFile="~/admin/AdminMaster.master" AutoEventWireup="true" CodeFile="VietBai.aspx.cs" Inherits="admin_VietBai" Title="Untitled Page" %>
<%@ Register Assembly="FredCK.FCKeditorV2" Namespace="FredCK.FCKeditorV2" TagPrefix="FCKeditorV2" %>

<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="cc1" %>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <table table cellpadding="2" cellspacing="1" border="0" align="center" style="background-color: #93DCFF">
        <tr>
            <td colspan="2" style="width: 100%; background-color: #006699; color: #FFFFFF; font-weight: bold;"
                align="center" height="25">
                Quản lý bài viết :: Viết bài
            </td>
        </tr>
        <tr>
            <td style="background-color: #FFF;" align="left" class="style7">
                <b>Tiêu đề:</b>
            </td>
            <td style="width: 85%; background-color: #FFFFFF;" align="left">
                <asp:TextBox ID="txtTitle" runat="server" Width="500px" 
                    style="margin-left: 0px"></asp:TextBox>
                <asp:HiddenField ID="hidUser" runat="server" />
            </td>
        </tr>
        <tr>
            <td style="background-color: #FFF;" align="left" class="style7">
                Chuyên mục:
            </td>
            <td style="width: 85%; background-color: #FFFFFF;" align="left">
                <asp:DropDownList ID="drChuyenMuc" runat="server" Width="250px" 
                    AppendDataBoundItems="True">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td style="background-color: #FFF;" align="left" class="style7">
                Ảnh đại diện:
            </td>
            <td style="width: 85%; background-color: #FFFFFF;" align="left">
                <asp:FileUpload ID="picUp" runat="server" />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Image ID="imagePic" runat="server" Visible="False" />
                &nbsp;&nbsp;
                <asp:Button ID="butThayAnh" runat="server" Text="Ảnh khác" 
                    CssClass="buttonLogin" onclick="butThayAnh_Click" />
            </td>
        </tr>
        <tr>
            <td style="background-color: #FFF;" align="left" class="style7">
                Miêu tả:
            </td>
            <td style="width:85%; background-color: #FFFFFF;" align="left">
                <asp:TextBox ID="txtMieuTa" runat="server" Height="74px" TextMode="MultiLine" 
                    Width="651px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="background-color: #FFFFFF;" align="left" class="style7">
                Nội dung
            </td>
            <td style="width: 85%; background-color: #FFFFFF;" align="left">
                <FCKeditorV2:FCKeditor ID="fckNoiDung" BasePath="../fckeditor/ " Height="320px"  ToolbarSet="EditorSimple" runat="server">
                </FCKeditorV2:FCKeditor>
               <%-- <FCKeditorV2:FCKeditor ID="fckNoiDung" runat="server" BasePath="../fckeditor/"
                    Height="320px" ToolbarSet="EditorSimple">
                </FCKeditorV2:FCKeditor>--%>
            </td>
        </tr>
        <tr>
            <td style="background-color: #FFF;" align="left" class="style7">
                Tác giả:
            </td>
            <td style="width: 85%; background-color: #FFFFFF;" align="left">
                <asp:TextBox ID="txtTacGia" runat="server" Width="200px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="background-color: #FFF;" align="left" class="style7">
                Liên kết:
            </td>
            <td style="width: 85%; background-color: #FFFFFF;" align="left">
                <asp:TextBox ID="txtLienKet" runat="server" Width="200px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="background-color: #FFF;" align="left" class="style7">
                Thời gian viết:
            </td>
            <td style="width: 85%; background-color: #FFFFFF;" align="left">
                <asp:TextBox ID="txtThoiGian" runat="server" Width="200px"></asp:TextBox>
                <cc1:CalendarExtender ID="txtThoiGian_CalendarExtender" runat="server" 
                    Enabled="True" TargetControlID="txtThoiGian">
                </cc1:CalendarExtender>
            </td>
        </tr>
        <tr>
            <td style="background-color: #FFF;" align="left" class="style7">
                Phản hồi
            </td>
            <td style="width: 85%; background-color: #FFFFFF;" align="left">
                &nbsp;
                <asp:RadioButton ID="rdoChoPhep" runat="server" Text="Cho Phép" 
                    GroupName="FeedBack" />
&nbsp;&nbsp;
                <asp:RadioButton ID="rdoKhongCHoPhep" runat="server" Text="Không cho phép" 
                    GroupName="FeedBack" />
            </td>
        </tr>
        <tr>
            <td style="background-color: #FFF;" align="left" class="style7">
                Từ khóa
            </td>
            <td style="width: 85%; background-color: #FFFFFF;" align="left">
                <asp:TextBox ID="txtTuKhoa" runat="server" Width="200px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td colspan="2" style="width: 15%; background-color: #FFF;" align="left" id="c" 
                class="buttonLogin">
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:CheckBox ID="chkDang" runat="server" Text="Đăng ngay" />
&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:CheckBox ID="chkDuyet" runat="server" Text="Duyệt ngay" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="butGuiBai" runat="server" Text="Gửi bài viết" 
                    style="height: 26px" onclick="butGuiBai_Click" />
            </td>
        </tr>
    </table>
</asp:Content>

