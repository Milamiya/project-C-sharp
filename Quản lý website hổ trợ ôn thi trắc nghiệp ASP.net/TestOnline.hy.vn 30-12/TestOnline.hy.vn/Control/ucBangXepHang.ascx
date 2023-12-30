<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ucBangXepHang.ascx.cs"
    Inherits="TestOnline.hy.vn.Control.ucBangXepHang" %>
<style type="text/css">
    .Sj_Khung
    {
        width: 974px;
        border: solid 3px #3366CC;
        font: 500 15px Arial;
    }
    .ucDepartment-right
    {
        width: 1173px;
        float: left;
    }
    .ucDepartment_gridview_Start
    {
        border-left: solid 1px black;
        border-top: solid 1px black;
    }
    .ucDepartment_gridview_End
    {
        border-right: solid 1px black;
        border-top: solid 1px black;
    }
    .ucDepartment_gridview_Center
    {
        border-top: solid 1px black;
    }
    .ucDepartment_lable
    {
        float: left;
        width: 120px;
        margin-left: 5px;
    }
    .ucDepartment_text
    {
        width: 300px;
        float: left;
        margin-right: 5px;
    }
    .menuTittleTop
    {
        padding: 10px 10px 10px 10px;
        background-color: #BFDBFF;
        margin: 0px 0px 5px 0px;
    }
    .menuTittleBottom
    {
        padding: 10px 10px 10px 10px;
        background-color: #BFDBFF;
        margin: 1px 0px 0px 0px;
        vertical-align: bottom;
    }
</style>
<div style="text-align:center">Chọn môn: &nbsp <asp:DropDownList runat="server" 
        DataTextField="SubjectName" DataValueField="SubjectID" ID="ddlSubject"  Width="200px"
        onselectedindexchanged="ddlSubject_SelectedIndexChanged" 
        AutoPostBack="True"></asp:DropDownList>  Chọn đợt thi: &nbsp<asp:DropDownList runat="server" 
        DataTextField="TheadName" DataValueField="ThreadsID" ID="ddlSelect"  Width="200px"
        onselectedindexchanged="ddlSelect_SelectedIndexChanged" 
        AutoPostBack="True"></asp:DropDownList></div>
<%--!Bắt đầu gridview--%>
<div style="margin: 5px 10px 5px 5px; width:710px">
    <asp:GridView ID="grvStudent" runat="server" Width="100%" AutoGenerateColumns="False"
        CellPadding="0" ForeColor="#333333" 
       >
        <RowStyle BackColor="#EFF3FB" />
        <Columns>
            <asp:TemplateField HeaderText="STT" HeaderStyle-HorizontalAlign="Center">
                <ItemTemplate>
                    <%# Container.DataItemIndex+1%>
                </ItemTemplate>
                <HeaderStyle HorizontalAlign="Center" CssClass="ucDepartment_gridview_Start" Width="40px">
                </HeaderStyle>
                <ItemStyle HorizontalAlign="Center" Width="40px" />
            </asp:TemplateField>
            <asp:BoundField DataField="StudentID" HeaderText="Tài khoản" 
                HeaderStyle-CssClass="ucDepartment_gridview_Center">
                <HeaderStyle CssClass="ucDepartment_gridview_Center"></HeaderStyle>
            </asp:BoundField>
            <asp:BoundField DataField="StudentName" HeaderText="Tên thành viên" HeaderStyle-CssClass="ucDepartment_gridview_Center">
                <HeaderStyle CssClass="ucDepartment_gridview_Center"></HeaderStyle>
            </asp:BoundField>
            <asp:BoundField DataField="Birthday" HeaderText="Ngày sinh" HeaderStyle-CssClass="ucDepartment_gridview_Center">
                <HeaderStyle CssClass="ucDepartment_gridview_Center"></HeaderStyle>
            </asp:BoundField>
            <asp:BoundField DataField="RegistrationDate" HeaderText="Ngày đăng ký" HeaderStyle-CssClass="ucDepartment_gridview_Center">
                <HeaderStyle CssClass="ucDepartment_gridview_Center"></HeaderStyle>
            </asp:BoundField>
            <asp:BoundField DataField="Email" HeaderText="Email" 
                HeaderStyle-CssClass="ucDepartment_gridview_Center" >
<HeaderStyle CssClass="ucDepartment_gridview_Center"></HeaderStyle>
            </asp:BoundField>
            <asp:BoundField DataField="City" HeaderText="Thành phố" 
                HeaderStyle-CssClass="ucDepartment_gridview_Center">
<HeaderStyle CssClass="ucDepartment_gridview_Center"></HeaderStyle>
            </asp:BoundField>
            <asp:BoundField DataField="Score" HeaderText="Điểm" 
                HeaderStyle-CssClass="ucDepartment_gridview_End" >
<HeaderStyle CssClass="ucDepartment_gridview_End"></HeaderStyle>
            </asp:BoundField>
        </Columns>
        <HeaderStyle Height="25px" />
        <PagerStyle BackColor="#BFDBFF" ForeColor="Black" HorizontalAlign="Center" />
        <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
        <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" VerticalAlign="Middle" />
        <EditRowStyle BackColor="#2461BF" />
        <AlternatingRowStyle BackColor="White" />
    </asp:GridView>
</div>
