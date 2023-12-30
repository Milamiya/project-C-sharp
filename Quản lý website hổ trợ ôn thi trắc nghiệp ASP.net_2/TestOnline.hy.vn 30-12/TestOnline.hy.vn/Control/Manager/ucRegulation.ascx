<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ucRegulation.ascx.cs"
    Inherits="TestOnline.hy.vn.Control.Manager.ucRegulation" %>
<style type="text/css">
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
    .Sj_Khung
    {
        width: 974px;
        border: solid 3px #3366CC;
        font: 500 14px Arial;
    }
    .ucDepartment-right
    {
        width: 1175px;
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
    .ucDepartment_text1
    {
        width: 200px;
        float: left;
        margin-right: 5px;
    }
</style>

<script src="../../Js/GridViewPreView.js" type="text/javascript"></script>

<div class="Sj_Khung">
    <div class="menuTittleTop">
        <asp:Button ID="btnRefresh" runat="server" Width="110px" Text="Tạo mới" OnClick="btnRefresh_Click" />
        <asp:Button ID="btnCreateNews" Width="110px" runat="server" Text="Thêm mới" OnClick="btnCreateNews_Click" />
        <asp:Button ID="btnEdit1" Width="110px" runat="server" Text="Sưa tin" OnClick="btnEdit1_Click" />
        <asp:Button ID="btnDeleteAll" runat="server" Width="110px" Text="Xóa hàng chọn" OnClick="btnDeleteAll_Click" />
        <asp:Label ID="lblThongBao" runat="server" ForeColor="Black" Font-Bold="True"></asp:Label>
    </div>
    <div style="width: 1000px; margin-top: 10px">
        <div class="ucDepartment_lable">
            Năm tuyển sinh:(*)</div>
        <div style="float: left">
            <asp:DropDownList runat="server" ID="ddlYear" Width="535px">
            </asp:DropDownList>
        </div>
    </div>
    <br />
    <br />
    <div style="width: 1000px;">
        <div class="ucDepartment_lable">
            Tiêu đề:(*)</div>
        <div style="float: left">
            <asp:TextBox ID="txtTitle" Width="530px" runat="server"></asp:TextBox></div>
    </div>
    <br />
    <div style="width: 1000px; margin-top: 10px">
    <div class="ucDepartment_lable">
        Đường dẫn:(*)
    </div>
    <div style="float: left">
        <asp:FileUpload ID="fulFile" runat="server" />
    </div>
    <div class="ucDepartment_lable">
        Ngày tạo:(*)
    </div>
    <div class="ucDepartment_text1">
        <asp:TextBox ID="txtCreateDate" Width="200px" runat="server" ReadOnly="True"></asp:TextBox></div>
</div>
    <br />
    <br />
    <br />
    <br />
    <%--!Bắt đầu gridview--%>
    <div style="margin: 5px 5px 5px 5px; width: 960px">
        <asp:GridView ID="grvRagulation" runat="server" Width="100%" AutoGenerateColumns="False"
            AllowPaging="True" CellPadding="0" ForeColor="#333333" OnPageIndexChanging="grvRagulation_PageIndexChanging"
            OnRowCommand="grvRagulation_RowCommand" OnRowCreated="grvRagulation_RowCreated"
            OnRowDataBound="grvRagulation_RowDataBound" OnRowDeleting="grvRagulation_RowDeleting"
            OnRowEditing="grvRagulation_RowEditing">
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
                <asp:BoundField DataField="Year" HeaderText="Năm tuyển sinh" HeaderStyle-CssClass="ucDepartment_gridview_Center">
                    <HeaderStyle CssClass="ucDepartment_gridview_Center"></HeaderStyle>
                </asp:BoundField>
                <asp:BoundField DataField="Titile" HeaderText="Tiêu đề" HeaderStyle-CssClass="ucDepartment_gridview_Center">
                    <HeaderStyle CssClass="ucDepartment_gridview_Center"></HeaderStyle>
                </asp:BoundField>
                <asp:BoundField DataField="Url" HeaderText="Đường dẫn" HeaderStyle-CssClass="ucDepartment_gridview_Center">
                    <HeaderStyle CssClass="ucDepartment_gridview_Center"></HeaderStyle>
                </asp:BoundField>
                <asp:BoundField DataField="CreateDate" HeaderText="Ngày tạo" HeaderStyle-CssClass="ucDepartment_gridview_Center">
                    <HeaderStyle CssClass="ucDepartment_gridview_Center"></HeaderStyle>
                </asp:BoundField>
                <asp:TemplateField HeaderStyle-Width="5%" HeaderText="Sửa">
                    <ItemTemplate>
                        <asp:LinkButton ID="btnSua" runat="server" CommandArgument='<%#DataBinder.Eval(Container.DataItem,"RegulationID")%>'
                            CommandName="Edit" ToolTip="Sửa tin" Text="Sửa"><img height="20px" src="../../Images/LinkButton/edit-icon.png" 
                                                    style="border-style:none;" width="20px" /></img></asp:LinkButton>
                    </ItemTemplate>
                    <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                    <HeaderStyle Width="40px" CssClass="ucDepartment_gridview_Center" HorizontalAlign="Center" />
                </asp:TemplateField>
                <asp:TemplateField HeaderStyle-Width="30px" HeaderText="Xóa">
                    <ItemTemplate>
                        <asp:LinkButton ID="btnXoa" runat="server" CommandArgument='<%#DataBinder.Eval(Container.DataItem,"RegulationID")%>'
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
    <div class="menuTittleBottom">
        <asp:Button ID="Button1" runat="server" Width="110px" Text="Tạo mới" />
        <asp:Button ID="Button2" Width="110px" runat="server" Text="Thêm mới" />
        <asp:Button ID="Button3" Width="110px" runat="server" Text="Sưa tin" />
        <asp:Button ID="Button4" runat="server" Width="110px" Text="Xóa hàng chọn" />
        <asp:Label ID="Label1" runat="server" ForeColor="Black" Font-Bold="True"></asp:Label>
    </div>
</div>
