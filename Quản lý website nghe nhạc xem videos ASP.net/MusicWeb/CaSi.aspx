<%@ Page Title="Tam anh music" Language="C#" MasterPageFile="~/Master_Home.master" AutoEventWireup="true" CodeFile="CaSi.aspx.cs" Inherits="CaSi" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<div>
<div class="CaSi_Left">
<asp:DataList ID="NgheSi__" runat="server" Width="100%" RepeatColumns="1">
        <ItemTemplate>
        <div class="thongtincasi">
                        <asp:ImageButton ID="ImageButton1" runat="server" Height="120px" 
                            ImageUrl='<%# "~/img_Casi/"+Eval("HinhAnh") %>' 
                            PostBackUrl='<%#Eval("MaCaSi","~/CaSi.aspx?C={0}") %>' Width="250px" />
        </div>
        <div class="thongtincasi"> Tên :
                        <asp:HyperLink ID="cl2" runat="server" 
                            Text='<%# Eval("TenCaSi") %>'></asp:HyperLink>
        </div>
        <div class="thongtincasi"> Tên Thật :
                        <asp:HyperLink ID="HyperLink2" runat="server"                            
                            Text='<%# Eval("TenThat") %>'></asp:HyperLink>
        </div>
        <div class="thongtincasi"> Ngày Sinh :
                        <asp:HyperLink ID="HyperLink3" runat="server"  
                            Text='<%# Eval("NgaySinh") %>'></asp:HyperLink>
        </div>
        <div class="thongtincasi"> Quốc Tịch :
                        <asp:HyperLink ID="HyperLink4" runat="server" 
                            Text='<%# Eval("QuocTich") %>'></asp:HyperLink>
        </div>
        <div class="thongtincasi">Giới Thiệu :
                        <asp:HyperLink ID="HyperLink5" runat="server" 
                            Text='<%# Eval("GioiThieu") %>'></asp:HyperLink>
        </div>
        </ItemTemplate>
    </asp:DataList>
</div>
<div class="CaSi_Right">
<asp:DataList ID="Video__" runat="server" Width="100%" RepeatColumns="2">
        <ItemTemplate>
            <asp:ImageButton ID="ImageButton1" runat="server" Height="120px" 
                        ImageUrl='<%# "~/img_video/"+Eval("Hinh") %>' 
                        PostBackUrl='<%#Eval("MaVideo","~/Play_Video.aspx?V={0}") %>' 
                        Width="250px"/>
                <br />
                <asp:HyperLink ID="cl2" runat="server" 
                    NavigateUrl='<%# Eval("MaVideo","~/Play.aspx?V={0}") %>' 
                    Text='<%# Eval("TenVideo") %>'></asp:HyperLink>
                <br />
            <asp:Label ID="Label1" runat="server" Text='<%# Eval("TenCaSi") %>'></asp:Label>
                <br />
        </ItemTemplate>
    </asp:DataList>
    <div>
        <img src="img_button/trang.jpg"  width="100%"/></div>
<asp:DataList ID="DataList1" RepeatColumns="1" runat="server" Width="100%" >
                        <ItemTemplate>
                            <div class="Ca_Khuc_LienQuan" align="left">
                                
                                <asp:HyperLink  ID="Lienquan" runat="server" 
                                    NavigateUrl='<%#Eval("MaBaiHat","~/Play.aspx?M={0}") %>' 
                                    Text='<%#Eval("TenBaiHat") %>'></asp:HyperLink>
                                    
                              
                                <asp:Image ID="Image2" runat="server" ToolTip="Thêm vào danh sách" ImageUrl="~/img_button/icon-add.gif" />
                                &nbsp;&nbsp;
                                
                                <asp:HyperLink ID="HyperLink1" ToolTip="Tải về máy tính của bạn" runat="server" >                                    
                                <asp:Image ID="Image3" runat="server" 
                                    ImageUrl="~/img_button/iconDowload.gif" />
                                    </asp:HyperLink>
                                    &nbsp;&nbsp;
                                    <asp:HyperLink ID="Lienq" runat="server" 
                                    NavigateUrl='<%#Eval("MaBaiHat","~/Play.aspx?M={0}") %>' ToolTip="Nghe ca khúc này">
                                    <asp:Image ID="Image1" runat="server" ImageUrl="~/img_button/icon-ngheNhac.gif" />
                                    </asp:HyperLink>
                                     &nbsp;&nbsp;
                                    <asp:Image ID="Image4" runat="server" ToolTip="Lời bài hát" ImageUrl="~/img_button/icon-paper.gif" />
                               
                                    <br />
                                    Trình bày:
                                <asp:Label ID="Label2" CssClass="Ten_Rieng" runat="server" Text='<%#Eval("TenCaSi")%>'></asp:Label>&nbsp;&nbsp;|&nbsp;
                                    Thể loại:
                                <asp:Label ID="Label3" CssClass="Ten_Rieng" runat="server" Text='<%#Eval("TenTheLoai")%>'></asp:Label>
                                    
                            </div>
                            <hr />
                        </ItemTemplate>
                    </asp:DataList>
</div>
</div>
</asp:Content>

