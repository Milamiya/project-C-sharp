<%@ Page Language="C#" MasterPageFile="~/admin.master" AutoEventWireup="true" 
CodeFile="themsp.aspx.cs" Inherits="Default3" Title="themsp" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <span style="font-size: 24pt"><h1 align="center"><b>THÊM SẢN PHẨM</b></h1>
    </span>
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
             <ContentTemplate>
             <asp:Panel ID="Panel1" runat="server">
    
            <TABLE style="WIDTH: 100%; COLOR: black; HEIGHT: 30%" cellSpacing=0 cellPadding=0 
            width="30%" align=right frame=void>
                <TBODY>
                    <TR>
                        <TD style="WIDTH: 164px; HEIGHT: 24px; TEXT-ALIGN: left">
                            <asp:Label id="Label3" runat="server" Text="Mã sản phẩm:" ForeColor="black"></asp:Label>
                        </TD>
                        <TD style="WIDTH: 237px; HEIGHT: 24px">
                            <asp:TextBox style="MARGIN-LEFT: 0px" id="txtmasp" runat="server" Width="80%"></asp:TextBox>
                            <BR />
                            &nbsp;
                        </TD>
                    </TR>
                    <TR>
                        <TD style="WIDTH: 164px; TEXT-ALIGN: left; height: 20px;">
                            <asp:Label id="Label2" runat="server" Text="Mã hàng" 
                    ForeColor="black"></asp:Label>
                        </TD>
                        <TD style="WIDTH: 237px; TEXT-ALIGN: left; height: 20px;">
                            <asp:DropDownList id="DropDownList1" runat="server" Width="80%" 
                        DataSourceID="AccessDataSource1" DataTextField="tenhang" 
                        DataValueField="mahang">
                            </asp:DropDownList>
                            &nbsp;
                            <asp:AccessDataSource id="AccessDataSource1" runat="server" 
                        SelectCommand="SELECT * FROM [tblhang]" 
                        DataFile="~/App_Data/dienthoaididong.mdb"></asp:AccessDataSource>
                        </TD>
                    </TR>
                    <TR>
                        <TD style="WIDTH: 164px; TEXT-ALIGN: left; height: 3px;">
                            <asp:Label id="Label4" runat="server" Text="Tên sản phẩm" 
                    ForeColor="black"></asp:Label>
                        </TD>
                        <TD style="WIDTH: 237px; height: 3px;">
                            <asp:TextBox id="Txttensp" 
                        tabIndex=2 runat="server" Width="80%"></asp:TextBox>
                            &nbsp;<BR />
&nbsp;</TD>
                    </TR>
                    <TR>
                        <TD style="WIDTH: 164px; TEXT-ALIGN: left; height: 23px;">
                            <asp:Label id="Label5" runat="server" Text="Giá" ForeColor="black"></asp:Label>
                        </TD>
                        <TD style="WIDTH: 237px; height: 23px;">
                            <asp:TextBox id="txtgia" tabIndex=6 runat="server" 
                        Width="80%"></asp:TextBox>
                            &nbsp;
                            <BR />
                        </TD>
                    </TR>
                    <TR>
                        <TD style="WIDTH: 164px; HEIGHT: 20px; TEXT-ALIGN: left">
                            <asp:Label id="Label6" runat="server" Text="Số lượng" ForeColor="black"></asp:Label>
                        </TD>
                        <TD style="WIDTH: 237px; HEIGHT: 20px">
                            <asp:TextBox id="txtsl" tabIndex=4 runat="server" Width="80%"></asp:TextBox>
                            &nbsp;
                            <BR />
                        </TD>
                    </TR>
                    <TR>
                        <TD style="WIDTH: 164px; HEIGHT: 28px; TEXT-ALIGN: left; color: Black">
                            Đặc điểm:</TD>
                        <TD style="WIDTH: 237px; HEIGHT: 28px">
                            <asp:TextBox id="txtdd" tabIndex=6 runat="server" 
                        Width="80%"></asp:TextBox>
                        </TD>
                    </TR>
                    <TR>
                        <TD style="WIDTH: 164px; TEXT-ALIGN: left; height: 11px;color: Black">
                            Bảo hành</TD>
                        <TD style="WIDTH: 237px; height: 11px;">
                            <asp:TextBox id="txtbh" tabIndex=6 runat="server" 
                        Width="80%"></asp:TextBox>
                        </TD>
                    </TR>
                    <TR>
                        <TD style="WIDTH: 164px; HEIGHT: 30px; TEXT-ALIGN: left;color: Black">
                            Khuyến mại</TD>
                        <TD style="WIDTH: 237px; HEIGHT: 30px">
                            <asp:TextBox id="txtkm" tabIndex=6 runat="server" Width="80%"></asp:TextBox>
                        </TD>
                    </TR>
                    <TR>
                        <TD style="WIDTH: 164px; TEXT-ALIGN: left; height: 18px;">
                            <asp:Label id="Label7" runat="server" 
                    Text="Kiểu dáng" ForeColor="black"></asp:Label>
                        </TD>
                        <TD style="WIDTH: 237px; height: 18px;">
                            <asp:TextBox id="txtkd" tabIndex=6 
                        runat="server" Width="80%"></asp:TextBox>
                            <BR />
                        </TD>
                    </TR>
                    <TR>
                        <TD style="WIDTH: 164px; TEXT-ALIGN: left; height: 7px;color: Black">
                            Phong cách</TD>
                        <TD style="WIDTH: 237px; height: 7px;">
                            <asp:TextBox id="Txtpc" 
                        runat="server" Width="80%"></asp:TextBox>
                        </TD>
                    </TR>
                    <TR>
                        <TD style="WIDTH: 164px; HEIGHT: 19px; TEXT-ALIGN: left;color: Black">
                            Ảnh</TD>
                        <TD style="WIDTH: 237px; HEIGHT: 19px">
                            <asp:TextBox id="Txtanh" runat="server" Width="80%"></asp:TextBox>
                            <br />
                            <asp:FileUpload ID="FileUpload1" runat="server" />
                        </TD>
                    </TR>
                    <TR>
                        <TD style="WIDTH: 164px; HEIGHT: 19px; TEXT-ALIGN: left;color: Black">
                            Ghi chú</TD>
                        <TD style="WIDTH: 237px; HEIGHT: 19px">
                            <asp:TextBox id="Txtghichu" runat="server" Width="80%"></asp:TextBox>
                        </TD>
                    </TR>
                    <TR>
                        <TD colSpan=2>
                            &nbsp;<asp:Label ID="Lbltb" runat="server" ForeColor="Black"></asp:Label>
                        </TD>
                    </TR>
                    <TR>
                        <TD style="WIDTH: 164px; HEIGHT: 24px">
                            &nbsp;</TD>
                        <TD style="WIDTH: 237px; HEIGHT: 24px">
                            <asp:Button id="btndangky" onclick="btndangky_Click" 
                        runat="server" Width="86px" Text="Thêm mới" Font-Bold="true"></asp:Button>
                        </TD>
                    </TR>
                </TBODY>
            </TABLE>
            </asp:Panel>
        </ContentTemplate>
    </asp:UpdatePanel>
    
   
    
</asp:Content>

