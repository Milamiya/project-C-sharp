<%@ Page Language="C#" MasterPageFile="~/hello/Admin.master" AutoEventWireup="true" CodeFile="ListUsers.aspx.cs" Inherits="hello_Default2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
    .thongsosp
        {
        	width:777px;
        	height:220px;
        	border-top:1px solid #e99765;                    	
        	border-right:1px solid #e99765;                    	
        	border-bottom:1px solid #e99765; 
        	padding-top:20px;
        	padding-left:20px;                 	
        	float:left;        	
        	background-color:White;
        }          
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div style="margin-bottom:20px;margin-top:5px;">
        <br />
        <asp:Label ID="Label1" runat="server" Text=">>Danh sách user" 
        Font-Bold="True" Font-Size="Large" ForeColor="#CC0000"></asp:Label>
    </div>    
    <div class="thongsosp">    
    <asp:GridView ID="GridView1" runat="server" AllowPaging="True" 
        AutoGenerateColumns="False" DataKeyNames="UserName" 
        DataSourceID="SqlDataSource1" 
        Width="94%" Height="136px" BorderColor="#E99765">
        <Columns>
            <asp:BoundField DataField="UserName" HeaderText="Tên đăng nhập" ReadOnly="True" 
                SortExpression="UserName" />
            <asp:BoundField DataField="PassWord" HeaderText="Mật khẩu" 
                SortExpression="PassWord" />
            <asp:BoundField DataField="Role" HeaderText="Quyền" SortExpression="Role" />
            <asp:BoundField DataField="FullName" HeaderText="Họ tên" 
                SortExpression="FullName" />
            <asp:BoundField DataField="Birthday" HeaderText="Ngày sinh" 
                SortExpression="Birthday" />
            <asp:BoundField DataField="Email" HeaderText="Email" SortExpression="Email" />
            <asp:CommandField CancelText="Hủy" EditText="Sửa" HeaderText="Sửa" 
                ShowEditButton="True" UpdateText="Lưu" />
            <asp:CommandField DeleteText="Xóa" EditText="Xóa" HeaderText="Xóa" 
                ShowDeleteButton="True" />
        </Columns>
    </asp:GridView> 
    </div>        
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
        ConnectionString="<%$ ConnectionStrings:ConnectionString %>" 
        SelectCommand="SELECT * FROM [tbLogin]" 
        DeleteCommand="DELETE FROM tbLogin WHERE (UserName = @UserName)" 
        UpdateCommand="UPDATE tbLogin SET PassWord = @Password, Role = @Role, FullName = @FullName, Birthday = @Birthday, Email = @Email WHERE (UserName = @UserName)">
        <DeleteParameters>
            <asp:Parameter Name="UserName" />
        </DeleteParameters>
        <UpdateParameters>
            <asp:Parameter Name="Password" />
            <asp:Parameter Name="Role" />
            <asp:Parameter Name="FullName" />
            <asp:Parameter Name="Birthday" />
            <asp:Parameter Name="Email" />
            <asp:Parameter Name="UserName" />
        </UpdateParameters>
    </asp:SqlDataSource>
</asp:Content>

