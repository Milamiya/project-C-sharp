<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ucCategories.ascx.cs" Inherits="TestOnline.hy.vn.Control.Manager.ucCategories" %>
<style type="text/css">
    .style1
    {
        width: 356px;
    }
    .style2
    {
        width: 180px;
    }
    .ucCategory_lable
    {
    	 font: 500 15px Arial;
        padding-right: 5px;
        text-align:left;
        width:120px;
    	}
</style>
<div style="border:solid 5px #3366CC">
<br />
<table style="height: 135px; margin-left:5px">
        <tr>
           
            <td class="ucCategory_lable">Mã thể loại(*): </td>
            <td><asp:TextBox runat="server" ID="txtCategorID" Width="219px"></asp:TextBox></td>
            <td class="ucCategory_lable">Vị trí thể loại: </td>
            <td class="style1"><asp:TextBox runat="server" ID='txtCategoriOrder' Width="222px"></asp:TextBox> </td>
        </tr>
        
       
         <tr>
            <td class="ucCategory_lable">Tên thể loại(*): </td>
            <td class="style2" colspan="3"><asp:TextBox runat="server" ID="txtCategoriName" Width="575px"></asp:TextBox> </td>
            
        </tr>
        <tr>
            <td class="ucCategory_lable">Mô tả</td>
            <td colspan="3"><asp:TextBox runat="server" ID='txtDiscriptio' Width="575px"></asp:TextBox> </td>
        </tr>
        <tr>  
        <td></td>
          <td style="margin-left: 40px">
              <asp:Button runat="server" ID="btnTaomoi" Text="Tạo mới" 
                Width="90px" onclick="btnTaomoi_Click"/>&nbsp<asp:Button runat="server" ID="btnThem" Text="Thêm" 
                Width="90px" onclick="btnThem_Click"/><asp:Label runat="server" ID="lblThongBao"></asp:Label>
        </td>
        </tr>
</table>
<table style="font:500 15px Arial; margin-left:5px">
        <tr>
        <td>
            <asp:GridView ID="grvHinhThuc" 
               runat="server" PageSize="20" AutoGenerateColumns="False"
                        Width="960px" AllowPaging="True" AllowSorting="True" 
                        HorizontalAlign="Center" onrowcommand="grvHinhThuc_RowCommand" 
                onrowdeleting="grvHinhThuc_RowDeleting">
                        <RowStyle BackColor="#EFF3FB" />
                <Columns>
                    <asp:BoundField DataField="CategoryID" HeaderText="Mã hình thức" />
                    <asp:BoundField DataField="CategoryName" HeaderText="Tên hình thức" />
                    <asp:BoundField DataField="CategoryOrder" HeaderText="Vị trí" />
                    <asp:BoundField DataField="Description" HeaderText="Mô tả" />
                    <asp:TemplateField HeaderStyle-Width="30px" HeaderText="Xóa">
                    <ItemTemplate>
                        <asp:LinkButton ID="btnXoa" runat="server" CommandArgument='<%#DataBinder.Eval(Container.DataItem,"CategoryID")%>'
                            CommandName="Delete" ToolTip="Xóa bản ghi" OnClientClick="return confirm('Bạn chắc chắn muốn xoá?')">  
                            <img  height="20px" src="../../Images/LinkButton/thunggiac.png" style="border-style:none ; text-align :center ;"  
                                                    width="20px"  /> </img></asp:LinkButton>
                    </ItemTemplate>
                    <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                    <HeaderStyle Width="40px" HorizontalAlign="Center" />
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
        </td>
        </tr>
</table>
<br />
</div>