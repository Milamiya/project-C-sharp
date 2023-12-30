<%@ Page Language="C#" MasterPageFile="~/QuanTri.master" AutoEventWireup="true" CodeFile="QuanLyKhuyenMai.aspx.cs" Inherits="QuanLyKhuyenMai" Title="Untitled Page" %>





<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <asp:ScriptManager ID="ScriptManager1" runat="server">
    </asp:ScriptManager>
    <script language="javascript">
    
 
  function checkall()
  {
  var frm=document.forms[0];
  var i = 0;
for (i = 0; i < frm.length; i++)
 {
if (frm.elements[i].id.indexOf('chkApDung') != -1)
 {
if (document.getElementById(frm.elements[i].id) != null) 
{
var chkapdunghd=document.getElementById('chkApDunghd');
if(chkapdunghd.checked==true)
{
frm.elements[i].checked = true;

} 
else
 {
frm.elements[i].checked = false;
}
 
  }
  }
  }
  }

</script>
 <div id="tieudenhap">
 <p  class="p" align="center">
        <b>&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp QUẢN LÝ KHUYẾN MẠI</b></p>
</div>
<div id="Nhap"  style="height:auto">
<div id="eror" style="margin-top:10px">
<table id="tberor">
<tr>

    <td>&nbsp;</td>
    
    <td><asp:CustomValidator ID="CustomValidator1" runat="server" ErrorMessage="CustomValidator"></asp:CustomValidator></td>
</tr>
<tr>
    <td><asp:CustomValidator ID="CustomValidator2" runat="server" ErrorMessage="CustomValidator"></asp:CustomValidator></td>

    <td><asp:CustomValidator ID="CustomValidator3" runat="server" ErrorMessage="CustomValidator"></asp:CustomValidator></td>
</tr>
<tr>
    <td><asp:CustomValidator ID="CustomValidator4" runat="server" ErrorMessage="CustomValidator"></asp:CustomValidator></td>
    
   <td> <asp:CustomValidator ID="CustomValidator5" runat="server" ErrorMessage="CustomValidator"></asp:CustomValidator></td>
 </tr>
    </table>
    </div>
   <table id="TTNhap" style="font-weight: bold; text-align:right; margin-left:10px;">
     <tr>
      <td>Mã khuyến mại:</td>
      <td class="khoangcach"></td>
      <td> 
          <asp:TextBox ID="txtMaKhuyenMai" runat="server" Enabled="False" Width="180px"></asp:TextBox>
                                </td>
             <td style="width: 103px">&nbsp;</td>
      
     </tr>
     <tr>
      <td>Tên khuyến mại:</td>
      <td class="khoangcach"></td>
      <td> 
          <asp:TextBox ID="txtTenKhuyenMai" runat="server" Width="180px"></asp:TextBox>
         </td>
       <td style="width: 103px">Ngày bắt đầu:</td>
       <td class="khoangcach" style="width: 5px"></td>
       <td style="width: 94px"> 
           <asp:TextBox ID="txtNgayBatDau" runat="server" Width="180px"></asp:TextBox>
                                </td>
      
     </tr>
     <tr>
     <td>Giá cần giảm:</td>
     <td class="khoangcach"></td>
     <td>
     <asp:TextBox ID="txtGiaCanGiam" runat=server Width="180px"></asp:TextBox>
     </td>
     <td>Ngày kết thúc:</td>
     <td class="khoangcach"></td>
      <td>
     <asp:TextBox ID="txtNgayKetThuc" runat=server Width="180px"></asp:TextBox>
     </td>
     
     </tr>
        <tr>
          <td>Nội dung khuyến mại:</td>
          <td class="khoangcach"></td>
         <td> <asp:TextBox ID="txtNoiDungKhuyenMai" Width="180px" Height="100px" 
                 runat=server ></asp:TextBox></td>
     
         <td style="width: 103px">&nbsp;<br />
                                </td>
         <td class="khoangcach" style="width: 5px"></td>
         <td style="width: 94px">&nbsp;</td>
     </tr>
          
   
   </table>
<hr />&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp
<asp:Button ID="btnNhap" Text="Nhập" Width="80px"  runat="server" onclick="btnNhap_Click" 
        /> &nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp<asp:Button 
        ID="btnSua" Text="Sửa"   OnClientClick="Chon()"  onclick="btnSua_Click" runat="server" Width="80px" 
         />
