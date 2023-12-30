<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ucManagerCommand.ascx.cs" Inherits="TestOnline.hy.vn.Control.Manager.ucManagerCommand" %>
<style type="text/css">
    .Sj_Khung
    {
        width: 974px;
        border: solid 3px #3366CC; font:500 15px Arial;
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
<asp:ScriptManager runat="server" ID="ScriptManager1">
</asp:ScriptManager>

<script src="../../Js/Calendar.js" type="text/javascript"></script>

<script src="../../Js/GridViewPreView.js" type="text/javascript"></script>

<link href="../../Style/Calendar.css" rel="stylesheet" type="text/css" />
<div class="Sj_Khung">
    <div class="menuTittleTop">
        <asp:Button ID="btnDeleteAll" runat="server" Width="110px" Text="Xóa hàng chọn" OnClick="btnDeleteAll_Click" />
        <asp:Label ID="lblThongBao" runat="server" ForeColor="Black" Font-Bold="True"></asp:Label>
    </div>
   
    <%--!Bắt đầu gridview--%>
    <div style="margin: 5px 10px 5px 5px; width:960px">
        <asp:GridView ID="grvCommand" runat="server" Width="100%" AutoGenerateColumns="False"
            AllowPaging="True" CellPadding="0" ForeColor="#333333" 
            onpageindexchanging="grvCommand_PageIndexChanging" 
            onrowcommand="grvCommand_RowCommand" onrowcreated="grvCommand_RowCreated" 
            onrowdatabound="grvCommand_RowDataBound" onrowdeleting="grvCommand_RowDeleting">
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
                <asp:TemplateField HeaderText="Chọn" HeaderStyle-HorizontalAlign="Center">
                    <HeaderTemplate>
                        <asp:CheckBox ID="cbSelectAll" runat="server" />
                    </HeaderTemplate>
                    <ItemTemplate>
                        <asp:CheckBox ID="chkSelect" runat="server" />
                    </ItemTemplate>
                    <HeaderStyle HorizontalAlign="Center" CssClass="ucDepartment_gridview_Center" Width="40px">
                    </HeaderStyle>
                    <ItemStyle HorizontalAlign="Center" />
                </asp:TemplateField>
                <asp:BoundField DataField="StudentID" HeaderText="Mã thành viên" 
                    HeaderStyle-CssClass="ucDepartment_gridview_Center">
                    <HeaderStyle CssClass="ucDepartment_gridview_Center"></HeaderStyle>
                </asp:BoundField>
                <asp:BoundField DataField="CommandName" HeaderText="Nội dung" 
                    HeaderStyle-CssClass="ucDepartment_gridview_Center">
                    <HeaderStyle CssClass="ucDepartment_gridview_Center"></HeaderStyle>
                </asp:BoundField>
                <asp:BoundField DataField="CreateDate" HeaderText="Ngày gửi" 
                    HeaderStyle-CssClass="ucDepartment_gridview_Center">
                    <HeaderStyle CssClass="ucDepartment_gridview_Center" ></HeaderStyle>
                </asp:BoundField>
                <asp:TemplateField HeaderStyle-Width="30px" HeaderText="Xóa">
                    <ItemTemplate>
                        <asp:LinkButton ID="btnXoa" runat="server" CommandArgument='<%#DataBinder.Eval(Container.DataItem,"CommandID")%>'
                            CommandName="Delete" ToolTip="Xóa bản ghi" OnClientClick="return confirm('Bạn chắc chắn muốn xoá?')">  
                            <img  height="20px" src="../../Images/LinkButton/thunggiac.png" style="border-style:none ; text-align :center ;"  
                                                    width="20px"  /> </img></asp:LinkButton>
                    </ItemTemplate>
                    <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                    <HeaderStyle Width="40px" CssClass="ucDepartment_gridview_End" HorizontalAlign="Center" />
                </asp:TemplateField>
            </Columns>
            <HeaderStyle Height="25px" />
            <PagerStyle BackColor="#BFDBFF" ForeColor="Black" HorizontalAlign="Center" />
            <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
            <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" VerticalAlign="Middle" />
            <EditRowStyle BackColor="#2461BF" />
            <AlternatingRowStyle BackColor="White" />
        </asp:GridView>
    </div>
</div>
