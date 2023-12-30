<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ucSubject.ascx.cs" Inherits="TestOnline.hy.vn.Control.Manager.ucSubject" %>
<style type="text/css">
    .Sj_Khung
    {
        width:974px;
        border: solid 5px #3366CC; font:500 14px Arial;
    }
    .Sj_lable
    {
        font: 500 14px Arial;
        padding-left: 5px;
        text-align:left;
        width:120px;
    }
    .Sj_textbox
    {
        width:250px;
    }
</style>
<div class="Sj_Khung">
    <div style="padding: 10px 10px; background-color: #BFDBFF;">
        <asp:Button ID="btnCreateNews" runat="server" Text="Thêm môn mới" 
            onclick="btnCreateNews_Click" />
        <asp:Button ID="btnDelete" runat="server" Text="Xóa nhiều môn" />
        <asp:Label ID="lblThongBao" runat="server" Font-Size="10pt" ForeColor="Black" Visible="False"
            BackColor="#FFFF99" Font-Bold="True"></asp:Label>
    </div>
    <br />
    <table style="margin-left: 5px">
        <tr>
            <td  class="Sj_lable">
                Mã môn học (*):
            </td>
            <td  class="Sj_textbox">
                <asp:TextBox runat="server" Width="250px" ID="txtSubjectCode"></asp:TextBox>
            </td>
            <td class="Sj_lable">
                Tên môn học (*):
            </td>
            <td class="Sj_textbox">
                <asp:TextBox runat="server" Width="250px" ID="txtSubjectName"></asp:TextBox>
            </td>
            <td style="width:250px"></td>
        </tr>
        <tr>
            <td colspan="5">
                <div style="min-height: 300px; padding-top: 10px; width:970px; font:500 15px Arial">
                    <asp:GridView ID="grvSubject" runat="server" PageSize="20" AutoGenerateColumns="False"
                        Width="960px" AllowPaging="True" AllowSorting="True" 
                        HorizontalAlign="Center" onrowcommand="grvSubject_RowCommand" 
                        onrowdeleting="grvSubject_RowDeleting">
                        <RowStyle BackColor="#EFF3FB" />
                        <Columns>
                            <asp:TemplateField HeaderText="STT" HeaderStyle-HorizontalAlign="Center">
                                <ItemTemplate>
                                    <%# Container.DataItemIndex + 1 %>
                                </ItemTemplate>
                                <HeaderStyle HorizontalAlign="Center"></HeaderStyle>
                                <ItemStyle HorizontalAlign="Center" Width="40px" />
                            </asp:TemplateField>
                            <asp:BoundField DataField="SubjectID" HeaderText="Mã môn"
                                ItemStyle-HorizontalAlign="Center" HeaderStyle-HorizontalAlign="Center">
                                <HeaderStyle HorizontalAlign="Center"></HeaderStyle>
                                <ItemStyle HorizontalAlign="Center" Width="100px"></ItemStyle>
                            </asp:BoundField>
                            <asp:BoundField DataField="SubjectName" HeaderText="Tên môn"
                                ItemStyle-HorizontalAlign="Center" HeaderStyle-HorizontalAlign="Center" 
                                ItemStyle-Width="80px">
                                <HeaderStyle HorizontalAlign="Center"></HeaderStyle>
                                <ItemStyle HorizontalAlign="Center" Width="80px"></ItemStyle>
                            </asp:BoundField>
                            <asp:TemplateField HeaderText="Xóa">
                                <ItemTemplate>
                                    <asp:LinkButton ID="lbtDelete" runat="server" CommandArgument='<%#Eval("SubjectID")%>'
                                        CommandName="Delete" OnClientClick="return confirm('Bạn chắc chắn muốn xoá?')"><img 
                                                    height="20px" src="../../Images/LinkButton/thunggiac.png" style="border-style:none" 
                                                    width="20px" /></img></asp:LinkButton>
                                </ItemTemplate>
                                <HeaderStyle VerticalAlign="Middle" HorizontalAlign="Center" />
                                <ItemStyle VerticalAlign="Middle" HorizontalAlign="Center" Width="40px" />
                            </asp:TemplateField>
                        </Columns>
                        <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" Width="20px" />
                        <PagerStyle BackColor="#BFDBFF" ForeColor="Black" HorizontalAlign="Center" Width="20px" />
                        <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                        <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" VerticalAlign="Middle"
                            HorizontalAlign="Center" Height="30px" />
                        <EditRowStyle BackColor="#2461BF" />
                        <AlternatingRowStyle BackColor="White" />
                    </asp:GridView>
                </div>
            </td>
        </tr>
    </table>
    <div style="padding: 10px 10px; background-color: #BFDBFF;">
        <asp:Button ID="Button1" runat="server" Text="Thêm môn mới" />
        <asp:Button ID="Button2" runat="server" Text="Xóa nhiều nhiều" />
        <asp:Label ID="Label1" runat="server" Font-Size="10pt" ForeColor="Black" Visible="False"
            BackColor="#FFFF99" Font-Bold="True"></asp:Label>
    </div>
</div>
