<%@ Page Language="C#" MasterPageFile="~/hello/Admin.master" AutoEventWireup="true" CodeFile="NewsEdit.aspx.cs" Inherits="hello_Default" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>

<%@ Register assembly="FredCK.FCKeditorV2" namespace="FredCK.FCKeditorV2" tagprefix="FCKeditorV2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
     <style type="text/css">
        .style1
        {
            width: 87px;
        }
        .thongsosp
        {
        	width:794px;        	
        	border-top:1px solid #e99765;                    	
        	border-right:1px solid #e99765;   
            border-left:1px solid #e99765;   
        	border-bottom:1px solid #e99765;                    	
        	float:left;        	
        	background-color:White;
        }
    .style2
    {
        width: 689px;
    }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
     <div style="margin-bottom:20px;margin-top:5px;">
         <br />
         <div>
            <asp:Label ID="Label1" runat="server" Text=">>Cập nhật tin" 
            Font-Bold="True" Font-Size="Large" ForeColor="#CC0000"></asp:Label>
        </div>         
             <div style="float:left;padding-left:50px;margin-bottom:10px; width: 704px;">
                Tìm tiêu đề 
                 <asp:DropDownList ID="ddlTieuDe" runat="server" 
                    Width="300px" DataSourceID="SqlDataSource1" DataTextField="Title" 
                    DataValueField="NewsID" AutoPostBack="true" 
                    onselectedindexchanged="DropDownList1_SelectedIndexChanged" >                
                </asp:DropDownList>
                &nbsp;&nbsp; Ngày đăng<i>(mm/dd/yyyy)</i>
                 <asp:DropDownList ID="ddlNgayDang" runat="server" 
                     DataSourceID="SqlDataSource2" DataTextField="Created" 
                     DataValueField="Created" AutoPostBack="True" 
                     onselectedindexchanged="DropDownList2_SelectedIndexChanged">
                 </asp:DropDownList>
                 <asp:SqlDataSource ID="SqlDataSource2" runat="server" 
                     ConnectionString="<%$ ConnectionStrings:ConnectionString %>" 
                     SelectCommand="SELECT [Created] FROM [tbNews] ORDER BY [Created] DESC">
                 </asp:SqlDataSource>                 
                <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
                    ConnectionString="<%$ ConnectionStrings:ConnectionString %>" 
                    SelectCommand="SELECT * FROM [tbNews] ORDER BY [Created] DESC">
                </asp:SqlDataSource>
            </div>                               
        <table class="thongsosp">
            <tr>
                <td style="height:10px;"></td>
            </tr> 
            <tr>
                <td class="style1">
                Loại tin:</td>
                <td class="style2">
                    <asp:DropDownList ID="ddlLoaiTin" runat="server" Height="20px" 
                        Width="140px">
                    </asp:DropDownList>                                    
                </td>
            </tr>   
            <tr>
                <td class="style1">
                    Tiêu đề tin:</td>
                <td class="style2">
                    <asp:TextBox ID="txtTieuDe" runat="server" Width="627px" Height="24px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style1">
                    Mô tả:</td>
                <td class="style2">
                    <FCKeditorV2:FCKeditor ID="FCKMota" runat="server" BasePath="~/FCKeditor/" 
                        ToolbarSet="EditorSimple" Height="150px" 
                       >
                    </FCKeditorV2:FCKeditor>
                </td>
            </tr>
            <tr>
                <td class="style1">
                    Nội dung:</td>
                <td class="style2">
                    <FCKeditorV2:FCKeditor ID="FCKNoiDung" runat="server" BasePath="~/FCKeditor/" 
                        ToolbarSet="hmweb" Height="300px">
                    </FCKeditorV2:FCKeditor>
                </td>
            </tr>
            <tr>
                <td class="style1">
                    Ngày đăng:</td>
                <td class="style2">
                    Ngày
                    <asp:DropDownList ID="ddlDay" runat="server" Height="24px" Width="50px">
                        <asp:ListItem>--</asp:ListItem>
                        <asp:ListItem>1</asp:ListItem>
                        <asp:ListItem>2</asp:ListItem>
                        <asp:ListItem>3</asp:ListItem>
                        <asp:ListItem>4</asp:ListItem>
                        <asp:ListItem>5</asp:ListItem>
                        <asp:ListItem>6</asp:ListItem>
                        <asp:ListItem>7</asp:ListItem>
                        <asp:ListItem>8</asp:ListItem>
                        <asp:ListItem>9</asp:ListItem>
                        <asp:ListItem>10</asp:ListItem>
                        <asp:ListItem>11</asp:ListItem>
                        <asp:ListItem>12</asp:ListItem>
                        <asp:ListItem>13</asp:ListItem>
                        <asp:ListItem>14</asp:ListItem>
                        <asp:ListItem>15</asp:ListItem>
                        <asp:ListItem>16</asp:ListItem>
                        <asp:ListItem>17</asp:ListItem>
                        <asp:ListItem>18</asp:ListItem>
                        <asp:ListItem>19</asp:ListItem>
                        <asp:ListItem>20</asp:ListItem>
                        <asp:ListItem>21</asp:ListItem>
                        <asp:ListItem>22</asp:ListItem>
                        <asp:ListItem>23</asp:ListItem>
                        <asp:ListItem>24</asp:ListItem>
                        <asp:ListItem>25</asp:ListItem>
                        <asp:ListItem>26</asp:ListItem>
                        <asp:ListItem>27</asp:ListItem>
                        <asp:ListItem>28</asp:ListItem>
                        <asp:ListItem>29</asp:ListItem>
                        <asp:ListItem>30</asp:ListItem>
                        <asp:ListItem>31</asp:ListItem>
                    </asp:DropDownList>
        &nbsp;
                    Tháng
                    <asp:DropDownList ID="ddlMonth" runat="server" Height="24px" Width="50px">
                        <asp:ListItem>--</asp:ListItem>
                        <asp:ListItem>1</asp:ListItem>
                        <asp:ListItem>2</asp:ListItem>
                        <asp:ListItem>3</asp:ListItem>
                        <asp:ListItem>4</asp:ListItem>
                        <asp:ListItem>5</asp:ListItem>
                        <asp:ListItem>6</asp:ListItem>
                        <asp:ListItem>7</asp:ListItem>
                        <asp:ListItem>8</asp:ListItem>
                        <asp:ListItem>9</asp:ListItem>
                        <asp:ListItem>10</asp:ListItem>
                        <asp:ListItem>11</asp:ListItem>
                        <asp:ListItem>12</asp:ListItem>
                    </asp:DropDownList>
        &nbsp;&nbsp;
                    Năm
                    <asp:DropDownList ID="ddlYear" runat="server" Height="24px" Width="70px">
                        <asp:ListItem>--</asp:ListItem>
                        <asp:ListItem>2010</asp:ListItem>
                        <asp:ListItem>2011</asp:ListItem>
                        <asp:ListItem>2012</asp:ListItem>
                        <asp:ListItem>2013</asp:ListItem>
                        <asp:ListItem>2014</asp:ListItem>
                        <asp:ListItem>2015</asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td style="height:4px;"></td>
            </tr>
            <tr>
                <td class="style1">
                    Người đăng:</td>
                <td class="style2">
                    <asp:TextBox ID="txtNguoiDang" runat="server" Width="290px" Height="24px"></asp:TextBox>
                </td>
            </tr>
            
            <tr>
                <td style="height:20px;"></td>
            </tr>
            <tr>
                <td colspan="2" style="text-align:center;">
                    <asp:Button ID="btLuu" runat="server" Text="Lưu tin" Width="75px" Height="29px" OnClientClick="confirm('Bạn có chắc chắn muốn thay đổi không?')" 
                        onclick="btLuu_Click" />
                </td>
            </tr>
            <tr>                
                <td style="height:10px;"></td>
            </tr>
        </table>              
</div>        
    </asp:Content>

