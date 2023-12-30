<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ucDeThiDaiHoc.ascx.cs"
    Inherits="TestOnline.hy.vn.Control.menuleft.ucDeThiDaiHoc" %>
<style type="text/css">
    .LI_Khung1_DH
    {
        width: 215px;
        height: 149px;
        border: solid 1px gray;
        border-bottom-left-radius: 6px;
        border-bottom-right-radius: 6px;
        color:Blue;
        font:500 13px Arial;
    }
    .LI_Head1_DH
    {
    	margin-top:15px;
        width: 217px;
        background-image: url('../Images/Control/ucMenuLeft/left_heading_img.jpg' );
        height: 37px;
        text-align: center;
        color: White;
    }
    .DH_Item
    {
    	background-image:url('../Images/gelbuttoncenter4.gif');
    	background-repeat:repeat-x;
    	width:215px;
    	height:37px;
    	}
    	.color_item
    	{
    		color:Blue;
    		text-decoration:none;
    		}
.color_item:hover
    	{
    		color:red;
    		}
</style>
<div class="LI_Head1_DH">
    <p style="padding-top: 10px; color: White; width: 215px; height: auto">
        Đề thi đại học & cao đẳng</p>
</div>
<div class="LI_Khung1_DH">
    <asp:Repeater runat="server" ID="rpt2">
        <ItemTemplate>
            <div class="DH_Item">
              <div style="padding-top:13px">  <a href='<%# "HomeTest.aspx?threadid=" + Eval("ThreadsID")%>' class="color_item"style="padding-top:20px">
                    <%#Eval("TheadName")%></a>
                    </div>
            </div>
        </ItemTemplate>
    </asp:Repeater>
</div>
