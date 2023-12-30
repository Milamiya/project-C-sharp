<%@ Page Language="C#" MasterPageFile="~/ParentPage.Master" AutoEventWireup="true"
    CodeBehind="ParentPage.aspx.cs" Inherits="TestOnline.hy.vn.ParentPage1" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div style="text-align: left; height: 30px; padding-top: 7px; text-decoration: underline;
        font-weight: bold">
        CHỌN MÔN LUYỆN THI
    </div>
    <table width="100%">
        <tr style="height: 150px">
            <td>
                <a href="ParentPage.aspx?monthi=TiengAnh" style="padding-top: 17px; height: 104px">
                    <img src="Images/monthi/tienganh.jpg" /></a>
                <div style="height: 29">
                    <a style="margin-bottom: 7px; margin-left: 2px" href="ParentPage.aspx?monthi=TiengAnh">
                        Tiếng Anh</a>
                </div>
            </td>
            <td>
                <a href="ParentPage.aspx?monthi=SinhHoc" style="padding-top: 17px; height: 104px">
                    <img src="Images/monthi/sinhhoc.jpg" /></a>
                <div style="height: 29">
                    <a style="margin-bottom: 7px; margin-left: 6px" href="ParentPage.aspx?monthi=SinhHoc">
                        Sinh Học</a>
                </div>
            </td>
            <td>
                <a href="ParentPage.aspx?monthi=VatLy" style="padding-top: 17px; height: 104px">
                    <img src="Images/monthi/vatly.jpg" /></a>
                <div style="height: 29">
                    <a style="margin-bottom: 7px; margin-left: 10px" href="ParentPage.aspx?monthi=VatLy">
                        Vật Lý</a>
                </div>
            </td>
            <td>
                <a href="ParentPage.aspx?monthi=HoaHoc" style="padding-top: 17px; height: 104px">
                    <img src="Images/monthi/hoahoc.jpg" /></a>
                <div style="height: 29">
                    <a style="margin-bottom: 7px; margin-left: 8px" href="ParentPage.aspx?monthi=HoaHoc">
                        Hóa Học</a>
                </div>
            </td>
        </tr>
    </table>
    <hr style="color: Gray; margin-left: 10px; margin-right: 10px; border-bottom-width: thin" />
    <div style="text-align: left; height: 30px; padding-top: 7px; text-decoration: underline;
        font-weight: bold">
        CHỌN HÌNH THỨC THI
    </div>
    <div style="border: solid thin gray; width: 504px; float: left">
        <img src="Images/monthi/bannerthi.jpg" alt="Planets" usemap="#planetmap" style="width: 504px;
            height: 160px" />
        <map name="planetmap">
            <area shape="rect" coords="7, 9, 167, 41" alt="Sun" href="ParentPage.aspx" />
            <area shape="rect" coords="7, 114, 167, 147" alt="Sun" href="thionline.aspx" />
            <area shape="rect" coords="379,5, 500, 36" alt="Sun" href="QuyDinh.aspx" />
            <area shape="rect" coords="379,44, 500, 74" alt="Sun" href="giaithuong.aspx" />
            <area shape="rect" coords="379,81, 500, 111" alt="Sun" href="Lichthi.aspx" />
            <area shape="rect" coords="379,119, 500, 149" alt="Sun" href="Bangsephang.aspx" />
            <%-- <area shape="circle" coords="124,58,8" alt="Venus" href="venus.htm" />--%>
        </map>
    </div>
    <div style="clear: both; height: 15px; width: 100%">
    </div>
    <table style="width: 100%; height: 69px; border: solid thin gray" width="150px">
        <tr>
            <td style="height: 23px;" align="center" colspan="2">
                &nbsp;
            </td>
        </tr>
        <tr>
            <td style="height: 23px; font-size: 20px; color: Blue" align="center" colspan="2">
                Lựa chọn nội dung đề thi trắc nghiệm hình thức ôn luyện
            </td>
        </tr>
        <tr>
            <td style="height: 23px;" align="center" colspan="2">
                &nbsp;
            </td>
        </tr>
        <tr>
            <td style="height: 23px; width: 183px" align="left">
                Chọn môn :
            </td>
            <td style="height: 23px" align="left">
                <asp:dropdownlist id="ddlchonmon" runat="server" style="width: 200px">
                </asp:dropdownlist>
            </td>
        </tr>
        <tr>
            <%--  <td style="height: 23px; width: 183px" align="left">
                Hình thức thi :
            </td>
            <td style="height: 23px" align="left">
                <asp:dropdownlist id="DropDownList2" runat="server" style="width: 200px">
                </asp:dropdownlist>
            </td>--%>
        </tr>
        <tr>
            <td style="height: 23px; width: 183px" align="left">
                Số lượng câu hỏi :
            </td>
            <td style="height: 23px" align="left">
                <asp:dropdownlist id="ddlsoluongcauhoi" runat="server" style="width: 200px">
                </asp:dropdownlist>
            </td>
        </tr>
        <tr>
            <td style="height: 23px; width: 183px" align="left">
                Mức độ câu hỏi :
            </td>
            <td style="height: 23px" align="left">
                <asp:radiobuttonlist id="rdbmucdo" runat="server" repeatdirection="Horizontal" width="218px">
                    <asp:ListItem>Khó</asp:ListItem>
                    <asp:ListItem>Dễ</asp:ListItem>
                    <asp:ListItem>Trung bình</asp:ListItem>
                </asp:radiobuttonlist>
            </td>
        </tr>
        <tr>
            <td>
                <asp:button runat="server" id="Accept" text="Chọn đề" onclick="Accept_Click" />
            </td>
        </tr>
        <tr>
            <td style="height: 23px; width: 183px" align="left">
                Chọn đề :
            </td>
            <td style="height: 23px" align="left">
                <asp:dropdownlist id="ddlchonde" runat="server" width="200px">
                </asp:dropdownlist>
            </td>
        </tr>
        <tr>
            <td style="height: 23px; width: 183px" align="left">
                &nbsp;
            </td>
            <td style="height: 23px" align="left">
                &nbsp;
            </td>
        </tr>
        <tr>
            <td style="height: 23px;" align="center" colspan="2">
                <asp:button runat="server" id="btnStart" text="Bắt đầu thi" onclick="btnStart_Click" />
                <%--    <a  href="../test/Hometest.aspx?ThreadID=< "  style="text-decoration:none">
                <input  type=button value="Bắt đầu thi" onclick/>
                </a>--%>
            </td>
        </tr>
    </table>
</asp:Content>