&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp<asp:Button ID="btnXoa" Text="Xóa" Width="80px" 
        runat="server" onclick="btnXoa_Click"  />
&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp<asp:Button ID="Button1" Text="Làm mói" 
        Width="80px" runat="server"  />
<hr />
<div id="tieudevuanhap">
<p  class="p" align="center">
        <b>SẢN PHẨM ĐƯỢC KHUYẾN MÃI</b> </p>
       
</div>
<div id="sanphamvuanhap" style="height:338px">

    <asp:LinqDataSource ID="LinqDataSource3" runat="server" 
        ContextTypeName="WedMayTinhDataContext" Select="new (MaSanPham, TenSP)" 
        TableName="SanPhams">
    </asp:LinqDataSource>

   <asp:GridView ID="GridView3" 
        style="margin-top:10px; margin-left:5px; text-align:center" runat="server" 
        Width="739px"   AllowPaging="True" 
        AllowSorting="True" 
        AutoGenerateColumns="False" DataSourceID="LinqDataSource3" 
     
        onrowdatabound="GridView3_RowDataBound" 
        onpageindexchanged="GridView3_PageIndexChanged1" 
        onselectedindexchanged="GridView3_SelectedIndexChanged" >
        <RowStyle  ForeColor='#000066' />
            <Columns>
            <asp:TemplateField>
            <HeaderTemplate>
            <asp:CheckBox ID="chkApDunghd" Text="Áp dụng" AutoPostBack="true" runat="server" OnCheckedChanged="chkApDunghd_OnCheckedChanged"  />
         
            </HeaderTemplate>
           <ItemTemplate>
           <asp:CheckBox ID="chkApDung" runat="server" />
           </ItemTemplate>
            </asp:TemplateField>
            <asp:BoundField DataField="MaSanPham" HeaderText="Mã sản phẩm" />
    <asp:BoundField DataField="TenSP" HeaderText="Tên sản phẩm" />
    </Columns>

        
        <HeaderStyle BackColor="#000066" ForeColor="White" />

        
    </asp:GridView>



</div>
<div id="tieudetatcasanpham" >
<p  class="p" align="center">
        <b>&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp DANH SÁCH KHUYẾN MẠI </b></p></div>

<div id="tatcasanpham"  style="height:auto">

   
    <asp:GridView style="margin-top:10px; margin-left:5px; text-align:center" 
        ID="GridView2" runat="server" Width="739px" AutoGenerateColumns="False" 
        AllowPaging="True" AllowSorting="True" PageSize="3" 
          PagerStyle-HorizontalAlign="Center" 
        DataSourceID="LinqDataSource2" DataKeyNames="MaKhuyenMai" 
        onselectedindexchanged="GridView2_SelectedIndexChanged" >
<PagerSettings Mode="NumericFirstLast"></PagerSettings>
<RowStyle  ForeColor='#000066' />
    <Columns>
    <asp:BoundField DataField="MaKhuyenMai" HeaderText="Mã khuyến mại" ReadOnly="True" 
           />
                <asp:BoundField DataField="TenKhuyenMai" HeaderText="Tên khuyến mại" 
            />
    <asp:BoundField DataField="NoiDungKhuyenMai" HeaderText="Nội dung" 
           />
    <asp:BoundField DataField="NgayBatDau" HeaderText="Ngày bắt đầu" 
            />
    <asp:BoundField DataField="NgayKetThuc" HeaderText="Ngày kết thúc" 
           />

    <asp:BoundField DataField="NgayTao" HeaderText="Ngày tạo"  />
        <asp:BoundField DataField="GiaCanGiam" HeaderText="Giá cần giảm" 
           />
            
    <asp:CommandField HeaderText="Chọn"  SelectText="Chọn" ShowSelectButton="true"/>
    </Columns>

<PagerStyle HorizontalAlign="Center"></PagerStyle>
        <HeaderStyle BackColor="#000066" ForeColor="White" />
    </asp:GridView>

   
    <asp:LinqDataSource ID="LinqDataSource2" runat="server" 
        ContextTypeName="WedMayTinhDataContext" TableName="KhuyenMais">
    </asp:LinqDataSource>

   
    </div>
</div>

</asp:Content>

