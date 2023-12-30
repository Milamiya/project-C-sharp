<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Map.aspx.cs" Inherits="Default2" Title="Untitled Page" %>

<%@ Register Assembly="Artem.GoogleMap" Namespace="Artem.Web.UI.Controls" TagPrefix="cc2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<table style="width:100%; height: 623px;">
        <tr>
            <td align="left"  
                style="font-size: 16px; font-weight: bold; color: #AE1504">                
                Bản đồ dẫn đường
            </td>
        </tr>
        <tr>            
            <td >
                <cc2:GoogleMap EnableScrollWheelZoom="true" ID="GoogleMap1" runat="server" Zoom="15" Width="100%" Height="500px" Latitude="20.965081409624027" Longitude="105.77995598316193"  Language="vi" Key="ABQIAAAAqRnFVryMM-2NGFDxgscheRQ6T9kD5fledREBp39_iAxfQqoR2BTtg4W2AqF1k7bl84cgjgcglgVS0w">
                <Markers>          
                <cc2:GoogleMarker Text="<h4> Siêu thị máy tính 3T</h4><h5> Địa chỉ : Hà Trì - Hà Cầu - Hà Nội<br/>Điện thoại: 04 33553355 - Fax: 04 33554862 - Email:truongnt90@gmail.com</h5>" Draggable="true">                
                </cc2:GoogleMarker>
                </Markers>
                </cc2:GoogleMap>                           
            </td>
        </tr> 
</table>         
</asp:Content>

