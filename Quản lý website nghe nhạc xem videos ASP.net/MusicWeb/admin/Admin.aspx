<%@ Page Title="Tam anh music admin" Language="C#" MasterPageFile="~/admin/Master_Admin.master" AutoEventWireup="true" CodeFile="Admin.aspx.cs" Inherits="admin_Admin" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<div class="QuyDinh"> 
    <br />
    Quy Định Của Admin Ban Quản Trị Web Tam Anh</div>
<div class="NoiDungQuyDinh">
    <br />
BQT chỉ nhận sửa bài / xóa bài / khoá chủ đề / chuyển... / thay đổi tên đăng nhập (ID) theo yêu cầu của thành viên nếu có ảnh hưởng đến bản thân của thành viên đó hoặc có ảnh hưởng đến người khác. 
    <br />
    <br />
    BQT không được tự ý xóa user khi user không bị khóa hơn 12 tháng hoặc vi phạm 
    điều lệ web quá 3 lần.<br />
    <br />
    Nếu BQT không tuân thủ quy định trên quá 3 lần sẽ bị đình chỉ công tác.</div>
</asp:Content>

