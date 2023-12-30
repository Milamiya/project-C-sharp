<%@ Page Language="C#" MasterPageFile="~/UserControl/Admin.master" AutoEventWireup="true" CodeFile="SuaxoaLSP.aspx.cs" Inherits="GiaoDien_SuaxoaLSP" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<div>
<h3 style="text-align:center;padding-top:10px;padding-bottom:10px">
CẬP NHẬT THÔNG TIN LOẠI SẢN PHẨM
</h3>
</div>
    <script language="javascript" type="text/javascript">
function CheckAll(cb)
{
    var control=document.getElementsByTagName('input');
    for(i=0; i<control.length;i++)
    {
        var checkbox=control[i];
        if(checkbox.type=="checkbox")
        {
            checkbox.checked=cb.checked;
        }
    }
}

    </script>

    <asp:ScriptManager ID="ScriptManager1" runat="server">
    </asp:ScriptManager>
    <div style="width: 775px; float: right; margin-top: 5px">
        <div style="margin: 10px 0 8px 0; border-bottom: thin solid #FF82AB; padding: 0 0 8px 8px">
            <div style="margin-top: 10px">
                <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                    <ContentTemplate>
                        <asp:Repeater runat="server" ID="rptFirm" OnItemCommand="rptFirm_ItemCommand" 
                           >
                            <HeaderTemplate>
                                <table border="1" cellspacing="0" cellpadding="0">
                                    <tr>
                                        <td style=" width:35px;text-align:center">
                                            <asp:CheckBox runat="server" ID="ckCheckAll" OnClick="CheckAll(this)" />
                                        </td>
                                        <td style="text-align:">
                                            Mã loại sản phẩm
                                        </td>
                                        <td style="text-align:center;width:150px">
                                           Tên loại sản phẩm
                                        </td>
                                    </tr>
                            </HeaderTemplate>
                            <ItemTemplate>
                                <tr>
                                    <td style="text-align: center">
                                        <asp:CheckBox runat="server" ID="ckCkeck" />
                                    </td>
                                    <td>
                                        <asp:Label runat="server" ID="lbMaLSP" Text='<%#Eval("ProductGroupID") %>'></asp:Label>
                                    </td>
                                    <td>
                                        <asp:Label runat="server" ID="lbTenLSP" Text='<%#Eval("ProductGroupName") %>'></asp:Label>
                                        <asp:TextBox runat="server" ID="txtTenLSP" Text='<%#Eval("ProductGroupName") %>' Visible="false"></asp:TextBox>
                                    </td>
                                    <td style="width:50px">
                                        <asp:LinkButton runat="server" ID="lbtnEdit" Text="Edit" CommandName="EditThis"></asp:LinkButton>
                                        <asp:LinkButton runat="server" ID="lbtnCancel" Text="Cancel" Visible="false" CommandName="CancelThis"></asp:LinkButton>
                                        <asp:LinkButton runat="server" ID="lbtnSave" Text="Save" CommandName="SaveThis" Visible="false"></asp:LinkButton>
                                    </td>
                                   <td>
                                    <asp:ImageButton runat="server" ID="ibtnDelte" ImageUrl="~/Image/Icon/delete2.jpeg"
                                     Width="25px" OnClick="ibtnDelte_Click" />
                                    </td>
                                </tr>
                            </ItemTemplate>
                            <FooterTemplate>
                                </table>
                           </FooterTemplate>
                        </asp:Repeater>
                       <div style="text-align: center; margin: 20px">
                            Trang :
                            <asp:Label runat="server" ID="lbPageCurrent" Text='<%#Eval("PageCurrent") %>'></asp:Label>
                            /
                            <asp:Label runat="server" ID="lbPageSum" Text='<%#Eval("PageSum") %>'></asp:Label>
                            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                           <asp:LinkButton runat="server" ID="lbtnFirst" Text="First" ></asp:LinkButton>&nbsp;
                            <asp:LinkButton runat="server" ID="lbtnPrevius" Text="Previus" ></asp:LinkButton>&nbsp;
                            <asp:LinkButton runat="server" ID="lbtnNext" Text="Next" ></asp:LinkButton>&nbsp;
                            <asp:LinkButton runat="server" ID="lbtnLast" Text="Last" ></asp:LinkButton>&nbsp;
                        </div>
                    </ContentTemplate>
                    <%--<Triggers>
                    <asp:PostBackTrigger ControlID="lbtnSave" />
                </Triggers>--%>
                </asp:UpdatePanel>
            </div>
        </div>
        </div>
</asp:Content>

