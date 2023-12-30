<%@ Page Title="PKT Phone | Chi Tiết" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="chitiet_sp.aspx.cs" Inherits="PKT.chitie_sp" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
    <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
<asp:Repeater ID="Chitiet" runat="server" onitemcommand="Chitiet_ItemCommand">
    <ItemTemplate>
        <div id="ct1">
            <div id="ct1-1">
                <img src="<%# Eval("HinhAnh") %>"/>
            </div>
            <div id="ct1-2">
		        <p1><%# Eval("TenSP") %></p1>
                <p2><br><%#Eval("GiaBan","{0:0,000 VNĐ}") %></p2>  
                <asp:hyperlink id="link" runat="server"><img src="Img/Images/icon/images.jpg" width="29px" height="20px" /> 
                        Bỏ vào giỏ hàng</asp:hyperlink> . <asp:Label ID="slt" runat="server" ForeColor="Red"></asp:Label>
            </div>
            <div><img src="Img/Images/mmm.png"/></div> 
        </div>
        <div id="ct2">
	        <div id="ct2-2">
                <%# Eval("NoiBat") %>
            </div>
            <div><img src="Img/Images/mmm1.png"/></div> 
        </div>
        <div id="ct2">
            <div id="ct2-1">
                Máy ảnh 	                 	
                <br>Máy ảnh phụ                                                                   
                <br>Quay phim                           
                <br>Xem phim
                <br>Nghe nhạc                                                           
                <br>FM radio  
                <br>Ghi âm
                <br>Trò chơi
                <br>Java
                <br>Ứng dụng khác
            </div>
            <div id="ct2-2">	
                <%# Eval("CT1") %>                           
                <br><%# Eval("CT2") %>                               
                <br><%# Eval("CT3") %>                              
                <br><%# Eval("CT4") %>                               
                <br><%# Eval("CT5") %>                                
                <br><%# Eval("CT6") %>                               
                <br><%# Eval("CT7") %>                                
                <br><%# Eval("CT8") %>
                <br><%# Eval("CT9") %>                                            
                <br><%# Eval("CT10") %>
            </div>
            <div><img src="Img/Images/mmm2.png"/></div> 
        </div>
        <div id="ct2">
            <div id="ct2-1"> 
                Bộ nhớ trong                  	
                <br>RAM                                                                                           
                <br>Vi xử lý CPU                                                                                
                <br>Thẻ nhớ ngoài                                                                                                         
                <br>Hỗ trợ thẻ tối đa
            </div>
            <div id="ct2-2">
                <%# Eval("CT11") %>                              
                <br><%# Eval("CT12") %>                               
                <br><%# Eval("CT13") %>                              
                <br><%# Eval("CT14") %>                               
                <br><%# Eval("CT15") %>
            </div>   
            <div><img src="Img/Images/mmm3.png"/></div>       
        </div>
        <div id="ct2">
            <div id="ct2-1"> 
                Băng tần 2G                 	             	
                <br>Băng tần 3G                                                                                                                                                                                     
                <br>Hỗ trợ đa SIM                                                                                               
                <br>GPRS                                                                                                                                                                                                                                                                                                                                 
                <br>Wifi                                                                                                                                                                 
                <br>Bluetooth                                                                                                                             
                <br>USB                              
                <br>GPS                            
            </div>
            <div id="ct2-2">
                <%# Eval("CT16") %>                                
                <br><%# Eval("CT17") %>                                
                <br><%# Eval("CT18") %>                               
                <br><%# Eval("CT19") %>                               
                <br><%# Eval("CT20") %>                               
                <br><%# Eval("CT21") %>                               
                <br><%# Eval("CT22") %>                               
                <br><%# Eval("CT23") %>
            </div>   
            <div><img src="Img/Images/mmm4.png"/></div>       
        </div>
        <div id="ct3">
            <div id="ct2-1"> 
                Hệ điều hành                              
                <br>Kiểu dáng                              
                <br>Bàn phím                                                                                                                                             
                <br>Kích thước                                                                                                                                             
                <br>Trọng lượng (g)                                                                                                                                           
                <br>Ngôn ngữ                                                     
            </div>
            <div id="ct2-2">
                <%# Eval("CT24") %>                           
                <br><%# Eval("CT25") %>                              
                <br><%# Eval("CT26") %>                               
                <br><%# Eval("CT27") %>                              
                <br><%# Eval("CT28") %>                              
                <br><%# Eval("CT29") %>
            </div>      
        </div>
    </ItemTemplate>
</asp:Repeater>
    
</asp:Content>
